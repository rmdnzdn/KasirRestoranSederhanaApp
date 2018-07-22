Public Class daftar

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bdaftar.Click
        sql = "insert into tb_user values('" & tusername.Text & "','" & tpassword.Text & "','" & tnama.Text & "','" & cakses.SelectedItem & "','" & jk & "')"
        msg = "Pendaftaran Berhasil Disimpan"
        runsql()
        tusername.Text = ""
        tpassword.Text = ""
        tnama.Text = ""
        cakses.Items.Clear()
        With cakses.Items
            .Add("PEMILIK")
            .Add("ADMIN")
            .Add("KASIR")
        End With
        rbl.Checked = False
        rbp.Checked = False
    End Sub

    Private Sub daftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Dim jk As String
    Private Sub rbl_CheckedChanged(sender As Object, e As EventArgs) Handles rbl.CheckedChanged
        jk = "Laki-laki"
    End Sub

    Private Sub rbp_CheckedChanged(sender As Object, e As EventArgs) Handles rbp.CheckedChanged
        jk = "Perempuan"
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        utama.Show()
        Me.Hide()
    End Sub
End Class