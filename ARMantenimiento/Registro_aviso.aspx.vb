Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Web.Script.Serialization
Imports System.Xml
Imports Newtonsoft.Json

Public Class Registro_aviso
	Inherits System.Web.UI.Page
	Dim obj As New Negocio.NManto
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		CargarActivacionGeneral()

		If Not Page.IsPostBack Then

			If Session("user") IsNot Nothing Then 'El usuario tiene su sesion activa
				'Registro Auditoria
				registro_acceso_pagina(Session("ACTIVACION_GENERAL").ToString(), Session("SistemaAcceso").ToString(), Session("user").ToString())
			End If

			hdnActiveTab.Value = "#tab1" ' Valor inicial
			'Lista desplegables
			datos_superior_usuario()
				Lista_Unidades_usuario()
				Lista_clase()
				Lista_Diagnostico_inicial()
				Lista_area_solicitante()
				Lista_impacto_aviso()

				'Lista desplegables de seleccion de proveedor
				Lista_FamiliaServicio()


				'Lista_Prioridad()

				'Carga datos del aviso

				Dim id_aviso As Integer
				Dim id_aviso_Grilla As Integer
				id_aviso_Grilla = 0

				id_aviso_Grilla = Request.QueryString("id_aviso")

				If id_aviso_Grilla = 0 Then
					'Carga blanco, para un nuevo registro
					cargar_datos_aviso(id_aviso) 'id_Aviso = 0

				Else
					'Carga id_aviso_grilla con lo seleccionado
					cargar_datos_aviso(id_aviso_Grilla) 'Para empezar el flujo
				End If


				'Es un registro Nuevo
				'If id_aviso = 0 Then

				'End If
				Session("dt_adjuntos") = Nothing 'Adjuntos al crear el aviso
				Session("dt_adjuntos_p") = Nothing 'Adjunto del sustento del proveedor

				'Grilla cotizaciones
				InicializarTabla()
				BindGrid()
				CargarGrillaInicial() 'Listado fictisio
			End If


	End Sub

	Public Sub datos_superior_usuario()
		Dim id_perfil As Integer = Integer.Parse(Session("id_perfil").ToString())

		lbluserad.Text = Session("user").ToString()

		If id_perfil = 27 Then
			lbldesc_perfil.Text = "Perfil Dios"
		End If
		If id_perfil = 28 Then
			lbldesc_perfil.Text = "Administrador de Unidad"
		End If
		If id_perfil = 29 Then
			lbldesc_perfil.Text = "Jefe de Mantenimiento"
		End If
		If id_perfil = 30 Then
			lbldesc_perfil.Text = "Equipo de Mantenimiento"
		End If
		If id_perfil = 31 Then
			lbldesc_perfil.Text = "Proveedor"
		End If
		If id_perfil = 32 Then
			lbldesc_perfil.Text = "Limitado"
		End If

		'27  Perfil Dios
		'28  Administrador de Unidad
		'29  Jefe de Mantenimiento
		'30  Equipo de Mantenimiento
		'31  Proveedor
		'32  Limitado



	End Sub
	'Public Sub Lista_Prioridad()
	'	Dim ds As New DataSet()
	'	ds = obj.Lista_Prioridad_Aviso()
	'	cboprioridad_aviso.DataSource = ds.Tables(0)
	'	cboprioridad_aviso.DataTextField = "desc_prioridad_aviso"
	'	cboprioridad_aviso.DataValueField = "cod_prioridad_aviso"
	'	cboprioridad_aviso.DataBind()
	'	ds.Dispose()

	'End Sub

	Public Sub Lista_Unidades_usuario()

		Dim ds As New DataSet()
		ds = Session("unidades_usuario") 'Se captura en el Login de Usuario
		cbounidad_usuario_aviso.DataSource = ds.Tables(0)
		cbounidad_usuario_aviso.DataTextField = "desc_unidad"
		cbounidad_usuario_aviso.DataValueField = "ceco"

		If ds.Tables(0).Rows.Count = 2 Then 'Si solo existe uno aparezca seleccionado por default
			cbounidad_usuario_aviso.SelectedIndex = 1
		End If


		cbounidad_usuario_aviso.DataBind()
		ds.Dispose()


	End Sub

	Public Sub Lista_clase()
		Dim ds As New DataSet()
		ds = obj.Lista_Clase()
		cboclase_aviso.DataSource = ds.Tables(0)
		cboclase_aviso.DataTextField = "desc_clase_aviso"
		cboclase_aviso.DataValueField = "id_clase_aviso"
		cboclase_aviso.DataBind()
		ds.Dispose()

	End Sub

	Public Sub Lista_Diagnostico_inicial()
		Dim ds As New DataSet()
		ds = obj.Lista_Diagnostico_Inicial()
		cbodiagnostico_ini_aviso.DataSource = ds.Tables(0)
		cbodiagnostico_ini_aviso.DataTextField = "desc_diagnostico_ini_aviso"
		cbodiagnostico_ini_aviso.DataValueField = "id_diagnostico_ini_aviso"
		cbodiagnostico_ini_aviso.DataBind()
		ds.Dispose()

	End Sub

	Public Sub Lista_area_solicitante()
		Dim ds As New DataSet()
		ds = obj.Lista_area_solicitante()
		cboarea_solic_aviso.DataSource = ds.Tables(0)
		cboarea_solic_aviso.DataTextField = "desc_area_solic_aviso"
		cboarea_solic_aviso.DataValueField = "id_area_solic_aviso"
		cboarea_solic_aviso.DataBind()
		ds.Dispose()

	End Sub

	Public Sub Lista_impacto_aviso()
		Dim ds As New DataSet()
		ds = obj.Lista_impacto_aviso()
		cboimpacto_aviso.DataSource = ds.Tables(0)
		cboimpacto_aviso.DataTextField = "desc_diagnostico_ini_aviso"
		cboimpacto_aviso.DataValueField = "id_impacto_aviso"
		cboimpacto_aviso.DataBind()
		ds.Dispose()

	End Sub
	Public Sub Lista_FamiliaServicio()
		Dim ds As New DataSet()
		ds = obj.Lista_FamiliaServicio()
		cbofamiliaservicio_aviso.DataSource = ds.Tables(0)
		cbofamiliaservicio_aviso.DataTextField = "cod_presupuestal_servicio"
		cbofamiliaservicio_aviso.DataValueField = "id_familia_servicio"
		cbofamiliaservicio_aviso.DataBind()
		ds.Dispose()

	End Sub
	Protected Sub btnBuscarEquipo_Click(sender As Object, e As EventArgs) Handles btnBuscarEquipo.Click
		ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", "<script>popup()</script>", False)
	End Sub

	Protected Sub btnBuscarEquipos_Click(sender As Object, e As EventArgs) Handles btnBuscarEquipos.Click

		System.Threading.Thread.Sleep(2000)
		Buscar_equipos()
	End Sub
	Public Sub Buscar_equipos()
		Dim serie As String
		Dim marca As String
		Dim codigo As String
		Dim desc_equipo As String
		Dim centro As String
		Dim codigo_qr As String
		Dim ds As New DataSet()

		serie = txtserie_FB.Text.ToString()
		marca = txtmarca_FB.Text.ToString()
		codigo = txtcodequipo_FB.Text.ToString()
		desc_equipo = txtdescequipo_FB.Text.ToString()
		centro = cbounidad_usuario_aviso.SelectedValue.ToString()
		codigo_qr = txtcodequipoQR_FB.Text.ToString()

		ds = obj.Filtro_Busqueda_Equipos(codigo, serie, marca, desc_equipo, centro, codigo_qr)
		grvlistadoEquipos.DataSource = ds.Tables(0)
		grvlistadoEquipos.DataBind()

		ds.Dispose()

		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_busqueda_equipos", "$('#myModal_busqueda_equipos').modal();", True)

	End Sub

	Protected Sub grvlistadoEquipos_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grvlistadoEquipos.RowCommand
		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		If e.CommandName = "seleccionar" Then
			Dim codigo_equipo As String
			codigo_equipo = (e.CommandArgument).ToString()

			For Each gvClaserow As GridViewRow In grvlistadoEquipos.Rows
				Dim lbldes_equipo_FB As Label
				Dim lblserie_FB As Label
				Dim lblmarca_FB As Label
				Dim lblcodigo_equipo_FB As Label

				lbldes_equipo_FB = gvClaserow.FindControl("lbldes_equipo_FB")
				lblserie_FB = gvClaserow.FindControl("lblserie_FB")
				lblmarca_FB = gvClaserow.FindControl("lblmarca_FB")
				lblcodigo_equipo_FB = gvClaserow.FindControl("lblcodigo_equipo_FB")

				If codigo_equipo = lblcodigo_equipo_FB.Text Then
					lblEquipo.Text = codigo_equipo.ToString() + " / " + lbldes_equipo_FB.Text.ToString()
					ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", "<script>cerrar_popup_equipos()</script>", False)
				End If
			Next
		End If
	End Sub

	Protected Sub btnCerrarPopupEquipos_Click(sender As Object, e As EventArgs) Handles btnCerrarPopupEquipos.Click
		' ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_busqueda", "$('#myModal_busqueda').modal('hide');", False)
		ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", "<script>cerrarModalEquipos()</script>", False)

	End Sub

	Protected Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If
		Dim id_aviso As Integer
		Dim id_usuario As Integer
		Dim cc_unidad_aviso As String
		Dim titulo_aviso As String
		Dim id_area_solic_aviso As Integer
		Dim id_diagnostico_ini_aviso As Integer
		Dim id_clase_aviso As Integer
		Dim id_impacto_aviso As Integer
		Dim id_prioridad_aviso As Integer
		Dim cod_equipo_aviso As String
		Dim desc_equipo_aviso As String
		Dim desc_aviso As String

		Dim validacion_error As String = ""
		Dim mensaje_error_concatenado As String = ""

		'USUARIO
		id_usuario = Integer.Parse(Session("id_usuario").ToString())

		'UNIDAD

		If cbounidad_usuario_aviso.SelectedIndex = 0 Then
			If mensaje_error_concatenado = "" Then
				mensaje_error_concatenado = "Unidad"
			Else
				mensaje_error_concatenado = mensaje_error_concatenado & " / Unidad"
			End If
			cbounidad_usuario_aviso.CssClass += " resaltar-obligatorio"
			validacion_error = "1"

		Else
			cbounidad_usuario_aviso.CssClass = cbounidad_usuario_aviso.CssClass.Replace("resaltar-obligatorio", "").Trim()
			cc_unidad_aviso = cbounidad_usuario_aviso.SelectedValue.ToString()
		End If

		'TITULO DEL AVISO

		If txttitulo_aviso.Text = "" Then
			If mensaje_error_concatenado = "" Then
				mensaje_error_concatenado = "Titulo del Aviso"
			Else
				mensaje_error_concatenado = mensaje_error_concatenado & " / Titulo del Aviso"
			End If

			txttitulo_aviso.CssClass += " resaltar-obligatorio"
			validacion_error = "1"

		Else
			txttitulo_aviso.CssClass = txttitulo_aviso.CssClass.Replace("resaltar-obligatorio", "").Trim()
			titulo_aviso = txttitulo_aviso.Text.ToString()
		End If


		'AREA SOLICITANTE

		If cboarea_solic_aviso.SelectedIndex = 0 Then
			If mensaje_error_concatenado = "" Then
				mensaje_error_concatenado = "Área solicitante"
			Else
				mensaje_error_concatenado = mensaje_error_concatenado & " / Área solicitante"
			End If

			cboarea_solic_aviso.CssClass += " resaltar-obligatorio"
			validacion_error = "1"
		Else
			cboarea_solic_aviso.CssClass = cboarea_solic_aviso.CssClass.Replace("resaltar-obligatorio", "").Trim()
			id_area_solic_aviso = cboarea_solic_aviso.SelectedValue.ToString()
		End If


		'DIAGNOSTICO INICIAL

		If cbodiagnostico_ini_aviso.SelectedIndex = 0 Then
			If mensaje_error_concatenado = "" Then
				mensaje_error_concatenado = "Diagnóstico Inicial"
			Else
				mensaje_error_concatenado = mensaje_error_concatenado & " / Diagnóstico Inicial"
			End If

			cbodiagnostico_ini_aviso.CssClass += " resaltar-obligatorio"
			validacion_error = "1"
		Else
			cbodiagnostico_ini_aviso.CssClass = cbodiagnostico_ini_aviso.CssClass.Replace("resaltar-obligatorio", "").Trim()
			id_diagnostico_ini_aviso = cbodiagnostico_ini_aviso.SelectedValue.ToString()
		End If

		'CLASE AVISO
		If cboclase_aviso.SelectedIndex = 0 Then
			If mensaje_error_concatenado = "" Then
				mensaje_error_concatenado = "Clase"
			Else
				mensaje_error_concatenado = mensaje_error_concatenado & " / Clase"
			End If

			cboclase_aviso.CssClass += " resaltar-obligatorio"
			validacion_error = "1"
		Else
			cboclase_aviso.CssClass = cboclase_aviso.CssClass.Replace("resaltar-obligatorio", "").Trim()
			id_clase_aviso = cboclase_aviso.SelectedValue.ToString()
		End If

		'IMPACTO

		If cboimpacto_aviso.SelectedIndex = 0 Then
			If mensaje_error_concatenado = "" Then
				mensaje_error_concatenado = "Impacto"
			Else
				mensaje_error_concatenado = mensaje_error_concatenado & " / Impacto"
			End If

			cboimpacto_aviso.CssClass += " resaltar-obligatorio"
			validacion_error = "1"
		Else
			cboimpacto_aviso.CssClass = cboimpacto_aviso.CssClass.Replace("resaltar-obligatorio", "").Trim()
			id_impacto_aviso = cboimpacto_aviso.SelectedValue.ToString()
		End If


		'EQUIPO

		If lblEquipo.Text = "" Then
			If mensaje_error_concatenado = "" Then
				mensaje_error_concatenado = "Equipo"
			Else
				mensaje_error_concatenado = mensaje_error_concatenado & " / Equipo"
			End If

			lblEquipo.CssClass += " resaltar-obligatorio"
			validacion_error = "1"

		Else
			lblEquipo.CssClass = lblEquipo.CssClass.Replace("resaltar-obligatorio", "").Trim()
			cod_equipo_aviso = lblEquipo.Text.ToString() 'Hay que extraer el codigo!!!!!!
			cod_equipo_aviso = cod_equipo_aviso.Split("/"c)(0).Trim()
			desc_equipo_aviso = lblEquipo.Text.ToString().Split("/"c)(1).Trim()
		End If




		'DESCRIPCION AVISO

		If txtdescripcion_aviso.Text = "" Then
			If mensaje_error_concatenado = "" Then
				mensaje_error_concatenado = "Descripción del aviso"
			Else
				mensaje_error_concatenado = mensaje_error_concatenado & " / Descripción del aviso"
			End If

			txtdescripcion_aviso.CssClass += " resaltar-obligatorio"
			validacion_error = "1"

		Else
			txtdescripcion_aviso.CssClass = lblEquipo.CssClass.Replace("resaltar-obligatorio", "").Trim()
			desc_aviso = txtdescripcion_aviso.Text.ToString()
		End If

		Dim dt_adjuntos_v As New DataTable()
		dt_adjuntos_v = Session("dt_adjuntos")
		If dt_adjuntos_v Is Nothing Then
			mensaje_error_concatenado = "Fotografía adjunta"
			validacion_error = "1"
		End If

		If validacion_error = "1" Then 'Si existe algun error de campo obligatorio
			lblmensajex.Text = "Favor de completar lo siguiente: " + mensaje_error_concatenado
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje", "$('#myModal_Mensaje').modal('show');", True)
			Return
		Else 'Registro del Aviso

			'PRIORIDAD - hay que extraer el codigo!!!!
			Dim prioridad As String
			prioridad = txtprioridad_aviso.Text.Split(":"c)(0).Trim()
			id_prioridad_aviso = Integer.Parse(prioridad)

			'Registrar Documento de Nuevo aviso

			id_aviso = obj.Registra_Nuevo_Aviso(id_usuario, cc_unidad_aviso, titulo_aviso, id_area_solic_aviso, id_diagnostico_ini_aviso,
						id_clase_aviso, id_impacto_aviso, id_prioridad_aviso, cod_equipo_aviso, desc_aviso, desc_equipo_aviso)

			'Registrar Archivos Adjuntos
			Dim j As Integer = 0
			Dim Adjuntos_Cliente As String
			Dim Adjuntos_Cliente_Temp As String

			'Ubicaciones
			Adjuntos_Cliente = ConfigurationManager.AppSettings("Adjuntos_Cliente")
			Adjuntos_Cliente_Temp = ConfigurationManager.AppSettings("Adjuntos_Cliente_Temp")

			'Archivos adjuntos del Aviso

			Dim dt_adjuntos As New DataTable()
			dt_adjuntos = Session("dt_adjuntos")
			If dt_adjuntos IsNot Nothing Then
				For j = 0 To dt_adjuntos.Rows.Count - 1
					Dim nombre_archivo As String
					nombre_archivo = dt_adjuntos.Rows(j)(2).ToString()

					'Copio archivo a la carpeta principal
					My.Computer.FileSystem.CopyFile(Adjuntos_Cliente_Temp + "\" + nombre_archivo, Adjuntos_Cliente + "\" + nombre_archivo, True)
					'Eliminar archivo de la ubicacion origen
					My.Computer.FileSystem.DeleteFile(Adjuntos_Cliente_Temp + "\" + nombre_archivo)

					obj.Registra_Archivos_Adjuntos_Fisico(id_aviso, nombre_archivo)
				Next
			End If


			'Archivos adjuntos del sustento del proveedor

			'Dim dt_adjuntos_p As New DataTable()
			'dt_adjuntos_p = Session("dt_adjuntos_p")
			'If dt_adjuntos_p IsNot Nothing Then
			'	For j = 0 To dt_adjuntos_p.Rows.Count - 1
			'		Dim nombre_archivo As String
			'		nombre_archivo = dt_adjuntos.Rows(j)(2).ToString()

			'		'Copio archivo a la carpeta principal
			'		My.Computer.FileSystem.CopyFile(Adjuntos_Cliente_Temp + "\" + nombre_archivo, Adjuntos_Cliente + "\" + nombre_archivo, True)
			'		'Eliminar archivo de la ubicacion origen
			'		My.Computer.FileSystem.DeleteFile(Adjuntos_Cliente_Temp + "\" + nombre_archivo)

			'		obj.Registra_Archivos_Adjuntos_Fisico_prov_sustento_proveedor(id_aviso, nombre_archivo)
			'	Next
			'End If


			lbltituloMensaje.Text = "Proceso Correctamente"
			iconoConfirmacion.Visible = True
			iconoError.Visible = False

			'Cargar los Datos del Nuevo Aviso en pantalla
			cargar_datos_aviso(id_aviso)

			lblmensajeconfirmacion.Text = "Se ha registrado el aviso de manera exitosa."
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_confirmacion", "$('#myModal_Mensaje_confirmacion').modal('show');", True)


		End If






	End Sub
	Public Sub cargar_datos_aviso(ByVal id_aviso As Integer)
		Dim id_estado As Integer

		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		'----- NUEVO REGISTRO --------
		If id_aviso = 0 Then 'No tiene aviso, es un nuevo registro
			PnlBotonRegistroInicial.Visible = True
			pnlbotonrechazar.Visible = False
			Pnlbotonaprobar.Visible = False

		End If

		'----- REGISTRO EXISTENTE ----------

		If id_aviso <> 0 Then 'No tiene aviso, es un nuevo registro
			PnlBotonRegistroInicial.Visible = False
			pnlbotonrechazar.Visible = True
			Pnlbotonaprobar.Visible = True
			pnllineatiempo_datos.Visible = True

			'1. Traer datos con el id_aviso
			Dim ds_detalle As New DataSet()
			ds_detalle = obj.Detalle_aviso_seleccionado(id_aviso)

			lblnro_aviso.Text = ds_detalle.Tables(0).Rows(0)(1).ToString()
			lblid_aviso.Text = id_aviso.ToString()

			lblfec_reg_aviso.Text = ds_detalle.Tables(0).Rows(0)(2).ToString()
			lblusuario_registro.Text = ds_detalle.Tables(0).Rows(0)(4).ToString()
			lblfec_modif_aviso.Text = ds_detalle.Tables(0).Rows(0)(5).ToString()

			Dim cc_unidad_aviso As String
			cc_unidad_aviso = ds_detalle.Tables(0).Rows(0)(7).ToString()
			cbounidad_usuario_aviso.SelectedValue = cc_unidad_aviso.ToString()

			txttitulo_aviso.Text = ds_detalle.Tables(0).Rows(0)(8).ToString()

			Dim id_area_solic_aviso As Integer
			id_area_solic_aviso = Integer.Parse(ds_detalle.Tables(0).Rows(0)(9).ToString())
			cboarea_solic_aviso.SelectedValue = id_area_solic_aviso

			Dim id_diagnostico_ini_aviso As Integer
			id_diagnostico_ini_aviso = Integer.Parse(ds_detalle.Tables(0).Rows(0)(10).ToString())
			cbodiagnostico_ini_aviso.SelectedValue = id_diagnostico_ini_aviso

			Dim id_clase_aviso As Integer
			id_clase_aviso = Integer.Parse(ds_detalle.Tables(0).Rows(0)(11).ToString())
			cboclase_aviso.SelectedValue = id_clase_aviso

			txtprioridad_aviso.Text = ds_detalle.Tables(0).Rows(0)(16).ToString()
			'Equipo falta la descripcion

			Dim impacto_aviso As Integer
			impacto_aviso = Integer.Parse(ds_detalle.Tables(0).Rows(0)(12).ToString())
			cboimpacto_aviso.SelectedValue = impacto_aviso

			Dim desc_equipo_aviso As String
			Dim cod_equipo_aviso As String

			cod_equipo_aviso = ds_detalle.Tables(0).Rows(0)(14).ToString()
			desc_equipo_aviso = ds_detalle.Tables(0).Rows(0)(17).ToString()
			lblEquipo.Text = cod_equipo_aviso + " / " + desc_equipo_aviso


			txtdescripcion_aviso.Text = ds_detalle.Tables(0).Rows(0)(15).ToString()

			'Traer el listado de clase OTM, de acuerdo al id_clase
			Dim dsOTM As New DataSet
			dsOTM = obj.Lista_Clase_OTM(id_clase_aviso)
			cboclaseotm_aviso.DataSource = dsOTM.Tables(0)
			cboclaseotm_aviso.DataValueField = "id_clase_otm"
			cboclaseotm_aviso.DataTextField = "desc_clase_otm"
			cboclaseotm_aviso.DataBind()
			dsOTM.Dispose()

			Dim id_clase_otm As Integer
			id_clase_otm = Integer.Parse(ds_detalle.Tables(0).Rows(0)(18).ToString())
			cboclaseotm_aviso.SelectedValue = id_clase_otm
			cboclaseotm_aviso.DataBind()


			'Traer Familia y Subfamilia

			Dim id_subfamilia_servicio As Integer
			Dim id_familia_servicio As Integer
			id_familia_servicio = Integer.Parse(ds_detalle.Tables(0).Rows(0)(20).ToString())
			id_subfamilia_servicio = Integer.Parse(ds_detalle.Tables(0).Rows(0)(19).ToString())

			cbofamiliaservicio_aviso.SelectedValue = id_familia_servicio
			Lista_subfamilia_servicio(id_familia_servicio)
			cbosubfamiliaservicio_aviso.SelectedValue = id_subfamilia_servicio


			'Mostrar datos de la pestaña proveedor
			Dim ruc_proveedor As String
			Dim razon_social_proveedor As String


			ruc_proveedor = ds_detalle.Tables(0).Rows(0)(21).ToString()
			razon_social_proveedor = ds_detalle.Tables(0).Rows(0)(22).ToString()
			If ruc_proveedor = "" Then
				lblrucproveedor_aviso.Text = ""
			Else
				lblrucproveedor_aviso.Text = ruc_proveedor + " / " + razon_social_proveedor
				lblrazosocial_proveedor_cotizacion.Text = ruc_proveedor + " / " + razon_social_proveedor
				lblrucproveedorSAP_aviso.Text = ds_detalle.Tables(0).Rows(0)(26).ToString()
			End If



			'grupo de compras
			If ds_detalle.Tables(0).Rows(0)(23).ToString() = "" Then
				lblgrupocompras_aviso.Text = "S18"
			Else
				lblgrupocompras_aviso.Text = ds_detalle.Tables(0).Rows(0)(23).ToString()
			End If



			'Fecha inicio y fin de coti
			If ds_detalle.Tables(0).Rows(0)(24).ToString() <> "" Then
				Dim FechaInicioCotizacion As DateTime = DateTime.Parse(ds_detalle.Tables(0).Rows(0)(24).ToString())
				txtFechaInicioCotizacion.Text = FechaInicioCotizacion.ToString("yyyy-MM-dd")

				Dim FechaFinCotizacion As DateTime = DateTime.Parse(ds_detalle.Tables(0).Rows(0)(25).ToString())
				txtFechaFinCotizacion.Text = FechaFinCotizacion.ToString("yyyy-MM-dd")

			End If


			'2. Mostrar el listado de archivos adjuntos

			grvadjuntos.DataSource = ds_detalle.Tables(1)
			grvadjuntos.DataBind()

			If ds_detalle.Tables(1).Rows.Count > 0 Then 'Tiene archivos adjuntos
				For Each row As GridViewRow In grvadjuntos.Rows
					Dim btnDownload As LinkButton = CType(row.FindControl("btnDownload"), LinkButton)
					Dim btneliminar As LinkButton = CType(row.FindControl("btneliminar"), LinkButton)

					btnDownload.Visible = True
					btneliminar.Visible = False
				Next
			End If

			'3. Mostrar el listado de archivos adjuntos - Sustento de Proveedores

			grvadjuntos_p.DataSource = ds_detalle.Tables(6)
			grvadjuntos_p.DataBind()

			If ds_detalle.Tables(6).Rows.Count > 0 Then 'Tiene archivos adjuntos
				For Each row As GridViewRow In grvadjuntos_p.Rows
					Dim btnDownload As LinkButton = CType(row.FindControl("btnDownload_p"), LinkButton)
					Dim btneliminar As LinkButton = CType(row.FindControl("btneliminar_p"), LinkButton)

					btnDownload.Visible = True
					btneliminar.Visible = False
				Next
			End If


			'pintado de linea de tiempo segun estado

			id_estado = Integer.Parse(ds_detalle.Tables(0).Rows(0)(6).ToString())
			lblid_estado.Text = id_estado.ToString()
			PintarTimeline(id_estado)

			'Muestra las cotizaciones del aviso - Listado
			Lista_Cotizaciones_aviso()

			'Muestra sustento de rechazo cotizaciones
			If ds_detalle.Tables(2).Rows.Count > 0 Then
				txtsustento_rechazo_cotizacion.Text = ds_detalle.Tables(2).Rows(0)(0).ToString()
			End If

			'OTM - API
			If ds_detalle.Tables(5).Rows.Count <> 0 Then
				txtOTM.Text = ds_detalle.Tables(5).Rows(0)(0).ToString()
			End If



			'Muestra OC generadas por el API

			If ds_detalle.Tables(3).Rows.Count <> 0 Then
				Dim OC_cadena As String
				OC_cadena = ds_detalle.Tables(3).Rows(0)(0).ToString()
				txtOC.Text = OC_cadena.ToString()
			End If


			'Sustento ingresado por el proveedor
			If ds_detalle.Tables(4).Rows.Count <> 0 Then
				txtsustento_ingresado_proveedor.Text = ds_detalle.Tables(4).Rows(0)(0).ToString()
			End If

			If ds_detalle.Tables(7).Rows.Count <> 0 Then
				txtdocumento_hes.Text = ds_detalle.Tables(7).Rows(0)(0).ToString()
			End If

		End If



		'Bloquear controles en la pagina segun perfil y estado
		Dim id_perfil As Integer
		id_perfil = Session("id_perfil")
		Bloqueo_Controles_Perfil_Estado(id_estado, id_perfil)

	End Sub

	Protected Sub btnAdjuntarP_Click(sender As Object, e As EventArgs) Handles btnAdjuntarP.Click
		Try
			If Session("user") Is Nothing Then
				Response.Redirect("~/login.aspx", True)
				Exit Sub
			End If

			Dim IPSERVER As String
			Dim itemAgregado As String
			Dim existe As String = "0"
			Dim ruta As String
			IPSERVER = ConfigurationManager.AppSettings("Adjuntos_Cliente_Temp")

			'Dim dt_adjuntos As New DataTable()
			'dt_adjuntos.Columns.AddRange(New DataColumn() {
			'									New DataColumn("nom_archivo_original", GetType(String)),
			'									New DataColumn("nom_archivo_server", GetType(String))
			'})
			Dim dt_adjuntos As New DataTable()
			dt_adjuntos.Columns.AddRange(New DataColumn() {
				New DataColumn("id_aviso_adjunto", GetType(Integer)),
				New DataColumn("nom_archivo_original", GetType(String)),
				New DataColumn("nom_archivo_server", GetType(String))
			})



			' If FileUpload1.HasFile Then
			If inputGroupFile04.HasFile Then
				Dim año As String
				Dim mes As String
				Dim dia As String
				Dim Hor As String
				Dim min As String
				Dim seg As String

				año = Date.Now.Year.ToString()
				mes = Date.Now.Month.ToString()
				dia = Date.Now.Day.ToString()
				Hor = Date.Now.Hour.ToString()
				min = Date.Now.Minute.ToString()
				seg = Date.Now.Second.ToString()

				Dim ext As String
				ext = System.IO.Path.GetExtension(inputGroupFile04.FileName)



				Dim archivo_general As String
				Dim ad_usuario As String
				ad_usuario = Session("user").ToString()

				archivo_general = ad_usuario + "_" + año + mes + dia + Hor + min + seg + "_" + inputGroupFile04.FileName

				inputGroupFile04.SaveAs(IPSERVER + "\" + archivo_general) 'Guardamos en Temporal antes de la principal


				If Session("dt_adjuntos") Is Nothing Then
					dt_adjuntos.Rows.Add(0, inputGroupFile04.FileName.ToString(), archivo_general)
					Session("dt_adjuntos") = dt_adjuntos
				Else
					dt_adjuntos = Session("dt_adjuntos")
					dt_adjuntos.Rows.Add(0, inputGroupFile04.FileName.ToString(), archivo_general)
					Session("dt_adjuntos") = dt_adjuntos

				End If
				'End If




				'Almacena en datatable - grilla

				grvadjuntos.DataSource = dt_adjuntos
				grvadjuntos.DataBind()


			End If
		Catch ex As Exception

		End Try
	End Sub

	Private Sub grvadjuntos_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grvadjuntos.RowCommand
		If e.CommandName = "EliminaAdjunto" Then

			'Es un registro Nuevo y la eliminacion solo es en pantalla
			If lblnro_aviso.Text = "" Then

				Dim NombreArchivo_eliminar As String
				NombreArchivo_eliminar = (e.CommandArgument).ToString()

				Dim dt_adjuntos As New DataTable()
				dt_adjuntos.Columns.AddRange(New DataColumn() {
												New DataColumn("nom_archivo_original", GetType(String)),
												New DataColumn("nom_archivo_server", GetType(String))
			})

				dt_adjuntos = Session("dt_adjuntos")

				Dim i As Integer = 0
				Dim can As Integer = 0
				can = dt_adjuntos.Rows.Count

				For i = 0 To can - 1
					Dim nom_archivo As String
					nom_archivo = dt_adjuntos.Rows(i)(1).ToString

					If NombreArchivo_eliminar = nom_archivo Then
						dt_adjuntos.Rows(i).Delete()
						Exit For
					End If
				Next




				Session("dt_adjuntos") = dt_adjuntos
				grvadjuntos.DataSource = dt_adjuntos
				grvadjuntos.DataBind()

				'txtuno.Text = dt_adjuntos.Rows.Count.ToString()
			Else 'Ya existe el documento y la eliminacion es en BD

			End If


		End If

		If e.CommandName = "DescargarAdjunto" Then
			ID = (e.CommandArgument).ToString()
			For Each gvClaserow As GridViewRow In grvadjuntos.Rows
				Dim label_id As Label
				Dim label_ruta As Label

				label_id = gvClaserow.FindControl("lblid_aviso_adjunto")
				label_ruta = gvClaserow.FindControl("lblarchivo_original")

				If ID.ToString() = label_id.Text.ToString() Then

					Dim IPSERVER As String = ConfigurationManager.AppSettings("Adjuntos_Cliente")
					Dim nombre_archivo As String = label_ruta.Text
					Dim ruta As String = Path.Combine(IPSERVER, nombre_archivo)

					If File.Exists(ruta) Then
						Dim nombreDescarga As String = Path.GetFileName(ruta)

						Dim response As HttpResponse = HttpContext.Current.Response
						response.Clear()
						response.ClearHeaders()
						response.ClearContent()

						response.ContentType = "application/octet-stream"
						response.AddHeader("Content-Disposition", "attachment; filename=" & nombreDescarga)
						response.TransmitFile(ruta)
						response.Flush()

						' 👇 mejor que Response.End()
						HttpContext.Current.ApplicationInstance.CompleteRequest()
					Else
						ScriptManager.RegisterStartupScript(Me, Me.GetType(), "alert", "alert('El archivo no existe en la ruta: " & ruta & "');", True)
					End If

				End If
			Next
		End If


	End Sub

	Protected Sub cboclase_aviso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboclase_aviso.SelectedIndexChanged
		matriz_prioridad_clase_impacto()

	End Sub

	Private Sub cboimpacto_aviso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboimpacto_aviso.SelectedIndexChanged
		matriz_prioridad_clase_impacto()
	End Sub
	Public Sub matriz_prioridad_clase_impacto()
		Dim clase As Integer
		Dim impacto As Integer
		Dim ds As New DataSet()
		Dim valor As String

		clase = Integer.Parse(cboclase_aviso.SelectedValue.ToString())
		impacto = Integer.Parse(cboimpacto_aviso.SelectedValue.ToString())

		ds = obj.Matriz_prioridad_clase_impacto(clase, impacto)

		If ds.Tables(0).Rows.Count > 0 Then
			valor = ds.Tables(0).Rows(0)(0).ToString()
			txtprioridad_aviso.Text = valor
		Else
			txtprioridad_aviso.Text = ""
		End If


	End Sub

	Public Sub PintarTimeline(ByVal id_estado As Integer)
		' Reset todos a gris
		step1.Attributes("class") = "timeline-marker bg-secondary"
		step2.Attributes("class") = "timeline-marker bg-secondary"
		step3.Attributes("class") = "timeline-marker bg-secondary"
		step4.Attributes("class") = "timeline-marker bg-secondary"
		step5.Attributes("class") = "timeline-marker bg-secondary"
		step6.Attributes("class") = "timeline-marker bg-secondary"
		step7.Attributes("class") = "timeline-marker bg-secondary"
		step8.Attributes("class") = "timeline-marker bg-secondary"

		If id_estado = 9 Then
			step1.Attributes("class") = "timeline-marker bg-danger"
			step2.Attributes("class") = "timeline-marker bg-danger"
			step3.Attributes("class") = "timeline-marker bg-danger"
			step4.Attributes("class") = "timeline-marker bg-danger"
			step5.Attributes("class") = "timeline-marker bg-danger"
			step6.Attributes("class") = "timeline-marker bg-danger"
			step7.Attributes("class") = "timeline-marker bg-danger"
			step8.Attributes("class") = "timeline-marker bg-danger"
			Exit Sub
		End If


		' Activa solo el actual en azul
		Select Case id_estado
			Case 1 : step1.Attributes("class") = "timeline-marker bg-primary"
			Case 2 : step2.Attributes("class") = "timeline-marker bg-primary"
			Case 3 : step3.Attributes("class") = "timeline-marker bg-primary"
			Case 4 : step4.Attributes("class") = "timeline-marker bg-primary"
			Case 5 : step5.Attributes("class") = "timeline-marker bg-primary"
			Case 6 : step6.Attributes("class") = "timeline-marker bg-primary"
			Case 7 : step7.Attributes("class") = "timeline-marker bg-primary"
			Case 8 : step8.Attributes("class") = "timeline-marker bg-primary"
		End Select
	End Sub

	Public Sub Bloqueo_Controles_Perfil_Estado(ByVal id_estado As Integer, ByVal id_perfil As Integer)

		'bloquear controles segun el perfil y estado

		'__Perfiles de la BD ARSYSUSERS__
		'27  Perfil Dios
		'28  Administrador de Unidad
		'29  Jefe de Mantenimiento
		'30  Equipo de Mantenimiento
		'31  Proveedor
		'32  Limitado

		'Estados
		'1   Pendiente de Atención
		'2   Proveedor Asignado
		'3   Cotización Registrada
		'4   Cotización Aprobada
		'5   Cotización rechazada
		'6   OC Confirmada
		'7   Sustento Ingresado
		'8   Aviso cerrado

		If id_perfil = 28 Then 'Administrador de Unidad

			If id_estado = 0 Then 'Es un registro aun nuevo, que se esta creando

				'Bloqueo de los controles de la pestaña
				PnlControlesTAB1.Enabled = True
				PnlControlesTAB2.Enabled = False 'Asignacion de proveedor
				PnlControlesTAB3_Ocultar() 'Registro de Cotizaciones
				pnladjuntar_p.Visible = False
			End If
			If id_estado = 1 Then 'Pendiente de atencion 

				'Bloqueo de los controles de la pestaña "Informacion general"
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3_Ocultar()
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar

				'bloquear botones de aprobacion y rechazo
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar

				pnladjuntar_p.Visible = False
			End If

			If id_estado = 2 Then 'Proveedor asignado
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3_Ocultar()
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar

				pnladjuntar_p.Visible = False
			End If

			If id_estado = 3 Then 'Cotización registrada
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3_Ocultar()
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				txtsustento_rechazo_cotizacion.Visible = True

				pnladjuntar_p.Visible = False

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 4 Then 'Cotización Aprobada
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonCerraraviso.Visible = False 'El usuario puede cerrar el aviso
				txtsustento_rechazo_cotizacion.Visible = True

				'Pestaña de Cotizaciones TAB3 
				PnlControlesTAB3_Ocultar()

				pnladjuntar_p.Visible = False

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 5 Then 'Cotización rechazada
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3_Ocultar()
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				txtsustento_rechazo_cotizacion.Visible = True

				pnladjuntar_p.Visible = False

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 9 Then 'Documento Rechazado al Inicio
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3.Enabled = False
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar

				pnladjuntar_p.Visible = False

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 8 Then 'Aviso cerrado
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3_Ocultar()
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				txtsustento_rechazo_cotizacion.Visible = True
				btnCerrarAviso.Visible = False

				pnladjuntar_p.Visible = True

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check

				'PnlControlesTAB1.Enabled = False
				'PnlControlesTAB2.Enabled = False
				'PnlControlesTAB3.Enabled = False
				'inputGroupFile04.Visible = False 'Controles del adjuntar
				'btnAdjuntar2.Visible = False 'Controles del adjuntar
				'Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				'pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				'txtsustento_rechazo_cotizacion.Visible = True
				'btnCerrarAviso.Visible = False

				'pnladjuntar_p.Visible = True

				'Bloquear_seleccion_cotizacion("1") 'Bloquear control check


				'PnlControlesTAB1.Enabled = False
				'PnlControlesTAB2.Enabled = False
				'PnlControlesTAB3_Ocultar()
				'inputGroupFile04.Visible = False 'Controles del adjuntar
				'btnAdjuntar2.Visible = False 'Controles del adjuntar
				'Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				'pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				'txtsustento_rechazo_cotizacion.Visible = True
				'btnCerrarAviso.Visible = False

				'pnladjuntar_p.Visible = False

				'Bloquear_seleccion_cotizacion("1") 'Bloquear control check

			End If

			If id_estado = 6 Then 'OC Confirmada
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonCerraraviso.Visible = False 'El usuario puede cerrar el aviso
				txtsustento_rechazo_cotizacion.Visible = True

				'Pestaña de Cotizaciones TAB3 
				PnlControlesTAB3_Ocultar()

				pnladjuntar_p.Visible = False

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 7 Then 'Sustento Ingresado
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonCerraraviso.Visible = False 'El usuario puede cerrar el aviso
				txtsustento_rechazo_cotizacion.Visible = True

				'Pestaña de Cotizaciones TAB3 
				PnlControlesTAB3_Ocultar()

				pnladjuntar_p.Visible = True

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

		End If


		If id_perfil = 29 Or id_perfil = 30 Then 'Jefe de Mantenimiento / Analistas de Mantenimiento
			If id_estado = 0 Then 'Es un registro aun nuevo, que se esta creando, el Jefe de mantenimiento puede crear

				'Bloqueo de los controles de la pestaña
				PnlControlesTAB1.Enabled = True
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3_Ocultar()

				pnladjuntar_p.Visible = False
			End If
			If id_estado = 1 Then 'Pendiente de atencion 
				'Bloqueo de los controles de la pestaña "Informacion general"
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = True
				PnlControlesTAB3_Ocultar()
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar

				pnladjuntar_p.Visible = False
			End If
			If id_estado = 2 Then 'Proveedor asignado
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3_Ocultar()
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar

				pnladjuntar_p.Visible = False
				Bloquear_seleccion_cotizacion("1") 'Bloquear control check

				pnlbotonCerraraviso.Visible = True
			End If

			If id_estado = 3 Then 'Cotización Registrada
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = True 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = True 'El usuario no puede aprobar ni rechazar
				pnlbotonCerraraviso.Visible = True 'El usuario puede cerrar el aviso
				txtsustento_rechazo_cotizacion.Visible = True

				'Pestaña de Cotizaciones TAB3 
				PnlControlesTAB3_Ocultar()

				pnladjuntar_p.Visible = False

				Bloquear_seleccion_cotizacion("0") 'DesBloquear control check
			End If

			If id_estado = 4 Then 'Cotización Aprobada
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonCerraraviso.Visible = False 'El usuario puede cerrar el aviso
				txtsustento_rechazo_cotizacion.Visible = True

				'Pestaña de Cotizaciones TAB3 
				PnlControlesTAB3_Ocultar()

				pnladjuntar_p.Visible = False

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 5 Then 'Cotización rechazada
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonCerraraviso.Visible = False 'El usuario puede cerrar el aviso
				txtsustento_rechazo_cotizacion.Visible = True

				'Pestaña de Cotizaciones TAB3 
				PnlControlesTAB3_Ocultar()

				pnladjuntar_p.Visible = False

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check

				pnlbotonCerraraviso.Visible = True
			End If

			If id_estado = 9 Then 'Documento Rechazado al Inicio
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3_Ocultar()
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar

				pnladjuntar_p.Visible = False

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 8 Then 'Documento Cerrado - Cuando ya tenian las cotizaciones
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3_Ocultar()
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				txtsustento_rechazo_cotizacion.Visible = True
				btnCerrarAviso.Visible = False

				pnladjuntar_p.Visible = True

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 6 Then 'OC Confirmada
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonCerraraviso.Visible = False 'El usuario puede cerrar el aviso
				txtsustento_rechazo_cotizacion.Visible = True

				'Pestaña de Cotizaciones TAB3 
				PnlControlesTAB3_Ocultar()

				pnladjuntar_p.Visible = False
				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If
			If id_estado = 7 Then 'Sustento Ingresado
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = True 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonCerraraviso.Visible = False 'El usuario puede cerrar el aviso
				txtsustento_rechazo_cotizacion.Visible = True

				'Pestaña de Cotizaciones TAB3 
				PnlControlesTAB3_Ocultar()

				pnladjuntar_p.Visible = True

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If
		End If


		If id_perfil = 31 Then 'Proveedor

			If id_estado = 2 Then 'Proveedor asignado
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3.Enabled = True
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = True 'El proveedor puede aprobar porque ingresara sus cotizaciones
				pnlbotonrechazar.Visible = False 'El proveedor no rechaza
				txtsustento_rechazo_cotizacion.Visible = True

				pnladjuntar_p.Visible = False
				lblTextoBoton.InnerText = "Guardar Aviso"
				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 3 Then 'Cotización Registrada
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3_Ocultar()

				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El proveedor puede aprobar porque ingresara sus cotizaciones
				pnlbotonrechazar.Visible = False 'El proveedor no rechaza
				txtsustento_rechazo_cotizacion.Visible = True

				pnladjuntar_p.Visible = False

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 4 Then 'Cotización Aprobada
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonCerraraviso.Visible = False 'El usuario puede cerrar el aviso
				txtsustento_rechazo_cotizacion.Visible = True

				'Pestaña de Cotizaciones TAB3 
				PnlControlesTAB3_Ocultar()

				pnladjuntar_p.Visible = False
				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 5 Then 'Cotización Rechazada (Es como Proveedor asignado)
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3.Enabled = True
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = True 'El proveedor puede aprobar porque ingresara sus cotizaciones
				pnlbotonrechazar.Visible = False 'El proveedor no rechaza
				txtsustento_rechazo_cotizacion.Visible = True

				pnladjuntar_p.Visible = False
				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 8 Then 'Documento Cerrado - Cuando ya tenian las cotizaciones
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3_Ocultar()
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				txtsustento_rechazo_cotizacion.Visible = True
				btnCerrarAviso.Visible = False

				pnladjuntar_p.Visible = False
				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 6 Then 'OC Confirmada
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = True 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonCerraraviso.Visible = False 'El usuario puede cerrar el aviso
				txtsustento_rechazo_cotizacion.Visible = True

				'Pestaña de Cotizaciones TAB3 
				PnlControlesTAB3_Ocultar()

				pnladjuntar_p.Visible = True
				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If
			If id_estado = 7 Then 'Sustento Ingresado
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonCerraraviso.Visible = False 'El usuario puede cerrar el aviso
				txtsustento_rechazo_cotizacion.Visible = True

				'Pestaña de Cotizaciones TAB3 
				PnlControlesTAB3_Ocultar()

				pnladjuntar_p.Visible = True
				Bloquear_seleccion_cotizacion("1") 'Bloquear control check
			End If

			If id_estado = 8 Then 'Aviso cerrado
				PnlControlesTAB1.Enabled = False
				PnlControlesTAB2.Enabled = False
				PnlControlesTAB3_Ocultar()
				inputGroupFile04.Visible = False 'Controles del adjuntar
				btnAdjuntar2.Visible = False 'Controles del adjuntar
				Pnlbotonaprobar.Visible = False 'El usuario no puede aprobar ni rechazar
				pnlbotonrechazar.Visible = False 'El usuario no puede aprobar ni rechazar
				txtsustento_rechazo_cotizacion.Visible = True
				btnCerrarAviso.Visible = False

				pnladjuntar_p.Visible = True

				Bloquear_seleccion_cotizacion("1") 'Bloquear control check



			End If


		End If



	End Sub
	Public Sub Bloquear_seleccion_cotizacion(ByVal bloquea As String)

		For Each row As GridViewRow In grvCotizacionesAviso.Rows
			Dim chk As CheckBox = CType(row.FindControl("chkSeleccion"), CheckBox)
			If chk IsNot Nothing Then

				If bloquea = "1" Then 'Bloquear control
					chk.Enabled = False
				End If

			End If
		Next

	End Sub
	Public Sub PnlControlesTAB3_Ocultar()
		'Pestaña de Cotizaciones TAB3 
		Tab_Cotizaciones_oculta_controles()
		Tab_Cotizaciones_muestra_controles_visualizar()
		pnlGrillaCotizacion.Enabled = False
		pnlCabeceraCotizacion.Enabled = False
		BtnVolver_Cotizacion.Visible = False
		BtnGuardarPopup_Cotizaciones.Visible = False
		btnAgregarFila.Visible = False
		'pnlAdjunto_sustentoproveedor.Visible = False
	End Sub

	Public Sub Tab_Cotizaciones_oculta_controles()
		'Ocultamos el boton
		btnAgregarCotizacion.Visible = False

		For Each row As GridViewRow In grvCotizacionesAviso.Rows
			If row.RowType = DataControlRowType.DataRow Then
				' Obtenemos el botón eliminar de la fila
				Dim btnEliminar As LinkButton = CType(row.FindControl("btneliminar"), LinkButton)
				Dim btnEditar As LinkButton = CType(row.FindControl("btnEditar"), LinkButton)
				Dim btnVisualizar As LinkButton = CType(row.FindControl("btnVisualizar"), LinkButton)
				btnEliminar.Visible = False
				btnEditar.Visible = False
				btnVisualizar.Visible = False
			End If
		Next
	End Sub
	Public Sub Tab_Cotizaciones_muestra_controles_visualizar()

		For Each row As GridViewRow In grvCotizacionesAviso.Rows
			If row.RowType = DataControlRowType.DataRow Then
				' Obtenemos el botón eliminar de la fila
				Dim btnVisualizar As LinkButton = CType(row.FindControl("btnVisualizar"), LinkButton)
				btnVisualizar.Visible = True
			End If
		Next
	End Sub
	Private Sub grvarchivosadjuntos_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grvarchivosadjuntos.RowCommand

	End Sub

	Protected Sub BtnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles BtnBuscarProveedor.Click

		ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", "<script>popup_proveedor()</script>", False)
	End Sub

	Protected Sub BtnBuscarProveedor_Popup_Click(sender As Object, e As EventArgs) Handles BtnBuscarProveedor_Popup.Click
		System.Threading.Thread.Sleep(2000)
		Buscar_proveedores()
	End Sub

	Protected Sub BtnCerrarPopup_Proveedores_Click(sender As Object, e As EventArgs) Handles BtnCerrarPopup_Proveedores.Click
		' ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_busqueda", "$('#myModal_busqueda').modal('hide');", False)
		ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", "<script>cerrar_popup_proveedores()</script>", False)

	End Sub

	Public Sub Buscar_proveedores()
		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		Dim rucproveedor As String
		Dim razonsocial As String
		Dim sapproveedor As String
		Dim desc_equipo As String
		Dim ds As New DataSet()

		rucproveedor = txtrucproveedor_popup.Text.ToString()
		razonsocial = txtrazonsocial_popup.Text.ToString()
		sapproveedor = txtsapproveedor_popup.Text.ToString()


		ds = obj.Filtro_Busqueda_Proveedores(rucproveedor, razonsocial, sapproveedor)
		grvproveedor_popup.DataSource = ds.Tables(0)
		grvproveedor_popup.DataBind()

		ds.Dispose()

		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If



		ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_busqueda_proveedor", "$('#myModal_busqueda_proveedor').modal();", True)

	End Sub

	Private Sub grvproveedor_popup_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grvproveedor_popup.RowCommand
		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If


		If e.CommandName = "seleccionar" Then
			Dim rucproveedor As String
			rucproveedor = (e.CommandArgument).ToString()

			For Each gvClaserow As GridViewRow In grvproveedor_popup.Rows
				Dim lblrazonsocial_popup As Label
				Dim lblrucproveedor_popup As Label
				Dim lblcodsap_proveedor As Label

				lblrazonsocial_popup = gvClaserow.FindControl("lblrazonsocial_popup")
				lblrucproveedor_popup = gvClaserow.FindControl("lblrucproveedor_popup")
				lblcodsap_proveedor = gvClaserow.FindControl("lblcodsap_proveedor")

				If rucproveedor = lblrucproveedor_popup.Text Then
					lblrucproveedor_aviso.Text = rucproveedor.ToString() + " / " + lblrazonsocial_popup.Text.ToString()
					lblrucproveedorSAP_aviso.Text = lblcodsap_proveedor.Text.ToString()
					ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", "<script>cerrar_popup_proveedores()</script>", False)



				End If
			Next






		End If
	End Sub

	Protected Sub cbofamiliaservicio_aviso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofamiliaservicio_aviso.SelectedIndexChanged
		Dim id_familia_servicio As Integer
		id_familia_servicio = Integer.Parse(cbofamiliaservicio_aviso.SelectedValue.ToString())

		If id_familia_servicio <> 0 Then
			Lista_subfamilia_servicio(id_familia_servicio)
		End If

	End Sub

	Public Sub Lista_subfamilia_servicio(ByVal id_familia_servicio As Integer)
		Dim ds As New DataSet()
		ds = obj.Lista_Subfamilia_Servicio(id_familia_servicio)

		cbosubfamiliaservicio_aviso.DataSource = ds.Tables(0)
		cbosubfamiliaservicio_aviso.DataTextField = "cta_sap_subfamilia_servicio"
		cbosubfamiliaservicio_aviso.DataValueField = "id_subfamilia_servicio"
		cbosubfamiliaservicio_aviso.DataBind()

		ds.Dispose()

	End Sub

	Private Sub btnrechazar_Click(sender As Object, e As EventArgs) Handles btnrechazar.Click
		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		Dim nro_aviso As String
		Dim id_usuario As Integer
		Dim id_perfil As Integer
		Dim resultado As Boolean
		Dim id_estado_aviso As Integer

		nro_aviso = lblnro_aviso.Text.ToString()
		id_usuario = Integer.Parse(Session("id_usuario").ToString())
		id_estado_aviso = Integer.Parse(lblid_estado.Text.ToString())

		If id_estado_aviso = 1 Then 'Pendiente de Atención

			'Cuando el administrador de la unidad genera un aviso, el area de mantenimiento puede rechazarlo. Y no sigue el flujo
			resultado = obj.Rechazar_Aviso(nro_aviso, id_usuario)

			If resultado Then

				lblmensajeconfirmacion.Text = "Se ha rechazado el aviso de manera exitósa."
				ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_confirmacion", "$('#myModal_Mensaje_confirmacion').modal('show');", True)

				id_perfil = Session("id_perfil")

				'Mostrar los campos nuevamente con validacion
				cargar_datos_aviso(Integer.Parse(lblid_aviso.Text.ToString()))
				Bloqueo_Controles_Perfil_Estado(9, id_perfil) '9:Rechazo inicial

			End If
		End If

		If id_estado_aviso = 3 Then 'Cotización registrada
			'Cuando el area de mantenimiento quiere rechazar las cotizaciones ingresadas por el proveedor puede rechazarlas, pero con un sustento.

			lblmensajerechazo.Text = "Por favor, detalle brevemente la razón por la cual está rechazando las cotizaciones:"
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_rechazo", "$('#myModal_Mensaje_rechazo').modal('show');", True)



		End If


	End Sub

	Private Sub btnaprobar_Click(sender As Object, e As EventArgs) Handles btnaprobar.Click
		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		'Proceso de Aprobación de un aviso
		Dim resultado As Boolean
		Dim validacion_error As String = ""
		Dim mensaje_error_concatenado As String = ""

		Dim id_perfil As Integer
		Dim id_estado_actual As Integer
		Dim id_estado_nuevo As Integer

		id_perfil = Session("id_perfil")
		id_estado_actual = Integer.Parse(lblid_estado.Text.ToString())


		'ESTADO: PROVEEDOR ASIGNADO ESTADO (id_estado: 2)

		If id_estado_actual = 1 Then 'Pendiente de Atencion
			id_estado_nuevo = 2 'Proveedor asignado

			'Parametros
			Dim ruc_proveedor As String
			Dim ruc_proveedor_sap As String
			Dim razon_social_proveedor As String
			Dim clase_otm As Integer
			Dim familia_servicio As Integer
			Dim subfamilia_servicio As Integer


			'Proveedor asignado

			If lblrucproveedor_aviso.Text = "" Then
				If mensaje_error_concatenado = "" Then
					mensaje_error_concatenado = "Proveedor"
				Else
					mensaje_error_concatenado = mensaje_error_concatenado & " / proveedor"
				End If

				lblrucproveedor_aviso.CssClass += " resaltar-obligatorio"
				validacion_error = "1"

			Else
				lblrucproveedor_aviso.CssClass = lblrucproveedor_aviso.CssClass.Replace("resaltar-obligatorio", "").Trim()
				ruc_proveedor = lblrucproveedor_aviso.Text.ToString() 'Hay que extraer el codigo!!!!!!
				ruc_proveedor = ruc_proveedor.Split("/"c)(0).Trim()
				ruc_proveedor_sap = lblrucproveedorSAP_aviso.Text.ToString()
				razon_social_proveedor = lblrucproveedor_aviso.Text.ToString().Split("/"c)(1).Trim()
			End If


			'Clase OTM
			If cboclaseotm_aviso.SelectedIndex = 0 Then
				If mensaje_error_concatenado = "" Then
					mensaje_error_concatenado = "Clase OTM"
				Else
					mensaje_error_concatenado = mensaje_error_concatenado & " / Clase OTM"
				End If
				cboclaseotm_aviso.CssClass += " resaltar-obligatorio"
				validacion_error = "1"

			Else
				cboclaseotm_aviso.CssClass = cboclaseotm_aviso.CssClass.Replace("resaltar-obligatorio", "").Trim()
				clase_otm = cboclaseotm_aviso.SelectedValue.ToString()
			End If


			'Grupo de Compras
			Dim grupo_compras As String
			grupo_compras = lblgrupocompras_aviso.Text


			'Fecha Inicial Cotizacion
			Dim FechaInicioCotizacion As String
			FechaInicioCotizacion = txtFechaInicioCotizacion.Text

			If FechaInicioCotizacion = "" Then
				If mensaje_error_concatenado = "" Then
					mensaje_error_concatenado = "Fecha Inicial Cotización"
				Else
					mensaje_error_concatenado = mensaje_error_concatenado & " / Fecha Inicial Cotización"
				End If
				txtFechaInicioCotizacion.CssClass += " resaltar-obligatorio"
				validacion_error = "1"
			Else
				txtFechaInicioCotizacion.CssClass = txtFechaInicioCotizacion.CssClass.Replace("resaltar-obligatorio", "").Trim()
				FechaInicioCotizacion = txtFechaInicioCotizacion.Text.ToString()
			End If

			'Fecha Final Cotizacion
			Dim FechaFinCotizacion As String
			FechaFinCotizacion = txtFechaFinCotizacion.Text

			If FechaFinCotizacion = "" Then
				If mensaje_error_concatenado = "" Then
					mensaje_error_concatenado = "Fecha Fin Cotización"
				Else
					mensaje_error_concatenado = mensaje_error_concatenado & " / Fecha Fin Cotización"
				End If
				txtFechaFinCotizacion.CssClass += " resaltar-obligatorio"
				validacion_error = "1"
			Else
				txtFechaFinCotizacion.CssClass = txtFechaFinCotizacion.CssClass.Replace("resaltar-obligatorio", "").Trim()
				FechaFinCotizacion = txtFechaFinCotizacion.Text.ToString()
			End If


			'Familia Servicio
			If cbofamiliaservicio_aviso.SelectedIndex = 0 Then
				If mensaje_error_concatenado = "" Then
					mensaje_error_concatenado = "Familia Servicio"
				Else
					mensaje_error_concatenado = mensaje_error_concatenado & " / Familia Servicio"
				End If
				cbofamiliaservicio_aviso.CssClass += " resaltar-obligatorio"
				validacion_error = "1"

			Else
				cbofamiliaservicio_aviso.CssClass = cbofamiliaservicio_aviso.CssClass.Replace("resaltar-obligatorio", "").Trim()
				familia_servicio = cbofamiliaservicio_aviso.SelectedValue.ToString()
			End If

			'Sub Familia Servicio
			If cbosubfamiliaservicio_aviso.SelectedIndex = 0 Then
				If mensaje_error_concatenado = "" Then
					mensaje_error_concatenado = "Familia Servicio"
				Else
					mensaje_error_concatenado = mensaje_error_concatenado & " / Familia Servicio"
				End If
				cbosubfamiliaservicio_aviso.CssClass += " resaltar-obligatorio"
				validacion_error = "1"

			Else
				cbosubfamiliaservicio_aviso.CssClass = cbosubfamiliaservicio_aviso.CssClass.Replace("resaltar-obligatorio", "").Trim()
				subfamilia_servicio = cbosubfamiliaservicio_aviso.SelectedValue.ToString()
			End If



			If validacion_error = "1" Then 'Si existe algun error de campo obligatorio
				lblmensajex.Text = "Favor de completar lo siguiente: " + mensaje_error_concatenado
				ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje", "$('#myModal_Mensaje').modal('show');", True)
				Return
			Else

				'Registro del Aviso
				Dim id_aviso As Integer
				Dim id_usuario As Integer


				id_aviso = Integer.Parse(lblid_aviso.Text.ToString())
				id_usuario = Session("id_usuario").ToString()

				resultado = obj.Registra_Estado_Aviso_2(id_aviso, id_usuario, ruc_proveedor, clase_otm, grupo_compras, DateTime.Parse(FechaInicioCotizacion), DateTime.Parse(FechaFinCotizacion), subfamilia_servicio, razon_social_proveedor, ruc_proveedor_sap)



			End If

		End If

		If id_estado_actual = 2 Then 'Proveedor Asignado

			'El proveedor procedió a registrar sus cotizaciones

			'Cantidad de cotizaciones
			Dim can_cotizaciones_registradas As Integer = 0
			can_cotizaciones_registradas = Integer.Parse(grvCotizacionesAviso.Rows.Count.ToString())


			If can_cotizaciones_registradas = 0 Then 'Si existe algun error de campo obligatorio
				lblmensajex.Text = "Favor de registrar la cotización para el aviso solicitado."
				ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje", "$('#myModal_Mensaje').modal('show');", True)
				Return
			Else

				'Registro del Aviso
				Dim id_aviso As Integer
				Dim id_usuario As Integer


				id_aviso = Integer.Parse(lblid_aviso.Text.ToString())
				id_usuario = Session("id_usuario").ToString()

				resultado = obj.Registra_Estado_Aviso_3(id_aviso, id_usuario)



			End If

		End If


		If id_estado_actual = 5 Then 'Cotizacion Rechazada
			'El proveedor reviso el sustento y el aviso tiene el estado de cotizacion rechazada
			'El proveedor debe ingresar una nueva cotizacion o editar la existente segun el sustento ingresado por Manto.



			'Cantidad de cotizaciones
			Dim can_cotizaciones_registradas As Integer = 0
			can_cotizaciones_registradas = Integer.Parse(grvCotizacionesAviso.Rows.Count.ToString())


			If can_cotizaciones_registradas = 0 Then 'Si existe algun error de campo obligatorio
				lblmensajex.Text = "Favor de registrar la cotización para el aviso solicitado."
				ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje", "$('#myModal_Mensaje').modal('show');", True)
				Return
			Else

				'Registro del Aviso
				Dim id_aviso As Integer
				Dim id_usuario As Integer


				id_aviso = Integer.Parse(lblid_aviso.Text.ToString())
				id_usuario = Session("id_usuario").ToString()

				resultado = obj.Registra_Estado_Aviso_3(id_aviso, id_usuario) 'Estado: Cotización Registrada



			End If


		End If

		If id_estado_actual = 3 Then 'Cotización Registrada (Envio de API)

			'El usuario de Mantenimiento aprobara la cotización
			Dim id_aviso As Integer
			id_aviso = Integer.Parse(lblid_aviso.Text.ToString())

			'Envio de API y cambio de estado del Aviso a Cotización Aprobada
			'API: API envió para crear OC - Me devuelve OTM

			'Verificar que se debe aprobar una cotizacion
			Dim selecciono As Boolean = False

			For Each row As GridViewRow In grvCotizacionesAviso.Rows
				Dim chk As CheckBox = CType(row.FindControl("chkSeleccion"), CheckBox)
				If chk IsNot Nothing AndAlso chk.Checked Then
					selecciono = True
					Exit For
				End If
			Next

			If Not selecciono Then
				lblmensajex.Text = "Debe marcar como aprobada una cotización del listado."
				ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje", "$('#myModal_Mensaje').modal('show');", True)
				Return
			End If

			'Registrar cotizacion aprobada del aviso

			For Each row As GridViewRow In grvCotizacionesAviso.Rows
				Dim chk As CheckBox = CType(row.FindControl("chkSeleccion"), CheckBox)
				Dim nro_cotizacion As Label = CType(row.FindControl("lblnro_cotizacion"), Label)

				If chk.Checked Then
					'actualizamos en tabla la cotizacion aprobada
					Dim id_aviso_x As Integer
					id_aviso_x = Integer.Parse(lblid_aviso.Text.ToString())
					obj.Cotizacion_aprobada_aviso(id_aviso_x, nro_cotizacion.Text)
				End If
			Next

			'Enviamos API para generar la OTM - De la cotizacion aprobada

			resultado = API1(id_aviso)


		End If

		If id_estado_actual = 6 Then 'OC Confirmada
			'El Proveedor debe ingresar un sustento
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_Estado_Sustento", "$('#myModal_Mensaje_Estado_Sustento').modal();", True)
			Return


		End If

		If id_estado_actual = 7 Then 'Sustento Ingresado por el proveedor
			Dim id_aviso As Integer
			Dim id_usuario As Integer

			''Enviamos API para crear las HESC - API Navideño
			'resultado = API_cierre(id_aviso)

			'If resultado Then 'Si se ejecuto correctamente la API
			'Con este proceso cerramos el caso
			'id_aviso = Integer.Parse(lblid_aviso.Text.ToString())
			'id_usuario = Session("id_usuario").ToString()
			'resultado = obj.Registra_Estado_Aviso_8(id_aviso, id_usuario) 'Estado: Aviso Cerrado

			'End If

			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_Sustento_final", "$('#myModal_Mensaje_Sustento_final').modal();", True)
			Return

			''Ini - Proceso Normal
			'id_aviso = Integer.Parse(lblid_aviso.Text.ToString())
			'id_usuario = Session("id_usuario").ToString()
			'resultado = obj.Registra_Estado_Aviso_8(id_aviso, id_usuario) 'Estado: Aviso Cerrado
			''Fin - Proceso Normal

		End If

		'Registro correctamente el cambio de estado
		If resultado Then
			lbltituloMensaje.Text = "Proceso Correctamente"
			iconoConfirmacion.Visible = True
			iconoError.Visible = False
			lblmensajeconfirmacion.Text = "Se ha registrado el aviso de manera exitosa."
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_confirmacion", "$('#myModal_Mensaje_confirmacion').modal('show');", True)

			'Mostrar los campos nuevamente con validacion
			cargar_datos_aviso(Integer.Parse(lblid_aviso.Text.ToString()))
			'Bloqueo_Controles_Perfil_Estado(9, id_perfil) '9:Rechazo inicial
		Else

			lbltituloMensaje.Text = "Error"
			iconoConfirmacion.Visible = False
			iconoError.Visible = True

			If Session("msj_error_api").ToString() <> "" Then 'Hay error en API

				'lblmensajeconfirmacion.Text = "Ocurrió un error al registrar el aviso en el sistema. Error: " + Session("msj_error_api").ToString()
				lblmensajeconfirmacion.Text = "Ocurrió un error al registrar el aviso en el sistema.<br>Error: " & Session("msj_error_api").ToString()

			Else
				'Proceso Normal

				lblmensajeconfirmacion.Text = "Ocurrió un error al registrar el aviso en el sistema."
			End If

			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_confirmacion", "$('#myModal_Mensaje_confirmacion').modal('show');", True)

			'Mostrar los campos nuevamente con validacion
			cargar_datos_aviso(Integer.Parse(lblid_aviso.Text.ToString()))
			'Bloqueo_Controles_Perfil_Estado(9, id_perfil) '9:Rechazo inicial
		End If




	End Sub

	Private Sub btnAgregarCotizacion_Click(sender As Object, e As EventArgs) Handles btnAgregarCotizacion.Click
		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		'Limpiar campos de nueva cotización
		lblnro_cotizacion.Text = "Nueva Cotización"
		lblid_aviso_cotizacion.Text = ""
		txtfecini_serv_cotizacion.Text = ""
		txtfecfin_serv_cotizacion.Text = ""
		cbomonedacotiz.SelectedIndex = 0
		txtdesc_cotizacion.Text = ""
		lblTotalGeneral.Text = "0.00"

		InicializarTabla()
		BindGrid()
		CargarGrillaInicial() 'Listado fictisio



		'Abrir el Popup de cotizaciones
		ScriptManager.RegisterStartupScript(Page, Page.GetType(), "kt_modal_2", "$('#kt_modal_2').modal();", True)

	End Sub
	Public Function API1(ByVal id_aviso As Integer) As Boolean
		Try


			'API: API envió para crear OC - Me devuelve OTM

			' Omitir validación de certificado SSL (Solo en pruebas)
			ServicePointManager.ServerCertificateValidationCallback = Function(sender, certificate, chain, sslPolicyErrors) True

			' URL del servicio SAP
			Dim url As String = ConfigurationManager.AppSettings("UrlAPI")
			Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)

			' Configuración de la solicitud
			request.Method = "POST"
			request.ContentType = "application/json"

			' Usuario y contraseña (Basic Auth)
			Dim usuario As String = ConfigurationManager.AppSettings("user")
			Dim password As String = ConfigurationManager.AppSettings("pswd")
			Dim credenciales As String = Convert.ToBase64String(Encoding.UTF8.GetBytes(usuario & ":" & password))
			request.Headers("Authorization") = "Basic " & credenciales

			Dim detalleJson As New StringBuilder()
			detalleJson.Append("[")

			Dim ds_datos As New DataSet()
			ds_datos = obj.Datos_Api_1(id_aviso)
			Dim dtDatos As DataTable = ds_datos.Tables(1) 'Componentes
			Dim dtDatos_servicios As DataTable = ds_datos.Tables(2) 'Servicios

			' Construcción final del JSON completo
			Dim objA As New ARMantenimiento.EAvisoCab()

			Dim aufnr As String = ds_datos.Tables(0).Rows(0)(0).ToString()
			Dim clase_orden As String = ds_datos.Tables(0).Rows(0)(1).ToString()
			Dim prioridad As String = ds_datos.Tables(0).Rows(0)(2).ToString()
			Dim ubicacion_tecnica As String = ds_datos.Tables(0).Rows(0)(3).ToString()
			Dim equipo As String = ds_datos.Tables(0).Rows(0)(4).ToString()
			Dim centro_planificacion As String = ds_datos.Tables(0).Rows(0)(5).ToString()
			Dim descripcion As String = ds_datos.Tables(0).Rows(0)(6).ToString()
			Dim fecha_inicio As String = ds_datos.Tables(0).Rows(0)(7).ToString()
			Dim fecha_fin As String = ds_datos.Tables(0).Rows(0)(8).ToString()
			Dim grupo_articulo As String = ds_datos.Tables(0).Rows(0)(9).ToString()
			Dim grupo_compras As String = ds_datos.Tables(0).Rows(0)(10).ToString()
			Dim org_compras As String = ds_datos.Tables(0).Rows(0)(11).ToString()
			Dim CLASE_ACTIVIDAD As String = ds_datos.Tables(0).Rows(0)(12).ToString()
			Dim puesto_trabajo As String = ds_datos.Tables(0).Rows(0)(13).ToString()

			objA.aufnr = aufnr
			objA.clase_orden = clase_orden
			objA.prioridad = prioridad
			objA.ubicacion_tecnica = ubicacion_tecnica
			objA.equipo = equipo
			objA.centro_planificacion = centro_planificacion
			objA.descripcion = descripcion
			objA.fecha_inicio = fecha_inicio
			objA.fecha_fin = fecha_fin
			objA.grupo_articulo = grupo_articulo
			objA.grupo_compras = grupo_compras
			objA.org_compras = org_compras
			objA.CLASE_ACTIVIDAD = CLASE_ACTIVIDAD
			objA.puesto_trabajo = puesto_trabajo

			For Each row As DataRow In dtDatos.Rows
				Dim matnr As String = row("matnr").ToString().Trim()
				Dim cantidad As String = row("cantidad").ToString().Trim()
				Dim unidad_medida As String = row("unidad_medida").ToString().Trim()
				Dim tipo_posicion As String = row("tipo_posicion").ToString().Trim()
				Dim precio As String = row("precio").ToString().Trim()
				Dim moneda As String = row("moneda").ToString().Trim()
				Dim solicitante As String = row("solicitante").ToString().Trim()
				Dim proveedor As String = row("proveedor").ToString().Trim()

				Dim componentes As New ARMantenimiento.EAvisoDet()

				objA.componentes.Add(New EAvisoDetComp With {
					.matnr = matnr,
					.cantidad = cantidad,
					.unidad_medida = unidad_medida,
					.tipo_posicion = tipo_posicion,
					.precio = precio,
					.moneda = moneda,
					.solicitante = solicitante,
					.proveedor = proveedor
				})

			Next

			For Each row As DataRow In dtDatos_servicios.Rows
				Dim asnum As String = row("asnum").ToString().Trim()
				Dim cantidad As String = row("cantidad").ToString().Trim()
				Dim meins As String = row("meins").ToString().Trim()
				Dim precio As String = row("precio").ToString().Trim()
				Dim waers As String = row("waers").ToString().Trim()
				Dim solicitante As String = row("solicitante").ToString().Trim()
				Dim lifnr As String = row("lifnr").ToString().Trim()

				Dim servicios As New ARMantenimiento.EAvisoDet()

				objA.servicios.Add(New EAvisoDet With {
					.asnum = asnum,
					.cantidad = cantidad,
					.meins = meins,
					.precio = precio,
					.waers = waers,
					.solicitante = solicitante,
					.lifnr = lifnr
				})

			Next


			Dim jsonData As String = JsonConvert.SerializeObject(objA, Newtonsoft.Json.Formatting.Indented)

			' Convertir el JSON a bytes
			Dim data As Byte() = Encoding.UTF8.GetBytes(jsonData)

			' Escribir los datos en la solicitud
			request.ContentLength = data.Length
			Using stream As Stream = request.GetRequestStream()
				stream.Write(data, 0, data.Length)
			End Using

			' Obtener la respuesta del servidor
			Dim responseText As String = ""
			Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
				Using reader As New StreamReader(response.GetResponseStream())
					responseText = reader.ReadToEnd()
				End Using
			End Using

			' Deserializar la respuesta JSON como una lista de diccionarios
			Dim jsSerializer As New JavaScriptSerializer()
			Dim jsonResponse As List(Of Dictionary(Of String, Object)) = jsSerializer.Deserialize(Of List(Of Dictionary(Of String, Object)))(responseText)

			' Extraer valores del primer objeto en la lista
			If jsonResponse.Count > 0 Then
				Dim code_output As String = jsonResponse(0)("code").ToString()
				Dim msj_output As String = jsonResponse(0)("msj").ToString()
				Dim aufnr_output As String = jsonResponse(0)("aufnr").ToString() 'Documento generado OTM

				Session("msj_error_api") = ""
				'Actualizacion del Registro en BD ARMANTO
				Dim resultado As Boolean
				Dim id_usuario As Integer
				id_usuario = Session("id_usuario").ToString()

				If code_output = "00" Then '00 = Proceso Correcto
					'Guarda correctamente y en Log.
					resultado = obj.Registra_Estado_Aviso_4(id_aviso, id_usuario, code_output, msj_output, aufnr_output) 'Estado: Cotización Aprobada

				Else '01 = Proceso con error

					'Guardamos en LOG, errores 
					resultado = obj.Registra_Estado_Aviso_4_LogApi(id_aviso, id_usuario, code_output, msj_output, aufnr_output) 'Estado: Cotización Aprobada
					Session("msj_error_api") = msj_output.ToString()
					Return False
				End If



				'				[
				'    {
				'        "code": "00",
				'        "msj": "Se genero la orden 000010000248",
				'        "aufnr": "000010000248"
				'    }
				']

				'Leyenda de campo CODE
				'00 = Proceso Correcto
				'01 = Proceso con error

				If resultado Then
					Return True
				End If

			Else
				Return False
				Response.Write("No se recibieron datos en la respuesta.<br>")
			End If

		Catch ex As Exception
			Session("msj_error_api") = "Error de conexión del Api"
			Return False
		End Try



		'Ejemplo de API:
		'{ "aufnr": "",
		'"clase_orden": "MCMT",
		'"prioridad": "2",
		'"ubicacion_tecnica": "",
		'"equipo": "EBMI-BA-02",
		'"centro_planificacion": "SE10",
		'"descripcion": "Reparacion de equipo",
		'"fecha_inicio": "16.09.2025",
		' "fecha_fin": "17.09.2025",
		' "grupo_articulo": "S00000001",
		' "grupo_compras": "S18",
		' "org_compras": "OLIM",
		' "CLASE_ACTIVIDAD": "",
		' "puesto_trabajo" : "CONTRATA",
		' "servicios": [{"asnum": "9000000135", "cantidad": "1", "meins": "UND", "precio": "776.28", "waers": "PEN", "solicitante": "WHUIZA", "lifnr": "1000000020"},
		'               {"asnum": "9000000136", "cantidad": "1", "meins": "UND", "precio": "168.00", "waers": "PEN", "solicitante": "WHUIZA", "lifnr": "1000000020"}],
		' "componentes": [{"matnr": "4000000100", "cantidad": "3", "unidad_medida": "UND", "tipo_posicion": "N", "precio": "65.23", "moneda": "PEN", "solicitante": "WHUIZA", "proveedor": "1000001532"},
		'                 {"matnr": "4000000101", "cantidad": "1.2", "unidad_medida": "UND", "tipo_posicion": "N", "precio": "9.00", "moneda": "PEN", "solicitante": "WHUIZA", "proveedor": "1000001532"}]
		'  }

	End Function
	Protected Sub btnCerrarPopupCotizaciones_Click(sender As Object, e As EventArgs) Handles btnCerrarPopupCotizaciones.Click
		' ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_busqueda", "$('#myModal_busqueda').modal('hide');", False)
		ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", "<script>cerrar_popup_cotizaciones()</script>", False)


	End Sub



	Private Sub grvItemsCotizacion_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grvItemsCotizacion.RowDataBound

		Static total As Decimal

		If e.Row.RowType = DataControlRowType.DataRow Then
			' Buscar el textbox de Subtotal
			Dim txtSubtotal As TextBox = CType(e.Row.FindControl("txtSubtotal"), TextBox)
			If txtSubtotal IsNot Nothing AndAlso Not String.IsNullOrEmpty(txtSubtotal.Text) Then
				Dim valor As Decimal
				If Decimal.TryParse(txtSubtotal.Text, valor) Then
					total += valor
				End If
			End If
		ElseIf e.Row.RowType = DataControlRowType.Footer Then
			' Mostrar el total en el footer
			Dim lblTotal As Label = CType(e.Row.FindControl("lblTotal"), Label)
			If lblTotal IsNot Nothing Then
				lblTotal.Text = "Total: " & total.ToString("C2") ' Ej: $1,000.00
			End If

			' Reiniciamos acumulador para siguientes postbacks
			total = 0
		End If
	End Sub

	Private Sub BtnGuardarPopup_Cotizaciones_Click(sender As Object, e As EventArgs) Handles BtnGuardarPopup_Cotizaciones.Click

		GuardarPopup_Cotizaciones()

		'Bloquear controles en la pagina segun perfil y estado
		Dim id_perfil As Integer
		Dim id_estado As Integer

		id_perfil = Session("id_perfil")
		id_estado = Integer.Parse(lblid_estado.Text.ToString())

		Bloqueo_Controles_Perfil_Estado(id_estado, id_perfil)


		'ScriptManager.RegisterStartupScript(Me, Me.GetType(),
		'							"recalcularGrilla",
		'							"recalcularSubtotalesEnGrilla();",
		'							True)


	End Sub
	Public Sub GuardarPopup_Cotizaciones()

		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If
		Dim nro_cotizacion As String
		Dim ruc_proveedor As String
		Dim error_valida As String = "0"

		ruc_proveedor = lblrucproveedor_aviso.Text
		nro_cotizacion = lblnro_cotizacion.Text.ToString()

		'Fecha Inicial Cotizacion - Servicio
		Dim fecini_serv_cotizacion As String
		fecini_serv_cotizacion = txtfecini_serv_cotizacion.Text

		If fecini_serv_cotizacion = "" Then
			txtfecini_serv_cotizacion.CssClass += " resaltar-obligatorio"

			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "kt_modal_2", "$('#kt_modal_2').modal();", True)
			'ScriptManager.RegisterStartupScript(Page, Page.GetType(), "kt_modal_2", "$('#kt_modal_2').modal(); recalcularSubtotalesEnGrilla();", True)


			Return
		Else
			txtfecini_serv_cotizacion.CssClass = txtfecini_serv_cotizacion.CssClass.Replace("resaltar-obligatorio", "").Trim()
			fecini_serv_cotizacion = txtfecini_serv_cotizacion.Text.ToString()

		End If

		'Fecha Final Cotizacion - Servicio
		Dim fecfin_serv_cotizacion As String
		fecfin_serv_cotizacion = txtfecfin_serv_cotizacion.Text

		If fecfin_serv_cotizacion = "" Then
			txtfecfin_serv_cotizacion.CssClass += " resaltar-obligatorio"

			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "kt_modal_2", "$('#kt_modal_2').modal();", True)
			'ScriptManager.RegisterStartupScript(Page, Page.GetType(), "kt_modal_2", "$('#kt_modal_2').modal(); setTimeout(recalcularSubtotalesEnGrilla, 200);", True)


			Return
		Else
			txtfecfin_serv_cotizacion.CssClass = txtfecfin_serv_cotizacion.CssClass.Replace("resaltar-obligatorio", "").Trim()
			fecfin_serv_cotizacion = txtfecfin_serv_cotizacion.Text.ToString()

		End If


		'Validar fechas donde la fecha inicial no debe ser mayor a la fecha final
		Dim fecini_serv_cotizacion_x As Date
		Dim fecfin_serv_cotizacion_x As Date

		' Intentar convertir las fechas

		' Validación principal
		If DateTime.Parse(fecini_serv_cotizacion) > DateTime.Parse(fecfin_serv_cotizacion) Then
			txtfecini_serv_cotizacion.CssClass += " resaltar-obligatorio"
			txtfecfin_serv_cotizacion.CssClass += " resaltar-obligatorio"
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "kt_modal_2", "$('#kt_modal_2').modal();", True)
			Return
		End If



		'Descripcion de la cotizacion
		Dim desc_cotizacion As String
		desc_cotizacion = txtdesc_cotizacion.Text

		If desc_cotizacion = "" Then
			txtdesc_cotizacion.CssClass += " resaltar-obligatorio"

			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "kt_modal_2", "$('#kt_modal_2').modal();", True)
			Return
		Else
			txtdesc_cotizacion.CssClass = txtdesc_cotizacion.CssClass.Replace("resaltar-obligatorio", "").Trim()
			desc_cotizacion = txtdesc_cotizacion.Text.ToString()

		End If

		''La grilla tiene que contener registros
		'Dim can_items As Integer
		'can_items = Integer.Parse(grvItemsCotizacion.Rows.Count.ToString())
		'If can_items = 1 Then 'Considera la cabecera por eso 1
		'	Return
		'End If

		'Validacion de que exista minimo un servicio
		Dim cant_servicios As Integer = 0
		For Each row As GridViewRow In grvItemsCotizacion.Rows
			If row.RowType = DataControlRowType.DataRow Then
				Dim txttipo As TextBox = CType(row.FindControl("txttipo"), TextBox)
				Dim tipo As String = If(txttipo IsNot Nothing, txttipo.Text.Trim(), "")
				If tipo = "Servicio" Then
					cant_servicios = cant_servicios + 1
				End If
			End If
		Next
		If cant_servicios = 0 Then
			grvItemsCotizacion.CssClass += " resaltar-obligatorio"
			error_valida = "1"
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "kt_modal_2", "$('#kt_modal_2').modal();", True)
			Return

		End If

		'Validacion de que no vea valores 0

		Dim error_validax As String = "0"

		For Each row As GridViewRow In grvItemsCotizacion.Rows
			If row.RowType = DataControlRowType.DataRow Then

				Dim txtCantidad As TextBox = CType(row.FindControl("txtCantidad"), TextBox)
				Dim txtPrecio As TextBox = CType(row.FindControl("txtPrecio"), TextBox)

				Dim cantidad As Decimal
				Dim precio As Decimal

				'---- VALIDAR CANTIDAD ----
				If txtCantidad Is Nothing _
			OrElse Not Decimal.TryParse(txtCantidad.Text.Trim(), cantidad) _
			OrElse cantidad <= 0 Then

					txtCantidad.CssClass &= " resaltar-obligatorio"
					error_validax = "1"
				End If

				'---- VALIDAR PRECIO ----
				If txtPrecio Is Nothing _
			OrElse Not Decimal.TryParse(txtPrecio.Text.Trim(), precio) _
			OrElse precio <= 0 Then

					txtPrecio.CssClass &= " resaltar-obligatorio"
					error_validax = "1"
				End If

			End If
		Next

		'---- SI HUBO ERRORES MOSTRAR MODAL ----
		If error_validax = "1" Then
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "kt_modal_2",
										"$('#kt_modal_2').modal();", True)
			Return
		End If


		Dim id_aviso_cotizacion As Integer
		Dim id_aviso As Integer
		Dim id_moneda As Integer
		Dim id_usuario As Integer
		Dim total_general As Decimal

		id_aviso = Integer.Parse(lblid_aviso.Text.ToString())
		id_moneda = Integer.Parse(cbomonedacotiz.SelectedValue.ToString())
		id_usuario = Integer.Parse(Session("id_usuario").ToString())
		total_general = Decimal.Parse(lblTotalGeneral.Text.ToString())


		If lblnro_cotizacion.Text = "Nueva Cotización" Then
			'Nueva Cotizacion

			id_aviso_cotizacion = obj.Registra_Cotizacion_Aviso(id_aviso, desc_cotizacion, id_moneda, id_usuario,
															DateTime.Parse(fecini_serv_cotizacion), DateTime.Parse(fecfin_serv_cotizacion), total_general)
		Else

			'Modificar Cotizacion existente 
			'Eliminamos el detalle, para que inserte nuevamente

			obj.Modificar_Cotizacion_Aviso(Integer.Parse(lblid_aviso_cotizacion.Text), desc_cotizacion, id_moneda, id_usuario,
															DateTime.Parse(fecini_serv_cotizacion), DateTime.Parse(fecfin_serv_cotizacion), total_general)
			id_aviso_cotizacion = Integer.Parse(lblid_aviso_cotizacion.Text)
		End If




		'Registro de la cabecera de la cotizacion, debe volver ID.

		'lblid_aviso
		'lblrucproveedor_aviso

		For Each row As GridViewRow In grvItemsCotizacion.Rows
			If row.RowType = DataControlRowType.DataRow Then
				' Buscar los controles dentro de la fila
				Dim txtcodigoselect As TextBox = CType(row.FindControl("txtcodigoselect"), TextBox)
				Dim txtDescripcion As TextBox = CType(row.FindControl("txtDescripcion"), TextBox)
				Dim txtCantidad As TextBox = CType(row.FindControl("txtCantidad"), TextBox)
				Dim txtPrecio As TextBox = CType(row.FindControl("txtPrecio"), TextBox)
				Dim txtSubtotal As TextBox = CType(row.FindControl("txtSubtotal"), TextBox)
				Dim txtum_select As TextBox = CType(row.FindControl("txtum_select"), TextBox)
				Dim txttipo As TextBox = CType(row.FindControl("txttipo"), TextBox)


				' Validar y convertir valores
				Dim codigo As String = If(txtcodigoselect IsNot Nothing, txtcodigoselect.Text.Trim(), "")
				Dim descripcion As String = If(txtDescripcion IsNot Nothing, txtDescripcion.Text.Trim(), "")
				Dim cantidad As Decimal = If(txtCantidad IsNot Nothing AndAlso IsNumeric(txtCantidad.Text), Convert.ToDecimal(txtCantidad.Text), 0)
				Dim precio As Decimal = If(txtPrecio IsNot Nothing AndAlso IsNumeric(txtPrecio.Text), Convert.ToDecimal(txtPrecio.Text), 0)
				Dim subtotal As Decimal = If(txtSubtotal IsNot Nothing AndAlso IsNumeric(txtSubtotal.Text), Convert.ToDecimal(txtSubtotal.Text), 0)
				Dim um As String = If(txtum_select IsNot Nothing, txtum_select.Text.Trim(), "")
				Dim tipo As String = If(txttipo IsNot Nothing, txttipo.Text.Trim(), "")

				If txtcodigoselect.Text <> "" Then 'Debe tener en la fila el codigo del item seleccionado

					'Mando ID de la cotizacion devuelta del registro

					obj.Registra_detalle_cotizacion(id_aviso_cotizacion, codigo, um, cantidad, precio, descripcion, tipo)

				End If

			End If
		Next

		'listar las cotizaciones en la grilla
		Lista_Cotizaciones_aviso()



	End Sub

	Private Sub InicializarTabla()
		Dim dt As New DataTable()
		dt.Columns.Add("Descripcion", GetType(String))
		dt.Columns.Add("Cantidad", GetType(Decimal))
		dt.Columns.Add("Precio", GetType(Decimal))
		dt.Columns.Add("Subtotal", GetType(Decimal))
		dt.Columns.Add("Codigo", GetType(String))
		dt.Columns.Add("unidad_medida", GetType(String))
		dt.Columns.Add("tipo", GetType(String))


		' Arrancamos con 1 fila vacía
		dt.Rows.Add("", 0, 0, 0, "", "", "")

		ViewState("Items") = dt
	End Sub

	Private Sub BindGrid()
		Dim dt As DataTable = CType(ViewState("Items"), DataTable)
		grvItemsCotizacion.DataSource = dt
		grvItemsCotizacion.DataBind()
	End Sub

	Private Sub GuardarValoresActuales()
		Dim dt As DataTable = CType(ViewState("Items"), DataTable)

		For i As Integer = 0 To grvItemsCotizacion.Rows.Count - 1
			Dim row As GridViewRow = grvItemsCotizacion.Rows(i)

			Dim txtDescripcion As TextBox = CType(row.FindControl("txtDescripcion"), TextBox)
			Dim txtcodigoselect As TextBox = CType(row.FindControl("txtcodigoselect"), TextBox)
			Dim txtCantidad As TextBox = CType(row.FindControl("txtCantidad"), TextBox)
			Dim txtPrecio As TextBox = CType(row.FindControl("txtPrecio"), TextBox)
			Dim txtum_select As TextBox = CType(row.FindControl("txtum_select"), TextBox)
			Dim txttipo As TextBox = CType(row.FindControl("txttipo"), TextBox)

			Dim cantidad As Decimal = If(String.IsNullOrEmpty(txtCantidad.Text), 0, Convert.ToDecimal(txtCantidad.Text))
			Dim precio As Decimal = If(String.IsNullOrEmpty(txtPrecio.Text), 0, Convert.ToDecimal(txtPrecio.Text))
			Dim subtotal As Decimal = cantidad * precio

			dt.Rows(i)("Descripcion") = txtDescripcion.Text
			dt.Rows(i)("Cantidad") = cantidad
			dt.Rows(i)("Precio") = precio
			dt.Rows(i)("Subtotal") = subtotal
			dt.Rows(i)("Codigo") = txtcodigoselect.Text
			dt.Rows(i)("unidad_medida") = txtum_select.Text
			dt.Rows(i)("tipo") = txttipo.Text
		Next

		ViewState("Items") = dt
	End Sub



	Private Sub btnAgregarFila_Click(sender As Object, e As EventArgs) Handles btnAgregarFila.Click

		' Guardar valores y recalcular subtotales
		GuardarValoresActuales()

		' Recuperar la tabla
		Dim dt As DataTable = CType(ViewState("Items"), DataTable)

		' Agregar una fila vacía
		dt.Rows.Add("", 0, 0, 0, "", "", "")

		' Guardar y refrescar
		ViewState("Items") = dt
		BindGrid()

		' Recalcular total general
		CalcularTotalGeneral()

	End Sub

	Private Sub CalcularTotalGeneral()
		Dim dt As DataTable = CType(ViewState("Items"), DataTable)
		Dim total As Decimal = 0

		For Each dr As DataRow In dt.Rows
			total += Convert.ToDecimal(dr("Subtotal"))
		Next

		lblTotalGeneral.Text = total.ToString("N2")
	End Sub
	' Guardar la fila que abrió el buscador
	Private Property FilaSeleccionada As Integer
		Get
			Return If(ViewState("FilaSeleccionada") IsNot Nothing, CInt(ViewState("FilaSeleccionada")), -1)
		End Get
		Set(value As Integer)
			ViewState("FilaSeleccionada") = value
		End Set
	End Property
	Private Sub CargarGrillaInicial()
		' Ejemplo simple: una fila vacía para pruebas
		Dim dt As New DataTable
		dt.Columns.Add("Descripcion")
		dt.Columns.Add("Cantidad")
		dt.Columns.Add("Precio")
		dt.Columns.Add("Subtotal")
		dt.Columns.Add("Codigo")
		dt.Columns.Add("unidad_medida")
		dt.Columns.Add("tipo")
		dt.Rows.Add("", 0, 0, 0, "", "", "")
		grvItemsCotizacion.DataSource = dt
		grvItemsCotizacion.DataBind()
	End Sub

	Protected Sub grvItemsCotizacion_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grvItemsCotizacion.RowCommand
		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		If e.CommandName = "BuscarArticulo" Then
			FilaSeleccionada = Convert.ToInt32(e.CommandArgument)

			' Ocultar/mostrar paneles
			pnlGrillaCotizacion.Visible = False
			pnlBusquedaItemsGrillaCotizacion.Visible = True

			'Capturar el textbox de la fila seleccionada
			Dim row As GridViewRow = grvItemsCotizacion.Rows(FilaSeleccionada)
			Dim txtDescripcion As TextBox = CType(row.FindControl("txtDescripcion"), TextBox)

			'Cargar datos
			Dim ds_equipos_servicios As New DataSet()
			Dim cc_logistico As String

			cc_logistico = cbounidad_usuario_aviso.SelectedValue
			ds_equipos_servicios = obj.Busqueda_Equipos_Servicios_Cotizacion(txtDescripcion.Text, cc_logistico)

			If ds_equipos_servicios.Tables(0).Rows.Count = 0 Then
				'Si no encuentra registro o manda el mismo elegido, muestra todos
				ds_equipos_servicios = obj.Busqueda_Equipos_Servicios_Cotizacion("", cc_logistico)
			End If

			Dim dt As New DataTable
			dt.Columns.Add("codigo")
			dt.Columns.Add("descripcion")
			dt.Columns.Add("tipo_material")
			dt.Columns.Add("unidad_medida")
			dt.Columns.Add("tipo")

			dt = ds_equipos_servicios.Tables(0)

			grvItemsBusqueda_Cotizacion.DataSource = dt
			grvItemsBusqueda_Cotizacion.DataBind()




			' Cargar datos ficticios
			'Dim dt As New DataTable
			'dt.Columns.Add("Codigo")
			'dt.Columns.Add("Descripcion")
			'dt.Rows.Add("A001", "Laptop Lenovo ThinkPad")
			'dt.Rows.Add("A002", "Mouse Logitech Inalámbrico")
			'dt.Rows.Add("A003", "Monitor Dell 24''")
			'grvItemsBusqueda_Cotizacion.DataSource = dt
			'grvItemsBusqueda_Cotizacion.DataBind()



		End If

		If e.CommandName = "EliminarArticulo" Then
			' 1. Guardar valores actuales para no perder lo editado
			GuardarValoresActuales()

			' 2. Obtener el índice de la fila
			Dim index As Integer = Convert.ToInt32(e.CommandArgument)

			' 3. Recuperar la tabla desde el ViewState
			Dim dt As DataTable = CType(ViewState("Items"), DataTable)

			' 4. Validar y eliminar
			If index >= 0 AndAlso index < dt.Rows.Count Then
				dt.Rows.RemoveAt(index)
			End If

			' 5. Guardar cambios en el ViewState
			ViewState("Items") = dt

			' 6. Reenlazar la grilla
			BindGrid()

			' 7. Recalcular el total general
			CalcularTotalGeneral()
		End If
	End Sub
	Protected Sub grvArticulos_RowCommand(sender As Object, e As GridViewCommandEventArgs)
		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		If e.CommandName = "Seleccionar" Then
			Dim datos() As String = e.CommandArgument.ToString().Split("|"c)
			Dim codigo As String = datos(0)
			Dim descripcion As String = datos(1)
			Dim unidad_medida As String = datos(2)
			Dim tipo As String = datos(3)

			' Obtener TextBox de la fila original
			Dim fila As GridViewRow = grvItemsCotizacion.Rows(FilaSeleccionada)
			Dim txtDescripcion As TextBox = CType(fila.FindControl("txtDescripcion"), TextBox)
			Dim txtcodigoselect As TextBox = CType(fila.FindControl("txtcodigoselect"), TextBox)
			Dim txtum_select As TextBox = CType(fila.FindControl("txtum_select"), TextBox)

			Dim txttipo As TextBox = CType(fila.FindControl("txttipo"), TextBox)


			txtDescripcion.Text = codigo & " - " & descripcion
			txtcodigoselect.Text = codigo
			txtum_select.Text = unidad_medida
			txttipo.Text = tipo


			'txtDescripcion.ReadOnly = True

			' Mostrar solo el botón Eliminar de esta fila
			'Dim btnEliminar As LinkButton = CType(fila.FindControl("btnEliminarArticulo"), LinkButton)
			'If btnEliminar IsNot Nothing Then
			'	btnEliminar.Visible = True
			'End If

			' Ocultar el botón Búsqueda de esta fila
			'Dim btnBuscar As LinkButton = CType(fila.FindControl("btnBuscarArticulo"), LinkButton)
			'If btnBuscar IsNot Nothing Then
			'	btnBuscar.Visible = False
			'End If

			' >>> NUEVO: Guardar en el DataTable que esta fila está seleccionada
			'Dim dt As DataTable = CType(ViewState("Items"), DataTable)
			'dt.Rows(FilaSeleccionada)("Seleccionado") = True
			'ViewState("Items") = dt

			' Volver a la grilla de cotización
			pnlBusquedaItemsGrillaCotizacion.Visible = False
			pnlGrillaCotizacion.Visible = True
		End If
	End Sub

	Protected Sub grvItemsBusqueda_Cotizacion_RowDataBound(sender As Object, e As GridViewRowEventArgs)
		If e.Row.RowType = DataControlRowType.DataRow Then
			' Cambia el color de fondo al pasar el mouse
			e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#F2F2F2'; this.style.cursor='pointer';")
			' Vuelve al color original al salir
			e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='';")
		End If
	End Sub

	Protected Sub BtnVolver_Cotizacion_Click(sender As Object, e As EventArgs) Handles BtnVolver_Cotizacion.Click


		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		pnlBusquedaItemsGrillaCotizacion.Visible = False
		pnlGrillaCotizacion.Visible = True
		'BtnVolver_Cotizacion.Visible = False
		''Abrir el Popup de cotizaciones
		ScriptManager.RegisterStartupScript(Page, Page.GetType(), "kt_modal_2", "$('#kt_modal_2').modal();", True)
		CalcularTotalGeneral()
	End Sub


	Public Sub Lista_Cotizaciones_aviso()

		Dim ds As New DataSet()
		ds = obj.lista_cotizaciones_aviso(Integer.Parse(lblid_aviso.Text))
		grvCotizacionesAviso.DataSource = ds.Tables(0)
		grvCotizacionesAviso.DataBind()

		' === Marcar el checkbox según el campo aprobado_cotizacion ===
		For i As Integer = 0 To grvCotizacionesAviso.Rows.Count - 1

			Dim row As GridViewRow = grvCotizacionesAviso.Rows(i)
			Dim chk As CheckBox = CType(row.FindControl("chkSeleccion"), CheckBox)

			' Validar
			If chk IsNot Nothing Then
				Dim aprobado As String = ds.Tables(0).Rows(i)("aprobado_cotizacion").ToString()

				If aprobado = "1" Then
					chk.Checked = True
				Else
					chk.Checked = False
				End If
			End If

		Next

		ds.Dispose()


	End Sub

	Protected Sub grvCotizacionesAviso_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grvCotizacionesAviso.RowCommand
		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		If e.CommandName = "EditarCotizacion" Then

			Dim id_aviso_cotizacion As Integer
			id_aviso_cotizacion = Convert.ToInt32(e.CommandArgument)

			Dim ds As New DataSet()
			ds = obj.Detalle_Cotizacion_Proveedor(id_aviso_cotizacion)

			'Muestra valores de la cotizacion en el Popup
			lblid_aviso_cotizacion.Text = id_aviso_cotizacion
			lblnro_cotizacion.Text = ds.Tables(0).Rows(0)(1).ToString()

			cbomonedacotiz.SelectedValue = Integer.Parse(ds.Tables(0).Rows(0)(4).ToString())
			txtdesc_cotizacion.Text = ds.Tables(0).Rows(0)(2).ToString()

			Dim fecini_serv_cotizacion As DateTime = DateTime.Parse(ds.Tables(0).Rows(0)(5).ToString())
			txtfecini_serv_cotizacion.Text = fecini_serv_cotizacion.ToString("yyyy-MM-dd")

			Dim fecfin_serv_cotizacion As DateTime = DateTime.Parse(ds.Tables(0).Rows(0)(6).ToString())
			txtfecfin_serv_cotizacion.Text = fecfin_serv_cotizacion.ToString("yyyy-MM-dd")

			lblTotalGeneral.Text = ds.Tables(0).Rows(0)(7).ToString()

			grvItemsCotizacion.DataSource = ds.Tables(1)
			grvItemsCotizacion.DataBind()




			'Guardar valores y recalcular subtotales
			GuardarValoresActuales_Editar(ds)

			' Recuperar la tabla
			Dim dt As DataTable = CType(ViewState("Items"), DataTable)

			' Guardar y refrescar
			ViewState("Items") = dt
			BindGrid()

			' Recalcular total general
			CalcularTotalGeneral()






			'Abrir el Popup de cotizaciones
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "kt_modal_2", "$('#kt_modal_2').modal();", True)
		End If

		If e.CommandName = "EliminaCotizacion" Then


			Dim id_aviso_cotizacion As Integer = Convert.ToInt32(e.CommandArgument)
			Dim id_usuario As Integer = Integer.Parse(Session("id_usuario").ToString())

			obj.Elimina_Cotizacion_Aviso(id_aviso_cotizacion, id_usuario)

			Lista_Cotizaciones_aviso()

		End If

		If e.CommandName = "VisualizarCotizacion" Then
			Dim id_aviso_cotizacion As Integer
			id_aviso_cotizacion = Convert.ToInt32(e.CommandArgument)

			Dim ds As New DataSet()
			ds = obj.Detalle_Cotizacion_Proveedor(id_aviso_cotizacion)

			'Muestra valores de la cotizacion en el Popup
			lblid_aviso_cotizacion.Text = id_aviso_cotizacion
			lblnro_cotizacion.Text = ds.Tables(0).Rows(0)(1).ToString()

			cbomonedacotiz.SelectedValue = Integer.Parse(ds.Tables(0).Rows(0)(4).ToString())
			txtdesc_cotizacion.Text = ds.Tables(0).Rows(0)(2).ToString()

			Dim fecini_serv_cotizacion As DateTime = DateTime.Parse(ds.Tables(0).Rows(0)(5).ToString())
			txtfecini_serv_cotizacion.Text = fecini_serv_cotizacion.ToString("yyyy-MM-dd")

			Dim fecfin_serv_cotizacion As DateTime = DateTime.Parse(ds.Tables(0).Rows(0)(6).ToString())
			txtfecfin_serv_cotizacion.Text = fecfin_serv_cotizacion.ToString("yyyy-MM-dd")

			lblTotalGeneral.Text = ds.Tables(0).Rows(0)(7).ToString()

			grvItemsCotizacion.DataSource = ds.Tables(1)
			grvItemsCotizacion.DataBind()




			'Guardar valores y recalcular subtotales
			GuardarValoresActuales_Editar(ds)

			' Recuperar la tabla
			Dim dt As DataTable = CType(ViewState("Items"), DataTable)

			' Guardar y refrescar
			ViewState("Items") = dt
			BindGrid()

			' Recalcular total general
			CalcularTotalGeneral()


			'Abrir el Popup de cotizaciones
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "kt_modal_2", "$('#kt_modal_2').modal();", True)
		End If

	End Sub

	Private Sub GuardarValoresActuales_Editar(ByVal ds As DataSet)
		Dim dt As DataTable = ds.Tables(1)

		For i As Integer = 0 To grvItemsCotizacion.Rows.Count - 1
			Dim row As GridViewRow = grvItemsCotizacion.Rows(i)

			Dim txtDescripcion As TextBox = CType(row.FindControl("txtDescripcion"), TextBox)
			Dim txtcodigoselect As TextBox = CType(row.FindControl("txtcodigoselect"), TextBox)
			Dim txtCantidad As TextBox = CType(row.FindControl("txtCantidad"), TextBox)
			Dim txtPrecio As TextBox = CType(row.FindControl("txtPrecio"), TextBox)
			Dim txtum_select As TextBox = CType(row.FindControl("txtum_select"), TextBox)

			Dim cantidad As Decimal = If(String.IsNullOrEmpty(txtCantidad.Text), 0, Convert.ToDecimal(txtCantidad.Text))
			Dim precio As Decimal = If(String.IsNullOrEmpty(txtPrecio.Text), 0, Convert.ToDecimal(txtPrecio.Text))
			Dim subtotal As Decimal = cantidad * precio

			dt.Rows(i)("Descripcion") = txtDescripcion.Text
			dt.Rows(i)("Cantidad") = cantidad
			dt.Rows(i)("Precio") = precio
			dt.Rows(i)("Subtotal") = subtotal
			dt.Rows(i)("Codigo") = txtcodigoselect.Text
			dt.Rows(i)("unidad_medida") = txtum_select.Text
		Next

		ViewState("Items") = dt
	End Sub


	Protected Sub btnRechazarCotizaciones_Sustento_Click(sender As Object, e As EventArgs) Handles btnRechazarCotizaciones_Sustento.Click
		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		'El area de mantenimiento rechaza las cotizaciones ingresadas.
		Dim sustento_rechazo As String
		Dim id_aviso As Integer
		Dim id_usuario As Integer

		sustento_rechazo = txtSustentoRechazo.Text.ToString()
		id_aviso = Integer.Parse(lblid_aviso.Text.ToString())
		id_usuario = Session("id_usuario").ToString()

		If sustento_rechazo = "" Then
			txtSustentoRechazo.CssClass += " resaltar-obligatorio"
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_rechazo", "$('#myModal_Mensaje_rechazo').modal();", True)
			Return

		End If

		obj.Registra_Estado_Aviso_5(id_aviso, id_usuario, sustento_rechazo)
		iconoConfirmacion.Visible = True
		iconoError.Visible = False
		lblmensajeconfirmacion.Text = "Se ha registrado el aviso de manera exitosa."
		ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_confirmacion", "$('#myModal_Mensaje_confirmacion').modal('show');", True)

		'Mostrar los campos nuevamente con validacion
		cargar_datos_aviso(Integer.Parse(lblid_aviso.Text.ToString()))


	End Sub

	Protected Sub btnCerrarAviso_Click(sender As Object, e As EventArgs) Handles btnCerrarAviso.Click
		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		Dim id_aviso As Integer
		Dim id_usuario As Integer
		Dim resultado As Boolean

		id_aviso = Integer.Parse(lblid_aviso.Text.ToString())
		id_usuario = Session("id_usuario").ToString()

		resultado = obj.Registra_Estado_Aviso_8(id_aviso, id_usuario)

		If resultado Then

			iconoConfirmacion.Visible = True
			iconoError.Visible = False
			lblmensajeconfirmacion.Text = "Se ha cerrado el aviso de manera exitosa."
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_confirmacion", "$('#myModal_Mensaje_confirmacion').modal('show');", True)

			'Mostrar los campos nuevamente con validacion
			cargar_datos_aviso(Integer.Parse(lblid_aviso.Text.ToString()))
		End If



	End Sub
	Protected Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
		CerrarSesion_ActivacionGeneral()

		Dim cogeCookie = Request.Cookies.Get("appNameAuth")
		If Not cogeCookie Is Nothing Then
			Request.Cookies.Remove("appNameAuth")
		End If

		FormsAuthentication.SignOut() 'ahora si cierras session!!!
		Session.Abandon()
		Session.Clear()
		Response.Redirect("Registro_aviso.aspx")


	End Sub

	Private Sub btnRechazarCotizaciones_cerrar_Click(sender As Object, e As EventArgs) Handles btnRechazarCotizaciones_cerrar.Click

	End Sub

	Protected Sub btnEstadoSustento_Proveedor_Click(sender As Object, e As EventArgs) Handles btnEstadoSustento_Proveedor.Click

		'-- ESTADO 7: Sustento Ingresado ---

		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		Dim id_aviso As Integer
		Dim id_usuario As Integer
		Dim resultado As Boolean
		Dim sustento_proveedor As String

		id_aviso = Integer.Parse(lblid_aviso.Text.ToString())
		id_usuario = Session("id_usuario").ToString()
		sustento_proveedor = txtsustento_proveedor.Text

		Dim dt_adjuntos_p_x As New DataTable()
		dt_adjuntos_p_x = Session("dt_adjuntos_p")

		If sustento_proveedor = "" Or dt_adjuntos_p_x Is Nothing Then
			txtsustento_proveedor.CssClass += " resaltar-obligatorio"
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_Estado_Sustento", "$('#myModal_Mensaje_Estado_Sustento').modal();", True)
			Return
		End If

		resultado = obj.Registra_Estado_Aviso_7(id_aviso, id_usuario, sustento_proveedor)

		'Registro de adjuntos del sustento de proveedor

		'Archivos adjuntos del sustento del proveedor
		'Ubicaciones
		If resultado Then
			Dim Adjuntos_Cliente As String
			Dim Adjuntos_Cliente_Temp As String
			Adjuntos_Cliente = ConfigurationManager.AppSettings("Adjuntos_Cliente")
			Adjuntos_Cliente_Temp = ConfigurationManager.AppSettings("Adjuntos_Cliente_Temp")
			Dim dt_adjuntos_p As New DataTable()
			dt_adjuntos_p = Session("dt_adjuntos_p")
			If dt_adjuntos_p IsNot Nothing Then
				For j = 0 To dt_adjuntos_p.Rows.Count - 1
					Dim nombre_archivo As String
					nombre_archivo = dt_adjuntos_p.Rows(j)(2).ToString()

					'Copio archivo a la carpeta principal
					My.Computer.FileSystem.CopyFile(Adjuntos_Cliente_Temp + "\" + nombre_archivo, Adjuntos_Cliente + "\" + nombre_archivo, True)
					'Eliminar archivo de la ubicacion origen
					My.Computer.FileSystem.DeleteFile(Adjuntos_Cliente_Temp + "\" + nombre_archivo)

					obj.Registra_Archivos_Adjuntos_Fisico_prov_sustento_proveedor(id_aviso, nombre_archivo)
				Next
			End If
		End If


		If resultado Then
			iconoConfirmacion.Visible = True
			iconoError.Visible = False
			lblmensajeconfirmacion.Text = "Se ha registrado el aviso de manera exitosa."
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_confirmacion", "$('#myModal_Mensaje_confirmacion').modal('show');", True)

			'Mostrar los campos nuevamente con validacion
			cargar_datos_aviso(Integer.Parse(lblid_aviso.Text.ToString()))
		End If
	End Sub

	Private Sub btnAdjuntarP_sustento_Click(sender As Object, e As EventArgs) Handles btnAdjuntarP_sustento.Click
		Try
			If Session("user") Is Nothing Then
				Response.Redirect("~/login.aspx", True)
				Exit Sub
			End If

			Dim IPSERVER As String
			Dim itemAgregado As String
			Dim existe As String = "0"
			Dim ruta As String
			IPSERVER = ConfigurationManager.AppSettings("Adjuntos_Cliente_Temp")

			'Dim dt_adjuntos As New DataTable()
			'dt_adjuntos.Columns.AddRange(New DataColumn() {
			'									New DataColumn("nom_archivo_original", GetType(String)),
			'									New DataColumn("nom_archivo_server", GetType(String))
			'})
			Dim dt_adjuntos As New DataTable()
			dt_adjuntos.Columns.AddRange(New DataColumn() {
				New DataColumn("id_aviso_adjunto", GetType(Integer)),
				New DataColumn("nom_archivo_original", GetType(String)),
				New DataColumn("nom_archivo_server", GetType(String))
			})



			' If FileUpload1.HasFile Then
			If inputGroupFile04_sustento.HasFile Then
				Dim año As String
				Dim mes As String
				Dim dia As String
				Dim Hor As String
				Dim min As String
				Dim seg As String

				año = Date.Now.Year.ToString()
				mes = Date.Now.Month.ToString()
				dia = Date.Now.Day.ToString()
				Hor = Date.Now.Hour.ToString()
				min = Date.Now.Minute.ToString()
				seg = Date.Now.Second.ToString()

				Dim ext As String
				ext = System.IO.Path.GetExtension(inputGroupFile04_sustento.FileName)



				Dim archivo_general As String
				Dim ad_usuario As String
				ad_usuario = Session("user").ToString()

				archivo_general = ad_usuario + "_" + año + mes + dia + Hor + min + seg + "_" + inputGroupFile04_sustento.FileName

				inputGroupFile04_sustento.SaveAs(IPSERVER + "\" + archivo_general) 'Guardamos en Temporal antes de la principal


				If Session("dt_adjuntos_p") Is Nothing Then
					dt_adjuntos.Rows.Add(0, inputGroupFile04_sustento.FileName.ToString(), archivo_general)
					Session("dt_adjuntos_p") = dt_adjuntos
				Else
					dt_adjuntos = Session("dt_adjuntos_p")
					dt_adjuntos.Rows.Add(0, inputGroupFile04_sustento.FileName.ToString(), archivo_general)
					Session("dt_adjuntos_p") = dt_adjuntos

				End If
				'End If




				'Almacena en datatable - grilla

				grvadjuntos_p.DataSource = dt_adjuntos
				grvadjuntos_p.DataBind()



			End If
		Catch ex As Exception

		End Try
	End Sub

	Protected Sub grvadjuntos_p_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grvadjuntos_p.RowCommand
		If e.CommandName = "EliminaAdjunto" Then

			'Es un registro Nuevo y la eliminacion solo es en pantalla
			If lblnro_aviso.Text <> "" Then

				Dim NombreArchivo_eliminar As String
				NombreArchivo_eliminar = (e.CommandArgument).ToString()

				Dim dt_adjuntos As New DataTable()
				dt_adjuntos.Columns.AddRange(New DataColumn() {
												New DataColumn("nom_archivo_original", GetType(String)),
												New DataColumn("nom_archivo_server", GetType(String))
			})

				dt_adjuntos = Session("dt_adjuntos_p")

				Dim i As Integer = 0
				Dim can As Integer = 0
				can = dt_adjuntos.Rows.Count

				For i = 0 To can - 1
					Dim nom_archivo As String
					nom_archivo = dt_adjuntos.Rows(i)(1).ToString

					If NombreArchivo_eliminar = nom_archivo Then
						dt_adjuntos.Rows(i).Delete()
						Exit For
					End If
				Next




				Session("dt_adjuntos_p") = dt_adjuntos
				grvadjuntos_p.DataSource = dt_adjuntos
				grvadjuntos_p.DataBind()

				'txtuno.Text = dt_adjuntos.Rows.Count.ToString()
			Else 'Ya existe el documento y la eliminacion es en BD

			End If


		End If

		If e.CommandName = "DescargarAdjunto" Then
			ID = (e.CommandArgument).ToString()
			For Each gvClaserow As GridViewRow In grvadjuntos_p.Rows
				Dim label_id As Label
				Dim label_ruta As Label

				label_id = gvClaserow.FindControl("lblid_aviso_adjunto_p")
				label_ruta = gvClaserow.FindControl("lblarchivo_original_p")

				If ID.ToString() = label_id.Text.ToString() Then

					Dim IPSERVER As String = ConfigurationManager.AppSettings("Adjuntos_Cliente")
					Dim nombre_archivo As String = label_ruta.Text
					Dim ruta As String = Path.Combine(IPSERVER, nombre_archivo)

					If File.Exists(ruta) Then
						Dim nombreDescarga As String = Path.GetFileName(ruta)

						Dim response As HttpResponse = HttpContext.Current.Response
						response.Clear()
						response.ClearHeaders()
						response.ClearContent()

						response.ContentType = "application/octet-stream"
						response.AddHeader("Content-Disposition", "attachment; filename=" & nombreDescarga)
						response.TransmitFile(ruta)
						response.Flush()

						' 👇 mejor que Response.End()
						HttpContext.Current.ApplicationInstance.CompleteRequest()
					Else
						ScriptManager.RegisterStartupScript(Me, Me.GetType(), "alert", "alert('El archivo no existe en la ruta: " & ruta & "');", True)
					End If

				End If
			Next
		End If
	End Sub


	Protected Sub chkSeleccion_CheckedChanged(sender As Object, e As EventArgs)
		Dim chkClicked As CheckBox = CType(sender, CheckBox)

		' Recorre todas las filas
		For Each row As GridViewRow In grvCotizacionesAviso.Rows
			Dim chk As CheckBox = CType(row.FindControl("chkSeleccion"), CheckBox)

			' Si no es el checkbox que se hizo click, lo desmarca
			If chk IsNot Nothing AndAlso chk IsNot chkClicked Then
				chk.Checked = False
			End If
		Next
	End Sub


	Public Function API_cierre(ByVal id_aviso As Integer) As Boolean
		Try
			Session("hes") = ""
			'API NAVIDEÑO

			'API: API envió para crear OC - Me devuelve OTM

			' Omitir validación de certificado SSL (Solo en pruebas)
			ServicePointManager.ServerCertificateValidationCallback = Function(sender, certificate, chain, sslPolicyErrors) True

			' URL del servicio SAP
			Dim url As String = ConfigurationManager.AppSettings("UrlAPI_HES")
			Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)

			' Configuración de la solicitud
			request.Method = "POST"
			request.ContentType = "application/json"

			' Usuario y contraseña (Basic Auth)
			Dim usuario As String = ConfigurationManager.AppSettings("user")
			Dim password As String = ConfigurationManager.AppSettings("pswd")
			Dim credenciales As String = Convert.ToBase64String(Encoding.UTF8.GetBytes(usuario & ":" & password))
			request.Headers("Authorization") = "Basic " & credenciales

			Dim detalleJson As New StringBuilder()
			detalleJson.Append("[")

			Dim ds_datos As New DataSet()
			ds_datos = obj.Datos_Api_3(id_aviso)
			Dim dtDatos As DataTable = ds_datos.Tables(0) 'Cabecera

			' Construcción final del JSON completo
			Dim objA As New ARMantenimiento.EAvisoCab_H()

			Dim ebeln As String = ds_datos.Tables(0).Rows(0)(0).ToString()
			Dim ebelp As String = ds_datos.Tables(0).Rows(0)(1).ToString()
			Dim fecha_contable As String = Date.Parse(txtfechacontable.Text).ToString("yyyyMMdd")
			Dim fecha_documento As String = ds_datos.Tables(0).Rows(0)(2).ToString()
			Dim texto As String = lblnro_aviso.Text.ToString()


			objA.ebeln = ebeln
			objA.ebelp = ebelp
			objA.fecha_contable = fecha_contable
			objA.fecha_documento = fecha_documento
			objA.texto = texto



			Dim jsonData As String = JsonConvert.SerializeObject(objA, Newtonsoft.Json.Formatting.Indented)

			' Convertir el JSON a bytes
			Dim data As Byte() = Encoding.UTF8.GetBytes(jsonData)

			' Escribir los datos en la solicitud
			request.ContentLength = data.Length
			Using stream As Stream = request.GetRequestStream()
				stream.Write(data, 0, data.Length)
			End Using

			' Obtener la respuesta del servidor
			Dim responseText As String = ""
			Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
				Using reader As New StreamReader(response.GetResponseStream())
					responseText = reader.ReadToEnd()
				End Using
			End Using


			' Deserializar como objeto (NO como lista)
			Dim jsSerializer As New JavaScriptSerializer()
			Dim jsonResponse As Dictionary(Of String, Object) = jsSerializer.Deserialize(Of Dictionary(Of String, Object))(responseText)

			' Validar y extraer valores
			Dim resultado As Boolean
			Dim id_usuario As Integer
			id_usuario = Session("id_usuario").ToString()

			If jsonResponse IsNot Nothing Then
				Dim code As String = jsonResponse("code").ToString()
				Dim lblni As String = jsonResponse("lblni").ToString()
				Dim msj As String = jsonResponse("msj").ToString()

				If code = "S" Then
					'Guarda correctamente y en Log.
					Session("hes") = lblni.ToString()
					resultado = obj.Registra_Estado_Aviso_4_LogApi(id_aviso, id_usuario, code, msj, lblni)
					Return True
				Else '01 = Proceso con error

					'Guardamos en LOG, errores 
					resultado = obj.Registra_Estado_Aviso_4_LogApi(id_aviso, id_usuario, code, msj, lblni)
					Session("msj_error_api") = msj.ToString()
					Return False
				End If
			End If

		Catch ex As Exception
			Session("msj_error_api") = "Error de conexión del Api"
			Return False
		End Try



		'{
		'"ebeln": "4600000416",
		'"ebelp": "10",
		'"fecha_contable": "20251123", "Fecha contable que coloque el usuario
		'"fecha_documento": "20251122", "Fecha del dia
		'"texto": "TEST serv prov QAS", "Aqui pondriamos el nro de aviso del portal
		'"item": [ ]
		'}


		'		EXITO
		'{
		'    "code": "S",
		'    "lblni": "1000000419",
		'    "msj": "El proceso se generó correctamente."
		'}

		'Error
		'{
		'    "code": "E",
		'    "lblni": "",
		'    "msj": "Servicio 9000000133: la cantidad 10.010 supera la cantidad 10.000 en el pedido"
		'}
	End Function

	Protected Sub btnRegistrarEstadoFinal_Click(sender As Object, e As EventArgs) Handles btnRegistrarEstadoFinal.Click
		'Enviamos API para crear las HESC - API Navideño
		Dim resultado As Boolean
		Dim id_aviso As Integer
		Dim id_usuario As Integer

		If txtfechacontable.Text = "" Then
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_Sustento_final", "$('#myModal_Mensaje_Sustento_final').modal();", True)
			Return
		End If

		Dim fecha_contable As String = Date.Parse(txtfechacontable.Text).ToString("yyyyMMdd")
		id_aviso = Integer.Parse(lblid_aviso.Text.ToString())
		resultado = API_cierre(id_aviso)

		If resultado Then 'Si se ejecuto correctamente la API

			id_usuario = Session("id_usuario").ToString()
			resultado = obj.Registra_Estado_Aviso_8_final(id_aviso, id_usuario, Session("hes").ToString(), DateTime.Parse(txtfechacontable.Text)) 'Estado: Aviso Cerrado

			lbltituloMensaje.Text = "Proceso Correctamente"
			iconoConfirmacion.Visible = True
			iconoError.Visible = False
			lblmensajeconfirmacion.Text = "Se ha registrado el aviso de manera exitosa."
			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_confirmacion", "$('#myModal_Mensaje_confirmacion').modal('show');", True)

			'Mostrar los campos nuevamente con validacion
			cargar_datos_aviso(Integer.Parse(lblid_aviso.Text.ToString()))
			'Bloqueo_Controles_Perfil_Estado(9, id_perfil) '9:Rechazo inicial


		Else
			lbltituloMensaje.Text = "Error"
			iconoConfirmacion.Visible = False
			iconoError.Visible = True

			If Session("msj_error_api").ToString() <> "" Then 'Hay error en API

				'lblmensajeconfirmacion.Text = "Ocurrió un error al registrar el aviso en el sistema. Error: " + Session("msj_error_api").ToString()
				lblmensajeconfirmacion.Text = "Ocurrió un error al registrar el aviso en el sistema.<br>Error: " & Session("msj_error_api").ToString()

			Else
				'Proceso Normal

				lblmensajeconfirmacion.Text = "Ocurrió un error al registrar el aviso en el sistema."
			End If

			ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal_Mensaje_confirmacion", "$('#myModal_Mensaje_confirmacion').modal('show');", True)

			'Mostrar los campos nuevamente con validacion
			cargar_datos_aviso(Integer.Parse(lblid_aviso.Text.ToString()))
			'Bloqueo_Controles_Perfil_Estado(9, id_perfil) '9:Rechazo inicial
		End If



	End Sub



	Public Sub CerrarSesion_ActivacionGeneral()
		obj.CerrarSesionGlobal(Session("ACTIVACION_GENERAL").ToString())
	End Sub

	Public Sub registro_acceso_pagina(ByVal TokenGlobal As String, ByVal sistema As String, ByVal user As String)
		obj.Registro_SesionSistema(TokenGlobal, user, sistema, "Registro_aviso.aspx")
	End Sub
	Public Function CargarActivacionGeneral() As Boolean

		Dim token As String = String.Empty
		Dim ds As New DataSet
		If Session("ACTIVACION_GENERAL") IsNot Nothing Then
			token = Session("ACTIVACION_GENERAL").ToString()

			ds = obj.ExisteTokenActivo(token)
			If ds.Tables(0).Rows.Count > 0 Then
				Return True
			Else
				Response.Redirect("~/SesionExpirada.aspx", False)
				Return False
			End If
		Else
			Response.Redirect("~/SesionExpirada.aspx")
			Return False
		End If


	End Function
End Class