Imports System.IO
Imports System.Text.RegularExpressions


Public Class MoversSignup
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles LocationTextBox.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CompanyNameTextBox.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles BusinessNumberTextBox.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ProfilePictureBox.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectedIndexChanged


        CategoryComboBox.Items.Add("Farm")
        CategoryComboBox.Items.Add("Business")
        CategoryComboBox.Items.Add("Household")
        CategoryComboBox.Items.Add("Courier")
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ProfilePictureBox.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Function IsPasswordValid(password As String) As Boolean

        Dim regex As New Regex("^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")
        Return regex.IsMatch(password)
    End Function


    Private Sub MoversSignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        Dim companyName As String = CompanyNameTextBox.Text
        Dim email As String = EmailTextBox.Text
        Dim password As String = PasswordTextBox.Text
        Dim businessNumber As String = BusinessNumberTextBox.Text
        Dim category As String = CategoryComboBox.SelectedItem.ToString()
        Dim location As String = LocationTextBox.Text

        If String.IsNullOrEmpty(companyName) OrElse
           String.IsNullOrEmpty(email) OrElse
           String.IsNullOrEmpty(password) OrElse
           String.IsNullOrEmpty(businessNumber) OrElse
           String.IsNullOrEmpty(category) OrElse
           String.IsNullOrEmpty(location) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not IsEmailValid(email) Then
            MessageBox.Show("Email format is invalid. Please enter a valid Gmail address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsPasswordValid(password) Then
            MessageBox.Show("Password must be at least 8 characters long, contain at least one capital letter, one number, one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not password.Equals(ConfirmPasswordTextBox) Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim profilePictureFileName As String = ""
        If ProfilePictureBox.Image IsNot Nothing Then
            profilePictureFileName = Path.Combine(Application.StartupPath, "ProfilePictures", $"{Guid.NewGuid().ToString()}.jpg")
            ProfilePictureBox.Image.Save(profilePictureFileName)
        End If

        Dim hashedPassword As String = HashPassword(password)


        Dim signUpInfo As String = $"Company Name: {companyName}{Environment.NewLine}" &
                                   $"Email: {email}{Environment.NewLine}" &
                                   $"Password: {password}{Environment.NewLine}" &
                                   $"Business Number: {businessNumber}{Environment.NewLine}" &
                                   $"Category: {category}{Environment.NewLine}" &
                                   $"Location: {location}{Environment.NewLine}" &
                                   $"Profile Picture: {profilePictureFileName}"
        MessageBox.Show(signUpInfo, "Sign Up Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)


        CompanyNameTextBox.Clear()
        EmailTextBox.Clear()
        PasswordTextBox.Clear()
        BusinessNumberTextBox.Clear()
        ProfilePictureBox.Image = Nothing
        CategoryComboBox.SelectedIndex = -1
        LocationTextBox.Clear()
    End Sub

    Private Function IsEmailValid(email As String) As Boolean

        Dim regex As New Regex("^([\w\.\-]+)@gmail\.com$")
        Return regex.IsMatch(email)
    End Function



    Private Function HashPassword(password As String) As String

        Return password
    End Function

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CategoryComboBox.Items.Add("Farm")
        CategoryComboBox.Items.Add("Business")
        CategoryComboBox.Items.Add("Household")
        CategoryComboBox.Items.Add("Courier")
    End Sub



    Private Sub CompanyEmailLabel_Click(sender As Object, e As EventArgs) Handles CompanyEmailLabel.Click

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub BusinessNumberLabel_Click(sender As Object, e As EventArgs) Handles BusinessNumberLabel.Click

    End Sub

    Private Sub CategoryLabel_Click(sender As Object, e As EventArgs) Handles CategoryLabel.Click

    End Sub
End Class
