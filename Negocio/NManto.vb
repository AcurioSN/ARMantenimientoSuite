Imports Data
Public Class NManto
    Dim obj As New Data.DManto
    Public Function configuracion_recaptcha() As DataSet
        Dim ds As New DataSet
        ds = obj.configuracion_recaptcha()
        Return ds
    End Function
    Public Function Lista_Unidades(ByVal usuario As String) As DataSet
        Dim ds As New DataSet
        ds = obj.Lista_Unidades(usuario)
        Return ds
    End Function
    Public Function Lista_Unidades_todos() As DataSet
        Dim ds As New DataSet
        ds = obj.Lista_Unidades_todos()
        Return ds
    End Function
    Public Function Lista_Clase() As DataSet
        Dim ds As New DataSet
        ds = obj.Lista_Clase()
        Return ds
    End Function

    Public Function Lista_Diagnostico_Inicial() As DataSet
        Dim ds As New DataSet
        ds = obj.Lista_Diagnostico_Inicial()
        Return ds
    End Function

    Public Function Lista_area_solicitante() As DataSet
        Dim ds As New DataSet
        ds = obj.Lista_area_solicitante()
        Return ds
    End Function
    Public Function Lista_Estado() As DataSet
        Dim ds As New DataSet
        ds = obj.Lista_Estado()
        Return ds
    End Function

    Public Function Lista_impacto_aviso() As DataSet
        Dim ds As New DataSet
        ds = obj.Lista_Impacto_Aviso()
        Return ds
    End Function
    Public Function Filtro_Busqueda_Equipos(ByVal codigo_equipo As String, ByVal serie As String, ByVal marca As String,
                                            ByVal desc_equipo As String, ByVal centro As String, ByVal codigo_equipo_qr As String) As DataSet
        Dim ds As New DataSet
        ds = obj.Filtro_Busqueda_Equipos(codigo_equipo, serie, marca, desc_equipo, centro, codigo_equipo_qr)
        Return ds
    End Function
    Public Function Filtro_Busqueda_Proveedores(ByVal ruc_proveedor As String, ByVal razon_social_proveedor As String, ByVal sapproveedor As String) As DataSet
        Dim ds As New DataSet
        ds = obj.Filtro_Busqueda_Proveedores(ruc_proveedor, razon_social_proveedor, sapproveedor)
        Return ds
    End Function

    Public Function Lista_Prioridad_Aviso() As DataSet
        Dim ds As New DataSet
        ds = obj.Lista_Prioridad_Aviso()
        Return ds
    End Function

    Public Function Matriz_prioridad_clase_impacto(ByVal id_clase_aviso As Integer, ByVal id_impacto_aviso As Integer) As DataSet
        Dim ds As New DataSet
        ds = obj.Matriz_prioridad_clase_impacto(id_clase_aviso, id_impacto_aviso)
        Return ds
    End Function

    Public Function Registra_Nuevo_Aviso(ByVal id_usuario As Integer, ByVal cc_unidad_aviso As String, ByVal titulo_aviso As String,
                                         ByVal id_area_solic_aviso As Integer, ByVal id_diagnostico_ini_aviso As Integer, ByVal id_clase_aviso As Integer,
                                         ByVal id_impacto_aviso As Integer, ByVal id_prioridad_aviso As Integer,
                                         ByVal cod_equipo_aviso As String, ByVal desc_aviso As String, ByVal desc_equipo_aviso As String) As Integer
        Dim id_aviso As Integer
        id_aviso = obj.Registra_Nuevo_Aviso(id_usuario, cc_unidad_aviso, titulo_aviso, id_area_solic_aviso, id_diagnostico_ini_aviso,
                       id_clase_aviso, id_impacto_aviso, id_prioridad_aviso, cod_equipo_aviso, desc_aviso, desc_equipo_aviso)
        Return id_aviso
    End Function

    Public Function Filtro_Busqueda_Avisos(ByVal nro_aviso As String, ByVal estado_aviso As Integer, ByVal unidad_usuario_aviso As String, ByVal area_solic_aviso As Integer, ByVal diagnostico_ini_aviso As Integer,
                                           ByVal clase_aviso As Integer, ByVal impacto_aviso As Integer, ByVal prioridad_aviso As Integer,
                                           ByVal fecregini_aviso As DateTime, ByVal fecregfin_aviso As DateTime) As DataSet
        Dim ds As New DataSet
        ds = obj.Filtro_Busqueda_Avisos(nro_aviso, estado_aviso, unidad_usuario_aviso, area_solic_aviso, diagnostico_ini_aviso, clase_aviso, impacto_aviso, prioridad_aviso,
                                        fecregini_aviso, fecregfin_aviso)
        Return ds
    End Function

    Public Function Detalle_aviso_seleccionado(ByVal id_aviso As Integer) As DataSet
        Dim ds As New DataSet
        ds = obj.Detalle_aviso_seleccionado(id_aviso)
        Return ds
    End Function

    Public Function Registra_Archivos_Adjuntos_Fisico(ByVal id_aviso As Integer, ByVal nom_archivo As String) As Boolean
        Dim resultado As Boolean
        resultado = obj.Registra_Archivos_Adjuntos_Fisico(id_aviso, nom_archivo)

        Return resultado
    End Function

    Public Function Lista_Clase_OTM(ByVal id_clase_aviso As Integer) As DataSet
        Dim ds As New DataSet
        ds = obj.Lista_Clase_OTM(id_clase_aviso)
        Return ds
    End Function

    Public Function Lista_FamiliaServicio() As DataSet
        Dim ds As New DataSet
        ds = obj.Lista_FamiliaServicio()
        Return ds
    End Function

    Public Function Lista_Subfamilia_Servicio(ByVal id_familia_servicio As Integer) As DataSet
        Dim ds As New DataSet
        ds = obj.Lista_Subfamilia_Servicio(id_familia_servicio)
        Return ds
    End Function

    Public Function Rechazar_Aviso(ByVal nro_aviso As String, ByVal id_usuario As Integer) As Boolean
        Dim resultado As Boolean
        resultado = obj.Rechazar_Aviso(nro_aviso, id_usuario)

        Return resultado
    End Function

    Public Function Registra_Estado_Aviso_2(ByVal id_aviso As Integer, ByVal id_usuario As Integer, ByVal proveedor_asig_aviso As String,
                                         ByVal id_clase_otm As Integer, ByVal grupo_compras_aviso As String, ByVal fecini_coti_limite_aviso As DateTime,
                                         ByVal fecfin_coti_limite_aviso As DateTime, ByVal id_subfamilia_servicio As Integer, ByVal razon_social_proveedor As String,
                                            ByVal ruc_proveedor_sap As String) As Boolean
        Dim resultado As Boolean
        resultado = obj.Registra_Estado_Aviso_2(id_aviso, id_usuario, proveedor_asig_aviso, id_clase_otm, grupo_compras_aviso, fecini_coti_limite_aviso,
                                                fecfin_coti_limite_aviso, id_subfamilia_servicio, razon_social_proveedor, ruc_proveedor_sap)

        Return resultado
    End Function

    Public Function lista_busqueda_avisos_inicial(ByVal usuario As String) As DataSet
        Dim ds As New DataSet
        ds = obj.lista_busqueda_avisos_inicial(usuario)
        Return ds
    End Function
    Public Function lista_busqueda_avisos_inicial_proveedor(ByVal usuario As String) As DataSet
        Dim ds As New DataSet
        ds = obj.lista_busqueda_avisos_inicial_proveedor(usuario)
        Return ds
    End Function

    Public Function Busqueda_Equipos_Servicios_Cotizacion(ByVal descripcion As String, ByVal cc_logistico As String) As DataSet
        Dim ds As New DataSet
        ds = obj.Busqueda_Equipos_Servicios_Cotizacion(descripcion, cc_logistico)
        Return ds
    End Function

    Public Function Registra_Cotizacion_Aviso(ByVal id_aviso As Integer, ByVal desc_cotizacion As String, ByVal id_moneda As Integer,
                                         ByVal id_usuario As Integer, ByVal fec_ini_serv_cotizacion As DateTime, ByVal fec_fin_serv_cotizacion As DateTime,
                                         ByVal monto_total_cotizacion As Decimal) As Integer
        Dim id_aviso_cotizacion As Integer
        id_aviso_cotizacion = obj.Registra_Cotizacion_Aviso(id_aviso, desc_cotizacion, id_moneda, id_usuario, fec_ini_serv_cotizacion,
                                                            fec_fin_serv_cotizacion, monto_total_cotizacion)
        Return id_aviso_cotizacion
    End Function
    Public Function lista_cotizaciones_aviso(ByVal id_aviso As Integer) As DataSet
        Dim ds As New DataSet
        ds = obj.lista_cotizaciones_aviso(id_aviso)
        Return ds
    End Function

    Public Function Registra_detalle_cotizacion(ByVal id_aviso_cotizacion As Integer, ByVal cod_comp_det_aviso_cotizacion As String, ByVal cod_um_det_aviso_cotizacion As String,
                                                ByVal cant_det_aviso_cotizacion As Decimal, ByVal prec_det_aviso_cotizacion As Decimal, ByVal desc_det_aviso_cotizacion As String, ByVal tipo As String) As Boolean
        Dim resultado As Boolean
        resultado = obj.Registra_detalle_cotizacion(id_aviso_cotizacion, cod_comp_det_aviso_cotizacion, cod_um_det_aviso_cotizacion, cant_det_aviso_cotizacion, prec_det_aviso_cotizacion, desc_det_aviso_cotizacion, tipo)

        Return resultado
    End Function

    Public Function Detalle_Cotizacion_Proveedor(ByVal id_aviso_cotizacion As Integer) As DataSet
        Dim ds As New DataSet
        ds = obj.Detalle_Cotizacion_Proveedor(id_aviso_cotizacion)
        Return ds
    End Function

    Public Function Modificar_Cotizacion_Aviso(ByVal id_aviso_cotizacion As Integer, ByVal desc_cotizacion As String, ByVal id_moneda As Integer,
                                       ByVal id_usuario As Integer, ByVal fec_ini_serv_cotizacion As DateTime, ByVal fec_fin_serv_cotizacion As DateTime,
                                       ByVal monto_total_cotizacion As Decimal) As Integer

        id_aviso_cotizacion = obj.Modificar_Cotizacion_Aviso(id_aviso_cotizacion, desc_cotizacion, id_moneda, id_usuario, fec_ini_serv_cotizacion,
                                                            fec_fin_serv_cotizacion, monto_total_cotizacion)
        Return id_aviso_cotizacion
    End Function

    Public Function Elimina_Cotizacion_Aviso(ByVal id_aviso_cotizacion As Integer, ByVal id_usuario As Integer) As Boolean
        Dim resultado As Boolean
        resultado = obj.Elimina_Cotizacion_Aviso(id_aviso_cotizacion, id_usuario)

        Return resultado
    End Function

    Public Function Registra_Estado_Aviso_3(ByVal id_aviso As Integer, ByVal id_usuario As Integer) As Boolean
        Dim resultado As Boolean
        resultado = obj.Registra_Estado_Aviso_3(id_aviso, id_usuario)

        Return resultado
    End Function

    Public Function Registra_Estado_Aviso_4(ByVal id_aviso As Integer, ByVal id_usuario As Integer, ByVal code_aviso_estado As String,
                                            ByVal msj_aviso_estado As String, ByVal aufnr_aviso_estado As String) As Boolean
        Dim resultado As Boolean
        resultado = obj.Registra_Estado_Aviso_4(id_aviso, id_usuario, code_aviso_estado, msj_aviso_estado, aufnr_aviso_estado)

        Return resultado
    End Function
    Public Function Registra_Estado_Aviso_4_LogApi(ByVal id_aviso As Integer, ByVal id_usuario As Integer, ByVal code_aviso_estado As String,
                                            ByVal msj_aviso_estado As String, ByVal aufnr_aviso_estado As String) As Boolean
        Dim resultado As Boolean
        resultado = obj.Registra_Estado_Aviso_4_LogApi(id_aviso, id_usuario, code_aviso_estado, msj_aviso_estado, aufnr_aviso_estado)

        Return resultado
    End Function


    Public Function Registra_Estado_Aviso_5(ByVal id_aviso As Integer, ByVal id_usuario As Integer, ByVal sustento_rechazo As String) As Boolean
        Dim resultado As Boolean
        resultado = obj.Registra_Estado_Aviso_5(id_aviso, id_usuario, sustento_rechazo)

        Return resultado
    End Function

    Public Function Registra_Estado_Aviso_8(ByVal id_aviso As Integer, ByVal id_usuario As Integer) As Boolean
        Dim resultado As Boolean
        resultado = obj.Registra_Estado_Aviso_8(id_aviso, id_usuario)

        Return resultado
    End Function

    Public Function Registra_Estado_Aviso_8_final(ByVal id_aviso As Integer, ByVal id_usuario As Integer, ByVal nro_hes As String,
                                            ByVal fecha_contable_hes As DateTime) As Boolean
        Dim resultado As Boolean
        resultado = obj.Registra_Estado_Aviso_8_final(id_aviso, id_usuario, nro_hes, fecha_contable_hes)

        Return resultado
    End Function

    Public Function valida_credenciales(ByVal user As String, ByVal clave As String) As DataSet
        Dim ds As New DataSet
        ds = obj.valida_credenciales(user, clave)
        Return ds
    End Function

    Public Function Datos_Api_1(ByVal id_aviso As Integer) As DataSet
        Dim ds As New DataSet
        ds = obj.Datos_Api_1(id_aviso)
        Return ds
    End Function

    Public Function Registra_Estado_Aviso_7(ByVal id_aviso As Integer, ByVal id_usuario As Integer, ByVal sustento_proveedor As String) As Boolean
        Dim resultado As Boolean
        resultado = obj.Registra_Estado_Aviso_7(id_aviso, id_usuario, sustento_proveedor)

        Return resultado
    End Function

    Public Function Registra_Archivos_Adjuntos_Fisico_prov_sustento_proveedor(ByVal id_aviso As Integer, ByVal nom_archivo As String) As Boolean
        Dim resultado As Boolean
        resultado = obj.Registra_Archivos_Adjuntos_Fisico_sustento_proveedor(id_aviso, nom_archivo)

        Return resultado
    End Function

    Public Function Cotizacion_aprobada_aviso(ByVal id_aviso As Integer, ByVal nro_cotizacion As String) As Boolean
        Dim resultado As Boolean
        resultado = obj.Cotizacion_aprobada_aviso(id_aviso, nro_cotizacion)

        Return resultado
    End Function

    Public Function Datos_Api_3(ByVal id_aviso As Integer) As DataSet
        Dim ds As New DataSet
        ds = obj.Datos_Api_3(id_aviso)
        Return ds
    End Function

    Public Function ExisteTokenActivo(ByVal token As String) As DataSet
        Dim ds As New DataSet
        ds = obj.ExisteTokenActivo(token)
        Return ds
    End Function

    Public Function CerrarSesionGlobal(ByVal tokenGlobal As String) As Boolean

        obj.CerrarSesionGlobal(tokenGlobal)
        Return True
    End Function

    Public Function Registro_SesionSistema(ByVal tokenGlobal As String, ByVal usuario As String, ByVal CodigoSistema As String, ByVal PaginaAcceso As String) As Boolean

        obj.Registro_SesionSistema(tokenGlobal, usuario, CodigoSistema, PaginaAcceso)
        Return True
    End Function
End Class
