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
        Me.lblGallonsOne = New System.Windows.Forms.Label()
        Me.lblGallonsTwo = New System.Windows.Forms.Label()
        Me.lblMilesOne = New System.Windows.Forms.Label()
        Me.lblMilesTwo = New System.Windows.Forms.Label()
        Me.lblMpg1 = New System.Windows.Forms.Label()
        Me.lblMpg2 = New System.Windows.Forms.Label()
        Me.txtGas1 = New System.Windows.Forms.TextBox()
        Me.txtGas2 = New System.Windows.Forms.TextBox()
        Me.txtMiles2 = New System.Windows.Forms.TextBox()
        Me.txtMiles1 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMpgOne = New System.Windows.Forms.Label()
        Me.lblMpgTwo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGallonsOne
        '
        Me.lblGallonsOne.Location = New System.Drawing.Point(30, 38)
        Me.lblGallonsOne.Name = "lblGallonsOne"
        Me.lblGallonsOne.Size = New System.Drawing.Size(99, 33)
        Me.lblGallonsOne.TabIndex = 15
        Me.lblGallonsOne.Text = "Gallons of gas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CAR 1 can hold:"
        '
        'lblGallonsTwo
        '
        Me.lblGallonsTwo.Location = New System.Drawing.Point(30, 151)
        Me.lblGallonsTwo.Name = "lblGallonsTwo"
        Me.lblGallonsTwo.Size = New System.Drawing.Size(99, 36)
        Me.lblGallonsTwo.TabIndex = 15
        Me.lblGallonsTwo.Text = "Gallons of gas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CAR 2 can hold:"
        '
        'lblMilesOne
        '
        Me.lblMilesOne.Location = New System.Drawing.Point(292, 38)
        Me.lblMilesOne.Name = "lblMilesOne"
        Me.lblMilesOne.Size = New System.Drawing.Size(149, 33)
        Me.lblMilesOne.TabIndex = 15
        Me.lblMilesOne.Text = "Number of miles CAR 1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "can be driven on a full tank:"
        '
        'lblMilesTwo
        '
        Me.lblMilesTwo.Location = New System.Drawing.Point(292, 151)
        Me.lblMilesTwo.Name = "lblMilesTwo"
        Me.lblMilesTwo.Size = New System.Drawing.Size(146, 36)
        Me.lblMilesTwo.TabIndex = 15
        Me.lblMilesTwo.Text = "Number of miles CAR 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "can be driven on a full tank:"
        '
        'lblMpg1
        '
        Me.lblMpg1.Location = New System.Drawing.Point(562, 38)
        Me.lblMpg1.Name = "lblMpg1"
        Me.lblMpg1.Size = New System.Drawing.Size(138, 23)
        Me.lblMpg1.TabIndex = 15
        Me.lblMpg1.Text = "Miles per gallon for CAR 1:"
        '
        'lblMpg2
        '
        Me.lblMpg2.Location = New System.Drawing.Point(562, 151)
        Me.lblMpg2.Name = "lblMpg2"
        Me.lblMpg2.Size = New System.Drawing.Size(145, 21)
        Me.lblMpg2.TabIndex = 15
        Me.lblMpg2.Text = "Miles per gallon for CAR 2:"
        '
        'txtGas1
        '
        Me.txtGas1.Location = New System.Drawing.Point(136, 40)
        Me.txtGas1.Name = "txtGas1"
        Me.txtGas1.Size = New System.Drawing.Size(100, 20)
        Me.txtGas1.TabIndex = 0
        '
        'txtGas2
        '
        Me.txtGas2.Location = New System.Drawing.Point(136, 152)
        Me.txtGas2.Name = "txtGas2"
        Me.txtGas2.Size = New System.Drawing.Size(100, 20)
        Me.txtGas2.TabIndex = 3
        '
        'txtMiles2
        '
        Me.txtMiles2.Location = New System.Drawing.Point(444, 152)
        Me.txtMiles2.Name = "txtMiles2"
        Me.txtMiles2.Size = New System.Drawing.Size(100, 20)
        Me.txtMiles2.TabIndex = 4
        '
        'txtMiles1
        '
        Me.txtMiles1.Location = New System.Drawing.Point(444, 40)
        Me.txtMiles1.Name = "txtMiles1"
        Me.txtMiles1.Size = New System.Drawing.Size(100, 20)
        Me.txtMiles1.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(254, 232)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(96, 57)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MPG"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(356, 232)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 57)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(458, 232)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 57)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "EXIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMpgOne
        '
        Me.lblMpgOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMpgOne.Location = New System.Drawing.Point(706, 37)
        Me.lblMpgOne.Name = "lblMpgOne"
        Me.lblMpgOne.Size = New System.Drawing.Size(106, 23)
        Me.lblMpgOne.TabIndex = 16
        Me.lblMpgOne.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblMpgTwo
        '
        Me.lblMpgTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMpgTwo.Location = New System.Drawing.Point(706, 149)
        Me.lblMpgTwo.Name = "lblMpgTwo"
        Me.lblMpgTwo.Size = New System.Drawing.Size(106, 23)
        Me.lblMpgTwo.TabIndex = 17
        Me.lblMpgTwo.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmDeal
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(827, 328)
        Me.Controls.Add(Me.lblMpgTwo)
        Me.Controls.Add(Me.lblMpgOne)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtMiles1)
        Me.Controls.Add(Me.txtMiles2)
        Me.Controls.Add(Me.txtGas2)
        Me.Controls.Add(Me.txtGas1)
        Me.Controls.Add(Me.lblMpg2)
        Me.Controls.Add(Me.lblMpg1)
        Me.Controls.Add(Me.lblMilesTwo)
        Me.Controls.Add(Me.lblMilesOne)
        Me.Controls.Add(Me.lblGallonsTwo)
        Me.Controls.Add(Me.lblGallonsOne)
        Me.Name = "frmDeal"
        Me.Text = "Deal - MPG Comparison Calculator SP17"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGallonsOne As Label
    Friend WithEvents lblGallonsTwo As Label
    Friend WithEvents lblMilesOne As Label
    Friend WithEvents lblMilesTwo As Label
    Friend WithEvents lblMpg1 As Label
    Friend WithEvents lblMpg2 As Label
    Friend WithEvents txtGas1 As TextBox
    Friend WithEvents txtGas2 As TextBox
    Friend WithEvents txtMiles2 As TextBox
    Friend WithEvents txtMiles1 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMpgOne As Label
    Friend WithEvents lblMpgTwo As Label
End Class
