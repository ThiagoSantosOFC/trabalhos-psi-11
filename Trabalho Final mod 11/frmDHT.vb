Imports System.IO
Imports System.IO.Ports

Public Class frmDHT

    Dim lista_dados As New ArrayList
    Dim returnStr As String
    Private Sub frmDHT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim com6 As IO.Ports.SerialPort = Nothing
        Try
            com6 = My.Computer.Ports.OpenSerialPort("COM6")
            com6.ReadTimeout = 10000

        Catch ex As TimeoutException
            returnStr = "Erro: tempo de leitura da porta expirado."
        Finally
            If com6 IsNot Nothing Then com6.Close()
        End Try
        Dim f1 As FileStream = New FileStream("dados.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim ReaderF1 As New BinaryReader(f1)

        If (f1.Length = 0) Then
            MsgBox("Ficheiro vazio, sem produtos registrados")
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class

