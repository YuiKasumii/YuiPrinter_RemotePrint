Imports System.IO
Imports System.Drawing.Printing
Imports PdfiumViewer
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Timers
Imports System.Text
Imports System.Net.NetworkInformation

Public Class Form1
    Private refreshTimer As Timer
    Private firstLoad As Boolean = True

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cek jika instance aplikasi sudah berjalan
        If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
            MessageBox.Show("Aplikasi sudah berjalan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Return
        End If

        ' Inisialisasi NotifyIcon
        Me.YuiNotify.Visible = True
        AddHandler Me.YuiNotify.DoubleClick, AddressOf NotifyIcon_DoubleClick

        ' Mengisi ComboBox CbPaperDef
        CbPaperDef.Items.AddRange(New String() {"A4", "F4", "A5"})

        ' Mengisi ComboBox CbOrientationDef
        CbOrientationDef.Items.AddRange(New String() {"portrait", "landscape"})

        ' Mengisi ComboBox CbPrinterDef dan CbPrinterCurrent dengan daftar printer
        GetConfigurationComputer()

        ' Mengisi ComboBox CbPaperCurrent dengan pilihan yang sama dari CbPaperDef
        CbPaperCurrent.Items.AddRange(CbPaperDef.Items.Cast(Of String).ToArray())

        ' Mengisi ComboBox CbOrientationCurrent dengan pilihan yang sama dari CbOrientationDef
        CbOrientationCurrent.Items.AddRange(CbOrientationDef.Items.Cast(Of String).ToArray())

        ' Memuat konfigurasi dari file config.ini
        LoadConfiguration()

        ' Mengatur ComboBox "Current" dengan nilai default dari ComboBox "Def"
        CbPrinterCurrent.SelectedIndex = CbPrinterDef.SelectedIndex
        CbPaperCurrent.SelectedIndex = CbPaperDef.SelectedIndex
        CbOrientationCurrent.SelectedIndex = CbOrientationDef.SelectedIndex

        ' Mengecek status startup
        CheckStartupStatus()

        ' Load data async
        Await LoadDataAsync()

        ' Inisialisasi dan atur timer untuk refresh otomatis
        InitializeRefreshTimer()

        ' Tambahkan event handler untuk TxtVoucher.TextChanged
        AddHandler TxtVoucher.TextChanged, AddressOf TxtVoucher_TextChanged
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If firstLoad Then
            firstLoad = False
            Me.Hide()
        End If
    End Sub
    Private Sub NotifyIcon_DoubleClick(sender As Object, e As EventArgs)
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.YuiNotify.Visible = False
    End Sub

    Private Sub BtnHideToTray_Click(sender As Object, e As EventArgs) Handles BtnHideToTray.Click
        Me.Hide()
        Me.YuiNotify.Visible = True
    End Sub

    Private Sub InitializeRefreshTimer()
        If refreshTimer Is Nothing Then
            refreshTimer = New Timer()
            AddHandler refreshTimer.Elapsed, AddressOf OnTimedEvent
        End If

        ' Atur interval timer berdasarkan NudRefresh
        SetRefreshInterval()
    End Sub

    Private Sub SetRefreshInterval()
        If refreshTimer IsNot Nothing Then
            Dim interval As Integer = CInt(NudRefresh.Value)
            If interval > 0 Then
                refreshTimer.Interval = interval * 1000 ' Convert to milliseconds
                refreshTimer.Start()
            Else
                LogError("Invalid refresh interval. Please enter a valid number of seconds.")
            End If
        End If
    End Sub

    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf RefreshData))
        Else
            RefreshData()
        End If
    End Sub

    Private Async Sub RefreshData()
        If CBoxAutoURL.Checked Then
            Await GetServerURLFromIP()
            TxtServerURL.Enabled = False
        Else
            TxtServerURL.Enabled = True
        End If
        Await LoadDataAsync()
    End Sub
    Private Async Function GetServerURLFromIP() As Task
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync("######")
                response.EnsureSuccessStatusCode()

                Dim ip As String = Await response.Content.ReadAsStringAsync()
                TxtServerURL.Text = $"http://{ip.Trim()}/eprinter"
            End Using
        Catch ex As Exception
            LogError("Error fetching IP from #########: " & ex.Message)
        End Try
    End Function
    Private Sub NudRefresh_ValueChanged(sender As Object, e As EventArgs) Handles NudRefresh.ValueChanged
        SetRefreshInterval()
    End Sub

    Private Sub GetConfigurationComputer()
        ' Mendapatkan daftar printer yang terhubung
        For Each printer As String In PrinterSettings.InstalledPrinters
            CbPrinterDef.Items.Add(printer)
            CbPrinterCurrent.Items.Add(printer)
        Next

        ' Pilihan pertama sebagai default
        If CbPrinterDef.Items.Count > 0 Then
            CbPrinterDef.SelectedIndex = 0
        End If

        If CbPrinterCurrent.Items.Count > 0 Then
            CbPrinterCurrent.SelectedIndex = 0
        End If

        ' Pilihan pertama sebagai default untuk orientation
        If CbOrientationDef.Items.Count > 0 Then
            CbOrientationDef.SelectedIndex = 0
        End If

        If CbOrientationCurrent.Items.Count > 0 Then
            CbOrientationCurrent.SelectedIndex = 0
        End If
    End Sub

    Private Function IsInternetAvailable() As Boolean
        Try
            Return My.Computer.Network.Ping("www.google.com")
        Catch
            Return False
        End Try
    End Function

    Private Async Function LoadDataAsync() As Task
        If Not IsInternetAvailable() Then
            LogError("Tidak ada koneksi internet. Aplikasi akan terus mencoba untuk menghubungkan kembali.")
            Return
        End If

        Dim url As String = TxtServerURL.Text ' Membaca URL dari TxtServerURL

        If Uri.IsWellFormedUriString(url, UriKind.Absolute) Then
            Try
                Using client As New HttpClient()
                    Dim response As HttpResponseMessage = Await client.GetAsync(url)
                    response.EnsureSuccessStatusCode()

                    Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                    Dim data As List(Of ApiData) = JsonConvert.DeserializeObject(Of List(Of ApiData))(responseBody)

                    PopulateDataGridView(data)

                    ' Auto print jika CBoxAutoPrint dicentang
                    If CBoxAutoPrint.Checked Then
                        For Each item In data
                            If item.print = 0 Then
                                ' Mendapatkan data yang diperlukan
                                Dim voucher_id As Integer = item.id
                                Dim voucher As String = item.name
                                Dim printer As String = CbPrinterCurrent.SelectedItem.ToString()
                                Dim paper As String = CbPaperCurrent.SelectedItem.ToString()
                                Dim orientation As String = CbOrientationCurrent.SelectedItem.ToString()
                                Dim files_base64 As String = item.files_base64

                                ' Pengecekan apakah files_base64 valid
                                If Not String.IsNullOrEmpty(files_base64) Then
                                    Try
                                        ' Mendekode Base64 ke file PDF
                                        Dim pdfBytes As Byte() = Convert.FromBase64String(files_base64)
                                        Dim pdfFilePath As String = Path.Combine(Path.GetTempPath(), $"{voucher}.pdf")
                                        File.WriteAllBytes(pdfFilePath, pdfBytes)

                                        ' Memuat file PDF menggunakan PdfiumViewer
                                        Using document As PdfDocument = PdfDocument.Load(pdfFilePath)
                                            ' Memanggil fungsi PrintPdf dari modul PdfPrinterHelper
                                            PdfPrinterHelper.PrintPdf(voucher_id, voucher, document, printer, paper, orientation)
                                        End Using

                                        ' Menghapus file sementara
                                        File.Delete(pdfFilePath)
                                    Catch ex As Exception
                                        LogError($"Error processing voucher_id {voucher_id}: {ex.Message}")
                                    End Try
                                Else
                                    LogError($"files_base64 is empty for voucher_id {voucher_id}")
                                End If
                            End If
                        Next
                    End If
                End Using
            Catch ex As HttpRequestException
                LogError("Tidak dapat menghubungi server. Aplikasi akan terus mencoba untuk menghubungkan kembali. Error: " & ex.Message)
            Catch ex As JsonException
                LogError("Data yang diterima dari server tidak valid. Silakan periksa URL server atau format data. Error: " & ex.Message)
            Catch ex As Exception
                LogError("Terjadi kesalahan: " & ex.Message)
            End Try
        Else
            LogError("Invalid URL in TxtServerURL.")
        End If
    End Function


    Private Sub TxtVoucher_TextChanged(sender As Object, e As EventArgs)
        Try
            Dim voucher As String = TxtVoucher.Text.Trim()

            Dim lastRow As DataGridViewRow = Nothing
            For Each row As DataGridViewRow In DGVList.Rows
                If row.Cells("api_voucher").Value IsNot Nothing AndAlso row.Cells("api_voucher").Value.ToString().Equals(voucher, StringComparison.OrdinalIgnoreCase) Then
                    If lastRow Is Nothing OrElse CInt(row.Cells("api_id").Value) > CInt(lastRow.Cells("api_id").Value) Then
                        lastRow = row
                    End If
                End If
            Next

            If lastRow IsNot Nothing Then
                TxtVoucher_ID.Text = If(lastRow.Cells("api_id").Value?.ToString(), "")
                TxtFilesBase64.Text = If(lastRow.Cells("api_files_base64").Value?.ToString(), "")
            Else
                TxtVoucher_ID.Text = ""
                TxtFilesBase64.Text = ""
            End If
        Catch ex As Exception
            LogError("Error in TxtVoucher_TextChanged: " & ex.Message)
        End Try
    End Sub



    Private Sub LogError(message As String)
        Dim logFilePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log")
        Dim logMessage As String = $"{DateTime.Now}: {message}{Environment.NewLine}"
        File.AppendAllText(logFilePath, logMessage)
    End Sub

    Public Async Function SetParamServer(voucher_id As Integer, param As String) As Task
        Dim url As String = $"{TxtServerURL.Text}/{voucher_id}?{param}=1"
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            response.EnsureSuccessStatusCode()
        End Using
    End Function

    Private Sub PopulateDataGridView(data As List(Of ApiData))
        If DGVList.InvokeRequired Then
            DGVList.Invoke(New Action(Of List(Of ApiData))(AddressOf PopulateDataGridView), data)
        Else
            DGVList.Rows.Clear()

            For Each item In data
                DGVList.Rows.Add(item.id, item.name, item.doc_url, item.files_base64, item.downloaded, item.print, item.print_date)
            Next
        End If
    End Sub

    Private Sub DGVList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVList.CellClick
        ' Pastikan baris yang diklik valid
        Try
            If e.RowIndex >= 0 AndAlso e.RowIndex < DGVList.Rows.Count Then
                Dim row As DataGridViewRow = DGVList.Rows(e.RowIndex)

                ' Mengisi field sesuai dengan kolom yang dipilih
                TxtVoucher_ID.Text = If(row.Cells("api_id").Value?.ToString(), "")
                TxtVoucher.Text = If(row.Cells("api_voucher").Value?.ToString(), "")
                TxtFilesBase64.Text = If(row.Cells("api_files_base64").Value?.ToString(), "")
            End If
        Catch ex As Exception
            LogError("Error in DGVList_CellClick: " & ex.Message)
        End Try
    End Sub


    Private Sub BtnSaveConfiguration_Click(sender As Object, e As EventArgs) Handles BtnSaveConfiguration.Click
        SaveConfiguration()
    End Sub

    Private Sub SaveConfiguration()
        Dim configFile As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini")

        Dim configData As New StringBuilder()
        configData.AppendLine("[Configuration]")
        configData.AppendLine($"Printer={CbPrinterDef.SelectedItem}")
        configData.AppendLine($"Paper={CbPaperDef.SelectedItem}")
        configData.AppendLine($"Orientation={CbOrientationDef.SelectedItem}")
        configData.AppendLine($"ServerURL={TxtServerURL.Text}")
        configData.AppendLine($"AutoPrint={CBoxAutoPrint.Checked}")
        configData.AppendLine($"Refresh={NudRefresh.Value}")
        configData.AppendLine($"AutoURL={CBoxAutoURL.Checked}")

        File.WriteAllText(configFile, configData.ToString())

        MessageBox.Show("Konfigurasi berhasil disimpan.")
    End Sub

    Private Sub LoadConfiguration()
        Dim configFile As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini")

        If File.Exists(configFile) Then
            Dim lines() As String = File.ReadAllLines(configFile)
            For Each line As String In lines
                Dim parts() As String = line.Split("=")
                If parts.Length = 2 Then
                    Select Case parts(0).Trim()
                        Case "Printer"
                            CbPrinterDef.SelectedItem = parts(1).Trim()
                        Case "Paper"
                            CbPaperDef.SelectedItem = parts(1).Trim()
                        Case "Orientation"
                            CbOrientationDef.SelectedItem = parts(1).Trim()
                        Case "ServerURL"
                            TxtServerURL.Text = parts(1).Trim()
                        Case "AutoPrint"
                            CBoxAutoPrint.Checked = Boolean.Parse(parts(1).Trim())
                        Case "Refresh"
                            NudRefresh.Value = Decimal.Parse(parts(1).Trim())
                        Case "AutoURL"
                            CBoxAutoURL.Checked = Boolean.Parse(parts(1).Trim())
                    End Select
                End If
            Next
        End If
    End Sub

    Private Sub CheckStartupStatus()
        Dim startupFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Dim shortcutPath As String = Path.Combine(startupFolder, Application.ProductName & ".lnk")

        CBoxStartup.Checked = File.Exists(shortcutPath)
    End Sub

    Private Sub CBoxStartup_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxStartup.CheckedChanged
        If CBoxStartup.Checked Then
            AddToStartup()
        Else
            RemoveFromStartup()
        End If
    End Sub

    Private Sub AddToStartup()
        Dim startupFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Dim shortcutPath As String = Path.Combine(startupFolder, Application.ProductName & ".lnk")

        If Not File.Exists(shortcutPath) Then
            Dim shell As Object = CreateObject("WScript.Shell")
            Dim shortcut As Object = shell.CreateShortcut(shortcutPath)
            shortcut.TargetPath = Application.ExecutablePath
            shortcut.Save()
        End If
    End Sub

    Private Sub RemoveFromStartup()
        Dim startupFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Dim shortcutPath As String = Path.Combine(startupFolder, Application.ProductName & ".lnk")

        If File.Exists(shortcutPath) Then
            File.Delete(shortcutPath)
        End If
    End Sub

    Private Async Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        ' Validasi field yang dibutuhkan tidak boleh kosong
        If String.IsNullOrWhiteSpace(TxtVoucher_ID.Text) OrElse String.IsNullOrWhiteSpace(TxtVoucher.Text) OrElse String.IsNullOrWhiteSpace(TxtFilesBase64.Text) Then
            MessageBox.Show("Pastikan semua field diisi sebelum mencetak.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Dapatkan data dari field
        Dim voucher_id As Integer = Integer.Parse(TxtVoucher_ID.Text)
        Dim voucher As String = TxtVoucher.Text
        Dim printer As String = CbPrinterCurrent.SelectedItem.ToString()
        Dim paper As String = CbPaperCurrent.SelectedItem.ToString()
        Dim orientation As String = CbOrientationCurrent.SelectedItem.ToString()
        Dim files_base64 As String = TxtFilesBase64.Text ' Menggunakan data dari TxtFilesBase64

        ' Mendekode Base64 ke file PDF
        Dim pdfBytes As Byte() = Convert.FromBase64String(files_base64)
        Dim pdfFilePath As String = Path.Combine(Path.GetTempPath(), $"{voucher}.pdf")
        File.WriteAllBytes(pdfFilePath, pdfBytes)

        ' Memuat file PDF menggunakan PdfiumViewer
        Using document As PdfDocument = PdfDocument.Load(pdfFilePath)
            ' Memanggil fungsi PrintPdf dari modul PdfPrinterHelper
            PdfPrinterHelper.PrintPdf(voucher_id, voucher, document, printer, paper, orientation)
        End Using

        ' Menghapus file sementara
        File.Delete(pdfFilePath)
    End Sub

    Public Class ApiData
        Public Property id As Integer
        Public Property name As String
        Public Property doc_url As String
        Public Property files_base64 As String
        Public Property downloaded As Integer
        Public Property print As Integer
        Public Property print_date As String
    End Class

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub
End Class