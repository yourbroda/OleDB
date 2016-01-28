Imports System.Data.SqlClient


Public Class Platformas
    Private cod_plata As Integer
    Private nom As String

    Private strsSql As String
    Private ocmComando As New SqlCommand

    Property Codigo As Integer
        Get

            Return cod_plata

        End Get
        Set(value As Integer)

            cod_plata = value

        End Set
    End Property

    Property nombre As String
        Get
            Return nom
        End Get
        Set(value As String)
            nom = value
        End Set
    End Property
    Public Function Añadir() As Boolean


        strsSql = "Insert into Plataformas values(" & cod_plata & ",'" & nom & "')"
        Try

            ocmComando = New SqlCommand(strsSql, Conexion.ocCon)
            ocmComando.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False

        End Try

    End Function
    Public Function Modificar() As Boolean
        strsSql = "UPDATE Plataformas set Nombre='" & nom & "' where Cod_Plata=" & cod_plata
        Try
            ocmComando = New SqlCommand(strsSql, Conexion.ocCon)
            ocmComando.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function
    Public Function Borrar() As Boolean

        strsSql = "Delete from Plataformas where Cod_Plata=" & cod_plata
        Try
            ocmComando = New SqlCommand(strsSql, Conexion.ocCon)
            ocmComando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Seleccionar() As DataTable

        Dim dtAdapter As SqlDataAdapter
        Dim dtPlataforma As DataTable

        strsSql = "Select Nombre from Plataformas where Cod_Plata= " & cod_plata
        Try
            ocmComando = New SqlCommand(strsSql, Conexion.ocCon)
            dtAdapter = New SqlDataAdapter(ocmComando)
            dtPlataforma = New DataTable()
            dtAdapter.Fill(dtPlataforma)
            Return dtPlataforma






        Catch ex As Exception
            Return dtPlataforma
        End Try
    End Function
    Public Function Rellenar() As DataTable

        'Mismo metodo qe Seleccionar pero con otro Select 
        Dim dtAdapter As SqlDataAdapter
        Dim dtPlataforma As DataTable

        strsSql = "Select Nombre, Cod_Plata from Plataformas"
        Try
            ocmComando = New SqlCommand(strsSql, Conexion.ocCon)
            dtAdapter = New SqlDataAdapter(ocmComando)
            dtPlataforma = New DataTable()
            dtAdapter.Fill(dtPlataforma)
            Return dtPlataforma






        Catch ex As Exception
            Return dtPlataforma
        End Try
    End Function
End Class
