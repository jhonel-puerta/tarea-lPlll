Imports bussines

Public Class editar
    Dim objBusines As cnAlumnos = New cnAlumnos

    Private Sub Border_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
        Me.DragMove()
    End Sub

    Private Sub Window_Initialized(sender As Object, e As EventArgs)
        Me.primerN.Text = fillData(1)
        Me.segundoN.Text = fillData(2)
        Me.primerA.Text = fillData(3)
        Me.segundoA.Text = fillData(4)
        Me.telefono.Text = fillData(5)
        Me.celular.Text = fillData(6)
        Me.direccion.Text = fillData(7)
        Me.email.Text = fillData(8)
        Me.fecha_n.Text = fillData(9)
        Me.observaciones.Text = fillData(10)

        ''establece el nomrbe del header:
        Me.header_name.Content = fillData(1)
    End Sub

    ''debuelve el dato que se le pide al dataset filtrado por id    
    Public Function fillData(item As Integer)
        Dim idUs As String = Module1.idUser
        Dim rs As String = objBusines.getUserById(idUs).Tables("alumnos").Rows(0).ItemArray(item).ToString
        Return rs
    End Function

    Private Sub btnCerrar_Click() Handles btnCerrar.Click
        Close()
        Dim winMain As MainWindow = New MainWindow()
        winMain.Show()
    End Sub

    Private Sub actualizar(sender As Object, e As RoutedEventArgs)

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
        idUs = Module1.idUser
        If (objBusines.actualiza(n1, n2, ap1, ap2, tel, cel, direccion, email, fechaN, observaciones, idUs)) Then
            MsgBox("actualizado correctamene")
        Else
            MsgBox("error")
        End If

        ''llamada a la funcion para cerrar la ventana
        btnCerrar_Click()
    End Sub
End Class

