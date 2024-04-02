<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        LoginButton = New Button()
        PasswordTextbox = New TextBox()
        EmailTextbox = New TextBox()
        EmailLabel = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' LoginButton
        ' 
        LoginButton.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginButton.Location = New Point(141, 250)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(112, 34)
        LoginButton.TabIndex = 0
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = True
        ' 
        ' PasswordTextbox
        ' 
        PasswordTextbox.Location = New Point(110, 198)
        PasswordTextbox.Name = "PasswordTextbox"
        PasswordTextbox.Size = New Size(223, 31)
        PasswordTextbox.TabIndex = 1
        ' 
        ' EmailTextbox
        ' 
        EmailTextbox.Location = New Point(110, 109)
        EmailTextbox.Name = "EmailTextbox"
        EmailTextbox.Size = New Size(223, 31)
        EmailTextbox.TabIndex = 2
        ' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EmailLabel.Location = New Point(110, 81)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(65, 25)
        EmailLabel.TabIndex = 3
        EmailLabel.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(110, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 25)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' LOGIN
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.WhatsApp_Image_2024_03_29_at_18_49_43_633f50f6
        ClientSize = New Size(799, 450)
        Controls.Add(Label2)
        Controls.Add(EmailLabel)
        Controls.Add(EmailTextbox)
        Controls.Add(PasswordTextbox)
        Controls.Add(LoginButton)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "LOGIN"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginButton As Button
    Friend WithEvents PasswordTextbox As TextBox
    Friend WithEvents EmailTextbox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents Label2 As Label

End Class
