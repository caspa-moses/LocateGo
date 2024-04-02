Imports System.Text
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms ' Import necessary namespace for MessageBox
Imports System.Security.Cryptography ' Import necessary namespace for SHA256Managed


Public Class Signup
    Dim sqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub SignupButton_Click(sender As Object, e As EventArgs) Handles SignupButton.Click
        If String.IsNullOrWhiteSpace(FirstNameTextbox.Text) OrElse
           String.IsNullOrWhiteSpace(LastNameTxtbox.Text) OrElse
           String.IsNullOrWhiteSpace(PhoneTextbox.Text) OrElse
           String.IsNullOrWhiteSpace(EmailTxtBox.Text) OrElse
           String.IsNullOrWhiteSpace(PasswordTxtBox.Text) OrElse
           String.IsNullOrWhiteSpace(ConfirmPasswordTXTbox.Text) Then
            'prompt user to fill in all the fields
            MessageBox.Show("Please fill in all fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If PhoneTextbox.Text.Length <> 10 Then
            ' Phone number does not contain exactly 10 digits, show error message
            MessageBox.Show("Phone number must contain exactly 10 digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if email contains '@'
        If Not EmailTxtBox.Text.Contains("@") Then
            ' Email does not contain '@', show error message
            MessageBox.Show("Email address is invalid.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If PasswordTxtBox.Text <> ConfirmPasswordTXTbox.Text Then
            ' Password and confirm password do not match, show error message
            MessageBox.Show("Password and Confirm Password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If PasswordTxtBox.Text.Length < 8 OrElse Not ContainsNumber(PasswordTxtBox.Text) Then
            ' Password does not meet requirements, show error message
            MessageBox.Show("Password must be at least 8 characters long and contain at least one number.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        SubmitFormData()


    End Sub

    Private Function HashPassword(ByVal password As String) As String
        Using sha256 As New SHA256Managed()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Dim builder As New StringBuilder()

            For Each b As Byte In hashBytes
                builder.Append(b.ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function

    Private Function ContainsNumber(ByVal input As String) As Boolean
        For Each c As Char In input
            If Char.IsDigit(c) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub SubmitFormData()
        sqlconn = New MySqlConnection(GetConnection())
        Dim password As String = PasswordTxtBox.Text
        ' Hash the password
        Dim hashedPassword As String = HashPassword(password)
        Dim Query As String
        Query = "INSERT INTO User(First_Name, Last_Name, Phone_Number, email, pswd)
            VALUES('" & FirstNameTextbox.Text & "','" & LastNameTxtbox.Text & "','" & PhoneTextbox.Text & "',
            '" & EmailTxtBox.Text & "','" & hashedPassword & "')"

        Try
            sqlconn.Open()
            MessageBox.Show("connection successful")

            COMMAND = New MySqlCommand(Query, sqlconn)

            Dim rowsAffected As Integer = COMMAND.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Registration successful!")
            Else
                MessageBox.Show("Registration failed!")
            End If

            sqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            sqlconn.Dispose()
            FirstNameTextbox.Clear()
            LastNameTxtbox.Clear()
            PhoneTextbox.Clear()
            EmailTxtBox.Clear()
            PasswordTxtBox.Clear()
            ConfirmPasswordTXTbox.Clear()
            UserDasboard.Show()
            Me.Hide()

        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class