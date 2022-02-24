Public Class Form_Open
    Private Sub Form_Open_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updati() ' Chamar função para inserir/atualizar o DataGridView
    End Sub

    Private Sub btnUpdata_Click(sender As Object, e As EventArgs)
        updati() ' Chamar função para inserir/atualizar o DataGridView
    End Sub
    Public Sub updati() ' função para inserir/atualizar o DataGridView
        Try ' Tentar percorrer esta parte do código
            DataGridView1.Rows.Clear() ' Eliminar tudo para não mostrar tudo repetido
            For Each obj As Class_Main In IdTMP.StoredTMP ' Criar uma variavel que vai passar pela ArrayList toda
                DataGridView1.Rows.Add() ' Adicionar linha
                DataGridView1.Rows(obj._id - 1).Cells(0).Value = obj._id ' Insere o id unico
                DataGridView1.Rows(obj._id - 1).Cells(1).Value = obj._data ' Insere a data e hora
                DataGridView1.Rows(obj._id - 1).Cells(2).Value = obj._valor ' Insere o valor de temperatura

                If obj._tipo = True Then ' Caso for entre 10 a 20 graus
                    DataGridView1.Rows(obj._id - 1).Cells(3).Value = "S" ' Inserir como Sim no tipo
                Else ' Caso não for
                    DataGridView1.Rows(obj._id - 1).Cells(3).Value = "N" ' Inserir como Não no tipo
                End If
            Next obj ' Para o próximo nivel da ArrayList
        Catch ex As Exception ' Caso der erro ao percorrer o código
            MsgBox("Informação não existente ou corrompida")
        End Try
    End Sub

End Class