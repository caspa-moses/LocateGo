Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text

Public Class LOGIN
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextbox.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles EmailTextbox.TextChanged

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim Email As String = EmailTextbox.Text
        Dim Password As String = PasswordTextbox.Text


        Dim hashedPassword As String = HashPassword(Password)


        If String.IsNullOrEmpty(EmailTextbox.Text) Then
            MessageBox.Show("Email Required", "Empty Email", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If

        If Not EmailTextbox.Text.Contains("@") Then

            MessageBox.Show("Email address is invalid.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If EmailTextbox.Text = "Admin" AndAlso PasswordTextbox.Text = "Password" Then
            MessageBox.Show("Login Succesful", "Succesful Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Invalid Email or Password", "error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If

    End Sub

    Private Function HashPassword(ByVal Password As String) As String

        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password))
            Dim builder As New StringBuilder()

            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function
End Class
