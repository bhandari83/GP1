<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnnualIncome
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
        Me.lstAnnualIncome = New System.Windows.Forms.ListBox()
        Me.lstAnnualLabels = New System.Windows.Forms.ListBox()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstAnnualIncome
        '
        Me.lstAnnualIncome.FormattingEnabled = True
        Me.lstAnnualIncome.Location = New System.Drawing.Point(22, 59)
        Me.lstAnnualIncome.MultiColumn = True
        Me.lstAnnualIncome.Name = "lstAnnualIncome"
        Me.lstAnnualIncome.Size = New System.Drawing.Size(175, 121)
        Me.lstAnnualIncome.TabIndex = 0
        '
        'lstAnnualLabels
        '
        Me.lstAnnualLabels.FormattingEnabled = True
        Me.lstAnnualLabels.Location = New System.Drawing.Point(22, 36)
        Me.lstAnnualLabels.MultiColumn = True
        Me.lstAnnualLabels.Name = "lstAnnualLabels"
        Me.lstAnnualLabels.Size = New System.Drawing.Size(175, 17)
        Me.lstAnnualLabels.TabIndex = 1
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(22, 187)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(175, 32)
        Me.btnOkay.TabIndex = 2
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Annual Income"
        '
        'frmAnnualIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 231)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lstAnnualLabels)
        Me.Controls.Add(Me.lstAnnualIncome)
        Me.Name = "frmAnnualIncome"
        Me.Text = "frmAnnualIncome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAnnualIncome As System.Windows.Forms.ListBox
    Friend WithEvents lstAnnualLabels As System.Windows.Forms.ListBox
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
