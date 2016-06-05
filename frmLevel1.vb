Public Class frmLevel1

    Dim intNumber As Integer
    Dim usedNumber(0 To 23) As Integer
    Dim arrCount As Integer
    Dim arrNumber(0 To 23) As Integer
    Dim qNumber As Integer
    Dim counter As Integer = -10
    Dim gRad As Integer
    Dim correctRad As Integer


    Public Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        'Assign the guessed radio button to a variable 
        If radOne.Checked = True Then
            gRad = 1
        ElseIf radTwo.Checked = True Then
            gRad = 2
        ElseIf radThree.Checked = True Then
            gRad = 3
        ElseIf radFour.Checked = True Then
            gRad = 4
        End If

        'Compare the guessed radio button To the correct radio button, the value being set by the last
        'iteration of the question call
        If gRad = correctRad Then
            counter += 10           'Add score for right ans, subtract for wrong
        Else
            counter -= 5
        End If

        'Set the label to the value of the score 
        lblCounter.Text = counter

        'Reset the state of the radio buttons to all be unchecked
        radOne.Checked = False
        radTwo.Checked = False
        radThree.Checked = False
        radFour.Checked = False

        If arrCount = 20 Then
            Dim showSecond As New frmPlay
            showSecond.Show()
            Me.Close()
        End If
        'Random number, from 1 to 22, with no repeating values 
        VBMath.Randomize()
Start:
        Dim y As Integer
        intNumber = Int((21 * Rnd()) + 1)
        For y = 0 To 22 Step 1
            If intNumber = usedNumber(y) Then
                GoTo Start
            End If
            If y = 22 Then
                usedNumber(arrCount) = intNumber
                arrCount += 1
                qNumber = intNumber

                'Assign questions to each generated number, to diplay 22, unique questions, in random order
                Select Case qNumber
                    Case 1
                        lblQuestion.Text = "What is the capital of" & country.austr & "?"
                        radOne.Text = "Sydney"
                        radTwo.Text = " Ottawa "
                        radThree.Text = " London "
                        radFour.Text = " Canberra "
                        correctRad = 4

                    Case 2
                        lblQuestion.Text = "What is the capital of" & country.brazil & "?"
                        radOne.Text = " Cairo"
                        radTwo.Text = " Manila"
                        radThree.Text = " Brasilia"
                        radFour.Text = " London"
                        correctRad = 3

                    Case 3
                        lblQuestion.Text = "What is the capital of" & country.canada & "?"
                        radOne.Text = " Moscow "
                        radTwo.Text = " Ottawa "
                        radThree.Text = " Washington "
                        radFour.Text = " New Delhi "
                        correctRad = 2
                    Case 4
                        lblQuestion.Text = "What is the capital of" & country.china & "?"
                        radOne.Text = " Berlin "
                        radTwo.Text = " Beijing "
                        radThree.Text = " Ankara "
                        radFour.Text = " Canberra "
                        correctRad = 2

                    Case 5
                        lblQuestion.Text = "What is the capital of" & country.egypt & "?"
                        radOne.Text = " Rome "
                        radTwo.Text = " Cairo "
                        radThree.Text = " Manila "
                        radFour.Text = " Seoul "
                        correctRad = 2

                    Case 6
                        lblQuestion.Text = "What is the capital of" & country.england & "?"
                        radOne.Text = " Tokyo "
                        radTwo.Text = " Cape Town "
                        radThree.Text = " Lima "
                        radFour.Text = " London "
                        correctRad = 4

                    Case 7
                        lblQuestion.Text = "What is the capital of" & country.ethiopia & "?"
                        radOne.Text = " Manila "
                        radTwo.Text = " Ankara "
                        radThree.Text = " Addis Ababa "
                        radFour.Text = " Riyadh "
                        correctRad = 3

                    Case 8
                        lblQuestion.Text = "What is the capital of" & country.france & "?"
                        radOne.Text = " Cairo "
                        radTwo.Text = " Paris "
                        radThree.Text = " London "
                        radFour.Text = " Pretoria "
                        correctRad = 2

                    Case 9
                        lblQuestion.Text = "What is the capital of" & country.germany & "?"
                        radOne.Text = " Berlin "
                        radTwo.Text = " Brasilia "
                        radThree.Text = " Riyadh "
                        radFour.Text = " Accra "
                        correctRad = 1

                    Case 10
                        lblQuestion.Text = "What is the capital of" & country.ghana & "?"
                        radOne.Text = " Riyadh "
                        radTwo.Text = " Bloemfontein "
                        radThree.Text = " Accra "
                        radFour.Text = " Addis Ababa "
                        correctRad = 3

                    Case 11
                        lblQuestion.Text = "What is the capital of" & country.india & "?"
                        radOne.Text = " Riyadh "
                        radTwo.Text = " New Delhi "
                        radThree.Text = " Canberra "
                        radFour.Text = " Moscow "
                        correctRad = 2

                    Case 12
                        lblQuestion.Text = "What is the capital of" & country.italy & "?"
                        radOne.Text = " Ankara "
                        radTwo.Text = " Ottawa "
                        radThree.Text = " Rome "
                        radFour.Text = " Berlin "
                        correctRad = 3

                    Case 13
                        lblQuestion.Text = "What is the capital of" & country.japan & "?"
                        radOne.Text = " Manila "
                        radTwo.Text = " Beijing "
                        radThree.Text = " Tokyo "
                        radFour.Text = " Seoul "
                        correctRad = 3

                    Case 14
                        lblQuestion.Text = "What is the capital of" & country.mexico & "?"
                        radOne.Text = " Tokyo "
                        radTwo.Text = " Mexico City "
                        radThree.Text = " Manila "
                        radFour.Text = " Lima "
                        correctRad = 2

                    Case 15
                        lblQuestion.Text = "What is the capital of" & country.peru & "?"
                        radOne.Text = " Sydney "
                        radTwo.Text = " Riyadh "
                        radThree.Text = " Lima"
                        radFour.Text = " London "
                        correctRad = 3

                    Case 16
                        lblQuestion.Text = "What is the capital of" & country.phil & "?"
                        radOne.Text = " Accra "
                        radTwo.Text = " Ankara"
                        radThree.Text = " Manila "
                        radFour.Text = " Canberra "
                        correctRad = 3

                    Case 17
                        lblQuestion.Text = "What is the capital of" & country.russia & "?"
                        radOne.Text = " Moscow "
                        radTwo.Text = " Berlin "
                        radThree.Text = " Cairo "
                        radFour.Text = " Pretoria "
                        correctRad = 1

                    Case 18
                        lblQuestion.Text = "What is the capital of" & country.saudi & "?"
                        radOne.Text = " Russia "
                        radTwo.Text = " Riyadh "
                        radThree.Text = " Berlin "
                        radFour.Text = " Cairo "
                        correctRad = 2

                    Case 19
                        lblQuestion.Text = "What is the capital of" & country.sAfrica & "?"
                        radOne.Text = " Berlin"
                        radTwo.Text = " Manila"
                        radThree.Text = " Tokyo"
                        radFour.Text = " Pretoria "
                        correctRad = 4

                    Case 20
                        lblQuestion.Text = "What is the capital of" & country.sKorea & "?"
                        radOne.Text = " Tokyo "
                        radTwo.Text = " Beijing "
                        radThree.Text = " Moscow "
                        radFour.Text = " Seoul "
                        correctRad = 4

                    Case 21
                        lblQuestion.Text = "What is the capital of" & country.turk & "?"
                        radOne.Text = " Ankara "
                        radTwo.Text = " Lima"
                        radThree.Text = " London "
                        radFour.Text = " Canberra "
                        correctRad = 1

                    Case 22
                        lblQuestion.Text = "What is the capital of" & country.usa & "?"
                        radOne.Text = " Toronto"
                        radTwo.Text = " Ottawa "
                        radThree.Text = " Washington"
                        radFour.Text = " Cape Town "
                        correctRad = 3

                End Select


            End If
        Next
    End Sub

    Private Sub frmLevel1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On load, set the lable values to prompt user
        lblQuestion.Text = "Select the correct capital city for the country. Press Guess! to begin"
        lblCounter.Text = "0"
    End Sub
End Class