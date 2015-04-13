<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangnhap))
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnDangnhap = New System.Windows.Forms.Button()
        Me.txtMatkhau = New System.Windows.Forms.TextBox()
        Me.txtDangnhap = New System.Windows.Forms.TextBox()
        Me.lblMatkhau = New System.Windows.Forms.Label()
        Me.lblTaikhoan = New System.Windows.Forms.Label()
        Me.lblDangnhap = New System.Windows.Forms.Label()
        Me.ptbDangnhap = New System.Windows.Forms.PictureBox()
        CType(Me.ptbDangnhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(376, 195)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(82, 32)
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnDangnhap
        '
        Me.btnDangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnDangnhap.Location = New System.Drawing.Point(276, 195)
        Me.btnDangnhap.Name = "btnDangnhap"
        Me.btnDangnhap.Size = New System.Drawing.Size(82, 32)
        Me.btnDangnhap.TabIndex = 11
        Me.btnDangnhap.Text = "Đăng nhập"
        Me.btnDangnhap.UseVisualStyleBackColor = True
        '
        'txtMatkhau
        '
        Me.txtMatkhau.Location = New System.Drawing.Point(276, 148)
        Me.txtMatkhau.MaxLength = 20
        Me.txtMatkhau.Name = "txtMatkhau"
        Me.txtMatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatkhau.Size = New System.Drawing.Size(182, 20)
        Me.txtMatkhau.TabIndex = 10
        '
        'txtDangnhap
        '
        Me.txtDangnhap.Location = New System.Drawing.Point(276, 95)
        Me.txtDangnhap.MaxLength = 30
        Me.txtDangnhap.Name = "txtDangnhap"
        Me.txtDangnhap.Size = New System.Drawing.Size(182, 20)
        Me.txtDangnhap.TabIndex = 7
        '
        'lblMatkhau
        '
        Me.lblMatkhau.AutoSize = True
        Me.lblMatkhau.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMatkhau.Location = New System.Drawing.Point(178, 148)
        Me.lblMatkhau.Name = "lblMatkhau"
        Me.lblMatkhau.Size = New System.Drawing.Size(79, 21)
        Me.lblMatkhau.TabIndex = 8
        Me.lblMatkhau.Text = "Mật khẩu"
        '
        'lblTaikhoan
        '
        Me.lblTaikhoan.AutoSize = True
        Me.lblTaikhoan.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTaikhoan.Location = New System.Drawing.Point(178, 95)
        Me.lblTaikhoan.Name = "lblTaikhoan"
        Me.lblTaikhoan.Size = New System.Drawing.Size(84, 21)
        Me.lblTaikhoan.TabIndex = 9
        Me.lblTaikhoan.Text = "Tài khoản"
        '
        'lblDangnhap
        '
        Me.lblDangnhap.AutoSize = True
        Me.lblDangnhap.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDangnhap.ForeColor = System.Drawing.Color.Red
        Me.lblDangnhap.Location = New System.Drawing.Point(245, 33)
        Me.lblDangnhap.Name = "lblDangnhap"
        Me.lblDangnhap.Size = New System.Drawing.Size(227, 40)
        Me.lblDangnhap.TabIndex = 6
        Me.lblDangnhap.Text = "ĐĂNG NHẬP"
        '
        'ptbDangnhap
        '
        Me.ptbDangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbDangnhap.ErrorImage = CType(resources.GetObject("ptbDangnhap.ErrorImage"), System.Drawing.Image)
        Me.ptbDangnhap.Image = CType(resources.GetObject("ptbDangnhap.Image"), System.Drawing.Image)
        Me.ptbDangnhap.Location = New System.Drawing.Point(30, 59)
        Me.ptbDangnhap.Name = "ptbDangnhap"
        Me.ptbDangnhap.Size = New System.Drawing.Size(142, 155)
        Me.ptbDangnhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbDangnhap.TabIndex = 13
        Me.ptbDangnhap.TabStop = False
        '
        'frmDangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 262)
        Me.Controls.Add(Me.ptbDangnhap)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangnhap)
        Me.Controls.Add(Me.txtMatkhau)
        Me.Controls.Add(Me.txtDangnhap)
        Me.Controls.Add(Me.lblMatkhau)
        Me.Controls.Add(Me.lblTaikhoan)
        Me.Controls.Add(Me.lblDangnhap)
        Me.Name = "frmDangnhap"
        Me.Text = "Đăng nhập"
        CType(Me.ptbDangnhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnDangnhap As System.Windows.Forms.Button
    Friend WithEvents txtMatkhau As System.Windows.Forms.TextBox
    Friend WithEvents txtDangnhap As System.Windows.Forms.TextBox
    Friend WithEvents lblMatkhau As System.Windows.Forms.Label
    Friend WithEvents lblTaikhoan As System.Windows.Forms.Label
    Friend WithEvents lblDangnhap As System.Windows.Forms.Label
    Friend WithEvents ptbDangnhap As System.Windows.Forms.PictureBox

End Class
