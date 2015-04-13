Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmKhachHang
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=ps01840.mssql.somee.com;packet size=4096;user id=congdinh60119_SQLLogin_1;pwd=qhc3iaos6n;data source=ps01840.mssql.somee.com;persist security info=False;initial catalog=ps01840"
    Private Sub Khachhang_Load()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from KhachHang", KetNoi)
        Try
            KetNoi.Open()

            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMakh.Text = DataGridView1.Item(0, index).Value
        txtTenkh.Text = DataGridView1.Item(1, index).Value
        txtEmail.Text = DataGridView1.Item(2, index).Value
        txtSdt.Text = DataGridView1.Item(3, index).Value
        txtDiachi.Text = DataGridView1.Item(4, index).Value
        txtCongty.Text = DataGridView1.Item(5, index).Value
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Khachhang_Load()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO KhachHang (MaKH,TenKH,Email,SoDT,DiaChi,Congty)"
        query &= "Values(@Makh,@TenKh,@Email,@SoDT,@Diachi,@Congty)"
        Using conn As New SqlConnection("workstation id=ps01840.mssql.somee.com;packet size=4096;user id=congdinh60119_SQLLogin_1;pwd=qhc3iaos6n;data source=ps01840.mssql.somee.com;persist security info=False;initial catalog=ps01840")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Makh", txtMakh.Text)
                    .Parameters.AddWithValue("@TenKh", txtTenkh.Text)
                    .Parameters.AddWithValue("@Email", txtEmail.Text)
                    .Parameters.AddWithValue("@SoDT", txtSdt.Text)
                    .Parameters.AddWithValue("@Diachi", txtDiachi.Text)
                    .Parameters.AddWithValue("@Congty", txtCongty.Text)

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
                Khachhang_Load()
            End Using
        End Using
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = " update KhachHang set TenKH = @TenKH ,Email = @Email,SoDT = @SoDT,DiaChi= @DiaChi where MaKH = @MaKH "
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            'thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@MaKH", txtMakh.Text)
            com.Parameters.AddWithValue("@TenKH", txtTenkh.Text)
            com.Parameters.AddWithValue("@Email", txtEmail.Text)
            com.Parameters.AddWithValue("@SoDT", txtSdt.Text)
            com.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
            com.Parameters.AddWithValue("@CongTy", txtCongty.Text)

            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("ket noi khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Khachhang_Load()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from  KhachHang where MaKH = @MaKH"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaKH", txtMakh.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Xoa khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Khachhang_Load()
    End Sub

    Private Sub btnTrove_Click(sender As Object, e As EventArgs) Handles btnTrove.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Khachhang_Load()
    End Sub

   
End Class