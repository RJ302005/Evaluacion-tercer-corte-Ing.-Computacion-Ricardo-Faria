Imports System.Data.OleDb

Public Class Form1
    Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\LABPC\Desktop\Evaluación Ricardo Faría\WindowsApplication1\WindowsApplication1/Bilioteca.mdb"
    Dim conn As New OleDbConnection(connString)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable

    ' Evento que se ejecuta cuando el formulario carga
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar ComboBox con opciones
        cmbOperaciones.Items.Add("Agregar Libro")
        cmbOperaciones.Items.Add("Modificar Libro")
        cmbOperaciones.Items.Add("Eliminar Libro")
        cmbOperaciones.Items.Add("Prestar Libro")
        cmbOperaciones.Items.Add("Devolver Libro")
        cmbOperaciones.SelectedIndex = 0 ' Selecciona la primera opción por defecto
        LoadData()
    End Sub

    ' Método para cargar datos
    Private Sub LoadData()
        Try
            conn.Open()
            adapter = New OleDbDataAdapter("SELECT * FROM Libros", conn)
            dt = New DataTable()
            adapter.Fill(dt)
            LibrosDataGridView.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Método que se ejecuta cuando se presiona el botón "Ejecutar"
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        ' Obtener la operación seleccionada en el ComboBox
        Dim operacionSeleccionada As String = cmbOperaciones.SelectedItem.ToString()

        Select Case operacionSeleccionada
            Case "Agregar Libro"
                ' Llamar al método para agregar un libro
                AgregarLibro()

            Case "Modificar Libro"
                ' Llamar al método para modificar un libro
                ModificarLibro()

            Case "Eliminar Libro"
                ' Llamar al método para eliminar un libro
                EliminarLibro()

            Case "Prestar Libro"
                ' Llamar al método para prestar un libro
                PrestarLibro()

            Case "Devolver Libro"
                ' Llamar al método para devolver un libro
                DevolverLibro()

            Case Else
                MessageBox.Show("Seleccione una operación válida")
        End Select
    End Sub

    ' Métodos para las operaciones en la biblioteca

    ' Método para agregar un libro
    Private Sub AgregarLibro()
        Try
            conn.Open()
            cmd = New OleDbCommand("INSERT INTO Libros (Nombre, Autor, Editorial, Disponible) VALUES (@Nombre, @Autor, @Editorial, @Disponible)", conn)
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@Autor", txtAutor.Text)
            cmd.Parameters.AddWithValue("@Editorial", txtEditorial.Text)
            cmd.Parameters.AddWithValue("@Disponible", True) ' Nuevo libro está disponible por defecto
            cmd.ExecuteNonQuery()
            conn.Close()
            LoadData()
            MessageBox.Show("Libro agregado exitosamente")
        Catch ex As Exception
            MessageBox.Show("Error al agregar el libro: " & ex.Message)
        End Try
    End Sub

    ' Método para modificar un libro
    Private Sub ModificarLibro()
        Dim libroSeleccionado As DataRowView = CType(LibrosDataGridView.CurrentRow.DataBoundItem, DataRowView)
        If libroSeleccionado IsNot Nothing Then
            Try
                conn.Open()
                cmd = New OleDbCommand("UPDATE Libros SET Nombre=@Nombre, Autor=@Autor, Editorial=@Editorial WHERE ID=@ID", conn)
                cmd.Parameters.AddWithValue("@ID", libroSeleccionado("ID"))
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@Autor", txtAutor.Text)
                cmd.Parameters.AddWithValue("@Editorial", txtEditorial.Text)
                cmd.ExecuteNonQuery()
                conn.Close()
                LoadData()
                MessageBox.Show("Libro modificado exitosamente")
            Catch ex As Exception
                MessageBox.Show("Error al modificar el libro: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Seleccione un libro primero")
        End If
    End Sub

    ' Método para eliminar un libro
    Private Sub EliminarLibro()
        Dim libroSeleccionado As DataRowView = CType(LibrosDataGridView.CurrentRow.DataBoundItem, DataRowView)
        If libroSeleccionado IsNot Nothing Then
            Try
                conn.Open()
                cmd = New OleDbCommand("DELETE FROM Libros WHERE ID=@ID", conn)
                cmd.Parameters.AddWithValue("@ID", libroSeleccionado("ID"))
                cmd.ExecuteNonQuery()
                conn.Close()
                LoadData()
                MessageBox.Show("Libro eliminado exitosamente")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el libro: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Seleccione un libro primero")
        End If
    End Sub

    ' Método para prestar un libro
    Private Sub PrestarLibro()
        Dim libroSeleccionado As DataRowView = CType(LibrosDataGridView.CurrentRow.DataBoundItem, DataRowView)
        If libroSeleccionado IsNot Nothing Then
            Try
                If Not libroSeleccionado("Disponible") Then
                    MessageBox.Show("El libro ya está prestado")
                Else
                    conn.Open()
                    cmd = New OleDbCommand("UPDATE Libros SET Disponible=@Disponible WHERE ID=@ID", conn)
                    cmd.Parameters.AddWithValue("@ID", libroSeleccionado("ID"))
                    cmd.Parameters.AddWithValue("@Disponible", False)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    LoadData()
                    MessageBox.Show("Libro prestado exitosamente")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al prestar el libro: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Seleccione un libro primero")
        End If
    End Sub

    ' Método para devolver un libro
    Private Sub DevolverLibro()
        Dim libroSeleccionado As DataRowView = CType(LibrosDataGridView.CurrentRow.DataBoundItem, DataRowView)
        If libroSeleccionado IsNot Nothing Then
            Try
                If libroSeleccionado("Disponible") Then
                    MessageBox.Show("El libro no estaba prestado")
                Else
                    conn.Open()
                    cmd = New OleDbCommand("UPDATE Libros SET Disponible=@Disponible WHERE ID=@ID", conn)
                    cmd.Parameters.AddWithValue("@ID", libroSeleccionado("ID"))
                    cmd.Parameters.AddWithValue("@Disponible", True)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    LoadData()
                    MessageBox.Show("Libro devuelto exitosamente")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al devolver el libro: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Seleccione un libro primero")
        End If
    End Sub

    ' Evento para seleccionar un libro y mostrar los datos en los campos
    Private Sub LibrosDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles LibrosDataGridView.SelectionChanged
        If LibrosDataGridView.CurrentRow IsNot Nothing Then
            Dim libroSeleccionado As DataRowView = CType(LibrosDataGridView.CurrentRow.DataBoundItem, DataRowView)
            If libroSeleccionado IsNot Nothing Then
                txtNombre.Text = libroSeleccionado("Nombre").ToString()
                txtAutor.Text = libroSeleccionado("Autor").ToString()
                txtEditorial.Text = libroSeleccionado("Editorial").ToString()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperaciones.SelectedIndexChanged

    End Sub
End Class
