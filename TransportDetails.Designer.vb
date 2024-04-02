<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransportDetails
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
        requestLabel = New Label()
        fromLabel = New Label()
        pickupComboBox = New ComboBox()
        DestinationComboBox = New ComboBox()
        DestinationLabel = New Label()
        DescriptionRichTextBox = New RichTextBox()
        DescriptionLabel = New Label()
        pickuptimeLabel = New Label()
        pickDateTimePicker = New DateTimePicker()
        sendButton = New Button()
        SuspendLayout()
        ' 
        ' requestLabel
        ' 
        requestLabel.AutoSize = True
        requestLabel.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        requestLabel.Location = New Point(12, 0)
        requestLabel.Name = "requestLabel"
        requestLabel.Size = New Size(270, 22)
        requestLabel.TabIndex = 0
        requestLabel.Text = "Kindly fill the information below :"
        ' 
        ' fromLabel
        ' 
        fromLabel.AutoSize = True
        fromLabel.Location = New Point(10, 48)
        fromLabel.Name = "fromLabel"
        fromLabel.Size = New Size(85, 15)
        fromLabel.TabIndex = 1
        fromLabel.Text = "Pick-up Point :"
        ' 
        ' pickupComboBox
        ' 
        pickupComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
        pickupComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
        pickupComboBox.FormattingEnabled = True
        pickupComboBox.Items.AddRange(New Object() {"Baringo County", "Bomet County", "Bungoma County", "Busia County", "Elgeyo Marakwet County", "Embu County", "Garissa County", "Homa Bay County", "Isiolo County", "Kajiado County", "Kakamega County", "Kericho County", "Kiambu County", "Kilifi County", "Kirinyaga County", "Kisii County", "Kisumu County", "Kitui County", "Kwale County", "Laikipia County", "Lamu County", "Machakos County", "Makueni County", "Mandera County", "Meru County", "Migori County", "Marsabit County", "Mombasa County", "Muranga County", "Nairobi County", "Nakuru County", "Nandi County", "Narok County", "Nyamira County", "Nyandarua County", "Nyeri County", "Samburu County", "Siaya County", "Taita Taveta County", "Tana River County", "Tharaka Nithi County", "Trans Nzoia County", "Turkana County", "Uasin Gishu County", "Vihiga County", "Wajir County", "West Pokot County"})
        pickupComboBox.Location = New Point(128, 45)
        pickupComboBox.Name = "pickupComboBox"
        pickupComboBox.Size = New Size(121, 23)
        pickupComboBox.TabIndex = 2
        ' 
        ' DestinationComboBox
        ' 
        DestinationComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
        DestinationComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
        DestinationComboBox.FormattingEnabled = True
        DestinationComboBox.Items.AddRange(New Object() {"Baringo County", "Bomet County", "Bungoma County", "Busia County", "Elgeyo Marakwet County", "Embu County", "Garissa County", "Homa Bay County", "Isiolo County", "Kajiado County", "Kakamega County", "Kericho County", "Kiambu County", "Kilifi County", "Kirinyaga County", "Kisii County", "Kisumu County", "Kitui County", "Kwale County", "Laikipia County", "Lamu County", "Machakos County", "Makueni County", "Mandera County", "Meru County", "Migori County", "Marsabit County", "Mombasa County", "Muranga County", "Nairobi County", "Nakuru County", "Nandi County", "Narok County", "Nyamira County", "Nyandarua County", "Nyeri County", "Samburu County", "Siaya County", "Taita Taveta County", "Tana River County", "Tharaka Nithi County", "Trans Nzoia County", "Turkana County", "Uasin Gishu County", "Vihiga County", "Wajir County", "West Pokot County"})
        DestinationComboBox.Location = New Point(128, 88)
        DestinationComboBox.Name = "DestinationComboBox"
        DestinationComboBox.Size = New Size(121, 23)
        DestinationComboBox.TabIndex = 4
        ' 
        ' DestinationLabel
        ' 
        DestinationLabel.AutoSize = True
        DestinationLabel.Location = New Point(9, 96)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New Size(73, 15)
        DestinationLabel.TabIndex = 3
        DestinationLabel.Text = "Destination :"
        ' 
        ' DescriptionRichTextBox
        ' 
        DescriptionRichTextBox.Location = New Point(128, 137)
        DescriptionRichTextBox.Name = "DescriptionRichTextBox"
        DescriptionRichTextBox.Size = New Size(150, 69)
        DescriptionRichTextBox.TabIndex = 5
        DescriptionRichTextBox.Text = ""
        ' 
        ' DescriptionLabel
        ' 
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New Point(9, 140)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New Size(110, 15)
        DescriptionLabel.TabIndex = 6
        DescriptionLabel.Text = "Goods Description :"
        ' 
        ' pickuptimeLabel
        ' 
        pickuptimeLabel.AutoSize = True
        pickuptimeLabel.Location = New Point(7, 228)
        pickuptimeLabel.Name = "pickuptimeLabel"
        pickuptimeLabel.Size = New Size(76, 15)
        pickuptimeLabel.TabIndex = 7
        pickuptimeLabel.Text = "Pick-up day :"
        ' 
        ' pickDateTimePicker
        ' 
        pickDateTimePicker.Location = New Point(93, 224)
        pickDateTimePicker.Name = "pickDateTimePicker"
        pickDateTimePicker.Size = New Size(189, 23)
        pickDateTimePicker.TabIndex = 9
        pickDateTimePicker.Value = New Date(2024, 3, 31, 23, 2, 30, 0)
        ' 
        ' sendButton
        ' 
        sendButton.BackColor = Color.FromArgb(CByte(168), CByte(100), CByte(62))
        sendButton.Location = New Point(164, 268)
        sendButton.Name = "sendButton"
        sendButton.Size = New Size(75, 23)
        sendButton.TabIndex = 11
        sendButton.Text = "Send"
        sendButton.UseVisualStyleBackColor = False
        ' 
        ' TransportDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(sendButton)
        Controls.Add(pickDateTimePicker)
        Controls.Add(pickuptimeLabel)
        Controls.Add(DescriptionLabel)
        Controls.Add(DescriptionRichTextBox)
        Controls.Add(DestinationComboBox)
        Controls.Add(DestinationLabel)
        Controls.Add(pickupComboBox)
        Controls.Add(fromLabel)
        Controls.Add(requestLabel)
        Name = "TransportDetails"
        Size = New Size(295, 313)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents requestLabel As Label
    Friend WithEvents fromLabel As Label
    Friend WithEvents pickupComboBox As ComboBox
    Friend WithEvents DestinationComboBox As ComboBox
    Friend WithEvents DestinationLabel As Label
    Friend WithEvents DescriptionRichTextBox As RichTextBox
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents pickuptimeLabel As Label
    Friend WithEvents pickDateTimePicker As DateTimePicker
    Friend WithEvents sendButton As Button

End Class
