<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogin = New Button()
        cmbRole = New ComboBox()
        lblRole = New Label()
        lblNama = New Label()
        lblNIM = New Label()
        txtNama = New TextBox()
        txtNIM = New TextBox()
        picImage = New PictureBox()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(139, 368)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Manager", "Staff"})
        cmbRole.Location = New Point(139, 155)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(182, 33)
        cmbRole.TabIndex = 1
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(48, 158)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(55, 25)
        lblRole.TabIndex = 2
        lblRole.Text = "Role :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(48, 227)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(68, 25)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama :"
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(48, 297)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(55, 25)
        lblNIM.TabIndex = 4
        lblNIM.Text = "NIM :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(139, 221)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(182, 31)
        txtNama.TabIndex = 5
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(139, 294)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(182, 31)
        txtNIM.TabIndex = 6
        ' 
        ' picImage
        ' 
        picImage.BorderStyle = BorderStyle.Fixed3D
        picImage.Location = New Point(139, 28)
        picImage.Name = "picImage"
        picImage.Size = New Size(100, 100)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 7
        picImage.TabStop = False
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(391, 450)
        Controls.Add(picImage)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        Controls.Add(lblNIM)
        Controls.Add(lblNama)
        Controls.Add(lblRole)
        Controls.Add(cmbRole)
        Controls.Add(btnLogin)
        Name = "FrmLogin"
        Text = "Login"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents picImage As PictureBox

End Class
