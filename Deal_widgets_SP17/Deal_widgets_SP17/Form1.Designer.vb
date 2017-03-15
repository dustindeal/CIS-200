<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblInputInstructions = New System.Windows.Forms.Label()
        Me.lblWidgetCount = New System.Windows.Forms.Label()
        Me.lblCostOfWidgets = New System.Windows.Forms.Label()
        Me.lblTaxRate = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtInputWeight = New System.Windows.Forms.TextBox()
        Me.lblWidgetOutput = New System.Windows.Forms.Label()
        Me.lblCostOutput = New System.Windows.Forms.Label()
        Me.lblTaxOutput = New System.Windows.Forms.Label()
        Me.lblTotalCostOutput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInputInstructions
        '
        Me.lblInputInstructions.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputInstructions.Location = New System.Drawing.Point(32, 42)
        Me.lblInputInstructions.Name = "lblInputInstructions"
        Me.lblInputInstructions.Size = New System.Drawing.Size(280, 41)
        Me.lblInputInstructions.TabIndex = 5
        Me.lblInputInstructions.Text = "Enter the weight of the pallet (in pounds)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "loaded with widgets"
        '
        'lblWidgetCount
        '
        Me.lblWidgetCount.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidgetCount.Location = New System.Drawing.Point(129, 159)
        Me.lblWidgetCount.Name = "lblWidgetCount"
        Me.lblWidgetCount.Size = New System.Drawing.Size(183, 23)
        Me.lblWidgetCount.TabIndex = 5
        Me.lblWidgetCount.Text = "# of Widgets on the pallet:"
        '
        'lblCostOfWidgets
        '
        Me.lblCostOfWidgets.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfWidgets.Location = New System.Drawing.Point(61, 210)
        Me.lblCostOfWidgets.Name = "lblCostOfWidgets"
        Me.lblCostOfWidgets.Size = New System.Drawing.Size(251, 23)
        Me.lblCostOfWidgets.TabIndex = 5
        Me.lblCostOfWidgets.Text = "Cost of the Widgets @ $10.50 each:"
        '
        'lblTaxRate
        '
        Me.lblTaxRate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxRate.Location = New System.Drawing.Point(251, 265)
        Me.lblTaxRate.Name = "lblTaxRate"
        Me.lblTaxRate.Size = New System.Drawing.Size(61, 23)
        Me.lblTaxRate.TabIndex = 3
        Me.lblTaxRate.Text = "8% Tax"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(105, 320)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(207, 23)
        Me.lblTotalCost.TabIndex = 4
        Me.lblTotalCost.Text = "TOTAL COST OF THE LOAD:"
        '
        'txtInputWeight
        '
        Me.txtInputWeight.Location = New System.Drawing.Point(353, 42)
        Me.txtInputWeight.Name = "txtInputWeight"
        Me.txtInputWeight.Size = New System.Drawing.Size(144, 20)
        Me.txtInputWeight.TabIndex = 0
        '
        'lblWidgetOutput
        '
        Me.lblWidgetOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWidgetOutput.Location = New System.Drawing.Point(353, 159)
        Me.lblWidgetOutput.Name = "lblWidgetOutput"
        Me.lblWidgetOutput.Size = New System.Drawing.Size(144, 23)
        Me.lblWidgetOutput.TabIndex = 6
        '
        'lblCostOutput
        '
        Me.lblCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCostOutput.Location = New System.Drawing.Point(353, 212)
        Me.lblCostOutput.Name = "lblCostOutput"
        Me.lblCostOutput.Size = New System.Drawing.Size(144, 23)
        Me.lblCostOutput.TabIndex = 7
        '
        'lblTaxOutput
        '
        Me.lblTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTaxOutput.Location = New System.Drawing.Point(353, 267)
        Me.lblTaxOutput.Name = "lblTaxOutput"
        Me.lblTaxOutput.Size = New System.Drawing.Size(144, 23)
        Me.lblTaxOutput.TabIndex = 8
        '
        'lblTotalCostOutput
        '
        Me.lblTotalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCostOutput.Location = New System.Drawing.Point(353, 320)
        Me.lblTotalCostOutput.Name = "lblTotalCostOutput"
        Me.lblTotalCostOutput.Size = New System.Drawing.Size(144, 23)
        Me.lblTotalCostOutput.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(353, 83)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(144, 47)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(380, 401)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmDeal
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(530, 456)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCostOutput)
        Me.Controls.Add(Me.lblTaxOutput)
        Me.Controls.Add(Me.lblCostOutput)
        Me.Controls.Add(Me.lblWidgetOutput)
        Me.Controls.Add(Me.txtInputWeight)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTaxRate)
        Me.Controls.Add(Me.lblCostOfWidgets)
        Me.Controls.Add(Me.lblWidgetCount)
        Me.Controls.Add(Me.lblInputInstructions)
        Me.Name = "frmDeal"
        Me.Text = "Deal - Widget Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInputInstructions As Label
    Friend WithEvents lblWidgetCount As Label
    Friend WithEvents lblCostOfWidgets As Label
    Friend WithEvents lblTaxRate As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtInputWeight As TextBox
    Friend WithEvents lblWidgetOutput As Label
    Friend WithEvents lblCostOutput As Label
    Friend WithEvents lblTaxOutput As Label
    Friend WithEvents lblTotalCostOutput As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
