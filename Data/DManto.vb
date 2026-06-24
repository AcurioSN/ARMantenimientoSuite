Imports System.Data.SqlClient
Imports System.Configuration
Public Class DManto

    Public Function configuracion_recaptcha() As DataSet
        Dim odt As New DataTable
        Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
        Dim cn As New SqlConnection(strConnString)

        Dim cmd As New SqlCommand
        cmd.Connection = cn

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_armaestro_prov_configuracion_recaptcha"



        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)


        Return ds
    End Function
    Public Function Lista_Unidades(ByVal usuario As String) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_unidades_usuario", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function
    Public Function Lista_Unidades_todos() As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_todas_unidades", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0


                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function
    Public Function Lista_Clase() As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_clase_aviso", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Lista_Estado() As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_estado", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Lista_Diagnostico_Inicial() As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_diagnostico_ini_aviso", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Lista_area_solicitante() As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_area_solicitante", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Lista_Impacto_Aviso() As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_impacto_aviso", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function
    Public Function Filtro_Busqueda_Equipos(ByVal codigo_equipo As String, ByVal serie As String, ByVal marca As String,
                                            ByVal desc_equipo As String, ByVal centro As String, ByVal codigo_equipo_QR As String) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_busqueda_equipos_N1", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@codigo_equipo", SqlDbType.VarChar, 50).Value = codigo_equipo
                    cmd.Parameters.Add("@serie", SqlDbType.VarChar, 50).Value = serie
                    cmd.Parameters.Add("@marca", SqlDbType.VarChar, 100).Value = marca
                    cmd.Parameters.Add("@desc_equipo", SqlDbType.VarChar, 200).Value = desc_equipo
                    cmd.Parameters.Add("@centro", SqlDbType.VarChar, 15).Value = centro
                    cmd.Parameters.Add("@codigo_equipo_qr", SqlDbType.VarChar, 15).Value = codigo_equipo_QR

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Lista_Prioridad_Aviso() As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_prioridad_aviso", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Matriz_prioridad_clase_impacto(ByVal id_clase_aviso As Integer, ByVal id_impacto_aviso As Integer) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_prioridad_clase_impacto", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@id_clase_aviso", SqlDbType.Int).Value = id_clase_aviso
                    cmd.Parameters.Add("@id_impacto_aviso", SqlDbType.Int).Value = id_impacto_aviso

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function


    Public Function Registra_Nuevo_Aviso(ByVal id_usuario As Integer, ByVal cc_unidad_aviso As String, ByVal titulo_aviso As String,
                                         ByVal id_area_solic_aviso As Integer, ByVal id_diagnostico_ini_aviso As Integer, ByVal id_clase_aviso As Integer,
                                         ByVal id_impacto_aviso As Integer, ByVal id_prioridad_aviso As Integer,
                                         ByVal cod_equipo_aviso As String, ByVal desc_aviso As String, ByVal desc_equipo_aviso As String) As Integer
        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim id_aviso As Integer

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_nuevo_registro_aviso", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Agregar parámetros con tipo y tamaño
                    cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_usuario
                    cmd.Parameters.Add("@cc_unidad_aviso", SqlDbType.VarChar, 15).Value = cc_unidad_aviso
                    cmd.Parameters.Add("@titulo_aviso", SqlDbType.VarChar, 500).Value = titulo_aviso
                    cmd.Parameters.Add("@id_area_solic_aviso", SqlDbType.Int).Value = id_area_solic_aviso
                    cmd.Parameters.Add("@id_diagnostico_ini_aviso", SqlDbType.Int).Value = id_diagnostico_ini_aviso
                    cmd.Parameters.Add("@id_clase_aviso", SqlDbType.Int).Value = id_clase_aviso
                    cmd.Parameters.Add("@id_impacto_aviso", SqlDbType.Int).Value = id_impacto_aviso
                    cmd.Parameters.Add("@id_prioridad_aviso", SqlDbType.Int).Value = id_prioridad_aviso
                    cmd.Parameters.Add("@cod_equipo_aviso", SqlDbType.VarChar, 100).Value = cod_equipo_aviso
                    cmd.Parameters.Add("@desc_aviso", SqlDbType.VarChar, 5000).Value = desc_aviso
                    cmd.Parameters.Add("@desc_equipo_aviso", SqlDbType.VarChar, 500).Value = desc_equipo_aviso

                    ' Parámetro de salida
                    cmd.Parameters.Add("@id_aviso", SqlDbType.Int).Direction = ParameterDirection.Output


                    cn.Open()
                    cmd.ExecuteNonQuery()

                    ' Obtener valor del parámetro de salida

                    id_aviso = Convert.ToInt32(cmd.Parameters("@id_aviso").Value)

                End Using
            End Using

            Return id_aviso
        Catch ex As Exception
            ' Aquí puedes registrar el error antes de relanzarlo
            ' LogError(ex.Message) 
            Throw ' Lanza el error para que sea manejado en niveles superiores
        End Try
    End Function

    Public Function Filtro_Busqueda_Avisos(ByVal nro_aviso As String, ByVal estado_aviso As Integer, ByVal unidad_usuario_aviso As String, ByVal area_solic_aviso As Integer, ByVal diagnostico_ini_aviso As Integer,
                                           ByVal clase_aviso As Integer, ByVal impacto_aviso As Integer, ByVal prioridad_aviso As Integer,
                                           ByVal fecregini_aviso As DateTime, ByVal fecregfin_aviso As DateTime) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_busqueda_avisos", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@nro_aviso", SqlDbType.VarChar, 50).Value = nro_aviso
                    cmd.Parameters.Add("@estado_aviso", SqlDbType.Int).Value = estado_aviso
                    cmd.Parameters.Add("@unidad_usuario_aviso", SqlDbType.VarChar, 50).Value = unidad_usuario_aviso
                    cmd.Parameters.Add("@area_solic_aviso", SqlDbType.Int).Value = area_solic_aviso
                    cmd.Parameters.Add("@diagnostico_ini_aviso", SqlDbType.Int).Value = diagnostico_ini_aviso
                    cmd.Parameters.Add("@clase_aviso", SqlDbType.Int).Value = clase_aviso
                    cmd.Parameters.Add("@impacto_aviso", SqlDbType.Int).Value = impacto_aviso
                    cmd.Parameters.Add("@prioridad_aviso", SqlDbType.Int).Value = prioridad_aviso
                    cmd.Parameters.Add("@fecregini_aviso", SqlDbType.DateTime).Value = fecregini_aviso
                    cmd.Parameters.Add("@fecregfin_aviso", SqlDbType.DateTime).Value = fecregfin_aviso

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function


    Public Function Detalle_aviso_seleccionado(ByVal id_aviso As Integer) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_detalle_aviso_seleccionado", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@id_aviso", SqlDbType.Int).Value = id_aviso

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Registra_Archivos_Adjuntos_Fisico(ByVal id_aviso As Integer, ByVal nom_archivo As String) As Boolean
        Try
            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_registra_archivo_adjunto_fisico"

            cmd.Parameters.Add("@id_aviso", SqlDbType.Int)
            cmd.Parameters(0).Value = id_aviso
            cmd.Parameters.Add("@nom_archivo", SqlDbType.VarChar)
            cmd.Parameters(1).Value = nom_archivo


            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Filtro_Busqueda_Proveedores(ByVal ruc_proveedor As String, ByVal razon_social_proveedor As String, ByVal sapproveedor As String) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_busqueda_proveedores_N", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@ruc_proveedor", SqlDbType.VarChar, 150).Value = ruc_proveedor
                    cmd.Parameters.Add("@razon_social_proveedor", SqlDbType.VarChar, 500).Value = razon_social_proveedor
                    cmd.Parameters.Add("@sapproveedor", SqlDbType.VarChar, 150).Value = sapproveedor


                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Lista_Clase_OTM(ByVal id_clase_aviso As Integer) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_clase_otm", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@id_clase_aviso", SqlDbType.Int).Value = id_clase_aviso

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Lista_FamiliaServicio() As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_familia_servicio", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Lista_Subfamilia_Servicio(ByVal id_familia_servicio As Integer) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_Subfamilia_servicio", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@id_familia_servicio", SqlDbType.Int).Value = id_familia_servicio

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Rechazar_Aviso(ByVal nro_aviso As String, ByVal id_usuario As Integer) As Boolean
        Try
            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_rechazar_aviso"

            cmd.Parameters.Add("@nro_aviso", SqlDbType.VarChar, 50)
            cmd.Parameters(0).Value = nro_aviso
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int)
            cmd.Parameters(1).Value = id_usuario


            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Function Registra_Estado_Aviso_2(ByVal id_aviso As Integer, ByVal id_usuario As Integer, ByVal proveedor_asig_aviso As String,
                                         ByVal id_clase_otm As Integer, ByVal grupo_compras_aviso As String, ByVal fecini_coti_limite_aviso As DateTime,
                                         ByVal fecfin_coti_limite_aviso As DateTime, ByVal id_subfamilia_servicio As Integer, ByVal razon_social_proveedor As String, ByVal ruc_proveedor_sap As String) As Boolean
        Try

            'REGISTRO DE ASIGNACION DE PROVEEDOR

            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_registra_aviso_estado_idestado_2", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Agregar parámetros con tipo y tamaño
                    cmd.Parameters.Add("@id_aviso", SqlDbType.Int).Value = id_aviso
                    cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_usuario
                    cmd.Parameters.Add("@proveedor_asig_aviso", SqlDbType.VarChar, 15).Value = proveedor_asig_aviso
                    cmd.Parameters.Add("@id_clase_otm", SqlDbType.Int).Value = id_clase_otm
                    cmd.Parameters.Add("@grupo_compras_aviso", SqlDbType.VarChar, 15).Value = grupo_compras_aviso
                    cmd.Parameters.Add("@fecini_coti_limite_aviso", SqlDbType.DateTime).Value = fecini_coti_limite_aviso
                    cmd.Parameters.Add("@fecfin_coti_limite_aviso", SqlDbType.DateTime).Value = fecfin_coti_limite_aviso
                    cmd.Parameters.Add("@id_subfamilia_servicio", SqlDbType.Int).Value = id_subfamilia_servicio
                    cmd.Parameters.Add("@razon_social_proveedor", SqlDbType.VarChar, 500).Value = razon_social_proveedor
                    cmd.Parameters.Add("@ruc_proveedor_sap", SqlDbType.VarChar, 500).Value = ruc_proveedor_sap



                    cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()

                    Return True

                End Using
            End Using

            Return id_aviso
        Catch ex As Exception
            ' Aquí puedes registrar el error antes de relanzarlo
            ' LogError(ex.Message) 
            Throw ' Lanza el error para que sea manejado en niveles superiores
        End Try
    End Function


    Public Function lista_busqueda_avisos_inicial(ByVal usuario As String) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_busqueda_avisos_inicial", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 100).Value = usuario

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function lista_busqueda_avisos_inicial_proveedor(ByVal usuario As String) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_busqueda_avisos_inicial_proveedor", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 100).Value = usuario

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Busqueda_Equipos_Servicios_Cotizacion(ByVal descripcion As String, ByVal cc_logistico As String) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_busqueda_equipos_servicios_cotizacion", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 500).Value = descripcion
                    cmd.Parameters.Add("@cc_logistico", SqlDbType.VarChar, 500).Value = cc_logistico

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Registra_Cotizacion_Aviso(ByVal id_aviso As Integer, ByVal desc_cotizacion As String, ByVal id_moneda As Integer,
                                         ByVal id_usuario As Integer, ByVal fec_ini_serv_cotizacion As DateTime, ByVal fec_fin_serv_cotizacion As DateTime,
                                         ByVal monto_total_cotizacion As Decimal) As Integer
        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim id_aviso_cotizacion As Integer

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_guarda_cotizacion_proveedor", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Agregar parámetros con tipo y tamaño
                    cmd.Parameters.Add("@id_aviso", SqlDbType.Int).Value = id_aviso
                    cmd.Parameters.Add("@desc_cotizacion", SqlDbType.VarChar, 500).Value = desc_cotizacion
                    cmd.Parameters.Add("@id_moneda", SqlDbType.Int).Value = id_moneda
                    cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_usuario
                    cmd.Parameters.Add("@fec_ini_serv_cotizacion", SqlDbType.DateTime).Value = fec_ini_serv_cotizacion
                    cmd.Parameters.Add("@fec_fin_serv_cotizacion", SqlDbType.DateTime).Value = fec_fin_serv_cotizacion
                    cmd.Parameters.Add("@monto_total_cotizacion", SqlDbType.Decimal).Value = monto_total_cotizacion

                    ' Parámetro de salida
                    cmd.Parameters.Add("@id_aviso_cotizacion", SqlDbType.Int).Direction = ParameterDirection.Output


                    cn.Open()
                    cmd.ExecuteNonQuery()

                    ' Obtener valor del parámetro de salida

                    id_aviso_cotizacion = Convert.ToInt32(cmd.Parameters("@id_aviso_cotizacion").Value)

                End Using
            End Using

            Return id_aviso_cotizacion
        Catch ex As Exception
            ' Aquí puedes registrar el error antes de relanzarlo
            ' LogError(ex.Message) 
            Throw ' Lanza el error para que sea manejado en niveles superiores
        End Try
    End Function

    Public Function lista_cotizaciones_aviso(ByVal id_aviso As Integer) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_lista_cotizaciones_proveedor", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@id_aviso", SqlDbType.Int).Value = id_aviso

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Registra_detalle_cotizacion(ByVal id_aviso_cotizacion As Integer, ByVal cod_comp_det_aviso_cotizacion As String, ByVal cod_um_det_aviso_cotizacion As String,
                                                ByVal cant_det_aviso_cotizacion As Decimal, ByVal prec_det_aviso_cotizacion As Decimal, ByVal desc_det_aviso_cotizacion As String, ByVal tipo As String) As Boolean
        Try
            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_guarda_detalle_cotizacion_proveedor_01"

            cmd.Parameters.Add("@id_aviso_cotizacion", SqlDbType.Int)
            cmd.Parameters(0).Value = id_aviso_cotizacion
            cmd.Parameters.Add("@cod_comp_det_aviso_cotizacion", SqlDbType.VarChar)
            cmd.Parameters(1).Value = cod_comp_det_aviso_cotizacion
            cmd.Parameters.Add("@cod_um_det_aviso_cotizacion", SqlDbType.VarChar)
            cmd.Parameters(2).Value = cod_um_det_aviso_cotizacion
            cmd.Parameters.Add("@cant_det_aviso_cotizacion", SqlDbType.Decimal)
            cmd.Parameters(3).Value = cant_det_aviso_cotizacion
            cmd.Parameters.Add("@prec_det_aviso_cotizacion", SqlDbType.Decimal)
            cmd.Parameters(4).Value = prec_det_aviso_cotizacion
            cmd.Parameters.Add("@desc_det_aviso_cotizacion", SqlDbType.VarChar)
            cmd.Parameters(5).Value = desc_det_aviso_cotizacion
            cmd.Parameters.Add("@tipo_det_aviso_cotizacion", SqlDbType.VarChar)
            cmd.Parameters(6).Value = tipo


            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Detalle_Cotizacion_Proveedor(ByVal id_aviso_cotizacion As Integer) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_detalle_cotizacion_proveedor", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@id_aviso_cotizacion", SqlDbType.Int).Value = id_aviso_cotizacion

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Modificar_Cotizacion_Aviso(ByVal id_aviso_cotizacion As Integer, ByVal desc_cotizacion As String, ByVal id_moneda As Integer,
                                       ByVal id_usuario As Integer, ByVal fec_ini_serv_cotizacion As DateTime, ByVal fec_fin_serv_cotizacion As DateTime,
                                       ByVal monto_total_cotizacion As Decimal) As Boolean
        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString


            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_modifica_cotizacion_proveedor", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Agregar parámetros con tipo y tamaño
                    cmd.Parameters.Add("@id_aviso_cotizacion", SqlDbType.Int).Value = id_aviso_cotizacion
                    cmd.Parameters.Add("@desc_cotizacion", SqlDbType.VarChar, 500).Value = desc_cotizacion
                    cmd.Parameters.Add("@id_moneda", SqlDbType.Int).Value = id_moneda
                    cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_usuario
                    cmd.Parameters.Add("@fec_ini_serv_cotizacion", SqlDbType.DateTime).Value = fec_ini_serv_cotizacion
                    cmd.Parameters.Add("@fec_fin_serv_cotizacion", SqlDbType.DateTime).Value = fec_fin_serv_cotizacion
                    cmd.Parameters.Add("@monto_total_cotizacion", SqlDbType.Decimal).Value = monto_total_cotizacion

                    cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()

                    Return True

                End Using
            End Using

            Return id_aviso_cotizacion
        Catch ex As Exception
            ' Aquí puedes registrar el error antes de relanzarlo
            ' LogError(ex.Message) 
            Throw ' Lanza el error para que sea manejado en niveles superiores
        End Try
    End Function

    Public Function Elimina_Cotizacion_Aviso(ByVal id_aviso_cotizacion As Integer, ByVal id_usuario As Integer) As Boolean
        Try
            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_elimina_cotizacion_aviso"

            cmd.Parameters.Add("@id_aviso_cotizacion", SqlDbType.Int)
            cmd.Parameters(0).Value = id_aviso_cotizacion
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int)
            cmd.Parameters(1).Value = id_usuario


            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Registra_Estado_Aviso_3(ByVal id_aviso As Integer, ByVal id_usuario As Integer) As Boolean
        Try
            'Cambiar a Estado Cotizacion registrada

            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_registra_aviso_estado_idestado_3"

            cmd.Parameters.Add("@id_aviso", SqlDbType.Int)
            cmd.Parameters(0).Value = id_aviso
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int)
            cmd.Parameters(1).Value = id_usuario


            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Registra_Estado_Aviso_4(ByVal id_aviso As Integer, ByVal id_usuario As Integer, ByVal code_aviso_estado As String,
                                            ByVal msj_aviso_estado As String, ByVal aufnr_aviso_estado As String) As Boolean
        Try
            'Cambiar a Estado Cotizacion registrada

            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_registra_aviso_estado_idestado_4"

            cmd.Parameters.Add("@id_aviso", SqlDbType.Int)
            cmd.Parameters(0).Value = id_aviso
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int)
            cmd.Parameters(1).Value = id_usuario
            cmd.Parameters.Add("@code_aviso_estado", SqlDbType.VarChar, 50)
            cmd.Parameters(2).Value = code_aviso_estado
            cmd.Parameters.Add("@msj_aviso_estado", SqlDbType.VarChar, 500)
            cmd.Parameters(3).Value = msj_aviso_estado
            cmd.Parameters.Add("@aufnr_aviso_estado", SqlDbType.VarChar, 50)
            cmd.Parameters(4).Value = aufnr_aviso_estado


            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Registra_Estado_Aviso_5(ByVal id_aviso As Integer, ByVal id_usuario As Integer, ByVal sustento_rechazo As String) As Boolean
        Try
            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_registra_aviso_estado_idestado_5"

            cmd.Parameters.Add("@id_aviso", SqlDbType.Int)
            cmd.Parameters(0).Value = id_aviso
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int)
            cmd.Parameters(1).Value = id_usuario
            cmd.Parameters.Add("@sustento_rechazo", SqlDbType.VarChar, 5000)
            cmd.Parameters(2).Value = sustento_rechazo


            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Registra_Estado_Aviso_8(ByVal id_aviso As Integer, ByVal id_usuario As Integer) As Boolean
        Try
            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_registra_aviso_estado_idestado_8"

            cmd.Parameters.Add("@id_aviso", SqlDbType.Int)
            cmd.Parameters(0).Value = id_aviso
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int)
            cmd.Parameters(1).Value = id_usuario



            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Registra_Estado_Aviso_8_final(ByVal id_aviso As Integer, ByVal id_usuario As Integer, ByVal nro_hes As String,
                                            ByVal fecha_contable_hes As DateTime) As Boolean
        Try
            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_registra_aviso_estado_idestado_8_N"

            cmd.Parameters.Add("@id_aviso", SqlDbType.Int)
            cmd.Parameters(0).Value = id_aviso
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int)
            cmd.Parameters(1).Value = id_usuario
            cmd.Parameters.Add("@nro_hes", SqlDbType.VarChar, 100)
            cmd.Parameters(2).Value = nro_hes
            cmd.Parameters.Add("@fecha_contable_hes", SqlDbType.DateTime)
            cmd.Parameters(3).Value = fecha_contable_hes


            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function valida_credenciales(ByVal user As String, ByVal clave As String) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_inicio_sesion", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = user
                    cmd.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = clave

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Datos_Api_1(ByVal id_aviso As Integer) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_Api1_Datos_N", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@id_aviso", SqlDbType.Int).Value = id_aviso

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function Registra_Estado_Aviso_4_LogApi(ByVal id_aviso As Integer, ByVal id_usuario As Integer, ByVal code_aviso_estado As String,
                                           ByVal msj_aviso_estado As String, ByVal aufnr_aviso_estado As String) As Boolean
        Try
            'Cambiar a Estado Cotizacion registrada

            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_registra_aviso_estado_idestado_4_LogApi"

            cmd.Parameters.Add("@id_aviso", SqlDbType.Int)
            cmd.Parameters(0).Value = id_aviso
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int)
            cmd.Parameters(1).Value = id_usuario
            cmd.Parameters.Add("@code_aviso_estado", SqlDbType.VarChar, 50)
            cmd.Parameters(2).Value = code_aviso_estado
            cmd.Parameters.Add("@msj_aviso_estado", SqlDbType.VarChar, 500)
            cmd.Parameters(3).Value = msj_aviso_estado
            cmd.Parameters.Add("@aufnr_aviso_estado", SqlDbType.VarChar, 50)
            cmd.Parameters(4).Value = aufnr_aviso_estado


            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Registra_Estado_Aviso_7(ByVal id_aviso As Integer, ByVal id_usuario As Integer, ByVal sustento_proveedor As String) As Boolean
        Try
            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_registra_aviso_estado_idestado_7"

            cmd.Parameters.Add("@id_aviso", SqlDbType.Int)
            cmd.Parameters(0).Value = id_aviso
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int)
            cmd.Parameters(1).Value = id_usuario
            cmd.Parameters.Add("@sustento_proveedor", SqlDbType.VarChar, 5000)
            cmd.Parameters(2).Value = sustento_proveedor


            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Function Registra_Archivos_Adjuntos_Fisico_sustento_proveedor(ByVal id_aviso As Integer, ByVal nom_archivo As String) As Boolean
        Try
            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_registra_archivo_adjunto_fisico_sustento_prov"

            cmd.Parameters.Add("@id_aviso", SqlDbType.Int)
            cmd.Parameters(0).Value = id_aviso
            cmd.Parameters.Add("@nom_archivo", SqlDbType.VarChar)
            cmd.Parameters(1).Value = nom_archivo


            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Cotizacion_aprobada_aviso(ByVal id_aviso As Integer, ByVal nro_cotizacion As String) As Boolean
        Try
            'Cambiar a Estado Cotizacion registrada

            Dim odt As New DataTable
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString
            Dim cn As New SqlConnection(strConnString)

            Dim cmd As New SqlCommand
            cmd.Connection = cn

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_armanto_registra_aviso_cotizacion"

            cmd.Parameters.Add("@id_aviso", SqlDbType.Int)
            cmd.Parameters(0).Value = id_aviso
            cmd.Parameters.Add("@nro_cotizacion", SqlDbType.VarChar, 25)
            cmd.Parameters(1).Value = nro_cotizacion


            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Datos_Api_3(ByVal id_aviso As Integer) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexion").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_armanto_Api3_Datos", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@id_aviso", SqlDbType.Int).Value = id_aviso

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function ExisteTokenActivo(ByVal token As String) As DataSet
        Dim ds As New DataSet()

        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexionAcceso").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_arsuite_Validartoken", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Definir parámetro con tipo y tamaño
                    cmd.Parameters.Add("@token", SqlDbType.VarChar, 500).Value = token

                    ' Llenar el DataSet usando SqlDataAdapter
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Registrar el error si es necesario
            ' LogError(ex.Message) 
            Throw ' Relanzar el error para ser manejado en un nivel superior
        End Try

        Return ds
    End Function

    Public Function CerrarSesionGlobal(ByVal tokenGlobal As String) As Boolean
        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexionAcceso").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_arsuite_CerrarSesionGlobal", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Agregar parámetros con tipo y tamaño
                    cmd.Parameters.Add("@token", SqlDbType.VarChar, 500).Value = tokenGlobal

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            ' Aquí puedes registrar el error antes de relanzarlo
            ' LogError(ex.Message) 
            Throw ' Lanza el error para que sea manejado en niveles superiores
        End Try
    End Function

    Public Function Registro_SesionSistema(ByVal tokenGlobal As String, ByVal usuario As String, ByVal CodigoSistema As String, ByVal PaginaAcceso As String) As Boolean
        Try
            Dim strConnString As String = ConfigurationManager.ConnectionStrings("cadenaConexionAcceso").ConnectionString

            Using cn As New SqlConnection(strConnString)
                Using cmd As New SqlCommand("sp_arsuite_Registro_SesionSistema", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 0

                    ' Agregar parámetros con tipo y tamaño
                    cmd.Parameters.Add("@tokenGlobal", SqlDbType.VarChar, 500).Value = tokenGlobal
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario
                    cmd.Parameters.Add("@CodigoSistema", SqlDbType.VarChar, 20).Value = CodigoSistema
                    cmd.Parameters.Add("@PaginaAcceso", SqlDbType.VarChar, 200).Value = PaginaAcceso

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            ' Aquí puedes registrar el error antes de relanzarlo
            ' LogError(ex.Message) 
            Throw ' Lanza el error para que sea manejado en niveles superiores
        End Try
    End Function

End Class
