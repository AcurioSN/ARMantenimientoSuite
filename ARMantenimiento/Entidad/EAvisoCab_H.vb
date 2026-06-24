Imports ARMantenimiento.EAvisoDet_H
Public Class EAvisoCab_H
	Public Property ebeln As String
	Public Property ebelp As String
	Public Property fecha_contable As String
	Public Property fecha_documento As String
	Public Property texto As String
	Public Property item As List(Of EAvisoDet_H) = New List(Of EAvisoDet_H)()
End Class
