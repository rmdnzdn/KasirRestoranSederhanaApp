Public Class Form1
    Public akses As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objcmd As New OleDb.OleDbCommand
        konek()
        sql = "select * from tb_user where username='" & tusername.Text & "' and password='" & tpassword.Text & "' and hak_akses='" & cakses.SelectedItem & "' "
        Try
            objcmd.Connection = cn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = sql
            If objcmd.ExecuteReader.Read Then
                akses = cakses.SelectedItem
                MsgBox("selamat datang")
                Me.Hide()
                utama.Show()
            Else
                MessageBox.Show("kombinasi username dan password salah", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tusername.Focus()
            End If
            tusername.Text = ""
            tpassword.Text = ""
            cakses.Items.Clear()
            With cakses.Items
                .Add("PEMILIK")
                .Add("ADMIN")
                .Add("KASIR")
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
