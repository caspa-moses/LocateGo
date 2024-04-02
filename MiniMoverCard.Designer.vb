<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiniMoverCard
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
        MiniMoverCardPanel = New Panel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel5 = New Panel()
        cancelButton = New Button()
        Panel3 = New Panel()
        Panel4 = New Panel()
        moredetailsbutton = New Button()
        selectButton = New Button()
        companynameLabel = New Label()
        moverPictureBox = New PictureBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        pricesPanel = New Panel()
        kmTextBox = New TextBox()
        KgTextBox = New TextBox()
        kmLabel = New Label()
        kgLabel = New Label()
        pricesLabel = New Label()
        RatingTextBox = New TextBox()
        reviewsLabel = New Label()
        contactinfoPanel = New Panel()
        emailTextBox = New TextBox()
        phoneTextBox = New TextBox()
        emailLabel = New Label()
        phoneLabel = New Label()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        CType(moverPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        pricesPanel.SuspendLayout()
        contactinfoPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MiniMoverCardPanel
        ' 
        MiniMoverCardPanel.BackColor = Color.FromArgb(CByte(168), CByte(100), CByte(62))
        MiniMoverCardPanel.Dock = DockStyle.Right
        MiniMoverCardPanel.Location = New Point(195, 0)
        MiniMoverCardPanel.Name = "MiniMoverCardPanel"
        MiniMoverCardPanel.Size = New Size(5, 302)
        MiniMoverCardPanel.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(168), CByte(100), CByte(62))
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 297)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(195, 5)
        Panel1.TabIndex = 37
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(168), CByte(100), CByte(62))
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(5, 297)
        Panel2.TabIndex = 38
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(cancelButton)
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(486, 339)
        Panel5.TabIndex = 48
        Panel5.Visible = False
        ' 
        ' cancelButton
        ' 
        cancelButton.BackColor = Color.FromArgb(CByte(168), CByte(100), CByte(62))
        cancelButton.Location = New Point(69, 268)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(75, 23)
        cancelButton.TabIndex = 0
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(168), CByte(100), CByte(62))
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(5, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(190, 5)
        Panel3.TabIndex = 39
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(moredetailsbutton)
        Panel4.Controls.Add(selectButton)
        Panel4.Controls.Add(companynameLabel)
        Panel4.Controls.Add(moverPictureBox)
        Panel4.Controls.Add(FlowLayoutPanel1)
        Panel4.Controls.Add(pricesPanel)
        Panel4.Controls.Add(RatingTextBox)
        Panel4.Controls.Add(reviewsLabel)
        Panel4.Controls.Add(contactinfoPanel)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(5, 5)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(190, 292)
        Panel4.TabIndex = 40
        ' 
        ' moredetailsbutton
        ' 
        moredetailsbutton.AllowDrop = True
        moredetailsbutton.BackColor = Color.FromArgb(CByte(168), CByte(100), CByte(62))
        moredetailsbutton.Location = New Point(53, 256)
        moredetailsbutton.Name = "moredetailsbutton"
        moredetailsbutton.Size = New Size(109, 27)
        moredetailsbutton.TabIndex = 32
        moredetailsbutton.Text = "More details"
        moredetailsbutton.UseVisualStyleBackColor = False
        ' 
        ' selectButton
        ' 
        selectButton.AllowDrop = True
        selectButton.BackColor = Color.FromArgb(CByte(168), CByte(100), CByte(62))
        selectButton.Location = New Point(277, 257)
        selectButton.Name = "selectButton"
        selectButton.Size = New Size(109, 27)
        selectButton.TabIndex = 47
        selectButton.Text = "select"
        selectButton.UseVisualStyleBackColor = False
        ' 
        ' companynameLabel
        ' 
        companynameLabel.AutoSize = True
        companynameLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        companynameLabel.Location = New Point(23, 136)
        companynameLabel.Name = "companynameLabel"
        companynameLabel.Size = New Size(130, 21)
        companynameLabel.TabIndex = 31
        companynameLabel.Text = "Company name"
        ' 
        ' moverPictureBox
        ' 
        moverPictureBox.Enabled = False
        moverPictureBox.Location = New Point(16, 20)
        moverPictureBox.Name = "moverPictureBox"
        moverPictureBox.Size = New Size(181, 113)
        moverPictureBox.TabIndex = 30
        moverPictureBox.TabStop = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(221, 131)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(238, 65)
        FlowLayoutPanel1.TabIndex = 46
        ' 
        ' pricesPanel
        ' 
        pricesPanel.Controls.Add(kmTextBox)
        pricesPanel.Controls.Add(KgTextBox)
        pricesPanel.Controls.Add(kmLabel)
        pricesPanel.Controls.Add(kgLabel)
        pricesPanel.Controls.Add(pricesLabel)
        pricesPanel.Location = New Point(16, 160)
        pricesPanel.Name = "pricesPanel"
        pricesPanel.Size = New Size(181, 90)
        pricesPanel.TabIndex = 33
        ' 
        ' kmTextBox
        ' 
        kmTextBox.BackColor = SystemColors.InactiveBorder
        kmTextBox.Enabled = False
        kmTextBox.Location = New Point(58, 63)
        kmTextBox.Name = "kmTextBox"
        kmTextBox.Size = New Size(99, 23)
        kmTextBox.TabIndex = 8
        kmTextBox.Text = "20KSh"
        ' 
        ' KgTextBox
        ' 
        KgTextBox.BackColor = SystemColors.InactiveBorder
        KgTextBox.Enabled = False
        KgTextBox.Location = New Point(58, 31)
        KgTextBox.Name = "KgTextBox"
        KgTextBox.Size = New Size(99, 23)
        KgTextBox.TabIndex = 7
        KgTextBox.Text = "10 KSh"
        ' 
        ' kmLabel
        ' 
        kmLabel.AutoSize = True
        kmLabel.Font = New Font("Sylfaen", 9F, FontStyle.Bold)
        kmLabel.Location = New Point(-2, 63)
        kmLabel.Name = "kmLabel"
        kmLabel.Size = New Size(59, 16)
        kmLabel.TabIndex = 5
        kmLabel.Text = "Per Km :"
        ' 
        ' kgLabel
        ' 
        kgLabel.AutoSize = True
        kgLabel.Font = New Font("Sylfaen", 9F, FontStyle.Bold)
        kgLabel.Location = New Point(0, 31)
        kgLabel.Name = "kgLabel"
        kgLabel.Size = New Size(56, 16)
        kgLabel.TabIndex = 4
        kgLabel.Text = "Per Kg :"
        ' 
        ' pricesLabel
        ' 
        pricesLabel.AutoSize = True
        pricesLabel.Font = New Font("Sylfaen", 10F, FontStyle.Bold)
        pricesLabel.Location = New Point(5, 0)
        pricesLabel.Name = "pricesLabel"
        pricesLabel.Size = New Size(58, 18)
        pricesLabel.TabIndex = 2
        pricesLabel.Text = "Prices :"
        ' 
        ' RatingTextBox
        ' 
        RatingTextBox.Enabled = False
        RatingTextBox.Location = New Point(277, 102)
        RatingTextBox.Name = "RatingTextBox"
        RatingTextBox.Size = New Size(55, 23)
        RatingTextBox.TabIndex = 45
        ' 
        ' reviewsLabel
        ' 
        reviewsLabel.AutoSize = True
        reviewsLabel.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        reviewsLabel.Location = New Point(210, 101)
        reviewsLabel.Name = "reviewsLabel"
        reviewsLabel.Size = New Size(69, 22)
        reviewsLabel.TabIndex = 43
        reviewsLabel.Text = "Rating :"
        ' 
        ' contactinfoPanel
        ' 
        contactinfoPanel.Controls.Add(emailTextBox)
        contactinfoPanel.Controls.Add(phoneTextBox)
        contactinfoPanel.Controls.Add(emailLabel)
        contactinfoPanel.Controls.Add(phoneLabel)
        contactinfoPanel.Location = New Point(216, 20)
        contactinfoPanel.Name = "contactinfoPanel"
        contactinfoPanel.Size = New Size(243, 78)
        contactinfoPanel.TabIndex = 44
        ' 
        ' emailTextBox
        ' 
        emailTextBox.BackColor = SystemColors.InactiveBorder
        emailTextBox.Enabled = False
        emailTextBox.Location = New Point(63, 46)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(164, 23)
        emailTextBox.TabIndex = 3
        emailTextBox.Text = "@gmail.com"
        ' 
        ' phoneTextBox
        ' 
        phoneTextBox.BackColor = SystemColors.InactiveBorder
        phoneTextBox.Enabled = False
        phoneTextBox.Location = New Point(63, 12)
        phoneTextBox.Name = "phoneTextBox"
        phoneTextBox.Size = New Size(164, 23)
        phoneTextBox.TabIndex = 2
        phoneTextBox.Text = "12345678"
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Font = New Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        emailLabel.Location = New Point(5, 46)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(57, 19)
        emailLabel.TabIndex = 1
        emailLabel.Text = "Email :"
        ' 
        ' phoneLabel
        ' 
        phoneLabel.AutoSize = True
        phoneLabel.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        phoneLabel.Location = New Point(-1, 10)
        phoneLabel.Name = "phoneLabel"
        phoneLabel.Size = New Size(65, 22)
        phoneLabel.TabIndex = 0
        phoneLabel.Text = "Phone :"
        ' 
        ' MiniMoverCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(MiniMoverCardPanel)
        MinimumSize = New Size(200, 302)
        Name = "MiniMoverCard"
        Size = New Size(200, 302)
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(moverPictureBox, ComponentModel.ISupportInitialize).EndInit()
        pricesPanel.ResumeLayout(False)
        pricesPanel.PerformLayout()
        contactinfoPanel.ResumeLayout(False)
        contactinfoPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MiniMoverCardPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents selectButton As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents RatingTextBox As TextBox
    Friend WithEvents reviewsLabel As Label
    Friend WithEvents contactinfoPanel As Panel
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents phoneTextBox As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents phoneLabel As Label
    Friend WithEvents moredetailsbutton As Button
    Friend WithEvents companynameLabel As Label
    Friend WithEvents moverPictureBox As PictureBox
    Friend WithEvents pricesPanel As Panel
    Friend WithEvents kmTextBox As TextBox
    Friend WithEvents KgTextBox As TextBox
    Friend WithEvents kmLabel As Label
    Friend WithEvents kgLabel As Label
    Friend WithEvents pricesLabel As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cancelButton As Button

End Class
