
Public Class alumno
    Private nombre As String
    Private segundo_nombre As String
    Private primer_apellido As String
    Private segundo_apellido As String
    Private telefono As String
    Private celular As String
    Private direccion As String
    Private email As String
    Private fecha_nacimiento As String
    Private observaciones As String

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Segundo_nombre1 As String
        Get
            Return segundo_nombre
        End Get
        Set(value As String)
            segundo_nombre = value
        End Set
    End Property

    Public Property Primer_apellido1 As String
        Get
            Return primer_apellido
        End Get
        Set(value As String)
            primer_apellido = value
        End Set
    End Property

    Public Property Segundo_apellido1 As String
        Get
            Return segundo_apellido
        End Get
        Set(value As String)
            segundo_apellido = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property Celular1 As String
        Get
            Return celular
        End Get
        Set(value As String)
            celular = value
        End Set
    End Property

    Public Property Direccion1 As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property Fecha_nacimiento1 As String
        Get
            Return fecha_nacimiento
        End Get
        Set(value As String)
            fecha_nacimiento = value
        End Set
    End Property

    Public Property Observaciones1 As String
        Get
            Return observaciones
        End Get
        Set(value As String)
            observaciones = value
        End Set
    End Property
End Class
