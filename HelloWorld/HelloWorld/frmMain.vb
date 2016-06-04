Public Class frmExplore

    Private Sub HelloWorld_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitle.BackColor = Color.Transparent
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Dim showSecond As New frmPlay
        showSecond.Show()
        Me.Hide()

    End Sub

    Private Sub btnExplore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExplore.Click
        Dim showSecond As New frmLearn
        showSecond.Show()
        Me.Hide()

    End Sub
End Class
