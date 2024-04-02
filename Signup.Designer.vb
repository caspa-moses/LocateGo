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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup))
        Inputs = New GroupBox()
        LinkLabel1 = New LinkLabel()
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
        Inputs.Controls.Add(LinkLabel1)
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
        Inputs.ForeColor = SystemColors.ControlText
        Inputs.Location = New Point(4, 25)
        Inputs.Margin = New Padding(4)
        Inputs.Name = "Inputs"
        Inputs.Padding = New Padding(4)
        Inputs.Size = New Size(610, 579)
        Inputs.TabIndex = 1
        Inputs.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(217, 492)
        LinkLabel1.Margin = New Padding(4, 0, 4, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(51, 19)
        LinkLabel1.TabIndex = 15
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Log in"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(47, 490)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 21)
        Label2.TabIndex = 14
        Label2.Text = "Already have an account ?"
        ' 
        ' SignupButton
        ' 
        SignupButton.BackColor = Color.Chocolate
        SignupButton.Location = New Point(56, 448)
        SignupButton.Margin = New Padding(4)
        SignupButton.Name = "SignupButton"
        SignupButton.Size = New Size(155, 29)
        SignupButton.TabIndex = 13
        SignupButton.Text = "SIGN UP"
        SignupButton.UseVisualStyleBackColor = False
        ' 
        ' LastNameTxtbox
        ' 
        LastNameTxtbox.Location = New Point(26, 128)
        LastNameTxtbox.Margin = New Padding(4)
        LastNameTxtbox.Name = "LastNameTxtbox"
        LastNameTxtbox.Size = New Size(220, 26)
        LastNameTxtbox.TabIndex = 12
        ' 
        ' PhoneTextbox
        ' 
        PhoneTextbox.Location = New Point(26, 195)
        PhoneTextbox.Margin = New Padding(4)
        PhoneTextbox.Name = "PhoneTextbox"
        PhoneTextbox.Size = New Size(220, 26)
        PhoneTextbox.TabIndex = 11
        ' 
        ' ConfirmPasswordTXTbox
        ' 
        ConfirmPasswordTXTbox.Location = New Point(26, 397)
        ConfirmPasswordTXTbox.Margin = New Padding(4)
        ConfirmPasswordTXTbox.Name = "ConfirmPasswordTXTbox"
        ConfirmPasswordTXTbox.PasswordChar = "*"c
        ConfirmPasswordTXTbox.Size = New Size(220, 26)
        ConfirmPasswordTXTbox.TabIndex = 10
        ' 
        ' PasswordTxtBox
        ' 
        PasswordTxtBox.Location = New Point(26, 330)
        PasswordTxtBox.Margin = New Padding(4)
        PasswordTxtBox.Name = "PasswordTxtBox"
        PasswordTxtBox.PasswordChar = "*"c
        PasswordTxtBox.Size = New Size(220, 26)
        PasswordTxtBox.TabIndex = 9
        ' 
        ' EmailTxtBox
        ' 
        EmailTxtBox.Location = New Point(26, 262)
        EmailTxtBox.Margin = New Padding(4)
        EmailTxtBox.Name = "EmailTxtBox"
        EmailTxtBox.Size = New Size(220, 26)
        EmailTxtBox.TabIndex = 8
        ' 
        ' FirstNameTextbox
        ' 
        FirstNameTextbox.Location = New Point(29, 61)
        FirstNameTextbox.Margin = New Padding(4)
        FirstNameTextbox.Name = "FirstNameTextbox"
        FirstNameTextbox.Size = New Size(220, 26)
        FirstNameTextbox.TabIndex = 7
        ' 
        ' ConfirmPassword
        ' 
        ConfirmPassword.AutoSize = True
        ConfirmPassword.Location = New Point(26, 374)
        ConfirmPassword.Margin = New Padding(4, 0, 4, 0)
        ConfirmPassword.Name = "ConfirmPassword"
        ConfirmPassword.Size = New Size(139, 19)
        ConfirmPassword.TabIndex = 6
        ConfirmPassword.Text = "Confirm Password :"
        ' 
        ' Password
        ' 
        Password.AutoSize = True
        Password.Location = New Point(26, 307)
        Password.Margin = New Padding(4, 0, 4, 0)
        Password.Name = "Password"
        Password.Size = New Size(81, 19)
        Password.TabIndex = 5
        Password.Text = "Password :"
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Location = New Point(26, 239)
        Email.Margin = New Padding(4, 0, 4, 0)
        Email.Name = "Email"
        Email.Size = New Size(56, 19)
        Email.TabIndex = 4
        Email.Text = "Email :"
        ' 
        ' PhoneNumber
        ' 
        PhoneNumber.AutoSize = True
        PhoneNumber.Location = New Point(26, 172)
        PhoneNumber.Margin = New Padding(4, 0, 4, 0)
        PhoneNumber.Name = "PhoneNumber"
        PhoneNumber.Size = New Size(117, 19)
        PhoneNumber.TabIndex = 3
        PhoneNumber.Text = "Phone Number :"
        ' 
        ' FirstNAme
        ' 
        FirstNAme.AutoSize = True
        FirstNAme.Location = New Point(26, 38)
        FirstNAme.Margin = New Padding(4, 0, 4, 0)
        FirstNAme.Name = "FirstNAme"
        FirstNAme.Size = New Size(93, 19)
        FirstNAme.TabIndex = 2
        FirstNAme.Text = "First Name :"
        ' 
        ' LastName
        ' 
        LastName.AutoSize = True
        LastName.Location = New Point(27, 105)
        LastName.Margin = New Padding(4, 0, 4, 0)
        LastName.Name = "LastName"
        LastName.Size = New Size(92, 19)
        LastName.TabIndex = 1
        LastName.Text = "Last Name :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sitka Display", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkOrange
        Label1.Location = New Point(298, -17)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 69)
        Label1.TabIndex = 2
        Label1.Text = "SIGN UP" & vbCrLf
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        BackgroundImage = My.Resources.Resources.Relocation_Movers1_1170x780__1_
        ClientSize = New Size(814, 592)
        Controls.Add(Label1)
        Controls.Add(Inputs)
        Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "Signup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign Up"
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
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
