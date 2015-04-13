Public Class frmMain

    Private Sub mniDangXuat_Click(sender As Object, e As EventArgs) Handles mniDangXuat.Click
        Dim Dangnhap As New frmDangnhap
        Dangnhap.Show() 'Hiển thị lại from Đăng nhập'
        Me.Close() 'Đóng from chính'
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mniThoat_Click(sender As Object, e As EventArgs) Handles mniThoat.Click
        Me.Close()
        Application.Exit() 'Thoát ứng dụng'
    End Sub

    Private Sub mniKhachHang_Click(sender As Object, e As EventArgs) Handles mniKhachHang.Click
        frmKhachHang.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    

    Private Sub mniTaiKhoan_Click(sender As Object, e As EventArgs) Handles mniTaiKhoan.Click
        frmTaikhoan.Show()
        Me.Close()

    End Sub

   
    Private Sub mniBanQuyen_Click(sender As Object, e As EventArgs) Handles mniBanQuyen.Click
        frmBanquyen.Show()
        Me.Close()


    End Sub
End Class