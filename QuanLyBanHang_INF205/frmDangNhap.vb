Imports System.Data.SqlClient

Public Class frmDangNhap

    Private Sub btnDangnhap_Click_1(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        Dim connectString As String = "workstation id=thangnhps02396.mssql.somee.com;packet size=4096;user id=ps02396;pwd=25251325;data source=thangnhps02396.mssql.somee.com;persist security info=False;initial catalog=thangnhps02396"

        Dim Connecting As SqlConnection = New SqlConnection(connectString)
        Dim Sqladapter As New SqlDataAdapter("select * from NhanVien Where MaNV ='" & txtID.Text & "' and Password='" & txtPassword.Text & "' ", Connecting)
        Dim table As New DataTable

        Try
            Connecting.Open()
            Sqladapter.Fill(table)

            If table.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công!", "Thông tin đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'xóa textbox sau khi thực hiện Đăng nhập thành công
                txtID.Clear()
                txtPassword.Clear()
                frmMain.Show()       'gọi form chính xuất hiện
                Me.Hide()            'ẩn form đăng nhập

            Else

                MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng!", _
                    "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Me.txtID.Text = ""
        Me.txtPassword.Text = ""
    End Sub
End Class
