Module Module1

    Sub Main()
        Console.WriteLine("Start")

        Dim po = New ParallelOptions With {
            .MaxDegreeOfParallelism = 6
        }

        Parallel.For(0, 100000, po, Sub(i As Integer) Console.WriteLine(i))


        'Parallel.Invoke(AddressOf Zähle, AddressOf Zähle, AddressOf Zähle, AddressOf Zähle)

        Console.WriteLine("Ende")
        Console.ReadKey()
    End Sub

    Private Sub Zähle()
        For index = 1 To 10
            Console.WriteLine(index)
        Next
    End Sub

End Module
