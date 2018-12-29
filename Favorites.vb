Public Class Favorites

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lstFavorites.ClearSelected()
        'clears the selected bookmark from the listbox
    End Sub

    Private Sub btnGoTo_Click(sender As Object, e As EventArgs) Handles btnGoTo.Click

        If lstFavorites.SelectedItem <> "" Then 'checks thats the selected item is not null
            Form1.WebBrowser1.Navigate(lstFavorites.SelectedItem) 'Then goes to the selected url
        Else
            MessageBox.Show("Nothing is Selected!") 'If it is null then shows message telling user
        End If
    End Sub
End Class