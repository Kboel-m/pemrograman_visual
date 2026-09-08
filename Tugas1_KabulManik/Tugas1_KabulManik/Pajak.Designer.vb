<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPajak
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
        lblLimaJuta = New Label()
        lblTigaPuluh = New Label()
        lblSeratus = New Label()
        lblPendapatan = New Label()
        lblRupiah = New Label()
        btnHitung = New Button()
        btnKeluar = New Button()
        txtPendapatan = New TextBox()
        SuspendLayout()
        ' 
        ' lblLimaJuta
        ' 
        lblLimaJuta.AutoSize = True
        lblLimaJuta.Location = New Point(34, 57)
        lblLimaJuta.Name = "lblLimaJuta"
        lblLimaJuta.Size = New Size(321, 25)
        lblLimaJuta.TabIndex = 0
        lblLimaJuta.Text = "Pendapatan lebih dari 5 juta, 10% Pajak"
        ' 
        ' lblTigaPuluh
        ' 
        lblTigaPuluh.AutoSize = True
        lblTigaPuluh.Location = New Point(22, 101)
        lblTigaPuluh.Name = "lblTigaPuluh"
        lblTigaPuluh.Size = New Size(333, 25)
        lblTigaPuluh.TabIndex = 1
        lblTigaPuluh.Text = "Pendapatan lebih dari 30 Juta, 20% Pajak"
        ' 
        ' lblSeratus
        ' 
        lblSeratus.AutoSize = True
        lblSeratus.Location = New Point(12, 147)
        lblSeratus.Name = "lblSeratus"
        lblSeratus.Size = New Size(341, 25)
        lblSeratus.TabIndex = 2
        lblSeratus.Text = "Pendapatan lebih dari 100 juta, 30% Pajak"
        ' 
        ' lblPendapatan
        ' 
        lblPendapatan.AutoSize = True
        lblPendapatan.Location = New Point(115, 201)
        lblPendapatan.Name = "lblPendapatan"
        lblPendapatan.Size = New Size(190, 25)
        lblPendapatan.TabIndex = 3
        lblPendapatan.Text = "Masukkan Pendapatan"
        ' 
        ' lblRupiah
        ' 
        lblRupiah.AutoSize = True
        lblRupiah.Location = New Point(57, 250)
        lblRupiah.Name = "lblRupiah"
        lblRupiah.Size = New Size(38, 25)
        lblRupiah.TabIndex = 4
        lblRupiah.Text = "Rp."
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(115, 303)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 5
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(115, 343)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 6
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(115, 250)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(190, 31)
        txtPendapatan.TabIndex = 7
        ' 
        ' FrmPajak
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(377, 450)
        Controls.Add(txtPendapatan)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Controls.Add(lblRupiah)
        Controls.Add(lblPendapatan)
        Controls.Add(lblSeratus)
        Controls.Add(lblTigaPuluh)
        Controls.Add(lblLimaJuta)
        Name = "FrmPajak"
        Text = "Pajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLimaJuta As Label
    Friend WithEvents lblTigaPuluh As Label
    Friend WithEvents lblSeratus As Label
    Friend WithEvents lblPendapatan As Label
    Friend WithEvents lblRupiah As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtPendapatan As TextBox
End Class
