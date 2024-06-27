<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DGVList = New System.Windows.Forms.DataGridView()
        Me.api_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.api_voucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.api_doc_url = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.api_files_base64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.api_downloaded = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.api_print = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.api_print_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtHeader = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnHideToTray = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtVoucher_ID = New System.Windows.Forms.TextBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbOrientationCurrent = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbPaperCurrent = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbPrinterCurrent = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFilesBase64 = New System.Windows.Forms.TextBox()
        Me.LblVoucherName = New System.Windows.Forms.Label()
        Me.TxtVoucher = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CBoxAutoURL = New System.Windows.Forms.CheckBox()
        Me.BtnSaveConfiguration = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtServerURL = New System.Windows.Forms.TextBox()
        Me.NudRefresh = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBoxAutoPrint = New System.Windows.Forms.CheckBox()
        Me.CBoxStartup = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbOrientationDef = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbPaperDef = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbPrinterDef = New System.Windows.Forms.ComboBox()
        Me.YuiNotify = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.DGVList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.NudRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVList
        '
        Me.DGVList.AllowUserToAddRows = False
        Me.DGVList.AllowUserToDeleteRows = False
        Me.DGVList.AllowUserToResizeRows = False
        Me.DGVList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.DGVList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVList.CausesValidation = False
        Me.DGVList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.api_id, Me.api_voucher, Me.api_doc_url, Me.api_files_base64, Me.api_downloaded, Me.api_print, Me.api_print_date})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVList.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGVList.Location = New System.Drawing.Point(12, 41)
        Me.DGVList.MultiSelect = False
        Me.DGVList.Name = "DGVList"
        Me.DGVList.ReadOnly = True
        Me.DGVList.RowHeadersVisible = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Lime
        Me.DGVList.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVList.Size = New System.Drawing.Size(607, 287)
        Me.DGVList.TabIndex = 0
        '
        'api_id
        '
        Me.api_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.api_id.FillWeight = 88.48685!
        Me.api_id.HeaderText = "ID"
        Me.api_id.Name = "api_id"
        Me.api_id.ReadOnly = True
        Me.api_id.Width = 50
        '
        'api_voucher
        '
        Me.api_voucher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.api_voucher.FillWeight = 202.2556!
        Me.api_voucher.HeaderText = "Voucher"
        Me.api_voucher.Name = "api_voucher"
        Me.api_voucher.ReadOnly = True
        '
        'api_doc_url
        '
        Me.api_doc_url.FillWeight = 31.60245!
        Me.api_doc_url.HeaderText = "Document URL"
        Me.api_doc_url.Name = "api_doc_url"
        Me.api_doc_url.ReadOnly = True
        '
        'api_files_base64
        '
        Me.api_files_base64.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.api_files_base64.FillWeight = 31.60245!
        Me.api_files_base64.HeaderText = "Files in Base64"
        Me.api_files_base64.Name = "api_files_base64"
        Me.api_files_base64.ReadOnly = True
        Me.api_files_base64.Visible = False
        Me.api_files_base64.Width = 5
        '
        'api_downloaded
        '
        Me.api_downloaded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.api_downloaded.FalseValue = "0"
        Me.api_downloaded.FillWeight = 118.9339!
        Me.api_downloaded.HeaderText = "D"
        Me.api_downloaded.Name = "api_downloaded"
        Me.api_downloaded.ReadOnly = True
        Me.api_downloaded.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.api_downloaded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.api_downloaded.TrueValue = "1"
        Me.api_downloaded.Width = 25
        '
        'api_print
        '
        Me.api_print.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.api_print.FalseValue = "0"
        Me.api_print.FillWeight = 127.1186!
        Me.api_print.HeaderText = "P"
        Me.api_print.Name = "api_print"
        Me.api_print.ReadOnly = True
        Me.api_print.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.api_print.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.api_print.TrueValue = "1"
        Me.api_print.Width = 25
        '
        'api_print_date
        '
        Me.api_print_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.api_print_date.HeaderText = "Date"
        Me.api_print_date.MinimumWidth = 100
        Me.api_print_date.Name = "api_print_date"
        Me.api_print_date.ReadOnly = True
        '
        'TxtHeader
        '
        Me.TxtHeader.AutoSize = True
        Me.TxtHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHeader.ForeColor = System.Drawing.Color.White
        Me.TxtHeader.Location = New System.Drawing.Point(12, 9)
        Me.TxtHeader.Name = "TxtHeader"
        Me.TxtHeader.Size = New System.Drawing.Size(96, 25)
        Me.TxtHeader.TabIndex = 1
        Me.TxtHeader.Text = "YuiPrinter"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnExit.FlatAppearance.BorderSize = 2
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Lime
        Me.BtnExit.Location = New System.Drawing.Point(785, 9)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnHideToTray
        '
        Me.BtnHideToTray.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BtnHideToTray.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnHideToTray.FlatAppearance.BorderSize = 2
        Me.BtnHideToTray.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHideToTray.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHideToTray.ForeColor = System.Drawing.Color.Lime
        Me.BtnHideToTray.Location = New System.Drawing.Point(704, 9)
        Me.BtnHideToTray.Name = "BtnHideToTray"
        Me.BtnHideToTray.Size = New System.Drawing.Size(75, 23)
        Me.BtnHideToTray.TabIndex = 4
        Me.BtnHideToTray.Text = "Hide"
        Me.BtnHideToTray.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(625, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(235, 287)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.TxtVoucher_ID)
        Me.TabPage1.Controls.Add(Me.BtnPrint)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.CbOrientationCurrent)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.CbPaperCurrent)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.CbPrinterCurrent)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtFilesBase64)
        Me.TabPage1.Controls.Add(Me.LblVoucherName)
        Me.TabPage1.Controls.Add(Me.TxtVoucher)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(227, 261)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Print"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(160, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "ID :"
        '
        'TxtVoucher_ID
        '
        Me.TxtVoucher_ID.BackColor = System.Drawing.Color.White
        Me.TxtVoucher_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVoucher_ID.Enabled = False
        Me.TxtVoucher_ID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVoucher_ID.ForeColor = System.Drawing.Color.Black
        Me.TxtVoucher_ID.Location = New System.Drawing.Point(163, 27)
        Me.TxtVoucher_ID.Name = "TxtVoucher_ID"
        Me.TxtVoucher_ID.Size = New System.Drawing.Size(54, 25)
        Me.TxtVoucher_ID.TabIndex = 27
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnPrint.FlatAppearance.BorderSize = 2
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.Lime
        Me.BtnPrint.Location = New System.Drawing.Point(8, 221)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(209, 35)
        Me.BtnPrint.TabIndex = 26
        Me.BtnPrint.Text = "PRINT"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Orientation"
        '
        'CbOrientationCurrent
        '
        Me.CbOrientationCurrent.BackColor = System.Drawing.Color.White
        Me.CbOrientationCurrent.DropDownHeight = 110
        Me.CbOrientationCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbOrientationCurrent.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbOrientationCurrent.ForeColor = System.Drawing.Color.Black
        Me.CbOrientationCurrent.FormattingEnabled = True
        Me.CbOrientationCurrent.IntegralHeight = False
        Me.CbOrientationCurrent.ItemHeight = 13
        Me.CbOrientationCurrent.Location = New System.Drawing.Point(8, 183)
        Me.CbOrientationCurrent.Name = "CbOrientationCurrent"
        Me.CbOrientationCurrent.Size = New System.Drawing.Size(148, 21)
        Me.CbOrientationCurrent.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(159, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Paper :"
        '
        'CbPaperCurrent
        '
        Me.CbPaperCurrent.BackColor = System.Drawing.Color.White
        Me.CbPaperCurrent.DropDownHeight = 110
        Me.CbPaperCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPaperCurrent.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPaperCurrent.ForeColor = System.Drawing.Color.Black
        Me.CbPaperCurrent.FormattingEnabled = True
        Me.CbPaperCurrent.IntegralHeight = False
        Me.CbPaperCurrent.ItemHeight = 13
        Me.CbPaperCurrent.Location = New System.Drawing.Point(162, 138)
        Me.CbPaperCurrent.Name = "CbPaperCurrent"
        Me.CbPaperCurrent.Size = New System.Drawing.Size(55, 21)
        Me.CbPaperCurrent.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Printer :"
        '
        'CbPrinterCurrent
        '
        Me.CbPrinterCurrent.BackColor = System.Drawing.Color.White
        Me.CbPrinterCurrent.DropDownHeight = 110
        Me.CbPrinterCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPrinterCurrent.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPrinterCurrent.ForeColor = System.Drawing.Color.Black
        Me.CbPrinterCurrent.FormattingEnabled = True
        Me.CbPrinterCurrent.IntegralHeight = False
        Me.CbPrinterCurrent.ItemHeight = 13
        Me.CbPrinterCurrent.Location = New System.Drawing.Point(8, 138)
        Me.CbPrinterCurrent.Name = "CbPrinterCurrent"
        Me.CbPrinterCurrent.Size = New System.Drawing.Size(148, 21)
        Me.CbPrinterCurrent.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Files Encode :"
        '
        'TxtFilesBase64
        '
        Me.TxtFilesBase64.BackColor = System.Drawing.Color.White
        Me.TxtFilesBase64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFilesBase64.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFilesBase64.ForeColor = System.Drawing.Color.Black
        Me.TxtFilesBase64.Location = New System.Drawing.Point(8, 77)
        Me.TxtFilesBase64.Name = "TxtFilesBase64"
        Me.TxtFilesBase64.Size = New System.Drawing.Size(209, 25)
        Me.TxtFilesBase64.TabIndex = 18
        '
        'LblVoucherName
        '
        Me.LblVoucherName.AutoSize = True
        Me.LblVoucherName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVoucherName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblVoucherName.Location = New System.Drawing.Point(5, 9)
        Me.LblVoucherName.Name = "LblVoucherName"
        Me.LblVoucherName.Size = New System.Drawing.Size(57, 15)
        Me.LblVoucherName.TabIndex = 17
        Me.LblVoucherName.Text = "Voucher :"
        '
        'TxtVoucher
        '
        Me.TxtVoucher.BackColor = System.Drawing.Color.White
        Me.TxtVoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVoucher.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVoucher.ForeColor = System.Drawing.Color.Black
        Me.TxtVoucher.Location = New System.Drawing.Point(8, 27)
        Me.TxtVoucher.Name = "TxtVoucher"
        Me.TxtVoucher.Size = New System.Drawing.Size(148, 25)
        Me.TxtVoucher.TabIndex = 16
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CBoxAutoURL)
        Me.TabPage2.Controls.Add(Me.BtnSaveConfiguration)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TxtServerURL)
        Me.TabPage2.Controls.Add(Me.NudRefresh)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.CBoxAutoPrint)
        Me.TabPage2.Controls.Add(Me.CBoxStartup)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.CbOrientationDef)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.CbPaperDef)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.CbPrinterDef)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(227, 261)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Configuration"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CBoxAutoURL
        '
        Me.CBoxAutoURL.AutoSize = True
        Me.CBoxAutoURL.Location = New System.Drawing.Point(8, 157)
        Me.CBoxAutoURL.Name = "CBoxAutoURL"
        Me.CBoxAutoURL.Size = New System.Drawing.Size(141, 17)
        Me.CBoxAutoURL.TabIndex = 40
        Me.CBoxAutoURL.Text = "Otomatic from Gulmer"
        Me.CBoxAutoURL.UseVisualStyleBackColor = True
        '
        'BtnSaveConfiguration
        '
        Me.BtnSaveConfiguration.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.BtnSaveConfiguration.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSaveConfiguration.FlatAppearance.BorderSize = 2
        Me.BtnSaveConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSaveConfiguration.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveConfiguration.ForeColor = System.Drawing.Color.Lime
        Me.BtnSaveConfiguration.Location = New System.Drawing.Point(8, 221)
        Me.BtnSaveConfiguration.Name = "BtnSaveConfiguration"
        Me.BtnSaveConfiguration.Size = New System.Drawing.Size(209, 35)
        Me.BtnSaveConfiguration.TabIndex = 39
        Me.BtnSaveConfiguration.Text = "SAVE CONFIG"
        Me.BtnSaveConfiguration.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(5, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 15)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Server URL"
        '
        'TxtServerURL
        '
        Me.TxtServerURL.BackColor = System.Drawing.Color.White
        Me.TxtServerURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtServerURL.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtServerURL.ForeColor = System.Drawing.Color.Black
        Me.TxtServerURL.Location = New System.Drawing.Point(8, 129)
        Me.TxtServerURL.Multiline = True
        Me.TxtServerURL.Name = "TxtServerURL"
        Me.TxtServerURL.Size = New System.Drawing.Size(209, 20)
        Me.TxtServerURL.TabIndex = 37
        Me.TxtServerURL.Text = "ADAWDAWDA"
        '
        'NudRefresh
        '
        Me.NudRefresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NudRefresh.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.NudRefresh.Location = New System.Drawing.Point(162, 191)
        Me.NudRefresh.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NudRefresh.Name = "NudRefresh"
        Me.NudRefresh.Size = New System.Drawing.Size(55, 22)
        Me.NudRefresh.TabIndex = 36
        Me.NudRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NudRefresh.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(159, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Refresh"
        '
        'CBoxAutoPrint
        '
        Me.CBoxAutoPrint.AutoSize = True
        Me.CBoxAutoPrint.Location = New System.Drawing.Point(8, 195)
        Me.CBoxAutoPrint.Name = "CBoxAutoPrint"
        Me.CBoxAutoPrint.Size = New System.Drawing.Size(76, 17)
        Me.CBoxAutoPrint.TabIndex = 33
        Me.CBoxAutoPrint.Text = "Auto Print"
        Me.CBoxAutoPrint.UseVisualStyleBackColor = True
        '
        'CBoxStartup
        '
        Me.CBoxStartup.AutoSize = True
        Me.CBoxStartup.Location = New System.Drawing.Point(8, 176)
        Me.CBoxStartup.Name = "CBoxStartup"
        Me.CBoxStartup.Size = New System.Drawing.Size(98, 17)
        Me.CBoxStartup.TabIndex = 32
        Me.CBoxStartup.Text = "Run at Startup"
        Me.CBoxStartup.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(5, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 15)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Orientation Default :"
        '
        'CbOrientationDef
        '
        Me.CbOrientationDef.BackColor = System.Drawing.Color.White
        Me.CbOrientationDef.DropDownHeight = 110
        Me.CbOrientationDef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbOrientationDef.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbOrientationDef.ForeColor = System.Drawing.Color.Black
        Me.CbOrientationDef.FormattingEnabled = True
        Me.CbOrientationDef.IntegralHeight = False
        Me.CbOrientationDef.ItemHeight = 13
        Me.CbOrientationDef.Location = New System.Drawing.Point(8, 76)
        Me.CbOrientationDef.Name = "CbOrientationDef"
        Me.CbOrientationDef.Size = New System.Drawing.Size(148, 21)
        Me.CbOrientationDef.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(159, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Paper :"
        '
        'CbPaperDef
        '
        Me.CbPaperDef.BackColor = System.Drawing.Color.White
        Me.CbPaperDef.DropDownHeight = 110
        Me.CbPaperDef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPaperDef.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPaperDef.ForeColor = System.Drawing.Color.Black
        Me.CbPaperDef.FormattingEnabled = True
        Me.CbPaperDef.IntegralHeight = False
        Me.CbPaperDef.ItemHeight = 13
        Me.CbPaperDef.Location = New System.Drawing.Point(162, 27)
        Me.CbPaperDef.Name = "CbPaperDef"
        Me.CbPaperDef.Size = New System.Drawing.Size(55, 21)
        Me.CbPaperDef.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(5, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Printer Default :"
        '
        'CbPrinterDef
        '
        Me.CbPrinterDef.BackColor = System.Drawing.Color.White
        Me.CbPrinterDef.DropDownHeight = 110
        Me.CbPrinterDef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPrinterDef.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPrinterDef.ForeColor = System.Drawing.Color.Black
        Me.CbPrinterDef.FormattingEnabled = True
        Me.CbPrinterDef.IntegralHeight = False
        Me.CbPrinterDef.ItemHeight = 13
        Me.CbPrinterDef.Location = New System.Drawing.Point(8, 27)
        Me.CbPrinterDef.Name = "CbPrinterDef"
        Me.CbPrinterDef.Size = New System.Drawing.Size(148, 21)
        Me.CbPrinterDef.TabIndex = 26
        '
        'YuiNotify
        '
        Me.YuiNotify.Icon = CType(resources.GetObject("YuiNotify.Icon"), System.Drawing.Icon)
        Me.YuiNotify.Text = "Yui Printer"
        Me.YuiNotify.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(872, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnHideToTray)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TxtHeader)
        Me.Controls.Add(Me.DGVList)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YuiPrinter Build 3.0.1"
        CType(Me.DGVList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NudRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtHeader As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnHideToTray As Button
    Friend WithEvents DGVList As DataGridView
    Friend WithEvents api_id As DataGridViewTextBoxColumn
    Friend WithEvents api_voucher As DataGridViewTextBoxColumn
    Friend WithEvents api_doc_url As DataGridViewTextBoxColumn
    Friend WithEvents api_files_base64 As DataGridViewTextBoxColumn
    Friend WithEvents api_downloaded As DataGridViewCheckBoxColumn
    Friend WithEvents api_print As DataGridViewCheckBoxColumn
    Friend WithEvents api_print_date As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnPrint As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CbOrientationCurrent As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbPaperCurrent As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbPrinterCurrent As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFilesBase64 As TextBox
    Friend WithEvents LblVoucherName As Label
    Friend WithEvents TxtVoucher As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnSaveConfiguration As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtServerURL As TextBox
    Friend WithEvents NudRefresh As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents CBoxAutoPrint As CheckBox
    Friend WithEvents CBoxStartup As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CbOrientationDef As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CbPaperDef As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbPrinterDef As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtVoucher_ID As TextBox
    Friend WithEvents YuiNotify As NotifyIcon
    Friend WithEvents CBoxAutoURL As CheckBox
End Class
