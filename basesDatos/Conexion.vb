Imports System.Data.SqlClient
Module Conexion

    Property ocCon As New SqlConnection


    Public Function Conexion() As Boolean

        'Funcion de conexion 

        Dim strCadConexion As String
        Dim strNomBD As String

        strNomBD = "Data Source=AIDAN\SQLEXPRESS;Initial Catalog=Videojuegos;Integrated Security=True"
        'strCadConexion = ".NET Framework Data Provider for SQL Server;Data Source=" & strNomBD


        Try
            ocCon = New SqlConnection(strNomBD)
            'ojo con el procesador de 64 bits y visualstudio 2005
            ocCon.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False

        End Try

    End Function

End Module
