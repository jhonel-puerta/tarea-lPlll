Imports bussines

Public Class loging
    Private Sub Border_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
        Me.DragMove()
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Module1.nameUser = txtName.Text.ToString
        Module1.password = FloatingPasswordBox.Password.ToString

        validarDatos()
    End Sub

    Private Sub Button_Click_1()
        Close()
    End Sub

    Sub validarDatos()

        Dim datos As authController = New authController()

        Dim name As String = txtName.Text
        Dim pass As String = FloatingPasswordBox.Password

        If (datos.validarDatos(name, password)) Then
            Dim main As MainWindow = New MainWindow()
            main.Show()
            Button_Click_1()
        Else
            MsgBox("Contraseña Incorrecta")
        End If
    End Sub
End Class
