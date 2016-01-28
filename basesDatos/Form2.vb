Public Class Form2
    Dim j As New Juegos
    Dim tabla As New DataTable

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked Then
            CheckBox6.Checked = False
            j.codBProp = True
            tabla = j.BuscarPor()
            DataGridView1.DataSource = tabla


        Else
            j.codBProp = False
            tabla = j.BuscarPor()
            DataGridView1.DataSource = tabla
        End If


    End Sub
    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked Then
            CheckBox6.Checked = False
            j.nombreProp = True
            tabla = j.BuscarPor()
            DataGridView1.DataSource = tabla



        Else
            j.nombreProp = False
            tabla = j.BuscarPor()
            DataGridView1.DataSource = tabla
        End If

    End Sub


    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles CheckBox3.Click
        If CheckBox3.Checked Then
            CheckBox6.Checked = False
            j.codPBprop = True
            tabla = j.BuscarPor()
            DataGridView1.DataSource = tabla


        Else
            j.codPBprop = False
            tabla = j.BuscarPor()
            DataGridView1.DataSource = tabla
        End If

    End Sub

    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles CheckBox4.Click
        If CheckBox4.Checked Then
            CheckBox6.Checked = False
            j.estProp = True
            tabla = j.BuscarPor()
            DataGridView1.DataSource = tabla


        Else
            j.estProp = False
            tabla = j.BuscarPor()
            DataGridView1.DataSource = tabla
        End If

    End Sub


    Private Sub CheckBox5_Click(sender As Object, e As EventArgs) Handles CheckBox5.Click
        If CheckBox5.Checked Then
            CheckBox6.Checked = False
            j.tipProp = True
            tabla = j.BuscarPor()
            DataGridView1.DataSource = tabla


        Else
            j.tipProp = False
            tabla = j.BuscarPor()
            DataGridView1.DataSource = tabla
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabla = j.Cargar()
        DataGridView1.DataSource = tabla

    End Sub



    Private Sub CheckBox6_Click(sender As Object, e As EventArgs) Handles CheckBox6.Click
        tabla = j.Cargar()
        DataGridView1.DataSource = tabla
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False


    End Sub
End Class