Public Class MoverCard


    Dim rating As Integer = 5
    Private Sub UpdateStars(rating As Integer)
        For i As Integer = 1 To 5  ' Start from index 1 (skipping logo)
            Dim pictureBox As PictureBox = Me.Controls.OfType(Of PictureBox)().ElementAt(i)
            If i <= rating Then  ' Filled star if index is less than or equal to rating (inclusive)
                pictureBox.Image = My.Resources.search_13_16
                ' Replace with your filled star image path
            Else
                ' pictureBox.Image = My.Resources.
                ' Replace with your empty star image path
            End If
        Next
    End Sub
    Private Sub MoverCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
