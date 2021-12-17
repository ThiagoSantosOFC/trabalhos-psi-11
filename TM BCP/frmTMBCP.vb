Public Class frmTMBCP


End Class
Public Class Contas
    Dim iNconta As String
    Public iNome As String
    Dim iData_abertura As Date = Date.Today
    Dim iSaldo As Double
    Public movimentos As New ArrayList ' definição de um array list para guardar os movimentos realizados numa
    ' determinada conta bancária'

    s

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
Public Class Movimentos
    Public idata As Date
    Public itipo As Char
    Public ivalor As Double
End Class
