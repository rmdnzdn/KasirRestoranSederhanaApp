<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.breset = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.bedit = New System.Windows.Forms.Button()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvmenu = New System.Windows.Forms.DataGridView()
        Me.tkode = New System.Windows.Forms.TextBox()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tharga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cjenis = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'breset
        '
        Me.breset.Location = New System.Drawing.Point(212, 366)
        Me.breset.Name = "breset"
        Me.breset.Size = New System.Drawing.Size(75, 23)
        Me.breset.TabIndex = 9
        Me.breset.Text = "RESET"
        Me.breset.UseVisualStyleBackColor = True
        '
        'bhapus
        '
        Me.bhapus.Location = New System.Drawing.Point(125, 366)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(75, 23)
        Me.bhapus.TabIndex = 8
        Me.bhapus.Text = "HAPUS"
        Me.bhapus.UseVisualStyleBackColor = True
        '
        'bedit
        '
        Me.bedit.Location = New System.Drawing.Point(212, 325)
        Me.bedit.Name = "bedit"
        Me.bedit.Size = New System.Drawing.Size(75, 23)
        Me.bedit.TabIndex = 7
        Me.bedit.Text = "EDIT"
        Me.bedit.UseVisualStyleBackColor = True
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(125, 198)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(162, 20)
        Me.tnama.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama Menu"
        '
        'dgvmenu
        '
        Me.dgvmenu.AllowUserToDeleteRows = False
        Me.dgvmenu.AllowUserToOrderColumns = True
        Me.dgvmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmenu.Location = New System.Drawing.Point(320, 151)
        Me.dgvmenu.Name = "dgvmenu"
        Me.dgvmenu.ReadOnly = True
        Me.dgvmenu.Size = New System.Drawing.Size(447, 238)
        Me.dgvmenu.TabIndex = 6
        '
        'tkode
        '
        Me.tkode.Location = New System.Drawing.Point(125, 151)
        Me.tkode.Name = "tkode"
        Me.tkode.Size = New System.Drawing.Size(162, 20)
        Me.tkode.TabIndex = 1
        '
        'bsimpan
        '
        Me.bsimpan.Location = New System.Drawing.Point(125, 325)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(75, 23)
        Me.bsimpan.TabIndex = 5
        Me.bsimpan.Text = "SIMPAN"
        Me.bsimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kode Menu"
        '
        'tharga
        '
        Me.tharga.Location = New System.Drawing.Point(125, 286)
        Me.tharga.Name = "tharga"
        Me.tharga.Size = New System.Drawing.Size(162, 20)
        Me.tharga.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Harga Menu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Jenis Menu"
        '
        'cjenis
        '
        Me.cjenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cjenis.FormattingEnabled = True
        Me.cjenis.Items.AddRange(New Object() {"makanan", "minuman"})
        Me.cjenis.Location = New System.Drawing.Point(125, 239)
        Me.cjenis.Name = "cjenis"
        Me.cjenis.Size = New System.Drawing.Size(162, 21)
        Me.cjenis.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gabriola", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(422, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 65)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "MENU"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Location = New System.Drawing.Point(-1, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 31)
        Me.Panel2.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(692, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "KEMBALI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BAP_restoran.My.Resources.Resources.room_service__1_
        Me.PictureBox1.Location = New System.Drawing.Point(290, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(802, 432)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cjenis)
        Me.Controls.Add(Me.tharga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.breset)
        Me.Controls.Add(Me.bhapus)
        Me.Controls.Add(Me.bedit)
        Me.Controls.Add(Me.tnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvmenu)
        Me.Controls.Add(Me.tkode)
        Me.Controls.Add(Me.bsimpan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menu"
        CType(Me.dgvmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents breset As System.Windows.Forms.Button
    Friend WithEvents bhapus As System.Windows.Forms.Button
    Friend WithEvents bedit As System.Windows.Forms.Button
    Friend WithEvents tnama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvmenu As System.Windows.Forms.DataGridView
    Friend WithEvents tkode As System.Windows.Forms.TextBox
    Friend WithEvents bsimpan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tharga As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cjenis As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
