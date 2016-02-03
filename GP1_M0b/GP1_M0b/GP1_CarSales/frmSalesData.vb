' Kia Xiong, Ananta Bhandari, Saminda Siriwardena
' IS 250, T0: Group Project 1
' Project started: 7/25/2014, Project Submitted: 7/29/2014
' Purpose of the program: Transpose the data from quartly to monthly
' and calculate the annual sales. Once annual sales is calculated, display the annual income.
' User can change the price of guitars and should update on the listbox, which 
' will change the annual income.
Option Strict On
Imports System.IO

Public Class frmSalesData

    Private Sub DisplayData()

        'Clear 
        lstSales.Items.Clear()
        lstLabels.Items.Clear()

        'Add label names to list box
        For Each strName In strLabels
            lstLabels.Items.Add(strName)
        Next

        For guitar As Integer = 0 To 4

            'Name
            lstSales.Items.Add(strGuitarMake(guitar))

            'price
            lstSales.Items.Add(intGuitarPrice(guitar).ToString("c0"))

            'Empty line as seperator
            lstSales.Items.Add("----")

            'Sales data for all months
            For intMonth As Integer = 0 To 11
                lstSales.Items.Add(intMonthlySales(intMonth, guitar).ToString)

            Next
            'Annual 
            lstSales.Items.Add("")
        Next
    End Sub
    Public Sub SaveDataToFile(ByVal outFileName As String)
        'defile the file object first
        Dim outFile As StreamWriter

        'open the file
        outFile = File.CreateText(outFileName)
        ' write data to the file
        ' name of each guitar 
        For i As Integer = 0 To strGuitarMake.Length - 1
            outFile.WriteLine(strGuitarMake(i))
        Next
        ' prices of each guitar 
        For Each intPrice In intGuitarPrice
            outFile.WriteLine(intPrice)
        Next
        'sales data from the two-dimensional array 
        For intMonth As Integer = 0 To 11
            For intGuitar As Integer = 0 To 4
                outFile.WriteLine(intMonthlySales(intMonth, intGuitar).ToString)
            Next
        Next
        'close the file
        outFile.Close()

    End Sub
    Public Sub ReadDataFromFile(ByVal inputFileName As String)
        'define the file object first
        Dim inputFile As StreamReader

        inputFile = File.OpenText(inputFileName)

        ' write data to the file
        ' name of each guitar

        For Guitar As Integer = 0 To strGuitarMake.Length - 1
            strGuitarMake(Guitar) = inputFile.ReadLine()
        Next

        ' prices of each guitar
        For intGuitar As Integer = 0 To intGuitarPrice.Length - 1
            intGuitarPrice(intGuitar) = CInt(inputFile.ReadLine())
        Next

        'sales data from the two-dimensional array 
        For intMonth As Integer = 0 To 11
            For intGuitar As Integer = 0 To 4
                intMonthlySales(intMonth, intGuitar) = CInt(inputFile.ReadLine())
            Next
        Next
        
        'close the file
        inputFile.Close()
    End Sub
    Private Sub mnuFileRead_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileRead.Click
        'check if file exists
        If File.Exists(FileName) Then
            'read data from the chosen file
            ReadDataFromFile(FileName)
            'dislpay in the list box
            DisplayData()
        Else
            MessageBox.Show("File " & FileName & " does not exist", "Input Error")
        End If
        mnuPrice.Enabled = True
        mnuCalculate.Enabled = True
    End Sub

    Private Sub mnuFileView_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileView.Click
        Shell("notepad " & FileName, AppWinStyle.NormalFocus)
    End Sub

    Private Sub mnuFileSave_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileSave.Click
        'check if file already exists
        If File.Exists(FileName) Then
            If MessageBox.Show("Do you want to overwrite changes?", "File Already Exists", _
               MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        'save data to the chosen file
        SaveDataToFile(FileName)
    End Sub

    Private Sub mnuHelpAbout_Click(sender As System.Object, e As System.EventArgs) Handles mnuHelpAbout.Click
        'An instance of the About Form.
        Dim frmAbout As New frmAbout

        'Show the Form
        frmAbout.Show()
    End Sub

    Private Sub mnuPriceChange_Click(sender As System.Object, e As System.EventArgs) Handles mnuPriceChange.Click
        'Create an instance of the Price Change Form.
        Dim frmPriceChange As New frmPriceChange
        'Create an instance of the Price Change Form.
        With frmPriceChange
            ' Get prices and guitar make from array
            .txtPrice0.Text = (intGuitarPrice(0).ToString)
            .txtPrice1.Text = (intGuitarPrice(1).ToString)
            .txtPrice2.Text = (intGuitarPrice(2).ToString)
            .txtPrice3.Text = (intGuitarPrice(3).ToString)
            .txtPrice4.Text = (intGuitarPrice(4).ToString)

            .lblProduct0.Text = strGuitarMake(0)
            .lblProduct1.Text = strGuitarMake(1)
            .lblProduct2.Text = strGuitarMake(2)
            .lblProduct3.Text = strGuitarMake(3)
            .lblProduct4.Text = strGuitarMake(4)


            'give focus to the text box
            .txtPrice0.Focus()

            'Show the Form 
            frmPriceChange.ShowDialog()
        End With
        'update prices shown the listbox

        For guitar As Integer = 0 To 4
            lstSales.Items(1 + 16 * guitar) = (intGuitarPrice(guitar).ToString("c0"))
        Next

    End Sub

    Private Sub mnuCalculateIncome_Click(sender As System.Object, e As System.EventArgs) Handles mnuCalculateIncome.Click
        'An instance of the Annual Income Form.

        Dim IncomeTotal As Integer
        Dim frmAnnualIncome As New frmAnnualIncome

        With frmAnnualIncome
            'Create labels in listbox Annual labels
            For Each strName In strLabels2
                .lstAnnualLabels.Items.Add(strName)
            Next
            ' Sending guitar make to label
            For i As Integer = 0 To 4
                .lstAnnualIncome.Items.Add(strGuitarMake(i))
            Next
            'Add dashes as seperator 
            .lstAnnualIncome.Items.Add("----------")
            .lstAnnualIncome.Items.Add("Total:")
            'Annual income for all guitar make
            For g As Integer = 0 To 4
                GuitarPrice(g) = intAnnualSales(g) * intGuitarPrice(g)
                .lstAnnualIncome.Items.Add(intGuitarPrice(g) *
                                          intAnnualSales(g)).ToString("c0")
                IncomeTotal += GuitarPrice(g)
            Next
            'Add dashes as seperator 
            .lstAnnualIncome.Items.Add("----------")
            .lstAnnualIncome.Items.Add(IncomeTotal)

            'Show the Form
            .ShowDialog()
        End With
    End Sub

    Private Sub mnuCalculateSales_Click(sender As System.Object, e As System.EventArgs) Handles mnuCalculateSales.Click
        'Call procedure annual sales
        AnnualSales()
        'Calculate annual sales
        For guitarbrand As Integer = 0 To 4
            lstSales.Items(15 + guitarbrand * 16) = intAnnualSales(guitarbrand)
        Next guitarbrand

        'enable Menu item.
        mnuCalculateIncome.Enabled = True
    End Sub


    Private Sub mnuFileQuit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileQuit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
