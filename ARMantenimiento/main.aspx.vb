Public Class main
	Inherits System.Web.UI.Page
	Dim obj As New Negocio.NManto
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

		'verificacion de que la Cookie exista
		CargarActivacionGeneral()

		If Not Page.IsPostBack Then

			If Session("user") IsNot Nothing Then 'El usuario tiene su sesion activa

				'Registro Auditoria
				registro_acceso_pagina(Session("ACTIVACION_GENERAL").ToString(), Session("SistemaAcceso").ToString(), Session("user").ToString())


			End If

		End If

	End Sub
	Public Sub bloqueo()
		Dim tipo_usuario As String
		Dim id_perfil As String

		'Perfiles:
		'27  Perfil Dios
		'28  Administrador de Unidad 
		'29  Jefe de Mantenimiento   (Mientras igual que equipo de Mantenimiento)
		'30  Equipo de Mantenimiento (Mientras igual que jefe de Mantenimiento)
		'31  Proveedor
		'32  Limitado

		tipo_usuario = Session("tipo_usuario").ToString() '1:Usuario interno , 2: Usuario Externo
		id_perfil = Session("id_perfil").ToString()

		If tipo_usuario = 2 Then
			pnlregistroaviso.Visible = False
			pnlreporte.Visible = False
			pnlanalitica.Visible = False
		End If

	End Sub

	Public Sub CerrarSesion_ActivacionGeneral()

		obj.CerrarSesionGlobal(Session("ACTIVACION_GENERAL").ToString())


		'================ PROCESO COOKIE =================
		'Session.Abandon()

		'Dim ck As New HttpCookie("ACTIVACION_GENERAL")
		'ck.Expires = DateTime.Now.AddDays(-1)

		'Response.Cookies.Add(ck)
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

	Public Sub registro_acceso_pagina(ByVal TokenGlobal As String, ByVal sistema As String, ByVal user As String)
		obj.Registro_SesionSistema(TokenGlobal, user, sistema, "main.aspx")
	End Sub
End Class