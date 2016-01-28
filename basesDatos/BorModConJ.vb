Public Class BorModConJ

    Private juego As New Juegos
    Private plata As New Platformas

    Private Sub BorModConJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'rellenar el combo box y ,muestra el nombre teniendo el valor del id
        ComboBox1.DataSource = plata.Rellenar
        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "Cod_Plata"

    End Sub

    Private Sub btConsulta_Click(sender As Object, e As EventArgs) Handles btConsulta.Click
        If tbCodB.Text.Equals("") Then
            MessageBox.Show("Necesario introducir el Codigo")
        Else
            juego.codigo = Convert.ToInt32(tbCodB.Text)
            Dim row As DataTable
            row = juego.Seleccionar
            If row.Rows.Count = 0 Then
                MessageBox.Show("No me consta")
            Else
                tbEstuB.Text = row.Rows(0).Item(4)
                tbTipoB.Text = row.Rows(0).Item(2)
                tbTituB.Text = row.Rows(0).Item(3)
                ComboBox1.SelectedValue = row.Rows(0).Item(1)
            End If
        End If





    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        If tbCodB.Text.Equals("") Then
            MessageBox.Show("Necesario introducir el Codigo")
        Else
            juego.codigo = Convert.ToInt32(tbCodB.Text)
            limpiar()

            If (juego.Borrar) Then
                MessageBox.Show("Borrado")
            Else
                MessageBox.Show("No se a Borrado")
            End If
        End If


    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        If tbCodB.Text.Equals("") Or tbEstuB.Text.Equals("") Or tbTituB.Text.Equals("") Or tbTipoB.Text.Equals("") Then
            MessageBox.Show("Necesario introducir TODOS los campos")
        Else
            juego.codigo = Convert.ToInt32(tbCodB.Text)
            juego.estudio = tbEstuB.Text
            juego.Plataforma = ComboBox1.SelectedValue
            juego.titulo = tbTituB.Text
            juego.Tipo = tbTipoB.Text
            limpiar()

            If (juego.Modificar) Then
                MessageBox.Show("Modificado")
            Else
                MessageBox.Show("No Modificado")
            End If
        End If



    End Sub

    Private Sub btVolverB_Click(sender As Object, e As EventArgs) Handles btVolverB.Click
        Dispose()

    End Sub
    Public Sub limpiar()
        tbCodB.Text = ""
        tbTituB.Text = ""
        tbEstuB.Text = ""
        tbTipoB.Text = ""
    End Sub
    Public Sub limpiarCodigo()
        tbCodB.Text = ""
    End Sub
End Class