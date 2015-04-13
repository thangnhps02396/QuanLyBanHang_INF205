<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLSanPham))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.lblDanhsachSP = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.txtHangSX = New System.Windows.Forms.TextBox()
        Me.txtChitiet = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.txtDongia = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.lblMaloai = New System.Windows.Forms.Label()
        Me.lblHangSX = New System.Windows.Forms.Label()
        Me.lblChitiet = New System.Windows.Forms.Label()
        Me.lblSoluong = New System.Windows.Forms.Label()
        Me.lblDongia = New System.Windows.Forms.Label()
        Me.lblTenSP = New System.Windows.Forms.Label()
        Me.lblMaSP = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnThoat)
        Me.GroupBox1.Controls.Add(Me.btnXoa)
        Me.GroupBox1.Controls.Add(Me.btnSua)
        Me.GroupBox1.Controls.Add(Me.btnThem)
        Me.GroupBox1.Controls.Add(Me.lblDanhsachSP)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txtMaLoai)
        Me.GroupBox1.Controls.Add(Me.txtHangSX)
        Me.GroupBox1.Controls.Add(Me.txtChitiet)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.txtDongia)
        Me.GroupBox1.Controls.Add(Me.txtTenSP)
        Me.GroupBox1.Controls.Add(Me.txtMaSP)
        Me.GroupBox1.Controls.Add(Me.lblMaloai)
        Me.GroupBox1.Controls.Add(Me.lblHangSX)
        Me.GroupBox1.Controls.Add(Me.lblChitiet)
        Me.GroupBox1.Controls.Add(Me.lblSoluong)
        Me.GroupBox1.Controls.Add(Me.lblDongia)
        Me.GroupBox1.Controls.Add(Me.lblTenSP)
        Me.GroupBox1.Controls.Add(Me.lblMaSP)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(821, 517)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin sản phẩm"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(520, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 286)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(593, 465)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 40)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(480, 465)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(90, 40)
        Me.btnThoat.TabIndex = 22
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(367, 465)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(90, 40)
        Me.btnXoa.TabIndex = 21
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(254, 465)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(90, 40)
        Me.btnSua.TabIndex = 20
        Me.btnSua.Text = "Sửa"
        Me.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(141, 465)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(90, 40)
        Me.btnThem.TabIndex = 19
        Me.btnThem.Text = "Thêm"
        Me.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'lblDanhsachSP
        '
        Me.lblDanhsachSP.AutoSize = True
        Me.lblDanhsachSP.Location = New System.Drawing.Point(28, 279)
        Me.lblDanhsachSP.Name = "lblDanhsachSP"
        Me.lblDanhsachSP.Size = New System.Drawing.Size(149, 18)
        Me.lblDanhsachSP.TabIndex = 18
        Me.lblDanhsachSP.Text = "Danh mục sản phẩm:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(28, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(765, 150)
        Me.DataGridView1.TabIndex = 17
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(176, 237)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.Size = New System.Drawing.Size(266, 24)
        Me.txtMaLoai.TabIndex = 16
        '
        'txtHangSX
        '
        Me.txtHangSX.Location = New System.Drawing.Point(176, 203)
        Me.txtHangSX.Name = "txtHangSX"
        Me.txtHangSX.Size = New System.Drawing.Size(266, 24)
        Me.txtHangSX.TabIndex = 15
        '
        'txtChitiet
        '
        Me.txtChitiet.Location = New System.Drawing.Point(176, 169)
        Me.txtChitiet.Name = "txtChitiet"
        Me.txtChitiet.Size = New System.Drawing.Size(266, 24)
        Me.txtChitiet.TabIndex = 14
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(176, 136)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(266, 24)
        Me.NumericUpDown1.TabIndex = 13
        '
        'txtDongia
        '
        Me.txtDongia.Location = New System.Drawing.Point(176, 101)
        Me.txtDongia.Name = "txtDongia"
        Me.txtDongia.Size = New System.Drawing.Size(266, 24)
        Me.txtDongia.TabIndex = 12
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(176, 67)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(266, 24)
        Me.txtTenSP.TabIndex = 11
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(176, 33)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(266, 24)
        Me.txtMaSP.TabIndex = 10
        '
        'lblMaloai
        '
        Me.lblMaloai.AutoSize = True
        Me.lblMaloai.Location = New System.Drawing.Point(25, 240)
        Me.lblMaloai.Name = "lblMaloai"
        Me.lblMaloai.Size = New System.Drawing.Size(60, 18)
        Me.lblMaloai.TabIndex = 9
        Me.lblMaloai.Text = "Mã loại:"
        '
        'lblHangSX
        '
        Me.lblHangSX.AutoSize = True
        Me.lblHangSX.Location = New System.Drawing.Point(25, 206)
        Me.lblHangSX.Name = "lblHangSX"
        Me.lblHangSX.Size = New System.Drawing.Size(106, 18)
        Me.lblHangSX.TabIndex = 8
        Me.lblHangSX.Text = "Hãng sản xuất:"
        '
        'lblChitiet
        '
        Me.lblChitiet.AutoSize = True
        Me.lblChitiet.Location = New System.Drawing.Point(25, 172)
        Me.lblChitiet.Name = "lblChitiet"
        Me.lblChitiet.Size = New System.Drawing.Size(126, 18)
        Me.lblChitiet.TabIndex = 7
        Me.lblChitiet.Text = "Chi tiết sản phẩm:"
        '
        'lblSoluong
        '
        Me.lblSoluong.AutoSize = True
        Me.lblSoluong.Location = New System.Drawing.Point(25, 138)
        Me.lblSoluong.Name = "lblSoluong"
        Me.lblSoluong.Size = New System.Drawing.Size(71, 18)
        Me.lblSoluong.TabIndex = 6
        Me.lblSoluong.Text = "Số lượng:"
        '
        'lblDongia
        '
        Me.lblDongia.AutoSize = True
        Me.lblDongia.Location = New System.Drawing.Point(25, 104)
        Me.lblDongia.Name = "lblDongia"
        Me.lblDongia.Size = New System.Drawing.Size(63, 18)
        Me.lblDongia.TabIndex = 5
        Me.lblDongia.Text = "Đơn giá:"
        '
        'lblTenSP
        '
        Me.lblTenSP.AutoSize = True
        Me.lblTenSP.Location = New System.Drawing.Point(25, 70)
        Me.lblTenSP.Name = "lblTenSP"
        Me.lblTenSP.Size = New System.Drawing.Size(106, 18)
        Me.lblTenSP.TabIndex = 4
        Me.lblTenSP.Text = "Tên sản phẩm:"
        '
        'lblMaSP
        '
        Me.lblMaSP.AutoSize = True
        Me.lblMaSP.Location = New System.Drawing.Point(25, 36)
        Me.lblMaSP.Name = "lblMaSP"
        Me.lblMaSP.Size = New System.Drawing.Size(102, 18)
        Me.lblMaSP.TabIndex = 3
        Me.lblMaSP.Text = "Mã sản phẩm:"
        '
        'frmQLSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 541)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQLSanPham"
        Me.Text = "Quản Lý Sản Phẩm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblChitiet As System.Windows.Forms.Label
    Friend WithEvents lblSoluong As System.Windows.Forms.Label
    Friend WithEvents lblDongia As System.Windows.Forms.Label
    Friend WithEvents lblTenSP As System.Windows.Forms.Label
    Friend WithEvents lblMaSP As System.Windows.Forms.Label
    Friend WithEvents lblMaloai As System.Windows.Forms.Label
    Friend WithEvents lblHangSX As System.Windows.Forms.Label
    Friend WithEvents lblDanhsachSP As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtMaLoai As System.Windows.Forms.TextBox
    Friend WithEvents txtHangSX As System.Windows.Forms.TextBox
    Friend WithEvents txtChitiet As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDongia As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
