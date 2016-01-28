Public Class ModificarP
    Dim plata As New Platformas

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text.Equals("") Then
            MessageBox.Show("Necesario rellenar los campos")
        Else
            plata.Codigo = Convert.ToInt32(TextBox1.Text)
            Dim tabla As DataTable

            tabla = plata.Seleccionar()
            If tabla.Rows.Count = 0 Then

                MessageBox.Show("No me consta")
            Else
                TextBox2.Text = tabla.Rows(0).Item(0)

            End If
        End If





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text.Equals("") Then
            MessageBox.Show("Necesario rellenar los campos")
        Else
            plata.Codigo = TextBox1.Text
            If (plata.Borrar) Then
                MessageBox.Show("Borrado")
                limpiar()
            Else
                MessageBox.Show("No borrado")
                limpiarTodo()


            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text.Equals("") Or TextBox2.Text.Equals("") Then
            MessageBox.Show("Necesario rellenar los campos")
        Else
            plata.Codigo = TextBox1.Text
            plata.nombre = TextBox2.Text

            If (plata.Modificar) Then
                MessageBox.Show("Modificado")
                limpiarTodo()
            Else
                MessageBox.Show("No modificado")

            End If
        End If


    End Sub
    Private Sub limpiarTodo()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub limpiar()
        TextBox1.Text = ""
    End Sub
End Class