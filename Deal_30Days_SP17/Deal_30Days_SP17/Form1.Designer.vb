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
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnHowManyDays = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(276, 83)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtMonth.TabIndex = 0
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(276, 163)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 1
        '
        'btnHowManyDays
        '
        Me.btnHowManyDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHowManyDays.Location = New System.Drawing.Point(255, 204)
        Me.btnHowManyDays.Name = "btnHowManyDays"
        Me.btnHowManyDays.Size = New System.Drawing.Size(140, 23)
        Me.btnHowManyDays.TabIndex = 2
        Me.btnHowManyDays.Text = "How Many Days?"
        Me.btnHowManyDays.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(211, 248)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(223, 80)
        Me.lblOutput.TabIndex = 3
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(30, 40)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(204, 128)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "30 days has September," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "April, June and November" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All the rest have 31" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "February " &
    "has 28 alone" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "But in every leap year " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "That come once in four " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "February has jus" &
    "t 1 day more!"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(76, 305)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(252, 40)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(164, 26)
        Me.lblMonth.TabIndex = 6
        Me.lblMonth.Text = "Enter the Number of the Month" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(i.e. January = 1, December = 12)"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(252, 133)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(141, 13)
        Me.lblYear.TabIndex = 7
        Me.lblYear.Text = "Enter the Year 1582 or Later"
        '
        'frmDeal
        '
        Me.AcceptButton = Me.btnHowManyDays
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 350)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnHowManyDays)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtMonth)
        Me.Name = "frmDeal"
        Me.Text = "Deal - 30 Days Poem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnHowManyDays As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
End Class
