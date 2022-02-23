﻿Imports System.IO
Imports System.IO.Ports
Public Class frmMultMeter
    Public porta As New SerialPort("COM8", 9600, Parity.None, 8, StopBits.One)
    Event PortData(ByVal Message As String)
    Dim dvgDados As New DataTable
    Dim lista_dados As New ArrayList
    Dim returnStr As String = ""
    Dim ler As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.PortName = ComboBox1.Text
        Try
            SerialPort1.Open()

            lblConexao.Text = "Conexão Ativa"
        Catch ex As Exception
            MsgBox("A porta não está aberta")
            If SerialPort1.IsOpen = False Then
                MsgBox("A porta não está aberta")
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Timer1.Enabled = True

        Catch ex As Exception
            MsgBox("Com Errada")
            lblconexao.Text = "Sem Conexão"

        End Try
    End Sub

    Private Sub frmMultMeter_Load(sender As Object, e As EventArgs) Handles MyBase.Load



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

        Dim i As Integer

        DataGridView1.Rows.Add()
            DataGridView1.Rows(i).Cells(i).Value = "1"
            DataGridView1.Rows(i).Cells(i).Value = "12-12-2015"
            DataGridView1.Rows(i).Cells(i).Value = "20º"
            DataGridView1.Rows(i).Cells(i).Value = True


            DataGridView1.Rows.Add()
            DataGridView1.Rows(i).Cells(i).Value = "2"
            DataGridView1.Rows(i).Cells(i).Value = "12-12-2015"
            DataGridView1.Rows(1).Cells(i).Value = "25º"
            DataGridView1.Rows(i).Cells(i).Value = False

    End Sub
End Class