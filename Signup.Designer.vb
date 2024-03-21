<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Inputs = New GroupBox()
        passConfirm = New TextBox()
        FirstNameTextBoxValidation = New TextBox()
        Label2 = New Label()
        SignupButton = New Button()
        LastNameTxtbox = New TextBox()
        PhoneTextbox = New TextBox()
        ConfirmPasswordTXTbox = New TextBox()
        PasswordTxtBox = New TextBox()
        EmailTxtBox = New TextBox()
        FirstNameTextbox = New TextBox()
        ConfirmPassword = New Label()
        Password = New Label()
        Email = New Label()
        PhoneNumber = New Label()
        FirstNAme = New Label()
        LastName = New Label()
        Label1 = New Label()
        Inputs.SuspendLayout()
        SuspendLayout()
        ' 
        ' Inputs
        ' 
        Inputs.BackColor = Color.Transparent
        Inputs.Controls.Add(passConfirm)
        Inputs.Controls.Add(FirstNameTextBoxValidation)
        Inputs.Controls.Add(Label2)
        Inputs.Controls.Add(SignupButton)
        Inputs.Controls.Add(LastNameTxtbox)
        Inputs.Controls.Add(PhoneTextbox)
        Inputs.Controls.Add(ConfirmPasswordTXTbox)
        Inputs.Controls.Add(PasswordTxtBox)
        Inputs.Controls.Add(EmailTxtBox)
        Inputs.Controls.Add(FirstNameTextbox)
        Inputs.Controls.Add(ConfirmPassword)
        Inputs.Controls.Add(Password)
        Inputs.Controls.Add(Email)
        Inputs.Controls.Add(PhoneNumber)
        Inputs.Controls.Add(FirstNAme)
        Inputs.Controls.Add(LastName)
        Inputs.Location = New Point(22, 99)
        Inputs.Margin = New Padding(3, 4, 3, 4)
        Inputs.Name = "Inputs"
        Inputs.Padding = New Padding(3, 4, 3, 4)
        Inputs.Size = New Size(292, 528)
        Inputs.TabIndex = 1
        Inputs.TabStop = False
        ' 
        ' passConfirm
        ' 
        passConfirm.Location = New Point(162, 414)
        passConfirm.Name = "passConfirm"
        passConfirm.Size = New Size(106, 24)
        passConfirm.TabIndex = 16
        ' 
        ' FirstNameTextBoxValidation
        ' 
        FirstNameTextBoxValidation.Font = New Font("Microsoft Sans Serif", 3.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FirstNameTextBoxValidation.Location = New Point(20, 75)
        FirstNameTextBoxValidation.Name = "FirstNameTextBoxValidation"
        FirstNameTextBoxValidation.Size = New Size(123, 13)
        FirstNameTextBoxValidation.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 474)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 23)
        Label2.TabIndex = 14
        Label2.Text = "Already have an account ?"
        ' 
        ' SignupButton
        ' 
        SignupButton.BackColor = Color.Chocolate
        SignupButton.Location = New Point(59, 431)
        SignupButton.Margin = New Padding(3, 4, 3, 4)
        SignupButton.Name = "SignupButton"
        SignupButton.Size = New Size(121, 29)
        SignupButton.TabIndex = 13
        SignupButton.Text = "SIGN UP"
        SignupButton.UseVisualStyleBackColor = False
        ' 
        ' LastNameTxtbox
        ' 
        LastNameTxtbox.Location = New Point(20, 114)
        LastNameTxtbox.Margin = New Padding(3, 4, 3, 4)
        LastNameTxtbox.Name = "LastNameTxtbox"
        LastNameTxtbox.Size = New Size(172, 24)
        LastNameTxtbox.TabIndex = 12
        ' 
        ' PhoneTextbox
        ' 
        PhoneTextbox.Location = New Point(20, 181)
        PhoneTextbox.Margin = New Padding(3, 4, 3, 4)
        PhoneTextbox.Name = "PhoneTextbox"
        PhoneTextbox.Size = New Size(172, 24)
        PhoneTextbox.TabIndex = 11
        ' 
        ' ConfirmPasswordTXTbox
        ' 
        ConfirmPasswordTXTbox.Location = New Point(20, 383)
        ConfirmPasswordTXTbox.Margin = New Padding(3, 4, 3, 4)
        ConfirmPasswordTXTbox.Name = "ConfirmPasswordTXTbox"
        ConfirmPasswordTXTbox.Size = New Size(172, 24)
        ConfirmPasswordTXTbox.TabIndex = 10
        ' 
        ' PasswordTxtBox
        ' 
        PasswordTxtBox.Location = New Point(20, 316)
        PasswordTxtBox.Margin = New Padding(3, 4, 3, 4)
        PasswordTxtBox.Name = "PasswordTxtBox"
        PasswordTxtBox.Size = New Size(172, 24)
        PasswordTxtBox.TabIndex = 9
        ' 
        ' EmailTxtBox
        ' 
        EmailTxtBox.Location = New Point(20, 248)
        EmailTxtBox.Margin = New Padding(3, 4, 3, 4)
        EmailTxtBox.Name = "EmailTxtBox"
        EmailTxtBox.Size = New Size(172, 24)
        EmailTxtBox.TabIndex = 8
        ' 
        ' FirstNameTextbox
        ' 
        FirstNameTextbox.Location = New Point(20, 47)
        FirstNameTextbox.Margin = New Padding(3, 4, 3, 4)
        FirstNameTextbox.Name = "FirstNameTextbox"
        FirstNameTextbox.Size = New Size(172, 24)
        FirstNameTextbox.TabIndex = 7
        ' 
        ' ConfirmPassword
        ' 
        ConfirmPassword.AutoSize = True
        ConfirmPassword.Location = New Point(20, 360)
        ConfirmPassword.Name = "ConfirmPassword"
        ConfirmPassword.Size = New Size(118, 19)
        ConfirmPassword.TabIndex = 6
        ConfirmPassword.Text = "Confirm Password :"
        ' 
        ' Password
        ' 
        Password.AutoSize = True
        Password.Location = New Point(20, 292)
        Password.Name = "Password"
        Password.Size = New Size(70, 19)
        Password.TabIndex = 5
        Password.Text = "Password :"
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Location = New Point(20, 225)
        Email.Name = "Email"
        Email.Size = New Size(49, 19)
        Email.TabIndex = 4
        Email.Text = "Email :"
        ' 
        ' PhoneNumber
        ' 
        PhoneNumber.AutoSize = True
        PhoneNumber.Location = New Point(20, 158)
        PhoneNumber.Name = "PhoneNumber"
        PhoneNumber.Size = New Size(98, 19)
        PhoneNumber.TabIndex = 3
        PhoneNumber.Text = "Phone Number :"
        ' 
        ' FirstNAme
        ' 
        FirstNAme.AutoSize = True
        FirstNAme.Location = New Point(20, 25)
        FirstNAme.Name = "FirstNAme"
        FirstNAme.Size = New Size(77, 19)
        FirstNAme.TabIndex = 2
        FirstNAme.Text = "First Name :"
        ' 
        ' LastName
        ' 
        LastName.AutoSize = True
        LastName.Location = New Point(20, 91)
        LastName.Name = "LastName"
        LastName.Size = New Size(74, 19)
        LastName.TabIndex = 1
        LastName.Text = "Last Name :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sitka Display", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(293, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 69)
        Label1.TabIndex = 2
        Label1.Text = "SIGN UP" & vbCrLf
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(7F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Relocation_Movers1_1170x780__1_
        ClientSize = New Size(724, 740)
        Controls.Add(Label1)
        Controls.Add(Inputs)
        Font = New Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Margin = New Padding(3, 4, 3, 4)
        Name = "Signup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Signup"
        Inputs.ResumeLayout(False)
        Inputs.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Inputs As GroupBox
    Friend WithEvents LastName As Label
    Friend WithEvents ConfirmPassword As Label
    Friend WithEvents Password As Label
    Friend WithEvents Email As Label
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents FirstNAme As Label
    Friend WithEvents LastNameTxtbox As TextBox
    Friend WithEvents PhoneTextbox As TextBox
    Friend WithEvents ConfirmPasswordTXTbox As TextBox
    Friend WithEvents PasswordTxtBox As TextBox
    Friend WithEvents EmailTxtBox As TextBox
    Friend WithEvents FirstNameTextbox As TextBox
    Friend WithEvents SignupButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNameTextBoxValidation As TextBox
    Friend WithEvents passConfirm As TextBox
End Class
