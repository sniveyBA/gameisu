Public Class frmPlay

    Private Sub btnLevel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel1.Click
        Dim showSecond As New frmLevel1
        showSecond.Show()
        Me.Close()

    End Sub

    Private Sub btnLevel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel2.Click
        Dim showSecond As New frmLevel2
        showSecond.Show()
        Me.Close()

    End Sub

    Private Sub btnLevel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel3.Click
        Dim showSecond As New frmLevel3
        showSecond.Show()
        Me.Close()
    End Sub


End Class