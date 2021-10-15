Option Explicit Off
Module MoDVF

    Private dbTaxaAnual As Double = 0
    Private iAnos As Integer = 0
    Private decValorInicial As Double = 0
    Private decDepositoMensal As Double = 0



    Private Sub AlimentaVF()
        'escreve uma linha no console'
        Console.WriteLine()
        'recebe os valores e armazena em cada variavel'
        decValorInicial = CDec(ObtemDados(("Valor Inicial = ")))
        dbTaxaAnual = CDbl(ObtemDados(("Taxa Anual = ")))
        decDepositoMensal = CDec(ObtemDados("Deposito Mensal = "))
        iAnos = CInt(ObtemDados("Periodo do investimento = "))
    End Sub
    Function CalculaVF(ByVal TaxaAnual As Double, ByVal Anos As Integer,
                               ByVal DepositoMensal As Double, ByVal ValorInicial As Double) As Double
        'vamos utilizar a taxa anual e dividir por 1200 para obtermos a porcetagem mensal 
        Dim decTaxaMensal As Double = CDec(TaxaAnual / 1200)

        'calculo do numero de meses
        Dim Imeses As Integer = (Anos * 12)

        'Declaração da variavel temporaria e da variavel que vai armazenar o valor do retorno
        Dim decTemp As Double
        Dim decRetorno As Double

        'Uso da variavel temporaria e da variavel de retorno
        decTemp = CDec((1 + decTaxaMensal) ^ Imeses)
        decRetorno = CDec(DepositoMensal * ((decTemp - 1) / decTaxaMensal) + (ValorInicial * decTemp))
        Return decRetorno
    End Function
    Private Sub MostraVF()
        Console.WriteLine()
        Console.WriteLine("Com um valor inicial de " & decValorInicial & " EUR ")
        Console.WriteLine("e depositos mensais de " & decDepositoMensal & " EUR")
        Console.WriteLine("por um periodo de {0} anos", iAnos)
        Console.WriteLine("a uma taxa de {0}%", dbTaxaAnual)
        Console.WriteLine("Terá um valor futuro de: " & Resultado & " EUR")
        Console.ReadLine()


    End Sub

    Function ObtemDados(ByVal msg As String) As String
        Console.WriteLine(msg)
        Return Console.ReadLine
    End Function
    Sub Main()
        AlimentaVF()
        CalculaVF(dbTaxaAnual, iAnos, decDepositoMensal, decValorInicial)
        MostraVF()
    End Sub
End Module
