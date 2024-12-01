Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web
Imports Entidades

Public Class datoAutomovil
    Public Sub New()

    End Sub
    Dim cnn As New SqlClient.SqlConnection(Datos.Conexion.cadenaconexion())
    Public Function AgregarAutomovil(automovil As eAutomovil) As Integer
        Dim cnn As New SqlConnection(Conexion.cadenaconexion)
        cnn.Open()

        Dim cmd As New SqlCommand("AutomoviInserta", cnn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("Marca", SqlDbType.VarChar, 100).Value = automovil.Marca
        cmd.Parameters.Add("Modelo", SqlDbType.VarChar, 100).Value = automovil.Modelo
        cmd.Parameters.Add("Anio", SqlDbType.Int).Value = automovil.Anio
        cmd.Parameters.Add("Precio", SqlDbType.Int).Value = automovil.Precio
        Dim id As Integer
        id = 0
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            id = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try
        Return id
    End Function

End Class
