Imports System.Runtime.CompilerServices
Imports System.Threading

Public Class UserDasboard
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SidePanel.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles FarmButton.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles HouseholdButton.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BusinessButton.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CooperationButton.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles TrackButton.Click

    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Me.Close()
        Thread.Sleep(1000)
        Login.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles NotificationButton.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PickupComboBox.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DestinationComboBox.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles PickupLabel.Click

    End Sub
End Class