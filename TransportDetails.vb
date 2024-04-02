Imports MySqlConnector

Public Class TransportDetails
    Dim userId As Integer
    Dim moverId As Integer
    Dim whereFrom As String
    Dim whereTo As String
    Dim description As String
    Dim pickupday As Date
    Dim status As Boolean

    Dim conn As New MySqlConnection(GetConnection)
    Public Sub SendRequest(ByVal userId As Integer, ByVal moverId As Integer, ByVal whereFrom As String, ByVal whereto As String, ByVal description As String, ByVal pickupday As Date, ByVal status As Boolean)
        Try
            conn.Open()
            Dim insertQuery As String = "INSERT INTO requestS (userID, moverId, whereFrom, whereTo, description, pick_up_day, status) VALUES (@userId, @moverId, @whereFrom, @whereTo, @description,@pick_up_day, @status)"


            Dim cmd As New MySqlCommand(insertQuery, conn)

            cmd.Parameters.AddWithValue("@userId", userId)
            cmd.Parameters.AddWithValue("@moverId", moverId)  ' Added moverId parameter
            cmd.Parameters.AddWithValue("@whereFrom", whereFrom)
            cmd.Parameters.AddWithValue("@whereTo", whereto)
            cmd.Parameters.AddWithValue("@description", description)
            cmd.Parameters.AddWithValue("@pick_up_day", pickupday)
            cmd.Parameters.AddWithValue("@status", status)

            cmd.ExecuteNonQuery()  ' Execute the query
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub DescriptionRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles DescriptionRichTextBox.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DestinationComboBox.SelectedIndexChanged

    End Sub

    Private Sub pickuptimeLabel_Click(sender As Object, e As EventArgs) Handles pickuptimeLabel.Click

    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs)
        Hide()
    End Sub

    Private Sub sendButton_Click(sender As Object, e As EventArgs) Handles sendButton.Click
        MessageBox.Show("A message request has been sent to the moving company.You will be contacted in the next 10 minutes", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        userId = 1
        moverId = CInt(Rnd() * 100) + 1
        whereFrom = pickupComboBox.SelectedItem
        whereTo = DestinationComboBox.SelectedItem
        description = DescriptionRichTextBox.Text
        pickupday = pickDateTimePicker.Value
        status = True
        SendRequest(userId, moverId, whereFrom, whereTo, description, pickupday, status)
        pickupComboBox.ResetText()
        DescriptionRichTextBox.ResetText()
        pickDateTimePicker.ResetText()
        DestinationComboBox.ResetText()
    End Sub
End Class
