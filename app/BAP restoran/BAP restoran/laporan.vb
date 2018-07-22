Public Class laporan

    Private Sub laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        tampildata()
        bulan()
        jenis()
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        subtotal()

    End Sub
    Sub tampildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT  tb_transaksi.kode_transaksi, tb_transaksi.tanggal_transaksi ,tb_transaksi.no_pesanan, tb_meja.kode_meja, tb_meja.nama_meja, tb_menu.kode_menu, tb_menu.nama_menu, tb_menu.jenis_menu, tb_menu.harga_menu, tb_transaksi.jumlah_porsi, tb_transaksi.total FROM (tb_menu INNER JOIN tb_transaksi ON tb_menu.kode_menu = tb_transaksi.kode_menu) INNER JOIN tb_meja ON tb_transaksi.kode_meja = tb_meja.kode_meja where status='terbayar'", cn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_transaksi")
        dgvlaporan.DataSource = DS.Tables("tb_transaksi")
        dgvlaporan.Enabled = True
        DA.Dispose()
        DS.Dispose()
        cn.Close()
        dgvlaporan.Columns(0).HeaderText = "Kode Transaksi"
        dgvlaporan.Columns(1).HeaderText = "Tanggal Transaksi"
        dgvlaporan.Columns(2).HeaderText = "Nomor Pesanan"
        dgvlaporan.Columns(3).HeaderText = "Kode Meja"
        dgvlaporan.Columns(4).HeaderText = "Nama Meja"
        dgvlaporan.Columns(5).HeaderText = "Kode Menu"
        dgvlaporan.Columns(6).HeaderText = "Nama Menu"
        dgvlaporan.Columns(7).HeaderText = "jenis menu "
        dgvlaporan.Columns(8).HeaderText = "harga menu"
        dgvlaporan.Columns(9).HeaderText = "jumlah porsi"
        dgvlaporan.Columns(10).HeaderText = "Total"
        dgvlaporan.Columns(2).Width = 70
        dgvlaporan.Columns(6).Width = 140
        dgvlaporan.Columns(7).Width = 110
        dgvlaporan.Columns(9).Width = 90
        dgvlaporan.Columns(9).Width = 50
        dgvlaporan.Columns(10).Width = 134
        dgvlaporan.ReadOnly = True
        subtotal()

    End Sub
    Sub bulan()
        With ComboBox1.Items
            .Add("Januari")
            .Add("Februari")
            .Add("Maret")
            .Add("April")
            .Add("Mei")
            .Add("Juni")
            .Add("Juli")
            .Add("Agustus")
            .Add("September")
            .Add("Oktober")
            .Add("November")
            .Add("Desember")
        End With
    End Sub
    Sub jenis()
        With ComboBox2.Items
            .Add("makanan")
            .Add("minuman")
        End With
    End Sub

    Dim a, b As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            a = 1
        ElseIf ComboBox1.SelectedIndex = 1 Then
            a = 2
        ElseIf ComboBox1.SelectedIndex = 2 Then
            a = 3
        ElseIf ComboBox1.SelectedIndex = 3 Then
            a = 4
        ElseIf ComboBox1.SelectedIndex = 4 Then
            a = 5
        ElseIf ComboBox1.SelectedIndex = 5 Then
            a = 6
        ElseIf ComboBox1.SelectedIndex = 6 Then
            a = 7
        ElseIf ComboBox1.SelectedIndex = 7 Then
            a = 8
        ElseIf ComboBox1.SelectedIndex = 8 Then
            a = 9
        ElseIf ComboBox1.SelectedIndex = 9 Then
            a = 10
        ElseIf ComboBox1.SelectedIndex = 10 Then
            a = 11
        ElseIf ComboBox1.SelectedIndex = 11 Then
            a = 12
        End If

        DA = New OleDb.OleDbDataAdapter("SELECT  tb_transaksi.kode_transaksi, tb_transaksi.tanggal_transaksi ,tb_transaksi.no_pesanan, tb_meja.kode_meja, tb_meja.nama_meja, tb_menu.kode_menu, tb_menu.nama_menu, tb_menu.jenis_menu, tb_menu.harga_menu, tb_transaksi.jumlah_porsi, tb_transaksi.total FROM (tb_menu INNER JOIN tb_transaksi ON tb_menu.kode_menu = tb_transaksi.kode_menu) INNER JOIN tb_meja ON tb_transaksi.kode_meja = tb_meja.kode_meja where MONTH(tanggal_transaksi) = '" + a + "'", cn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_transaksi")
        dgvlaporan.DataSource = DS.Tables("tb_transaksi")
        dgvlaporan.Enabled = True
        subtotal()


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        DA = New OleDb.OleDbDataAdapter("SELECT  tb_transaksi.kode_transaksi, tb_transaksi.tanggal_transaksi ,tb_transaksi.no_pesanan, tb_meja.kode_meja, tb_meja.nama_meja, tb_menu.kode_menu, tb_menu.nama_menu, tb_menu.jenis_menu, tb_menu.harga_menu, tb_transaksi.jumlah_porsi, tb_transaksi.total FROM (tb_menu INNER JOIN tb_transaksi ON tb_menu.kode_menu = tb_transaksi.kode_menu) INNER JOIN tb_meja ON tb_transaksi.kode_meja = tb_meja.kode_meja where jenis_menu='" & ComboBox2.SelectedItem & "'", cn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_transaksi")
        dgvlaporan.DataSource = DS.Tables("tb_transaksi")
        dgvlaporan.Enabled = True
        subtotal()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ComboBox1.Enabled = True
        ComboBox2.Enabled = False
        ComboBox2.Items.Clear()
        jenis()
        subtotal()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ComboBox2.Enabled = True
        ComboBox1.Enabled = False
        ComboBox1.Items.Clear()
        bulan()
        subtotal()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        utama.Show()
        Me.Hide()

    End Sub

    Sub subtotal()
        Dim total As Integer
        For r = 0 To dgvlaporan.RowCount - 1
            total = total + dgvlaporan.Item(10, r).Value
        Next
        tkeseluruhan.Text = total
    End Sub
End Class