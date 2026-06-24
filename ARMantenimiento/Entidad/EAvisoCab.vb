Imports ARMantenimiento.EAvisoDet
Public Class EAvisoCab
    Public Property aufnr As String
    Public Property clase_orden As String
    Public Property prioridad As String
    Public Property ubicacion_tecnica As String
    Public Property equipo As String
    Public Property centro_planificacion As String
    Public Property descripcion As String
    Public Property fecha_inicio As String
    Public Property fecha_fin As String
    Public Property grupo_articulo As String
    Public Property grupo_compras As String
    Public Property org_compras As String
    Public Property CLASE_ACTIVIDAD As String
    Public Property puesto_trabajo As String

    Public Property servicios As List(Of EAvisoDet) = New List(Of EAvisoDet)()

    Public Property componentes As List(Of EAvisoDetComp) = New List(Of EAvisoDetComp)()

End Class
