Option Strict On
Public Class frmDeal
    Private Sub frmDeal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblGasOne As Double           'Declaring the variables for Vehicle one'
        Dim dblMilesOne As Double

        Dim dblGasTwo As Double           'Declaring the variables for Vehicle two'
        Dim dblMilesTwo As Double

        Dim dblMpgOne As Double           'Declaring the variables for MPG
        Dim dblMpgTwo As Double

        dblGasOne = CDbl(txtGas1.Text)     'Converting the text strings into numbers
        dblGasTwo = CDbl(txtGas2.Text)
        dblMilesOne = CDbl(txtMiles1.Text)
        dblMilesTwo = CDbl(txtMiles2.Text)

        dblMpgOne = dblMilesOne / dblGasOne     'Calculating the MPG
        dblMpgTwo = dblMilesTwo / dblGasTwo

        lblMpgOne.Text = dblMpgOne.ToString("N0")  'Outputting the MPG with no decimal places
        lblMpgTwo.Text = dblMpgTwo.ToString("N0")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGas1.Text = String.Empty                 'Clearing all the text forms and focusing on textbox for Gas 1
        txtMiles1.Text = String.Empty
        txtGas2.Text = String.Empty
        txtMiles2.Text = String.Empty
        lblMpgOne.Text = String.Empty
        lblMpgTwo.Text = String.Empty

        txtGas1.Focus()
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()                                   'closing the program
    End Sub

End Class
