Public Class Class_Main
    Public StoredTMP As New List(Of Class_Main)()
    Public Property _id As Integer 'id
    Public Property _data As Date 'data
    Public Property _valor As Decimal 'Temperatura
    Public Property _tipo As Boolean 'Se está entre 10 a 20 graus
    Public Sub New()
    End Sub
    Public Sub New(ByVal _id As Integer, ByVal _data As Date, ByVal _valor As Decimal, ByVal _tipo As Boolean)
        Me._id = _id
        Me._data = _data
        Me._valor = _valor
        Me._tipo = _tipo
    End Sub
End Class
