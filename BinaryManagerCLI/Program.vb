Imports System.IO
Module Module1
    Const nomeArquivo As String = "C:\Users\52315\source\repos\BinaryManagerCLI\ConfigDemo.bin"
    Sub Main()
        GravarValoresPadrao()
        ExibirValores()
    End Sub
    Sub GravarValoresPadrao()
        Using writer As BinaryWriter = New BinaryWriter(File.Open(nomeArquivo, FileMode.Create))
            writer.Write("macoratti")
            writer.Write("numsey")
            writer.Write(0.25F)
            writer.Write("c:\dados\config")
            writer.Write(10)
            writer.Write(True)
        End Using
    End Sub
    Sub ExibirValores()
        Dim nomeUsuario As String
        Dim senhaUsuario As String
        Dim percentual As Single
        Dim pastaBackup As String
        Dim tempoEspera As Integer
        Dim exibirDados As Boolean
        If (File.Exists(nomeArquivo)) Then
            Using reader As BinaryReader = New BinaryReader(File.Open(nomeArquivo, FileMode.Open))
                nomeUsuario = reader.ReadString()
                senhaUsuario = reader.ReadString()
                percentual = reader.ReadSingle()
                pastaBackup = reader.ReadString()
                tempoEspera = reader.ReadInt32()
                exibirDados = reader.ReadBoolean()
            End Using
            Console.WriteLine("Nome do usuário    : " & nomeUsuario)
            Console.WriteLine("Senha do usuário   : " & senhaUsuario)
            Console.WriteLine("Percentual Multa   : " & percentual)
            Console.WriteLine("Pasta de Backup    : " & pastaBackup)
            Console.WriteLine("Tempo de Espera    : " & tempoEspera)
            Console.WriteLine("Exibe Configuracao : " & exibirDados)
        End If
    End Sub
End Module