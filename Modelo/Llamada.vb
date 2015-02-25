Public Class Llamada

    Private _ID As Integer
    Private _Persona As Persona
    Private _Fecha As Date

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Persona As Persona
        Get
            Return _Persona
        End Get
        Set(value As Persona)
            _Persona = value
        End Set
    End Property
    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return ID.ToString + " " + Persona.ToString
    End Function
End Class
