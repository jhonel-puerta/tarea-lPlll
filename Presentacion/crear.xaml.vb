Imports bussines

Public Class crear
    Dim objBusines As cnAlumnos = New cnAlumnos

    Private Sub Border_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
        Me.DragMove()
    End Sub

    Private Sub Window_Initialized(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCerrar_Click() Handles btnCerrar.Click
        Close()
        Dim winMain As MainWindow = New MainWindow()
        winMain.Show()
    End Sub

    Private Sub crear(sender As Object, e As RoutedEventArgs)

        Dim n1, n2, ap1, ap2, tel, cel, direccion, email, fechaN, observaciones, idUs As String
        n1 = Me.primerN.Text
        n2 = Me.segundoN.Text
        ap1 = Me.primerA.Text
        ap2 = Me.segundoA.Text
        tel = Me.telefono.Text
        cel = Me.celular.Text
        direccion = Me.direccion.Text
        email = Me.email.Text
        fechaN = Me.fecha_n.Text
        observaciones = Me.observaciones.Text

        If objBusines.crear(n1, n2, ap1, ap2, tel, cel, direccion, email, fechaN, observaciones) Then
            MsgBox("Alumno agregado correctamente!")
        Else
            MsgBox("error")
        End If

        ''llamada a la funcion para cerrar la ventana
        btnCerrar_Click()
    End Sub
End Class
