Imports System.Data.SqlClient
Imports System.IO


Public Class Juegos
#Region "Variables"
    Private cod As Integer
    Private cod_Plat As Integer
    Private tip As String
    Private nombre As String
    Private est As String
    Private imagen As String
    Private strsSql As String
    Private ocmComando As New SqlCommand
    Private arreglo As Byte() = Nothing
    Private codB, codPB, tipB, nombreB, estB As Boolean
    Property codBProp As Boolean
        Get
            Return codB

        End Get
        Set(value As Boolean)
            codB = value
        End Set
    End Property
    Property codPBprop As Boolean
        Get
            Return codPB

        End Get
        Set(value As Boolean)
            codPB = value
        End Set
    End Property

    Property tipProp As Boolean
        Get
            Return tipB

        End Get
        Set(value As Boolean)
            tipB = value
        End Set
    End Property

    Property nombreProp As Boolean
        Get
            Return nombreB

        End Get
        Set(value As Boolean)
            nombreB = value
        End Set
    End Property
    Property estProp As Boolean
        Get
            Return estB

        End Get
        Set(value As Boolean)
            estB = value
        End Set
    End Property


    Property codigo As Integer
        Get
            Return cod
        End Get
        Set(value As Integer)
            cod = value
        End Set
    End Property
    Property titulo As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Property estudio As String
        Get
            Return est
        End Get
        Set(value As String)
            est = value
        End Set
    End Property
    Property Tipo As String
        Get
            Return tip
        End Get
        Set(value As String)
            tip = value
        End Set
    End Property
    Property Plataforma As Integer
        Get
            Return cod_Plat

        End Get
        Set(value As Integer)
            cod_Plat = value

        End Set
    End Property
    Property ImagenProp As String
        Get
            Return imagen
        End Get
        Set(value As String)
            imagen = value

        End Set
    End Property
#End Region
#Region "Metodos"
    Public Function AñadirJuego() As Boolean
        'Funcion que añade un juego con todos los valores


        strsSql = "Insert into Juegos values(" & cod & "," & cod_Plat & ",'" & tip & "','" & nombre & "','" & est & "')"
        Try
            'Le pasamos por parametros el string de seleccion y la variable de conexion
            ocmComando = New SqlCommand(strsSql, Conexion.ocCon)
            ocmComando.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False

        End Try

    End Function
    Public Function Modificar() As Boolean
        'Update de los registros
        strsSql = "UPDATE Juegos set Cod_Plataforma=" & cod_Plat & ", Tipo='" & tip & "', Nombre='" & nombre & "', Estudio='" & est & "' where Codigo=" & cod
        Try
            'Le pasamos por parametros el string de seleccion y la variable de conexion
            ocmComando = New SqlCommand(strsSql, Conexion.ocCon)
            ocmComando.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function
    Public Function Borrar() As Boolean
        'Borrado de registros
        strsSql = "Delete from Juegos where Codigo=" & cod
        Try
            'Le pasamos por parametros el string de seleccion y la variable de conexion
            ocmComando = New SqlCommand(strsSql, Conexion.ocCon)
            ocmComando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Seleccionar() As DataTable
        'Seleccion de registros
        Dim dtAdapter As SqlDataAdapter
        Dim dtjuegos As DataTable

        strsSql = "Select * from Juegos where Codigo= " & cod

        Try
            ocmComando = New SqlCommand(strsSql, Conexion.ocCon) 'conexion
            dtAdapter = New SqlDataAdapter(ocmComando) 'instanciacion de sqlAdapter
            dtjuegos = New DataTable()
            dtAdapter.Fill(dtjuegos) 'rellenaos el datatable juegos con el dtAdapter
            Return dtjuegos 'devolvemos el datatable






        Catch ex As Exception

        End Try
    End Function
    Public Function BuscarPor() As DataTable

        Dim dtAdapter As SqlDataAdapter
        Dim dtjuegos As DataTable
        Dim busqueda As String
        busqueda = ""
        If (codB) Then

            busqueda = busqueda + "Codigo"
        End If
        If (codPB) Then
            If ((codB = True) And (codPB = True Or tipB = True Or nombreB = True Or estB = True)) Then
                busqueda = busqueda + ","
            End If
            busqueda = busqueda + "Cod_Plataforma"
        End If
        If (tipB) Then
            If ((codB = True Or tipB = True Or nombreB = True Or estB = True) And (codPB = True)) Then
                busqueda = busqueda + ","
            End If
            busqueda = busqueda + "Tipo"
        End If
        If (nombreB) Then
            If ((codB = True Or codPB = True Or tipB = True Or estB = True) And (nombreB = True)) Then
                busqueda = busqueda + ","
            End If
            busqueda = busqueda + "Nombre"
        End If
        If (estB) Then
            If ((codB = True Or codPB = True Or tipB = True Or nombreB = True) And (estB = True)) Then
                busqueda = busqueda + ","
            End If
            busqueda = busqueda + "Estudio"
        End If

        strsSql = "Select " & busqueda & " from Juegos where 1=1"
        Try
            ocmComando = New SqlCommand(strsSql, Conexion.ocCon)
            dtAdapter = New SqlDataAdapter(ocmComando)
            dtjuegos = New DataTable()

            dtAdapter.Fill(dtjuegos)
            Return dtjuegos
        Catch ex As Exception

        End Try
    End Function
    Public Function Cargar() As DataTable
        Dim dtAdapter As SqlDataAdapter
        Dim dtjuegos As DataTable

        strsSql = "Select * from Juegos where 1=1"

        Try
            ocmComando = New SqlCommand(strsSql, Conexion.ocCon)
            dtAdapter = New SqlDataAdapter(ocmComando)
            dtjuegos = New DataTable()
            dtAdapter.Fill(dtjuegos)
            Return dtjuegos
        Catch ex As Exception

        End Try
    End Function
#End Region

End Class
