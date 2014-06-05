Option Strict On
Imports System.IO
Module MainModule
    Public Structure PropertyData
        Dim address As String
        Dim city As String
        Dim state As String
        Dim zipcode As String
        Dim description As String
        Dim agentName As String
        Dim sellerName As String
        Dim squareFeet As String
        Dim dateReady As String
        Dim propPrice As String
        Dim propSold As String
        Dim acres As String
        Dim residential As Boolean
    End Structure
    Public realEstate(0) As PropertyData

    Public Sub OpenFile(ByVal fileName As String)
        Dim canOpener As StreamReader
        ReDim realEstate(0)
        Dim count As Integer = 0
        canOpener = File.OpenText(fileName)
        While canOpener.Peek <> -1
            Dim data() As String
            data = Split(canOpener.ReadLine, vbTab)
            With realEstate(count)
                .address = data(0)
                .city = data(1)
                .state = data(2)
                .zipcode = data(3)
                .description = data(4)
                .agentName = data(5)
                .sellerName = data(6)
                .squareFeet = data(7)
                .dateReady = data(8)
                .acres = data(9)
                .propPrice = data(10)
                .propSold = data(11)
                .residential = CBool(data(12))
            End With
            count += 1
            ReDim Preserve realEstate(count)
        End While
    End Sub

    Public Sub SaveFile(ByVal fileName As String, ByVal propertyInformation As PropertyData)
        Dim writingWriter As StreamWriter

        writingWriter = File.AppendText(fileName)
        With propertyInformation
            'writingWriter.WriteLine("Agent Name" & vbTab & "Seller Name" & vbTab & "Sq. Feet" & vbTab & "Date Avail." & vbTab & "Acreage" & vbTab & "Prop. Price" & vbTab & "Sold" & vbTab & "Prop. Type" & vbTab & "Address" & vbTab & "City" & vbTab & "State" & vbTab & "Zipcode" & vbTab & "Property Description")
            writingWriter.WriteLine(.agentName & vbTab & .sellerName & vbTab & .squareFeet & vbTab & FormatDateTime(CDate(.dateReady), DateFormat.ShortDate) & vbTab & .acres & vbTab & .propPrice & vbTab & .propSold & vbTab & .residential & vbTab & .address & vbTab & .city & vbTab & .state & vbTab & .zipcode & vbTab & .description)
        End With
        writingWriter.Close()
    End Sub
End Module
