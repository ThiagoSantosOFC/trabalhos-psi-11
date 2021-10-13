Imports System

Module Program
    Sub Main(args As String())

        Dim Valor As String = InputBox("Informe seu nome")
        Dim Vezes As Byte = 1
        Do
            Console.WriteLine(Valor)
            Vezes += 1
        Loop
        Console.ReadLine()
    End Sub
End Module
