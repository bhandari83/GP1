Option Strict On

Imports System.IO


Public Class frmSalesData

    Private Sub DisplayData()



        'labels column
        lstLabels.Items.Clear()
        'Add label names to list box
        For Each strName In strLabels
            lstLabels.Items.Add(strName)
        Next

        'main sales listbox
        lstSales.Items.Clear()

        For fruit As Integer = 0 To 4
            'name
            lstSales.Items.Add(strFruitName(fruit))
            'price
            lstSales.Items.Add(intFruitPrice(fruit).ToString("c0"))
            'empty line as separator
            lstSales.Items.Add("")  ' add empty column
            'Sales Data for all months
            For month As Integer = 0 To 11
                lstSales.Items.Add(intMonthlySales(month, fruit).ToString)
            Next
            'empty line as separator
            lstSales.Items.Add("")  ' add empty column
            'reserve for Annual
            lstSales.Items.Add("")  ' add empty column
        Next fruit




        'Disable the open, save, and annual income options in the menu.
        'mnuOpen.Enabled = False
        'mnuSave.Enabled = False
        'mnuAnnualIncome.Enabled = False

    End Sub


    Private Sub btnSaveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveFile.Click

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


    Public Sub SaveDataToFile(ByVal outFileName As String)
        'defile the file objet first
        Dim outFile As StreamWriter

        'open the file
        outFile = File.CreateText(outFileName)
        ' write data to the file
        ' name of each car 
        For i As Integer = 0 To strFruitName.Length - 1
            outFile.WriteLine(strFruitName(i))
        Next
        ' prices of each car 
        For Each intPrice In intFruitPrice
            outFile.WriteLine(intPrice)
        Next
        'sales data from the two-dimensional array 
        For fruit As Integer = 0 To 4
            For month As Integer = 0 To 11
                outFile.WriteLine(intMonthlySales(month, fruit).ToString)
            Next
        Next
        'close the file
        outFile.Close()

    End Sub

    Private Sub btnReadFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadFromFile.Click
        'choose FileName from OpenFile Dialog

        'check if file exists
        If File.Exists(FileName) Then
            'read data from the chosen file
            ReadDataFromFile(FileName)
            'dislpay in the list box
            DisplayData()
        Else
            MessageBox.Show("File " & FileName & " does not exist", "Input Error")
        End If
    End Sub


    Public Sub ReadDataFromFile(ByVal inputFileName As String)
        'defile the file obcet first
        Dim inputFile As StreamReader

        inputFile = File.OpenText(inputFileName)

        ' write data to the file
        ' name of each car 

        For fruit As Integer = 0 To strFruitName.Length - 1
            strFruitName(fruit) = inputFile.ReadLine()
        Next

        ' prices of each car 
        For Each intFruit As Integer In intFruitPrice
            intFruit = CInt(inputFile.ReadLine())
        Next

        'sales data from the two-dimensional array 
        For fruit As Integer = 0 To 4
            For month As Integer = 0 To 11
                intMonthlySales(month, fruit) = CInt(inputFile.ReadLine())
            Next
        Next

        'close the file
        inputFile.Close()
    End Sub

    Private Sub btnNotepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotepad.Click
        Shell("notepad " & FileName, appWinStyle.NormalFocus)
    End Sub

End Class
