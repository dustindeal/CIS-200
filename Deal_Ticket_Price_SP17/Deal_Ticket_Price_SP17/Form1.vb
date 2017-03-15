Option Strict On

Public Class frmDeal
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim dblAge As Double                                    '' Declaring the variable to store Age 

        If IsNumeric(txtAgeInput.Text) Then                     '' Validating the input from the user before conversion 
            dblAge = CDbl(txtAgeInput.Text)
            If dblAge 0 < 2 Then                                                      ''Determining the price based on age 
                lblOutput.Text = "The movie ticket price for a baby is $0.00"
            ElseIf dblAge < 13 Then
                lblOutput.Text = "The movie ticket price for a child is $7.50"
            ElseIf dblAge < 65 Then
                lblOutput.Text = "The movie ticket price for an adult is $10.00"
            Else
                lblOutput.Text = "The movie ticket price for a senior is $5.00"
            End If

        Else                                                                        '' Error message if the input cannot be validated 
            MessageBox.Show("Please enter a valid age in years.")
            txtAgeInput.SelectAll()
            txtAgeInput.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click     ''Clearing the form for new input
        lblOutput.Text = String.Empty
        txtAgeInput.Text = String.Empty
        txtAgeInput.Focus()
    End Sub
End Class
