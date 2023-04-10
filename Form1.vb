Public Class Form1
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        PlayForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        SettingsForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ExitForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Store.Show()
        Me.Hide()
    End Sub
End Class
