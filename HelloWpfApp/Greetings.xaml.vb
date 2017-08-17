Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If rb1.IsChecked = True Then
            MessageBox.Show("Hello")
        Else rb2.IsChecked = True
            MessageBox.Show("Goodbye")
        End If

    End Sub
End Class
