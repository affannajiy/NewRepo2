Module Program
    Sub Main()
        Dim I, J As Integer
        For I = 1 To 5
            For J = 1 To I
                Console.Write(I)
            Next J
            Console.WriteLine()
        Next I
    End Sub
End Module

Module Program
    Sub Main()
        Dim I, J, K As Integer
        For I = 1 To 5
            For J = 5 To I + 1 Step -1
                Console.Write(" ")
            Next J

            For K = 1 To I
                Console.Write(I)
            Next

            Console.WriteLine()
        Next I
    End Sub
End Module
