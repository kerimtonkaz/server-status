Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "&Başlat" Then
            Button1.Text = "&Durdur"
            patches.start()
        Else
            patches.stop()
            Button1.Text = "&Başlat"
        End If
    End Sub

    Private Sub patches_Tick(sender As Object, e As EventArgs) Handles patches.Tick
        WebBrowser1.Refresh()
    End Sub
End Class