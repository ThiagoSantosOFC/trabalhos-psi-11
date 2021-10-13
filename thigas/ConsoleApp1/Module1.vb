Module Module1

    Sub Main()
        Dim repetir As Integer = 1
        Console.WriteLine("Usando o Do While")
        Do While repetir <= 5
            Console.WriteLine(repetir.ToString & "Thiago Show na cena")
            repetir += 1
        Loop
        Console.ReadLine()

        'apagando o que foi escrito'
        Console.Clear()
        repetir = 1
        Console.WriteLine("Usando o Do Until")

        Do Until repetir > 5
            Console.WriteLine(repetir.ToString & "Literalmente o Thigas")
            repetir += 1
        Loop
        Console.ReadLine()
    End Sub

End Module
