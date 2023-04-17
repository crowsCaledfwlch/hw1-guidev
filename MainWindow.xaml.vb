Class MainWindow
    Private Sub btn1_Click(sender As Object, e As RoutedEventArgs) Handles btn1.Click
        lblFrench.Content = "un"
    End Sub

    Private Sub btn2_Click(sender As Object, e As RoutedEventArgs) Handles btn2.Click
        lblFrench.Content = "deux"
    End Sub

    Private Sub btn3_Click(sender As Object, e As RoutedEventArgs) Handles btn3.Click
        lblFrench.Content = "trois"
    End Sub

    Private Sub btn4_Click(sender As Object, e As RoutedEventArgs) Handles btn4.Click
        lblFrench.Content = "quatre"
    End Sub

    Private Sub btn5_Click(sender As Object, e As RoutedEventArgs) Handles btn5.Click
        lblFrench.Content = "cinq"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As RoutedEventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frm_Loaded(sender As Object, e As RoutedEventArgs)
        Me.WindowStartupLocation = WindowStartupLocation.CenterScreen

    End Sub
End Class
