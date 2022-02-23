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


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.PortName = ComboBox1.Text
        Try
            SerialPort1.Open()

            Label5.Text = "Conexão Ativa"
        Catch ex As Exception
            MsgBox("Porta não está aberta")
            If SerialPort1.IsOpen = False Then
                MsgBox("Porta não está aberta")
            End If
        End Try
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
