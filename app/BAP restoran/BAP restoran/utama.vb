Public Class utama

    Private Sub utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TransaksiToolStripMenuItem.Visible = False
        DataToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
        hak_akses()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Form1.Show()
        Dispose()

    End Sub
    Sub hak_akses()
        If Form1.akses = "PEMILIK" Then
            TransaksiToolStripMenuItem.Visible = False
            DataToolStripMenuItem.Visible = False
            LaporanToolStripMenuItem.Visible = True
        ElseIf Form1.akses = "KASIR"
            TransaksiToolStripMenuItem.Visible = True
            DataToolStripMenuItem.Visible = False
            LaporanToolStripMenuItem.Visible = False
        ElseIf Form1.akses = "ADMIN"
            TransaksiToolStripMenuItem.Visible = False
            DataToolStripMenuItem.Visible = True
            LaporanToolStripMenuItem.Visible = False
        End If

    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        End
    End Sub

    Private Sub InputDataMejaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataMejaToolStripMenuItem.Click
        meja.Show()
        Me.Hide()
    End Sub

    Private Sub InputDataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataMenuToolStripMenuItem.Click
        BAP_restoran.menu.Show()
        Me.Hide()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        sql = "delete from tb_transaksi where kode_transaksi ='" & transaksi.tkodetransaksi.Text & "' or status='proses' or status='belum terbayar'"
        msg = "Masuk Ke Form Transaksi"
        runsql()
        transaksi.tampildatamenu()
        transaksi.tampildatatransaksi()
        transaksi.autokode()
        transaksi.autonomor()
        transaksi.PrintDocument1.DefaultPageSettings.Landscape = True
        transaksi.PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.05
        transaksi.bhapus.Enabled = False
        transaksi.bpilihmenu.Enabled = True
        transaksi.tkodemenu.Enabled = False
        transaksi.tkodetransaksi.Enabled = False
        transaksi.tanggal.Format = DateTimePickerFormat.Custom
        transaksi.tanggal.CustomFormat = "dd/MM/yyyy"
        transaksi.tanggal.Enabled = False
        transaksi.tsubtotal.Enabled = False
        transaksi.tbayar.Enabled = False
        transaksi.tkembali.Enabled = False
        transaksi.tjumlahporsi.Enabled = True
        transaksi.bbayar.Enabled = False
        transaksi.bselesai.Enabled = False
        transaksi.bstruk.Enabled = False
        transaksi.bpesansemua.Enabled = False
        transaksi.ListBox1.Enabled = True
        transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub InputDataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataUserToolStripMenuItem.Click
        BAP_restoran.daftar.Show()
        Me.Hide()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        laporan.Show()
        Me.Hide()
    End Sub
End Class