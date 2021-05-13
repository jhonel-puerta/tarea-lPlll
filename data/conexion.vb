Imports System.Data
Imports System.Data.SqlClient

Public Class conexion
    Public connectionLink As SqlConnection = New SqlConnection(My.Settings.conexion)
    Public ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private cmb As SqlCommandBuilder

    ''funcion que permite conectarse con la db
    Sub conectar()
        Try
            connectionLink.Open()
            Console.WriteLine("conexion exitosa")
        Catch ex As Exception
            Console.WriteLine(ex.Message)

        End Try
    End Sub

    ''funcion puede llamarse para cerrar la conexion
    Sub cerrarConexion()
        connectionLink.Close()
        Console.WriteLine("conexion cerrada exitosamente!")
    End Sub

    Sub eliminar(ByVal id As String)
        Try
            Dim comand As SqlCommand = New SqlCommand("delete from alumnos where id='" & id & "'", connectionLink)
            comand.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("error al intentar eliminar: " & ex.Message)
        End Try
    End Sub

    ''funcion para actualizar alumnos
    Public Function actualizar(n1 As String,
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

        Dim status As Boolean
        Try
            Dim sql As String = "update alumnos set primer_nombre='" & n1 & "',segundo_nombre=' " & n2 & " ',primer_apellido='" & ap1 & "',segundo_apellido='" & ap2 & "',telefono='" & tel & "',celular='" & cel & "',direccion='" & direccion & "',email='" & email & "',fecha_nacimiento='" & fechaN & "',observaciones='" & obsb & "' where id='" & id & "'"
            Dim command As SqlCommand = New SqlCommand(sql, connectionLink)

            command.ExecuteNonQuery()

            If (command.ExecuteNonQuery() >= 1) Then
                status = True
            Else
                status = False
            End If

        Catch ex As Exception
            Console.WriteLine("error al intentar actualizar: " & ex.Message)
        End Try

        Return status
    End Function

    '' lista alumnos por id
    Sub listarById(id As String)
        Dim tabla As String = "alumnos"
        Dim sql As String = "select * from alumnos where id= " & id
        da = New SqlDataAdapter(sql, connectionLink)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub


    ''lista de todos los alumnos 

    Sub Listar()
        Dim tabla As String = "alumnos"
        Dim sql As String = "select * from alumnos"
        da = New SqlDataAdapter(sql, connectionLink)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    ''proceso que permite agregar un nuevo usuario
    Public Function agregar(n1 As String,
                   n2 As String,
                   ap1 As String,
                   ap2 As String,
                   tel As String,
                   cel As String,
                   direccion As String,
                   email As String,
                   fechaN As String,
                   obsb As String)

        Dim status As Boolean
        Try
            Dim sql As String = "insert into alumnos (primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,telefono,celular,direccion,email,fecha_nacimiento,observaciones) values ('" & n1 & "','" & n2 & "','" & ap1 & "','" & ap2 & "','" & tel & "','" & cel & "','" & direccion & "','" & email & "','" & fechaN & "','" & obsb & "');"
            Dim command As SqlCommand = New SqlCommand(sql, connectionLink)
            command.ExecuteNonQuery()
            If (command.ExecuteNonQuery() >= 1) Then
                status = True
            Else
                status = False
            End If
        Catch ex As Exception
            Console.WriteLine("error al intentar agregar alumno: " & ex.Message)
        End Try

        Return status
    End Function
End Class
