Imports System.IO
Imports System.IO.Ports

Public Class frmDHT

    Public porta As New SerialPort("COM6", 9600, Parity.None, 8, StopBits.One)
    Event PortData(ByVal Message As String)
    Dim dvgDados As New DataTable
    Dim lista_dados As New ArrayList
    Dim returnStr As String = ""
    Dim ler As String
    Private Sub frmDHT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim com6 As IO.Ports.SerialPort = Nothing

        Dim f1 As FileStream = New FileStream("dados.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim ReaderF1 As New BinaryReader(f1)

        If (f1.Length = 0) Then
            MsgBox("Ficheiro vazio, sem dados registrados")
        Else
            Do While ReaderF1.PeekChar <> -1
                Dim novo As New Dados()
                novo.int_IDleitura = ReaderF1.ReadInt32()
                novo.data_Reg = ReaderF1.ReadString()
                novo.temp = ReaderF1.ReadDouble()
                novo.Hum = ReaderF1.ReadDouble()
            Loop
        End If
        ReaderF1.Close()
        f1.Close()

        Do
            Dim recebe As String = com6.ReadLine()
            If recebe Is Nothing Then
                Exit Do
            Else
                returnStr &= recebe & vbCrLf
            End If
        Loop
        MsgBox(returnStr)
    End Sub
    Private Sub readPort()
        Do While True
            Try
                Dim message As String = porta.ReadLine()
                RaiseEvent PortData(message)
                System.Threading.Thread.Sleep(0)
                My.Application.DoEvents()
            Catch ex As Exception
                Exit Do
            End Try
        Loop
    End Sub

    Private Sub leitura()

    End Sub

End Class
