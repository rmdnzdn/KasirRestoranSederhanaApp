Public Class meja
    Private Sub meja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        tampildata()
        autokode()
        tkode.Enabled = False
        bhapus.Enabled = False
    End Sub
    Sub tampildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("select * from tb_meja", cn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_meja")
        dgvmeja.DataSource = DS.Tables("tb_meja")
        dgvmeja.Enabled = True
        DA.Dispose()
        DS.Dispose()
        cn.Close()
        dgvmeja.Columns(0).HeaderText = "Kode Meja"
        dgvmeja.Columns(1).HeaderText = "Nama Meja"
    End Sub

    Sub bersih()
        autokode()
        tnama.Text = ""
        tkode.Enabled = False
        bsimpan.Enabled = True
        bedit.Enabled = False
        bhapus.Enabled = False

    End Sub

    Sub autokode()
        Dim tes As String
        konek()
        CMD = New OleDb.OleDbCommand("select * from tb_meja order by kode_meja desc", cn)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            tkode.Text = "KM" + "001"
        Else
            tes = Val(Mid(DR.Item("kode_meja").ToString, 3, 3)) + 1
        End If

        If Len(tes) = 1 Then
            tkode.Text = "KM" + "00" + tes
        ElseIf Len(tes) = 2 Then
            tkode.Text = "KM" + "0" + tes
        ElseIf Len(tes) = 3 Then
            tkode.Text = "KM" + "" + tes
        End If
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        sql = "insert into tb_meja values('" & tkode.Text & "','" & tnama.Text & "')"
        msg = "Data Berhasil Disimpan"
        runsql()
        tampildata()
        bersih()
    End Sub

    Private Sub bedit_Click(sender As Object, e As EventArgs) Handles bedit.Click
        sql = "update tb_meja set nama_meja='" & tnama.Text & "' where kode_meja='" & tkode.Text & "'"
        msg = "Data Berhasil Di edit"
        runsql()
        tampildata()
        bersih()

    End Sub

    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        sql = "delete from tb_meja where kode_meja='" & tkode.Text & "'"
        msg = "Data Berhasil Dihapus"
        runsql()
        tampildata()
        bersih()
    End Sub

    Private Sub dgvmeja_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvmeja.RowHeaderMouseClick
        Dim i As Integer
        i = e.RowIndex
        tkode.Text = dgvmeja.Item(0, i).Value
        tnama.Text = dgvmeja.Item(1, i).Value
        tkode.Enabled = False
        bsimpan.Enabled = False
        bedit.Enabled = True
        bhapus.Enabled = True

    End Sub

    Private Sub breset_Click(sender As Object, e As EventArgs) Handles breset.Click
        bersih()
    End Sub

    Private Sub dgvmeja_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmeja.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        utama.Show()
        Me.Hide()

    End Sub
End Class