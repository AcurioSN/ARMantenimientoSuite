<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="prueba.aspx.vb" Inherits="ARMantenimiento.prueba" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro de Aviso</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f5f7fa;
        }
        .card {
            border-radius: 1rem;
            box-shadow: 0 4px 12px rgba(0,0,0,0.08);
        }
        .nav-tabs .nav-link.active {
            font-weight: 600;
            color: #4b006e !important;
            border-color: #4b006e #4b006e #fff;
        }
        .stepper {
            display: flex;
            justify-content: space-between;
            margin: 1rem 0;
        }
        .step {
            text-align: center;
            flex: 1;
            position: relative;
        }
        .step::before {
            content: "";
            position: absolute;
            top: 12px;
            left: 50%;
            width: 100%;
            height: 4px;
            background-color: #dee2e6;
            z-index: -1;
        }
        .step:first-child::before { display: none; }
        .step .circle {
            width: 28px;
            height: 28px;
            border-radius: 50%;
            display: inline-flex;
            align-items: center;
            justify-content: center;
            font-size: 13px;
            color: #fff;
            font-weight: bold;
        }
        .step.completed .circle { background-color: #28a745; }
        .step.active .circle { background-color: #4b006e; }
        .step.pending .circle { background-color: #adb5bd; }
        .floating-buttons {
            position: fixed;
            bottom: 20px;
            right: 20px;
            display: flex;
            gap: 0.75rem;
            z-index: 1050;
        }
        .floating-buttons button {
            border-radius: 50px;
            padding: 0.75rem 1.25rem;
            font-weight: 500;
            display: flex;
            align-items: center;
            gap: 0.5rem;
            box-shadow: 0 4px 8px rgba(0,0,0,0.15);
        }
        .badge-aviso {
            font-size: 1rem;
            background-color: #4b006e;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <div class="container py-4">
            <div class="card p-4">
                <div class="d-flex justify-content-between align-items-center mb-3">
                    <h4 class="fw-bold mb-0">Mantenimiento de Aviso</h4>
                    <span class="badge badge-aviso text-white">Nro. Aviso: Av0001</span>
                </div>

                <!-- Tabs -->
                <ul class="nav nav-tabs mb-3">
                    <li class="nav-item">
                        <a class="nav-link active" data-bs-toggle="tab" href="#">Información General</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" data-bs-toggle="tab" href="#">Proveedor Asignado</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" data-bs-toggle="tab" href="#">Cotizaciones Proveedor</a>
                    </li>
                </ul>

                <!-- Stepper -->
                <div class="stepper">
                    <div class="step completed"><div class="circle">1</div><div class="small">Pendiente</div></div>
                    <div class="step active"><div class="circle">2</div><div class="small">Proveedor Asignado</div></div>
                    <div class="step pending"><div class="circle">3</div><div class="small">Cotización</div></div>
                    <div class="step pending"><div class="circle">4</div><div class="small">Aprobado</div></div>
                    <div class="step pending"><div class="circle">5</div><div class="small">Cerrado</div></div>
                </div>

                <!-- Formulario -->
                <div class="row g-3">
                    <div class="col-md-6">
                        <asp:DropDownList ID="ddlUnidad" runat="server" CssClass="form-select"></asp:DropDownList>
                        <label class="form-label mt-1">Unidad</label>
                    </div>
                    <div class="col-md-6">
                        <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                        <label class="form-label mt-1">Título del Aviso</label>
                    </div>
                    <div class="col-md-6">
                        <asp:DropDownList ID="ddlPrioridad" runat="server" CssClass="form-select"></asp:DropDownList>
                        <label class="form-label mt-1">Prioridad</label>
                    </div>
                    <div class="col-md-6">
                        <asp:DropDownList ID="ddlClase" runat="server" CssClass="form-select"></asp:DropDownList>
                        <label class="form-label mt-1">Clase</label>
                    </div>
                    <div class="col-md-6">
                        <asp:DropDownList ID="ddlDiagInicial" runat="server" CssClass="form-select"></asp:DropDownList>
                        <label class="form-label mt-1">Diagnóstico Inicial</label>
                    </div>
                    <div class="col-md-6">
                        <asp:DropDownList ID="ddlAreaSolic" runat="server" CssClass="form-select"></asp:DropDownList>
                        <label class="form-label mt-1">Área Solicitante</label>
                    </div>
                    <div class="col-md-6">
                        <asp:TextBox ID="txtImpacto" runat="server" CssClass="form-control"></asp:TextBox>
                        <label class="form-label mt-1">Impacto</label>
                    </div>
                    <div class="col-md-6">
                        <asp:TextBox ID="txtEquipo" runat="server" CssClass="form-control"></asp:TextBox>
                        <label class="form-label mt-1">Equipo (B)</label>
                    </div>
                    <div class="col-12">
                        <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" Rows="4" CssClass="form-control"></asp:TextBox>
                        <label class="form-label mt-1">Descripción del Aviso</label>
                    </div>
                    <div class="col-12">
                        <asp:FileUpload ID="fuAdjunto" runat="server" CssClass="form-control" />
                        <label class="form-label mt-1">Archivos Adjuntos</label>
                    </div>
                </div>
            </div>
        </div>

        <!-- Botones flotantes -->
        <div class="floating-buttons">
            <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary" Text="Registrar" />
            <asp:Button ID="btnAprobar" runat="server" CssClass="btn btn-success" Text="Aprobar" />
            <asp:Button ID="btnRechazar" runat="server" CssClass="btn btn-danger" Text="Rechazar" />
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
