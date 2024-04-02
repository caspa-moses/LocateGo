Imports System.Threading
Imports MySqlConnector
Imports Syncfusion.Windows.Forms.Tools
Imports System.Text.RegularExpressions
Imports Windows.Storage.Streams
Imports Org.BouncyCastle.Crypto
Imports System.Globalization

Public Class UserDasboard

    Dim categoryState As String
    Dim searchString As String
    Dim conn As New MySqlConnection(GetConnection)
    Private Sub LoadContent(ByVal categoryState As String)
        Try
            conn.Open()

            Dim selectQuery As String = "SELECT Name, Email, Phone,
Image_path, Rating, Price_per_Kg, Price_per_Km FROM movers_profile WHERE Category = @categoryState "  ' Modified query to match MiniMoverCard fields

            Dim movers As New List(Of MiniMoverCard)  ' Create a list to hold MiniMoverCard instances

            Using da As New MySqlDataAdapter(selectQuery, conn)  ' Create a data adapter
                da.SelectCommand.Parameters.AddWithValue("@categoryState", categoryState)
                Dim moversDataset As New DataSet  ' Create a dataset
                da.Fill(moversDataset)  ' Fill the dataset with query results

                If moversDataset.Tables(0).Rows.Count > 0 Then  ' Check if any movers found
                    For Each row As DataRow In moversDataset.Tables(0).Rows
                        Dim miniMoverCard As New MiniMoverCard  ' Create a new MiniMoverCard instance

                        ' Set properties on MiniMoverCard (same as previous code)
                        miniMoverCard.companynameLabel.Text = row("Name").ToString
                        miniMoverCard.moverPictureBox.ImageLocation = row("Image_path").ToString
                        miniMoverCard.KgTextBox.Text = Convert.ToDecimal(row("Price_per_Kg"))
                        miniMoverCard.kmTextBox.Text = row("Price_per_Km")
                        miniMoverCard.RatingTextBox.Text = row("Rating")
                        miniMoverCard.phoneTextBox.Text = row("Phone")
                        miniMoverCard.emailTextBox.Text = row("Email")

                        'Dim ratingControl1 As RatingControl = New RatingControl
                        'miniMoverCard.FlowLayoutPanel1.Controls.Add(ratingControl1)
                        'ratingControl1.Value = row("Rating")
                        'miniMoverCard.UpdateStars(Convert.ToUInt32(row("Rating")))



                        movers.Add(miniMoverCard)  ' Add MiniMoverCard to the list
                    Next
                End If
            End Using

            conn.Close()  ' Close the connection


            If movers.Count > 0 Then  ' Check if any movers retrieved

                MainFlowLayoutPanel.Controls.Clear()

                For i As Integer = 0 To movers.Count - 1
                    MainFlowLayoutPanel.Controls.Add(movers(i))  ' Add MiniMoverCard to mainPanel
                    ' Set margins or other layout properties for FlowLayoutPanel
                    movers(i).Margin = New Padding(10)  ' Example margin for spacing
                Next
            Else
                ' Handle case where no movers found 
                MessageBox.Show("No business movers found in the database.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub GetSearch(ByVal searchString As String)
        Try
            conn.Open()
            Dim selectQuery As String = "SELECT Name, Email, Phone,
Image_path, Rating, Price_per_Kg, Price_per_Km FROM movers_profile"

            Dim command As New MySqlCommand(selectQuery, conn)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            Dim movers As New List(Of MiniMoverCard)
            Dim Regexpattern As String = Regex.Escape(searchString) & ".?"
            For Each row In reader
                Dim name As String = row("Name").ToString
                If Regex.IsMatch(name, Regexpattern, RegexOptions.IgnoreCase) Then
                    Dim miniMoverCard As New MiniMoverCard
                    miniMoverCard.companynameLabel.Text = row("Name").ToString
                    miniMoverCard.moverPictureBox.ImageLocation = row("Image_path").ToString
                    miniMoverCard.KgTextBox.Text = Convert.ToDecimal(row("Price_per_Kg"))
                    miniMoverCard.kmTextBox.Text = row("Price_per_Km")
                    miniMoverCard.RatingTextBox.Text = row("Rating")
                    miniMoverCard.phoneTextBox.Text = row("Phone")
                    miniMoverCard.emailTextBox.Text = row("Email")

                    'Dim ratingControl1 As RatingControl = New RatingControl
                    'miniMoverCard.FlowLayoutPanel1.Controls.Add(ratingControl1)
                    'ratingControl1.Value = row("Rating")

                    movers.Add(miniMoverCard)
                End If

            Next
            reader.Close()
            conn.Close()

            If movers.Count > 0 Then  ' Check if any movers retrieved

                MainFlowLayoutPanel.Controls.Clear()

                For i As Integer = 0 To movers.Count - 1
                    MainFlowLayoutPanel.Controls.Add(movers(i))  ' Add MiniMoverCard to mainPanel
                    ' Set margins or other layout properties for FlowLayoutPanel
                    movers(i).Margin = New Padding(10)  ' Example margin for spacing
                Next
            Else
                ' Handle case where no movers found 
                MessageBox.Show("No business movers found in the database.")
            End If



        Catch ex As Exception
            MessageBox.Show("Failed to connect" & ex.Message)

        End Try
    End Sub
    'Public Sub GetSort(ByVal categoryState As String, ByVal toSort As String)
    '    Dim sortOrder As String = "ASC"  ' Default sort order
    '    Dim sortQuery As String

    '    If toSort Is "Prices per Kg" Then
    '        ' Descending order for price-related sorts
    '        sortQuery = "SELECT * FROM movers_profile WHERE Category = @categoryState ORDER BY Prive_per_Kg ASC"
    '    ElseIf toSort Is "Price per Km" Then
    '        sortQuery = "SELECT * FROM movers_profile WHERE Category = @categoryState ORDER BY Prive_per_Km ASC"
    '    ElseIf toSort Is "Rating" Then
    '        sortQuery = "SELECT * FROM movers_profile WHERE Category = @categoryState ORDER BY Rating DESC"
    '    ElseIf toSort Is "A_Z" Then
    '        sortQuery = "SELECT * FROM movers_profile WHERE Category = @categoryState ORDER BY name ASC"
    '    End If


    '    Dim movers As New List(Of MiniMoverCard)
    '    Try
    '        conn.Open()
    '        Using command As New MySqlCommand(sortQuery, conn)
    '            command.Parameters.AddWithValue("@categoryState", categoryState)
    '            command.Parameters.AddWithValue("@toSort", toSort)

    '            Dim reader As MySqlDataReader = command.ExecuteReader()

    '            For Each row In reader
    '                Dim miniMoverCard As New MiniMoverCard
    '                miniMoverCard.companynameLabel.Text = row("Name").ToString
    '                miniMoverCard.emailTextBox.Text = row("Email").ToString
    '                miniMoverCard.phoneTextBox.Text = row("Phone").ToString
    '                miniMoverCard.KgTextBox.Text = Convert.ToDecimal(row("Price_per_Kg")).ToString("0.00")  ' Format price with two decimal places
    '                miniMoverCard.kmTextBox.Text = Convert.ToDecimal(row("Price_per_Km")).ToString("0.00") ' Format price with two decimal places
    '                miniMoverCard.RatingTextBox.Text = row("Rating").ToString
    '                miniMoverCard.moverPictureBox.ImageLocation = row("ImagePath").ToString

    '                movers.Add(miniMoverCard)
    '                MessageBox.Show($"Found {movers.Count} movers.")
    '            Next

    '            reader.Close()
    '        End Using


    '        conn.Close()  ' Close the connection


    '        If movers.Count > 0 Then  ' Check if any movers retrieved

    '        MainFlowLayoutPanel.Controls.Clear()
    '        For i As Integer = 0 To movers.Count - 1
    '            MainFlowLayoutPanel.Controls.Add(movers(i))  ' Add MiniMoverCard to mainPanel
    '            ' Set margins or other layout properties for FlowLayoutPanel
    '            movers(i).Margin = New Padding(10)  ' Example margin for spacing
    '        Next
    '    Else
    '        ' Handle case where no movers found 
    '        MessageBox.Show("No business movers found in the database.")
    '    End If
    '    Catch ex As Exception
    '    MessageBox.Show(ex.Message)
    '    Finally
    '    conn.Close()
    '    End Try
    'End Sub
    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Me.Close()
        Thread.Sleep(1000)
        Login.Show()
    End Sub

    Dim previousSelectedButton As Button = Nothing  ' Stores the previously selected button
    Public Sub ChangeColor(ByVal categoryState As String)

        If previousSelectedButton IsNot Nothing Then
            previousSelectedButton.BackColor = Color.FromArgb(168, 100, 62)
        End If

        ' Set the background color for the newly selected button
        If categoryState = "Business" Then
            BusinessButton.BackColor = Color.FromArgb(168, 100, 30)
            previousSelectedButton = BusinessButton
        ElseIf categoryState = "Household" Then
            HouseholdButton.BackColor = Color.FromArgb(168, 100, 30)
            previousSelectedButton = HouseholdButton
        ElseIf categoryState = "Farm" Then
            FarmButton.BackColor = Color.FromArgb(168, 100, 30)
            previousSelectedButton = FarmButton
        ElseIf categoryState = "Courier service" Then
            CourierButton.BackColor = Color.FromArgb(168, 100, 30)
            previousSelectedButton = CourierButton
        End If


    End Sub
    Private Sub BusinessButton_Click(sender As Object, e As EventArgs) Handles BusinessButton.Click
        categoryState = "Business"
        ChangeColor(categoryState)
        LoadContent(categoryState)

    End Sub

    Private Sub HouseholdButton_Click(sender As Object, e As EventArgs) Handles HouseholdButton.Click
        categoryState = "Household"
        ChangeColor(categoryState)
        LoadContent(categoryState)
    End Sub

    Private Sub FarmButton_Click(sender As Object, e As EventArgs) Handles FarmButton.Click
        categoryState = "Farm"
        ChangeColor(categoryState)
        LoadContent(categoryState)
    End Sub

    Private Sub CourierButton_Click(sender As Object, e As EventArgs) Handles CourierButton.Click
        categoryState = "Courier service"
        ChangeColor(categoryState)
        LoadContent(categoryState)
    End Sub

    Private Sub UserDasboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        categoryState = "Business"
        LoadContent(categoryState)
    End Sub


    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        searchString = SearchTextBox.Text
        GetSearch(searchString)
    End Sub

    Private Sub MainFlowLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainFlowLayoutPanel.Paint

    End Sub

    'Private Sub SortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SortComboBox.SelectedIndexChanged
    '    GetSort(categoryState, SortComboBox.SelectedItem)
    'End Sub
End Class