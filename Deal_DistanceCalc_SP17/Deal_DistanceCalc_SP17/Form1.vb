Public Class frmDeal

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declaring Variables' 

        Dim strZones As String = "{0,-4}     {1,-15} "
        Dim intHours As Integer
        Dim intSpeed As Integer
        Dim intHoursTraveled As Integer
        Dim strSpeed As String = String.Empty
        Dim strHours As String = String.Empty
        Dim blnSpeed As Boolean
        Dim blnCancel As Boolean
        Dim blnHours As Boolean

        lstOutput.Items.Clear()


        Do
            'Loop asking the user for input for the speed 

            strSpeed = InputBox("Please enter the SPEED (MPH) at which the vehicle is travelling", "Speed")
            If IsNumeric(strSpeed) Then     'Checking if the string is a number

                If CInt(strSpeed) > 0 Then      'Making sure the car is moving forward
                    blnSpeed = True             'Using a boolean to get out of the loop later on
                    intSpeed = CInt(strSpeed)   'Finally converting the string input into a variable 

                    Do
                        'Loop asking the user for input for the time in hours 

                        strHours = InputBox("Please enter the TIME in HOURS at which the vehicle has been travelling", "Time")
                        If IsNumeric(strHours) Then 'Making sure the string is a number

                            If CInt(strHours) > 0 Then      'Making sure we don't have time travellers 
                                blnHours = True             'Using a boolean to get out of the loop later on 
                                intHours = CInt(strHours)   'Converting the string input into a variable 


                                '--------------Adding Information to the list box----------------------------'

                                lstOutput.Items.Add("Vehicle Speed: " & intSpeed.ToString & " MPH")
                                lstOutput.Items.Add("Time Traveled: " & intHours.ToString & " Hours")

                                lstOutput.Items.Add(String.Format(strZones, "Hour", "Distance Traveled"))
                                lstOutput.Items.Add(String.Format(strZones, "----", "---------------"))

                                For intHoursTraveled = 1 To intHours

                                    lstOutput.Items.Add(String.Format(strZones, intHoursTraveled.ToString, (intSpeed * intHoursTraveled).ToString & " Miles"))

                                Next intHoursTraveled


                            Else
                                MessageBox.Show("Please enter a positive amount of time. This application does not work with time travel (yet)")
                            End If

                        ElseIf strHours = "X" Or strHours = "x" Then
                            blnCancel = True

                        ElseIf blnHours = False Then
                            MessageBox.Show("Please enter a valid TIME in HOURS, example: 4", "Error: Invalid Hours")
                        End If

                    Loop Until blnHours = True OrElse blnCancel = True


                Else
                    MessageBox.Show("Please enter a positive speed, or contact me with how you managed to go a negative speed.")
                End If     'Checking if the number is over positive

            ElseIf strSpeed = "X" Or strSpeed = "x" Then
                blnCancel = True
            ElseIf blnSpeed = False Then
                MessageBox.Show("Please enter a valid SPEED in MPH, example: 55 ", "Error: Invalid Speed")

            End If      ' Checking if the string is number 

        Loop Until blnSpeed = True OrElse blnCancel = True


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
