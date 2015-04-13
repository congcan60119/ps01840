<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBanquyen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBanquyen))
        Me.btnDong = New System.Windows.Forms.Button()
        Me.lblGiaovien = New System.Windows.Forms.Label()
        Me.lblBanquyen = New System.Windows.Forms.Label()
        Me.lblThietke = New System.Windows.Forms.Label()
        Me.lblPhienban = New System.Windows.Forms.Label()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.lblTen = New System.Windows.Forms.Label()
        Me.ptbHinh = New System.Windows.Forms.PictureBox()
        CType(Me.ptbHinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnDong.Location = New System.Drawing.Point(164, 404)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(86, 41)
        Me.btnDong.TabIndex = 10
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'lblGiaovien
        '
        Me.lblGiaovien.AutoSize = True
        Me.lblGiaovien.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblGiaovien.ForeColor = System.Drawing.Color.Black
        Me.lblGiaovien.Location = New System.Drawing.Point(105, 227)
        Me.lblGiaovien.Name = "lblGiaovien"
        Me.lblGiaovien.Size = New System.Drawing.Size(173, 19)
        Me.lblGiaovien.TabIndex = 3
        Me.lblGiaovien.Text = "GVHD: Trần Duy Phong"
        '
        'lblBanquyen
        '
        Me.lblBanquyen.AutoSize = True
        Me.lblBanquyen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblBanquyen.ForeColor = System.Drawing.Color.Black
        Me.lblBanquyen.Location = New System.Drawing.Point(105, 193)
        Me.lblBanquyen.Name = "lblBanquyen"
        Me.lblBanquyen.Size = New System.Drawing.Size(191, 19)
        Me.lblBanquyen.TabIndex = 4
        Me.lblBanquyen.Text = "Bản quyền: congdqps01840"
        '
        'lblThietke
        '
        Me.lblThietke.AutoSize = True
        Me.lblThietke.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblThietke.ForeColor = System.Drawing.Color.Black
        Me.lblThietke.Location = New System.Drawing.Point(105, 161)
        Me.lblThietke.Name = "lblThietke"
        Me.lblThietke.Size = New System.Drawing.Size(193, 19)
        Me.lblThietke.TabIndex = 5
        Me.lblThietke.Text = "Thiết kế: Đinh Quang Công"
        '
        'lblPhienban
        '
        Me.lblPhienban.AutoSize = True
        Me.lblPhienban.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblPhienban.ForeColor = System.Drawing.Color.Black
        Me.lblPhienban.Location = New System.Drawing.Point(146, 129)
        Me.lblPhienban.Name = "lblPhienban"
        Me.lblPhienban.Size = New System.Drawing.Size(125, 19)
        Me.lblPhienban.TabIndex = 6
        Me.lblPhienban.Text = "Phiên bản XD007"
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblWeb.ForeColor = System.Drawing.Color.Red
        Me.lblWeb.Location = New System.Drawing.Point(103, 65)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(173, 36)
        Me.lblWeb.TabIndex = 7
        Me.lblWeb.Text = "www.fpt.vn"
        '
        'lblTen
        '
        Me.lblTen.AutoSize = True
        Me.lblTen.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTen.ForeColor = System.Drawing.Color.Blue
        Me.lblTen.Location = New System.Drawing.Point(81, 28)
        Me.lblTen.Name = "lblTen"
        Me.lblTen.Size = New System.Drawing.Size(243, 22)
        Me.lblTen.TabIndex = 8
        Me.lblTen.Text = "Phần mềm quản lý sản phẩm"
        '
        'ptbHinh
        '
        Me.ptbHinh.ErrorImage = Nothing
        Me.ptbHinh.Image = CType(resources.GetObject("ptbHinh.Image"), System.Drawing.Image)
        Me.ptbHinh.InitialImage = Nothing
        Me.ptbHinh.Location = New System.Drawing.Point(62, 275)
        Me.ptbHinh.Name = "ptbHinh"
        Me.ptbHinh.Size = New System.Drawing.Size(316, 116)
        Me.ptbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbHinh.TabIndex = 9
        Me.ptbHinh.TabStop = False
        '
        'frmBanquyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(431, 472)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.ptbHinh)
        Me.Controls.Add(Me.lblGiaovien)
        Me.Controls.Add(Me.lblBanquyen)
        Me.Controls.Add(Me.lblThietke)
        Me.Controls.Add(Me.lblPhienban)
        Me.Controls.Add(Me.lblWeb)
        Me.Controls.Add(Me.lblTen)
        Me.Name = "frmBanquyen"
        Me.Text = "Bản Quyền"
        CType(Me.ptbHinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents ptbHinh As System.Windows.Forms.PictureBox
    Friend WithEvents lblGiaovien As System.Windows.Forms.Label
    Friend WithEvents lblBanquyen As System.Windows.Forms.Label
    Friend WithEvents lblThietke As System.Windows.Forms.Label
    Friend WithEvents lblPhienban As System.Windows.Forms.Label
    Friend WithEvents lblWeb As System.Windows.Forms.Label
    Friend WithEvents lblTen As System.Windows.Forms.Label
End Class
