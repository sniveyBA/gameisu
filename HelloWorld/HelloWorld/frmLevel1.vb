Public Class frmLevel1

    Dim intNumber As Integer
    Dim usedNumber(0 To 23) As Integer
    Dim arrCount As Integer
    Dim arrNumber(0 To 23) As Integer
    Dim qNumber As Integer
    Dim counter As Integer

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click


        Randomize()
Start:
        Dim y As Integer

        intNumber = Int((21 * Rnd()) + 1)
        For y = 0 To 22 Step 1
            If intNumber = usedNumber(y) Then
                GoTo start
            End If
            If y = 22 Then
                usedNumber(arrCount) = intNumber
                arrCount += 1
                qNumber = intNumber

                lblCounter.Text = counter

                Select Case qNumber
                    Case 1
                        lblQuestion.Text = "What is the capital of" & country.austr & "?"
                        radOne.Text = " Sydney "
                        radTwo.Text = " Ottawa "
                        radThree.Text = " London "
                        radFour.Text = " Canberra "
                        If radFour.Checked = True Then
                            counter += 1
                            radFour.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 2
                        lblQuestion.Text = "What is the capital of" & country.brazil & "?"
                        radOne.Text = " Cairo"
                        radTwo.Text = " Manila"
                        radThree.Text = " Brasilia"
                        radFour.Text = " London"
                        If radThree.Checked = True Then
                            counter += 1
                            radThree.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If

                    Case 3
                        lblQuestion.Text = "What is the capital of" & country.canada & "?"
                        radOne.Text = " Moscow "
                        radTwo.Text = " Ottawa "
                        radThree.Text = " Washington "
                        radFour.Text = " New Delhi "
                        If radTwo.Checked = True Then
                            counter += 1
                            radTwo.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 4
                        lblQuestion.Text = "What is the capital of" & country.china & "?"
                        radOne.Text = " Berlin "
                        radTwo.Text = " Beijing "
                        radThree.Text = " Ankara "
                        radFour.Text = " Canberra "
                        If radTwo.Checked = True Then
                            counter += 1
                            radTwo.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 5
                        lblQuestion.Text = "What is the capital of" & country.egypt & "?"
                        radOne.Text = " Rome "
                        radTwo.Text = " Cairo "
                        radThree.Text = " Manila "
                        radFour.Text = " Seoul "
                        If radTwo.Checked = True Then
                            counter += 1
                            radTwo.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 6
                        lblQuestion.Text = "What is the capital of" & country.england & "?"
                        radOne.Text = " Tokyo "
                        radTwo.Text = " Cape Town "
                        radThree.Text = " Lima "
                        radFour.Text = " London "
                        If radFour.Checked = True Then
                            counter += 1
                            radFour.Checked = False
                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 7
                        lblQuestion.Text = "What is the capital of" & country.ethiopia & "?"
                        radOne.Text = " Manila "
                        radTwo.Text = " Ankara "
                        radThree.Text = " Addis Ababa "
                        radFour.Text = " Riyadh "
                        If radThree.Checked = True Then
                            counter += 1
                            radThree.Checked = False
                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        End If
                    Case 8
                        lblQuestion.Text = "What is the capital of" & country.france & "?"
                        radOne.Text = " Cairo "
                        radTwo.Text = " Paris "
                        radThree.Text = " London "
                        radFour.Text = " Pretoria "
                        If radTwo.Checked = True Then
                            counter += 1
                            radTwo.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 9
                        lblQuestion.Text = "What is the capital of" & country.germany & "?"
                        radOne.Text = " Berlin "
                        radTwo.Text = " Brasilia "
                        radThree.Text = " Riyadh "
                        radFour.Text = " Accra "
                        If radOne.Checked = True Then
                            counter += 1
                            radOne.Checked = False

                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 10
                        lblQuestion.Text = "What is the capital of" & country.ghana & "?"
                        radOne.Text = " Riyadh "
                        radTwo.Text = " Bloemfontein "
                        radThree.Text = " Accra "
                        radFour.Text = " Addis Ababa "
                        If radThree.Checked = True Then
                            counter += 1
                            radThree.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        End If
                    Case 11
                        lblQuestion.Text = "What is the capital of" & country.india & "?"
                        radOne.Text = " Riyadh "
                        radTwo.Text = " New Delhi "
                        radThree.Text = " Canberra "
                        radFour.Text = " Moscow "
                        If radTwo.Checked = True Then
                            counter += 1
                            radTwo.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        End If
                    Case 12
                        lblQuestion.Text = "What is the capital of" & country.italy & "?"
                        radOne.Text = " Ankara "
                        radTwo.Text = " Ottawa "
                        radThree.Text = " Rome "
                        radFour.Text = " Berlin "
                        If radThree.Checked = True Then
                            counter += 1
                            radThree.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        End If
                    Case 13
                        lblQuestion.Text = "What is the capital of" & country.japan & "?"
                        radOne.Text = " Manila "
                        radTwo.Text = " Beijing "
                        radThree.Text = " Tokyo "
                        radFour.Text = " Seoul "
                        If radThree.Checked = True Then
                            counter += 1
                            radThree.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        End If
                    Case 14
                        lblQuestion.Text = "What is the capital of" & country.mexico & "?"
                        radOne.Text = " Tokyo "
                        radTwo.Text = " Mexico City "
                        radThree.Text = " Manila "
                        radFour.Text = " Lima "
                        If radTwo.Checked = True Then
                            counter += 1
                            radTwo.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 15
                        lblQuestion.Text = "What is the capital of" & country.peru & "?"
                        radOne.Text = " Sydney "
                        radTwo.Text = " Riyadh "
                        radThree.Text = " Lima"
                        radFour.Text = " London "
                        If radThree.Checked = True Then
                            counter += 1
                            radThree.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        End If
                    Case 16
                        lblQuestion.Text = "What is the capital of" & country.phil & "?"
                        radOne.Text = " Accra "
                        radTwo.Text = " Ankara"
                        radThree.Text = " Manila "
                        radFour.Text = " Canberra "
                        If radThree.Checked = True Then
                            counter += 1
                            radThree.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        End If
                    Case 17
                        lblQuestion.Text = "What is the capital of" & country.russia & "?"
                        radOne.Text = " Moscow "
                        radTwo.Text = " Berlin "
                        radThree.Text = " Cairo "
                        radFour.Text = " Pretoria "
                        If radOne.Checked = True Then
                            counter += 1
                            radOne.Checked = False

                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 18
                        lblQuestion.Text = "What is the capital of" & country.saudi & "?"
                        radOne.Text = " Russia "
                        radTwo.Text = " Riyadh "
                        radThree.Text = " Berlin "
                        radFour.Text = " Cairo "
                        If radTwo.Checked = True Then
                            counter += 1
                            radTwo.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 19
                        lblQuestion.Text = "What is the capital of" & country.sAfrica & "?"
                        radOne.Text = " Berlin"
                        radTwo.Text = " Manila"
                        radThree.Text = " Tokyo"
                        radFour.Text = " Pretoria "
                        If radFour.Checked = True Then
                            counter += 1
                            radFour.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 20
                        lblQuestion.Text = "What is the capital of" & country.sKorea & "?"
                        radOne.Text = " Tokyo "
                        radTwo.Text = " Beijing "
                        radThree.Text = " Moscow "
                        radFour.Text = " Seoul "
                        If radFour.Checked = True Then
                            counter += 1
                            radFour.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 21
                        lblQuestion.Text = "What is the capital of" & country.turk & "?"
                        radOne.Text = " Ankara "
                        radTwo.Text = " Lima"
                        radThree.Text = " London "
                        radFour.Text = " Canberra "
                        If radOne.Checked = True Then
                            counter += 1
                            radOne.Checked = False

                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radThree.Checked = True Then
                            radThree.Checked = False
                            GoTo Start
                        End If
                    Case 22
                        lblQuestion.Text = "What is the capital of" & country.usa & "?"
                        radOne.Text = " Toronto"
                        radTwo.Text = " Ottawa "
                        radThree.Text = " Washington"
                        radFour.Text = " Cape Town "
                        If radThree.Checked = True Then
                            counter += 1
                            radThree.Checked = False

                            GoTo Start
                        ElseIf radOne.Checked = True Then
                            radOne.Checked = False
                            GoTo Start
                        ElseIf radTwo.Checked = True Then
                            radTwo.Checked = False
                            GoTo Start
                        ElseIf radFour.Checked = True Then
                            radFour.Checked = False
                            GoTo Start
                        End If
                End Select

            End If
        Next
    End Sub
End Class