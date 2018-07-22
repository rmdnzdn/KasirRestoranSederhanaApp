<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaksi))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tkodetransaksi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tkodemenu = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tnopesan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.thargamenu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ttotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tjumlahporsi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvtransaksi = New System.Windows.Forms.DataGridView()
        Me.dgvmenu = New System.Windows.Forms.DataGridView()
        Me.bpilihmenu = New System.Windows.Forms.Button()
        Me.bpesansemua = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.tsubtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbayar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tkembali = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.bbayar = New System.Windows.Forms.Button()
        Me.bstruk = New System.Windows.Forms.Button()
        Me.bselesai = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.bkembali = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvtransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Transaksi"
        '
        'tkodetransaksi
        '
        Me.tkodetransaksi.Location = New System.Drawing.Point(143, 29)
        Me.tkodetransaksi.Name = "tkodetransaksi"
        Me.tkodetransaksi.Size = New System.Drawing.Size(214, 20)
        Me.tkodetransaksi.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tanggal Transaksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Kode Menu"
        '
        'tkodemenu
        '
        Me.tkodemenu.Location = New System.Drawing.Point(35, 48)
        Me.tkodemenu.Name = "tkodemenu"
        Me.tkodemenu.Size = New System.Drawing.Size(131, 20)
        Me.tkodemenu.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tnopesan)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tanggal)
        Me.GroupBox1.Controls.Add(Me.tkodetransaksi)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(223, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 156)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESTO"
        '
        'tnopesan
        '
        Me.tnopesan.Enabled = False
        Me.tnopesan.Location = New System.Drawing.Point(143, 113)
        Me.tnopesan.Name = "tnopesan"
        Me.tnopesan.Size = New System.Drawing.Size(214, 20)
        Me.tnopesan.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nomor Pesanan"
        '
        'tanggal
        '
        Me.tanggal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.tanggal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tanggal.Location = New System.Drawing.Point(143, 68)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(214, 21)
        Me.tanggal.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 296)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pilih Meja"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(154, 277)
        Me.ListBox1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.thargamenu)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.ttotal)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.tjumlahporsi)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.tkodemenu)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(223, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(389, 134)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pilih Menu"
        '
        'thargamenu
        '
        Me.thargamenu.Enabled = False
        Me.thargamenu.Location = New System.Drawing.Point(35, 103)
        Me.thargamenu.Name = "thargamenu"
        Me.thargamenu.Size = New System.Drawing.Size(131, 20)
        Me.thargamenu.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Harga Menu"
        '
        'ttotal
        '
        Me.ttotal.Enabled = False
        Me.ttotal.Location = New System.Drawing.Point(228, 103)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.Size = New System.Drawing.Size(131, 20)
        Me.ttotal.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(278, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Total"
        '
        'tjumlahporsi
        '
        Me.tjumlahporsi.Location = New System.Drawing.Point(226, 48)
        Me.tjumlahporsi.Name = "tjumlahporsi"
        Me.tjumlahporsi.Size = New System.Drawing.Size(131, 20)
        Me.tjumlahporsi.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Jumlah Porsi"
        '
        'dgvtransaksi
        '
        Me.dgvtransaksi.AllowUserToDeleteRows = False
        Me.dgvtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtransaksi.Location = New System.Drawing.Point(34, 447)
        Me.dgvtransaksi.Name = "dgvtransaksi"
        Me.dgvtransaksi.ReadOnly = True
        Me.dgvtransaksi.Size = New System.Drawing.Size(1043, 227)
        Me.dgvtransaksi.TabIndex = 6
        '
        'dgvmenu
        '
        Me.dgvmenu.AllowUserToDeleteRows = False
        Me.dgvmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmenu.Location = New System.Drawing.Point(633, 54)
        Me.dgvmenu.Name = "dgvmenu"
        Me.dgvmenu.ReadOnly = True
        Me.dgvmenu.Size = New System.Drawing.Size(444, 296)
        Me.dgvmenu.TabIndex = 2
        '
        'bpilihmenu
        '
        Me.bpilihmenu.Location = New System.Drawing.Point(258, 378)
        Me.bpilihmenu.Name = "bpilihmenu"
        Me.bpilihmenu.Size = New System.Drawing.Size(114, 45)
        Me.bpilihmenu.TabIndex = 4
        Me.bpilihmenu.Text = "PILIH MENU"
        Me.bpilihmenu.UseVisualStyleBackColor = True
        '
        'bpesansemua
        '
        Me.bpesansemua.Location = New System.Drawing.Point(633, 379)
        Me.bpesansemua.Name = "bpesansemua"
        Me.bpesansemua.Size = New System.Drawing.Size(444, 57)
        Me.bpesansemua.TabIndex = 7
        Me.bpesansemua.Text = "PESAN SEMUA"
        Me.bpesansemua.UseVisualStyleBackColor = True
        '
        'bhapus
        '
        Me.bhapus.Location = New System.Drawing.Point(451, 379)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(114, 45)
        Me.bhapus.TabIndex = 5
        Me.bhapus.Text = "HAPUS MENU"
        Me.bhapus.UseVisualStyleBackColor = True
        '
        'tsubtotal
        '
        Me.tsubtotal.Location = New System.Drawing.Point(1143, 355)
        Me.tsubtotal.Multiline = True
        Me.tsubtotal.Name = "tsubtotal"
        Me.tsubtotal.Size = New System.Drawing.Size(174, 40)
        Me.tsubtotal.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1143, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "TOTAL KESELURUHAN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1140, 398)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "BAYAR"
        '
        'tbayar
        '
        Me.tbayar.Location = New System.Drawing.Point(1143, 414)
        Me.tbayar.Multiline = True
        Me.tbayar.Name = "tbayar"
        Me.tbayar.Size = New System.Drawing.Size(174, 37)
        Me.tbayar.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1140, 496)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "KEMBALI"
        '
        'tkembali
        '
        Me.tkembali.Location = New System.Drawing.Point(1143, 513)
        Me.tkembali.Multiline = True
        Me.tkembali.Name = "tkembali"
        Me.tkembali.Size = New System.Drawing.Size(174, 37)
        Me.tkembali.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Coral
        Me.Label11.Location = New System.Drawing.Point(1100, 366)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 19)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "RP."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Coral
        Me.Label12.Location = New System.Drawing.Point(1100, 424)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 19)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "RP."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Coral
        Me.Label13.Location = New System.Drawing.Point(1100, 517)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 19)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "RP."
        '
        'bbayar
        '
        Me.bbayar.Location = New System.Drawing.Point(1143, 456)
        Me.bbayar.Name = "bbayar"
        Me.bbayar.Size = New System.Drawing.Size(174, 37)
        Me.bbayar.TabIndex = 9
        Me.bbayar.Text = "BAYAR"
        Me.bbayar.UseVisualStyleBackColor = True
        '
        'bstruk
        '
        Me.bstruk.Location = New System.Drawing.Point(1143, 556)
        Me.bstruk.Name = "bstruk"
        Me.bstruk.Size = New System.Drawing.Size(174, 37)
        Me.bstruk.TabIndex = 10
        Me.bstruk.Text = "PRINT STRUCK"
        Me.bstruk.UseVisualStyleBackColor = True
        '
        'bselesai
        '
        Me.bselesai.Location = New System.Drawing.Point(1146, 599)
        Me.bselesai.Name = "bselesai"
        Me.bselesai.Size = New System.Drawing.Size(76, 37)
        Me.bselesai.TabIndex = 11
        Me.bselesai.Text = "SELESAI"
        Me.bselesai.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BAP_restoran.My.Resources.Resources.invoice
        Me.PictureBox1.Location = New System.Drawing.Point(1143, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.BAP_restoran.My.Resources.Resources.cash_machine
        Me.PictureBox2.Location = New System.Drawing.Point(1129, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(122, 101)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'bkembali
        '
        Me.bkembali.Location = New System.Drawing.Point(1228, 599)
        Me.bkembali.Name = "bkembali"
        Me.bkembali.Size = New System.Drawing.Size(89, 37)
        Me.bkembali.TabIndex = 12
        Me.bkembali.Text = "KEMBALI"
        Me.bkembali.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(1354, 701)
        Me.ControlBox = False
        Me.Controls.Add(Me.bkembali)
        Me.Controls.Add(Me.bselesai)
        Me.Controls.Add(Me.bstruk)
        Me.Controls.Add(Me.bbayar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tkembali)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbayar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tsubtotal)
        Me.Controls.Add(Me.dgvtransaksi)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.bpesansemua)
        Me.Controls.Add(Me.bpilihmenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.bhapus)
        Me.Controls.Add(Me.dgvmenu)
        Me.Controls.Add(Me.GroupBox2)
        Me.MinimizeBox = False
        Me.Name = "transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pilih Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvtransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tkodetransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tkodemenu As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents dgvtransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents ttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tjumlahporsi As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvmenu As System.Windows.Forms.DataGridView
    Friend WithEvents bpilihmenu As System.Windows.Forms.Button
    Friend WithEvents bpesansemua As System.Windows.Forms.Button
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents thargamenu As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bhapus As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tnopesan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbayar As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tkembali As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents bbayar As System.Windows.Forms.Button
    Friend WithEvents bstruk As System.Windows.Forms.Button
    Friend WithEvents bselesai As System.Windows.Forms.Button
    Friend WithEvents bkembali As Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
End Class
