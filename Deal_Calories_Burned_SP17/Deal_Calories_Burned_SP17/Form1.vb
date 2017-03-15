Option Strict On
Public Class frmDeal
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblCalories As Double   'Calories burned in selected exercise
        Dim dblCal As Double        'Unit calories per minute 
        Dim strOutput As String     'Output string 

        Select Case True    'Selecting an exercise

            Case btnRunning.Checked     'User checked running
                lstOutput.Items.Clear()
                For dblCalories = 15.0 To 90.0 Step 15.0
                    dblCal = dblCalories * 3.9
                    strOutput = "Running on a treadmill burns " & dblCal.ToString & " calories in " & dblCalories.ToString & " minutes."
                    lstOutput.Items.Add(strOutput)
                Next
            Case btnSwimming.Checked    'User checked swimming
                lstOutput.Items.Clear()
                For dblCalories = 15.0 To 90.0 Step 15.0
                    dblCal = dblCalories * 6.0
                    strOutput = "Swimming burns " & dblCal.ToString & " calories in " & dblCalories.ToString & " minutes."
                    lstOutput.Items.Add(strOutput)
                Next
            Case btnSleeping.Checked    'User checked sleeping
                lstOutput.Items.Clear()
                For dblCalories = 15.0 To 90.0 Step 15.0
                    dblCal = dblCalories * 0.5
                    strOutput = "Sleeping burns " & dblCal.ToString & " calories in " & dblCalories.ToString & " minutes."
                    lstOutput.Items.Add(strOutput)
                Next
        End Select 'End of Select Case selecting an exercise 
    End Sub
End Class
