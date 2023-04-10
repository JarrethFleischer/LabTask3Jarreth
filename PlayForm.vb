Public Class PlayForm
    Private Sub PlayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAttack_Click(sender As Object, e As EventArgs) Handles btnAttack.Click
        Dim playerhealth As Integer = Val(tbPlayerHealth.Text)
        Dim playerarmor As Integer = Val(tbPlayerArmor.Text)
        Dim playermana As Integer = Val(tbPlayerMana.Text)
        Dim omenhealth As Integer = Val(tbOmenHealth.Text)

        Dim attack As Integer
        attack = 50000

        omenhealth = omenhealth - attack



        If omenhealth < 400000 Then
            tbPlayerHealth.Text = playerhealth - 5000
            tbPlayerArmor.Text = playerarmor - 10
            tbPlayerMana.Text = playermana - 100

        End If
        tbOmenHealth.Text = omenhealth.ToString

        If omenhealth = 0 Then
            MessageBox.Show("You have defeated Omen!")
            Form1.Show()
            Me.Hide()
        End If
    End Sub

End Class