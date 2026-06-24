Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Web
Imports System.Text
Imports System.IO
Public Class DAdmin_Sancion
    Public Function Lista_Motivos() As DataSet
        Dim odt As New DataTable
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
        Dim cn As New SqlConnection(strConnString)

        Dim cmd As New SqlCommand
        cmd.Connection = cn

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_arsancion_lista_motivo"

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)


        Return ds
    End Function

    Public Function Lista_estados() As DataSet
        Dim odt As New DataTable
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
        Dim cn As New SqlConnection(strConnString)

        Dim cmd As New SqlCommand
        cmd.Connection = cn

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_arsancion_lista_estado"

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)


        Return ds
    End Function

    Public Function unidades_usuario(ByVal ad_usuario As String) As DataSet
        Dim odt As New DataTable
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
        Dim cn As New SqlConnection(strConnString)

        Dim cmd As New SqlCommand
        cmd.Connection = cn

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_arsancion_unidades_usuario"
        cmd.Parameters.Add("@ad_usuario", SqlDbType.VarChar)
        cmd.Parameters(0).Value = ad_usuario

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)


        Return ds
    End Function

    Public Function Lista_Documentos_Sancion(ByVal FechaInicial As String, ByVal FechaFinal As String, ByVal id_unidad As Integer, ByVal id_motivo As Integer, ByVal nro_doc As String, ByVal usuario As String, ByVal nombre_apellido As String,
                                             ByVal estado As Integer) As DataSet
        Dim odt As New DataTable
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
        Dim cn As New SqlConnection(strConnString)

        Dim cmd As New SqlCommand
        cmd.Connection = cn

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_arsancion_lista_documentos"
        cmd.Parameters.Add("@FechaInicial", SqlDbType.NVarChar)
        cmd.Parameters(0).Value = FechaInicial
        cmd.Parameters.Add("@FechaFinal", SqlDbType.NVarChar)
        cmd.Parameters(1).Value = FechaFinal
        cmd.Parameters.Add("@id_unidad", SqlDbType.Int)
        cmd.Parameters(2).Value = id_unidad
        cmd.Parameters.Add("@id_motivo", SqlDbType.Int)
        cmd.Parameters(3).Value = id_motivo
        cmd.Parameters.Add("@nro_doc", SqlDbType.VarChar)
        cmd.Parameters(4).Value = nro_doc
        cmd.Parameters.Add("@usuario", SqlDbType.VarChar)
        cmd.Parameters(5).Value = usuario
        cmd.Parameters.Add("@nombre_apellido", SqlDbType.VarChar)
        cmd.Parameters(6).Value = nombre_apellido
        cmd.Parameters.Add("@estado", SqlDbType.Int)
        cmd.Parameters(7).Value = estado

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)


        Return ds
    End Function




End Class
