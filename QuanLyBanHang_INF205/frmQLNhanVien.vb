Imports System.Data.SqlClient
Imports System.Data.DataTable


Public Class frmQLNhanVien
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=thangnhps02396.mssql.somee.com;packet size=4096;user id=ps02396;pwd=25251325;data source=thangnhps02396.mssql.somee.com;persist security info=False;initial catalog=thangnhps02396"

    Private Sub LoadData()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", KetNoi)
        Try
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()

    End Sub
    Private Sub frmQLNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tạo đối tượng kết nối tới Data Trên Somee.com thông qua chuỗi kết nối connectstr
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", KetNoi)

        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = tb
        KetNoi.Close()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Khi click vào một ô bất kì, lấy giá trị tại ô đó lên textbox tương ứng
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaNV.Text = DataGridView1.Item(0, index).Value
        txtPassword.Text = DataGridView1.Item(1, index).Value
        txtTenNV.Text = DataGridView1.Item(2, index).Value
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.txtMaNV.Text = ""
        Me.txtPassword.Text = ""
        Me.txtTenNV.Text = ""
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        'Ket noi với data trên somee thông qua chuỗi kết nối connectstr
        Dim Ketnoi As New SqlConnection(connectstr)
        'Mở kết nối
        Ketnoi.Open()
        'Câu truy vấn để sửa dữ liệu theo mã
        Dim stradd As String = "UPDATE NhanVien SET MaNV = @MaNV, Password = @Password, TenNV = @TenNV Where MaNV = @MaNV"
        Dim com As New SqlCommand(stradd, Ketnoi)
        Try
            'Thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
            com.Parameters.AddWithValue("@Password", txtPassword.Text)
            com.Parameters.AddWithValue("@TenNV", txtTenNV.Text)
            'Thực thi câu truy vấn và sửa dữ liệu trong Database
            com.ExecuteNonQuery()
            'Đóng kết nối
            Ketnoi.Close()
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'xóa textbox sau khi thực hiện Sửa thành công
            txtMaNV.Clear()
            txtPassword.Clear()
            txtTenNV.Clear()
        Catch ex As Exception
            MessageBox.Show("Kết nối thất bại!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Load lại nhân viên
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Ketnoi As New SqlConnection(connectstr)
        Ketnoi.Open()
        Dim stradd As String = "DELETE from NhanVien Where MaNV = @MaNV"
        Dim com As New SqlCommand(stradd, Ketnoi)
        Try
            com.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
            com.ExecuteNonQuery()
            Ketnoi.Close()
            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'xóa textbox sau khi thực hiện Xóa thành công
            txtMaNV.Clear()
            txtPassword.Clear()
            txtTenNV.Clear()
        Catch ex As Exception
            MessageBox.Show("Kết nối thất bại!", "Lỗi kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim load As New SqlConnection(connectstr)
        Dim add As New SqlDataAdapter("Insert Into NhanVien Values ('" & txtMaNV.Text & "','" & txtPassword.Text & "','" & txtTenNV.Text & "')", load)
        Try
            load.Open()
            add.Fill(tb)
            MessageBox.Show("Đã thêm thành viên mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'xóa textbox sau khi thực hiện Thêm thành công
            txtMaNV.Clear()
            txtPassword.Clear()
            txtTenNV.Clear()
        Catch ex As Exception
            MessageBox.Show("Kết nối thất bại!", "Lỗi kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        load.Close()
        LoadData()
    End Sub
End Class