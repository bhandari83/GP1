
Imports System.IO

Public Class frmPriceChange

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnChange_Click(sender As System.Object, e As System.EventArgs) Handles btnChange.Click 

        'Get price array to textbox
        intGuitarPrice(0) = Val(txtPrice0.Text)
        intGuitarPrice(1) = Val(txtPrice1.Text)
        intGuitarPrice(2) = Val(txtPrice2.Text)
        intGuitarPrice(3) = Val(txtPrice3.Text)
        intGuitarPrice(4) = Val(txtPrice4.Text)
       
        'Close the form.
        Me.Close()
    End Sub

 
   
End Class