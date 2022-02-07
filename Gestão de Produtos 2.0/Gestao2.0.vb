Imports System.IO
Public Class frmGestaoProdutos
    Dim lista_dados As New ArrayList
    Private Sub frmGestaoProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f1 As FileStream = New FileStream("dados4.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite)

    End Sub
End Class
Public Class Dados
    Public codigo As Integer
    Public descricao As String
    Public Categoria As String
    Public preco As String
End Class