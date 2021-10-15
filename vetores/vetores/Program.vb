Imports System

Module Program
    Sub Main(args As String())
        Dim vetor(0 To 5) As String
        Dim PrimeiroValor As String = vetor(0)
        Dim VetorOrdenado = Array.Sort(vetor)
        vetor(0) = “valor qualquer”
        vetor(1) = “outro valor”
        vetor(2) = “Benfica”
        vetor(3) = “Teste”
        vetor(4) = “Olá Mundo”
        vetor(5) = “Hostnet”
        Console.WriteLine(vetor(4)) 'Escrever o valor na janela
        Console.WriteLine(vetor.Length.ToString)
        Console.WriteLine(VetorOrdenado)

    End Sub
End Module
