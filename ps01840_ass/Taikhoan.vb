Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmTaikhoan
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=ps01840.mssql.somee.com;packet size=4096;user id=congdinh60119_SQLLogin_1;pwd=qhc3iaos6n;data source=ps01840.mssql.somee.com;persist security info=False;initial catalog=ps01840"
    Private Sub TaiKhoan_Load()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from TaiKhoan", KetNoi)
        Try
            KetNoi.Open()

            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO TaiKhoan (MaTK,Password,TenTK)"
        query &= "Values(@Matk,@Password,@Tentk)"
        Using conn As New SqlConnection("workstation id=ps01840.mssql.somee.com;packet size=4096;user id=congdinh60119_SQLLogin_1;pwd=qhc3iaos6n;data source=ps01840.mssql.somee.com;persist security info=False;initial catalog=ps01840")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Matk", txtMatk.Text)
                    .Parameters.AddWithValue("@Password", txtPass.Text)
                    .Parameters.AddWithValue("@Tentk", txtTentk.Text)
                    

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
                tb.Clear()
                DataGridView1.DataSource = tb
                DataGridView1.DataSource = Nothing
                TaiKhoan_Load()
            End Using
        End Using
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = " update TaiKhoan set Password = @Password ,TenTK = @Tentk where MaTK = @Matk "
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            'thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@MaTk", txtMatk.Text)
            com.Parameters.AddWithValue("@Password", txtPass.Text)
            com.Parameters.AddWithValue("@Tentk", txtTentk.Text)
           
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("ket noi khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        TaiKhoan_Load()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from  TaiKhoan where MaTK = @Matk"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Matk", txtMatk.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Xoa khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        TaiKhoan_Load()
    End Sub

    Private Sub btnTrove_Click(sender As Object, e As EventArgs) Handles btnTrove.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub frmTaikhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        TaiKhoan_Load()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMatk.Text = DataGridView1.Item(0, index).Value
        txtPass.Text = DataGridView1.Item(1, index).Value
        txtTentk.Text = DataGridView1.Item(2, index).Value
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        TaiKhoan_Load()
    End Sub
End Class

