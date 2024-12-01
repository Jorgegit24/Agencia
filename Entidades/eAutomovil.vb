Public Class eAutomovil
    Private _automovil As Integer
    Private _marca As String
    Private _modelo As String
    Private _anio As Integer
    Private _precio As Integer

    Public Property Automovil As Integer
        Get
            Return _automovil
        End Get
        Set(value As Integer)
            _automovil = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property Modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Public Property Anio As Integer
        Get
            Return _anio
        End Get
        Set(value As Integer)
            _anio = value
        End Set
    End Property

    Public Property Precio As Integer
        Get
            Return _precio
        End Get
        Set(value As Integer)
            _precio = value
        End Set
    End Property
End Class
