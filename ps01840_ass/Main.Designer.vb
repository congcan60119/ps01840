<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mniHeThong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDangXuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQuanLy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniKhachHang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniTaiKhoan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThongTin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniBanQuyen = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gold
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniHeThong, Me.mniQuanLy, Me.mniThongTin})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mniHeThong
        '
        Me.mniHeThong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniDangXuat, Me.mniThoat})
        Me.mniHeThong.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mniHeThong.ForeColor = System.Drawing.Color.Red
        Me.mniHeThong.Name = "mniHeThong"
        Me.mniHeThong.Size = New System.Drawing.Size(82, 23)
        Me.mniHeThong.Text = "Hệ thống"
        '
        'mniDangXuat
        '
        Me.mniDangXuat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mniDangXuat.Image = CType(resources.GetObject("mniDangXuat.Image"), System.Drawing.Image)
        Me.mniDangXuat.Name = "mniDangXuat"
        Me.mniDangXuat.Size = New System.Drawing.Size(152, 24)
        Me.mniDangXuat.Text = "Đăng Xuất"
        '
        'mniThoat
        '
        Me.mniThoat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mniThoat.Image = CType(resources.GetObject("mniThoat.Image"), System.Drawing.Image)
        Me.mniThoat.Name = "mniThoat"
        Me.mniThoat.Size = New System.Drawing.Size(152, 24)
        Me.mniThoat.Text = "Thoát"
        '
        'mniQuanLy
        '
        Me.mniQuanLy.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniKhachHang, Me.mniTaiKhoan})
        Me.mniQuanLy.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mniQuanLy.ForeColor = System.Drawing.Color.Red
        Me.mniQuanLy.Name = "mniQuanLy"
        Me.mniQuanLy.Size = New System.Drawing.Size(79, 23)
        Me.mniQuanLy.Text = "Quản Lý"
        '
        'mniKhachHang
        '
        Me.mniKhachHang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mniKhachHang.Image = CType(resources.GetObject("mniKhachHang.Image"), System.Drawing.Image)
        Me.mniKhachHang.Name = "mniKhachHang"
        Me.mniKhachHang.Size = New System.Drawing.Size(161, 24)
        Me.mniKhachHang.Text = "Khách Hàng"
        '
        'mniTaiKhoan
        '
        Me.mniTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mniTaiKhoan.Image = CType(resources.GetObject("mniTaiKhoan.Image"), System.Drawing.Image)
        Me.mniTaiKhoan.Name = "mniTaiKhoan"
        Me.mniTaiKhoan.Size = New System.Drawing.Size(161, 24)
        Me.mniTaiKhoan.Text = "Tài Khoản"
        '
        'mniThongTin
        '
        Me.mniThongTin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniBanQuyen})
        Me.mniThongTin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mniThongTin.ForeColor = System.Drawing.Color.Red
        Me.mniThongTin.Name = "mniThongTin"
        Me.mniThongTin.Size = New System.Drawing.Size(84, 23)
        Me.mniThongTin.Text = "Thông tin"
        '
        'mniBanQuyen
        '
        Me.mniBanQuyen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mniBanQuyen.Image = CType(resources.GetObject("mniBanQuyen.Image"), System.Drawing.Image)
        Me.mniBanQuyen.Name = "mniBanQuyen"
        Me.mniBanQuyen.Size = New System.Drawing.Size(153, 24)
        Me.mniBanQuyen.Text = "Bản Quyền"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(137, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(31, 127)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(461, 255)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(534, 394)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Orange
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mniHeThong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDangXuat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQuanLy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniKhachHang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniTaiKhoan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThongTin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniBanQuyen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
