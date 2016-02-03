<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstSales = New System.Windows.Forms.ListBox()
        Me.btnSaveFile = New System.Windows.Forms.Button()
        Me.btnReadFromFile = New System.Windows.Forms.Button()
        Me.btnNotepad = New System.Windows.Forms.Button()
        Me.lstLabels = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstSales
        '
        Me.lstSales.ColumnWidth = 80
        Me.lstSales.FormattingEnabled = True
        Me.lstSales.Location = New System.Drawing.Point(90, 54)
        Me.lstSales.Margin = New System.Windows.Forms.Padding(2)
        Me.lstSales.MultiColumn = True
        Me.lstSales.Name = "lstSales"
        Me.lstSales.Size = New System.Drawing.Size(303, 251)
        Me.lstSales.TabIndex = 0
        '
        'btnSaveFile
        '
        Me.btnSaveFile.Location = New System.Drawing.Point(9, 12)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveFile.TabIndex = 3
        Me.btnSaveFile.Text = "Save"
        Me.btnSaveFile.UseVisualStyleBackColor = True
        '
        'btnReadFromFile
        '
        Me.btnReadFromFile.Location = New System.Drawing.Point(90, 12)
        Me.btnReadFromFile.Name = "btnReadFromFile"
        Me.btnReadFromFile.Size = New System.Drawing.Size(75, 23)
        Me.btnReadFromFile.TabIndex = 4
        Me.btnReadFromFile.Text = "Read"
        Me.btnReadFromFile.UseVisualStyleBackColor = True
        '
        'btnNotepad
        '
        Me.btnNotepad.Location = New System.Drawing.Point(262, 12)
        Me.btnNotepad.Name = "btnNotepad"
        Me.btnNotepad.Size = New System.Drawing.Size(131, 23)
        Me.btnNotepad.TabIndex = 5
        Me.btnNotepad.Text = "View /Edit"
        Me.btnNotepad.UseVisualStyleBackColor = True
        '
        'lstLabels
        '
        Me.lstLabels.BackColor = System.Drawing.SystemColors.Control
        Me.lstLabels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstLabels.ColumnWidth = 50
        Me.lstLabels.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstLabels.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLabels.FormattingEnabled = True
        Me.lstLabels.Location = New System.Drawing.Point(9, 54)
        Me.lstLabels.Margin = New System.Windows.Forms.Padding(2)
        Me.lstLabels.MultiColumn = True
        Me.lstLabels.Name = "lstLabels"
        Me.lstLabels.Size = New System.Drawing.Size(73, 223)
        Me.lstLabels.TabIndex = 2
        '
        'frmSalesData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 467)
        Me.Controls.Add(Me.btnNotepad)
        Me.Controls.Add(Me.btnReadFromFile)
        Me.Controls.Add(Me.btnSaveFile)
        Me.Controls.Add(Me.lstLabels)
        Me.Controls.Add(Me.lstSales)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSalesData"
        Me.Text = "Frit Sales by Paul's Tropical WholeSales"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstSales As System.Windows.Forms.ListBox
    Friend WithEvents btnSaveFile As System.Windows.Forms.Button
    Friend WithEvents btnReadFromFile As System.Windows.Forms.Button
    Friend WithEvents btnNotepad As System.Windows.Forms.Button
    Friend WithEvents lstLabels As System.Windows.Forms.ListBox

End Class
