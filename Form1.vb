Public Class Form1
    'Deshon Mcneil 
    '2016 (2018 Revision)
    'free to copy if credit is given.
    Public homePage As String = "Google.com" 'Set homepage

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblLoadInfo.Text = "Ready" 'Change info label
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        WebBrowser1.GoBack()
        'Back button
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(cmbUrl.Text) 'Navigates to the texts in the combobox

        cmbUrl.Items.Add(cmbUrl.Text) 'Adds recent text to combobox list, aka history

        History.ListBox1.Items.Add(cmbUrl.Text) 'Adds to history
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        cmbUrl.Text = WebBrowser1.Url.ToString
        'Changes text in textbox to current url
        lblLoadInfo.Text = "Done"
        'tells the loading label that the page is done loading
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnForward.Click
        WebBrowser1.GoForward()
        'Forward button
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        WebBrowser1.Refresh()
        'refreshes the webpage
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs)
        lblLoadInfo.Text = "Loading"
        'if the page is loading the label will say loading.
    End Sub

    Public Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click

        WebBrowser1.Navigate(urlString:=homePage)
        'Home button
    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        'Not Handled Yet
        MessageBox.Show("This toolbar is not fully functional yet. It will be soon.")
        'Show Not handled message
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        'Not Handled Yet
        MessageBox.Show("This button is not fully functional yet. It will be soon.")
        'Show Not handled message
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        'Not Handled Yet
        MessageBox.Show("This button is not fully functional yet. It will be soon.")
        'Show Not handled message
    End Sub

    Private Sub WebBrowser1_DocumentTitleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebBrowser1.DocumentTitleChanged
        cmbUrl.Text = WebBrowser1.Url.ToString
        'This will also change the text in the combobox to the url.
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        WebBrowser1.Navigate("https://www.google.com/?gws_rd=ssl#q=" + txtSearch.Text)
        'Searches using the search textbox
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUrl.SelectedIndexChanged
        History.ListBox1.Items.Add(cmbUrl.Text)
        'Adds Url to history
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowHistory.Click
        History.Show()
        'Show history
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFav.Click
        Favorites.lstFavorites.Items.Add(cmbUrl.Text)
        'Add to favorites list
        MessageBox.Show("Added to favorites!")

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowFav.Click
        Favorites.Show()
        'Show favorites list
    End Sub
End Class
'This was dumb af, idk why I did it in the first place.