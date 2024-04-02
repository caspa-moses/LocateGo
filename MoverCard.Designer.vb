<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoverCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        pricesPanel = New Panel()
        kmTextBox = New TextBox()
        KgTextBox = New TextBox()
        kmLabel = New Label()
        kgLabel = New Label()
        pricesLabel = New Label()
        selectButton = New Button()
        starPictureBox5 = New PictureBox()
        starPictureBox4 = New PictureBox()
        starPictureBox3 = New PictureBox()
        starPictureBox2 = New PictureBox()
        starPictureBox1 = New PictureBox()
        reviewsLabel = New Label()
        companynameLabel = New Label()
        contactinfoPanel = New Panel()
        emailTextBox = New TextBox()
        phoneTextBox = New TextBox()
        emailLabel = New Label()
        phoneLabel = New Label()
        moverPictureBox = New PictureBox()
        pricesPanel.SuspendLayout()
        CType(starPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(starPictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(starPictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(starPictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(starPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        contactinfoPanel.SuspendLayout()
        CType(moverPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' pricesPanel
        ' 
        pricesPanel.Controls.Add(kmTextBox)
        pricesPanel.Controls.Add(KgTextBox)
        pricesPanel.Controls.Add(kmLabel)
        pricesPanel.Controls.Add(kgLabel)
        pricesPanel.Controls.Add(pricesLabel)
        pricesPanel.Location = New Point(12, 286)
        pricesPanel.Name = "pricesPanel"
        pricesPanel.Size = New Size(249, 99)
        pricesPanel.TabIndex = 20
        ' 
        ' kmTextBox
        ' 
        kmTextBox.BackColor = SystemColors.InactiveBorder
        kmTextBox.Location = New Point(88, 71)
        kmTextBox.Name = "kmTextBox"
        kmTextBox.Size = New Size(141, 23)
        kmTextBox.TabIndex = 8
        kmTextBox.Text = "20KSh"
        ' 
        ' KgTextBox
        ' 
        KgTextBox.BackColor = SystemColors.InactiveBorder
        KgTextBox.Location = New Point(88, 37)
        KgTextBox.Name = "KgTextBox"
        KgTextBox.Size = New Size(139, 23)
        KgTextBox.TabIndex = 7
        KgTextBox.Text = "10 KSh"
        ' 
        ' kmLabel
        ' 
        kmLabel.AutoSize = True
        kmLabel.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        kmLabel.Location = New Point(6, 72)
        kmLabel.Name = "kmLabel"
        kmLabel.Size = New Size(76, 22)
        kmLabel.TabIndex = 5
        kmLabel.Text = "Per Km :"
        ' 
        ' kgLabel
        ' 
        kgLabel.AutoSize = True
        kgLabel.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        kgLabel.Location = New Point(3, 35)
        kgLabel.Name = "kgLabel"
        kgLabel.Size = New Size(71, 22)
        kgLabel.TabIndex = 4
        kgLabel.Text = "Per Kg :"
        ' 
        ' pricesLabel
        ' 
        pricesLabel.AutoSize = True
        pricesLabel.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pricesLabel.Location = New Point(0, 0)
        pricesLabel.Name = "pricesLabel"
        pricesLabel.Size = New Size(66, 22)
        pricesLabel.TabIndex = 2
        pricesLabel.Text = "Prices :"
        ' 
        ' selectButton
        ' 
        selectButton.AllowDrop = True
        selectButton.BackColor = Color.FromArgb(CByte(168), CByte(100), CByte(62))
        selectButton.Location = New Point(67, 391)
        selectButton.Name = "selectButton"
        selectButton.Size = New Size(136, 35)
        selectButton.TabIndex = 19
        selectButton.Text = "Select"
        selectButton.UseVisualStyleBackColor = False
        ' 
        ' starPictureBox5
        ' 
        starPictureBox5.Location = New Point(208, 235)
        starPictureBox5.Name = "starPictureBox5"
        starPictureBox5.Size = New Size(40, 40)
        starPictureBox5.TabIndex = 18
        starPictureBox5.TabStop = False
        ' 
        ' starPictureBox4
        ' 
        starPictureBox4.Location = New Point(159, 235)
        starPictureBox4.Name = "starPictureBox4"
        starPictureBox4.Size = New Size(40, 40)
        starPictureBox4.TabIndex = 17
        starPictureBox4.TabStop = False
        ' 
        ' starPictureBox3
        ' 
        starPictureBox3.Location = New Point(113, 235)
        starPictureBox3.Name = "starPictureBox3"
        starPictureBox3.Size = New Size(40, 40)
        starPictureBox3.TabIndex = 16
        starPictureBox3.TabStop = False
        ' 
        ' starPictureBox2
        ' 
        starPictureBox2.Location = New Point(67, 235)
        starPictureBox2.Name = "starPictureBox2"
        starPictureBox2.Size = New Size(40, 40)
        starPictureBox2.TabIndex = 15
        starPictureBox2.TabStop = False
        ' 
        ' starPictureBox1
        ' 
        starPictureBox1.Location = New Point(18, 235)
        starPictureBox1.Name = "starPictureBox1"
        starPictureBox1.Size = New Size(40, 40)
        starPictureBox1.TabIndex = 14
        starPictureBox1.TabStop = False
        ' 
        ' reviewsLabel
        ' 
        reviewsLabel.AutoSize = True
        reviewsLabel.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        reviewsLabel.Location = New Point(12, 210)
        reviewsLabel.Name = "reviewsLabel"
        reviewsLabel.Size = New Size(69, 22)
        reviewsLabel.TabIndex = 11
        reviewsLabel.Text = "Rating :"
        ' 
        ' companynameLabel
        ' 
        companynameLabel.AutoSize = True
        companynameLabel.Font = New Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        companynameLabel.Location = New Point(12, 2)
        companynameLabel.Name = "companynameLabel"
        companynameLabel.Size = New Size(165, 25)
        companynameLabel.TabIndex = 13
        companynameLabel.Text = "Company Name :"
        ' 
        ' contactinfoPanel
        ' 
        contactinfoPanel.Controls.Add(emailTextBox)
        contactinfoPanel.Controls.Add(phoneTextBox)
        contactinfoPanel.Controls.Add(emailLabel)
        contactinfoPanel.Controls.Add(phoneLabel)
        contactinfoPanel.Location = New Point(18, 129)
        contactinfoPanel.Name = "contactinfoPanel"
        contactinfoPanel.Size = New Size(243, 78)
        contactinfoPanel.TabIndex = 12
        ' 
        ' emailTextBox
        ' 
        emailTextBox.BackColor = SystemColors.InactiveBorder
        emailTextBox.Location = New Point(66, 46)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(164, 23)
        emailTextBox.TabIndex = 3
        emailTextBox.Text = "@gmail.com"
        ' 
        ' phoneTextBox
        ' 
        phoneTextBox.BackColor = SystemColors.InactiveBorder
        phoneTextBox.Location = New Point(66, 12)
        phoneTextBox.Name = "phoneTextBox"
        phoneTextBox.Size = New Size(164, 23)
        phoneTextBox.TabIndex = 2
        phoneTextBox.Text = "12345678"
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Font = New Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        emailLabel.Location = New Point(3, 46)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(57, 19)
        emailLabel.TabIndex = 1
        emailLabel.Text = "Email :"
        ' 
        ' phoneLabel
        ' 
        phoneLabel.AutoSize = True
        phoneLabel.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        phoneLabel.Location = New Point(0, 10)
        phoneLabel.Name = "phoneLabel"
        phoneLabel.Size = New Size(65, 22)
        phoneLabel.TabIndex = 0
        phoneLabel.Text = "Phone :"
        ' 
        ' moverPictureBox
        ' 
        moverPictureBox.Location = New Point(24, 30)
        moverPictureBox.Name = "moverPictureBox"
        moverPictureBox.Size = New Size(215, 86)
        moverPictureBox.TabIndex = 10
        moverPictureBox.TabStop = False
        ' 
        ' MoverCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pricesPanel)
        Controls.Add(selectButton)
        Controls.Add(starPictureBox5)
        Controls.Add(starPictureBox4)
        Controls.Add(starPictureBox3)
        Controls.Add(starPictureBox2)
        Controls.Add(starPictureBox1)
        Controls.Add(reviewsLabel)
        Controls.Add(companynameLabel)
        Controls.Add(contactinfoPanel)
        Controls.Add(moverPictureBox)
        Name = "MoverCard"
        Size = New Size(273, 429)
        pricesPanel.ResumeLayout(False)
        pricesPanel.PerformLayout()
        CType(starPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(starPictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(starPictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(starPictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(starPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        contactinfoPanel.ResumeLayout(False)
        contactinfoPanel.PerformLayout()
        CType(moverPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents pricesPanel As Panel
    Friend WithEvents kmTextBox As TextBox
    Friend WithEvents KgTextBox As TextBox
    Friend WithEvents kmLabel As Label
    Friend WithEvents kgLabel As Label
    Friend WithEvents pricesLabel As Label
    Friend WithEvents selectButton As Button
    Friend WithEvents starPictureBox5 As PictureBox
    Friend WithEvents starPictureBox4 As PictureBox
    Friend WithEvents starPictureBox3 As PictureBox
    Friend WithEvents starPictureBox2 As PictureBox
    Friend WithEvents starPictureBox1 As PictureBox
    Friend WithEvents reviewsLabel As Label
    Friend WithEvents companynameLabel As Label
    Friend WithEvents contactinfoPanel As Panel
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents phoneTextBox As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents phoneLabel As Label
    Friend WithEvents moverPictureBox As PictureBox

End Class
