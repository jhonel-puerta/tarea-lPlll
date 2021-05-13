Imports System.Data
Imports System.Data.SqlClient

Public Class auth
    Dim conexion As conexion = New conexion()
    Public ds As DataSet = New DataSet
    Dim da As SqlDataAdapter
    Dim cmb As SqlCommandBuilder


    ''obtiene el nombre de un administrador de la db
    Public Sub user()
        conexion.conectar()
        Try
            Dim sql As String = "select nombre from rol"
            Dim table As String = "rol"
            da = New SqlDataAdapter(sql, conexion.connectionLink)
            cmb = New SqlCommandBuilder(da)
            da.Fill(ds, table)
        Catch ex As Exception
            MsgBox("error" & ex.Message)
        Finally
            conexion.cerrarConexion()
        End Try
    End Sub

    ''obtiene la contraseña de un administrados / en una proxima actualizacion modificaremos el sub proceso para que nos debuelva de un administrador en especifico en este caso solo tenemos 1
    Public Sub pass()
        conexion.conectar()
        Try
            Dim sql As String = "select contrasena from rol"
            Dim table As String = "rol"
            da = New SqlDataAdapter(sql, conexion.connectionLink)
            cmb = New SqlCommandBuilder(da)
            da.Fill(ds, table)
        Catch ex As Exception
            MsgBox("error" & ex.Message)
        Finally

        End Try
    End Sub
End Class
