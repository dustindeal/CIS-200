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
        Me.txtAgeInput = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAgeInput
        '
        Me.txtAgeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAgeInput.Location = New System.Drawing.Point(484, 138)
        Me.txtAgeInput.Name = "txtAgeInput"
        Me.txtAgeInput.Size = New System.Drawing.Size(100, 31)
        Me.txtAgeInput.TabIndex = 0
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(82, 70)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(277, 99)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Enter the age " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- in YEARS -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the movie-goer: "
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(382, 219)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(202, 77)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Determine Ticket Price"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(88, 219)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(186, 77)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&CLEAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(88, 336)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(496, 221)
        Me.lblOutput.TabIndex = 4
        '
        'frmDeal
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 642)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.txtAgeInput)
        Me.Name = "frmDeal"
        Me.Text = "Deal - Movie Ticket Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAgeInput As TextBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblOutput As Label
End Class
