Module Module1

    Sub Main()
        Dim myChar, thisChar, nextChar As Char
        Dim Highest, Count, a, b As Integer
        Dim Str1 As String

        myChar = ""
        Highest = 0
        Count = 0

        Console.Write("EnterString to be processed: ")
        Str1 = Console.ReadLine

        For a = 1 To Len(Str1)
            nextChar = Mid(Str1, a, 1)
            Count = 0
            For b = 1 To Len(Str1)
                thisChar = Mid(Str1, b, 1)
                If thisChar = nextChar Then Count = Count + 1
            Next

            If Count > Highest Then
                Highest = Count
                myChar = nextChar
            End If
        Next
        Console.WriteLine(myChar & " appeared " & Highest & " times.")
        Console.ReadKey()
    End Sub
End Module
