Imports data

Public Class alumnosController
    Dim conexion As conexion = New conexion()

    Sub listaAlumnos()
        conexion.conectar()
        conexion.Listar()
        conexion.cerrarConexion()
    End Sub
End Class
