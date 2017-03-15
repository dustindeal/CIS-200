Option Strict On
Public Class frmDeal
    Private Sub btnHowManyDays_Click(sender As Object, e As EventArgs) Handles btnHowManyDays.Click


        'Declaring a variable to store the month, then checking to see if the input is valid and within domain' 
        Dim intMonth As Integer
        If Integer.TryParse(txtMonth.Text, intMonth) AndAlso intMonth >= 1 And intMonth <= 12 Then

            'Declaring a variable to store the year, then checking to see if the input is valid and within domain'
            Dim intYear As Integer
            If Integer.TryParse(txtYear.Text, intYear) AndAlso intYear >= 1582 Then
                'The user listened for once, so it's time to figure out how many days are in their month :) 

                Dim blnLeapYear As Boolean 'Declaring the variable here so it's accessible outside of Case 2 
                Dim strMonth As String = String.Empty
                Dim intDays As Integer

                Select Case intMonth        'Converting their numeric input to month/day 
                    Case 1
                        strMonth = "January"
                        intDays = 31
                    Case 2
                        strMonth = "February"

                        If intYear Mod 4 = 0 Then
                            blnLeapYear = True
                            If intYear Mod 100 = 0 AndAlso intYear Mod 400 <> 0 Then
                                blnLeapYear = False
                            End If
                        Else
                            blnLeapYear = False
                        End If 'If the year is divisble by 4 

                        If blnLeapYear Then
                            intDays = 29
                        Else
                            intDays = 28
                        End If

                    Case 3
                        strMonth = "March"
                        intDays = 31
                    Case 4
                        strMonth = "April"
                        intDays = 30
                    Case 5
                        strMonth = "May"
                        intDays = 31
                    Case 6
                        strMonth = "June"
                        intDays = 30
                    Case 7
                        strMonth = "July"
                        intDays = 31
                    Case 8
                        strMonth = "August"
                        intDays = 31
                    Case 9
                        strMonth = "September" 'Best month of the year, I might have been born in it' 
                        intDays = 30
                    Case 10
                        strMonth = "October"
                        intDays = 31
                    Case 11
                        strMonth = "November"
                        intDays = 30
                    Case 12
                        strMonth = "December"
                        intDays = 31
                End Select

                If intYear < Today.Year Then

                    If blnLeapYear Then
                        MessageBox.Show(strMonth & ", " & intYear.ToString() & " was a leap year with " & intDays.ToString() & " days.")
                    Else
                        MessageBox.Show(strMonth & ", " & intYear.ToString() & " had " & intDays.ToString() & " days.")
                    End If
                Else
                    If blnLeapYear Then
                        MessageBox.Show(strMonth & ", " & intYear.ToString() & " will be a leap year with " & intDays.ToString() & " days.")
                    Else
                        MessageBox.Show(strMonth & ", " & intYear.ToString() & " has " & intDays.ToString() & " days.")
                    End If
                End If

            Else
                MessageBox.Show("Please enter a year 1582 or later.", "Error")
                txtYear.SelectAll()
                txtYear.Focus()
            End If 'If the year is a number >= 1582 

        Else
            MessageBox.Show("Please enter a number 1 to 12", "Error")
            txtMonth.SelectAll()
            txtMonth.Focus()
        End If 'If the month is a number between 1 to 12 


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMonth.Text = String.Empty
        txtYear.Text = String.Empty
        txtMonth.Focus()

    End Sub
End Class
