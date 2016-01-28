Public Class añadirP
    Private plat As New Platformas
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub añadirP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Codigo"
        Label2.Text = "Nombre"
        Button1.Text = "Añadir"
        Button2.Text = "Volver"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        plat.Codigo = Integer.Parse(TextBox1.Text)
        plat.nombre = TextBox2.Text

        If (plat.Añadir()) Then
            MessageBox.Show("Añadido")
        Else
            MessageBox.Show("No añadido")
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub
End Class