'Module contains definitions of Public variables used across the Project
'    (It can also contain Public Subs and Functions)


Module ModuleSales

    'Declare and initialize one-dimensional array of Guitar Makes per Guitar
    Public strGuitarMake() As String = {"Takamine", "Ovation", "Gibson", "Fender", "Washburn"}

    'Declare and initialize one-dimensional array of Guitar Prices per Guitar 
    Public intGuitarPrice() As Integer = {2500, 1950, 1750, 3500, 1650}


    'Declare and initialize two-dimensional array of Guitar Sales 
    'per Guitar (row) and Quarter (column)
    Public intMonthlySales(,) As Integer =
      {{5, 4, 7, 3, 6},
     {13, 7, 8, 4, 9},
     {10, 12, 11, 9, 14},
     {4, 5, 15, 3, 6},
     {11, 10, 17, 13, 9},
     {5, 4, 18, 7, 6},
     {13, 7, 21, 8, 9},
     {10, 11, 5, 9, 14},
     {4, 5, 3, 2, 6},
     {11, 10, 13, 4, 9},
     {4, 5, 3, 6, 2},
     {11, 10, 13, 9, 2}}

    'Declare variables that will be used throughout multiple forms.

    Public intPrice As Integer
    Public strName As String
    'Arrays of "labels" 
    Public strLabels() As String = {"Guitar", "Price", "----", "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec", "Annual"}
    Public strLabels2() As String = {"Guitar", "Income"}
    Public FileName As String = "GuitarSales.txt"
    Public intAnnualSales(4) As Integer
    Public GuitarPrice(4) As Integer

    Public Sub AnnualSales()
        ' Adding annual sales
        For guitarbrand As Integer = 0 To 4
            intAnnualSales(guitarbrand) = 0
            For intMonth As Integer = 0 To 11
                intAnnualSales(guitarbrand) += intMonthlySales(intMonth, guitarbrand)
            Next intMonth
        Next guitarbrand
    End Sub
End Module
