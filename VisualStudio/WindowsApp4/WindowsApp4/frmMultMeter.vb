Imports System.IO

Public Class frmMultMeter


    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim Nome As String ' Nome da localização
        OpenFileDialog1.DefaultExt = "*.tmplog" ' Extensão unica do ficheiro
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Ficheiro de Registo de Temperatura | *.tmplog"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Nome = OpenFileDialog1.FileName
            Dim FSficheiro As New FileStream(Nome, FileMode.Open, FileAccess.Read) ' Preparar a stream
            Dim BR As New BinaryReader(FSficheiro) ' Usar a leitura binária
            Dim temp As Integer = 0
            Try ' Tentar ler os dados
                couting = BR.ReadInt32
                IdTMP.StoredTMP.Clear() ' Limpar a ArrayList por completo para não haver corrupção de dados
                Do While temp < couting ' Contar e continuar até não haver mais registos
                    IdTMP._id = BR.ReadInt32
                    IdTMP._data = BR.ReadString
                    IdTMP._valor = BR.ReadDecimal
                    IdTMP._tipo = BR.ReadBoolean
                    IdTMP.StoredTMP.Add(New Class_Main(IdTMP._id, IdTMP._data, IdTMP._valor, IdTMP._humidade, IdTMP._tipo)) ' Mete-los na ArrayList
                    temp = temp + 1
                Loop
                BR.Close() ' Fechar a leitura binaria
                FSficheiro.Close() ' Fechar a stream
                lblStatusS.Visible = True
                Timer_POP.Enabled = True
            Catch ex As Exception ' Caso houver algum erro a obter os dados
                MsgBox("Informação não existente ou corrompida")
            End Try
        End If
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Form_Find.Show() ' Chamar a sua form
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Form_Open.Show() ' chamar a sua Form
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Form_Read.Show() ' chama a form
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MsgBox("Este programa utiliza um sistema em Arduino para coletar dados do ambiente usando um sensor dht22")
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim Nome As String ' Nome da localização
        SaveFileDialog1.DefaultExt = "*.tmplog" ' Extensão unica do ficheiro
        SaveFileDialog1.AddExtension = False
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Ficheiro de Registo de Temperatura | *.tmplog"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Nome = SaveFileDialog1.FileName
            Dim FSficheiro As New FileStream(Nome, FileMode.Create, FileAccess.Write) ' Preparar a stream
            Dim BW As New BinaryWriter(FSficheiro) ' Usar a escrita binária
            Try ' Tentar guardar os dados
                BW.Write(couting)
                For Each obj As Class_Main In IdTMP.StoredTMP ' Criar uma variavel que vai percorrer a ArrayList até não haver mais
                    BW.Write(obj._id)
                    BW.Write(obj._data)
                    BW.Write(obj._valor)
                    BW.Write(obj._tipo)
                    BW.Write(obj._humidade)
                Next obj
                BW.Close() ' Fechar a escrita binaria
                FSficheiro.Close() ' Fechar a stream
                lblStatusS.Visible = True
                Timer_POP.Enabled = True
            Catch ex As Exception ' Caso ocorrer um erro ao guardar os dados
                MsgBox("Informação não existente ou corrompida")
            End Try

        End If
    End Sub
End Class
