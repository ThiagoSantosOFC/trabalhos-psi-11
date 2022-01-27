Imports System.IO
Public Class frmPaises_E_Cidades
    Public caminho As String = "C:\Users\52315\source\repos\Paises e Cidades\Paises e Cidades\dados.txt"
    Private Sub btnAddPais_Click(sender As Object, e As EventArgs) Handles btnAddPais.Click
        Dim fsficheiro As New FileStream(caminho, FileMode.Append, FileAccess.Write)
        Dim SW As New StreamWriter(fsficheiro)
        Dim i As Integer = 0
        For i = 0 To (ListBox.)
    End Sub
End Class
