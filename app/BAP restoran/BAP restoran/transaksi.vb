Public Class transaksi
    Dim quertransaksi As String
    Dim quermenu As String

    Private Sub transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        tampildatamenu()
        tampildatatransaksi()
        autokode()
        autonomor()
        isimeja()
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.05
        bhapus.Enabled = False
        bpilihmenu.Enabled = True
        tkodemenu.Enabled = False
        tkodetransaksi.Enabled = False
        tanggal.Format = DateTimePickerFormat.Custom
        tanggal.CustomFormat = "dd/MM/yyyy"
        tanggal.Enabled = False
        tsubtotal.Enabled = False
        tbayar.Enabled = False
        tkembali.Enabled = False
        tjumlahporsi.Enabled = True
        bbayar.Enabled = False
        bselesai.Enabled = False
        bstruk.Enabled = False
        bpesansemua.Enabled = False

    End Sub
    Sub tampildatamenu()
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


    Sub tampildatatransaksi()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT  tb_transaksi.no_pesanan,  tb_meja.nama_meja, tb_menu.kode_menu, tb_menu.nama_menu, tb_menu.jenis_menu, tb_menu.harga_menu, tb_transaksi.jumlah_porsi, tb_transaksi.total FROM (tb_menu INNER JOIN tb_transaksi ON tb_menu.kode_menu = tb_transaksi.kode_menu) INNER JOIN tb_meja ON tb_transaksi.kode_meja = tb_meja.kode_meja where kode_transaksi='" & tkodetransaksi.Text & "' and status='proses'", cn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_transaksi")
        dgvtransaksi.DataSource = DS.Tables("tb_transaksi")
        dgvtransaksi.Enabled = True
        DA.Dispose()
        DS.Dispose()
        cn.Close()
        dgvtransaksi.Columns(0).HeaderText = "Nomor Pesanan"
        dgvtransaksi.Columns(1).HeaderText = "Nama Meja"
        dgvtransaksi.Columns(2).HeaderText = "Kode Menu"
        dgvtransaksi.Columns(3).HeaderText = "Nama Menu"
        dgvtransaksi.Columns(4).HeaderText = "jenis menu "
        dgvtransaksi.Columns(5).HeaderText = "harga menu"
        dgvtransaksi.Columns(6).HeaderText = "jumlah porsi"
        dgvtransaksi.Columns(7).HeaderText = "Total"
        dgvtransaksi.Columns(0).Width = 90
        dgvtransaksi.Columns(1).Width = 130
        dgvtransaksi.Columns(2).Width = 130
        dgvtransaksi.Columns(3).Width = 160
        dgvtransaksi.Columns(4).Width = 170
        dgvtransaksi.Columns(5).Width = 120
        dgvtransaksi.Columns(6).Width = 80
        dgvtransaksi.Columns(7).Width = 120
        subtotal()
    End Sub
    Sub isimeja()
        CMD = New OleDb.OleDbCommand("Select kode_meja from tb_meja", cn)
        DR = CMD.ExecuteReader
        While DR.Read = True
            ListBox1.Items.Add(DR("kode_meja").ToString)
        End While
    End Sub

    Sub autokode()
        Dim tes As String
        konek()
        CMD = New OleDb.OleDbCommand("Select * from tb_transaksi where status='terbayar' order by kode_transaksi desc", cn)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            tkodetransaksi.Text = "KT" + "001"
        Else
            tes = Val(Mid(DR.Item("kode_transaksi").ToString, 3, 3)) + 1
        End If

        If Len(tes) = 1 Then
            tkodetransaksi.Text = "KT" + "00" + tes
        ElseIf Len(tes) = 2 Then
            tkodetransaksi.Text = "KT" + "0" + tes
        ElseIf Len(tes) = 3 Then
            tkodetransaksi.Text = "KT" + "" + tes
        End If
    End Sub

    Sub autonomor()
        Dim tes As String
        konek()
        CMD = New OleDb.OleDbCommand("select * from tb_transaksi where kode_transaksi='" & tkodetransaksi.Text & "' order by no_pesanan desc", cn)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            tnopesan.Text = "001"
        Else
            tes = Val(Mid(DR.Item("no_pesanan").ToString, 1, 3)) + 1
        End If
        If Len(tes) = 1 Then
            tnopesan.Text = "00" + tes
        ElseIf Len(tes) = 2 Then
            tnopesan.Text = "0" + tes
        ElseIf Len(tes) = 3 Then
            tnopesan.Text = "" + tes
        End If
    End Sub

    Sub subtotal()
        Dim total As Integer
        For a = 0 To dgvtransaksi.RowCount - 1
            total = total + dgvtransaksi.Item(7, a).Value
        Next
        tsubtotal.Text = total
    End Sub


    Private Sub dgvmenu_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvmenu.RowHeaderMouseClick
        Dim i As Integer
        i = e.RowIndex
        tkodemenu.Text = dgvmenu.Item(0, i).Value
        thargamenu.Text = dgvmenu.Item(3, i).Value
        tkodemenu.Enabled = False
        bpilihmenu.Enabled = True
        bhapus.Enabled = False
        tjumlahporsi.Text = ""
        ttotal.Text = ""
        tjumlahporsi.Enabled = True
        tjumlahporsi.Focus()
        autonomor()
    End Sub

    Private Sub tjumlahporsi_KeyUp(sender As Object, e As KeyEventArgs) Handles tjumlahporsi.KeyUp
        ttotal.Text = Val(thargamenu.Text) * Val(tjumlahporsi.Text)
        bpilihmenu.Focus()

    End Sub


    Private Sub dgvtransaksi_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvtransaksi.RowHeaderMouseClick
        Dim i As Integer
        i = e.RowIndex
        tnopesan.Text = dgvtransaksi.Item(2, i).Value
        tkodemenu.Text = dgvtransaksi.Item(5, i).Value
        thargamenu.Text = dgvtransaksi.Item(8, i).Value
        tjumlahporsi.Text = dgvtransaksi.Item(9, i).Value
        ttotal.Text = dgvtransaksi.Item(10, i).Value
        bpilihmenu.Enabled = False
        bhapus.Enabled = True
        tjumlahporsi.Enabled = False


    End Sub

    Private Sub bpesan_Click(sender As Object, e As EventArgs) Handles bpilihmenu.Click
        If tkodemenu.Text = "" Or tjumlahporsi.Text = "" Or ListBox1.SelectedItem = "" Then

        End If
        sql = "insert into tb_transaksi values('" & tkodetransaksi.Text & "','" & tanggal.Text & "','" & tnopesan.Text & "','" & ListBox1.SelectedItem & "','" & tkodemenu.Text & "','" & tjumlahporsi.Text & "','" & ttotal.Text & "','proses')"
        msg = "menu berhasil dipilih"
        runsql()
        tampildatatransaksi()
        autonomor()
        subtotal()
        ListBox1.Enabled = False
        bpesansemua.Enabled = True
        tkodemenu.Text = ""
        thargamenu.Text = ""
        tjumlahporsi.Text = ""
        ttotal.Text = ""
        dgvmenu.Focus()

    End Sub

    Private Sub bpesansemua_Click(sender As Object, e As EventArgs) Handles bpesansemua.Click
        sql = "update tb_transaksi set status='belum terbayar' where kode_transaksi and status='proses'"
        msg = "semua menu berhasil dipesan"
        runsql()
        dgvmenu.Enabled = False
        tbayar.Enabled = True
        bbayar.Enabled = True
        dgvtransaksi.Enabled = False
        bpilihmenu.Enabled = False
        bhapus.Enabled = False
        tbayar.Focus()
    End Sub
    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        sql = "delete from tb_transaksi where kode_menu='" & tkodemenu.Text & "' and no_pesanan='" & tnopesan.Text & "'"
        msg = "menu Berhasil Dihapus"
        runsql()
        tampildatatransaksi()
        tkodemenu.Text = ""
        thargamenu.Text = ""
        tjumlahporsi.Text = ""
        ttotal.Text = ""
    End Sub
    Private Sub dgvtransaksi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtransaksi.CellContentClick

    End Sub

    Private Sub bbayar_Click(sender As Object, e As EventArgs) Handles bbayar.Click
        If Val(tbayar.Text) < Val(tsubtotal.Text) Then
            MsgBox("Maaf uang Anda tidak cukup")
            tbayar.Text = ""
        ElseIf tsubtotal.Text = ""
            MsgBox("Pesan Terlebih Dahulu Menunya")

        Else
            tkembali.Text = Val(tbayar.Text - tsubtotal.Text)
            sql = "update tb_transaksi set status='terbayar' where kode_transaksi and status='belum terbayar'"
            msg = "Kemblian Anda =" + tkembali.Text
            runsql()
            subtotal()
            bstruk.Enabled = True
            bstruk.Focus()
            bpesansemua.Enabled = False

            'tampildatamenu()
            'tampildatatransaksi()
            'autokode()
            'autonomor()
            'bhapus.Enabled = False
            'ListBox1.Enabled = True
            'bpilihmenu.Enabled = True
            'bpesansemua.Enabled = False
            'tkodemenu.Enabled = False
            'tkodetransaksi.Enabled = False
            'totalsemua()
            'tsubtotal.Text = tsubtotal.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ListBox1.Enabled = True
    End Sub

    Private Sub bstruk_Click(sender As Object, e As EventArgs) Handles bstruk.Click
        bselesai.Enabled = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        bselesai.Focus()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim linesPerpage As Single = 0
        Dim yPos As Single = 0
        Dim xPos As Single = 0
        Dim count As Single = 0
        Dim count2 As Single = 0
        Dim line As String = Nothing
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim rightMargin As Single = e.MarginBounds.Right
        Dim myFont As Font = dgvtransaksi.Font
        Dim q As Font = New Font("Script MT Bold", 40)
        Dim kd As Font = New Font("Cooper Black", 14)
        Dim al As Font = New Font("Dotum", 15)
        Dim tt As Font = New Font("Dotum", 12)
        linesPerpage = e.MarginBounds.Height / myFont.Height()
        Dim i As Integer
        e.Graphics.DrawString("Golden Chef", q, Brushes.Black, (leftMargin + (23 * myFont.Height)), (topMargin + (count * myFont.Height)))
        count = 4
        e.Graphics.DrawString("Restaurant", q, Brushes.Black, (leftMargin + (23 * myFont.Height)), (topMargin + (count * myFont.Height)))
        count = 10
        e.Graphics.DrawString("Jl.Menuju Kemenangan No 17-08 , Bogor, 11505071", al, Brushes.Black, (leftMargin + (14 * myFont.Height)), (topMargin + (count * myFont.Height)))
        count = 12
        e.Graphics.DrawString("0838-1194-1421", al, Brushes.Black, (leftMargin + (27 * myFont.Height)), (topMargin + (count * myFont.Height)))
        count = 14
        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", kd, Brushes.Black, (leftMargin + (-10 * myFont.Height)), (topMargin + (count * myFont.Height)))
        count = 16

        e.Graphics.DrawString("Kode Transaksi", kd, Brushes.Black, (leftMargin + (0 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString(":", kd, Brushes.Black, (leftMargin + (13 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString(tkodetransaksi.Text, kd, Brushes.Black, (leftMargin + (14 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString("||", kd, Brushes.Black, (leftMargin + (20 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString("Tanggal Transaksi", kd, Brushes.Black, (leftMargin + (22.5 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString(":", kd, Brushes.Black, (leftMargin + (37 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString(tanggal.Text, kd, Brushes.Black, (leftMargin + (38.5 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString("||", kd, Brushes.Black, (leftMargin + (48.5 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString("Nama Meja", kd, Brushes.Black, (leftMargin + (52 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString(":", kd, Brushes.Black, (leftMargin + (61.1 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString(dgvtransaksi.Item(1, i).Value, kd, Brushes.Black, (leftMargin + (62.5 * myFont.Height)), (topMargin + (count * myFont.Height)))
        count = 18
        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", kd, Brushes.Black, (leftMargin + (-10 * myFont.Height)), (topMargin + (count * myFont.Height)))
        count = 20

        e.Graphics.DrawString("NO", dgvtransaksi.Font, Brushes.Black, (leftMargin + (6.9 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString("NAMA MEJA", dgvtransaksi.Font, Brushes.Black, (leftMargin + (10 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString("KODE MENU", dgvtransaksi.Font, Brushes.Black, (leftMargin + (18 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString("NAMA MENU", dgvtransaksi.Font, Brushes.Black, (leftMargin + (26 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString("JENIS", dgvtransaksi.Font, Brushes.Black, (leftMargin + (35.5 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString("HARGA", dgvtransaksi.Font, Brushes.Black, (leftMargin + (42 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString("JUMLAH", dgvtransaksi.Font, Brushes.Black, (leftMargin + (47.5 * myFont.Height)), (topMargin + (count * myFont.Height)))
        e.Graphics.DrawString("TOTAL", dgvtransaksi.Font, Brushes.Black, (leftMargin + (54 * myFont.Height)), (topMargin + (count * myFont.Height)))
        count = 20.6
        e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", kd, Brushes.Black, (leftMargin + (6.8 * myFont.Height)), (topMargin + (count * myFont.Height)))
        count = 22.2
        For i = 0 To dgvtransaksi.RowCount - 1
            yPos = (topMargin + (count * myFont.Height))

            e.Graphics.DrawString(dgvtransaksi.Item(0, i).Value, dgvtransaksi.Font, Brushes.Black, (leftMargin + (6.9 * myFont.Height)), yPos)
            e.Graphics.DrawString(dgvtransaksi.Item(1, i).Value, dgvtransaksi.Font, Brushes.Black, (leftMargin + (11 * myFont.Height)), yPos)
            e.Graphics.DrawString(dgvtransaksi.Item(2, i).Value, dgvtransaksi.Font, Brushes.Black, (leftMargin + (19 * myFont.Height)), yPos)
            e.Graphics.DrawString(dgvtransaksi.Item(3, i).Value, dgvtransaksi.Font, Brushes.Black, (leftMargin + (26.5 * myFont.Height)), yPos)
            e.Graphics.DrawString(dgvtransaksi.Item(4, i).Value, dgvtransaksi.Font, Brushes.Black, (leftMargin + (35 * myFont.Height)), yPos)
            e.Graphics.DrawString(dgvtransaksi.Item(5, i).Value, dgvtransaksi.Font, Brushes.Black, (leftMargin + (42.5 * myFont.Height)), yPos)
            e.Graphics.DrawString(dgvtransaksi.Item(6, i).Value, dgvtransaksi.Font, Brushes.Black, (leftMargin + (48.8 * myFont.Height)), yPos)
            e.Graphics.DrawString(dgvtransaksi.Item(7, i).Value, dgvtransaksi.Font, Brushes.Black, (leftMargin + (54 * myFont.Height)), yPos)

            count += 1.5

        Next
        count += i
        e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", kd, Brushes.Black, (leftMargin + (6.8 * myFont.Height)), (topMargin + (count - i - 2) * myFont.Height))
        count += i
        e.Graphics.DrawString("SUBTOTAL ", tt, Brushes.Black, (leftMargin + (42.5 * myFont.Height)), (topMargin + (count - i - 4) * myFont.Height))
        e.Graphics.DrawString(tsubtotal.Text, tt, Brushes.Black, (rightMargin + (-16 * myFont.Height)), (topMargin + (count - i - 4) * myFont.Height))
        count += i
        e.Graphics.DrawString("CASH ", tt, Brushes.Black, (leftMargin + (42.5 * myFont.Height)), (topMargin + (count - i - 6) * myFont.Height))
        e.Graphics.DrawString(tbayar.Text, tt, Brushes.Black, (rightMargin + (-16 * myFont.Height)), (topMargin + (count - i - 6) * myFont.Height))
        count += i
        e.Graphics.DrawString("---------------------", tt, Brushes.Black, (leftMargin + (42.5 * myFont.Height)), (topMargin + (count - i - 8.5) * myFont.Height))
        count += i
        e.Graphics.DrawString("CHANGE ", tt, Brushes.Black, (leftMargin + (42.5 * myFont.Height)), (topMargin + (count - i - 11.5) * myFont.Height))
        e.Graphics.DrawString(tkembali.Text, tt, Brushes.Black, (rightMargin + (-16 * myFont.Height)), (topMargin + (count - i - 11.5) * myFont.Height))

    End Sub
    Private Sub bselesai_Click(sender As Object, e As EventArgs) Handles bselesai.Click
        MsgBox("Transaksi Berhasil")
        tampildatamenu()
        tampildatatransaksi()
        autokode()
        autonomor()
        bhapus.Enabled = False
        tbayar.Enabled = False
        bbayar.Enabled = False
        bstruk.Enabled = False
        ListBox1.Enabled = True
        bpilihmenu.Enabled = True
        bpesansemua.Enabled = False
        tkodemenu.Enabled = False
        tkodetransaksi.Enabled = False
        tsubtotal.Text = ""
        tbayar.Text = ""
        tkembali.Text = ""
    End Sub


    Private Sub bkembali_Click(sender As Object, e As EventArgs) Handles bkembali.Click
        sql = "delete from tb_transaksi where status='proses'"
        msg = "Kembali Ke Menu Utama"
        runsql()
        utama.Show()
        Me.Hide()


    End Sub

    Private Sub tjumlahporsi_TextChanged(sender As Object, e As EventArgs) Handles tjumlahporsi.TextChanged

    End Sub

    Private Sub tanggal_ValueChanged(sender As Object, e As EventArgs) Handles tanggal.ValueChanged

    End Sub
End Class