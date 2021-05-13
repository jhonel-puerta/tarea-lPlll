Imports data

Public Class cnAlumnos
    Public conexion As conexion = New conexion()
    ''Public objAlumnos As conexion = New conexion()

    Public Sub conectar()
        conexion.conectar()
    End Sub

    ''funcion que lista todos los alumnos de la db
    Public Function listaAlumnos() As DataSet
        conexion.conectar()
        conexion.Listar()
        Return conexion.ds
    End Function


    ''elimina
    Public Sub eliminar(id As String)
        Try
            conexion.conectar()
            conexion.eliminar(id)
            Console.WriteLine("eliminado correctamente el id: " & id)
        Catch ex As Exception
            MsgBox("error: " & ex.Message)
        Finally

        End Try
    End Sub


    ''obtiene el usuario de la db filtrada por su id
    Public Function getUserById(id As String) As DataSet
        conexion.conectar()
        Try
            conexion.listarById(id)
        Catch ex As Exception
            Console.WriteLine("no se pudo obtener el userID -> capa negocio")
        Finally

        End Try
        Return conexion.ds
    End Function

    ''actualiza
    Public Function actualiza(
                        n1 As String,
                       n2 As String,
                       ap1 As String,
                       ap2 As String,
                       tel As String,
                       cel As String,
                       direccion As String,
                       email As String,
                       fechaN As String,
                       obsb As String,
                       id As String)
        conexion.conectar()
        Dim statusQuery As Boolean
        Try
            If (conexion.actualizar(n1, n2, ap1, ap2, tel, cel, direccion, email, fechaN, obsb, id)) Then
                statusQuery = True
            Else
                statusQuery = False
            End If
        Catch ex As Exception
            Console.WriteLine("error: capa negocio -> " & ex.Message)
        Finally

        End Try

        Return statusQuery
    End Function

    ''crea un nuevo alumno
    Public Function crear(
                        n1 As String,
                       n2 As String,
                       ap1 As String,
                       ap2 As String,
                       tel As String,
                       cel As String,
                       direccion As String,
                       email As String,
                       fechaN As String,
                       obsb As String)
        conexion.conectar()
        Dim statusQuery As Boolean
        Try
            If (conexion.agregar(n1, n2, ap1, ap2, tel, cel, direccion, email, fechaN, obsb)) Then
                statusQuery = True
            Else
                statusQuery = False
            End If
        Catch ex As Exception
            Console.WriteLine("error: capa negocio crear -> " & ex.Message)
        Finally

        End Try
        Return statusQuery
    End Function

End Class

