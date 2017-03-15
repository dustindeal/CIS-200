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
        Me.grpExercises = New System.Windows.Forms.GroupBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnRunning = New System.Windows.Forms.RadioButton()
        Me.btnSwimming = New System.Windows.Forms.RadioButton()
        Me.btnSleeping = New System.Windows.Forms.RadioButton()
        Me.grpExercises.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpExercises
        '
        Me.grpExercises.Controls.Add(Me.btnSleeping)
        Me.grpExercises.Controls.Add(Me.btnSwimming)
        Me.grpExercises.Controls.Add(Me.btnRunning)
        Me.grpExercises.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpExercises.Location = New System.Drawing.Point(30, 38)
        Me.grpExercises.Name = "grpExercises"
        Me.grpExercises.Size = New System.Drawing.Size(370, 178)
        Me.grpExercises.TabIndex = 10
        Me.grpExercises.TabStop = False
        Me.grpExercises.Text = "Select an ""Exercise"""
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Items.AddRange(New Object() {" "})
        Me.lstOutput.Location = New System.Drawing.Point(30, 256)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(370, 95)
        Me.lstOutput.TabIndex = 10
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(30, 222)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(370, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate Calories Burned" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnRunning
        '
        Me.btnRunning.AutoSize = True
        Me.btnRunning.Checked = True
        Me.btnRunning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunning.Location = New System.Drawing.Point(21, 46)
        Me.btnRunning.Name = "btnRunning"
        Me.btnRunning.Size = New System.Drawing.Size(333, 20)
        Me.btnRunning.TabIndex = 0
        Me.btnRunning.TabStop = True
        Me.btnRunning.Text = "Running on a treadmill burns 3.9 calories per minute."
        Me.btnRunning.UseVisualStyleBackColor = True
        '
        'btnSwimming
        '
        Me.btnSwimming.AutoSize = True
        Me.btnSwimming.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSwimming.Location = New System.Drawing.Point(19, 79)
        Me.btnSwimming.Name = "btnSwimming"
        Me.btnSwimming.Size = New System.Drawing.Size(252, 20)
        Me.btnSwimming.TabIndex = 1
        Me.btnSwimming.TabStop = True
        Me.btnSwimming.Text = "Swimming burns 6 calories per minute."
        Me.btnSwimming.UseVisualStyleBackColor = True
        '
        'btnSleeping
        '
        Me.btnSleeping.AutoSize = True
        Me.btnSleeping.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSleeping.Location = New System.Drawing.Point(19, 115)
        Me.btnSleeping.Name = "btnSleeping"
        Me.btnSleeping.Size = New System.Drawing.Size(255, 20)
        Me.btnSleeping.TabIndex = 2
        Me.btnSleeping.Text = "Sleeping burns 0.5 calories per minute."
        Me.btnSleeping.UseVisualStyleBackColor = True
        '
        'frmDeal
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 378)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.grpExercises)
        Me.Name = "frmDeal"
        Me.Text = "Deal - Calories Burned"
        Me.grpExercises.ResumeLayout(False)
        Me.grpExercises.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpExercises As GroupBox
    Friend WithEvents btnSleeping As RadioButton
    Friend WithEvents btnSwimming As RadioButton
    Friend WithEvents btnRunning As RadioButton
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnCalculate As Button
End Class
