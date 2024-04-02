Imports Windows.UI.Popups
Imports Syncfusion.Windows.Forms.Tools


Public Class MiniMoverCard

    Private isFirstClick As Boolean = True
    Public previousControlStack As New Stack(Of Control)
    Dim rating As Integer = 3
    Dim pictureboxstar As New PictureBox

    Dim pictureboxwhite As New PictureBox

    'Public Sub UpdateStars(ByVal rating As Integer)
    ' pictureboxstar.Image = My.Resources.briefcase_3_24
    'pictureboxwhite.Image = My.Resources.delivery_24
    'For i As Integer = 0 To rating - 1
    ' Dim pictureBox As New PictureBox
    ' pictureBox = Panel4.Controls.OfType(Of PictureBox).ElementAt(i)
    'If i < rating Then
    '           pictureboxstar.Visible = True  ' Show filled star
    '          FlowLayoutPanel1.Controls.Add(pictureboxstar)
    'Else
    '           pictureboxwhite.Visible = True  ' Show empty star
    '          FlowLayoutPanel1.Controls.Add(pictureboxwhite)
    'End If
    '
    'Next
    'End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub


    Public Sub MiniMoverCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Private Sub MiniMoverCard_MouseLeave(sender As Object, e As EventArgs) Handles MiniMoverCardPanel.MouseLeave, Panel1.MouseLeave, Panel2.MouseLeave, Panel3.MouseLeave
    ' If Not isFirstClick Then
    '     Width = 200
    '    isFirstClick = True
    '   moredetailsbutton.Text = "more details"
    ' End If



    Private Sub Moredetailsbutton_Click(sender As Object, e As EventArgs) Handles moredetailsbutton.Click
        If isFirstClick Then
            Width = 487
            Panel1.Width = 487
            Panel3.Width = 487
            isFirstClick = False
            moredetailsbutton.Text = "less details"
        Else
            Width = 200
            isFirstClick = True
            moredetailsbutton.Text = "more details"
        End If

    End Sub
    Private Sub kgLabel_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)


    End Sub
    Dim Transportform As New TransportDetails
    Private Sub selectButton_Click(sender As Object, e As EventArgs) Handles selectButton.Click

        previousControlStack.Clear()
        Transportform.Visible = True

        Panel5.Controls.Add(Transportform)
        Panel5.Visible = True

        Panel4.Visible = True

        Size = New Size(304, MinimumSize.Height)
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Transportform.Visible = False
        Panel5.Visible = False
        Width = 486
    End Sub

    Private Sub emailTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class
