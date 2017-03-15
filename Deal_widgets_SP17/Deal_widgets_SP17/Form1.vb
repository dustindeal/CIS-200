Option Strict On
Public Class frmDeal
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declaring all variables'

        Dim intInputWeight As Integer
        Dim intTotalWidgetWeight As Integer
        Dim dblTotalWidgetCost As Double
        Dim dblTaxRate As Double
        Dim intPalletWeight As Integer
        Dim dblWidgetWeight As Double
        Dim intWidgetCount As Integer
        Dim dblWidgetCost As Double
        Dim dblTotalTax As Double
        Dim dblTotalCost As Double

        'Assigining independent variables: tax rate, widget weight, widget cost, and pallet weight'

        dblTaxRate = 0.08
        dblWidgetWeight = 8.75
        dblWidgetCost = 10.5
        intPalletWeight = 100

        If IsNumeric(txtInputWeight.Text) Then
            intInputWeight = CInt(txtInputWeight.Text)

            'Subtracting the weight of the pallet from the total weight input to figure out the total number of widgets'
            intTotalWidgetWeight = (intInputWeight - intPalletWeight)
            intWidgetCount = CInt(Int(intTotalWidgetWeight / dblWidgetWeight))

            'Calculating the total widget cost' 
            dblTotalWidgetCost = intWidgetCount * dblWidgetCost

            'Calculating the total tax'
            dblTotalTax = dblTotalWidgetCost * dblTaxRate

            'Calculating the total cost with tax included'
            dblTotalCost = dblTotalTax + dblTotalWidgetCost

            'Outputting the data to the user'
            lblWidgetOutput.Text = intWidgetCount.ToString
            lblCostOutput.Text = dblTotalWidgetCost.ToString("c")
            lblTaxOutput.Text = dblTotalTax.ToString("c")
            lblTotalCostOutput.Text = dblTotalCost.ToString("c")

        Else
            MessageBox.Show("Please Enter a valid Number (A positive whole number")
            txtInputWeight.SelectAll()
            txtInputWeight.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing all the outputs and the original input so the user can start over again with new data' 
        txtInputWeight.Text = String.Empty
        lblWidgetOutput.Text = String.Empty
        lblCostOutput.Text = String.Empty
        lblTaxOutput.Text = String.Empty
        lblTotalCostOutput.Text = String.Empty

        'Setting the focus back onto the original input field' 
        txtInputWeight.Focus()
    End Sub
End Class
