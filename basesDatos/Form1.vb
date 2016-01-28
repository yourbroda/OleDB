Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Conexion.Conexion) Then
            MsgBox("Conexion realizada")
        Else
            MsgBox("Conexion no realizada")

        End If

    End Sub

    Private Sub JuegosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuegosToolStripMenuItem.Click

    End Sub

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click

        Dim a As New AñadirJ()
        a.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim a As New BorModConJ()
        a.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim a As New BorModConJ()
        a.Show()
    End Sub

    Private Sub ModicarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModicarToolStripMenuItem.Click
        Dim a As New BorModConJ()
        a.Show()
    End Sub

    Private Sub AñadirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem1.Click
        Dim p As New añadirP
        p.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem1.Click
        Dim a As New ModificarP
        a.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        Dim a As New ModificarP
        a.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim a As New ModificarP
        a.Show()
    End Sub

    Private Sub ConsultarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarTodosToolStripMenuItem.Click
        Dim a As New Form2
        a.Show()
    End Sub
End Class
