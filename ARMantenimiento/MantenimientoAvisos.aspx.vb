Imports System.IO

Public Class MantenimientoAvisos
	Inherits System.Web.UI.Page
	Dim obj As New Negocio.NManto
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


		CargarActivacionGeneral()
		If Not Page.IsPostBack Then


			If Session("user") IsNot Nothing Then 'El usuario tiene su sesion activa
				'Registro Auditoria
				registro_acceso_pagina(Session("ACTIVACION_GENERAL").ToString(), Session("SistemaAcceso").ToString(), Session("user").ToString())
			End If
			datos_superior_usuario()
			Lista_Unidades_usuario()
			Lista_area_solicitante()
			Lista_Diagnostico_inicial()
			Lista_clase()
			Lista_impacto_aviso()
			Lista_Prioridad()
			Lista_Estados()
			Lista_Avisos_Inicial()

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
	Public Sub Lista_Avisos_Inicial()

		Dim ds As New DataSet()
		Dim usuario As String
		Dim tipo_usuario As String

		usuario = Session("user").ToString()
		tipo_usuario = Session("tipo_usuario").ToString()

		'Listado de avisos iniciales para Usuarios Internos
		If tipo_usuario = "1" Then
			ds = obj.lista_busqueda_avisos_inicial(usuario)
			grvlistaavisos.DataSource = ds.Tables(0)
			grvlistaavisos.DataBind()
		End If


		'listado de avisos iniciales para Usuarios Externos
		If tipo_usuario = "2" Then
			ds = obj.lista_busqueda_avisos_inicial_proveedor(usuario) 'Se necesita los casos asignados con estado "Proveedor asignado y otros"
			grvlistaavisos.DataSource = ds.Tables(0)
			grvlistaavisos.DataBind()
			PnlBotonBusqueda.Visible = False 'ocultamos mientras tanto el filtro de busqueda para proveedores, mostraremos los asignados mientras.,
		End If


	End Sub


	Public Sub Lista_Unidades_usuario()
		Dim ds As New DataSet()
		ds = Session("unidades_usuario") 'Se captura en el Login de Usuario
		cbounidad_usuario_aviso.DataSource = ds.Tables(0)
		cbounidad_usuario_aviso.DataTextField = "desc_unidad"
		cbounidad_usuario_aviso.DataValueField = "ceco"
		cbounidad_usuario_aviso.DataBind()
		ds.Dispose()

	End Sub

	Public Sub Lista_Estados()
		Dim ds As New DataSet()
		ds = obj.Lista_Estado()
		cboestado_aviso.DataSource = ds.Tables(0)
		cboestado_aviso.DataTextField = "desc_estado"
		cboestado_aviso.DataValueField = "id_estado"
		cboestado_aviso.DataBind()
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
	Public Sub Lista_Diagnostico_inicial()
		Dim ds As New DataSet()
		ds = obj.Lista_Diagnostico_Inicial()
		cbodiagnostico_ini_aviso.DataSource = ds.Tables(0)
		cbodiagnostico_ini_aviso.DataTextField = "desc_diagnostico_ini_aviso"
		cbodiagnostico_ini_aviso.DataValueField = "id_diagnostico_ini_aviso"
		cbodiagnostico_ini_aviso.DataBind()
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
	Public Sub Lista_impacto_aviso()
		Dim ds As New DataSet()
		ds = obj.Lista_impacto_aviso()
		cboimpacto_aviso.DataSource = ds.Tables(0)
		cboimpacto_aviso.DataTextField = "desc_diagnostico_ini_aviso"
		cboimpacto_aviso.DataValueField = "id_impacto_aviso"
		cboimpacto_aviso.DataBind()
		ds.Dispose()

	End Sub
	Public Sub Lista_Prioridad()
		Dim ds As New DataSet()
		ds = obj.Lista_Prioridad_Aviso()
		cboprioridad_aviso.DataSource = ds.Tables(0)
		cboprioridad_aviso.DataTextField = "desc_prioridad_aviso"
		cboprioridad_aviso.DataValueField = "cod_prioridad_aviso"
		cboprioridad_aviso.DataBind()
		ds.Dispose()

	End Sub


	'Private Sub btnBuscarAvisos_Click(sender As Object, e As EventArgs) Handles btnBuscarAvisos.Click

	'End Sub

	Private Sub btnbusqueda_Click(sender As Object, e As EventArgs) Handles btnbusqueda.Click
		ScriptManager.RegisterStartupScript(Me, GetType(Page), "alerta", "<script>popup()</script>", False)
	End Sub

	Protected Sub BtnBuscarAvisos_Click(sender As Object, e As EventArgs) Handles BtnBuscarAvisos.Click
		Dim ds As New DataSet()

		If Session("user") Is Nothing Then
			Response.Redirect("~/login.aspx", True)
			Exit Sub
		End If

		Dim nro_aviso As String
		Dim estado_aviso As Integer
		Dim unidad_usuario_aviso As String
		Dim area_solic_aviso As Integer
		Dim diagnostico_ini_aviso As Integer
		Dim clase_aviso As Integer
		Dim impacto_aviso As Integer
		Dim prioridad_aviso As Integer
		Dim fecregini_aviso As DateTime
		Dim fecregfin_aviso As DateTime

		nro_aviso = txtnro_aviso.Text.Trim.ToString()
		estado_aviso = Integer.Parse(cboestado_aviso.SelectedValue.ToString())
		unidad_usuario_aviso = cbounidad_usuario_aviso.SelectedValue.ToString()
		area_solic_aviso = Integer.Parse(cboarea_solic_aviso.SelectedValue.ToString())
		diagnostico_ini_aviso = Integer.Parse(cbodiagnostico_ini_aviso.SelectedValue.ToString())
		clase_aviso = Integer.Parse(cboclase_aviso.SelectedValue.ToString())
		impacto_aviso = Integer.Parse(cboimpacto_aviso.SelectedValue.ToString())
		prioridad_aviso = Integer.Parse(cboprioridad_aviso.SelectedValue.ToString())

		If txtfecregini_aviso.Text = "" Then
			fecregini_aviso = DateTime.ParseExact("20230101", "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)
		Else
			fecregini_aviso = DateTime.Parse(txtfecregini_aviso.Text.ToString())
		End If

		If txtfecregfin_aviso.Text = "" Then
			fecregfin_aviso = DateTime.ParseExact("21000101", "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)
		Else
			fecregfin_aviso = DateTime.Parse(txtfecregfin_aviso.Text.ToString())
		End If

		ds = obj.Filtro_Busqueda_Avisos(nro_aviso, estado_aviso, unidad_usuario_aviso, area_solic_aviso, diagnostico_ini_aviso, clase_aviso, impacto_aviso, prioridad_aviso,
								   fecregini_aviso, fecregfin_aviso)

		grvlistaavisos.DataSource = ds.Tables(0)
		grvlistaavisos.DataBind()

		'prueba

		lvAvisosDetalle.DataSource = ds.Tables(0)
		lvAvisosDetalle.DataBind()






		ds.Dispose()


	End Sub

	Private Sub grvlistaavisos_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles grvlistaavisos.RowDataBound
		If e.Row.RowType = DataControlRowType.DataRow Then
			Dim lblId As Label = CType(e.Row.FindControl("lblid_estado"), Label)
			Dim lblDesc As Label = CType(e.Row.FindControl("lbldesc_estado"), Label)
			Dim lblIcono As Label = CType(e.Row.FindControl("lblIcono"), Label)

			If lblId IsNot Nothing AndAlso lblDesc IsNot Nothing AndAlso lblIcono IsNot Nothing Then
				Dim idEstado As Integer = Convert.ToInt32(lblId.Text)
				Dim descripcion As String = lblDesc.Text

				Select Case idEstado
					Case 1
						lblIcono.Text = $"<i class='bi bi-hourglass-split text-warning fs-5' title='{descripcion}'></i>"
					Case 2
						lblIcono.Text = $"<i class='bi bi-person-check text-primary fs-5' title='{descripcion}'></i>"
					Case 3
						lblIcono.Text = $"<i class='bi bi-file-earmark-text text-info fs-5' title='{descripcion}'></i>"
					Case 4
						lblIcono.Text = $"<i class='bi bi-check-circle-fill text-success fs-5' title='{descripcion}'></i>"
					Case 5
						lblIcono.Text = $"<i class='bi bi-x-circle-fill text-danger fs-5' title='{descripcion}'></i>"
					Case 6
						lblIcono.Text = $"<i class='bi bi-bag-check-fill text-success fs-5' title='{descripcion}'></i>"
					Case 7
						lblIcono.Text = $"<i class='bi bi-journal-text text-secondary fs-5' title='{descripcion}'></i>"
					Case 8
						lblIcono.Text = $"<i class='bi bi-lock-fill text-dark fs-5' title='{descripcion}'></i>"
					Case Else
						lblIcono.Text = $"<i class='bi bi-question-circle text-muted fs-5' title='{descripcion}'></i>"
				End Select

				' Ocultar el texto para que solo quede el icono
				'lblDesc.Visible = False 
			End If
		End If
	End Sub

	Protected Function GetEstadoIcono(idEstado As Object, descripcion As Object) As String
		Dim desc As String = descripcion.ToString()
		Select Case Convert.ToInt32(idEstado)
			Case 1 : Return $"<i class='bi bi-hourglass-split text-warning' title='{desc}'></i>"
			Case 2 : Return $"<i class='bi bi-person-check text-primary' title='{desc}'></i>"
			Case 3 : Return $"<i class='bi bi-file-earmark-text text-info' title='{desc}'></i>"
			Case 4 : Return $"<i class='bi bi-check-circle-fill text-success' title='{desc}'></i>"
			Case 5 : Return $"<i class='bi bi-x-circle-fill text-danger' title='{desc}'></i>"
			Case 6 : Return $"<i class='bi bi-bag-check-fill text-success' title='{desc}'></i>"
			Case 7 : Return $"<i class='bi bi-journal-text text-secondary' title='{desc}'></i>"
			Case 8 : Return $"<i class='bi bi-lock-fill text-dark' title='{desc}'></i>"
			Case Else : Return $"<i class='bi bi-question-circle text-muted' title='{desc}'></i>"
		End Select
	End Function
	Protected Sub lvAvisosDetalle_ItemCommand(sender As Object, e As ListViewCommandEventArgs) Handles lvAvisosDetalle.ItemCommand
		If e.CommandName = "SeleccionarAviso" Then
			Dim idAviso As Integer = Convert.ToInt32(e.CommandArgument)

			' Aquí puedes hacer lo que quieras con el id_aviso:
			' - Abrir un detalle
			' - Cargar otra grilla
			' - Mostrar modal, etc.
			Response.Write("ID Aviso seleccionado: " & idAviso)
		End If
	End Sub

	Protected Sub grvlistaavisos_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grvlistaavisos.RowCommand
		If e.CommandName = "TrabajarAviso" Then
			Dim idAviso As Integer = Convert.ToInt32(e.CommandArgument)
			Response.Redirect("~/Registro_aviso.aspx?id_aviso=" + idAviso.ToString())


		End If
		If e.CommandName = "VerImagen" Then
			' Captura el nombre del archivo desde el CommandArgument
			Dim nombre_archivo As String = e.CommandArgument.ToString().Trim()
			Dim Adjuntos_Cliente As String
			Dim Adjuntos_Cliente_Temp As String

			'Ubicaciones
			Adjuntos_Cliente = ConfigurationManager.AppSettings("Adjuntos_Cliente")
			Adjuntos_Cliente_Temp = ConfigurationManager.AppSettings("Adjuntos_Cliente_Temp")

			' Ruta física completa (por si quieres validar que exista)
			Dim rutaFisica As String = Path.Combine(Adjuntos_Cliente, nombre_archivo)

			' Verifica si el archivo existe en el servidor
			If File.Exists(rutaFisica) Then
				' Genera la ruta virtual accesible desde el navegador
				' Ejemplo: http://<servidor>/armanto/Adjuntos_Cliente/nombre.jpg
				Dim rutaVirtual As String = ResolveUrl("~/Adjuntos_Cliente/" & nombre_archivo)

				' Asigna la ruta virtual al control Image del modal
				imgPopup.ImageUrl = rutaVirtual

				' Muestra el modal Bootstrap
				ScriptManager.RegisterStartupScript(Me, Me.GetType(), "PopupFoto", "$('#myModal_Foto').modal('show');", True)
			Else
				' En caso de que el archivo no exista
				ScriptManager.RegisterStartupScript(Me, Me.GetType(), "NoFile", "alert('La imagen no se encuentra en el servidor.');", True)
			End If
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
		Response.Redirect("MantenimientoAvisos.aspx")

	End Sub

	Public Sub CerrarSesion_ActivacionGeneral()
		obj.CerrarSesionGlobal(Session("ACTIVACION_GENERAL").ToString())
	End Sub

	Public Sub registro_acceso_pagina(ByVal TokenGlobal As String, ByVal sistema As String, ByVal user As String)
		obj.Registro_SesionSistema(TokenGlobal, user, sistema, "MantenimientoAvisos.aspx")
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