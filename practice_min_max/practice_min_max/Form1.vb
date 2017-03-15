Option Strict On
Option Explicit On

Public Class Form1



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtA.Clear()
        txtB.Clear()
        lblOutput.Text = String.Empty
        txtA.Focus()
    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click


        Dim dblNumberA As Double
        Dim dblNumberB As Double

        If IsNumeric(txtA.Text) Then
            dblNumberA = CDbl(txtA.Text)

            If IsNumeric(txtB.Text) Then
                dblNumberB = CDbl(txtB.Text)

                If dblNumberA > dblNumberB Then
                    lblOutput.Text = dblNumberA.ToString & " is greater than " & dblNumberB.ToString

                ElseIf dblNumberA = dblNumberB Then
                    lblOutput.Text = dblNumberA.ToString & " is equal to " & dblNumberB.ToString

                Else lblOutput.Text = dblNumberB.ToString & " is greater than " & dblNumberA.ToString
                End If
            Else
                MessageBox.Show("Please Enter a Valid Number")
                txtB.SelectAll()
                txtB.Focus()

            End If

        Else
            MessageBox.Show("Please Enter a Valid Number")
            txtA.SelectAll()
            txtA.Focus()

        End If

    End Sub
End Class

