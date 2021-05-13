Imports bussines

Class MainWindow

    ''instancia de la clase cnalumnos - capa negocio
    Public cnAlumno As cnAlumnos = New cnAlumnos

    ''proceso que cierra la ventana al precionar el boton cerrar
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Close()
    End Sub

    ''se ejecuta cuando inicia la ventana mainWindow
    Private Sub Window_Initialized(sender As Object, e As EventArgs)
        Me.mostrarDatos()
        ''desactivando botones
        btnEditar.IsEnabled = False
        btnEliminar.IsEnabled = False
    End Sub

    'Private Sub eliminar_Click(sender As Object, e As RoutedEventArgs) Handles eliminar.Click

    'End Sub

    ''funcion que se ejecuta cuando el mainwindow esta desactivado
    'Private Sub Window_Deactivated(sender As Object, e As EventArgs)
    '    Me.mostrarDatos()
    'End Sub

    ''minimisa la ventana mainwindow
    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Me.WindowState = WindowState.Minimized
    End Sub


    ''funcion que rellena el gridview será llamado en l afuncion que se ejecuta al inicializar la ventana
    Sub mostrarDatos()
        cnAlumno.listaAlumnos.Clear() ''limpia el gridview
        dgvAlumnos.ItemsSource = cnAlumno.listaAlumnos().Tables("alumnos").DefaultView ''carga los datos al gridview
    End Sub


    'Private Sub dgvAlumnos_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dgvAlumnos.SelectionChanged

    'End Sub

    ''este proceso se ejecutará al hacer doble clic en el gridview 
    Private Sub dgvAlumnos_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles dgvAlumnos.MouseDoubleClick
        '' MsgBox("hola tu id is: " & dgvAlumnos.CurrentCell.Item(0).ToString)
        btnEliminar.IsEnabled = True
        btnEditar.IsEnabled = True

    End Sub

    Private Sub dgvAlumnos_MouseEnter(sender As Object, e As MouseEventArgs) Handles dgvAlumnos.MouseEnter
        ''con este evento controlamos cuando el usuario pasa el mouse por el datagrid
        ''Dim mycolor As Color = New Color()
        ''mycolor = Color.FromArgb(255, 0, 255, 0)
        dgvAlumnos.Background = Brushes.Lavender
        cardEditar.Opacity = 20
    End Sub

    ''cuando sacamos el mouse fuera del area que pretenece al gridview
    Private Sub dgvAlumnos_MouseLeave(sender As Object, e As MouseEventArgs) Handles dgvAlumnos.MouseLeave
        ''btnactualiza.IsEnabled = statusBtn
        dgvAlumnos.Background = Brushes.Transparent

    End Sub

    ''elimina un alumno obteniendo su id
    Private Sub btnEliminar_Click(sender As Object, e As RoutedEventArgs) Handles btnEliminar.Click
        Dim id As String = dgvAlumnos.CurrentCell.Item(0).ToString
        cnAlumno.eliminar(id)
        MsgBox("eliminado correctamente")
    End Sub

    ''se ejecuta al hacer clic en el boton eliminar - envia el id de el alumno seleccionado al module y habre una nueva ventana 'editar'
    Private Sub btnEditar_Click(sender As Object, e As RoutedEventArgs) Handles btnEditar.Click
        ''envia los datos al module
        Module1.idUser = getIdUser()
        Dim windowEdit As editar = New editar()
        windowEdit.Show()
        Hide()
    End Sub

    ''obtener el id de un usuario desde el gridview
    Public Function getIdUser() As String
        Return dgvAlumnos.CurrentCell.Item(0).ToString
    End Function

    ''abre una nueva ventana para crear un nuevo alumno
    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim crear As crear = New crear()
        crear.Show()
        Hide()

    End Sub
End Class
