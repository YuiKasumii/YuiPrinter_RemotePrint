Imports System.Drawing.Printing
Imports PdfiumViewer
Imports System.Threading.Tasks

Public Module PdfPrinterHelper
    Private notifyIcon As NotifyIcon

    Public Async Sub PrintPdf(voucher_id As Integer, voucher As String, document As PdfDocument, printer As String, paper As String, orientation As String)
        ' Inisialisasi NotifyIcon jika belum ada
        If notifyIcon Is Nothing Then
            notifyIcon = New NotifyIcon()
            notifyIcon.Icon = Form1.YuiNotify.Icon ' Menggunakan ikon yang sama dengan aplikasi
            notifyIcon.Visible = True
        End If

        ' Buat PrintDocument dari dokumen PDF
        Using printDoc As PrintDocument = document.CreatePrintDocument()

            ' Mengatur printer
            printDoc.PrinterSettings.PrinterName = printer

            ' Mengatur ukuran kertas
            Dim ps As PaperSize
            Select Case paper.ToLower()
                Case "a4"
                    ps = New PaperSize("A4", 827, 1169)
                Case "f4"
                    ps = New PaperSize("F4", 850, 1300)
                Case "a5"
                    ps = New PaperSize("A5", 583, 827)
                Case Else
                    MessageBox.Show("Ukuran kertas tidak dikenal, menggunakan A4 sebagai default.")
                    ps = New PaperSize("A4", 827, 1169)
            End Select
            printDoc.DefaultPageSettings.PaperSize = ps

            ' Mengatur orientasi
            Select Case orientation.ToLower()
                Case "portrait"
                    printDoc.DefaultPageSettings.Landscape = False
                Case "landscape"
                    printDoc.DefaultPageSettings.Landscape = True
                Case Else
                    MessageBox.Show("Orientasi tidak dikenal, menggunakan portrait sebagai default.")
                    printDoc.DefaultPageSettings.Landscape = False
            End Select

            ' Mengatur margin menjadi nol

            printDoc.DefaultPageSettings.Margins = New Margins(0, 100, 0, 0) ' Set top margin to 1.25 inch

            ' Mencetak dokumen
            printDoc.Print()
        End Using

        ' Memanggil SetParamServer setelah file berhasil dicetak
        Await Form1.SetParamServer(voucher_id, "downloaded")
        Await Form1.SetParamServer(voucher_id, "print")

        ' Menampilkan notifikasi bahwa voucher telah dicetak
        ShowNotification($"Voucher ID {voucher} telah dicetak.")
    End Sub

    Private Sub ShowNotification(message As String)
        notifyIcon.BalloonTipTitle = "Pencetakan Selesai"
        notifyIcon.BalloonTipText = message
        notifyIcon.ShowBalloonTip(3000)
    End Sub
End Module
