Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Security.Cryptography
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports Negocio
Imports Newtonsoft.Json.Linq

Public Class login
    Inherits System.Web.UI.Page
    Dim obj As New Negocio.NManto
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            '1. Capturo el token desde la Suite: Token de usuario y clave y token de activacion general (DE BD)
            Dim token As String = Request.QueryString("t")
            Dim tokenGlobal As String = Request.QueryString("tg")
            Session("ACTIVACION_GENERAL") = tokenGlobal


            '2. Registro de Logs en el sistema ARRECETAS
            UtilLog.EscribirLog(
                "Ingreso Login ARMANTO. URL=" &
                Request.Url.ToString())

            UtilLog.EscribirLog(
                "Host=" &
                Request.Url.Host)

            UtilLog.EscribirLog(
                "token recibido=" &
                If(token, "(NULL)"))

            UtilLog.EscribirLog(
                "TokenGlobal recibido=" &
                If(tokenGlobal, "(NULL)"))



            If Not String.IsNullOrEmpty(token) Then

                Dim datos As String = Desencriptar(token)

                Dim partes() As String = datos.Split("|")

                Dim usuario As String = partes(0)
                Dim clave As String = partes(1)

                '3.Registros de Ingreso al sistema ARRECETAS y Acceso
                Session("SistemaAcceso") = "ARMAN"
                obj.Registro_SesionSistema(tokenGlobal, usuario, Session("SistemaAcceso").ToString(), "login.aspx")

                '4.================ PROCESO COOKIE =================
                Dim resultado_cookie As Boolean
                resultado_cookie = CargarActivacionGeneral()

                '5.================ PROCESO COOKIE =================
                If resultado_cookie Then
                    validar_ingreso_sistema_suite(usuario, clave) 'Proceso del boton Login (El de antes)
                End If

            Else
                Response.Redirect("~/SesionExpirada.aspx")
            End If


            'Proceso normal 
            txtusuario.Focus()
            Dim ds As DataSet
            ds = obj.configuracion_recaptcha()
            Session("clave_sitio") = ds.Tables(0).Rows(0)(0).ToString()
            Session("clave_secreta") = ds.Tables(0).Rows(0)(1).ToString()

            'Perfiles:
            '27  Perfil Dios
            '28  Administrador de Unidad 
            '29  Jefe de Mantenimiento   (Mientras igual que equipo de Mantenimiento)
            '30  Equipo de Mantenimiento (Mientras igual que jefe de Mantenimiento)
            '31  Proveedor
            '32  Limitado

        End If




    End Sub

    Public Sub lista_unidades_acceso()

        Dim tipo_usuario As String

        Dim ds As New DataSet()
        Dim usuario As String
        usuario = Session("user").ToString()
        tipo_usuario = Session("tipo_usuario").ToString()

        If tipo_usuario = "1" Then 'USUARIO INTERNO - UNIDADES A LA CUAL TIENE ACCESO
            ds = obj.Lista_Unidades(usuario)
            Session("unidades_usuario") = ds
            ds.Dispose()
        End If

        If tipo_usuario = "2" Then 'USUARIO EXTERNO - TODAS LAS UNIDADES
            ds = obj.Lista_Unidades_todos()
            Session("unidades_usuario") = ds
            ds.Dispose()
        End If

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim user As String
            Dim pwd As String
            Dim ds As New DataSet
            Dim dsUnidades As New DataSet

            user = txtusuario.Text.ToString()
            pwd = txtcontraseña.Text.ToString()

            '------------------reCaptcha-------------------
            'Dim result As String
            'Dim success As Boolean

            Dim respuestaRecaptcha As String = Request.Form("g-recaptcha-response")
            Dim secretKey As String = Session("clave_secreta")
            Dim client As New WebClient()

            Dim result As String = client.DownloadString($"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={respuestaRecaptcha}")

            Dim jsonResult As JObject = JObject.Parse(result)
            Dim success As Boolean = jsonResult.Value(Of Boolean)("success")

            Dim can As Integer
            Dim usuario As String
            Dim clave As String
            Dim tipo_usuario As String = ""
            Dim id_usuario As String
            Dim id_perfil As Integer
            Dim resultado As Boolean

            Dim i As Integer = 6
            usuario = user
            clave = pwd

            'Validamos la existencia del usuario en arsysusers

            If success Then

                ds = obj.valida_credenciales(user, clave)
                can = ds.Tables(0).Rows.Count



                'Verificamos si el usuario existe
                If can > 0 Then
                    tipo_usuario = ds.Tables(0).Rows(0)(3).ToString() '1: Usuario interno , 2: usuario externo proveedor
                Else
                    lblMensajeError.Visible = True
                    lblMensajeError2.Visible = True
                    lblMensajeError.Text = "Usuario no se encuentra registrado dentro del AD."
                    lblMensajeError2.Text = "Contraseña o nombre de usuario incorrecto."
                    Return
                End If

                If tipo_usuario = 1 Then 'usuario interno - validador AD
                    resultado = IsAuthenticated("acurio.net", usuario, clave)
                End If
                If tipo_usuario = 2 Then 'usuario externo - proveedor
                    resultado = 1
                End If


                If resultado Then 'Paso todo ok

                    tipo_usuario = ds.Tables(0).Rows(0)(3).ToString()
                    id_usuario = ds.Tables(0).Rows(0)(0).ToString()
                    id_perfil = Integer.Parse(ds.Tables(0).Rows(0)(1).ToString())

                    Session("tipo_usuario") = tipo_usuario '1:Usuario interno , 2: Usuario Externo
                    Session("user") = usuario '"imartinez"
                    Session("id_usuario") = id_usuario 'de la BD de accesos

                    Session("id_perfil") = id_perfil
                    'Perfiles:
                    '27  Perfil Dios
                    '28  Administrador de Unidad 
                    '29  Jefe de Mantenimiento   (Mientras igual que equipo de Mantenimiento)
                    '30  Equipo de Mantenimiento (Mientras igual que jefe de Mantenimiento)
                    '31  Proveedor
                    '32  Limitado


                    'Traemos el Acceso de Unidades por Usuario
                    lista_unidades_acceso()

                    Dim strRedirect As String
                    strRedirect = Request("ReturnUrl")
                    If strRedirect Is Nothing Then
                        strRedirect = "main.aspx"
                    End If

                    Dim vRecuerdame = False 'cuando pongas tu chek de recordar tu pagina 
                    Dim tkt = New FormsAuthenticationTicket(1, user, DateTime.Now, DateTime.Now.AddMinutes(30), vRecuerdame, user)
                    Dim cookiestr = FormsAuthentication.Encrypt(tkt)
                    Dim ck = New HttpCookie("appNameAuth", cookiestr)
                    If vRecuerdame Then
                        ck.Expires = tkt.Expiration
                    End If
                    ck.Path = FormsAuthentication.FormsCookiePath
                    Response.Cookies.Add(ck)
                    Response.Redirect(strRedirect, True)
                Else
                    'Response.Redirect("login.aspx")
                    lblMensajeError.Visible = True
                    lblMensajeError2.Visible = True
                    lblMensajeError.Text = "Usuario no se encuentra registrado dentro del AD."
                    lblMensajeError2.Text = "Contraseña o nombre de usuario incorrecto."

                End If
            Else
                ' Mostrar un mensaje de error indicando que el reCAPTCHA no se ha completado correctamente.
                lblMensajeError.Text = "Por favor, completa la verificación reCAPTCHA."
                lblMensajeError.Visible = True
                lblMensajeError2.Visible = False
            End If



        Catch ex As Exception

        End Try
    End Sub

    Public Sub validar_ingreso_sistema_suite(ByVal user As String, ByVal pwd As String)
        Try

            Dim ds As New DataSet
            Dim dsUnidades As New DataSet

            'user = txtusuario.Text.ToString()
            'pwd = txtcontraseña.Text.ToString()

            '------------------reCaptcha-------------------

            'Dim respuestaRecaptcha As String = Request.Form("g-recaptcha-response")
            'Dim secretKey As String = Session("clave_secreta")
            'Dim client As New WebClient()

            'Dim result As String = client.DownloadString($"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={respuestaRecaptcha}")

            'Dim jsonResult As JObject = JObject.Parse(result)
            'Dim success As Boolean = jsonResult.Value(Of Boolean)("success")

            Dim can As Integer
            Dim usuario As String
            Dim clave As String
            Dim tipo_usuario As String = ""
            Dim id_usuario As String
            Dim id_perfil As Integer
            Dim resultado As Boolean

            'Dim i As Integer = 6
            'usuario = user
            'clave = pwd

            'Validamos la existencia del usuario en arsysusers
            Dim success As Boolean
            success = True
            If success Then

                ds = obj.valida_credenciales(user, pwd)
                can = ds.Tables(0).Rows.Count



                'Verificamos si el usuario existe
                If can > 0 Then
                    tipo_usuario = ds.Tables(0).Rows(0)(3).ToString() '1: Usuario interno , 2: usuario externo proveedor
                Else
                    lblMensajeError.Visible = True
                    lblMensajeError2.Visible = True
                    lblMensajeError.Text = "Usuario no se encuentra registrado dentro del AD."
                    lblMensajeError2.Text = "Contraseña o nombre de usuario incorrecto."
                    Return
                End If

                If tipo_usuario = 1 Then 'usuario interno - validador AD
                    resultado = True ' IsAuthenticated("acurio.net", usuario, clave)
                End If
                If tipo_usuario = 2 Then 'usuario externo - proveedor
                    resultado = 1
                End If


                If resultado Then 'Paso todo ok

                    tipo_usuario = ds.Tables(0).Rows(0)(3).ToString()
                    id_usuario = ds.Tables(0).Rows(0)(0).ToString()
                    id_perfil = Integer.Parse(ds.Tables(0).Rows(0)(1).ToString())

                    Session("tipo_usuario") = tipo_usuario '1:Usuario interno , 2: Usuario Externo
                    Session("user") = user '"imartinez"
                    Session("id_usuario") = id_usuario 'de la BD de accesos

                    Session("id_perfil") = id_perfil
                    'Perfiles:
                    '27  Perfil Dios
                    '28  Administrador de Unidad 
                    '29  Jefe de Mantenimiento   (Mientras igual que equipo de Mantenimiento)
                    '30  Equipo de Mantenimiento (Mientras igual que jefe de Mantenimiento)
                    '31  Proveedor
                    '32  Limitado


                    'Traemos el Acceso de Unidades por Usuario
                    lista_unidades_acceso()

                    'Dim strRedirect As String
                    'strRedirect = Request("ReturnUrl")
                    'If strRedirect Is Nothing Then
                    '    strRedirect = "main.aspx"
                    'End If

                    'Dim vRecuerdame = False 'cuando pongas tu chek de recordar tu pagina 
                    'Dim tkt = New FormsAuthenticationTicket(1, user, DateTime.Now, DateTime.Now.AddMinutes(30), vRecuerdame, user)
                    'Dim cookiestr = FormsAuthentication.Encrypt(tkt)
                    'Dim ck = New HttpCookie("appNameAuth", cookiestr)
                    'If vRecuerdame Then
                    '    ck.Expires = tkt.Expiration
                    'End If
                    'ck.Path = FormsAuthentication.FormsCookiePath
                    'Response.Cookies.Add(ck)
                    'Response.Redirect(strRedirect, True)

                    Response.Redirect("~/main.aspx")

                    Return

                    'Else
                    '    'Response.Redirect("login.aspx")
                    '    lblMensajeError.Visible = True
                    '    lblMensajeError2.Visible = True
                    '    lblMensajeError.Text = "Usuario no se encuentra registrado dentro del AD."
                    '    lblMensajeError2.Text = "Contraseña o nombre de usuario incorrecto."

                End If
            Else
                ' Mostrar un mensaje de error indicando que el reCAPTCHA no se ha completado correctamente.
                lblMensajeError.Text = "Por favor, completa la verificación reCAPTCHA."
                lblMensajeError.Visible = True
                lblMensajeError2.Visible = False
            End If



        Catch ex As Exception

        End Try
    End Sub
    Public Function IsAuthenticated(ByVal Domain As String, ByVal username As String, ByVal pwd As String) As Boolean
        Dim Success As Boolean = False
        Dim Entry As New System.DirectoryServices.DirectoryEntry("LDAP://" & Domain, username, pwd)
        Dim Searcher As New System.DirectoryServices.DirectorySearcher(Entry)
        Searcher.SearchScope = DirectoryServices.SearchScope.OneLevel
        Try
            Dim Results As System.DirectoryServices.SearchResult = Searcher.FindOne
            Success = Not (Results Is Nothing)
        Catch
            Success = False
        End Try
        Return Success
    End Function

    Public Function CargarActivacionGeneral() As Boolean

        Dim token As String = Session("ACTIVACION_GENERAL")
        Dim ds As New DataSet
        ds = obj.ExisteTokenActivo(token)

        If ds.Tables(0).Rows.Count > 0 Then

            Return True
        Else
            Response.Redirect("~/SesionExpirada.aspx", False)
            Return False
        End If


    End Function
    Private Function Desencriptar(textoEncriptado As String) As String

        Dim clave As String = "ACURIO2026SUPERKEY"

        Dim aes As New AesManaged()

        Dim pdb As New Rfc2898DeriveBytes(
        clave,
        New Byte() {
            &H49, &H76, &H61, &H6E,
            &H20, &H4D, &H65, &H64,
            &H76, &H65, &H64, &H65,
            &H76
        })

        aes.Key = pdb.GetBytes(32)
        aes.IV = pdb.GetBytes(16)

        Dim bytes As Byte() =
        Convert.FromBase64String(textoEncriptado)

        Dim ms As New MemoryStream(bytes)

        Dim cs As New CryptoStream(
        ms,
        aes.CreateDecryptor(),
        CryptoStreamMode.Read)

        Dim sr As New StreamReader(cs, Encoding.UTF8)

        Return sr.ReadToEnd()

    End Function

End Class