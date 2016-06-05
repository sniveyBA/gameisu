Public Class frmLearnBox

    Dim loadData As Integer


    Private Sub frmLearnBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        loadData = frmLearn.shareMon

        If loadData = 1 Then
            lblCountry.Text = country.austr
            lblCapital.Text = capital.austr
            lblHead.Text = head.austr
            lblMonument.Text = mon.austr
        ElseIf loadData = 2 Then
            lblCountry.Text = country.brazil
            lblCapital.Text = capital.brazil
            lblHead.Text = head.brazil
            lblMonument.Text = mon.brazil
        ElseIf loadData = 3 Then
            lblCountry.Text = country.canada
            lblCapital.Text = capital.canada
            lblHead.Text = head.canada
            lblMonument.Text = mon.canada
        ElseIf loadData = 4 Then
            lblCountry.Text = country.china
            lblCapital.Text = capital.china
            lblHead.Text = head.china
            lblMonument.Text = mon.china
        ElseIf loadData = 5 Then
            lblCountry.Text = country.egypt
            lblCapital.Text = capital.egypt
            lblHead.Text = head.egypt
            lblMonument.Text = mon.egypt
        ElseIf loadData = 6 Then
            lblCountry.Text = country.england
            lblCapital.Text = capital.england
            lblHead.Text = head.england
            lblMonument.Text = mon.england
        ElseIf loadData = 7 Then
            lblCountry.Text = country.ethiopia
            lblCapital.Text = capital.ethiopia
            lblHead.Text = head.ethiopia
            lblMonument.Text = mon.ethiopia
        ElseIf loadData = 8 Then
            lblCountry.Text = country.france
            lblCapital.Text = capital.france
            lblHead.Text = head.france
            lblMonument.Text = mon.france
        ElseIf loadData = 9 Then
            lblCountry.Text = country.germany
            lblCapital.Text = capital.germany
            lblHead.Text = head.germany
            lblMonument.Text = mon.germany
        ElseIf loadData = 10 Then
            lblCountry.Text = country.ghana
            lblCapital.Text = capital.ghana
            lblHead.Text = head.ghana
            lblMonument.Text = mon.ghana
        ElseIf loadData = 11 Then
            lblCountry.Text = country.india
            lblCapital.Text = capital.india
            lblHead.Text = head.india
            lblMonument.Text = mon.india
        ElseIf loadData = 12 Then
            lblCountry.Text = country.italy
            lblCapital.Text = capital.italy
            lblHead.Text = head.italy
            lblMonument.Text = mon.italy
        ElseIf loadData = 13 Then
            lblCountry.Text = country.japan
            lblCapital.Text = capital.japan
            lblHead.Text = head.japan
            lblMonument.Text = mon.japan
        ElseIf loadData = 14 Then
            lblCountry.Text = country.mexico
            lblCapital.Text = capital.mexico
            lblHead.Text = head.mexico
            lblMonument.Text = mon.mexico
        ElseIf loadData = 15 Then
            lblCountry.Text = country.peru
            lblCapital.Text = capital.peru
            lblHead.Text = head.peru
            lblMonument.Text = mon.peru
        ElseIf loadData = 16 Then
            lblCountry.Text = country.phil
            lblCapital.Text = capital.phil
            lblHead.Text = head.phil
            lblMonument.Text = mon.phil
        ElseIf loadData = 17 Then
            lblCountry.Text = country.russia
            lblCapital.Text = capital.russia
            lblHead.Text = head.russia
            lblMonument.Text = mon.russia
        ElseIf loadData = 18 Then
            lblCountry.Text = country.saudi
            lblCapital.Text = capital.saudi
            lblHead.Text = head.saudi
            lblMonument.Text = mon.saudi
        ElseIf loadData = 19 Then
            lblCountry.Text = country.sAfrica
            lblCapital.Text = capital.sAfrica
            lblHead.Text = head.sAfrica
            lblMonument.Text = mon.sAfrica
        ElseIf loadData = 20 Then
            lblCountry.Text = country.sKorea
            lblCapital.Text = capital.sKorea
            lblHead.Text = head.sKorea
            lblMonument.Text = mon.sKorea
        ElseIf loadData = 21 Then
            lblCountry.Text = country.turk
            lblCapital.Text = capital.turk
            lblHead.Text = head.turk
            lblMonument.Text = mon.turk
        ElseIf loadData = 22 Then
            lblCountry.Text = country.usa
            lblCapital.Text = capital.usa
            lblHead.Text = head.usa
            lblMonument.Text = mon.usa
        End If

    End Sub

End Class