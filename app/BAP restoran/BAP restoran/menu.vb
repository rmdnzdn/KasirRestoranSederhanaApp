Public Class menu

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        tampildata()
        autokode()
        tkode.Enabled = False
        bhapus.Enabled = False
    End Sub
    Sub tampildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("select * from tb_menu", cn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_menu")
        dgvmenu.DataSource = DS.Tables("tb_menu")
        dgvmenu.Enabled = True
        DA.Dispose()
        DS.Dispose()
        cn.Close()
        dgvmenu.Columns(0).HeaderText = "Kode Menu"
        dgvmenu.Columns(1).HeaderText = "Nama Menu"
        dgvmenu.Columns(2).HeaderText = "Jenis Menu"
        dgvmenu.Columns(3).HeaderText = "Harga Menu"
    End Sub

    Sub bersih()
        autokode()
        tnama.Text = ""
        cjenis.Text = ""
        tharga.Text = ""
        tkode.Enabled = False
        bsimpan.Enabled = True
        bedit.Enabled = False
        bhapus.Enabled = False
        cjenis.Items.Clear()
        With cjenis
            .Items.Add("makanan")
            .Items.Add("minuman")
        End With
    End Sub

    Sub autokode()
        Dim tes As String
        konek()
        CMD = New OleDb.OleDbCommand("select * from tb_menu order by kode_menu desc", cn)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            tkode.Text = "KMN" + "001"
        Else
            tes = Val(Mid(DR.Item("kode_menu").ToString, 4, 3)) + 1
        End If

        If Len(tes) = 1 Then
            tkode.Text = "KMN" + "00" + tes
        ElseIf Len(tes) = 2 Then
            tkode.Text = "KMN" + "0" + tes
        ElseIf Len(tes) = 3 Then
            tkode.Text = "KMN" + "" + tes
        End If
    End Sub


    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        sql = "insert into tb_menu values('" & tkode.Text & "','" & tnama.Text & "','" & cjenis.SelectedItem & "','" & tharga.Text & "')"
        msg = "Data Berhasil Disimpan"
        runsql()
        tampildata()
        bersih()
    End Sub


    Private Sub bedit_Click(sender As Object, e As EventArgs) Handles bedit.Click
        sql = "update tb_menu set nama_menu='" & tnama.Text & "', jenis_menu='" & cjenis.SelectedItem & "',harga_menu='" & tharga.Text & "' where kode_menu='" & tkode.Text & "'"
        msg = "Data Berhasil Diedit"
        runsql()
        tampildata()
        bersih()

    End Sub


    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        sql = "delete from tb_menu where kode_menu='" & tkode.Text & "'"
        msg = "Data Berhasil Dihapus"
        runsql()
        tampildata()
        bersih()
    End Sub

    Private Sub breset_Click(sender As Object, e As EventArgs) Handles breset.Click
        bersih()
    End Sub

    Private Sub dgvmenu_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvmenu.RowHeaderMouseClick
        Dim i As Integer
        i = e.RowIndex
        tkode.Text = dgvmenu.Item(0, i).Value
        tnama.Text = dgvmenu.Item(1, i).Value
        cjenis.Text = dgvmenu.Item(2, i).Value
        tharga.Text = dgvmenu.Item(3, i).Value
        tkode.Enabled = False
        bsimpan.Enabled = False
        bedit.Enabled = True
        bhapus.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        utama.Show()
        Me.Hide()

    End Sub
End Class