Imports System.Text.RegularExpressions


Public Class Signup

    Private FirstNameValid As Boolean 'Is Name  Valid?
    Private LastnameValid As Boolean 'Is Surname Valid?
    Private PhoneValid As Boolean 'Is Phone Number Valid?
    Private EmailValid As Boolean 'Is Email Valid?


    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FirstNameTextbox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextbox.TextChanged
        If FirstNameTextbox.Text.Length() < 5 Then
            FirstNameTextBoxValidation.Text = "name must be longer than 5"
        Else
            FirstNameTextBoxValidation.Text = ""
        End If
    End Sub

    Private Sub SignupButton_Click(sender As Object, e As EventArgs) Handles SignupButton.Click
        If String.IsNullOrEmpty(FirstNameTextbox.Text) OrElse
            String.IsNullOrEmpty(LastNameTxtbox.Text) OrElse
            String.IsNullOrEmpty(PhoneTextbox.Text) OrElse
            String.IsNullOrEmpty(PasswordTxtBox.Text) OrElse
            String.IsNullOrEmpty(ConfirmPasswordTXTbox.Text) Then
            MessageBox.Show("Fill All Fields", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Inputs_Enter(sender As Object, e As EventArgs) Handles Inputs.Enter

    End Sub

    Private Sub ConfirmPasswordTXTbox_TextChanged(sender As Object, e As EventArgs) Handles ConfirmPasswordTXTbox.TextChanged
        If ConfirmPasswordTXTbox.Text.Equals(PasswordTxtBox.Text) Then
            passConfirm.Text = "MATCH"
        End If
    End Sub
End Class