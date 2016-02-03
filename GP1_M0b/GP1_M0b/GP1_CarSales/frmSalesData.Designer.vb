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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileRead = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrice = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPriceChange = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalculate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalculateSales = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalculateIncome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstLabels = New System.Windows.Forms.ListBox()
        Me.lstSales = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuPrice, Me.mnuCalculate, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(403, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileRead, Me.mnuFileSave, Me.mnuFileView, Me.mnuFileQuit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileRead
        '
        Me.mnuFileRead.Name = "mnuFileRead"
        Me.mnuFileRead.Size = New System.Drawing.Size(124, 22)
        Me.mnuFileRead.Text = "Read"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(124, 22)
        Me.mnuFileSave.Text = "Save"
        '
        'mnuFileView
        '
        Me.mnuFileView.Name = "mnuFileView"
        Me.mnuFileView.Size = New System.Drawing.Size(124, 22)
        Me.mnuFileView.Text = "View/Edit"
        '
        'mnuFileQuit
        '
        Me.mnuFileQuit.Name = "mnuFileQuit"
        Me.mnuFileQuit.Size = New System.Drawing.Size(124, 22)
        Me.mnuFileQuit.Text = "Quit"
        '
        'mnuPrice
        '
        Me.mnuPrice.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPriceChange})
        Me.mnuPrice.Enabled = False
        Me.mnuPrice.Name = "mnuPrice"
        Me.mnuPrice.Size = New System.Drawing.Size(45, 20)
        Me.mnuPrice.Text = "Price"
        '
        'mnuPriceChange
        '
        Me.mnuPriceChange.Name = "mnuPriceChange"
        Me.mnuPriceChange.Size = New System.Drawing.Size(115, 22)
        Me.mnuPriceChange.Text = "Change"
        '
        'mnuCalculate
        '
        Me.mnuCalculate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCalculateSales, Me.mnuCalculateIncome})
        Me.mnuCalculate.Enabled = False
        Me.mnuCalculate.Name = "mnuCalculate"
        Me.mnuCalculate.Size = New System.Drawing.Size(68, 20)
        Me.mnuCalculate.Text = "Calculate"
        '
        'mnuCalculateSales
        '
        Me.mnuCalculateSales.Name = "mnuCalculateSales"
        Me.mnuCalculateSales.Size = New System.Drawing.Size(155, 22)
        Me.mnuCalculateSales.Text = "Annual Sales"
        '
        'mnuCalculateIncome
        '
        Me.mnuCalculateIncome.Enabled = False
        Me.mnuCalculateIncome.Name = "mnuCalculateIncome"
        Me.mnuCalculateIncome.Size = New System.Drawing.Size(155, 22)
        Me.mnuCalculateIncome.Text = "Annual Income"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuHelpAbout.Text = "About"
        '
        'lstLabels
        '
        Me.lstLabels.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLabels.BackColor = System.Drawing.SystemColors.Control
        Me.lstLabels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstLabels.ColumnWidth = 52
        Me.lstLabels.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstLabels.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLabels.FormattingEnabled = True
        Me.lstLabels.Location = New System.Drawing.Point(18, 49)
        Me.lstLabels.Margin = New System.Windows.Forms.Padding(2)
        Me.lstLabels.MultiColumn = True
        Me.lstLabels.Name = "lstLabels"
        Me.lstLabels.Size = New System.Drawing.Size(77, 236)
        Me.lstLabels.TabIndex = 11
        '
        'lstSales
        '
        Me.lstSales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstSales.ColumnWidth = 75
        Me.lstSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSales.FormattingEnabled = True
        Me.lstSales.Location = New System.Drawing.Point(99, 49)
        Me.lstSales.Margin = New System.Windows.Forms.Padding(2)
        Me.lstSales.MultiColumn = True
        Me.lstSales.Name = "lstSales"
        Me.lstSales.Size = New System.Drawing.Size(286, 238)
        Me.lstSales.TabIndex = 10
        '
        'frmSalesData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 337)
        Me.Controls.Add(Me.lstLabels)
        Me.Controls.Add(Me.lstSales)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSalesData"
        Me.Text = "Guitar Sales (C) Kia Xiong, Ananta Bhandari, Saminda Siriwardena, July 2014"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileRead As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPriceChange As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCalculate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCalculateSales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCalculateIncome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstLabels As System.Windows.Forms.ListBox
    Friend WithEvents lstSales As System.Windows.Forms.ListBox

End Class
