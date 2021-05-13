Imports data

Public Class authController

    ''instancia de la clase auth de la capa datos
    Dim objAuth As auth = New auth()
    Public Function getUser() As DataSet
        objAuth.user()
        Return objAuth.ds
    End Function


    ''obtiene la contraseña de la base de datos
    Public Function getPass() As DataSet
        objAuth.pass()
        Return objAuth.ds
    End Function

    ''valida los datos obtenidos, debuelve un valor booleano
    Public Function validarDatos(name As String, pass As String)
        Dim rs As Boolean = False
        If name.Equals(getUser.Tables("rol").Rows(0).Item(0)) Then
            If pass.Equals(getPass.Tables("rol").Rows(1).Item(1)) Then
                rs = True
            End If
        End If
        Return rs
    End Function
End Class
