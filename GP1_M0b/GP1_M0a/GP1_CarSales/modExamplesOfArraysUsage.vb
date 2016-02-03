Module modExamplesOfArraysUsage
    'Dim BookPageName(1003) As String
    'BookPageName(0) = "Cover Page"
    'BookPageName(1) = "Cover Page back"
    'BookPageName(2) = " Page 1"
    '...
    'BookPageName(1002) = "Page 1000"
    'BookPageName(1003) = "Back Cover back"
    'BookPageName(1004) = "Back Cover"

    'Dim PictureName(,,) As String
    'PictureName(2, 1, 2) = "mom 2010"

    'Const intPAGE As Integer = 999
    'Const intROW As Integer = 59
    'Const intCOLUMN As Integer = 59

    'Dim Character(intROW, intCOLUMN, intPAGE, intBOOK, intSHELF, intBOOKSHELF, intROOM,
    '              intFLOOR, intBUILDING, intCAMPUS, intCITY, intSTATE, intCOUNTRY,
    '              intCONTINENT, intPLANET, intSTARSYSTEM, intGALAXY, iniUVERSE) As String
    'PictureName(210, 11, 17).Trim = ")"

    'printed(Array)
    '1    -->   0
    '234  --> 233

    Public Sub mysub()
        For i As Integer = 0 To strFruitName.Length - 1
            strFruitName(i) = ""
            intFruitPrice(i) = 9
        Next
    End Sub


End Module
