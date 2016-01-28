Public Class AñadirJ
    Private juego As New Juegos
    Private plata As New Platformas

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tbCodigo.BackColor = Color.White
        tbTitulo.BackColor = Color.White
        tbEstudio.BackColor = Color.White
        tbTipo.BackColor = Color.White
        If tbCodigo.Text.Equals("") Or tbTitulo.Text.Equals("") Or tbEstudio.Text.Equals("") Or tbTipo.Text.Equals("") Then
            MessageBox.Show("Necesario rellenar TODOS los campos")
            If tbCodigo.Text.Equals("") Then
                tbCodigo.BackColor = Color.Red
            End If
            If tbTitulo.Text.Equals("") Then
                tbTitulo.BackColor = Color.Red
            End If
            If tbEstudio.Text.Equals("") Then
                tbEstudio.BackColor = Color.Red

            End If
            If tbTipo.Text.Equals("") Then
                tbTipo.BackColor = Color.Red
            End If
        Else
            juego.codigo = tbCodigo.Text
            juego.titulo = tbTitulo.Text
            juego.estudio = tbEstudio.Text
            juego.Tipo = tbTipo.Text
            juego.Plataforma = Convert.ToInt32(ComboBox1.SelectedValue)
            limpiar()

            If (juego.AñadirJuego()) Then
                MessageBox.Show("Añadido")

            Else
                MessageBox.Show("No Añadido")
                tbCodigo.BackColor = Color.Red
                tbCodigo.Text = "Codigo Repetido"
            End If

        End If





    End Sub

    Private Sub tbCodigo_TextChanged(sender As Object, e As EventArgs) Handles tbCodigo.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub AñadirJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.DataSource = plata.Rellenar
        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "Cod_Plata"




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub
    Public Sub limpiar()
        tbCodigo.Text = ""
        tbTitulo.Text = ""
        tbEstudio.Text = ""
        tbTipo.Text = ""
    End Sub
End Class