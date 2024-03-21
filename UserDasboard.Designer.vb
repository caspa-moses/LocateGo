<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDasboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserDasboard))
        SidePanel = New Panel()
        LogoutButton = New Button()
        CooperationButton = New Button()
        FarmButton = New Button()
        HouseholdButton = New Button()
        BusinessButton = New Button()
        ColorDialog1 = New ColorDialog()
        TopPanel = New Panel()
        SearchButton = New Button()
        SearchTextBox = New TextBox()
        NotificationButton = New Button()
        TrackButton = New Button()
        PickupComboBox = New ComboBox()
        PickupLabel = New Label()
        DestinationLabel = New Label()
        DestinationComboBox = New ComboBox()
        MainbodyPanel = New Panel()
        SidePanel.SuspendLayout()
        TopPanel.SuspendLayout()
        MainbodyPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = Color.FromArgb(CByte(168), CByte(100), CByte(62))
        SidePanel.Controls.Add(LogoutButton)
        SidePanel.Controls.Add(CooperationButton)
        SidePanel.Controls.Add(FarmButton)
        SidePanel.Controls.Add(HouseholdButton)
        SidePanel.Controls.Add(BusinessButton)
        SidePanel.Dock = DockStyle.Left
        SidePanel.Location = New Point(0, 0)
        SidePanel.Name = "SidePanel"
        SidePanel.Size = New Size(154, 477)
        SidePanel.TabIndex = 0
        ' 
        ' LogoutButton
        ' 
        LogoutButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        LogoutButton.AutoSize = True
        LogoutButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        LogoutButton.FlatAppearance.BorderSize = 0
        LogoutButton.FlatStyle = FlatStyle.Flat
        LogoutButton.ForeColor = Color.White
        LogoutButton.Image = My.Resources.Resources.logout_24
        LogoutButton.Location = New Point(0, 432)
        LogoutButton.Name = "LogoutButton"
        LogoutButton.Size = New Size(30, 30)
        LogoutButton.TabIndex = 4
        LogoutButton.TextImageRelation = TextImageRelation.ImageBeforeText
        LogoutButton.UseVisualStyleBackColor = True
        ' 
        ' CooperationButton
        ' 
        CooperationButton.FlatAppearance.BorderSize = 0
        CooperationButton.FlatStyle = FlatStyle.Flat
        CooperationButton.Image = My.Resources.Resources.delivery_24
        CooperationButton.ImageAlign = ContentAlignment.BottomLeft
        CooperationButton.Location = New Point(0, 240)
        CooperationButton.Name = "CooperationButton"
        CooperationButton.Size = New Size(154, 31)
        CooperationButton.TabIndex = 3
        CooperationButton.Text = "  Courier"
        CooperationButton.TextAlign = ContentAlignment.BottomLeft
        CooperationButton.TextImageRelation = TextImageRelation.ImageBeforeText
        CooperationButton.UseVisualStyleBackColor = True
        ' 
        ' FarmButton
        ' 
        FarmButton.FlatAppearance.BorderSize = 0
        FarmButton.FlatStyle = FlatStyle.Flat
        FarmButton.Image = My.Resources.Resources.tractor_24
        FarmButton.ImageAlign = ContentAlignment.BottomLeft
        FarmButton.Location = New Point(0, 179)
        FarmButton.Name = "FarmButton"
        FarmButton.Size = New Size(154, 31)
        FarmButton.TabIndex = 2
        FarmButton.Text = "  Farm"
        FarmButton.TextAlign = ContentAlignment.BottomLeft
        FarmButton.TextImageRelation = TextImageRelation.ImageBeforeText
        FarmButton.UseVisualStyleBackColor = True
        ' 
        ' HouseholdButton
        ' 
        HouseholdButton.FlatAppearance.BorderSize = 0
        HouseholdButton.FlatStyle = FlatStyle.Flat
        HouseholdButton.Image = My.Resources.Resources.sofa_24
        HouseholdButton.ImageAlign = ContentAlignment.BottomLeft
        HouseholdButton.Location = New Point(0, 113)
        HouseholdButton.Name = "HouseholdButton"
        HouseholdButton.Size = New Size(154, 31)
        HouseholdButton.TabIndex = 1
        HouseholdButton.Text = "  Household"
        HouseholdButton.TextAlign = ContentAlignment.BottomLeft
        HouseholdButton.TextImageRelation = TextImageRelation.ImageBeforeText
        HouseholdButton.UseVisualStyleBackColor = True
        ' 
        ' BusinessButton
        ' 
        BusinessButton.FlatAppearance.BorderSize = 0
        BusinessButton.FlatStyle = FlatStyle.Flat
        BusinessButton.Image = My.Resources.Resources.briefcase_3_24
        BusinessButton.ImageAlign = ContentAlignment.BottomLeft
        BusinessButton.Location = New Point(0, 46)
        BusinessButton.Name = "BusinessButton"
        BusinessButton.Size = New Size(154, 31)
        BusinessButton.TabIndex = 0
        BusinessButton.Text = "  Business"
        BusinessButton.TextAlign = ContentAlignment.BottomLeft
        BusinessButton.TextImageRelation = TextImageRelation.ImageBeforeText
        BusinessButton.UseVisualStyleBackColor = True
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = Color.FromArgb(CByte(251), CByte(205), CByte(88))
        TopPanel.Controls.Add(SearchButton)
        TopPanel.Controls.Add(SearchTextBox)
        TopPanel.Controls.Add(NotificationButton)
        TopPanel.Controls.Add(TrackButton)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(154, 0)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(646, 40)
        TopPanel.TabIndex = 4
        ' 
        ' SearchButton
        ' 
        SearchButton.Anchor = AnchorStyles.Top
        SearchButton.AutoSize = True
        SearchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SearchButton.FlatStyle = FlatStyle.Flat
        SearchButton.ForeColor = Color.White
        SearchButton.Image = My.Resources.Resources.search_13_16
        SearchButton.Location = New Point(389, 13)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(24, 24)
        SearchButton.TabIndex = 8
        SearchButton.UseVisualStyleBackColor = True
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.Anchor = AnchorStyles.Top
        SearchTextBox.Location = New Point(215, 15)
        SearchTextBox.Name = "SearchTextBox"
        SearchTextBox.Size = New Size(168, 23)
        SearchTextBox.TabIndex = 7
        ' 
        ' NotificationButton
        ' 
        NotificationButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        NotificationButton.AutoSize = True
        NotificationButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        NotificationButton.FlatStyle = FlatStyle.Flat
        NotificationButton.ForeColor = Color.White
        NotificationButton.Image = My.Resources.Resources.appointment_reminders_16
        NotificationButton.Location = New Point(568, 12)
        NotificationButton.Name = "NotificationButton"
        NotificationButton.Size = New Size(24, 24)
        NotificationButton.TabIndex = 6
        NotificationButton.UseVisualStyleBackColor = True
        ' 
        ' TrackButton
        ' 
        TrackButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TrackButton.AutoSize = True
        TrackButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TrackButton.FlatStyle = FlatStyle.Flat
        TrackButton.ForeColor = Color.White
        TrackButton.Image = My.Resources.Resources.map_marker_16
        TrackButton.Location = New Point(604, 12)
        TrackButton.Name = "TrackButton"
        TrackButton.Size = New Size(24, 24)
        TrackButton.TabIndex = 5
        TrackButton.UseVisualStyleBackColor = True
        ' 
        ' PickupComboBox
        ' 
        PickupComboBox.Anchor = AnchorStyles.Top
        PickupComboBox.AutoCompleteCustomSource.AddRange(New String() {"Nairobi", "Nakuru", "Kisumu", "Mombasa"})
        PickupComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        PickupComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
        PickupComboBox.FormattingEnabled = True
        PickupComboBox.Items.AddRange(New Object() {"Nairobi", "Nakuru", "Kisumu", "Mombasa"})
        PickupComboBox.Location = New Point(113, 11)
        PickupComboBox.Name = "PickupComboBox"
        PickupComboBox.Size = New Size(152, 23)
        PickupComboBox.TabIndex = 5
        ' 
        ' PickupLabel
        ' 
        PickupLabel.Anchor = AnchorStyles.Top
        PickupLabel.AutoSize = True
        PickupLabel.Location = New Point(3, 7)
        PickupLabel.Name = "PickupLabel"
        PickupLabel.Size = New Size(100, 15)
        PickupLabel.TabIndex = 6
        PickupLabel.Text = "Pick-up location :"
        ' 
        ' DestinationLabel
        ' 
        DestinationLabel.Anchor = AnchorStyles.Top
        DestinationLabel.AutoSize = True
        DestinationLabel.Location = New Point(380, 6)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New Size(73, 15)
        DestinationLabel.TabIndex = 7
        DestinationLabel.Text = "Destination :"
        ' 
        ' DestinationComboBox
        ' 
        DestinationComboBox.Anchor = AnchorStyles.Top
        DestinationComboBox.AutoCompleteCustomSource.AddRange(New String() {"Juja", "Thika", "Naivasha", "Kirinyaga", "Eldoret"})
        DestinationComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
        DestinationComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
        DestinationComboBox.FormattingEnabled = True
        DestinationComboBox.Items.AddRange(New Object() {"Juja", "Thika", "Naivasha", "Kirinyaga", "Eldoret"})
        DestinationComboBox.Location = New Point(459, 11)
        DestinationComboBox.Name = "DestinationComboBox"
        DestinationComboBox.Size = New Size(152, 23)
        DestinationComboBox.TabIndex = 8
        ' 
        ' MainbodyPanel
        ' 
        MainbodyPanel.Controls.Add(PickupLabel)
        MainbodyPanel.Controls.Add(DestinationComboBox)
        MainbodyPanel.Controls.Add(PickupComboBox)
        MainbodyPanel.Controls.Add(DestinationLabel)
        MainbodyPanel.Dock = DockStyle.Fill
        MainbodyPanel.Location = New Point(154, 40)
        MainbodyPanel.Name = "MainbodyPanel"
        MainbodyPanel.Size = New Size(646, 437)
        MainbodyPanel.TabIndex = 9
        ' 
        ' UserDasboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(800, 477)
        Controls.Add(MainbodyPanel)
        Controls.Add(TopPanel)
        Controls.Add(SidePanel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "UserDasboard"
        Text = "LocateGo"
        SidePanel.ResumeLayout(False)
        SidePanel.PerformLayout()
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        MainbodyPanel.ResumeLayout(False)
        MainbodyPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SidePanel As Panel
    Friend WithEvents CooperationButton As Button
    Friend WithEvents FarmButton As Button
    Friend WithEvents HouseholdButton As Button
    Friend WithEvents BusinessButton As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents TopPanel As Panel
    Friend WithEvents NotificationButton As Button
    Friend WithEvents TrackButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents PickupComboBox As ComboBox
    Friend WithEvents PickupLabel As Label
    Friend WithEvents DestinationLabel As Label
    Friend WithEvents DestinationComboBox As ComboBox
    Friend WithEvents MainbodyPanel As Panel
End Class
