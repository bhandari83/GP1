'Module contains definitions of Public variables used across the Project
'    (It can also contain Public Subs and Functions)


Module ModuleSales
    'Declare and initialize one-dimensional array of Car Makes per Car 
    Public strFruitName() As String = {"Apple", "Orange", "Peach", "Grapes", "Plum"}

    'Declare and initialize one-dimensional array of Car Prices per Car 
    Public intFruitPrice() As Integer = {25, 19, 17, 35, 16}


    'Declare and initialize two-dimensional array of Car Sales 
    'per Car (row) and Quarter (column)
    Public intMonthlySales(,) As Integer =
    {{5, 4, 7, 6, 4},
     {13, 7, 8, 9, 5},
     {10, 11, 9, 6, 14},
     {10, 11, 9, 6, 14},
     {13, 7, 8, 9, 5},
     {10, 11, 9, 6, 14},
     {4, 5, 3, 3, 6},
     {13, 7, 8, 9, 5},
     {10, 11, 9, 6, 14},
     {4, 5, 3, 3, 6},
     {4, 5, 3, 3, 6},
     {11, 5, 10, 13, 9}}


    'Declare variables that will be used throughout multiple forms.

    Public intPrice As Integer
    Public strName As String
    'Arrays of "labels"  
    Public strLabels() As String = {"Car", "Price", " ", "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                                    "Jul", "Aug", "Sep", "Oct", "Nov", "Dec", "", "Annual"}
    Public strLabels2() As String = {"Fruit", "Income"}
    Public FileName As String = "FruitSales.txt"

End Module
