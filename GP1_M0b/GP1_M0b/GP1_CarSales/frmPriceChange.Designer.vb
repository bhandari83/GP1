<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriceChange
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProduct0 = New System.Windows.Forms.Label()
        Me.lblProduct2 = New System.Windows.Forms.Label()
        Me.lblProduct1 = New System.Windows.Forms.Label()
        Me.lblProduct3 = New System.Windows.Forms.Label()
        Me.lblProduct4 = New System.Windows.Forms.Label()
        Me.txtPrice0 = New System.Windows.Forms.TextBox()
        Me.txtPrice3 = New System.Windows.Forms.TextBox()
        Me.txtPrice1 = New System.Windows.Forms.TextBox()
        Me.txtPrice4 = New System.Windows.Forms.TextBox()
        Me.txtPrice2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(23, 206)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 44)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(158, 206)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 44)
        Me.btnChange.TabIndex = 1
        Me.btnChange.Text = "Accept Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Insert New Guitar Price:"
        '
        'lblProduct0
        '
        Me.lblProduct0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProduct0.Location = New System.Drawing.Point(23, 39)
        Me.lblProduct0.Name = "lblProduct0"
        Me.lblProduct0.Size = New System.Drawing.Size(75, 20)
        Me.lblProduct0.TabIndex = 3
        Me.lblProduct0.Text = " "
        '
        'lblProduct2
        '
        Me.lblProduct2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProduct2.Location = New System.Drawing.Point(23, 102)
        Me.lblProduct2.Name = "lblProduct2"
        Me.lblProduct2.Size = New System.Drawing.Size(75, 20)
        Me.lblProduct2.TabIndex = 4
        Me.lblProduct2.Text = " "
        '
        'lblProduct1
        '
        Me.lblProduct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProduct1.Location = New System.Drawing.Point(23, 69)
        Me.lblProduct1.Name = "lblProduct1"
        Me.lblProduct1.Size = New System.Drawing.Size(75, 20)
        Me.lblProduct1.TabIndex = 5
        Me.lblProduct1.Text = " "
        '
        'lblProduct3
        '
        Me.lblProduct3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProduct3.Location = New System.Drawing.Point(23, 131)
        Me.lblProduct3.Name = "lblProduct3"
        Me.lblProduct3.Size = New System.Drawing.Size(75, 20)
        Me.lblProduct3.TabIndex = 6
        Me.lblProduct3.Text = " "
        '
        'lblProduct4
        '
        Me.lblProduct4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProduct4.Location = New System.Drawing.Point(23, 164)
        Me.lblProduct4.Name = "lblProduct4"
        Me.lblProduct4.Size = New System.Drawing.Size(75, 20)
        Me.lblProduct4.TabIndex = 7
        Me.lblProduct4.Text = " "
        '
        'txtPrice0
        '
        Me.txtPrice0.Location = New System.Drawing.Point(158, 39)
        Me.txtPrice0.Name = "txtPrice0"
        Me.txtPrice0.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice0.TabIndex = 8
        '
        'txtPrice3
        '
        Me.txtPrice3.Location = New System.Drawing.Point(158, 131)
        Me.txtPrice3.Name = "txtPrice3"
        Me.txtPrice3.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice3.TabIndex = 9
        '
        'txtPrice1
        '
        Me.txtPrice1.Location = New System.Drawing.Point(158, 69)
        Me.txtPrice1.Name = "txtPrice1"
        Me.txtPrice1.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice1.TabIndex = 10
        '
        'txtPrice4
        '
        Me.txtPrice4.Location = New System.Drawing.Point(158, 164)
        Me.txtPrice4.Name = "txtPrice4"
        Me.txtPrice4.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice4.TabIndex = 11
        '
        'txtPrice2
        '
        Me.txtPrice2.Location = New System.Drawing.Point(158, 102)
        Me.txtPrice2.Name = "txtPrice2"
        Me.txtPrice2.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice2.TabIndex = 12
        '
        'frmPriceChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtPrice2)
        Me.Controls.Add(Me.txtPrice4)
        Me.Controls.Add(Me.txtPrice1)
        Me.Controls.Add(Me.txtPrice3)
        Me.Controls.Add(Me.txtPrice0)
        Me.Controls.Add(Me.lblProduct4)
        Me.Controls.Add(Me.lblProduct3)
        Me.Controls.Add(Me.lblProduct1)
        Me.Controls.Add(Me.lblProduct2)
        Me.Controls.Add(Me.lblProduct0)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmPriceChange"
        Me.Text = "Change Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProduct0 As System.Windows.Forms.Label
    Friend WithEvents lblProduct2 As System.Windows.Forms.Label
    Friend WithEvents lblProduct1 As System.Windows.Forms.Label
    Friend WithEvents lblProduct3 As System.Windows.Forms.Label
    Friend WithEvents lblProduct4 As System.Windows.Forms.Label
    Friend WithEvents txtPrice0 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice4 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice2 As System.Windows.Forms.TextBox
End Class
