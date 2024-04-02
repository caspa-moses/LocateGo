<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MoversSignup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MoversSignup))
        CompanyNameTextBox = New TextBox()
        EmailTextBox = New TextBox()
        BusinessNumberTextBox = New TextBox()
        LocationTextBox = New TextBox()
        CategoryComboBox = New ComboBox()
        ProfilePictureBox = New PictureBox()
        SignUpButton = New Button()
        BrowseButton = New Button()
        PasswordTextBox = New TextBox()
        CompanyNameLabel = New Label()
        CompanyEmailLabel = New Label()
        PasswordLabel = New Label()
        BusinessNumberLabel = New Label()
        ProfilePictureLabel = New Label()
        CategoryLabel = New Label()
        LocationLabel = New Label()
        ConfirmPasswordTextBox = New TextBox()
        Label1 = New Label()
        CType(ProfilePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CompanyNameTextBox
        ' 
        CompanyNameTextBox.Location = New Point(107, 62)
        CompanyNameTextBox.Name = "CompanyNameTextBox"
        CompanyNameTextBox.Size = New Size(279, 31)
        CompanyNameTextBox.TabIndex = 0
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(107, 124)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(279, 31)
        EmailTextBox.TabIndex = 1
        ' 
        ' BusinessNumberTextBox
        ' 
        BusinessNumberTextBox.Location = New Point(106, 186)
        BusinessNumberTextBox.Name = "BusinessNumberTextBox"
        BusinessNumberTextBox.Size = New Size(279, 31)
        BusinessNumberTextBox.TabIndex = 2
        ' 
        ' LocationTextBox
        ' 
        LocationTextBox.Location = New Point(107, 500)
        LocationTextBox.Name = "LocationTextBox"
        LocationTextBox.Size = New Size(279, 31)
        LocationTextBox.TabIndex = 3
        ' 
        ' CategoryComboBox
        ' 
        CategoryComboBox.FormattingEnabled = True
        CategoryComboBox.Location = New Point(108, 576)
        CategoryComboBox.Name = "CategoryComboBox"
        CategoryComboBox.Size = New Size(279, 33)
        CategoryComboBox.TabIndex = 4
        ' 
        ' ProfilePictureBox
        ' 
        ProfilePictureBox.Location = New Point(107, 393)
        ProfilePictureBox.Name = "ProfilePictureBox"
        ProfilePictureBox.Size = New Size(176, 75)
        ProfilePictureBox.TabIndex = 5
        ProfilePictureBox.TabStop = False
        ' 
        ' SignUpButton
        ' 
        SignUpButton.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUpButton.Location = New Point(158, 627)
        SignUpButton.Name = "SignUpButton"
        SignUpButton.Size = New Size(112, 34)
        SignUpButton.TabIndex = 6
        SignUpButton.Text = "Signup"
        SignUpButton.UseVisualStyleBackColor = True
        ' 
        ' BrowseButton
        ' 
        BrowseButton.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BrowseButton.Location = New Point(293, 393)
        BrowseButton.Name = "BrowseButton"
        BrowseButton.Size = New Size(94, 34)
        BrowseButton.TabIndex = 7
        BrowseButton.Text = "Browse"
        BrowseButton.UseVisualStyleBackColor = True
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(106, 318)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(279, 31)
        PasswordTextBox.TabIndex = 8
        ' 
        ' CompanyNameLabel
        ' 
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CompanyNameLabel.Location = New Point(107, 34)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New Size(163, 25)
        CompanyNameLabel.TabIndex = 9
        CompanyNameLabel.Text = "Company name"
        ' 
        ' CompanyEmailLabel
        ' 
        CompanyEmailLabel.AutoSize = True
        CompanyEmailLabel.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CompanyEmailLabel.Location = New Point(106, 96)
        CompanyEmailLabel.Name = "CompanyEmailLabel"
        CompanyEmailLabel.Size = New Size(163, 25)
        CompanyEmailLabel.TabIndex = 10
        CompanyEmailLabel.Text = "Company Email"
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PasswordLabel.Location = New Point(106, 158)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(106, 25)
        PasswordLabel.TabIndex = 11
        PasswordLabel.Text = "Password"
        ' 
        ' BusinessNumberLabel
        ' 
        BusinessNumberLabel.AutoSize = True
        BusinessNumberLabel.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BusinessNumberLabel.Location = New Point(108, 290)
        BusinessNumberLabel.Name = "BusinessNumberLabel"
        BusinessNumberLabel.Size = New Size(181, 25)
        BusinessNumberLabel.TabIndex = 12
        BusinessNumberLabel.Text = "Business Number"
        ' 
        ' ProfilePictureLabel
        ' 
        ProfilePictureLabel.AutoSize = True
        ProfilePictureLabel.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProfilePictureLabel.Location = New Point(108, 365)
        ProfilePictureLabel.Name = "ProfilePictureLabel"
        ProfilePictureLabel.Size = New Size(144, 25)
        ProfilePictureLabel.TabIndex = 13
        ProfilePictureLabel.Text = "Profile picture"
        ' 
        ' CategoryLabel
        ' 
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CategoryLabel.Location = New Point(108, 548)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New Size(100, 25)
        CategoryLabel.TabIndex = 14
        CategoryLabel.Text = "Category"
        ' 
        ' LocationLabel
        ' 
        LocationLabel.AutoSize = True
        LocationLabel.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LocationLabel.Location = New Point(108, 472)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New Size(94, 25)
        LocationLabel.TabIndex = 15
        LocationLabel.Text = "Location"
        ' 
        ' ConfirmPasswordTextBox
        ' 
        ConfirmPasswordTextBox.Location = New Point(107, 248)
        ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        ConfirmPasswordTextBox.Size = New Size(278, 31)
        ConfirmPasswordTextBox.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(108, 220)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 25)
        Label1.TabIndex = 17
        Label1.Text = "Confirm Password"
        ' 
        ' MoversSignup
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        'BackgroundImage = My.Resources.Resources.signup
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1158, 703)
        Controls.Add(Label1)
        Controls.Add(ConfirmPasswordTextBox)
        Controls.Add(LocationLabel)
        Controls.Add(CategoryLabel)
        Controls.Add(ProfilePictureLabel)
        Controls.Add(BusinessNumberLabel)
        Controls.Add(PasswordLabel)
        Controls.Add(CompanyEmailLabel)
        Controls.Add(CompanyNameLabel)
        Controls.Add(PasswordTextBox)
        Controls.Add(BrowseButton)
        Controls.Add(SignUpButton)
        Controls.Add(ProfilePictureBox)
        Controls.Add(CategoryComboBox)
        Controls.Add(LocationTextBox)
        Controls.Add(BusinessNumberTextBox)
        Controls.Add(EmailTextBox)
        Controls.Add(CompanyNameTextBox)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MoversSignup"
        Text = "Signup"
        CType(ProfilePictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents BusinessNumberTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents ProfilePictureBox As PictureBox
    Friend WithEvents SignUpButton As Button
    Friend WithEvents BrowseButton As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents CompanyNameLabel As Label
    Friend WithEvents CompanyEmailLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents BusinessNumberLabel As Label
    Friend WithEvents ProfilePictureLabel As Label
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents Label1 As Label

End Class
