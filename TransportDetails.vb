Public Class TransportDetails
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
        pickupComboBox.ResetText()
        DescriptionRichTextBox.ResetText()
        pickDateTimePicker.ResetText()
        DestinationComboBox.ResetText()
    End Sub
End Class
