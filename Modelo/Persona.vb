Public Class Persona

    Private _ID As Integer
    Private _Nombre As String
    Private _Ciudad As String
    Private _Correo As String

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Ciudad() As String
        Get
            Return _Ciudad
        End Get
        Set(value As String)
            _Ciudad = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return ID.ToString + " " + Nombre
    End Function

End Class
