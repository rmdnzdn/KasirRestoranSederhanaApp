<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class meja
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.tkode = New System.Windows.Forms.TextBox()
        Me.dgvmeja = New System.Windows.Forms.DataGridView()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bedit = New System.Windows.Forms.Button()
        Me.breset = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvmeja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Meja"
        '
        'bsimpan
        '
        Me.bsimpan.Location = New System.Drawing.Point(339, 127)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(75, 23)
        Me.bsimpan.TabIndex = 3
        Me.bsimpan.Text = "SIMPAN"
        Me.bsimpan.UseVisualStyleBackColor = True
        '
        'tkode
        '
        Me.tkode.Location = New System.Drawing.Point(338, 29)
        Me.tkode.Name = "tkode"
        Me.tkode.Size = New System.Drawing.Size(162, 20)
        Me.tkode.TabIndex = 1
        '
        'dgvmeja
        '
        Me.dgvmeja.AllowUserToDeleteRows = False
        Me.dgvmeja.AllowUserToOrderColumns = True
        Me.dgvmeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmeja.Location = New System.Drawing.Point(523, 29)
        Me.dgvmeja.Name = "dgvmeja"
        Me.dgvmeja.ReadOnly = True
        Me.dgvmeja.Size = New System.Drawing.Size(263, 168)
        Me.dgvmeja.TabIndex = 7
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(338, 76)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(162, 20)
        Me.tnama.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Meja"
        '
        'bedit
        '
        Me.bedit.Location = New System.Drawing.Point(425, 127)
        Me.bedit.Name = "bedit"
        Me.bedit.Size = New System.Drawing.Size(75, 23)
        Me.bedit.TabIndex = 4
        Me.bedit.Text = "EDIT"
        Me.bedit.UseVisualStyleBackColor = True
        '
        'breset
        '
        Me.breset.Location = New System.Drawing.Point(425, 174)
        Me.breset.Name = "breset"
        Me.breset.Size = New System.Drawing.Size(75, 23)
        Me.breset.TabIndex = 6
        Me.breset.Text = "RESET"
        Me.breset.UseVisualStyleBackColor = True
        '
        'bhapus
        '
        Me.bhapus.Location = New System.Drawing.Point(339, 174)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(75, 23)
        Me.bhapus.TabIndex = 5
        Me.bhapus.Text = "HAPUS"
        Me.bhapus.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(711, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "KEMBALI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BAP_restoran.My.Resources.Resources.table
        Me.PictureBox1.Location = New System.Drawing.Point(24, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 201)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'meja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(811, 236)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.breset)
        Me.Controls.Add(Me.bhapus)
        Me.Controls.Add(Me.bedit)
        Me.Controls.Add(Me.tnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvmeja)
        Me.Controls.Add(Me.tkode)
        Me.Controls.Add(Me.bsimpan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "meja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "meja"
        CType(Me.dgvmeja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bsimpan As System.Windows.Forms.Button
    Friend WithEvents tkode As System.Windows.Forms.TextBox
    Friend WithEvents dgvmeja As System.Windows.Forms.DataGridView
    Friend WithEvents tnama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bedit As System.Windows.Forms.Button
    Friend WithEvents breset As System.Windows.Forms.Button
    Friend WithEvents bhapus As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
