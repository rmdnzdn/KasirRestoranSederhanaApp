<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftar
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
        Me.rbp = New System.Windows.Forms.RadioButton()
        Me.rbl = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cakses = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tusername = New System.Windows.Forms.TextBox()
        Me.bdaftar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tnama = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbp
        '
        Me.rbp.AutoSize = True
        Me.rbp.Location = New System.Drawing.Point(224, 272)
        Me.rbp.Name = "rbp"
        Me.rbp.Size = New System.Drawing.Size(93, 17)
        Me.rbp.TabIndex = 6
        Me.rbp.TabStop = True
        Me.rbp.Text = "PEREMPUAN"
        Me.rbp.UseVisualStyleBackColor = True
        '
        'rbl
        '
        Me.rbl.AutoSize = True
        Me.rbl.Location = New System.Drawing.Point(144, 272)
        Me.rbl.Name = "rbl"
        Me.rbl.Size = New System.Drawing.Size(74, 17)
        Me.rbl.TabIndex = 5
        Me.rbl.TabStop = True
        Me.rbl.Text = "LAKI-LAKI"
        Me.rbl.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "JENIS KELAMIN"
        '
        'cakses
        '
        Me.cakses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cakses.FormattingEnabled = True
        Me.cakses.Items.AddRange(New Object() {"PEMILIK", "ADMIN", "KASIR"})
        Me.cakses.Location = New System.Drawing.Point(144, 230)
        Me.cakses.Name = "cakses"
        Me.cakses.Size = New System.Drawing.Size(173, 21)
        Me.cakses.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "HAK AKSES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "PASSWORD"
        '
        'tpassword
        '
        Me.tpassword.Location = New System.Drawing.Point(144, 160)
        Me.tpassword.Name = "tpassword"
        Me.tpassword.Size = New System.Drawing.Size(173, 20)
        Me.tpassword.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "USERNAME"
        '
        'tusername
        '
        Me.tusername.Location = New System.Drawing.Point(144, 121)
        Me.tusername.Name = "tusername"
        Me.tusername.Size = New System.Drawing.Size(173, 20)
        Me.tusername.TabIndex = 1
        '
        'bdaftar
        '
        Me.bdaftar.Location = New System.Drawing.Point(144, 312)
        Me.bdaftar.Name = "bdaftar"
        Me.bdaftar.Size = New System.Drawing.Size(75, 23)
        Me.bdaftar.TabIndex = 7
        Me.bdaftar.Text = "DAFTAR"
        Me.bdaftar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(242, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "BATAL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Location = New System.Drawing.Point(-18, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 28)
        Me.Panel1.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gabriola", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(177, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 54)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "DAFTAR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BAP_restoran.My.Resources.Resources.add_friend
        Me.PictureBox1.InitialImage = Global.BAP_restoran.My.Resources.Resources.user_list
        Me.PictureBox1.Location = New System.Drawing.Point(116, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "NAMA"
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(144, 195)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(173, 20)
        Me.tnama.TabIndex = 3
        '
        'daftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(381, 378)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tnama)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bdaftar)
        Me.Controls.Add(Me.rbp)
        Me.Controls.Add(Me.rbl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cakses)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tpassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tusername)
        Me.Name = "daftar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "daftar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbp As System.Windows.Forms.RadioButton
    Friend WithEvents rbl As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cakses As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tusername As System.Windows.Forms.TextBox
    Friend WithEvents bdaftar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tnama As System.Windows.Forms.TextBox
End Class
