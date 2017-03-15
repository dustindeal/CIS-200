<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(274, 169)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(68, 44)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(133, 169)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(101, 44)
        Me.btnCompare.TabIndex = 21
        Me.btnCompare.Text = "COMPARE"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(56, 106)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(261, 48)
        Me.lblOutput.TabIndex = 20
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Enter Two Numbers"
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(218, 52)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 29)
        Me.txtB.TabIndex = 18
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "B:"
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(59, 52)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 29)
        Me.txtA.TabIndex = 16
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "A:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 243)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Practice Exercise - IsNumeric & Nested Ifs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnCompare As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents Label1 As Label
End Class
