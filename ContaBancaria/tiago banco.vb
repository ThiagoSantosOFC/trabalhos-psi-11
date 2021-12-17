Public Class frmContaBanco

    Dim conta1 As New contabancaria 'cria um objeto instanciado na classe contabancaria, diga-mos que é o processo para abrir uma conta bancaria'

    Private Sub frmContaBanco_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAbrirConta_Click(sender As Object, e As EventArgs)
        ' define as informações gerais da conta
        conta1.Nconta = 1111111
        conta1.Saldo = 0
        conta1.iNome = "Marco Neves"
    End Sub

    Private Sub btnEfetuar_Deposito_Click(sender As Object, e As EventArgs)
        conta1.movimentos.Add(New movimentos)
        conta1.movimentos(0).idata = Date.Today
        conta1.movimentos(0).itipo = "D"
        conta1.movimentos(0).ivalor = 1000
        'atualizar o saldo
        conta1.Saldo = conta1.Saldo + conta1.movimentos(0).ivalor
    End Sub

    Private Sub btnMostra_Movimentos_Click(sender As Object, e As EventArgs)
        MsgBox(conta1.movimentos.Count)
    End Sub

    Private Sub btnEfetua_Levantamento_Click(sender As Object, e As EventArgs)
        conta1.movimentos.Add(New movimentos)
        conta1.movimentos(1).idata = Date.Today
        conta1.movimentos(1).itipo = "L"
        conta1.movimentos(1).ivalor = 800
        conta1.Saldo = conta1.Saldo - conta1.movimentos(1).ivalor
    End Sub

    Private Sub btnMostra_Saldo_Click(sender As Object, e As EventArgs)
        MsgBox(conta1.Saldo)
    End Sub

    Private Sub btnMostra_Movimentos_Click_1(sender As Object, e As EventArgs) Handles btnMostra_Movimentos.Click

    End Sub

    Private Sub frmContaBanco_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
Public Class contabancaria
    Dim iNconta As String
    Public iNome As String
    Dim iData_abertura As Date = Date.Today
    Dim iSaldo As Double
    Public movimentos As New ArrayList ' definição de um array list para guardar os movimentos realizados numa determinada conta bancária'

    Property Nconta As String
        Get
            Nconta = iNconta
        End Get
        Set(value As String)
            iNconta = value
        End Set
    End Property
    Property Saldo As Double
        Get
            Saldo = iSaldo
        End Get
        Set(value As Double)
            iNome = value
        End Set
    End Property

    ReadOnly Property Data_abertura As Date
        Get
            Data_abertura = iData_abertura
        End Get
    End Property
End Class
Public Class movimentos
    Public idata As Date
    Public itipo As Char
    Public ivalor As Double
End Class




