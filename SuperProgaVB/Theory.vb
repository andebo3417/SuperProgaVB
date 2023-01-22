Public Class Theory
    Private par_ As Integer
    Private theory_ As String

    Public Property par As Integer
        Get
            Return par_
        End Get
        Set
            par_ = Value
        End Set
    End Property

    Public Property theory As String
        Get
            Return theory_
        End Get
        Set
            theory_ = Value
        End Set
    End Property

    Sub New()
        par = 0
        theory = ""
    End Sub

End Class
