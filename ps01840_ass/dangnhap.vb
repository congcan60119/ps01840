
Imports System.Data.SqlClient
Public Class frmDangnhap

    Private Sub ButtonDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        Dim chuoiketnoi As String = "workstation id=ps01840.mssql.somee.com;packet size=4096;user id=congdinh60119_SQLLogin_1;pwd=qhc3iaos6n;data source=ps01840.mssql.somee.com;persist security info=False;initial catalog=ps01840"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from TaiKhoan where MaTK='" & txtDangnhap.Text & "' and Password='" & txtMatkhau.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công")
                frmMain.Show()
                Me.Hide()

            Else
                MessageBox.Show("Sai Tai Khoan hoac Mat Khau")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        'Khai báo biến dialog kiểu DialogResult nắm giữ hộp thoại 2 nút hỏi Yes và No
        Dim dialog As DialogResult = MessageBox.Show("Bạn muốn kết thúc ứng dụng ?",
                                     "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'Nếu nhấp nút Yes thì đóng form đang nhập và kết thúc ứng dụng
        If (dialog = DialogResult.Yes) Then
            Me.Close() 'đóng form đăng nhập
            Application.Exit() 'kết thúc ứng dụng
        End If
    End Sub

  
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ptbDangnhap.Click

    End Sub

    Private Sub lblTaikhoan_Click(sender As Object, e As EventArgs) Handles lblTaikhoan.Click

    End Sub

    Private Sub lblMatkhau_Click(sender As Object, e As EventArgs) Handles lblMatkhau.Click

    End Sub
End Class



