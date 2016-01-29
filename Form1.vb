Public Class Form1
    'Deshon Mcneil 
    '2016
    'free to copy if credit is given.
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label1.Text = "Ready"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebBrowser1.GoBack()
        'Back button
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(ComboBox1.Text)
        'Navigation
        ComboBox1.Items.Add(ComboBox1.Text)

        History.ListBox1.Items.Add(ComboBox1.Text)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        ComboBox1.Text = WebBrowser1.Url.ToString
        'Changes text in textbox to current url
        Label1.Text = "Done"
        'tells the loading label that the page is done loading
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser1.GoForward()
        'Forward button
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()
        'refreshes the webpage
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs)
        Label1.Text = "Loading"
        'if the page is loading the label will say loading.
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        WebBrowser1.Navigate(urlString:="www.google.com")

    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        MessageBox.Show("This toolbar is not fully functional yet. It will be soon.")
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click

    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click


    End Sub

    Private Sub WebBrowser1_DocumentTitleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebBrowser1.DocumentTitleChanged
        ComboBox1.Text = WebBrowser1.Url.ToString
        'This will also change the text in the combobox to the url.
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        WebBrowser1.Navigate("https://www.google.com/?gws_rd=ssl#q=" + TextBox1.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        History.ListBox1.Items.Add(ComboBox1.Text)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        History.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Favorites.ListBox1.Items.Add(ComboBox1.Text)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Favorites.Show()

    End Sub
End Class
