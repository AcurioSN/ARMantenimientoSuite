<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Registro_aviso.aspx.vb" Inherits="ARMantenimiento.Registro_aviso" %>

<!DOCTYPE html>

<html lang="en">
	<!--begin::Head-->
	<head>
		<title>Sistema ARManto</title>
		<meta charset="utf-8" />
		<meta name="description" content="Área de Soluciones de Negocio - Sistema Web de Mantenimiento en Acurio Restaurantes." />
		<meta name="keywords" content="Start, bootstrap, bootstrap 5, admin themes, free admin themes, bootstrap admin, bootstrap dashboard, html admin theme, html template" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<meta property="og:locale" content="en_US" />
		<meta property="og:type" content="article" />
		<meta property="og:title" content="ARManto Sistema de Mantenimiento" />
		<meta property="og:url" content="https://themes.getbootstrap.com/product/start-multipurpose-admin-dashboard-theme/" />
		<meta property="og:site_name" content="Keenthemes | Start" />
		<link rel="canonical" href="https://preview.keenthemes.com/start" />
		<link rel="shortcut icon" href="images/images_sistema/LogoarmANTO.PNG" />
		<!--begin::Fonts-->
		<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700" />
		<!--end::Fonts-->

		<link href="theme/dist/assets/plugins/custom/leaflet/leaflet.bundle.css" rel="stylesheet" type="text/css" />
		<link href="theme/dist/assets/plugins/global/plugins.bundle.css" rel="stylesheet" type="text/css" />
		<link href="theme/dist/assets/css/style.bundle.css" rel="stylesheet" type="text/css" />
		<script src="assets/libs/jquery/dist/jquery.min.js"></script>
	    <script src="assets/libs/bootstrap/dist/js/bootstrap.min.js"></script>
		
		<link href="theme/dist/assets/plugins/custom/prismjs/prismjs.bundle.css" rel="stylesheet" type="text/css" />
		<link href="theme/dist/assets/plugins/global/plugins.bundle.css" rel="stylesheet" type="text/css" />
		<link href="theme/dist/assets/css/style.bundle.css" rel="stylesheet" type="text/css" />
		<link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.10.5/font/bootstrap-icons.css" rel="stylesheet">

	<script>
        function CerrarSesion() {
            /*  alert('hola');*/
            var btnCerrarSesion = document.getElementById('<%=btnCerrarSesion.ClientID %>');
            btnCerrarSesion.click();
		}


    </script>
		
	
		<script>

           <%-- function adjuntar() {
                //alert('hola');
                var btnadjuntarP = document.getElementById('<%=btnAdjuntarP.ClientID %>');
             btnadjuntarP.click();
         }--%>
    
			function adjuntar() {
				var fileInput = document.getElementById('<%=inputGroupFile04.ClientID %>');
				var filePath = fileInput.value;

 
				if (!filePath) {
					alert('Por favor, seleccione un archivo.');
					return false;
				}

				var btnadjuntarP = document.getElementById('<%=btnAdjuntarP.ClientID %>');
				btnadjuntarP.click();
			}


			function adjuntar_sustento() {
				var fileInput = document.getElementById('<%=inputGroupFile04_sustento.ClientID %>');
				var filePath = fileInput.value;

 
				if (!filePath) {
					alert('Por favor, seleccione un archivo.');
					return false;
				}

				var btnadjuntarP_sustento = document.getElementById('<%=btnAdjuntarP_sustento.ClientID %>');
				btnadjuntarP_sustento.click();
			}


			

		</script>
     <script type="text/javascript">
         function popup() {
			 /*$('.bs-example-modal-lg').modal("show");*/
			 $('#myModal_busqueda_equipos').modal("show");
		 };


		 function popup_proveedor() {
			 // Activa el tab2
			 //$('#tab2-tab').tab('show');

			 $('#myModal_busqueda_proveedor').modal("show");
		 };

		
		

		 function cerrar_popup_equipos() {
			 /*alert("cerrar popup");*/
			 //$('#myModal_busqueda').modal("hide");

			 /* $("#myModal_busqueda").modal('hide');//ocultamos el modal*/
			 var btnCerrarPopupEquipos = document.getElementById('<%=btnCerrarPopupEquipos.ClientID %>');
			 btnCerrarPopupEquipos.click();

		 };
		 function cerrar_popup_proveedores() {
			 /*alert("cerrar popup");*/
			 //$('#myModal_busqueda').modal("hide");

			 /* $("#myModal_busqueda").modal('hide');//ocultamos el modal*/
			 var btnCerrarPopupEquipos = document.getElementById('<%=btnCerrarPopupEquipos.ClientID %>');
			 btnCerrarPopupEquipos.click();

		 };
		 function cerrar_popup_cotizaciones() {
			 /*alert("cerrar popup");*/
			 //$('#myModal_busqueda').modal("hide");

			 /* $("#myModal_busqueda").modal('hide');//ocultamos el modal*/
			 var btnCerrarPopupCotizaciones = document.getElementById('<%=btnCerrarPopupCotizaciones.ClientID %>');
			 btnCerrarPopupCotizaciones.click();

		 };
	 </script>
		

     <style>
        /*css process modal -  processing-modal*/
        .modal-static2 { 
            position: fixed;
            top: 50% !important; 
            left: 50% !important; 
            margin-top: -100px;  
            margin-left: -150px; 
            overflow: visible !important;
        }
        .modal-static2,
        .modal-static2 .modal-dialog,
        .modal-static2 .modal-content {
            width: 300px; 
            height: 90px; 
        }
        .modal-static2 .modal-dialog,
        .modal-static2 .modal-content {
            padding: 0 !important; 
            margin: 0 !important;
        }
        .modal-static2 .modal-content .icon {
        }
        .modal-text{
            text-align:center;
            font-family:Cambria;
            font-weight:normal;
            font-size:medium;
        }
    </style>
	
	

		<%-- Diseño del Formulario --%>
<style>
  /* ====== ESTILO GLOBAL ====== */
  body {
    font-family: "Segoe UI", Roboto, Arial, sans-serif;
    font-size: 1.1rem; /* base más grande */
    color: #172b4d;
    background-color: #f4f5f7;
    margin: 0;
    padding: 20px;
  }

  label {
    display: block;
    margin-bottom: 6px;
    font-weight: 600;
    font-size: 1.1rem; /* igual que el body */
    color: #344563;
  }

  input[type="text"],
  input[type="email"],
  input[type="number"],
  input[type="date"],
  textarea,
  select {
    width: 100%;
    padding: 12px 14px;
    font-size: 1.1rem;
    border: 1px solid #dfe1e6;
    border-radius: 8px;
    background-color: #fff;
    transition: border-color 0.2s ease, box-shadow 0.2s ease;
  }

  /* ====== ESTADO FOCUS (color corporativo) ====== */
  input:focus,
  textarea:focus,
  select:focus {
    border-color: #860264 !important;
    box-shadow: 0 0 0 3px rgba(134, 2, 100, 0.25);
    outline: none;
  }

  /* ====== BOTONES NATIVOS ====== */
  button {
    background-color: #860264;
    color: #fff;
    font-size: 1.1rem;
    font-weight: 600;
    padding: 12px 20px;
    border: none;
    border-radius: 8px;
    cursor: pointer;
    transition: background-color 0.2s ease, transform 0.1s ease, box-shadow 0.2s ease;
    box-shadow: 0 2px 6px rgba(0, 0, 0, 0.08);
  }

  button:hover {
    background-color: #a30f7a;
    box-shadow: 0 4px 10px rgba(0, 0, 0, 0.15);
  }

  button:active {
    transform: scale(0.97);
  }

  /* ====== TARJETA / CONTENEDOR ====== */
  .card {
    background-color: #fff;
    padding: 24px;
    border-radius: 12px;
    box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
    margin-bottom: 20px;
  }
</style>

<%-- Diseño de los botones uniformes estilo Jira 2025 --%>
<style>
  .button-row {
    display: flex;
    gap: 1rem;
    justify-content: flex-start;
    margin-top: 1rem;
  }

  .icon-button {
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 0.5rem;
    background-color: #f4f5f7;
    border: 1px solid #dfe1e6;
    color: #172b4d;
    font-size: 1.1rem;
    font-weight: 500;
    padding: 0.75rem 1.25rem;
    border-radius: 8px;
    text-decoration: none;
    transition: all 0.25s ease;
    cursor: pointer;

    /* --- Uniformidad --- */
    min-width: 150px; /* ancho mínimo uniforme */
    height: 50px;     /* altura fija */
    text-align: center;
    box-shadow: 0 2px 6px rgba(0, 0, 0, 0.08);
  }

  .icon-button i {
    font-size: 1.2rem;
  }

  .icon-button:hover {
    background-color: #860264;
    border-color: #860264;
    color: #ffffff;
    box-shadow: 0 4px 10px rgba(134, 2, 100, 0.3);
  }

  .icon-button:focus {
    outline: none;
    border-color: #860264;
    box-shadow: 0 0 0 3px rgba(134, 2, 100, 0.4);
  }

  /* Variante primaria (ej. Registrar) */
  .icon-button.primary {
    background-color: #860264;
    color: #fff;
    border: 1px solid #860264;
  }

  .icon-button.primary:hover {
    background-color: #a5037c;
    border-color: #a5037c;
  }

  /* Variante de peligro (ej. Limpiar/Rechazar) */
  .icon-button.danger {
    background-color: #ffebe6;
    color: #de350b;
    border: 1px solid #ffbdad;
  }

  .icon-button.danger:hover {
    background-color: #de350b;
    color: #fff;
    border-color: #de350b;
  }
</style>

<!-- Estilos personalizados Linea tiempo -->
<style>
.timeline-horizontal {
  position: relative;
  width: 100%;
  padding: 0 10px;
}
.timeline-horizontal::before {
  content: "";
  position: absolute;
  top: 12px; /* línea atraviesa el centro del círculo */
  left: 0;
  right: 0;
  height: 2px;
  background-color: #dee2e6;
  z-index: 1;
}
.timeline-step {
  position: relative;
  z-index: 2;
}
.timeline-marker {
  width: 20px;
  height: 20px;
  border-radius: 50%;
  margin: 0 auto;
  position: relative;
  z-index: 2;
}
</style>
<style>
    /* Estilos para botones flotantes */
    .btn-float {
        font-size: 1rem;               /* tamaño de fuente más grande */
        font-weight: 500;              /* texto más sólido */
        transition: all 0.2s ease-in;  /* animación suave */
    }

    .btn-float i {
        font-size: 1.1rem;             /* íconos también un poco más grandes */
    }

    .btn-float:hover {
        background-color: #f8f9fa;     /* gris claro al hover */
        box-shadow: 0 4px 12px rgba(0,0,0,0.15); 
        transform: translateY(-2px);   /* efecto flotante */
    }
</style>

	<style>
  /* Color de Acurio para los TAB */
  /*.nav-tabs .nav-link {
    color: #540f4a;*/             /* texto normal */
    /*font-weight: 500;
  }

  .nav-tabs .nav-link:hover {
    color: #380a31;*/             /* un tono más oscuro al hover */
  /*}

  .nav-tabs .nav-link.active {
    color: #fff;*/                /* texto blanco cuando está activo */
    /*background-color: #540f4a;*/  /* fondo corporativo */
    /*border-color: #540f4a;*/      /* borde también corporativo */
  /*}*/

  /* Tabs personalizados estilo Acurio */
.custom-tabs .nav-link {
  font-weight: 600;
  color: #1a2b49; /* Azul oscuro elegante */
  border: none;
  border-bottom: 3px solid transparent;
  transition: all 0.3s ease;
  padding: 0.75rem 1.25rem;
}

.custom-tabs .nav-link i {
  font-size: 1rem;
  opacity: 0.75;
}

.custom-tabs .nav-link:hover {
  color: #540f4a; /* Dorado/Amarillo elegante */
  border-bottom: 3px solid #540f4a;
  background-color: rgba(184, 134, 11, 0.05); /* fondo muy suave */
}

.custom-tabs .nav-link.active {
  color: #540f4a; /* Dorado */
  border-bottom: 3px solid #540f4a;
  background-color: transparent;
}

.custom-tabs {
  border-bottom: 2px solid #eee;
}


</style>
	<style>
	/* Botón circular */
.btn-circle {
    width: 36px;
    height: 36px;
    border-radius: 50% !important;
    display: flex;
    align-items: center;
    justify-content: center;
    padding: 0;
}

/* Color personalizado (en vez de verde por defecto) */
.btn-outline-custom {
    border: 1px solid #975a89;
    color: #975a89;
    background-color: transparent;
}

/* Hover: mantiene el círculo y el ícono centrado */
.btn-outline-custom:hover {
    background-color: #975a89;
    color: #fff;
    border-color: #975a89;
}


	</style>
		<style>
			/* Cabecera */
.modal-header {
    background-color: #975a89;
    color: #fff;
    border-bottom: 2px solid #7a476e; /* tono más oscuro */
}
.modal-header_cotizador {
    background-color: #FFFFFF;
    color: #fff;
    border-bottom: 2px solid #7a476e; /* tono más oscuro */
}

/* Cuerpo */
.modal-body {
    background-color: #ffffff;
    padding: 1rem 1.5rem;
}

/* Footer */
.modal-footer {
    background-color: #ffffff;
    border-top: 1px solid #dee2e6;
    padding: 0.75rem 1.5rem;
}


		</style>

		<style>
			/* Botón morado */
			.btn-purple {
				background-color: #6f42c1;
				border: none;
			}

			.btn-purple:hover {
				background-color: #5a379e;
			}

			/* Animación bounce */
			@keyframes bounceIn {
				0% {
					opacity: 0;
					transform: scale(0.3);
				}
				50% {
					opacity: 1;
					transform: scale(1.05);
				}
				70% {
					transform: scale(0.9);
				}
				100% {
					transform: scale(1);
				}
			}

			.bounce-effect {
				animation: bounceIn 0.6s ease;
			}


		</style>

		<style>
			.resaltar-obligatorio {
				border: 2px solid #dc3545 !important; /* rojo Bootstrap */
				box-shadow: 0 0 5px rgba(220, 53, 69, 0.5);
				background-color: #fff5f5;
			}
		</style>
		
		<%--filtro de busqueda de equipos--%>
		<style>

			.modal-header, .modal-footer {
					border: none !important;
				}

			.modal-content {
				border-radius: 16px;
				box-shadow: 0 8px 30px rgba(0, 0, 0, 0.2);
				border: none;
			}
			.modal-body {
				padding: 1.5rem 2rem;
			}

		</style>
		<style>
			/* TextBox más delgado */
			.textbox-thin {
				height: 24px !important;      /* controla la altura */
				padding: 2px 4px !important;  /* reduce el espacio interno */
				font-size: 0.85rem;           /* texto un poco más pequeño */
			}

		</style>
		<style>
    .input-uniforme {
        height: 31px;      /* iguala la altura en todos (ajusta según veas en tu proyecto) */
        padding: .25rem .5rem;
        font-size: .875rem; /* mismo tamaño que form-control-sm */
    }
</style>



	</head>
	<!--end::Head-->
	<!--begin::Body-->
		<body id="kt_body" class="header-fixed header-tablet-and-mobile-fixed aside-enabled aside-fixed aside-primary-enabled aside-secondary-enabled" style="" data-kt-aside-minimize="on">
		<!--begin::Main-->
		<!--begin::Root-->
		<div class="d-flex flex-column flex-root">
			<!--begin::Page-->
			<div class="page d-flex flex-row flex-column-fluid">
				<!--begin::Aside-->
				<div id="kt_aside" class="aside bg-info" data-kt-drawer="true" data-kt-drawer-name="aside" data-kt-drawer-activate="{default: true, lg: false}" data-kt-drawer-overlay="true" data-kt-drawer-width="{default:'200px', '300px': '250px'}" data-kt-drawer-direction="start" data-kt-drawer-toggle="#kt_aside_toggler">
					<!--begin::Primary-->
					<div class="aside-primary d-flex flex-column align-items-center flex-row-auto" style="background: linear-gradient(to right, #540f4a, #975a89);">
						<!--begin::Logo-->
						<div class="aside-logo d-flex flex-column align-items-center flex-column-auto py-4 pt-lg-10 pb-lg-7" id="kt_aside_logo">
							<a href="main.aspx">
								<img alt="Logo" src="images/images_sistema/logoARManto.png" class="mh-100px" />
							</a>
						</div>
						<!--end::Logo-->
						<!--begin::Nav Wrapper-->
						<div class="aside-nav d-flex flex-column align-items-center flex-column-fluid pt-0 pb-5" id="kt_aside_nav">
							<!--begin::Nav scroll-->
							<div class="hover-scroll-y" data-kt-scroll="true" data-kt-scroll-height="auto" data-kt-scroll-dependencies="#kt_aside_logo, #kt_aside_footer" data-kt-scroll-wrappers="#kt_aside_nav" data-kt-scroll-offset="10px">
								<!--begin::Nav-->
								<%--<ul class="nav flex-column">
									<!--begin::Item-->
									<li class="nav-item mb-1" title="Features" data-bs-toggle="tooltip" data-bs-dismiss="click" data-bs-placement="right">
										<a href="#" class="nav-link h-40px w-40px h-lg-50px w-lg-50px btn btn-custom btn-icon btn-color-white active" data-bs-toggle="tab" data-bs-target="#kt_aside_tab_1" role="tab">
											<!--begin::Svg Icon | path: icons/duotune/general/gen025.svg-->
											<span class="svg-icon svg-icon-2 svg-icon-lg-1">
												<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
													<rect x="2" y="2" width="9" height="9" rx="2" fill="black" />
													<rect opacity="0.3" x="13" y="2" width="9" height="9" rx="2" fill="black" />
													<rect opacity="0.3" x="13" y="13" width="9" height="9" rx="2" fill="black" />
													<rect opacity="0.3" x="2" y="13" width="9" height="9" rx="2" fill="black" />
												</svg>
											</span>
											<!--end::Svg Icon-->
										</a>
									</li>
									<!--end::Item-->
									<!--begin::Item-->
									<li class="nav-item mb-1" title="Members" data-bs-toggle="tooltip" data-bs-dismiss="click" data-bs-placement="right">
										<a href="#" class="nav-link h-40px w-40px h-lg-50px w-lg-50px btn btn-custom btn-icon btn-color-white" data-bs-toggle="tab" data-bs-target="#kt_aside_tab_2" role="tab">
											<!--begin::Svg Icon | path: icons/duotune/finance/fin006.svg-->
											<span class="svg-icon svg-icon-2 svg-icon-lg-1">
												<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
													<path opacity="0.3" d="M20 15H4C2.9 15 2 14.1 2 13V7C2 6.4 2.4 6 3 6H21C21.6 6 22 6.4 22 7V13C22 14.1 21.1 15 20 15ZM13 12H11C10.5 12 10 12.4 10 13V16C10 16.5 10.4 17 11 17H13C13.6 17 14 16.6 14 16V13C14 12.4 13.6 12 13 12Z" fill="black" />
													<path d="M14 6V5H10V6H8V5C8 3.9 8.9 3 10 3H14C15.1 3 16 3.9 16 5V6H14ZM20 15H14V16C14 16.6 13.5 17 13 17H11C10.5 17 10 16.6 10 16V15H4C3.6 15 3.3 14.9 3 14.7V18C3 19.1 3.9 20 5 20H19C20.1 20 21 19.1 21 18V14.7C20.7 14.9 20.4 15 20 15Z" fill="black" />
												</svg>
											</span>
											<!--end::Svg Icon-->
										</a>
									</li>
									<!--end::Item-->
									<!--begin::Item-->
									<li class="nav-item mb-1" title="Latest Reports" data-bs-toggle="tooltip" data-bs-dismiss="click" data-bs-placement="right">
										<a href="#" class="nav-link h-40px w-40px h-lg-50px w-lg-50px btn btn-custom btn-icon btn-color-white" data-bs-toggle="tab" data-bs-target="#kt_aside_tab_3" role="tab">
											<!--begin::Svg Icon | path: icons/duotune/general/gen032.svg-->
											<span class="svg-icon svg-icon-2 svg-icon-lg-1">
												<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
													<rect x="8" y="9" width="3" height="10" rx="1.5" fill="black" />
													<rect opacity="0.5" x="13" y="5" width="3" height="14" rx="1.5" fill="black" />
													<rect x="18" y="11" width="3" height="8" rx="1.5" fill="black" />
													<rect x="3" y="13" width="3" height="6" rx="1.5" fill="black" />
												</svg>
											</span>
											<!--end::Svg Icon-->
										</a>
									</li>
									<!--end::Item-->
									<!--begin::Item-->
									<li class="nav-item mb-1" title="Project Management" data-bs-toggle="tooltip" data-bs-dismiss="click" data-bs-placement="right">
										<a href="#" class="nav-link h-40px w-40px h-lg-50px w-lg-50px btn btn-custom btn-icon btn-color-white" data-bs-toggle="tab" data-bs-target="#kt_aside_tab_2" role="tab">
											<!--begin::Svg Icon | path: icons/duotune/general/gen048.svg-->
											<span class="svg-icon svg-icon-2 svg-icon-lg-1">
												<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
													<path opacity="0.3" d="M20.5543 4.37824L12.1798 2.02473C12.0626 1.99176 11.9376 1.99176 11.8203 2.02473L3.44572 4.37824C3.18118 4.45258 3 4.6807 3 4.93945V13.569C3 14.6914 3.48509 15.8404 4.4417 16.984C5.17231 17.8575 6.18314 18.7345 7.446 19.5909C9.56752 21.0295 11.6566 21.912 11.7445 21.9488C11.8258 21.9829 11.9129 22 12.0001 22C12.0872 22 12.1744 21.983 12.2557 21.9488C12.3435 21.912 14.4326 21.0295 16.5541 19.5909C17.8169 18.7345 18.8277 17.8575 19.5584 16.984C20.515 15.8404 21 14.6914 21 13.569V4.93945C21 4.6807 20.8189 4.45258 20.5543 4.37824Z" fill="black" />
													<path d="M10.5606 11.3042L9.57283 10.3018C9.28174 10.0065 8.80522 10.0065 8.51412 10.3018C8.22897 10.5912 8.22897 11.0559 8.51412 11.3452L10.4182 13.2773C10.8099 13.6747 11.451 13.6747 11.8427 13.2773L15.4859 9.58051C15.771 9.29117 15.771 8.82648 15.4859 8.53714C15.1948 8.24176 14.7183 8.24176 14.4272 8.53714L11.7002 11.3042C11.3869 11.6221 10.874 11.6221 10.5606 11.3042Z" fill="black" />
												</svg>
											</span>
											<!--end::Svg Icon-->
										</a>
									</li>
									<!--end::Item-->
									<!--begin::Item-->
									<li class="nav-item mb-1" title="User Management" data-bs-toggle="tooltip" data-bs-dismiss="click" data-bs-placement="right">
										<a href="#" class="nav-link h-40px w-40px h-lg-50px w-lg-50px btn btn-custom btn-icon btn-color-white" data-bs-toggle="tab" data-bs-target="#kt_aside_tab_3" role="tab">
											<!--begin::Svg Icon | path: icons/duotune/abstract/abs027.svg-->
											<span class="svg-icon svg-icon-2 svg-icon-lg-1">
												<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
													<path opacity="0.3" d="M21.25 18.525L13.05 21.825C12.35 22.125 11.65 22.125 10.95 21.825L2.75 18.525C1.75 18.125 1.75 16.725 2.75 16.325L4.04999 15.825L10.25 18.325C10.85 18.525 11.45 18.625 12.05 18.625C12.65 18.625 13.25 18.525 13.85 18.325L20.05 15.825L21.35 16.325C22.35 16.725 22.35 18.125 21.25 18.525ZM13.05 16.425L21.25 13.125C22.25 12.725 22.25 11.325 21.25 10.925L13.05 7.62502C12.35 7.32502 11.65 7.32502 10.95 7.62502L2.75 10.925C1.75 11.325 1.75 12.725 2.75 13.125L10.95 16.425C11.65 16.725 12.45 16.725 13.05 16.425Z" fill="black" />
													<path d="M11.05 11.025L2.84998 7.725C1.84998 7.325 1.84998 5.925 2.84998 5.525L11.05 2.225C11.75 1.925 12.45 1.925 13.15 2.225L21.35 5.525C22.35 5.925 22.35 7.325 21.35 7.725L13.05 11.025C12.45 11.325 11.65 11.325 11.05 11.025Z" fill="black" />
												</svg>
											</span>
											<!--end::Svg Icon-->
										</a>
									</li>
									<!--end::Item-->
									<!--begin::Item-->
									<li class="nav-item mb-1" title="Finance &amp; Accounting" data-bs-toggle="tooltip" data-bs-dismiss="click" data-bs-placement="right">
										<a href="#" class="nav-link h-40px w-40px h-lg-50px w-lg-50px btn btn-custom btn-icon btn-color-white" data-bs-toggle="tab" data-bs-target="#kt_aside_tab_6" role="tab">
											<!--begin::Svg Icon | path: icons/duotune/files/fil005.svg-->
											<span class="svg-icon svg-icon-2 svg-icon-lg-1">
												<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
													<path opacity="0.3" d="M19 22H5C4.4 22 4 21.6 4 21V3C4 2.4 4.4 2 5 2H14L20 8V21C20 21.6 19.6 22 19 22ZM16 13H13V10C13 9.4 12.6 9 12 9C11.4 9 11 9.4 11 10V13H8C7.4 13 7 13.4 7 14C7 14.6 7.4 15 8 15H11V18C11 18.6 11.4 19 12 19C12.6 19 13 18.6 13 18V15H16C16.6 15 17 14.6 17 14C17 13.4 16.6 13 16 13Z" fill="black" />
													<path d="M15 8H20L14 2V7C14 7.6 14.4 8 15 8Z" fill="black" />
												</svg>
											</span>
											<!--end::Svg Icon-->
										</a>
									</li>
									<!--end::Item-->
								</ul>--%>
								<!--end::Nav-->
							</div>
							<!--end::Nav scroll-->
						</div>
						<!--end::Nav Wrapper-->
						<!--begin::Footer-->
						<div class="aside-footer d-flex flex-column align-items-center flex-column-auto py-5 py-lg-7" id="kt_aside_footer">
							<!--begin::Aside Toggle-->
							<button class="btn btn-sm btn-icon btn-white btn-active-primary position-absolute translate-middle start-100 end-0 bottom-0 shadow-sm d-none d-lg-flex" id="kt_aside_toggle" data-kt-toggle="true" data-kt-toggle-state="active" data-kt-toggle-target="body" data-kt-toggle-name="aside-minimize" title="Toggle Aside">
								<!--begin::Svg Icon | path: icons/duotune/arrows/arr063.svg-->
								<span class="svg-icon svg-icon-2 rotate-180">
									<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
										<rect opacity="0.5" x="6" y="11" width="13" height="2" rx="1" fill="black" />
										<path d="M8.56569 11.4343L12.75 7.25C13.1642 6.83579 13.1642 6.16421 12.75 5.75C12.3358 5.33579 11.6642 5.33579 11.25 5.75L5.70711 11.2929C5.31658 11.6834 5.31658 12.3166 5.70711 12.7071L11.25 18.25C11.6642 18.6642 12.3358 18.6642 12.75 18.25C13.1642 17.8358 13.1642 17.1642 12.75 16.75L8.56569 12.5657C8.25327 12.2533 8.25327 11.7467 8.56569 11.4343Z" fill="black" />
									</svg>
								</span>
								<!--end::Svg Icon-->
							</button>
							<!--end::Aside Toggle-->
							<!--begin::Menu-->
							<div class="mb-2" data-bs-toggle="tooltip" data-bs-placement="right" data-bs-trigger="hover" title="Quick settings">
								<%--<button type="button" class="btn btn-custom h-40px w-40px h-lg-50px w-lg-50px btn-icon btn-color-white" data-kt-menu-trigger="click" data-kt-menu-overflow="true" data-kt-menu-placement="top-start" data-kt-menu-flip="top-end">
									<!--begin::Svg Icon | path: icons/duotune/general/gen008.svg-->
									<span class="svg-icon svg-icon-2 svg-icon-lg-1">
										<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
											<path d="M3 2H10C10.6 2 11 2.4 11 3V10C11 10.6 10.6 11 10 11H3C2.4 11 2 10.6 2 10V3C2 2.4 2.4 2 3 2Z" fill="black" />
											<path opacity="0.3" d="M14 2H21C21.6 2 22 2.4 22 3V10C22 10.6 21.6 11 21 11H14C13.4 11 13 10.6 13 10V3C13 2.4 13.4 2 14 2Z" fill="black" />
											<path opacity="0.3" d="M3 13H10C10.6 13 11 13.4 11 14V21C11 21.6 10.6 22 10 22H3C2.4 22 2 21.6 2 21V14C2 13.4 2.4 13 3 13Z" fill="black" />
											<path opacity="0.3" d="M14 13H21C21.6 13 22 13.4 22 14V21C22 21.6 21.6 22 21 22H14C13.4 22 13 21.6 13 21V14C13 13.4 13.4 13 14 13Z" fill="black" />
										</svg>
									</span>
									<!--end::Svg Icon-->
								</button>--%>
								<!--begin::Menu-->
								<div class="menu menu-sub menu-sub-dropdown menu-column menu-rounded menu-gray-600 menu-state-bg-light-primary fw-bold w-200px" data-kt-menu="true">
									<div class="menu-item px-3">
										<div class="menu-content fs-6 text-dark fw-bolder px-3 py-4">Manage</div>
									</div>
									<div class="separator mb-3 opacity-75"></div>
									<div class="menu-item px-3">
										<a href="#" class="menu-link px-3">Add User</a>
									</div>
									<div class="menu-item px-3">
										<a href="#" class="menu-link px-3">Add Role</a>
									</div>
									<div class="menu-item px-3" data-kt-menu-trigger="hover" data-kt-menu-placement="right-start" data-kt-menu-flip="left-start, top">
										<a href="#" class="menu-link px-3">
											<span class="menu-title">Add Group</span>
											<span class="menu-arrow"></span>
										</a>
										<div class="menu-sub menu-sub-dropdown w-200px py-4">
											<div class="menu-item px-3">
												<a href="#" class="menu-link px-3">Admin Group</a>
											</div>
											<div class="menu-item px-3">
												<a href="#" class="menu-link px-3">Staff Group</a>
											</div>
											<div class="menu-item px-3">
												<a href="#" class="menu-link px-3">Member Group</a>
											</div>
										</div>
									</div>
									<div class="menu-item px-3">
										<a href="#" class="menu-link px-3">Reports</a>
									</div>
									<div class="separator mt-3 opacity-75"></div>
									<div class="menu-item px-3">
										<div class="menu-content px-3 py-3">
											<a class="btn btn-primary fw-bold btn-sm px-4" href="#">Create New</a>
										</div>
									</div>
								</div>
								<!--end::Menu-->
							</div>
							<!--end::Menu-->
						</div>
						<!--end::Footer-->
					</div>
					<!--end::Primary-->
					<!--begin::Secondary-->
					<div class="aside-secondary d-flex flex-row-fluid bg-white">
						<!--begin::Workspace-->
						<div class="aside-workspace my-7 ps-5 pe-4 ps-lg-10 pe-lg-6" id="kt_aside_wordspace">
							<!--begin::Tab Content-->
							<div class="tab-content">
								<!--begin::Main menu-->
								<div class="tab-pane fade show active" id="kt_aside_tab_1">
									<!--begin::Aside Menu-->
									<!--begin::Menu-->
									<div class="menu menu-column menu-rounded menu-title-gray-700 menu-state-title-primary menu-state-icon-primary menu-state-bullet-primary menu-arrow-gray-500 fw-bold fs-6" data-kt-menu="true">
										<div class="hover-scroll-y pe-4 pe-lg-5" id="kt_aside_menu_scroll" data-kt-scroll="true" data-kt-scroll-height="auto" data-kt-scroll-wrappers="#kt_aside_wordspace" data-kt-scroll-offset="10px">
											<div class="menu-wrapper menu-column menu-fit">
												<div class="menu-item here show">
													<h4 class="menu-content text-dark mb-0 fs-4 fw-semibold"
    style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; letter-spacing: 0.5px;">
  Sistema <span style="color:#2c3e50;">ARManto</span>
</h4>
													<div class="menu-sub menu-fit menu-sub-accordion show pb-10">
														<div class="menu-item">
															<a class="menu-link py-2 text-dark fw-normal" href="main.aspx" 
															   style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: 14px;">
																			<span class="menu-title">Menú principal</span>
															</a>
														</div>
														<%--<div class="menu-item">
															<a class="menu-link active py-2" href="../dist/dashboards/extended.html">
																<span class="menu-title">Extended</span>
															</a>
														</div>
														<div class="menu-item">
															<a class="menu-link py-2" href="../dist/dashboards/light.html">
																<span class="menu-title">Light</span>
															</a>
														</div>
														<div class="menu-item">
															<a class="menu-link py-2" href="../dist/dashboards/compact.html">
																<span class="menu-title">Compact</span>
															</a>
														</div>--%>
													</div>
												</div>
												<div class="menu-item">
													<%--<h4 class="menu-content text-muted mb-0 fs-6 fw-bold text-uppercase">Opciones del sistema</h4>--%>
													<h4 class="menu-content text-dark mb-0 fs-5 fw-normal" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">
													  Opciones del sistema
													</h4>

													<div class="menu-sub menu-fit menu-sub-accordion show pb-10">
															<div class="menu-item">
																<a class="menu-link py-2 text-dark fw-normal" href="Registro_aviso.aspx" 
																   style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: 14px;">
																	<span class="menu-title">Crear Aviso</span>
																</a>
															</div>
															<div class="menu-item">
																<a class="menu-link py-2 text-dark fw-normal" href="MantenimientoAvisos.aspx" 
																   style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: 14px;">
																	<span class="menu-title">Administrador de Avisos</span>
																</a>
															</div>
															<div class="menu-item">
																<a class="menu-link py-2 text-dark fw-normal" href="main.aspx" 
																   style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: 14px;">
																	<span class="menu-title">Analítica</span>
																</a>
															</div>
															<div class="menu-item">
																<a class="menu-link py-2 text-dark fw-normal" href="main.aspx" 
																   style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: 14px;">
																	<span class="menu-title">Reportes</span>
																</a>
															</div>
														</div>

												</div>

											
												<%--<div class="menu-item">
													<h4 class="menu-content text-muted mb-0 fs-6 fw-bold text-uppercase">Mantenimiento</h4>
													<div class="menu-sub menu-fit menu-sub-accordion show pb-10">
														<div class="menu-item">
															<a class="menu-link py-2" href="main.aspx">
																<span class="menu-title">Empresa</span>
															</a>
														</div>
														<div class="menu-item">
															<a class="menu-link py-2" href="main.aspx">
																<span class="menu-title">Marca</span>
															</a>
														</div>
														<div class="menu-item">
															<a class="menu-link py-2" href="main.aspx">
																<span class="menu-title">Unidad</span>
															</a>
														</div>
														<div class="menu-item">
															<a class="menu-link py-2" href="main.aspx">
																<span class="menu-title">Motivos</span>
															</a>
														</div>
														<div class="menu-item">
															<a class="menu-link py-2" href="main.aspx">
																<span class="menu-title">Categoría 1</span>
															</a>
														</div>
														<div class="menu-item">
															<a class="menu-link py-2" href="main.aspx">
																<span class="menu-title">Tipo 1</span>
															</a>
														</div>
														<div class="menu-item">
															<a class="menu-link py-2" href="main.aspx">
																<span class="menu-title">Categoría 2</span>
															</a>
														</div>
														<div class="menu-item">
															<a class="menu-link py-2" href="main.aspx">
																<span class="menu-title">Tipo 2</span>
															</a>
														</div>
													</div>
												</div>--%>
<%--												<div class="menu-item">
													<h4 class="menu-content text-muted mb-0 fs-6 fw-bold text-uppercase">Profile</h4>
													<div class="menu-sub menu-fit menu-sub-accordion show pb-10">
														<div class="menu-item">
															<a class="menu-link py-2" href="main.aspx">
																<span class="menu-title">Datos Usuario</span>
															</a>
														</div>
													
													</div>
												</div>--%>
												
											</div>
										</div>
									</div>
									<!--end::Menu-->
								</div>
								<!--end::Main menu-->
								<!--begin::Demo menu-->
								<div class="tab-pane fade" id="kt_aside_tab_2">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.</div>
								<!--end::Demo menu-->
								<!--begin::Demo menu-->
								<div class="tab-pane fade" id="kt_aside_tab_3">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.</div>
								<!--end::Demo menu-->
							</div>
							<!--end::Tab Content-->
						</div>
						<!--end::Workspace-->
					</div>
					<!--end::Secondary-->
				</div>
				<!--end::Aside-->
				<!--begin::Wrapper-->
				<div class="wrapper d-flex flex-column flex-row-fluid" id="kt_wrapper">
					<!--begin::Header-->
					<div id="kt_header" class="header" data-kt-sticky="true" data-kt-sticky-name="header" data-kt-sticky-offset="{default: '200px', lg: '300px'}">
						<!--begin::Container-->
						<div class="container-xxl d-flex align-items-stretch justify-content-between">
							<!--begin::Left-->
							<div class="d-flex align-items-center">
								<!--begin::Title-->
								<h3 class="text-dark fw-bolder my-1 fs-2">Menú | Mantenimiento Aviso</h3>
								<!--end::Title-->
							</div>
							
													
							<!--end::Left-->
							<!--begin::Right-->
							<div class="d-flex align-items-center">
								<!--begin::Search-->
							<%--	<button class="btn btn-icon btn-sm btn-active-bg-accent ms-1 ms-lg-6" data-bs-toggle="modal" data-bs-target="#kt_header_search_modal" id="kt_header_search_toggle">
									<!--begin::Svg Icon | path: icons/duotune/general/gen021.svg-->
									<span class="svg-icon svg-icon-1 svg-icon-dark">
										<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
											<rect opacity="0.5" x="17.0365" y="15.1223" width="8.15546" height="2" rx="1" transform="rotate(45 17.0365 15.1223)" fill="black" />
											<path d="M11 19C6.55556 19 3 15.4444 3 11C3 6.55556 6.55556 3 11 3C15.4444 3 19 6.55556 19 11C19 15.4444 15.4444 19 11 19ZM11 5C7.53333 5 5 7.53333 5 11C5 14.4667 7.53333 17 11 17C14.4667 17 17 14.4667 17 11C17 7.53333 14.4667 5 11 5Z" fill="black" />
										</svg>
									</span>
									<!--end::Svg Icon-->
								</button>--%>
								<!--end::Search-->
								<!--begin::Message-->
								<%--<button class="btn btn-icon btn-sm btn-active-bg-accent ms-1 ms-lg-6" id="kt_drawer_chat_toggle">
									<!--begin::Svg Icon | path: icons/duotune/communication/com003.svg-->
									<span class="svg-icon svg-icon-1 svg-icon-dark">
										<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
											<path opacity="0.3" d="M2 4V16C2 16.6 2.4 17 3 17H13L16.6 20.6C17.1 21.1 18 20.8 18 20V17H21C21.6 17 22 16.6 22 16V4C22 3.4 21.6 3 21 3H3C2.4 3 2 3.4 2 4Z" fill="black" />
											<path d="M18 9H6C5.4 9 5 8.6 5 8C5 7.4 5.4 7 6 7H18C18.6 7 19 7.4 19 8C19 8.6 18.6 9 18 9ZM16 12C16 11.4 15.6 11 15 11H6C5.4 11 5 11.4 5 12C5 12.6 5.4 13 6 13H15C15.6 13 16 12.6 16 12Z" fill="black" />
										</svg>
									</span>
									<!--end::Svg Icon-->
								</button>--%>
								<!--end::Message-->
								<!--begin::User-->
								<div class="ms-1 ms-lg-6">
									<!--begin::Toggle-->
									<div class="btn btn-icon btn-sm btn-active-bg-accent" data-kt-menu-trigger="click" data-kt-menu-placement="bottom-end" id="kt_header_user_menu_toggle">
										<!--begin::Svg Icon | path: icons/duotune/communication/com013.svg-->
										<span class="svg-icon svg-icon-1 svg-icon-dark">
											<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
												<path d="M6.28548 15.0861C7.34369 13.1814 9.35142 12 11.5304 12H12.4696C14.6486 12 16.6563 13.1814 17.7145 15.0861L19.3493 18.0287C20.0899 19.3618 19.1259 21 17.601 21H6.39903C4.87406 21 3.91012 19.3618 4.65071 18.0287L6.28548 15.0861Z" fill="black" />
												<rect opacity="0.3" x="8" y="3" width="8" height="8" rx="4" fill="black" />
											</svg>
										</span>
										<!--end::Svg Icon-->
									</div>
									<!--begin::Menu-->
									<div class="menu menu-sub menu-sub-dropdown menu-column menu-rounded menu-gray-600 menu-state-bg-light-primary fw-bold w-300px" data-kt-menu="true">
										<div class="menu-content fw-bold d-flex align-items-center bgi-no-repeat bgi-position-y-top rounded-top" style="background-image:url('assets/media//misc/dropdown-header-bg.jpg')">
											<div class="symbol symbol-45px mx-5 py-5">
												<span class="symbol-label bg-primary align-items-end">
													<img alt="Logo" src="theme/dist/assets/media/svg/avatars/001-boy.svg" class="mh-35px" />
												</span>
											</div>
											<div class="">
												<span class="text-black fw-bolder fs-4"><asp:Label ID="lbluserad" runat="server" Text="Label"></asp:Label></span>
												<span class="text-black fw-bold fs-7 d-block"><asp:Label ID="lbldesc_perfil" runat="server" Text="Label"></asp:Label></span>
											</div>
										</div>
										<!--begin::Row-->
										<div class="row row-cols-2 g-0">
											<a href="Registro_aviso.aspx" class="border-bottom border-end text-center py-10 btn btn-active-color-primary rounded-0">
												<!--begin::Svg Icon | path: icons/duotune/general/gen025.svg-->
												<span class="svg-icon svg-icon-3x me-n1">
													<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
														<rect x="2" y="2" width="9" height="9" rx="2" fill="black" />
														<rect opacity="0.3" x="13" y="2" width="9" height="9" rx="2" fill="black" />
														<rect opacity="0.3" x="13" y="13" width="9" height="9" rx="2" fill="black" />
														<rect opacity="0.3" x="2" y="13" width="9" height="9" rx="2" fill="black" />
													</svg>
												</span>
												<!--end::Svg Icon-->
												<span class="fw-bolder fs-6 d-block pt-3">Credenciales</span>
											</a>
											<%--<a href="main.aspx" class="col border-bottom text-center py-10 btn btn-active-color-primary rounded-0">
												<!--begin::Svg Icon | path: icons/duotune/general/gen019.svg-->
												<span class="svg-icon svg-icon-3x me-n1">
													<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
														<path d="M17.5 11H6.5C4 11 2 9 2 6.5C2 4 4 2 6.5 2H17.5C20 2 22 4 22 6.5C22 9 20 11 17.5 11ZM15 6.5C15 7.9 16.1 9 17.5 9C18.9 9 20 7.9 20 6.5C20 5.1 18.9 4 17.5 4C16.1 4 15 5.1 15 6.5Z" fill="black" />
														<path opacity="0.3" d="M17.5 22H6.5C4 22 2 20 2 17.5C2 15 4 13 6.5 13H17.5C20 13 22 15 22 17.5C22 20 20 22 17.5 22ZM4 17.5C4 18.9 5.1 20 6.5 20C7.9 20 9 18.9 9 17.5C9 16.1 7.9 15 6.5 15C5.1 15 4 16.1 4 17.5Z" fill="black" />
													</svg>
												</span>
												<!--end::Svg Icon-->
												<span class="fw-bolder fs-6 d-block pt-3">Herramientas</span>
											</a>--%>
										<%--	<a href="main.aspx" class="col text-center border-end py-10 btn btn-active-color-primary rounded-0">
												<!--begin::Svg Icon | path: icons/duotune/finance/fin009.svg-->
												<span class="svg-icon svg-icon-3x me-n1">
													<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
														<path opacity="0.3" d="M15.8 11.4H6C5.4 11.4 5 11 5 10.4C5 9.80002 5.4 9.40002 6 9.40002H15.8C16.4 9.40002 16.8 9.80002 16.8 10.4C16.8 11 16.3 11.4 15.8 11.4ZM15.7 13.7999C15.7 13.1999 15.3 12.7999 14.7 12.7999H6C5.4 12.7999 5 13.1999 5 13.7999C5 14.3999 5.4 14.7999 6 14.7999H14.8C15.3 14.7999 15.7 14.2999 15.7 13.7999Z" fill="black" />
														<path d="M18.8 15.5C18.9 15.7 19 15.9 19.1 16.1C19.2 16.7 18.7 17.2 18.4 17.6C17.9 18.1 17.3 18.4999 16.6 18.7999C15.9 19.0999 15 19.2999 14.1 19.2999C13.4 19.2999 12.7 19.2 12.1 19.1C11.5 19 11 18.7 10.5 18.5C10 18.2 9.60001 17.7999 9.20001 17.2999C8.80001 16.8999 8.49999 16.3999 8.29999 15.7999C8.09999 15.1999 7.80001 14.7 7.70001 14.1C7.60001 13.5 7.5 12.8 7.5 12.2C7.5 11.1 7.7 10.1 8 9.19995C8.3 8.29995 8.79999 7.60002 9.39999 6.90002C9.99999 6.30002 10.7 5.8 11.5 5.5C12.3 5.2 13.2 5 14.1 5C15.2 5 16.2 5.19995 17.1 5.69995C17.8 6.09995 18.7 6.6 18.8 7.5C18.8 7.9 18.6 8.29998 18.3 8.59998C18.2 8.69998 18.1 8.69993 18 8.79993C17.7 8.89993 17.4 8.79995 17.2 8.69995C16.7 8.49995 16.5 7.99995 16 7.69995C15.5 7.39995 14.9 7.19995 14.2 7.19995C13.1 7.19995 12.1 7.6 11.5 8.5C10.9 9.4 10.5 10.6 10.5 12.2C10.5 13.3 10.7 14.2 11 14.9C11.3 15.6 11.7 16.1 12.3 16.5C12.9 16.9 13.5 17 14.2 17C15 17 15.7 16.8 16.2 16.4C16.8 16 17.2 15.2 17.9 15.1C18 15 18.5 15.2 18.8 15.5Z" fill="black" />
													</svg>
												</span>
												<!--end::Svg Icon-->
												<span class="fw-bolder fs-6 d-block pt-3">Otros</span>
											</a>--%>
											<a href="javascript:CerrarSesion();" class="col text-center py-10 btn btn-active-color-primary rounded-0">
												<!--begin::Svg Icon | path: icons/duotune/arrows/arr077.svg-->
												<span class="svg-icon svg-icon-3x me-n1">
													<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
														<rect opacity="0.3" x="4" y="11" width="12" height="2" rx="1" fill="black" />
														<path d="M5.86875 11.6927L7.62435 10.2297C8.09457 9.83785 8.12683 9.12683 7.69401 8.69401C7.3043 8.3043 6.67836 8.28591 6.26643 8.65206L3.34084 11.2526C2.89332 11.6504 2.89332 12.3496 3.34084 12.7474L6.26643 15.3479C6.67836 15.7141 7.3043 15.6957 7.69401 15.306C8.12683 14.8732 8.09458 14.1621 7.62435 13.7703L5.86875 12.3073C5.67684 12.1474 5.67684 11.8526 5.86875 11.6927Z" fill="black" />
														<path d="M8 5V6C8 6.55228 8.44772 7 9 7C9.55228 7 10 6.55228 10 6C10 5.44772 10.4477 5 11 5H18C18.5523 5 19 5.44772 19 6V18C19 18.5523 18.5523 19 18 19H11C10.4477 19 10 18.5523 10 18C10 17.4477 9.55228 17 9 17C8.44772 17 8 17.4477 8 18V19C8 20.1046 8.89543 21 10 21H19C20.1046 21 21 20.1046 21 19V5C21 3.89543 20.1046 3 19 3H10C8.89543 3 8 3.89543 8 5Z" fill="#C4C4C4" />
													</svg>
												</span>
												<!--end::Svg Icon-->
												<span class="fw-bolder fs-6 d-block pt-3">Salir</span>
											</a>
										</div>
										<!--end::Row-->
									</div>
									<!--end::Menu-->
								</div>
								<!--end::User-->
								<!--begin::Notifications-->
								<div class="ms-1 ms-lg-6">
									<!--begin::Dropdown-->
									<%--<button class="btn btn-icon btn-sm btn-light-danger fw-bolder pulse pulse-danger" data-kt-menu-trigger="click" data-kt-menu-placement="bottom-end" id="kt_activities_toggle">
										<span class="position-absolute fs-6">3</span>
										<span class="pulse-ring"></span>
									</button>--%>
									<!--begin::Menu-->
									<div class="menu menu-sub menu-sub-dropdown menu-column menu-rounded fw-bold menu-title-gray-800 menu-hover-bg menu-state-title-primary w-250px w-md-300px" data-kt-menu="true">
										<div class="menu-item mx-3">
											<div class="menu-content fs-6 text-dark fw-bolder py-6">4 New Notifications</div>
										</div>
										<div class="separator mb-3"></div>
										<div class="menu-item mx-3">
											<a href="#" class="menu-link px-4 py-3">
												<div class="symbol symbol-35px">
													<span class="symbol-label bg-light-info">
														<!--begin::Svg Icon | path: icons/duotune/abstract/abs027.svg-->
														<span class="svg-icon svg-icon-3 svg-icon-info">
															<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																<path opacity="0.3" d="M21.25 18.525L13.05 21.825C12.35 22.125 11.65 22.125 10.95 21.825L2.75 18.525C1.75 18.125 1.75 16.725 2.75 16.325L4.04999 15.825L10.25 18.325C10.85 18.525 11.45 18.625 12.05 18.625C12.65 18.625 13.25 18.525 13.85 18.325L20.05 15.825L21.35 16.325C22.35 16.725 22.35 18.125 21.25 18.525ZM13.05 16.425L21.25 13.125C22.25 12.725 22.25 11.325 21.25 10.925L13.05 7.62502C12.35 7.32502 11.65 7.32502 10.95 7.62502L2.75 10.925C1.75 11.325 1.75 12.725 2.75 13.125L10.95 16.425C11.65 16.725 12.45 16.725 13.05 16.425Z" fill="black" />
																<path d="M11.05 11.025L2.84998 7.725C1.84998 7.325 1.84998 5.925 2.84998 5.525L11.05 2.225C11.75 1.925 12.45 1.925 13.15 2.225L21.35 5.525C22.35 5.925 22.35 7.325 21.35 7.725L13.05 11.025C12.45 11.325 11.65 11.325 11.05 11.025Z" fill="black" />
															</svg>
														</span>
														<!--end::Svg Icon-->
													</span>
												</div>
												<div class="ps-4">
													<span class="menu-title fw-bold mb-1">New Uer Library Added</span>
													<span class="text-muted fw-bold d-block fs-7">3 Hours ago</span>
												</div>
											</a>
										</div>
										<div class="menu-item mx-3">
											<a href="#" class="menu-link px-4 py-3">
												<div class="symbol symbol-35px">
													<span class="symbol-label bg-light-warning">
														<!--begin::Svg Icon | path: icons/duotune/communication/com004.svg-->
														<span class="svg-icon svg-icon-3 svg-icon-warning">
															<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																<path opacity="0.3" d="M14 3V20H2V3C2 2.4 2.4 2 3 2H13C13.6 2 14 2.4 14 3ZM11 13V11C11 9.7 10.2 8.59995 9 8.19995V7C9 6.4 8.6 6 8 6C7.4 6 7 6.4 7 7V8.19995C5.8 8.59995 5 9.7 5 11V13C5 13.6 4.6 14 4 14V15C4 15.6 4.4 16 5 16H11C11.6 16 12 15.6 12 15V14C11.4 14 11 13.6 11 13Z" fill="black" />
																<path d="M2 20H14V21C14 21.6 13.6 22 13 22H3C2.4 22 2 21.6 2 21V20ZM9 3V2H7V3C7 3.6 7.4 4 8 4C8.6 4 9 3.6 9 3ZM6.5 16C6.5 16.8 7.2 17.5 8 17.5C8.8 17.5 9.5 16.8 9.5 16H6.5ZM21.7 12C21.7 11.4 21.3 11 20.7 11H17.6C17 11 16.6 11.4 16.6 12C16.6 12.6 17 13 17.6 13H20.7C21.2 13 21.7 12.6 21.7 12ZM17 8C16.6 8 16.2 7.80002 16.1 7.40002C15.9 6.90002 16.1 6.29998 16.6 6.09998L19.1 5C19.6 4.8 20.2 5 20.4 5.5C20.6 6 20.4 6.60005 19.9 6.80005L17.4 7.90002C17.3 8.00002 17.1 8 17 8ZM19.5 19.1C19.4 19.1 19.2 19.1 19.1 19L16.6 17.9C16.1 17.7 15.9 17.1 16.1 16.6C16.3 16.1 16.9 15.9 17.4 16.1L19.9 17.2C20.4 17.4 20.6 18 20.4 18.5C20.2 18.9 19.9 19.1 19.5 19.1Z" fill="black" />
															</svg>
														</span>
														<!--end::Svg Icon-->
													</span>
												</div>
												<div class="ps-4">
													<span class="menu-title fw-bold mb-1">Clean Microphone</span>
													<span class="text-muted fw-bold d-block fs-7">5 Hours ago</span>
												</div>
											</a>
										</div>
										<div class="menu-item mx-3">
											<a href="#" class="menu-link px-4 py-3">
												<div class="symbol symbol-35px">
													<span class="symbol-label bg-light-primary">
														<!--begin::Svg Icon | path: icons/duotune/communication/com012.svg-->
														<span class="svg-icon svg-icon-3 svg-icon-primary">
															<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																<path opacity="0.3" d="M20 3H4C2.89543 3 2 3.89543 2 5V16C2 17.1046 2.89543 18 4 18H4.5C5.05228 18 5.5 18.4477 5.5 19V21.5052C5.5 22.1441 6.21212 22.5253 6.74376 22.1708L11.4885 19.0077C12.4741 18.3506 13.6321 18 14.8167 18H20C21.1046 18 22 17.1046 22 16V5C22 3.89543 21.1046 3 20 3Z" fill="black" />
																<rect x="6" y="12" width="7" height="2" rx="1" fill="black" />
																<rect x="6" y="7" width="12" height="2" rx="1" fill="black" />
															</svg>
														</span>
														<!--end::Svg Icon-->
													</span>
												</div>
												<div class="ps-4">
													<span class="menu-title fw-bold mb-1">Quick Chat Created</span>
													<span class="text-muted fw-bold d-block fs-7">A Day ago</span>
												</div>
											</a>
										</div>
										<div class="menu-item mx-3">
											<a href="#" class="menu-link px-4 py-3">
												<div class="symbol symbol-35px">
													<span class="symbol-label bg-light-danger">
														<!--begin::Svg Icon | path: icons/duotune/coding/cod008.svg-->
														<span class="svg-icon svg-icon-3 svg-icon-danger">
															<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																<path d="M11.2166 8.50002L10.5166 7.80007C10.1166 7.40007 10.1166 6.80005 10.5166 6.40005L13.4166 3.50002C15.5166 1.40002 18.9166 1.50005 20.8166 3.90005C22.5166 5.90005 22.2166 8.90007 20.3166 10.8001L17.5166 13.6C17.1166 14 16.5166 14 16.1166 13.6L15.4166 12.9C15.0166 12.5 15.0166 11.9 15.4166 11.5L18.3166 8.6C19.2166 7.7 19.1166 6.30002 18.0166 5.50002C17.2166 4.90002 16.0166 5.10007 15.3166 5.80007L12.4166 8.69997C12.2166 8.89997 11.6166 8.90002 11.2166 8.50002ZM11.2166 15.6L8.51659 18.3001C7.81659 19.0001 6.71658 19.2 5.81658 18.6C4.81658 17.9 4.71659 16.4 5.51659 15.5L8.31658 12.7C8.71658 12.3 8.71658 11.7001 8.31658 11.3001L7.6166 10.6C7.2166 10.2 6.6166 10.2 6.2166 10.6L3.6166 13.2C1.7166 15.1 1.4166 18.1 3.1166 20.1C5.0166 22.4 8.51659 22.5 10.5166 20.5L13.3166 17.7C13.7166 17.3 13.7166 16.7001 13.3166 16.3001L12.6166 15.6C12.3166 15.2 11.6166 15.2 11.2166 15.6Z" fill="black" />
																<path opacity="0.3" d="M5.0166 9L2.81659 8.40002C2.31659 8.30002 2.0166 7.79995 2.1166 7.19995L2.31659 5.90002C2.41659 5.20002 3.21659 4.89995 3.81659 5.19995L6.0166 6.40002C6.4166 6.60002 6.6166 7.09998 6.5166 7.59998L6.31659 8.30005C6.11659 8.80005 5.5166 9.1 5.0166 9ZM8.41659 5.69995H8.6166C9.1166 5.69995 9.5166 5.30005 9.5166 4.80005L9.6166 3.09998C9.6166 2.49998 9.2166 2 8.5166 2H7.81659C7.21659 2 6.71659 2.59995 6.91659 3.19995L7.31659 4.90002C7.41659 5.40002 7.91659 5.69995 8.41659 5.69995ZM14.6166 18.2L15.1166 21.3C15.2166 21.8 15.7166 22.2 16.2166 22L17.6166 21.6C18.1166 21.4 18.4166 20.8 18.1166 20.3L16.7166 17.5C16.5166 17.1 16.1166 16.9 15.7166 17L15.2166 17.1C14.8166 17.3 14.5166 17.7 14.6166 18.2ZM18.4166 16.3L19.8166 17.2C20.2166 17.5 20.8166 17.3 21.0166 16.8L21.3166 15.9C21.5166 15.4 21.1166 14.8 20.5166 14.8H18.8166C18.0166 14.8 17.7166 15.9 18.4166 16.3Z" fill="black" />
															</svg>
														</span>
														<!--end::Svg Icon-->
													</span>
												</div>
												<div class="ps-4">
													<span class="menu-title fw-bold mb-1">32 New Attachements</span>
													<span class="text-muted fw-bold d-block fs-7">2 Day ago</span>
												</div>
											</a>
										</div>
										<div class="separator mt-3"></div>
										<div class="menu-item mx-2">
											<div class="menu-content py-5">
												<a href="#" class="btn btn-primary fw-bolder me-2 px-5">Report</a>
												<a href="#" class="btn btn-light fw-bolder px-5">Reset</a>
											</div>
										</div>
									</div>
									<!--end::Menu-->
									<!--end::Dropdown-->
								</div>
								<!--end::Notifications-->
								<!--begin::Aside Toggler-->
								<button class="btn btn-icon btn-sm btn-active-bg-accent d-lg-none ms-1 ms-lg-6" id="kt_aside_toggler">
									<!--begin::Svg Icon | path: icons/duotune/abstract/abs015.svg-->
									<span class="svg-icon svg-icon-1 svg-icon-dark">
										<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
											<path d="M21 7H3C2.4 7 2 6.6 2 6V4C2 3.4 2.4 3 3 3H21C21.6 3 22 3.4 22 4V6C22 6.6 21.6 7 21 7Z" fill="black" />
											<path opacity="0.3" d="M21 14H3C2.4 14 2 13.6 2 13V11C2 10.4 2.4 10 3 10H21C21.6 10 22 10.4 22 11V13C22 13.6 21.6 14 21 14ZM22 20V18C22 17.4 21.6 17 21 17H3C2.4 17 2 17.4 2 18V20C2 20.6 2.4 21 3 21H21C21.6 21 22 20.6 22 20Z" fill="black" />
										</svg>
									</span>
									<!--end::Svg Icon-->
								</button>
								<!--end::Aside Toggler-->
								<!--begin::Sidebar Toggler-->
								<!--end::Sidebar Toggler-->
							</div>
							<!--end::Right-->
						</div>
						<!--end::Container-->
					</div>
					<!--end::Header-->
					<!--begin::Main-->
					<div class="d-flex flex-column flex-column-fluid">
						<!--begin::Content-->
						<div class="content fs-6 d-flex flex-column-fluid" id="kt_content">
							<!--begin::Container-->
							<div class="container-xxl">
								<form class="form d-flex justify-content-center" runat="server">
									<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
									<asp:Button ID="btnCerrarSesion" runat="server" Text="Button" style="display:none;" />
									<asp:Button ID="btnAdjuntarP" runat="server" Text="Vista" style="display:none;"/>
									<asp:Button ID="btnAdjuntarP_sustento" runat="server" Text="Vista" style="display:none;"/>
									<asp:Label ID="lblnombreusuario" runat="server" Text="Ivan Martinez" style="display:none;"></asp:Label>
									<asp:Label ID="lbldatosusuario" runat="server" Text="Label" style="display:none;"></asp:Label>
									<asp:Label ID="lbladusuario" runat="server" Text="Label" style="display:none;"></asp:Label>
									<asp:Label ID="lbldnihistoria" runat="server" Text="Label" style="display:none;"></asp:Label>
									<asp:Label ID="lbldiaretraso" runat="server" Text="0" style="display:none;"></asp:Label>
									<asp:Label ID="lblemail" runat="server" Text="imartinez" style="display:none;"></asp:Label>
									<asp:Button ID="btnCerrarPopupEquipos" runat="server" Text="Button" style="display:none;" />
									<asp:Button ID="btnCerrarPopupCotizaciones" runat="server" Text="Button" style="display:none;" />

									<div class="card container">
										
										
										<!--begin::Form DISEÑANDO CUERPO FORM-->
									
											<div class="card-body fs-6 py-15 px-4 px-lg-5 text-gray-700">
												<div class="container">
													<%--Inicio Cuerpo documento--%>
													 <div class="container my-3">

														<asp:Panel ID="pnlAviso" runat="server" CssClass="p-3 mb-4 rounded-2" Style="background-color:#540f4a; color:white;" Visible="True">
															<div class="d-flex flex-column">
																<h5 class="mb-1 fw-bold text-white">NUEVO AVISO</h5>
																<small style="color:#f0cfe1;">
																	Le solicitamos completar la información requerida a fin de registrar un nuevo aviso y proceder con su atención.
																</small>
															</div>
														</asp:Panel>



														 <asp:UpdatePanel ID="UpdatePanel6" runat="server">
															 <ContentTemplate>

																<asp:Panel ID="pnllineatiempo_datos" runat="server" Visible="False">

 																<!-- Contenedor de la línea de tiempo y datos -->

																<div class="p-3 bg-white shadow rounded-3" style="font-size: 0.85rem;">
												
																
																	<br />
																	<br />


																	 <div class="timeline-horizontal d-flex justify-content-start align-items-center flex-nowrap" 
     style="overflow-x: auto; overflow-y: hidden; white-space: nowrap; gap: 1rem; padding-bottom: 0.5rem;">
    
																		<div class="timeline-step text-center flex-fill">
																			<div id="step1" runat="server" class="timeline-marker bg-secondary"></div>
																			<div class="fw-semibold mt-2">Pendiente de Atención</div>
																		</div>

																		<div class="timeline-step text-center flex-fill">
																			<div id="step2" runat="server" class="timeline-marker bg-secondary"></div>
																			<div class="fw-semibold mt-2">Proveedor Asignado</div>
																		</div>

																		<div class="timeline-step text-center flex-fill">
																			<div id="step3" runat="server" class="timeline-marker bg-secondary"></div>
																			<div class="fw-semibold mt-2">Cotización Registrado</div>
																		</div>

																		<div class="timeline-step text-center flex-fill">
																			<div id="step4" runat="server" class="timeline-marker bg-secondary"></div>
																			<div class="fw-semibold mt-2">Cotización Aprobado</div>
																		</div>

																		<div class="timeline-step text-center flex-fill">
																			<div id="step5" runat="server" class="timeline-marker bg-secondary"></div>
																			<div class="fw-semibold mt-2">Cotización Rechazada</div>
																		</div>

																		<div class="timeline-step text-center flex-fill">
																			<div id="step6" runat="server" class="timeline-marker bg-secondary"></div>
																			<div class="fw-semibold mt-2">OC Confirmada</div>
																		</div>

																		<div class="timeline-step text-center flex-fill">
																			<div id="step7" runat="server" class="timeline-marker bg-secondary"></div>
																			<div class="fw-semibold mt-2">Sustento Ingresado</div>
																		</div>

																		<div class="timeline-step text-center flex-fill">
																			<div id="step8" runat="server" class="timeline-marker bg-secondary"></div>
																			<div class="fw-semibold mt-2">Aviso Cerrado</div>
																		</div>

																	</div>

								
								
																	<br />
																	<br />



								 
																	<%--Datos del aviso--%>
												
																	<div class="row gy-3 gx-4" style="font-size: 0.95rem;">

																	  <!-- Item -->
																	  <div class="col-md-6">
																		<div class="d-flex justify-content-between align-items-center p-3 border rounded-3 shadow-sm bg-white">
																		  <div class="fw-semibold text-dark">
																			<i class="bi bi-hash me-2 text-info"></i> Nro. Aviso
																		  </div>
																		  <div class="text-muted"> <asp:Label ID="lblnro_aviso" runat="server" Text="" class="form-label" ></asp:Label></div>
																			<asp:Label ID="lblid_aviso" runat="server" Text="" class="form-label" Style="display:none"></asp:Label>
																			<asp:Label ID="lblid_estado" runat="server" Text="" class="form-label" Style="display:none"></asp:Label>
																		</div>
																	  </div>

																	  <!-- Item -->
																	  <div class="col-md-6">
																		<div class="d-flex justify-content-between align-items-center p-3 border rounded-3 shadow-sm bg-white">
																		  <div class="fw-semibold text-dark">
																			<i class="bi bi-calendar-event me-2 text-info"></i> Fecha de registro
																		  </div>
																		  <div class="text-muted"><asp:Label ID="lblfec_reg_aviso" runat="server" Text="" class="form-label"></asp:Label></div>
																		</div>
																	  </div>

																	  <!-- Item -->
																	  <div class="col-md-6">
																		<div class="d-flex justify-content-between align-items-center p-3 border rounded-3 shadow-sm bg-white">
																		  <div class="fw-semibold text-dark">
																			<i class="bi bi-person-circle me-2 text-info"></i> Usuario de registro
																		  </div>
																		  <div class="text-muted"><asp:Label ID="lblusuario_registro" runat="server" Text="" class="form-label"></asp:Label></div>
																		</div>
																	  </div>

																	  <!-- Item -->
																	  <div class="col-md-6">
																		<div class="d-flex justify-content-between align-items-center p-3 border rounded-3 shadow-sm bg-white">
																		  <div class="fw-semibold text-dark">
																			<i class="bi bi-clock-history me-2 text-info"></i> Última modificación
																		  </div>
																		  <div class="text-muted"><asp:Label ID="lblfec_modif_aviso" runat="server" Text="" class="form-label"></asp:Label></div>
																		</div>
																	  </div>

																	</div>






													 
																	</div>

																		<br />
 
																		<br />

																	</asp:Panel>
															 </ContentTemplate>
														 </asp:UpdatePanel>

														 




														<%--Diseño del cuerpo del formulario--%>
													

														
														 <asp:HiddenField ID="hdnActiveTab" runat="server" />
														 <div class="row">
															<div class="col-lg-12">
															
															
															
																<ul class="nav nav-tabs custom-tabs" id="myTab" role="tablist">
																	<%--<asp:Panel ID="TabInformacionGeneral" runat="server" >--%>
																	<li class="nav-item" role="presentation">
																	<button class="nav-link active" id="tab1-tab" data-bs-toggle="tab" data-bs-target="#tab1"
																		type="button" role="tab" aria-controls="tab1" aria-selected="true">
																		<i class="bi bi-info-circle me-2"></i> Información General Aviso</button>
																	</li>
																	<%--</asp:Panel>--%>
																	<%--<asp:Panel ID="TabProveedorAsignado" runat="server">--%>
																	<li class="nav-item" role="presentation">
																	<button class="nav-link" id="tab2-tab" data-bs-toggle="tab" data-bs-target="#tab2"
																		type="button" role="tab" aria-controls="tab2" aria-selected="false">
																		<i class="bi bi-people-fill me-2"></i> Proveedor Asignado
																	</button>
																	</li>
																<%--	</asp:Panel>--%>
																	<%--<asp:Panel ID="TabCotizacionesProveedor" runat="server" >--%>
																		<li class="nav-item" role="presentation">
																		<button class="nav-link" id="tab3-tab" data-bs-toggle="tab" data-bs-target="#tab3"
																						type="button" role="tab" aria-controls="tab3" aria-selected="false">
																						<i class="bi bi-cash-coin me-2"></i> Cotizaciones del Proveedor
																		</button>
																		</li>
																	<%--</asp:Panel>--%>
																	
																</ul>




																<!-- Tabs Content -->
																<div class="tab-content border border-top-0 p-3 rounded-bottom shadow-sm bg-white" id="myTabContent">
																  <!-- TAB 1 -->
																	
																  <div class="tab-pane fade show active" id="tab1" role="tabpanel" aria-labelledby="tab1-tab">
																		
																	
															

																	  <%--Registro de Aviso Ini TAB 1--%>
																	  <div class="card-body p-3">
																		 <h6 class="mt-3 mb-1 d-flex align-items-center">
																		<i class="bi bi-person-vcard-fill me-2" style="color:  #6f42c1;"></i>
																		Datos principales del Aviso
																			</h6>
																			<br />

																			<asp:Panel ID="PnlControlesTAB1" runat="server">
																				<div class="row g-3">
																					<div class="col-md-6">
																						<div class="form-floating">
																							<asp:DropDownList ID="cbounidad_usuario_aviso" runat="server" CssClass="form-select form-select-sm fw-normal" BackColor="White"></asp:DropDownList>
																							<label for="cbounidad_usuario_aviso" class="form-label fw-semibold fs-6">Unidad</label>
																						</div>
																					</div>
																					<div class="col-md-6">
																						<div class="form-floating">
																							<asp:TextBox ID="txttitulo_aviso" runat="server" CssClass="form-control form-control-sm fw-normal" BackColor="White"></asp:TextBox>
																							<label for="txttitulo_aviso" class="form-label fw-semibold fs-6">Título del Aviso</label>
																						</div>
																					</div>
																				</div>

																				<div class="row g-3 mt-1">
																			
																						<div class="col-md-6">
																							<div class="form-floating">
																								<asp:DropDownList ID="cboarea_solic_aviso" runat="server" CssClass="form-select form-select-sm fw-normal" BackColor="White" ></asp:DropDownList>
																								<label for="cboarea_solic_aviso" class="form-label fw-semibold fs-6">Área Solicitante</label>
																							</div>
																						</div>

																			
																					<div class="col-md-6">
																						<div class="form-floating">
																							<asp:DropDownList ID="cbodiagnostico_ini_aviso" runat="server" CssClass="form-select form-select-sm fw-normal" BackColor="White"></asp:DropDownList>
																							<label for="cbodiagnostico_ini_aviso" class="form-label fw-semibold fs-6">Diagnóstico Inicial</label>
																						</div>
																					</div>



																				</div>

																				<div class="row g-3 mt-1">
																			


																					<div class="col-md-6">
																						<div class="form-floating">
																								<asp:DropDownList ID="cboclase_aviso" runat="server" CssClass="form-select form-select-sm" AutoPostBack="True" BackColor="White"></asp:DropDownList>
																								<label for="cboclase_aviso" class="form-label fw-semibold fs-6">Clase</label>
																						</div>
																					</div>

																					<div class="col-md-6">
																						<div class="form-floating">
																							<asp:DropDownList ID="cboimpacto_aviso" runat="server" CssClass="form-select form-select-sm fw-normal" AutoPostBack="True" BackColor="White"></asp:DropDownList>
																							<label for="cboimpacto_aviso" class="form-label fw-semibold fs-6">Impacto</label>
																						</div>
																					</div>
																			



																				</div>

																				<div class="row g-3 mt-1">

																					<div class="col-md-6">
																						<div class="form-floating">
																						<div class="form-floating">
																	
																							<asp:TextBox ID="txtprioridad_aviso" runat="server" CssClass="form-control form-control-sm fw-normal" BackColor="White" ReadOnly="True"></asp:TextBox>
																				
																							<label for="txtprioridad_aviso" class="form-label fw-semibold fs-6">Prioridad</label>
																						</div>
																						</div>
																					</div>

																		
																					<div class="col-md-6">
																						<div class="input-group">
																							<!-- Campo solo lectura con estilo form-control -->
																							<div class="form-floating flex-grow-1" style="min-width:0;">
																								<asp:Label ID="lblEquipo" runat="server" CssClass="form-control form-control-sm text-dark fw-normal" BackColor="White"></asp:Label>
																								
																								<label for="lblEquipo" class="form-label fw-semibold fs-6">Equipo o Sistema</label>
																							</div>

																							<!-- Botón de búsqueda -->
																							<asp:LinkButton ID="btnBuscarEquipo" runat="server" CssClass="btn btn-outline-secondary btn-sm">
																								<i class="bi bi-search"></i>
																							</asp:LinkButton>
																						</div>
																					</div>

										


																				</div>

																			  <div class="mt-2 form-floating">
																						<asp:TextBox ID="txtdescripcion_aviso" runat="server" 
																							TextMode="MultiLine" MaxLength="5000"
																							CssClass="form-control fw-normal"
																							style="height: 300px;" BackColor="White">
																						</asp:TextBox>
																						<label for="TextBox3" class="form-label fw-semibold fs-6">Ingrese una descripción del Aviso</label>
																					</div>
																				</asp:Panel>
																		  <br />
																		<!-- Archivos Adjuntos -->

																		  	 <h6 class="mt-3 mb-1 d-flex align-items-center">
																				<i class="bi bi-paperclip me-2" style="color:  #6f42c1;"></i>
																				Archivos adjuntos del aviso - Fotografía
																			</h6>
																			<br />

																			<div class="row g-3 mt-1">
																				<div class="col-md-12">
																			
																					<asp:Panel ID="pnladjuntar" runat="server">
																						<div class="container">
																										<!-- File Upload Section -->
																										<div class="row align-items-center">
																											<div class="col-lg-12">
																												<div class="form-group">
																													<%--<label for="inputGroupFile04" class="form-label text-danger">Adjuntar Archivos al Documento</label>--%>
																													<div class="input-group">
																														<!-- Custom file input for selecting the file -->
																														<asp:FileUpload ID="inputGroupFile04" runat="server" CssClass="form-control" style="max-width:100%;" Font-Size="Small" onchange="adjuntar();"/>
                        
																														<!-- Button to attach file -->
																														<asp:UpdatePanel ID="UpdatePanel1" runat="server">
																															<ContentTemplate>
																																<asp:LinkButton ID="btnAdjuntar2" runat="server" CssClass="btn btn-outline-secondary" href="javascript:adjuntar();" Visible="False">Adjuntar</asp:LinkButton>
																															</ContentTemplate>
																														</asp:UpdatePanel>
																													</div>
																												</div>
																											</div>
																										</div>
																										<br />
																										<!-- Attached Files Label Section -->
																									<%--	<div class="row">
																											<div class="col-lg-12">
																												<label class="form-label mt-3">Archivos físico:</label>
																											</div>
																										</div>--%>

																										<!-- Attached Files Grid Section -->
																										<div class="row">
																											<div class="col-lg-12">
																												<div class="table-responsive">
																														<asp:GridView ID="grvadjuntos" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover table-bordered">
																															<HeaderStyle CssClass="thead-dark" />
																															<Columns>
																							
																																<asp:TemplateField HeaderText="Acción">
																																	<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
																																	<ItemStyle CssClass="text-center align-middle" />
																																	<ItemTemplate>
																																		<asp:LinkButton ID="btneliminar" runat="server" CssClass="btn btn-danger btn-sm" 
																																			CommandName="EliminaAdjunto" CommandArgument='<%# Bind("nom_archivo_original") %>'>
																																			<i class="fas fa-trash-alt"></i>
																																		</asp:LinkButton>
																																		<asp:LinkButton ID="btnDownload" runat="server" CssClass="btn btn-light-primary btn-sm" 
																																			CommandName="DescargarAdjunto" CommandArgument='<%# Bind("id_aviso_adjunto") %>' Visible="False">
																																			<i class="fas fa-download"></i>
																																		</asp:LinkButton>

																																	</ItemTemplate>
																																</asp:TemplateField>

																							
																																<asp:TemplateField HeaderText="Archivos Adjuntados">
																																	<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
																																	<ItemStyle CssClass="align-middle" />
																																	<ItemTemplate>
																																		<asp:Label ID="lblarchivo_original" runat="server" Text='<%# Bind("nom_archivo_original") %>' 
																																			CssClass="text-dark fw-semibold form-control-sm"></asp:Label>
																																		<asp:Label ID="lblid_aviso_adjunto" runat="server" Text='<%# Bind("id_aviso_adjunto") %>' 
																																		CssClass="text-dark fw-semibold form-control-sm" Visible="False"></asp:Label>

																																	</ItemTemplate>
																																</asp:TemplateField>
																															</Columns>
																														</asp:GridView>
																												</div>
																											</div>
																										</div>
																									</div>
																							</asp:Panel>


																				</div>
																			</div>

																		  <br />

																		  <%--ADjunto Sustento del Proveedor--%>

																		  <h6 class="mt-3 mb-1 d-flex align-items-center">
																							<i class="bi bi-paperclip me-2" style="color:  #6f42c1;"></i>
																							Archivos adjuntos del Proveedor - Sustento del trabajo realizado
																			</h6>
																			<br />


																			<div class="row g-3 mt-1">
																				<div class="col-md-12">
																					<asp:Panel ID="pnladjuntar_p" runat="server">
																						<div class="container">
																							<!-- File Upload Section -->
																							<div class="row align-items-center">
																									<div class="col-lg-12">
																										<div class="form-group">
																											<%--<label for="inputGroupFile04" class="form-label text-danger">Adjuntar Archivos al Documento</label>--%>
																											<div class="input-group">
																												<!-- Custom file input for selecting the file -->
																												<asp:FileUpload ID="inputGroupFile04_sustento" runat="server" CssClass="form-control" style="max-width:100%;" Font-Size="Small" onchange="adjuntar_sustento();"/>
                        
																												<!-- Button to attach file -->
																												<asp:UpdatePanel ID="UpdatePanel15" runat="server">
																													<ContentTemplate>
																														<asp:LinkButton ID="btnAdjuntar2_sustento" runat="server" CssClass="btn btn-outline-secondary" href="javascript:adjuntar_sustento();" Visible="False">Adjuntar</asp:LinkButton>
																													</ContentTemplate>
																												</asp:UpdatePanel>
																											</div>
																										</div>
																									</div>
																							</div>
																						<br />



																							<div class="row">
																								<div class="col-lg-12">
																									<div class="table-responsive">
								
																									<asp:GridView ID="grvadjuntos_p" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover table-bordered">
																													<HeaderStyle CssClass="thead-dark" />
																													<Columns>
																							
																														<asp:TemplateField HeaderText="Acción">
																																		<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
																																		<ItemStyle CssClass="text-center align-middle" />
																																		<ItemTemplate>
																																				<asp:LinkButton ID="btneliminar_p" runat="server" CssClass="btn btn-danger btn-sm" 
																																					CommandName="EliminaAdjunto" CommandArgument='<%# Bind("nom_archivo_original") %>'>
																																					<i class="fas fa-trash-alt"></i>
																																				</asp:LinkButton>
																																				<asp:LinkButton ID="btnDownload_p" runat="server" CssClass="btn btn-light-primary btn-sm" 
																																					CommandName="DescargarAdjunto" CommandArgument='<%# Bind("id_aviso_adjunto") %>' Visible="False">
																																					<i class="fas fa-download"></i>
																																				</asp:LinkButton>

																																		</ItemTemplate>
																														</asp:TemplateField>

																																		<asp:TemplateField HeaderText="Archivos Adjuntados">
																																		<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
																																		<ItemStyle CssClass="align-middle" />
																																		<ItemTemplate>
																																				<asp:Label ID="lblarchivo_original_p" runat="server" Text='<%# Bind("nom_archivo_original") %>' 
																																					CssClass="text-dark fw-semibold form-control-sm"></asp:Label>
																																				<asp:Label ID="lblid_aviso_adjunto_p" runat="server" Text='<%# Bind("id_aviso_adjunto") %>' 
																																				CssClass="text-dark fw-semibold form-control-sm" Visible="False"></asp:Label>

																																		</ItemTemplate>
																																		</asp:TemplateField>
																													</Columns>
																									</asp:GridView>
																									</div>
																								</div>
																							</div>








																						</div>
																					</asp:Panel>
																				</div>
																			</div>





																		</div>








																	  <%--Registro de Aviso Fin TAB1--%>


																  </div>
																
																  <!-- TAB 2 -->
																  <div class="tab-pane fade" id="tab2" role="tabpanel" aria-labelledby="tab2-tab">
																	  <asp:Panel ID="PnlControlesTAB2" runat="server">
																		<div class="card-body p-3">
																			
																				   <h6 class="mt-3 mb-1 d-flex align-items-center">
																					<i class="bi bi-person-vcard-fill me-2" style="color:  #6f42c1;"></i>
																					Datos principales del Proveedor
																				   </h6>
																		<br />
																			<div class="row g-3 mt-1">
																				<div class="col-md-12">
																					<div class="input-group">
																							<!-- Campo solo lectura con estilo form-control -->
																							<div class="form-floating flex-grow-1" style="min-width:0;">
																								<asp:Label ID="lblrucproveedor_aviso" runat="server" CssClass="form-control fw-normal" BackColor="White"></asp:Label>
																								
																								<label for="lblrucproveedor_aviso" class="form-label fw-semibold fs-6">Seleccione Proveedor</label>
																							</div>

																							<!-- Botón de búsqueda -->
																							<asp:LinkButton ID="BtnBuscarProveedor" runat="server" CssClass="btn btn-outline-secondary btn-sm">
																											<i class="bi bi-search"></i>
																							</asp:LinkButton>
																					</div>
																				</div>

																				<%--<div class="col-md-6">
																					<div class="form-floating">
																							<asp:TextBox ID="TextBox9" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
																							<label for="TextBox1" class="form-label fw-semibold fs-6">Razón social</label>
																					</div>
																				</div>--%>
																		</div>
																			<div class="row g-3 mt-1">
																				<div class="col-md-12">
																					<div class="input-group">
																						<div class="form-floating flex-grow-1" style="min-width:0;">
																							<asp:Label ID="lblrucproveedorSAP_aviso" runat="server" CssClass="form-control fw-normal" BackColor="White"></asp:Label>
																							<label for="lblrucproveedorSAP_aviso" class="form-label fw-semibold fs-6">Cod. Proveedor SAP</label>
																						</div>
																					</div>
																				</div>
																			
																			</div>
																			
																			<div class="row g-3 mt-1">
																				<div class="col-md-6">
																					<div class="form-floating">
																						<asp:DropDownList ID="cboclaseotm_aviso" runat="server" CssClass="form-select form-select-sm fw-normal"  BackColor="White"></asp:DropDownList>
																						<label for="cboclaseotm_aviso" class="form-label fw-semibold fs-6">Clase de OTM</label>
																					</div>
																				</div>
																				<div class="col-md-6">
																					<div class="form-floating">
																						<asp:Label ID="lblgrupocompras_aviso" runat="server" CssClass="form-control form-control-sm fw-normal" Text="S18" BackColor="White"></asp:Label>

																						<label for="lblgrupocompras_aviso" class="form-label fw-semibold fs-6">Grupo de Compras</label>
																					</div>
																				</div>
																			</div>
																			<div class="row g-3 mt-1">
																				<div class="col-md-6">
																					<div class="form-floating">
																						<asp:TextBox ID="txtFechaInicioCotizacion" runat="server" CssClass="form-control form-control-sm fw-normal" TextMode="Date" BackColor="White"></asp:TextBox>
																						<label for="txtFechaInicio" class="form-label fw-semibold fs-6">Fecha Inicial de la Cotización (Registro de Cotización)</label>
																					</div>
																				</div>
																				<div class="col-md-6">
																					<div class="form-floating">
																						<asp:TextBox ID="txtFechaFinCotizacion" runat="server" CssClass="form-control form-control-sm fw-normal" TextMode="Date" BackColor="White"></asp:TextBox>
																						<label for="txtFechaInicio" class="form-label fw-semibold fs-6">Fecha Final de la Cotización (Registro de Cotización)</label>
																					</div>
																				</div>
																			</div>

																			<div class="row g-3 mt-1">
																				<div class="col-md-6">
																					<div class="form-floating">
																							
																										<asp:DropDownList ID="cbofamiliaservicio_aviso" runat="server" CssClass="form-select form-select-sm fw-normal" AutoPostBack="True" BackColor="White"></asp:DropDownList>
																										<label for="cbofamiliaservicio_aviso" class="form-label fw-semibold fs-6">Servicio (Familia)</label>

																									
																					</div>
																				</div>
																				<div class="col-md-6">
																					<div class="form-floating">
																								
																										<asp:DropDownList ID="cbosubfamiliaservicio_aviso" runat="server" CssClass="form-select form-select-sm fw-normal" BackColor="White"></asp:DropDownList>
																										<label for="cbosubfamiliaservicio_aviso" class="form-label fw-semibold fs-6">Servicio (SubFamilia)</label>
																					
																									
																					</div>
																				</div>
																			</div>
																			


																		 </div>
																	  </asp:Panel>



																  </div>

																  <!-- TAB 3 -->
																  <div class="tab-pane fade" id="tab3" role="tabpanel" aria-labelledby="tab3-tab">
																	
																<div class="card-body p-3">
																			
																	   <h6 class="mt-3 mb-1 d-flex align-items-center">
																				<i class="bi bi-cash-stack me-2" style="color:  #6f42c1;"></i>
																				Cotización del Proveedor y Documentos Generados
																		 </h6>

																	  
																	  <asp:Panel ID="PnlControlesTAB3" runat="server">
																	<!-- Contenedor superior para el botón -->
																		<div class="d-flex justify-content-end mb-3">
																			<asp:LinkButton ID="btnAgregarCotizacion" runat="server" 
																				CssClass="btn btn-outline-dark d-flex align-items-center px-3 py-2 rounded-pill shadow-sm">
																				<i class="fas fa-file me-2"></i>
																				<span>Agregar Nueva Cotización</span>
																			</asp:LinkButton>
																		</div>

																		  

																	  <br />
																	  <div class="row">
																		<div class="col-lg-12">
																			<div class="table-responsive">
																			<asp:GridView ID="grvCotizacionesAviso" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover table-bordered">
																					<HeaderStyle CssClass="thead-dark" />
																					<Columns>
																						
																						

																						<asp:TemplateField HeaderText="Acción">
																										<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
																										<ItemStyle CssClass="text-center align-middle" />
																										<ItemTemplate>
																														<asp:LinkButton ID="btneliminar" runat="server" CssClass="btn btn-danger btn-sm" 
																															CommandName="EliminaCotizacion" CommandArgument='<%# Bind("id_aviso_cotizacion") %>'>
																															<i class="fas fa-trash-alt"></i>
																														</asp:LinkButton>
																														<asp:LinkButton ID="btnEditar" runat="server" CssClass="btn btn-light-primary btn-sm" 
																															CommandName="EditarCotizacion" CommandArgument='<%# Bind("id_aviso_cotizacion") %>'>
																															<i class="fas fa-edit"></i>
																														</asp:LinkButton>
																														<asp:LinkButton ID="btnVisualizar" runat="server" CssClass="btn btn-dark btn-sm" 
																															CommandName="VisualizarCotizacion" CommandArgument='<%# Bind("id_aviso_cotizacion") %>' Visible="False">
																															<i class="fas fa-search"></i>
																														</asp:LinkButton>

																										</ItemTemplate>
																						</asp:TemplateField>

																						<asp:TemplateField HeaderText="Nro. Cotización">
																								<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
																								<ItemStyle CssClass="align-middle" />
																								<ItemTemplate>
																										<asp:Label ID="lblnro_cotizacion" runat="server" Text='<%# Bind("nro_cotizacion") %>' 
																											CssClass="text-dark fw-semibold form-control-sm"></asp:Label>
																								</ItemTemplate>
																						</asp:TemplateField>

																						<asp:TemplateField HeaderText="Descripción Cotización">
																								<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
																								<ItemStyle CssClass="align-middle" />
																								<ItemTemplate>
																												<asp:Label ID="lbldesc_cotizacion" runat="server" Text='<%# Bind("desc_cotizacion") %>' 
																													CssClass="text-dark fw-semibold form-control-sm"></asp:Label>
																									
																								</ItemTemplate>
																						</asp:TemplateField>
																						<asp:TemplateField HeaderText="Fecha Registro">
																								<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
																								<ItemStyle CssClass="align-middle" />
																								<ItemTemplate>
																												<asp:Label ID="lblfec_reg_cotizacion" runat="server" Text='<%# Bind("fec_reg_cotizacion") %>' 
																																CssClass="text-dark fw-semibold form-control-sm"></asp:Label>
																											
																								</ItemTemplate>
																						</asp:TemplateField>
																						<asp:TemplateField HeaderText="Moneda">
																								<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
																								<ItemStyle CssClass="align-middle" />
																								<ItemTemplate>
																												<asp:Label ID="lblmoneda_cotizacion" runat="server" Text='<%# Bind("desc_moneda") %>' 
																																			CssClass="text-dark fw-semibold form-control-sm"></asp:Label>
																								</ItemTemplate>
																						</asp:TemplateField>

																						<asp:TemplateField HeaderText="Total general">
																								<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
																								<ItemStyle CssClass="align-middle" />
																								<ItemTemplate>
																												<asp:Label ID="lblmonto_total_cotizacion" runat="server" Text='<%# Bind("monto_total_cotizacion") %>' 
																																CssClass="text-dark fw-semibold form-control-sm"></asp:Label>
																								</ItemTemplate>
																						</asp:TemplateField>


																						<asp:TemplateField HeaderText="Aprobado">
																								<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
																								<ItemStyle CssClass="text-center align-middle" />
																								<ItemTemplate>
																									<asp:CheckBox ID="chkSeleccion" runat="server" AutoPostBack="True" OnCheckedChanged="chkSeleccion_CheckedChanged"/>
																								</ItemTemplate>
																						</asp:TemplateField>

																					</Columns>
																			</asp:GridView>
																			</div>
																		</div>
																	  </div>

																	</asp:Panel>

																	  <br />

																	   <div class="mt-2 form-floating">
																			<asp:TextBox ID="txtsustento_rechazo_cotizacion" runat="server" 
																															TextMode="MultiLine" MaxLength="5000"
																															CssClass="form-control fw-normal"
																															style="height: 100px;" BackColor="White" ReadOnly="True">
																			</asp:TextBox>
																			<label for="txtsustento_rechazo_cotizacion" class="form-label fw-semibold fs-6">Motivo de rechazo de la cotización:</label>
																		</div>
																	  <br />

																	  <div class="mt-2 form-floating">
																			<asp:TextBox ID="txtOTM" runat="server" 
																						TextMode="MultiLine" MaxLength="5000"
																						CssClass="form-control fw-normal"
																						style="height: 50px;" BackColor="White" ReadOnly="True">
																			</asp:TextBox>
																			<label for="txtOTM" class="form-label fw-semibold fs-6">OTM Autogenerada</label>
																		</div>

																	  <br />
																	    <div class="mt-2 form-floating">
																			<asp:TextBox ID="txtOC" runat="server" 
																							TextMode="MultiLine" MaxLength="5000"
																							CssClass="form-control fw-normal"
																							style="height: 50px;" BackColor="White" ReadOnly="True">
																			</asp:TextBox>
																			<label for="txtOC" class="form-label fw-semibold fs-6">Ordenes de Compras generadas</label>
																		</div>
																	  <br />
																		  <div class="mt-2 form-floating">
																					<asp:TextBox ID="txtsustento_ingresado_proveedor" runat="server" 
																								TextMode="MultiLine" MaxLength="5000"
																								CssClass="form-control fw-normal"
																								style="height: 50px;" BackColor="White" ReadOnly="True">
																					</asp:TextBox>
																					<label for="txtsustento_ingresado_proveedor" class="form-label fw-semibold fs-6">Sustento Ingresado por el Proveedor</label>
																		</div>

																	<br />
																		  <div class="mt-2 form-floating">
																					<asp:TextBox ID="txtdocumento_hes" runat="server" 
																														TextMode="MultiLine" MaxLength="5000"
																														CssClass="form-control fw-normal"
																														style="height: 50px;" BackColor="White" ReadOnly="True">
																					</asp:TextBox>
																					<label for="txtdocumento_hes" class="form-label fw-semibold fs-6">HES - Fecha Contable</label>
																		</div>


																	</div>

																  </div>
																</div>




																<%--Tabs final--%>

																
															</div>
														</div>


														  <!-- 🔹 Botones flotantes -->
														<%--<div style="position: fixed; bottom: 20px; right: 20px; z-index: 1050;" 
															 class="d-flex gap-2 shadow p-2 bg-white rounded-3">
															
															<asp:LinkButton ID="btnregresar" runat="server" CssClass="icon-button">
																<i class="fas fa-home"></i>
																<span class="icon-text">Regresar Inicio</span>
															</asp:LinkButton>

															<asp:LinkButton ID="btnregistrar" runat="server" CssClass="icon-button">
																<i class="fas fa-check-circle"></i>
																<span class="icon-text">Registrar</span>
															</asp:LinkButton>

															

															<asp:LinkButton ID="LinkButton1" runat="server" CssClass="icon-button">
																<i class="fas fa-file-archive"></i>
																<span class="icon-text">Nueva Cotización</span>
															</asp:LinkButton>

															<asp:LinkButton ID="LinkButton3" runat="server" CssClass="icon-button">
																<i class="fas fa-exclamation-circle"></i>
																<span class="icon-text">Rechazar</span>
															</asp:LinkButton>


															<asp:LinkButton ID="btnrechazar" runat="server" CssClass="icon-button">
																<i class="fas fa-trash-restore"></i>
																<span class="icon-text">Limpiar</span>
															</asp:LinkButton>

														</div>--%>
														
														
														<!-- Botón flotante con timeline -->
													<%--<div style="position: fixed; bottom: 20px; right: 20px; z-index: 1050;" 
														 class="d-flex align-items-center gap-3 shadow p-3 bg-white rounded-3">

														<!-- Botones -->
														<asp:LinkButton ID="btnregresar" runat="server" CssClass="icon-button">
															<i class="fas fa-home"></i>
															<span class="icon-text">Registrar</span>
														</asp:LinkButton>

														<asp:LinkButton ID="btnregistrar" runat="server" CssClass="icon-button">
															<i class="fas fa-check-circle"></i>
															<span class="icon-text">Aprobar</span>
														</asp:LinkButton>
														<asp:LinkButton ID="LinkButton1" runat="server" CssClass="icon-button">
																		<i class="fas fa-check-circle"></i>
																		<span class="icon-text">Rechazar</span>
														</asp:LinkButton>
														

													</div>--%>


														<div style="position: fixed; bottom: 15px; right: 15px; z-index: 1050;" 
															 class="d-flex align-items-center gap-3 shadow p-3 bg-white rounded-pill">

															<!-- Botón Registrar -->
															<asp:Panel ID="PnlBotonRegistroInicial" runat="server" Visible="True">
																<asp:LinkButton ID="btnregistrar" runat="server" 
																	CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark">
																	<i class="fas fa-save me-2"></i>
																	<span>Registrar Nuevo Aviso</span>
																</asp:LinkButton>
															</asp:Panel>
															

															<!-- Botón Aprobar -->
															<asp:Panel ID="Pnlbotonaprobar" runat="server" Visible="False">
																<asp:LinkButton ID="btnaprobar" runat="server" 
																	CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark">
																	<i class="fas fa-check-circle me-2 text-success"></i>
																	<span id="lblTextoBoton" runat="server">Aprobar Aviso</span>
																</asp:LinkButton>
															</asp:Panel>
															

															<!-- Botón Rechazar -->
															<asp:Panel ID="pnlbotonrechazar" runat="server" Visible="False">
																<asp:LinkButton ID="btnrechazar" runat="server" 
																	CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark">
																	<i class="fas fa-times-circle me-2 text-danger"></i>
																	<span>Rechazar Aviso</span>
																</asp:LinkButton>
															</asp:Panel>
															
															<!-- Botón Cerrar Aviso -->
															<asp:Panel ID="pnlbotonCerraraviso" runat="server" Visible="False">
																			<asp:LinkButton ID="btnCerrarAviso" runat="server" 
																							CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark">
																							<i class="fas fa-fire me-2 text-dark"></i>
																							<span>Cerrar Aviso</span>
																			</asp:LinkButton>
															</asp:Panel>

														

														</div>
														
													</div>
													<%--Fin cuerpo documento--%>
												</div>
											</div>
									
	
										<%--Modal Error--%>
										



										<%--Modal Busqueda Equipo--%>


									<div class="modal fade" tabindex="-1" id="myModal_busqueda_equipos" role="dialog" data-backdrop="static" data-keyboard="false">    
										<div class="modal-dialog modal-lg">
										<div class="modal-content">

											<!-- Header moderno -->
											<div class="modal-header justify-content-center border-0" 
												style="background: linear-gradient(135deg, #540f4a, #ba0c5c); border-radius: 12px 12px 0 0;">
											<h5 class="modal-title text-white fw-bold text-center">
												<i class="bi bi-search me-2"></i> Búsqueda de Equipos
											</h5>
										<%--	<button type="button" class="btn-close btn-close-white position-absolute end-0 me-3" data-bs-dismiss="modal"></button>--%>
											</div>

											<!-- Body con filtros -->
											<div class="modal-body px-4">
											<%-- Filtro de Busqueda --%>
											<asp:UpdatePanel ID="UpdatePanel54" runat="server" UpdateMode="Always">
												<ContentTemplate>
												<asp:Panel ID="Panel3" runat="server">
													<div class="row g-3 mt-1">
														<div class="col-md-12">
															<div class="form-floating">
															<asp:TextBox ID="txtcodequipoQR_FB" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
															<label for="txtcodequipoQR_FB" class="form-label fw-semibold fs-6">Código QR de Equipo</label>
															</div>
														</div>
													</div>
													<div class="row g-3 mt-1">
													<div class="col-md-6">
														<div class="form-floating">
														<asp:TextBox ID="txtcodequipo_FB" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
														<label for="lblcodequipo_FB" class="form-label fw-semibold fs-6">Código de Equipo</label>
														</div>
													</div>
													<div class="col-md-6">
														<div class="form-floating">
														<asp:TextBox ID="txtserie_FB" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
														<label for="lblserie_FB" class="form-label fw-semibold fs-6">Nro. Serie</label>
														</div>
													</div>
													</div>
													<div class="row g-3 mt-1">
													<div class="col-md-6">
														<div class="form-floating">
														<asp:TextBox ID="txtmarca_FB" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
														<label for="lblmarca_FB" class="form-label fw-semibold fs-6">Marca del equipo</label>
														</div>
													</div>
													<div class="col-md-6">
														<div class="form-floating">
														<asp:TextBox ID="txtdescequipo_FB" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
														<label for="lbldescequipo_FB" class="form-label fw-semibold fs-6">Descripción del equipo</label>
														</div>
													</div>
													</div>
												</asp:Panel>	
												</ContentTemplate>
											</asp:UpdatePanel>
											</div>

											<!-- Footer con botones -->
											<div class="modal-footer d-flex justify-content-end align-items-center gap-2 border-0 pt-3 pb-4">
												<br />
											<!-- Botón Buscar -->
											<asp:LinkButton ID="btnBuscarEquipos" runat="server" 
												CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark shadow-sm">
												<i class="fas fa-search me-2 text-success"></i>
												<span>Buscar Equipos</span>
											</asp:LinkButton>

											<!-- Botón Cancelar búsqueda -->
											<asp:LinkButton ID="LinkButton6" runat="server" 
												CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark shadow-sm">
												<i class="fas fa-times-circle me-2 text-danger"></i>
												<span>Cancelar</span>
											</asp:LinkButton>
											</div>

											<!-- Footer con listado -->
											<div class="modal-footer border-0">
											<%-- Listado de busqueda de equipos --%>
											<div class="row g-3 w-100" style="overflow: auto">
												<asp:UpdatePanel ID="UpdatePanel2" runat="server">
												<ContentTemplate>
													<asp:GridView ID="grvlistadoEquipos" runat="server" AutoGenerateColumns="False" 
													CssClass="table table-hover table-sm table-bordered align-middle text-nowrap shadow-sm rounded">
													<HeaderStyle CssClass="bg-light fw-bolder text-dark text-center" />
													<RowStyle CssClass="text-dark fw-semibold" />
													<Columns>
														<asp:TemplateField HeaderText="Acción">
														<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2 px-3" Width="80px" />
														<ItemStyle CssClass="text-center px-3" Width="80px" />
														<ItemTemplate>
															<asp:LinkButton ID="btnSeleccionar" runat="server" CommandName="seleccionar"
															CommandArgument='<%# Bind("codigo_equipo") %>'
															CssClass="btn btn-outline-custom btn-circle"
															ToolTip="Seleccionar">
															<i class="bi bi-check-circle"></i>
															</asp:LinkButton>
														</ItemTemplate>
														</asp:TemplateField>

														<asp:TemplateField HeaderText="Código SAP">
														<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
														<ItemStyle CssClass="text-center" />
														<ItemTemplate>
															<asp:Label ID="lblcodigo_equipo_FB" runat="server" 
															Text='<%# Bind("codigo_equipo") %>' 
															CssClass="text-dark fw-semibold form-control-sm" />
														</ItemTemplate>
														</asp:TemplateField>

														<asp:TemplateField HeaderText="Cod. Equipo QR">
														<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
														<ItemStyle CssClass="text-center" />
														<ItemTemplate>
																		<asp:Label ID="lblcodigo_equipo_QR_FB" runat="server" 
																		Text='<%# Bind("codigo_equipo_qr") %>' 
																		CssClass="text-dark fw-semibold form-control-sm" />
														</ItemTemplate>
														</asp:TemplateField>


														<asp:TemplateField HeaderText="Descripción">
														<HeaderStyle CssClass="fw-bold fs-6 text-start border-bottom border-2 px-3" />
														<ItemStyle CssClass="text-start px-3" />
														<ItemTemplate>
															<asp:Label ID="lbldes_equipo_FB" runat="server" Text='<%# Bind("desc_equipo") %>' 
															CssClass="text-dark fw-semibold form-control-sm" />
														</ItemTemplate>
														</asp:TemplateField>

														<asp:TemplateField HeaderText="Serie">
														<HeaderStyle CssClass="fw-bold fs-6 text-start border-bottom border-2" />
														<ItemStyle CssClass="text-start" />
														<ItemTemplate>
															<asp:Label ID="lblserie_FB" runat="server" Text='<%# Bind("serie") %>' 
															CssClass="text-dark fw-semibold form-control-sm" />
														</ItemTemplate>
														</asp:TemplateField>

														<asp:TemplateField HeaderText="Marca">
														<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
														<ItemStyle CssClass="text-center" />
														<ItemTemplate>
															<asp:Label ID="lblmarca_FB" runat="server" Text='<%# Bind("marca") %>' 
															CssClass="text-dark fw-semibold form-control-sm" />
														</ItemTemplate>
														</asp:TemplateField>
													</Columns>
													</asp:GridView>
												</ContentTemplate>
												</asp:UpdatePanel>
											</div>
											</div>

										</div>
										</div>
									</div>



								<%--Modal Busqueda Proveedor--%>


								<div class="modal fade" tabindex="-1" id="myModal_busqueda_proveedor" role="dialog" data-backdrop="static" data-keyboard="false">    
									<div class="modal-dialog modal-lg">
									<div class="modal-content">

										<!-- Header moderno -->
										<div class="modal-header justify-content-center border-0" 
											style="background: linear-gradient(135deg, #540f4a, #ba0c5c); border-radius: 12px 12px 0 0;">
										<h5 class="modal-title text-white fw-bold text-center">
											<i class="bi bi-search me-2"></i> Búsqueda de Proveedores
										</h5>
									<%--	<button type="button" class="btn-close btn-close-white position-absolute end-0 me-3" data-bs-dismiss="modal"></button>--%>
										</div>

										<!-- Body con filtros -->
										<div class="modal-body px-4">
										<%-- Filtro de Busqueda --%>
										<asp:UpdatePanel ID="UpdatePanel7" runat="server" UpdateMode="Always">
											<ContentTemplate>
											<asp:Panel ID="Panel1" runat="server">
												<div class="row g-3 mt-1">
												<div class="col-md-6">
													<div class="form-floating">
													<asp:TextBox ID="txtrucproveedor_popup" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
													<label for="lblcodequipo_FB" class="form-label fw-semibold fs-6">RUC de proveedor</label>
													</div>
												</div>
												<div class="col-md-6">
													<div class="form-floating">
													<asp:TextBox ID="txtrazonsocial_popup" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
													<label for="lblserie_FB" class="form-label fw-semibold fs-6">Razón Social</label>
													</div>
												</div>
												</div>
												<div class="row g-3 mt-1">
												<div class="col-md-12">
													<div class="form-floating">
													<asp:TextBox ID="txtsapproveedor_popup" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
													<label for="lblmarca_FB" class="form-label fw-semibold fs-6">Código SAP (LIFNR)</label>
													</div>
												</div>
												<%--<div class="col-md-6">
													<div class="form-floating">
													<asp:TextBox ID="TextBox4" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
													<label for="lbldescequipo_FB" class="form-label fw-semibold fs-6">Descripción del equipo</label>
													</div>
												</div>--%>
												</div>
											</asp:Panel>	
											</ContentTemplate>
										</asp:UpdatePanel>
										</div>

										<!-- Footer con botones -->
										<div class="modal-footer d-flex justify-content-end align-items-center gap-2 border-0 pt-3 pb-4">
											<br />
										<!-- Botón Buscar -->
										<asp:LinkButton ID="BtnBuscarProveedor_Popup" runat="server" 
											CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark shadow-sm">
											<i class="fas fa-search me-2 text-success"></i>
											<span>Buscar Proveedores</span>
										</asp:LinkButton>

										<!-- Botón Cancelar búsqueda -->
										<asp:LinkButton ID="BtnCerrarPopup_Proveedores" runat="server" 
											CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark shadow-sm">
											<i class="fas fa-times-circle me-2 text-danger"></i>
											<span>Cancelar</span>
										</asp:LinkButton>
										</div>

										<!-- Footer con listado -->
										<div class="modal-footer border-0">
										<%-- Listado de busqueda de equipos --%>
										<div class="row g-3 w-100" style="overflow: auto">
											<asp:UpdatePanel ID="UpdatePanel8" runat="server">
											<ContentTemplate>
												<asp:GridView ID="grvproveedor_popup" runat="server" AutoGenerateColumns="False" 
												CssClass="table table-hover table-sm table-bordered align-middle text-nowrap shadow-sm rounded">
												<HeaderStyle CssClass="bg-light fw-bolder text-dark text-center" />
												<RowStyle CssClass="text-dark fw-semibold" />
												<Columns>
													<asp:TemplateField HeaderText="Acción">
													<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2 px-3" Width="80px" />
													<ItemStyle CssClass="text-center px-3" Width="80px" />
													<ItemTemplate>
														<asp:LinkButton ID="btnSeleccionarProveedor" runat="server" CommandName="seleccionar"
														CommandArgument='<%# Bind("RUCPROVEEDOR") %>'
														CssClass="btn btn-outline-custom btn-circle"
														ToolTip="Seleccionar">
														<i class="bi bi-check-circle"></i>
														</asp:LinkButton>
													</ItemTemplate>
													</asp:TemplateField>

													<asp:TemplateField HeaderText="Cod. Proveedor">
													<HeaderStyle CssClass="fw-bold fs-6 text-center border-bottom border-2" />
													<ItemStyle CssClass="text-center" />
													<ItemTemplate>
														<asp:Label ID="lblrucproveedor_popup" runat="server" 
														Text='<%# Bind("RUCPROVEEDOR") %>' 
														CssClass="text-dark fw-semibold form-control-sm" />
													</ItemTemplate>
													</asp:TemplateField>

													<asp:TemplateField HeaderText="Descripción">
													<HeaderStyle CssClass="fw-bold fs-6 text-start border-bottom border-2 px-3" />
													<ItemStyle CssClass="text-start px-3" />
													<ItemTemplate>
														<asp:Label ID="lblrazonsocial_popup" runat="server" Text='<%# Bind("RAZON_SOCIAL") %>' 
														CssClass="text-dark fw-semibold form-control-sm" />
													</ItemTemplate>
													</asp:TemplateField>

													<asp:TemplateField HeaderText="COD.SAP - Proveedor">
													<HeaderStyle CssClass="fw-bold fs-6 text-start border-bottom border-2" />
													<ItemStyle CssClass="text-start" />
													<ItemTemplate>
														<asp:Label ID="lblcodsap_proveedor" runat="server" Text='<%# Bind("SAPPROVEEDOR") %>' 
														CssClass="text-dark fw-semibold form-control-sm" />
													</ItemTemplate>
													</asp:TemplateField>

													
												</Columns>
												</asp:GridView>
											</ContentTemplate>
											</asp:UpdatePanel>
										</div>
										</div>

									</div>
									</div>
								</div>




										<%--Modal Popup Cotizcaiones--%>
										<div class="modal bg-white fade" tabindex="-1" id="kt_modal_2">
											<div class="modal-dialog modal-fullscreen">
												<div class="modal-content shadow-lg rounded-3">
            
												<!-- Header -->
												<div class="modal-header border-0 d-flex align-items-center py-2">
													<h5 class="modal-title fw-bold fs-4 mb-0 text-white">
														<asp:Label ID="lblnro_cotizacion" runat="server" Text="Nueva Cotización"></asp:Label>
														<asp:Label ID="lblid_aviso_cotizacion" runat="server" Text="" Style="display:none"></asp:Label>
													</h5>
												</div>



													<!-- Body -->
													<div class="modal-body">
														<!-- Encabezado Cotización -->
														<div class="container-fluid mb-4">
															<asp:Panel ID="pnlCabeceraCotizacion" runat="server">
															<div class="row g-3">
																<div class="col-md-6">
																	<div class="p-3 bg-light rounded shadow-sm h-100">
																		<p class="mb-1 text-muted small">Proveedor</p>
																		<h6 class="mb-0 fw-semibold"><asp:Label ID="lblrazosocial_proveedor_cotizacion" runat="server" Text=""></asp:Label></h6>
																	</div>
																</div>
															<div class="col-md-2">
																<div class="p-3 bg-light rounded shadow-sm h-100">
																	<p class="mb-1 text-muted small">Fecha inicio del servicio</p>
																	<div class="mb-0 fw-semibold">
																		<asp:TextBox ID="txtfecini_serv_cotizacion" runat="server"
																			CssClass="form-control w-100 input-uniforme"
																			TextMode="Date" BackColor="White"></asp:TextBox>
																	</div>
																</div>
															</div>

															<div class="col-md-2">
																<div class="p-3 bg-light rounded shadow-sm h-100">
																	<p class="mb-1 text-muted small">Fecha fin del servicio</p>
																	<div class="mb-0 fw-semibold">
																		<asp:TextBox ID="txtfecfin_serv_cotizacion" runat="server"
																			CssClass="form-control w-100 input-uniforme"
																			TextMode="Date" BackColor="White"></asp:TextBox>
																	</div>
																</div>
															</div>

															<div class="col-md-2">
																<div class="p-3 bg-light rounded shadow-sm h-100">
																	<p class="mb-1 text-muted small">Moneda</p>
																	<div class="mb-0 fw-semibold">
																		<asp:DropDownList ID="cbomonedacotiz" runat="server"
																			CssClass="form-select w-100 input-uniforme" BackColor="White">
																			<asp:ListItem Text="Soles" Value="1" Selected="True"></asp:ListItem>
																			<asp:ListItem Text="Dólares" Value="2"></asp:ListItem>
																		</asp:DropDownList>
																	</div>
																</div>
															</div>

															</div>
															<br />
															<div class="row g-3">
																 <div class="form-floating">
																				<asp:TextBox ID="txtdesc_cotizacion" runat="server" CssClass="form-control form-control-sm fw-normal" BackColor="White"></asp:TextBox>
																				<label for="txtdesc_cotizacion" class="form-label fw-semibold fs-6">Descripción de la Cotización</label>
																</div>

															</div>
															</asp:Panel>
														</div>
														<div class="container-fluid mb-4">
															<br />										
															<h5 class="modal-title fw-bold fs-4 mb-0 text-black">
																Ítems de la Cotización <span class="fw-normal text-muted fs-6">(Debe agregarse al menos un servicio)</span>
															</h5>

															<br />
															<asp:UpdatePanel ID="UpdatePanel11" runat="server">
																<ContentTemplate>
																	<asp:Panel ID="pnlGrillaCotizacion" runat="server" >

																		<!-- Lista de Ítems -->
																		<asp:UpdatePanel ID="UpdatePanel9" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
																				<ContentTemplate>

																					<asp:Button ID="btnAgregarFila" runat="server" 
																					Text="Agregar fila" CssClass="btn btn-sm btn-dark mb-2"/>

																					<asp:GridView ID="grvItemsCotizacion" runat="server" AutoGenerateColumns="False" 
																					CssClass="table table-hover table-sm table-bordered align-middle text-nowrap"
																					GridLines="None" ShowHeader="True" ShowFooter="True" OnRowCommand="grvItemsCotizacion_RowCommand">
    
																					<HeaderStyle CssClass="table-light fw-bold text-center border-bottom border-2" />
																					<RowStyle CssClass="text-dark fw-semibold" />
																					<AlternatingRowStyle CssClass="bg-light" />
																					<FooterStyle CssClass="fw-bold bg-light text-end" />

																					<Columns>
													
																				

																						<asp:TemplateField HeaderText="Descripción" ItemStyle-Width="48%">
																							<ItemTemplate>
																								<div class="position-relative">
																									<asp:TextBox ID="txtcodigoselect" runat="server"
																									CssClass="form-control form-control-sm pe-5 textbox-thin fw-normal"
																									Text='<%# Eval("Codigo") %>' Style="display:none"/>
																								
																									<%--<asp:TextBox ID="txtum_select" runat="server"
																									CssClass="form-control form-control-sm pe-5 textbox-thin fw-normal"
																									Text='<%# Eval("unidad_medida") %>'/>--%>
																								

																									<asp:TextBox ID="txtDescripcion" runat="server"
																										CssClass="form-control form-control-sm pe-5 textbox-thin fw-normal"
																										Text='<%# Eval("Descripcion") %>' BackColor="White" />
																									
																									<asp:TextBox ID="txttipo" runat="server"
																										CssClass="form-control form-control-sm pe-5 textbox-thin fw-normal"
																										Text='<%# Eval("tipo") %>' Visible="False" BackColor="White"/>
																									
																																												
																									<asp:LinkButton ID="btnEliminarArticulo" runat="server"
																										CommandName="EliminarArticulo"
																										CommandArgument='<%# Container.DataItemIndex %>'
																										CssClass="btn btn-sm btn-link position-absolute top-50 end-0 translate-middle-y p-0 text-danger" Visible="True">
																										<i class="bi bi-trash"></i>
																									</asp:LinkButton>

																									<asp:LinkButton ID="btnBuscarArticulo" runat="server"
																										CommandName="BuscarArticulo"
																										CommandArgument='<%# Container.DataItemIndex %>'
																										CssClass="btn btn-sm btn-link position-absolute top-50 translate-middle-y p-0"
																										style="right: 2.0rem;">   
																										<i class="bi bi-search"></i>
																									</asp:LinkButton>

																							

																								</div>
																							</ItemTemplate>
																						</asp:TemplateField>

																						<asp:TemplateField HeaderText="UM" ItemStyle-Width="7%">
																								<ItemTemplate>
																											<asp:TextBox ID="txtum_select" runat="server"
																											CssClass="form-control form-control-sm pe-5 textbox-thin fw-normal"
																											Text='<%# Eval("unidad_medida") %>' ReadOnly="True" BackColor="White"/>
																								</ItemTemplate>
																						</asp:TemplateField>

																						<asp:TemplateField HeaderText="Cantidad" ItemStyle-Width="7%">
																							<ItemTemplate>
																								<asp:TextBox ID="txtCantidad" runat="server" 
																									CssClass="form-control form-control-sm text-center fw-semibold textbox-thin fw-normal"
																									Text='<%# Eval("Cantidad") %>' 
																									TextMode="Number"
																									oninput="calcularSubtotal(this)" 
																									step="0.01" BackColor="White"/>
																							</ItemTemplate>
																						</asp:TemplateField>

																					


																						<asp:TemplateField HeaderText="Precio Unit." ItemStyle-Width="10%">
																							<ItemTemplate>
																								<asp:TextBox ID="txtPrecio" runat="server" 
																									CssClass="form-control form-control-sm text-end fw-semibold textbox-thin fw-normal"
																									Text='<%# Eval("Precio") %>' 
																									TextMode="Number"
																									oninput="calcularSubtotal(this)" 
																									step="0.01" BackColor="White"/>
																							</ItemTemplate>
																						</asp:TemplateField>
																				


																						<asp:TemplateField HeaderText="Subtotal" ItemStyle-Width="10%">
																										<ItemTemplate>
																												<asp:TextBox ID="txtSubtotal" runat="server" 
																													CssClass="form-control form-control-sm text-end fw-semibold textbox-thin fw-normal"
																													Text='<%# Eval("Subtotal") %>' ReadOnly="true" />
																										</ItemTemplate>
																						</asp:TemplateField>



<%--<asp:TemplateField HeaderText="Cantidad" ItemStyle-Width="7%">
  <ItemTemplate>
<asp:TextBox ID="txtCantidad" runat="server"
    CssClass="form-control form-control-sm text-center fw-semibold textbox-thin fw-normal"
    Text='<%# Bind("Cantidad") %>'
    TextMode="SingleLine"
    inputmode="decimal"
    pattern="[0-9]*[.,]?[0-9]+"
    AutoPostBack="True"
    OnTextChanged="txtCantidad_TextChanged"
    oninput="debounceChange(this)"
    BackColor="White" />
  </ItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="Precio Unit." ItemStyle-Width="10%">
  <ItemTemplate>
<asp:TextBox ID="txtPrecio" runat="server"
    CssClass="form-control form-control-sm text-end fw-semibold textbox-thin fw-normal"
    Text='<%# Bind("Precio") %>'
    TextMode="SingleLine"
    inputmode="decimal"
    pattern="[0-9]*[.,]?[0-9]+"
    AutoPostBack="True"
    OnTextChanged="txtPrecio_TextChanged"
    oninput="debounceChange(this)"
    BackColor="White" />



  </ItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="Subtotal" ItemStyle-Width="10%">
  <ItemTemplate>
    <asp:TextBox ID="txtSubtotal" runat="server"
      CssClass="form-control form-control-sm text-end fw-semibold textbox-thin fw-normal"
      Text='<%# Bind("Subtotal") %>' ReadOnly="true" />
  </ItemTemplate>
</asp:TemplateField>--%>



																					</Columns>
																				</asp:GridView>

																					<div class="text-end mt-2 fw-bold fs-5" style="color: #800080">
																						Total General: 
																						<asp:Label ID="lblTotalGeneral" runat="server" Text="0.00" CssClass="text-dark"></asp:Label>
																					</div>



																				</ContentTemplate>
																		</asp:UpdatePanel>
				
																		</asp:Panel>

																</ContentTemplate>
															</asp:UpdatePanel>

															<asp:UpdatePanel ID="UpdatePanel10" runat="server">
																<ContentTemplate>
																	<asp:Panel ID="pnlBusquedaItemsGrillaCotizacion" runat="server" Visible="false">

																		<asp:GridView ID="grvItemsBusqueda_Cotizacion" runat="server"
																						AutoGenerateColumns="False"
																						CssClass="table table-sm table-bordered"
																						OnRowCommand="grvArticulos_RowCommand"
																						OnRowDataBound="grvItemsBusqueda_Cotizacion_RowDataBound">
																						<Columns>
																							<asp:BoundField DataField="codigo" HeaderText="Código" />
																							<asp:BoundField DataField="descripcion" HeaderText="Descripción" />
																							<asp:BoundField DataField="tipo_material" HeaderText="Tipo Material" />
																							<asp:BoundField DataField="unidad_medida" HeaderText="Unidad Medida" />
																							<asp:BoundField DataField="tipo" HeaderText="Tipo" />
																							<asp:TemplateField>
																								<ItemTemplate>
																									<asp:LinkButton ID="btnSeleccionar" runat="server"
																										CommandName="Seleccionar"
																										CommandArgument='<%# Eval("codigo") & "|" & Eval("descripcion") & "|" & Eval("unidad_medida") & "|" & Eval("tipo") %>'
																										CssClass="btn btn-dark btn-sm">
																										Elegir
																									</asp:LinkButton>

																								</ItemTemplate>
																							</asp:TemplateField>
																						</Columns>
																		</asp:GridView>

																	</asp:Panel>
																</ContentTemplate>
														</asp:UpdatePanel>



														</div>
														

														
														

													</div>

													<!-- Footer -->
													<div class="modal-footer border-0">
													<asp:Panel ID="pnlFooterCotizacion_botones" runat="server">
													
														<table>
															<tr>
																<td><asp:LinkButton ID="BtnVolver_Cotizacion" runat="server" 
																CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark shadow-sm">
																<i class="fas fa-circle-arrow-left me-2"></i>
																<span>Volver</span>
																</asp:LinkButton></td>

																<td>
																	<asp:LinkButton ID="BtnGuardarPopup_Cotizaciones" runat="server" 
																CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark shadow-sm">
																<i class="fas fa-save me-2 text-success"></i>
																<span>Guardar</span>
																</asp:LinkButton>

																</td>
													

															</tr>
														</table>
														

														
														</asp:Panel>

														<asp:LinkButton ID="BtnCerrarPopup_Cotizaciones" runat="server" 
																		CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark shadow-sm">
																		<i class="fas fa-times-circle me-2 text-danger"></i>
																		<span>Cerrar</span>
														</asp:LinkButton>

														

													
													
													</div>




												</div>
											</div>
										</div>

				
										<div class="modal fade" tabindex="-1" id="myModal_archivos_adjuntos">
											<div class="modal-dialog">
													<div class="modal-content">
													<div class="modal-header" style="background-color: #A8123E">
														<h5 class="modal-title" style="color: #FFFFFF">Archivos Adjuntos para el Cliente</h5>
													</div>

													<div class="modal-body">
														<h4>Listado de Archivos</h4>
														<p>El siguiente listado muestra los archivos adjuntos por el administrador de la unidad.</p>
														<div style="overflow: auto">
														<asp:GridView ID="grvarchivosadjuntos" runat="server" AutoGenerateColumns="False" 
																CssClass="table table-bordered table-hover">
																<HeaderStyle CssClass="thead-dark" />
																<Columns>

																	<asp:TemplateField HeaderText="Descargar">
																		<HeaderStyle CssClass="text-center" ForeColor="#A8123E" />
																		<ItemStyle CssClass="text-center align-middle" />
																		<ItemTemplate>
																			<asp:LinkButton ID="btndescargar" runat="server" 
																				CssClass="btn btn-bg-light btn-sm rounded-circle waves-effect" 
																				CommandName="adjunto" 
																				CommandArgument='<%# Bind("id_documento_archivo") %>' 
																				Style="width: 40px; height: 40px; display: inline-flex; align-items: center; justify-content: center;">
																				<i class="fas fa-download"></i>
																			</asp:LinkButton>
																			<asp:Label ID="lblid" runat="server" Text='<%# Bind("id_documento_archivo") %>' 
																				Style="display:none"></asp:Label>
																		</ItemTemplate>
																	</asp:TemplateField>


																	<asp:TemplateField HeaderText="Nombre del Archivo Adjunto">
																		<HeaderStyle CssClass="text-center" ForeColor="#A8123E" />
																		<ItemStyle CssClass="align-middle" />
																		<ItemTemplate>
																			<asp:Label ID="lblarchivoadjunto" runat="server" 
																				Text='<%# Bind("nom_archivo") %>' 
																				CssClass="form-label"></asp:Label>
																		</ItemTemplate>
																	</asp:TemplateField>
																</Columns>
															</asp:GridView>
														</div>
													<%--	<div class="mb-6">
															
														</div>--%>

													</div>

													<div class="modal-footer">
													</div>
												</div>
												</div>
										</div>


										<div  class="modal fade bs-example-modal-lg" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true" style="display: none;">
                                    <div class="modal-dialog modal-xl">
                                        <div class="modal-content">
                                            <div class="modal-header" style="background-color: #A8123E; color: #FFFFFF;">
                                                <h4 class="modal-title" id="myLargeModalLabel">
                                                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                        <ContentTemplate>
                                                         <h5 class="modal-title" id="vcenter" style="color: #FFFFFF"><asp:Label ID="lbltituloCasos" runat="server" Text="Archivos Adjuntos por el Proveedor"></asp:Label></h5>
                                                         <asp:Label ID="lblNroExpedienteSelect" runat="server" Text="" Visible="False"></asp:Label>
                                                     </ContentTemplate></asp:UpdatePanel>
                                                   

                                                </h4>
                                                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                                            </div>
                                            <div class="modal-body">

                                                <h4>Listado de Archivos</h4>
                                                <p>El siguiente listado muestra los archivos adjuntos por el administrador de la unidad.</p>
                                                

                                                <div class="row">
                                                   <div class="col-12">
                                                    <div class="card">
                                                        <div class="card-body">
                                                       
                                                            <div class="table-responsive">

                                                           

                                                                        <%--<asp:GridView ID="grvarchivosadjuntos" runat="server"  class="table" AutoGenerateColumns="False">
                                                                      <Columns>
                                                                   <asp:TemplateField HeaderText="Descargar Archivo" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle">
                                                                       <ItemTemplate>
                                                                              <asp:LinkButton ID="btndescargar" runat="server" class="btn btn-youtube waves-effect btn-circle waves-light" CommandName="adjunto" ImageUrl="~/images/download.png" CommandArgument='<%# Bind("id_documento_archivo") %>'>
                                                                                 <i class="fas fa-download"></i>
                                                                              </asp:LinkButton>
                                                                           <asp:Label ID="lblid" runat="server" Text='<%# Bind("id_documento_archivo") %>' Style="display:none"></asp:Label>
                                                                       </ItemTemplate>
                                                                        <HeaderStyle CssClass="td-class-1" />
                                                                   </asp:TemplateField>
                                                                   <asp:TemplateField HeaderText="Nombre del Archivo adjunto" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle">
                                                                       <ItemTemplate>
                                                                          <asp:Label ID="lblarchivoadjunto" runat="server" Text='<%# Bind("nom_archivo") %>'></asp:Label>
                                                                      </ItemTemplate>
                                                                        <HeaderStyle CssClass="td-class-1"  />
                                                                   </asp:TemplateField>
                                       
                                                              
                                                               </Columns>

                                                                </asp:GridView>--%>
                                                                


                                    
                                                            </div>
                                                          
                                                        </div>
                            
                                                    </div>
                                                </div>


                                               </div>


                                            </div>
                                            <div class="modal-footer">
                                                <button type="button" class="btn btn-danger waves-effect text-left" data-dismiss="modal">Cerrar</button>
                                            </div>
                                        </div>
                                        <!-- /.modal-content -->
                                    </div>
                                    <!-- /.modal-dialog -->
                                </div>


										<%--<div class="modal fade" tabindex="-1" id="myModal_Mensaje">
											<div class="modal-dialog">
													<div class="modal-content">
													<div class="modal-header">
														<h5 class="modal-title">Sistema de Reconocimiento												<!--begin::Close-->
														<div class="btn btn-icon btn-sm btn-active-light-primary ms-2" data-bs-dismiss="modal" aria-label="Close">
															<span class="svg-icon svg-icon-2x"></span>
														</div>
														<!--end::Close-->
													</div>

													<div class="modal-body">
														<p>
															<asp:UpdatePanel ID="UpdatePanel5" runat="server">
																<ContentTemplate>
																	<asp:Label ID="lblmensajex" runat="server" Text="Label"></asp:Label>
																</ContentTemplate>
															</asp:UpdatePanel>
														</p>
													</div>

													<div class="modal-footer">
														<asp:LinkButton ID="btncerrar1" runat="server" class="btn btn-light" data-bs-dismiss="modal fade">Cerrar</asp:LinkButton>
							
													</div>
												</div>
												</div>
										</div>--%>

										<div class="modal fade" tabindex="-1" id="myModal_Mensaje">
											<div class="modal-dialog modal-md">
												<div class="modal-content text-center p-4 bg-white">
            
													<!-- Ícono con ID para animación -->
													<div class="mb-3">
														<i id="iconoAdvertencia" class="bi bi-exclamation-circle-fill text-warning" style="font-size: 3rem;"></i>
													</div>

													<!-- Título -->
													<h5 class="modal-title mb-2">Campos obligatorios</h5>

													<!-- Mensaje -->
													<div class="modal-body">
														<asp:UpdatePanel ID="UpdatePanel5" runat="server">
															<ContentTemplate>
																<asp:Label ID="lblmensajex" runat="server" CssClass="fw-bold"
																	Text="Por favor, completa todos los campos obligatorios antes de continuar."></asp:Label>
															</ContentTemplate>
														</asp:UpdatePanel>
													</div>

													<!-- Botón -->
													<div class="modal-footer justify-content-center border-0 bg-white">
														<%--<asp:LinkButton ID="btncerrar1" runat="server" CssClass="btn btn-purple text-white px-4 py-2"
															data-bs-dismiss="modal">Entendido</asp:LinkButton>--%>
														<asp:LinkButton ID="LinkButton2" runat="server" class="btn btn-light" data-bs-dismiss="modal fade">Cerrar</asp:LinkButton>
													</div>
												</div>
											</div>
										</div>


										<div class="modal fade" tabindex="-1" id="myModal_Mensaje_confirmacion">
												<div class="modal-dialog modal-md">
													<div class="modal-content text-center p-4 bg-white">
            
														<!-- Ícono con ID para animación -->
														<div class="mb-3">
															<%--<i id="iconoConfirmacion" class="bi bi-check-circle-fill text-success" style="font-size: 3rem;"></i>
															<i id="iconoError" class="bi bi-check-circle-fill text-danger" style="font-size: 3rem;"></i>--%>
															<i id="iconoConfirmacion" runat="server" class="bi bi-check-circle-fill text-success" style="font-size: 3rem;"></i>
															<i id="iconoError" runat="server" class="bi bi-x-circle-fill text-danger" style="font-size: 3rem;"></i>

														</div>

														<!-- Título -->
														<h5 class="modal-title mb-2"><asp:Label ID="lbltituloMensaje" runat="server" Text="Proceso Correctamente"></asp:Label></h5>

														<!-- Mensaje -->
														<div class="modal-body">
															<asp:UpdatePanel ID="UpdatePanel4" runat="server">
																<ContentTemplate>
																	<asp:Label ID="lblmensajeconfirmacion" runat="server" CssClass="fw-bold"
																		Text="Por favor, completa todos los campos obligatorios antes de continuar." EnableViewState="false"></asp:Label>
																</ContentTemplate>
															</asp:UpdatePanel>
														</div>

														<!-- Botón -->
														<div class="modal-footer justify-content-center border-0 bg-white">
															<%--<asp:LinkButton ID="btncerrar1" runat="server" CssClass="btn btn-purple text-white px-4 py-2"
																data-bs-dismiss="modal">Entendido</asp:LinkButton>--%>
															<asp:LinkButton ID="LinkButton3" runat="server" class="btn btn-light" data-bs-dismiss="modal fade">Cerrar</asp:LinkButton>
														</div>
													</div>
												</div>
										</div>

										<div class="modal fade" tabindex="-1" id="myModal_Mensaje_rechazo">
											<div class="modal-dialog modal-md">
												<div class="modal-content text-center p-4 bg-white">
            
													<!-- Ícono con ID para animación -->
													<div class="mb-3 text-center">
														<i id="iconoConfirmacionx" class="bi bi-x-circle-fill text-danger" style="font-size: 3rem;"></i>
													</div>


													<!-- Título -->
													<h5 class="modal-title mb-2">Cotización Rechazada</h5>

													<!-- Mensaje -->
													<div class="modal-body">
														<asp:UpdatePanel ID="UpdatePanel12" runat="server">
															<ContentTemplate>
															
																<asp:Label ID="lblmensajerechazo" runat="server" CssClass="fw-semibold d-block mb-2"
																	Text="Por favor, indique el motivo del rechazo:"></asp:Label>

																<asp:TextBox ID="txtSustentoRechazo" runat="server" CssClass="form-control" 
																	TextMode="MultiLine" Rows="4" MaxLength="500" 
																	placeholder="Escriba aquí el sustento del rechazo..."></asp:TextBox>

																<small class="text-muted">Máximo 500 caracteres.</small>
															</ContentTemplate>
														</asp:UpdatePanel>
													</div>


													<!-- Botón -->
													<div class="modal-footer justify-content-center border-0 bg-white">
												
														<%--<asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-light" data-bs-dismiss="modal fade">Cerrar</asp:LinkButton>
														--%>
														<asp:LinkButton ID="btnRechazarCotizaciones_cerrar" runat="server" 
																CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark" data-bs-dismiss="modal fade">
																<i class="fas fa-closed-captioning me-2 text-danger"></i>
																<span>Cancelar</span>
														</asp:LinkButton>
														
														<asp:LinkButton ID="btnRechazarCotizaciones_Sustento" runat="server" 
																		CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark" data-bs-dismiss="modal fade">
																		<i class="fas fa-save me-2 text-dark"></i>
																		<span>Registrar</span>
														</asp:LinkButton>

													</div>
												</div>
											</div>
										</div>




										<div class="modal fade" tabindex="-1" id="myModal_Mensaje_Estado_Sustento">
											<div class="modal-dialog modal-md">
											<div class="modal-content text-center p-4 bg-white">
            
												<!-- Ícono con ID para animación -->
												<div class="mb-3 text-center">
													<i id="iconoConfirmacionxy" class="bi bi-info-square-fill text-primary" style="font-size: 3rem;"></i>
												</div>


												<!-- Título -->
												<h5 class="modal-title mb-2">Sustento del Proveedor</h5>

												<!-- Mensaje -->
												<div class="modal-body">
													<asp:UpdatePanel ID="UpdatePanel13" runat="server">
														<ContentTemplate>
														
															<asp:Label ID="Label1" runat="server" CssClass="fw-semibold d-block mb-2"
																Text="No olvide adjuntar el archivo que sustente el trabajo del proveedor y deje un comentario al respecto:"></asp:Label>

															<asp:TextBox ID="txtsustento_proveedor" runat="server" CssClass="form-control" 
																TextMode="MultiLine" Rows="16" MaxLength="500" 
																placeholder="Escriba aquí el sustento..."></asp:TextBox>

															<small class="text-muted">Máximo 500 caracteres.</small>
														</ContentTemplate>
													</asp:UpdatePanel>
												</div>


												<!-- Botón -->
												<div class="modal-footer justify-content-center border-0 bg-white">
								
													<%--<asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-light" data-bs-dismiss="modal fade">Cerrar</asp:LinkButton>
													--%>
													<asp:LinkButton ID="LinkButton1" runat="server" 
															CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark" data-bs-dismiss="modal fade">
															<i class="fas fa-closed-captioning me-2 text-danger"></i>
															<span>Cancelar</span>
													</asp:LinkButton>
													
													<asp:LinkButton ID="btnEstadoSustento_Proveedor" runat="server" 
																	CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark" data-bs-dismiss="modal fade">
																	<i class="fas fa-save me-2 text-dark"></i>
																	<span>Registrar</span>
													</asp:LinkButton>

												</div>
											</div>
											</div>
										</div>




										<div class="modal fade" tabindex="-1" id="myModal_Mensaje_Sustento_final">
											<div class="modal-dialog modal-md">
											<div class="modal-content text-center p-4 bg-white">
            
															<!-- Ícono con ID para animación -->
															<div class="mb-3 text-center">
																		<i class="bi bi-calendar-date text-primary" style="font-size: 3rem;"></i>

															</div>


															<!-- Título -->
															<h5 class="modal-title mb-2">Ingrese la fecha contable para la aprobación del aviso.</h5>

															<!-- Mensaje -->
															<div class="modal-body">
																			<asp:UpdatePanel ID="UpdatePanel16" runat="server">
																				<ContentTemplate>
			<%--		
																						<asp:Label ID="Label3" runat="server" CssClass="fw-semibold d-block mb-2"
																						Text="Ingrese Fecha contable:"></asp:Label>--%>

																						<asp:TextBox ID="txtfechacontable" runat="server" CssClass="form-control form-control-sm fw-normal" TextMode="Date" BackColor="White"></asp:TextBox>

																					
																					
																				</ContentTemplate>
																			</asp:UpdatePanel>
															</div>


															<!-- Botón -->
															<div class="modal-footer justify-content-center border-0 bg-white">
								
																			<%--<asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-light" data-bs-dismiss="modal fade">Cerrar</asp:LinkButton>
																			--%>
																			<asp:LinkButton ID="LinkButton4" runat="server" 
																					CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark" data-bs-dismiss="modal fade">
																					<i class="fas fa-closed-captioning me-2 text-danger"></i>
																					<span>Cancelar</span>
																			</asp:LinkButton>
												
																			<asp:LinkButton ID="btnRegistrarEstadoFinal" runat="server" 
																							CssClass="btn-float d-flex align-items-center px-3 py-2 rounded-pill text-dark" data-bs-dismiss="modal fade">
																							<i class="fas fa-save me-2 text-dark"></i>
																							<span>Registrar</span>
																			</asp:LinkButton>

															</div>
											</div>
											</div>
</div>






										<div class="modal fade" tabindex="-1" id="myModal_Mensaje_vacio">
											<div class="modal-dialog">
													<div class="modal-content">
													<div class="modal-header">
														<h5 class="modal-title">Sistema de Sanciones												<!--begin::Close-->
														<div class="btn btn-icon btn-sm btn-active-light-primary ms-2" data-bs-dismiss="modal" aria-label="Close">
															<span class="svg-icon svg-icon-2x"></span>
														</div>
														<!--end::Close-->
													</div>

													<div class="modal-body">
														<p>
															<asp:UpdatePanel ID="UpdatePanel14" runat="server">
																<ContentTemplate>

																	<i class="stepper-check fas fa-check"></i>
																	<asp:Label ID="lblmensajevacio" runat="server" Text="Label"></asp:Label>
																</ContentTemplate>
															</asp:UpdatePanel>
														</p>
													</div>

													<div class="modal-footer">
														<button type="button" class="btn btn-light" data-bs-dismiss="modal">Close</button>
													<%--	<asp:Button ID="btnprocesar" runat="server" Text="Procesar" class="btn btn-light"/>--%>
											<%--			<asp:LinkButton ID="btncerrar1" runat="server" class="btn btn-light" data-bs-dismiss="modal fade">LinkButton</asp:LinkButton>
														<button type="button" class="btn btn-primary">Save changes</button>--%>
											
													</div>
												</div>
												</div>
										</div>



										<div class="modal fade" id="myModal_Foto" tabindex="-1" role="dialog" aria-hidden="true" data-backdrop="static" data-keyboard="false">
											<div class="modal-dialog modal-dialog-centered modal-lg">
												<div class="modal-content">
													<div class="modal-header bg-dark text-white">
														<h5 class="modal-title">Foto del Incidente</h5>
														<button type="button" class="close text-white" data-dismiss="modal" aria-label="Close">
															<span aria-hidden="true">&times;</span>
														</button>
													</div>
													<div class="modal-body text-center">
														<asp:Image ID="imgPopup" runat="server" CssClass="img-fluid rounded shadow-lg border" />
													</div>
													<div class="modal-footer">
														<button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
													</div>
												</div>
											</div>
										</div>



										<div class="modal fade" tabindex="-1" id="myModal_busqueda">
											<div class="modal-dialog">
													<div class="modal-content">
													<div class="modal-header">
														<h5 class="modal-title">Filtro de Búsqueda</h5>
													</div>

													<div class="modal-body">
														<div class="mb-6">
														<label for="exampleFormControlInput1" class="form-label">DNI - Carnet Ext.</label>
														<%--<input type="text" class="form-control form-control-solid" placeholder="Ingresar Datos de Colaborador"/>--%>
														<asp:TextBox ID="txtnrodocumento" runat="server" class="form-control form-control-solid" placeholder=""></asp:TextBox>
														</div>
														<div class="mb-6">
														<label for="exampleFormControlInput1" class="form-label">Nombre y Apellidos</label>
														<%--<input type="text" class="form-control form-control-solid" placeholder="Ingresar Datos de Colaborador"/>--%>
														<asp:TextBox ID="txtnomape" runat="server" class="form-control form-control-solid" placeholder=""></asp:TextBox>
														</div>
														<div class="mb-6">
														<label for="exampleFormControlInput1" class="form-label">Seleccione Unidad</label>
														<%--<input type="text" class="form-control form-control-solid" placeholder="Ingresar Datos de Colaborador"/>--%>
														<asp:DropDownList ID="cbounidadx" runat="server" class="form-select form-select-lg form-select-solid"></asp:DropDownList>
														
														</div>
														<div class="mb-6">
														<label for="exampleFormControlInput1" class="form-label">Seleccione Motivo</label>
														<%--<input type="text" class="form-control form-control-solid" placeholder="Ingresar Datos de Colaborador"/>--%>
														<asp:DropDownList ID="cbomotivo" runat="server" class="form-select form-select-lg form-select-solid"></asp:DropDownList>
														</div>
														<div class="mb-6">
														<label for="exampleFormControlInput1" class="form-label">Seleccione Estado</label>
														<%--<input type="text" class="form-control form-control-solid" placeholder="Ingresar Datos de Colaborador"/>--%>
														<asp:DropDownList ID="cboestado" runat="server" class="form-select form-select-lg form-select-solid"></asp:DropDownList>
														</div>
														<div class="mb-6">
														<label for="exampleFormControlInput1" class="form-label">Fecha de Registro inicial</label>
														<%--<input type="text" class="form-control form-control-solid" placeholder="Ingresar Datos de Colaborador"/>--%>
														<asp:TextBox ID="txtfecinisancion" runat="server" class="form-control" type="date"></asp:TextBox>
														</div>
														<div class="mb-6">
														<label for="exampleFormControlInput1" class="form-label">Fecha de Registro Final</label>
														<%--<input type="text" class="form-control form-control-solid" placeholder="Ingresar Datos de Colaborador"/>--%>
														<asp:TextBox ID="txtfecfinsancion" runat="server" class="form-control" type="date"></asp:TextBox>
														</div>

														<div class="mb-6">
															<asp:LinkButton ID="btnbuscarx" runat="server" class="btn btn-bg-light">Buscar</asp:LinkButton>
														</div>
														


													</div>

													<div class="modal-footer">
													<%--	<button type="button" class="btn btn-light" data-bs-dismiss="modal">Close</button>
														<asp:Button ID="btnprocesar" runat="server" Text="Procesar" class="btn btn-light"/>--%>
											<%--			<asp:LinkButton ID="btncerrar1" runat="server" class="btn btn-light" data-bs-dismiss="modal fade">LinkButton</asp:LinkButton>
														<button type="button" class="btn btn-primary">Save changes</button>--%>
											
													</div>
												</div>
												</div>
										</div>

	

									<%--<div id="modal-validacion" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="vcenter" aria-hidden="true">
                                    <div class="modal-dialog modal-dialog-centered">
                                        <div class="modal-content">
                                            <div class="modal-header" style="background-color: #A8123E">
                                                <h5 class="modal-title" id="vcenter" style="color: #FFFFFF">Administrador de Libro de Reclamaciones</h5>
                                                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                                            </div>
                                            <div class="modal-body" >
                                                <p>
                                                    <asp:Label ID="lblmensaje_validacion" runat="server" Text=""></asp:Label>

                                                </p>
                                            </div>
                                            <div class="modal-footer">
                                                <button type="button" class="btn btn-info waves-effect" data-dismiss="modal">Cerrar</button>
                                            </div>
                                        </div>
                                        <!-- /.modal-content -->
                                    </div>
                                    <!-- /.modal-dialog -->
                                </div>
                        --%>
								<div class="modal modal-static fade" id="modal-validacion"  tabindex="-1" role="dialog" aria-labelledby="vcenter" aria-hidden="true">
																	<div class="modal-dialog modal-dialog-centered">
																		<div class="modal-content">
																		 <div class="modal-header" style="background-color: #A8123E">
																			<h4 class="modal-title" id="vcenter" style="color: #FFFFFF">Administrador de Reclamos</h4>
                                              
																		</div>
																			<div class="modal-body">
																				 <p><asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label>

																			</p>
                                                                                                  
																			</div>
																			<div class="modal-footer">
																			<asp:Button ID="Button1" runat="server" Text="Cerrar" BackColor="#A8123E" BorderColor="#A8123E" ForeColor="White" />
																		</div>

                                               
																		</div>
									</div>
								</div>



								<div id="modal-validacion2" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="vcenter" aria-hidden="true">
                                    <div class="modal-dialog modal-dialog-centered">
                                        <div class="modal-content">
                                            <div class="modal-header" style="background-color: #A8123E">
                                                <h4 class="modal-title" id="vcenter" style="color: #FFFFFF">Administrador de Reclamos</h4>
                                                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                                            </div>
                                            <div class="modal-body" >
                                                <p>
                                                    <asp:Label ID="lblmensaje_foto" runat="server" Text="Label"></asp:Label>

                                                </p>
                                            </div>
                                            <div class="modal-footer">
                                                <button type="button" class="btn btn-info waves-effect" data-dismiss="modal">Cerrar</button>
                                            </div>
                                        </div>
                                        <!-- /.modal-content -->
                                    </div>
                                    <!-- /.modal-dialog -->
                                </div>


							 <div class="modal modal-static fade" id="modal-info"  tabindex="-1" role="dialog" aria-labelledby="vcenter" aria-hidden="true">
																	<div class="modal-dialog modal-dialog-centered">
																		<div class="modal-content">
																		 <div class="modal-header" style="background-color: #A8123E">
																			<h4 class="modal-title" id="vcenter" style="color: #FFFFFF">Administrador de Reclamos</h4>
                                              
																		</div>
																			<div class="modal-body">
																				 <p><label id="lblmensaje2">Se registró correctamente.</label>

																			</p>
                                                                                                  
																			</div>
																			<div class="modal-footer">
																			<asp:Button ID="btncerrar" runat="server" Text="Cerrar" BackColor="#A8123E" BorderColor="#A8123E" ForeColor="White" />
																		</div>

                                               
																		</div>
									</div>
								</div>

										      
									<div class="modal modal-static2 fade" id="processing-modal" role="dialog" aria-hidden="true">
																<div class="modal-dialog">
																	<div class="modal-content">
																		<div class="modal-body">
																			<div class="text-center">
																				<%--Popup de adjuntos--%>
																				<img src="images/images_sistema/loading.gif" class="icon" />
																				<h5><span class="modal-text"><asp:Label ID="Label2" runat="server" Text="Registrando Aviso... " ForeColor="#666666"></asp:Label></span></h5>
																			</div>
																		</div>
																	</div>
																</div>
										</div>



									
						
								</div>

								</form>





							<!--begin::Row-->
					


								<!--begin::Modal - Select Location-->
								<div class="modal fade" id="kt_modal_select_location" tabindex="-1" aria-hidden="true">
									<!--begin::Modal dialog-->
									<div class="modal-dialog mw-1000px">
										<!--begin::Modal content-->
										<div class="modal-content">
											<!--begin::Modal header-->
											<div class="modal-header">
												<!--begin::Title-->
												<h2>Select Location</h2>
												<!--end::Title-->
												<!--begin::Close-->
												<div class="btn btn-sm btn-icon btn-active-color-primary" data-bs-dismiss="modal">
													<!--begin::Svg Icon | path: icons/duotune/arrows/arr061.svg-->
													<span class="svg-icon svg-icon-1">
														<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
															<rect opacity="0.5" x="6" y="17.3137" width="16" height="2" rx="1" transform="rotate(-45 6 17.3137)" fill="black" />
															<rect x="7.41422" y="6" width="16" height="2" rx="1" transform="rotate(45 7.41422 6)" fill="black" />
														</svg>
													</span>
													<!--end::Svg Icon-->
												</div>
												<!--end::Close-->
											</div>
											<!--end::Modal header-->
											<!--begin::Modal body-->
											<div class="modal-body">
												<div id="kt_modal_select_location_map" class="w-100 rounded" style="height:450px"></div>
											</div>
											<!--end::Modal body-->
											<!--begin::Modal footer-->
											<div class="modal-footer d-flex justify-content-end">
												<a href="#" class="btn btn-active-light me-5" data-bs-dismiss="modal">Cancel</a>
												<button type="button" id="kt_modal_select_location_button" class="btn btn-primary" data-bs-dismiss="modal">Apply</button>
											</div>
											<!--end::Modal footer-->
										</div>
										<!--end::Modal content-->
									</div>
									<!--end::Modal dialog-->
								</div>
								<!--end::Modal - Select Location-->
								<!--end::Modals-->
								<!--end::Container-->
								<!--end::Content-->
								<!--end::Main-->
								<!--begin::Footer-->
								<div class="footer py-4 d-flex flex-lg-column" id="kt_footer">
									<!--begin::Container-->
									<div class="container-xxl d-flex flex-column flex-md-row flex-stack">
										<!--begin::Copyright-->
										<div class="text-dark order-2 order-md-1">
											<span class="text-muted fw-bold me-2">Desarrollo de Sistemas e Innovación</span>
											<a href="https://keenthemes.com" target="_blank" class="text-gray-800 text-hover-primary">Área de Soluciones de Negocio</a>
										</div>
										<!--end::Copyright-->
										<!--begin::Menu-->
										<%--<ul class="menu menu-gray-600 menu-hover-primary fw-bold order-1">
											<li class="menu-item">
												<a href="https://keenthemes.com" target="_blank" class="menu-link px-2">About</a>
											</li>
											<li class="menu-item">
												<a href="https://keenthemes.com/support" target="_blank" class="menu-link px-2">Support</a>
											</li>
											<li class="menu-item">
												<a href="https://themes.getbootstrap.com/product/start-multipurpose-admin-dashboard-theme/" target="_blank" class="menu-link px-2">Purchase</a>
											</li>
										</ul>--%>
										<!--end::Menu-->
									</div>
									<!--end::Container-->
								</div>
								<!--end::Footer-->
								<!--end::Wrapper-->
								<!--end::Page-->
								<!--end::Root-->
								<!--begin::Header Search-->
								<div class="modal bg-white fade" id="kt_header_search_modal" aria-hidden="true">
									<div class="modal-dialog modal-fullscreen">
										<div class="modal-content shadow-none">
											<div class="container w-lg-800px">
												<div class="modal-header d-flex justify-content-end border-0">
													<!--begin::Close-->
													<div class="btn btn-icon btn-sm btn-light-primary ms-2" data-bs-dismiss="modal">
														<!--begin::Svg Icon | path: icons/duotune/arrows/arr061.svg-->
														<span class="svg-icon svg-icon-1">
															<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																<rect opacity="0.5" x="6" y="17.3137" width="16" height="2" rx="1" transform="rotate(-45 6 17.3137)" fill="black" />
																<rect x="7.41422" y="6" width="16" height="2" rx="1" transform="rotate(45 7.41422 6)" fill="black" />
															</svg>
														</span>
														<!--end::Svg Icon-->
													</div>
													<!--end::Close-->
												</div>
												<div class="modal-body">
													<!--begin::Search-->
													<form class="pb-10">
														<input autofocus="" type="text" class="form-control bg-transparent border-0 fs-4x text-center fw-normal" name="query" placeholder="Search..." />
													</form>
													<!--end::Search-->
													<!--begin::Shop Goods-->
													<div class="py-10">
														<h3 class="fw-bolder mb-8">Shop Goods</h3>
														<!--begin::Row-->
														<div class="row g-5">
															<div class="col-sm-6">
																<div class="row g-5">
																	<div class="col-sm-6">
																		<div class="card overlay min-h-125px mb-5 shadow-none">
																			<div class="card-body d-flex flex-column p-0">
																				<div class="overlay-wrapper flex-grow-1 bgi-no-repeat bgi-size-cover bgi-position-center card-rounded" style="background-image:url('assets/media/stock/600x400/img-17.jpg')"></div>
																				<div class="overlay-layer bg-white bg-opacity-50">
																					<a href="#" class="btn btn-sm fw-bold btn-primary">Explore</a>
																				</div>
																			</div>
																		</div>
																		<div class="card overlay min-h-125px mb-5 shadow-none">
																			<div class="card-body d-flex flex-column p-0">
																				<div class="overlay-wrapper flex-grow-1 bgi-no-repeat bgi-size-cover bgi-position-center card-rounded" style="background-image:url('assets/media/stock/600x400/img-1.jpg')"></div>
																				<div class="overlay-layer bg-white bg-opacity-50">
																					<a href="#" class="btn btn-sm fw-bold btn-primary">Explore</a>
																				</div>
																			</div>
																		</div>
																	</div>
																	<div class="col-sm-6">
																		<div class="card card-stretch overlay mb-5 shadow-none min-h-250px">
																			<div class="card-body d-flex flex-column p-0">
																				<div class="overlay-wrapper flex-grow-1 bgi-no-repeat bgi-size-cover bgi-position-center card-rounded" style="background-image:url('assets/media/stock/600x400/img-23.jpg')"></div>
																				<div class="overlay-layer bg-white bg-opacity-50">
																					<a href="#" class="btn btn-sm fw-bold btn-primary">Explore</a>
																				</div>
																			</div>
																		</div>
																	</div>
																</div>
															</div>
															<div class="col-sm-6">
																<div class="card card-stretch overlay mb-5 shadow-none min-h-250px">
																	<div class="card-body d-flex flex-column p-0">
																		<div class="overlay-wrapper flex-grow-1 bgi-no-repeat bgi-size-cover bgi-position-center card-rounded" style="background-image:url('assets/media/stock/600x400/img-11.jpg')"></div>
																		<div class="overlay-layer bg-white bg-opacity-50">
																			<a href="#" class="btn btn-sm fw-bold btn-primary">Explore</a>
																		</div>
																	</div>
																</div>
															</div>
														</div>
														<!--end::Row-->
													</div>
													<!--end::Shop Goods-->
													<!--begin::Framework Users-->
													<div>
														<h3 class="text-dark fw-bolder fs-1 mb-6">Framework Users</h3>
														<!--begin::List Widget 4-->
														<div class="card bg-transparent mb-5 shadow-none">
															<!--begin::Body-->
															<div class="card-body pt-2 px-0">
																<div class="table-responsive">
																	<table class="table table-borderless align-middle">
																		<!--begin::Item-->
																		<tr>
																			<th class="ps-0 w-55px">
																				<!--begin::Symbol-->
																				<div class="symbol symbol-55px flex-shrink-0 me-4">
																					<span class="symbol-label bg-light-primary">
																						<img src="assets/media/svg/avatars/009-boy-4.svg" class="h-75 align-self-end" alt="" />
																					</span>
																				</div>
																				<!--end::Symbol-->
																			</th>
																			<td class="ps-0 flex-column min-w-300px">
																				<!--begin::Title-->
																				<a href="#" class="text-gray-800 fw-bolder text-hover-primary fs-6 mb-1">Brad Simmons</a>
																				<div class="text-muted fw-bold">Uses: HTML/CSS/JS, Python</div>
																				<!--end::Title-->
																			</td>
																			<td>
																				<!--begin::Label-->
																				<div class="me-4 me-md-19 text-md-right">
																					<div class="text-gray-800 fw-bolder fs-6 mb-1">$2,000,000</div>
																					<span class="text-muted fw-bold">Paid</span>
																				</div>
																				<!--end::Label-->
																			</td>
																			<td class="text-end pe-0">
																				<!--begin::Btn-->
																				<a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm">
																					<!--begin::Svg Icon | path: icons/duotune/arrows/arr064.svg-->
																					<span class="svg-icon svg-icon-4">
																						<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																							<rect opacity="0.5" x="18" y="13" width="13" height="2" rx="1" transform="rotate(-180 18 13)" fill="black" />
																							<path d="M15.4343 12.5657L11.25 16.75C10.8358 17.1642 10.8358 17.8358 11.25 18.25C11.6642 18.6642 12.3358 18.6642 12.75 18.25L18.2929 12.7071C18.6834 12.3166 18.6834 11.6834 18.2929 11.2929L12.75 5.75C12.3358 5.33579 11.6642 5.33579 11.25 5.75C10.8358 6.16421 10.8358 6.83579 11.25 7.25L15.4343 11.4343C15.7467 11.7467 15.7467 12.2533 15.4343 12.5657Z" fill="black" />
																						</svg>
																					</span>
																					<!--end::Svg Icon-->
																				</a>
																				<!--end::Btn-->
																			</td>
																		</tr>
																		<!--end::Item-->
																		<!--begin::Item-->
																		<tr>
																			<th class="ps-0">
																				<!--begin::Symbol-->
																				<div class="symbol symbol-55px flex-shrink-0 me-4">
																					<span class="symbol-label bg-light-danger">
																						<img src="assets/media/svg/avatars/006-girl-3.svg" class="h-75 align-self-end" alt="" />
																					</span>
																				</div>
																				<!--end::Symbol-->
																			</th>
																			<td class="ps-0 flex-column min-w-300px">
																				<!--begin::Title-->
																				<a href="#" class="text-gray-800 fw-bolder text-hover-primary fs-6 mb-1">Jessie Clarcson</a>
																				<div class="text-muted fw-bold">Uses: HTML, ReactJS, ASP.NET</div>
																				<!--end::Title-->
																			</td>
																			<td>
																				<!--end::Label-->
																				<div class="me-4 me-md-19 text-md-right">
																					<div class="text-gray-800 fw-bolder fs-6 mb-1">$1,200,000</div>
																					<span class="text-muted fw-bold">Paid</span>
																				</div>
																				<!--end::Label-->
																			</td>
																			<td class="text-end pe-0">
																				<!--begin::Btn-->
																				<a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm">
																					<!--begin::Svg Icon | path: icons/duotune/arrows/arr064.svg-->
																					<span class="svg-icon svg-icon-4">
																						<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																							<rect opacity="0.5" x="18" y="13" width="13" height="2" rx="1" transform="rotate(-180 18 13)" fill="black" />
																							<path d="M15.4343 12.5657L11.25 16.75C10.8358 17.1642 10.8358 17.8358 11.25 18.25C11.6642 18.6642 12.3358 18.6642 12.75 18.25L18.2929 12.7071C18.6834 12.3166 18.6834 11.6834 18.2929 11.2929L12.75 5.75C12.3358 5.33579 11.6642 5.33579 11.25 5.75C10.8358 6.16421 10.8358 6.83579 11.25 7.25L15.4343 11.4343C15.7467 11.7467 15.7467 12.2533 15.4343 12.5657Z" fill="black" />
																						</svg>
																					</span>
																					<!--end::Svg Icon-->
																				</a>
																				<!--end::Btn-->
																			</td>
																		</tr>
																		<!--end::Item-->
																		<!--begin::Item-->
																		<tr>
																			<th class="ps-0">
																				<!--begin::Symbol-->
																				<div class="symbol symbol-55px flex-shrink-0 me-4">
																					<span class="symbol-label bg-light-success">
																						<img src="assets/media/svg/avatars/011-boy-5.svg" class="h-75 align-self-end" alt="" />
																					</span>
																				</div>
																				<!--end::Symbol-->
																			</th>
																			<td class="ps-0 flex-column min-w-300px">
																				<!--begin::Title-->
																				<a href="#" class="text-gray-800 fw-bolder text-hover-primary fs-6 mb-1">Lebron Wayde</a>
																				<div class="text-muted fw-bold">Uses: HTML. Laravel Framework</div>
																				<!--end::Title-->
																			</td>
																			<td>
																				<!--end::Label-->
																				<div class="me-4 me-md-19 text-md-right">
																					<div class="text-gray-800 fw-bolder fs-6 mb-1">$3,400,000</div>
																					<span class="text-muted fw-bold">Paid</span>
																				</div>
																				<!--end::Label-->
																			</td>
																			<td class="text-end pe-0">
																				<!--begin::Btn-->
																				<a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm">
																					<!--begin::Svg Icon | path: icons/duotune/arrows/arr064.svg-->
																					<span class="svg-icon svg-icon-4">
																						<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																							<rect opacity="0.5" x="18" y="13" width="13" height="2" rx="1" transform="rotate(-180 18 13)" fill="black" />
																							<path d="M15.4343 12.5657L11.25 16.75C10.8358 17.1642 10.8358 17.8358 11.25 18.25C11.6642 18.6642 12.3358 18.6642 12.75 18.25L18.2929 12.7071C18.6834 12.3166 18.6834 11.6834 18.2929 11.2929L12.75 5.75C12.3358 5.33579 11.6642 5.33579 11.25 5.75C10.8358 6.16421 10.8358 6.83579 11.25 7.25L15.4343 11.4343C15.7467 11.7467 15.7467 12.2533 15.4343 12.5657Z" fill="black" />
																						</svg>
																					</span>
																					<!--end::Svg Icon-->
																				</a>
																				<!--end::Btn-->
																			</td>
																		</tr>
																		<!--end::Item-->
																		<!--begin::Item-->
																		<tr>
																			<th class="ps-0">
																				<!--begin::Symbol-->
																				<div class="symbol symbol-55px flex-shrink-0 me-4">
																					<span class="symbol-label bg-light-warning">
																						<img src="assets/media/svg/avatars/015-boy-6.svg" class="h-75 align-self-end" alt="" />
																					</span>
																				</div>
																				<!--end::Symbol-->
																			</th>
																			<td class="ps-0 flex-column min-w-300px">
																				<!--begin::Title-->
																				<a href="#" class="text-gray-800 fw-bolder text-hover-primary fs-6 mb-1">Kevin Leonard</a>
																				<div class="text-muted fw-bold">Uses: VueJS, Laravel Framework</div>
																				<!--end::Title-->
																			</td>
																			<td>
																				<!--end::Label-->
																				<div class="me-4 me-md-19 text-md-right">
																					<div class="text-gray-800 fw-bolder fs-6 mb-1">$35,600,000</div>
																					<span class="text-muted fw-bold">Paid</span>
																				</div>
																				<!--end::Label-->
																			</td>
																			<td class="text-end pe-0">
																				<!--begin::Btn-->
																				<a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm">
																					<!--begin::Svg Icon | path: icons/duotune/arrows/arr064.svg-->
																					<span class="svg-icon svg-icon-4">
																						<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																							<rect opacity="0.5" x="18" y="13" width="13" height="2" rx="1" transform="rotate(-180 18 13)" fill="black" />
																							<path d="M15.4343 12.5657L11.25 16.75C10.8358 17.1642 10.8358 17.8358 11.25 18.25C11.6642 18.6642 12.3358 18.6642 12.75 18.25L18.2929 12.7071C18.6834 12.3166 18.6834 11.6834 18.2929 11.2929L12.75 5.75C12.3358 5.33579 11.6642 5.33579 11.25 5.75C10.8358 6.16421 10.8358 6.83579 11.25 7.25L15.4343 11.4343C15.7467 11.7467 15.7467 12.2533 15.4343 12.5657Z" fill="black" />
																						</svg>
																					</span>
																					<!--end::Svg Icon-->
																				</a>
																				<!--end::Btn-->
																			</td>
																		</tr>
																		<!--end::Item-->
																	</table>
																</div>
															</div>
															<!--end::Body-->
														</div>
														<!--end::List Widget 4-->
													</div>
													<!--end::Framework Users-->
													<!--begin::Tutorials-->
													<div class="pb-10">
														<h3 class="text-dark fw-bolder fs-1 mb-6">Tutorials</h3>
														<!--begin::List Widget 5-->
														<div class="card mb-5 shadow-none">
															<!--begin::Body-->
															<div class="card-body pt-2 px-0">
																<!--begin::Item-->
																<div class="d-flex mb-6">
																	<!--begin::Icon-->
																	<div class="me-1">
																		<!--begin::Svg Icon | path: icons/duotune/arrows/arr071.svg-->
																		<span class="svg-icon svg-icon-sm svg-icon-primary">
																			<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																				<path d="M12.6343 12.5657L8.45001 16.75C8.0358 17.1642 8.0358 17.8358 8.45001 18.25C8.86423 18.6642 9.5358 18.6642 9.95001 18.25L15.4929 12.7071C15.8834 12.3166 15.8834 11.6834 15.4929 11.2929L9.95001 5.75C9.5358 5.33579 8.86423 5.33579 8.45001 5.75C8.0358 6.16421 8.0358 6.83579 8.45001 7.25L12.6343 11.4343C12.9467 11.7467 12.9467 12.2533 12.6343 12.5657Z" fill="black" />
																			</svg>
																		</span>
																		<!--end::Svg Icon-->
																	</div>
																	<!--end::Icon-->
																	<!--begin::Content-->
																	<div class="d-flex flex-column">
																		<a href="#" class="fs-6 fw-bolder text-hover-primary text-gray-800 mb-2">How to Create Your First Project with Start Admin Theme</a>
																		<div class="fw-bold text-muted">But nothing can prepare you for the real thing</div>
																	</div>
																	<!--end::Content-->
																</div>
																<!--end::Item-->
																<!--begin::Item-->
																<div class="d-flex mb-6">
																	<!--begin::Icon-->
																	<div class="me-1">
																		<!--begin::Svg Icon | path: icons/duotune/arrows/arr071.svg-->
																		<span class="svg-icon svg-icon-sm svg-icon-primary">
																			<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																				<path d="M12.6343 12.5657L8.45001 16.75C8.0358 17.1642 8.0358 17.8358 8.45001 18.25C8.86423 18.6642 9.5358 18.6642 9.95001 18.25L15.4929 12.7071C15.8834 12.3166 15.8834 11.6834 15.4929 11.2929L9.95001 5.75C9.5358 5.33579 8.86423 5.33579 8.45001 5.75C8.0358 6.16421 8.0358 6.83579 8.45001 7.25L12.6343 11.4343C12.9467 11.7467 12.9467 12.2533 12.6343 12.5657Z" fill="black" />
																			</svg>
																		</span>
																		<!--end::Svg Icon-->
																	</div>
																	<!--end::Icon-->
																	<!--begin::Content-->
																	<div class="d-flex flex-column">
																		<a href="#" class="fs-6 fw-bolder text-hover-primary text-gray-800 mb-2">Start Admin Theme Getting Started &amp; Installation</a>
																		<div class="fw-bold text-muted">Long before you sit down to put digital pen</div>
																	</div>
																	<!--end::Content-->
																</div>
																<!--end::Item-->
																<!--begin::Item-->
																<div class="d-flex mb-6">
																	<!--begin::Icon-->
																	<div class="me-1">
																		<!--begin::Svg Icon | path: icons/duotune/arrows/arr071.svg-->
																		<span class="svg-icon svg-icon-sm svg-icon-primary">
																			<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																				<path d="M12.6343 12.5657L8.45001 16.75C8.0358 17.1642 8.0358 17.8358 8.45001 18.25C8.86423 18.6642 9.5358 18.6642 9.95001 18.25L15.4929 12.7071C15.8834 12.3166 15.8834 11.6834 15.4929 11.2929L9.95001 5.75C9.5358 5.33579 8.86423 5.33579 8.45001 5.75C8.0358 6.16421 8.0358 6.83579 8.45001 7.25L12.6343 11.4343C12.9467 11.7467 12.9467 12.2533 12.6343 12.5657Z" fill="black" />
																			</svg>
																		</span>
																		<!--end::Svg Icon-->
																	</div>
																	<!--end::Icon-->
																	<!--begin::Content-->
																	<div class="d-flex flex-column">
																		<a href="#" class="fs-6 fw-bolder text-hover-primary text-gray-800 mb-2">Craft a headline that is both informative and will capture</a>
																		<div class="fw-bold text-muted">But nothing can prepare you for the real thing</div>
																	</div>
																	<!--end::Content-->
																</div>
																<!--end::Item-->
																<!--begin::Item-->
																<div class="d-flex mb-6">
																	<!--begin::Icon-->
																	<div class="me-1">
																		<!--begin::Svg Icon | path: icons/duotune/arrows/arr071.svg-->
																		<span class="svg-icon svg-icon-sm svg-icon-primary">
																			<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																				<path d="M12.6343 12.5657L8.45001 16.75C8.0358 17.1642 8.0358 17.8358 8.45001 18.25C8.86423 18.6642 9.5358 18.6642 9.95001 18.25L15.4929 12.7071C15.8834 12.3166 15.8834 11.6834 15.4929 11.2929L9.95001 5.75C9.5358 5.33579 8.86423 5.33579 8.45001 5.75C8.0358 6.16421 8.0358 6.83579 8.45001 7.25L12.6343 11.4343C12.9467 11.7467 12.9467 12.2533 12.6343 12.5657Z" fill="black" />
																			</svg>
																		</span>
																		<!--end::Svg Icon-->
																	</div>
																	<!--end::Icon-->
																	<!--begin::Content-->
																	<div class="d-flex flex-column">
																		<a href="#" class="fs-6 fw-bolder text-hover-primary text-gray-800 mb-2">Write your post, either writing a draft in a single</a>
																		<div class="fw-bold text-muted">Long before you sit down to put pen</div>
																	</div>
																	<!--end::Content-->
																</div>
																<!--end::Item-->
																<!--begin::Item-->
																<div class="d-flex mb-6">
																	<!--begin::Icon-->
																	<div class="me-1">
																		<!--begin::Svg Icon | path: icons/duotune/arrows/arr071.svg-->
																		<span class="svg-icon svg-icon-sm svg-icon-primary">
																			<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																				<path d="M12.6343 12.5657L8.45001 16.75C8.0358 17.1642 8.0358 17.8358 8.45001 18.25C8.86423 18.6642 9.5358 18.6642 9.95001 18.25L15.4929 12.7071C15.8834 12.3166 15.8834 11.6834 15.4929 11.2929L9.95001 5.75C9.5358 5.33579 8.86423 5.33579 8.45001 5.75C8.0358 6.16421 8.0358 6.83579 8.45001 7.25L12.6343 11.4343C12.9467 11.7467 12.9467 12.2533 12.6343 12.5657Z" fill="black" />
																			</svg>
																		</span>
																		<!--end::Svg Icon-->
																	</div>
																	<!--end::Icon-->
																	<!--begin::Content-->
																	<div class="d-flex flex-column">
																		<a href="#" class="fs-6 fw-bolder text-hover-primary text-gray-800 mb-2">Use images to enhance your post, improve its flow</a>
																		<div class="fw-bold text-muted">Long before you sit down to put digital pen</div>
																	</div>
																	<!--end::Content-->
																</div>
																<!--end::Item-->
															</div>
															<!--end::Body-->
														</div>
														<!--end::List Widget 5-->
													</div>
													<!--end::Tutorials-->
												</div>
											</div>
										</div>
									</div>
								</div>
								<!--end::Header Search-->
								<!--begin::Mega Menu-->
								<div class="modal bg-white fade" id="kt_mega_menu_modal" tabindex="-1" aria-hidden="true">
									<div class="modal-dialog modal-fullscreen">
										<div class="modal-content shadow-none">
											<div class="container">
												<div class="modal-header d-flex flex-stack border-0">
													<div class="d-flex align-items-center">
														<!--begin::Logo-->
														<a href="../dist/index.html">
															<img alt="Logo" src="assets/media/logos/logo-default.svg" class="h-30px" />
														</a>
														<!--end::Logo-->
													</div>
													<!--begin::Close-->
													<div class="btn btn-icon btn-sm btn-light-primary ms-2" data-bs-dismiss="modal">
														<!--begin::Svg Icon | path: icons/duotune/arrows/arr061.svg-->
														<span class="svg-icon svg-icon-1">
															<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
																<rect opacity="0.5" x="6" y="17.3137" width="16" height="2" rx="1" transform="rotate(-45 6 17.3137)" fill="black" />
																<rect x="7.41422" y="6" width="16" height="2" rx="1" transform="rotate(45 7.41422 6)" fill="black" />
															</svg>
														</span>
														<!--end::Svg Icon-->
													</div>
													<!--end::Close-->
												</div>
												<div class="modal-body">
													<!--begin::Row-->
													<div class="row py-10 g-5">
														<!--begin::Column-->
														<div class="col-lg-6 pe-lg-25">
															<!--begin::Row-->
															<div class="row">
																<div class="col-sm-4">
																	<h3 class="fw-bolder mb-5">Menú Principal</h3>
																	<ul class="menu menu-column menu-fit menu-rounded menu-gray-600 menu-hover-primary menu-active-primary fw-bold fs-6 mb-10">
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/index.html">Principal</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2 active" href="../dist/dashboards/extended.html">Extended</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/dashboards/light.html">Light</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/dashboards/compact.html">Compact</a>
																		</li>
																	</ul>
																</div>
																<div class="col-sm-4">
																	<h3 class="fw-bolder mb-5">Apps</h3>
																	<ul class="menu menu-column menu-fit menu-rounded menu-gray-600 menu-hover-primary menu-active-primary fw-bold fs-6 mb-10">
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/apps/calendar.html">Calendar</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/apps/chat/private.html">Private Chat</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/apps/chat/group.html">Group Chat</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/apps/chat/drawer.html">Drawer Chat</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/apps/inbox.html">Inbox</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/apps/shop/shop-1.html">Shop 1</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/apps/shop/shop-2.html">Shop 2</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/apps/shop/product.html">Shop Product</a>
																		</li>
																	</ul>
																</div>
																<div class="col-sm-4">
																	<h3 class="fw-bolder mb-5">General</h3>
																	<ul class="menu menu-column menu-fit menu-rounded menu-gray-600 menu-hover-primary menu-active-primary fw-bold fs-6 mb-10">
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/general/faq.html">FAQ</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/general/pricing.html">Pricing</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/general/invoice.html">Invoice</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/general/login.html">Login</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/general/wizard.html">Wizard</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/general/error.html">Error</a>
																		</li>
																	</ul>
																</div>
															</div>
															<!--end::Row-->
															<!--begin::Row-->
															<div class="row">
																<div class="col-sm-4">
																	<h3 class="fw-bolder mb-5">Profile</h3>
																	<ul class="menu menu-column menu-fit menu-rounded menu-gray-600 menu-hover-primary menu-active-primary fw-bold fs-6 mb-10">
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/profile/overview.html">Overview</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/profile/account.html">Account</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/profile/settings.html">Settings</a>
																		</li>
																	</ul>
																</div>
																<div class="col-sm-4">
																	<h3 class="fw-bolder mb-5">Resources</h3>
																	<ul class="menu menu-column menu-fit menu-rounded menu-gray-600 menu-hover-primary menu-active-primary fw-bold fs-6 mb-10">
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/documentation/base/utilities.html">Components</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/documentation/getting-started.html">Documentation</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="https://preview.keenthemes.com/start/layout-builder.html">Layout Builder</a>
																		</li>
																		<li class="menu-item">
																			<a class="menu-link ps-0 py-2" href="../dist/documentation/getting-started/changelog.html">Changelog
																			<span class="badge badge-changelog badge-light-danger bg-hover-danger text-hover-white fw-bold fs-9 px-2 ms-2">v1.0.9</span></a>
																		</li>
																	</ul>
																</div>
															</div>
															<!--end::Row-->
														</div>
														<!--end::Column-->
														<!--begin::Column-->
														<div class="col-lg-6">
															<h3 class="fw-bolder mb-8">Quick Links</h3>
															<!--begin::Row-->
															<div class="row g-5">
																<div class="col-sm-4">
																	<a href="#" class="card bg-light-success hoverable min-h-125px shadow-none mb-5">
																		<div class="card-body d-flex flex-column flex-center">
																			<h3 class="fs-3 mb-2 text-dark fw-bolder">Security</h3>
																			<p class="mb-0 text-gray-600">$2.99/month</p>
																		</div>
																	</a>
																</div>
																<div class="col-sm-4">
																	<a href="#" class="card bg-light-danger hoverable min-h-125px shadow-none mb-5">
																		<div class="card-body d-flex flex-column flex-center text-center">
																			<h3 class="fs-3 mb-2 text-dark fw-bolder">Demo</h3>
																			<p class="mb-0 text-gray-600">Free Version</p>
																		</div>
																	</a>
																</div>
																<div class="col-sm-4">
																	<a href="#" class="card bg-light-warning hoverable min-h-125px shadow-none mb-5">
																		<div class="card-body d-flex flex-column flex-center text-center">
																			<h3 class="fs-3 mb-2 text-dark text-hover-primary fw-bolder">Try Now</h3>
																			<p class="mb-0 text-gray-600">Pro Version</p>
																		</div>
																	</a>
																</div>
															</div>
															<!--end::Row-->
															<!--begin::Row-->
															<div class="row g-5">
																<div class="col-sm-8">
																	<a href="#" class="card bg-light-primary hoverable min-h-125px shadow-none mb-5">
																		<div class="card-body d-flex flex-column flex-center text-center">
																			<h3 class="fs-3 mb-2 text-dark fw-bolder">Payment Methods</h3>
																			<p class="mb-0 text-gray-600">Credit Cards/Debit Cards, Paypal,
																			<br />Transferwise &amp; Others</p>
																		</div>
																	</a>
																	<!--begin::Row-->
																	<div class="row g-5">
																		<div class="col-sm-6">
																			<a class="card bg-light-warning hoverable shadow-none min-h-125px mb-5">
																				<div class="card-body d-flex flex-column flex-center text-center">
																					<h3 class="fs-3 mb-2 text-dark fw-bolder">Support</h3>
																					<p class="mb-0 text-gray-600">6 Month Free</p>
																				</div>
																			</a>
																		</div>
																		<div class="col-sm-6">
																			<a href="#" class="card bg-light-success hoverable shadow-none min-h-125px mb-5">
																				<div class="card-body d-flex flex-column flex-center text-center">
																					<h3 class="fs-3 mb-2 text-dark fw-bolder">Installation</h3>
																					<p class="mb-0 text-gray-600">$0.99 Per Machine</p>
																				</div>
																			</a>
																		</div>
																	</div>
																	<!--end::Row-->
																</div>
																<div class="col-sm-4">
																	<a href="#" class="card card-stretch mb-5 bg-light-info hoverable shadow-none min-h-250px">
																		<div class="card-body d-flex flex-column p-0">
																			<div class="d-flex flex-column flex-grow-1 flex-center text-center px-5 pt-10">
																				<h3 class="fs-3 mb-2 text-dark fw-bolder">Quick Start</h3>
																				<p class="mb-0 text-gray-600">Single Click Import</p>
																			</div>
																			<div class="min-h-125px bgi-no-repeat bgi-size-contain bgi-position-x-center bgi-position-y-bottom card-rounded-bottom" style="background-image:url('assets/media/illustrations/sigma-1/2.png')"></div>
																		</div>
																	</a>
																</div>
															</div>
															<!--end::Row-->
														</div>
														<!--end::Column-->
													</div>
													<!--end::Row-->
												</div>
											</div>
										</div>
									</div>
								</div>
								<!--end::Mega Menu-->
								<!--begin::Drawers-->
								<!--begin::Chat drawer-->
								
								<!--end::Chat drawer-->
								<!--end::Drawers-->
								<!--begin::Scrolltop-->
								<div id="kt_scrolltop" class="scrolltop" data-kt-scrolltop="true">
									<!--begin::Svg Icon | path: icons/duotune/arrows/arr066.svg-->
									<span class="svg-icon">
										<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
											<rect opacity="0.5" x="13" y="6" width="13" height="2" rx="1" transform="rotate(90 13 6)" fill="black" />
											<path d="M12.5657 8.56569L16.75 12.75C17.1642 13.1642 17.8358 13.1642 18.25 12.75C18.6642 12.3358 18.6642 11.6642 18.25 11.25L12.7071 5.70711C12.3166 5.31658 11.6834 5.31658 11.2929 5.70711L5.75 11.25C5.33579 11.6642 5.33579 12.3358 5.75 12.75C6.16421 13.1642 6.83579 13.1642 7.25 12.75L11.4343 8.56569C11.7467 8.25327 12.2533 8.25327 12.5657 8.56569Z" fill="black" />
										</svg>
									</span>
									<!--end::Svg Icon-->
								</div>
								<!--end::Scrolltop-->
								<!--end::Main-->
								<script>var hostUrl = "theme/dist/assets/";</script>
								<!--begin::Javascript-->
								<!--begin::Global Javascript Bundle(used by all pages)-->
							
								<script src="theme/dist/assets/assets/plugins/custom/prismjs/prismjs.bundle.js"></script>
								<script src="theme/dist/assets/assets/js/custom/documentation/documentation.js"></script>
								<script src="theme/dist/assets/assets/js/custom/documentation/search.js"></script>
								<script src="theme/dist/assets/assets/js/custom/documentation/forms/daterangepicker.js"></script>


								<script src="theme/dist/assets/plugins/global/plugins.bundle.js"></script>
								<script src="theme/dist/assets/js/scripts.bundle.js"></script>
								<!--end::Global Javascript Bundle-->
								<!--begin::Page Vendors Javascript(used by this page)-->
								<script src="theme/dist/assets/plugins/custom/leaflet/leaflet.bundle.js"></script>
								<!--end::Page Vendors Javascript-->
								<!--begin::Page Custom Javascript(used by this page)-->
								<script src="theme/dist/assets/js/custom/widgets.js"></script>
								<script src="theme/dist/assets/js/custom/modals/create-app.js"></script>
								<script src="theme/dist/assets/js/custom/modals/select-location.js"></script>
								<script src="theme/dist/assets/js/custom/apps/chat/chat.js"></script>

								<script>
                                    // Add the following code if you want the name of the file appear on select
                                    $(".custom-file-input").on("change", function () {
                                        var fileName = $(this).val().split("\\").pop();
                                        $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
                                    });

                                </script>

								


								<script>
									$("#btnaprobar").click("click", function () {

										var md = $("#processing-modal");
										md.modal('show');


									});

									$("#btnrechazar").click("click", function () {

										var md = $("#processing-modal");
										md.modal('show');


									});

                                </script>

								 <script>
                                     $("#btnregistrar").click("click", function () {

                                         var x = document.getElementById("chkanulado_fisico").checked;
                                         if (x == "0") {
                                             /*La validacion funciona solo si no es para documentos anulados*/
                                             /*alert("tiene check desaactivo");*/

                                             if (document.getElementById("txtNroFisico").value == "") {
                                                 //alert("Ingrese su Nombre para poder continuar");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Ingresar obligatoriamente el Nro. de Documento Físico del Reclamo.");
                                                 md.modal('show');
                                                 return false;
                                             };
                                             if (document.getElementById("txtFechaDocumento").value == "") {
                                                 //alert("Ingrese su Nombre para poder continuar");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Ingresar obligatoriamente la fecha del Nro. de Documento Físico.");
                                                 md.modal('show');
                                                 return false;
                                             };

                                             var mT = document.getElementById("cbomarca");
                                             var M = mT.options[mT.selectedIndex].value;
                                             if (M == 0) {
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Seleccione una Marca para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             }
                                             else {
                                                 var uT = document.getElementById("cbolocal");
                                                 var U = uT.options[uT.selectedIndex].value;
                                                 if (U == 0) {
                                                     //alert("Seleccione una Local para poder continuar");
                                                     var md = $("#modal-validacion");
                                                     $("#lblmensaje").text("Seleccione una Local para poder continuar.");
                                                     md.modal('show');
                                                     return false;
                                                 };
                                             }
                                             //------------------------------------------------------------------
                                             var mD = document.getElementById("cbodistrito");
                                             var D = mD.options[mD.selectedIndex].value;

                                             if (document.getElementById("txtNombre").value == "") {
                                                 //alert("Ingrese su Nombre para poder continuar");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Ingrese su Nombre completo para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             };

                                             if (document.getElementById("txtApellido").value == "") {
                                                 //alert("Ingrese su Nombre para poder continuar");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Ingrese su Apellido completo para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             };
                                             if (document.getElementById("txtDomicilio").value == "") {
                                                 //alert("Ingrese Domicilio para poder continuar");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Ingrese Domicilio para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             };

                                             if (document.getElementById("txtDNI").value == "") {
                                                 //alert("Ingrese su número de DNI para poder continuar");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Ingrese su número de DNI para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             };

                                             if (document.getElementById("txtTelefono").value == "") {
                                                 //alert("Ingrese un teléfono o celular para poder continuar");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Ingrese un teléfono o celular para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             };

                                             if (document.getElementById("txtEmail").value == "") {
                                                 //alert("Ingrese su Email para poder continuar");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Ingrese su Email para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             };

                                             if (validarEmail(document.getElementById("txtEmail").value) == false) {
                                                 //alert("ingrese un Email válido para poder continuar");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Ingrese un Email válido para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             }



                                             //------------------------------------------------------------------------------

                                             var qT = document.getElementById("cboquejareclamo");
                                             var Q = qT.options[qT.selectedIndex].value;

                                             var bT = document.getElementById("cboproducto_servicio");
                                             var B = bT.options[bT.selectedIndex].value;

                                             if (Q == 0) {
                                                 //alert("Seleccione la opción Queja o Reclamo para poder continuar");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Seleccione la opción Queja o Reclamo para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             };

                                             if (document.getElementById("txtDetalle").value == "") {
                                                 //alert("ingrese detalle de su Queja o Reclamo para poder continuar");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Ingrese el detalle de su Queja o Reclamo para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             };

                                             if (B == 0) {
                                                 //alert("Seleccione la opción Producto o Servicio para continuar");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Seleccione la opción Producto o Servicio para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             };

                                             //------------------------------------------------------------------------------
                                             var cT = document.getElementById("cbocanalPedido");
                                             var C = cT.options[cT.selectedIndex].value;


                                             if (C == 0) {
                                                 //alert("Seleccione el canal por el cuál fue atendido para poder continuar.");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Seleccione el canal por el cuál fue atendido para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             };


                                             if (document.getElementById("txtPedido").value == "") {
                                                 //alert("Ingrese el detalle de su pedido para poder continuar.");
                                                 var md = $("#modal-validacion");
                                                 $("#lblmensaje").text("Ingrese el detalle de su pedido para poder continuar.");
                                                 md.modal('show');
                                                 return false;
                                             };


                                             //------------------------------------------------------------------------------
                                             var md = $("#processing-modal");
                                             md.modal('show');

                                         }



                                     });

                                     function validarEmail(valor) {
                                         if (/^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/.test(valor)) {

                                         } else {
                                             return false;
                                         }
                                         return true;
                                     };

                                     function NumCheck(e, field) {
                                         key = e.keyCode ? e.keyCode : e.which
                                         // backspace
                                         if (key == 8) return true
                                         // 0-9
                                         if (key > 47 && key < 58) {
                                             if (field.value == "") return true
                                             regexp = /[0-9]{5}$/
                                             return !(regexp.test(field.value))
                                         }
                                         // .
                                         if (key == 46) {
                                             if (field.value == "") return false
                                             regexp = /^[0-9]+$/
                                             return regexp.test(field.value)
                                         }
                                         // other key
                                         return false

                                     }

                                 </script>
    
								<script>
									// Add the following code if you want the name of the file appear on select
									$(".custom-file-input").on("change", function () {
										var fileName = $(this).val().split("\\").pop();
										$(this).siblings(".custom-file-label").addClass("selected").html(fileName);
									});

								</script>

								<script>
									function cerrarModalEquipos() {
										$('#myModal_busqueda_equipos').modal('hide');
									}
									function cerrarModalProveedor() {
										$('#myModal_busqueda_proveedor').modal('hide');
									}
								</script>

								<script type="text/javascript">
									// Guardar tab activo cuando se cambia
									document.addEventListener("DOMContentLoaded", function () {
										var triggerTabList = [].slice.call(document.querySelectorAll('#myTab button'))
										triggerTabList.forEach(function (triggerEl) {
											triggerEl.addEventListener('shown.bs.tab', function (event) {
												var activeTab = event.target.getAttribute("data-bs-target");
												document.getElementById("<%= hdnActiveTab.ClientID %>").value = activeTab;
											});
										});

										// Restaurar el tab activo después de postback
										var activeTab = document.getElementById("<%= hdnActiveTab.ClientID %>").value;
										if (activeTab) {
											var someTabTriggerEl = document.querySelector('[data-bs-target="' + activeTab + '"]');
											if (someTabTriggerEl) {
												var tab = new bootstrap.Tab(someTabTriggerEl);
												tab.show();
											}
										}
									});
								</script>

								<script>
									function calcularSubtotal(input) {
										// fila actual
										var row = input.closest("tr");

										// buscar controles dentro de esa fila
										var txtCantidad = row.querySelector("input[id*='txtCantidad']");
										var txtPrecio = row.querySelector("input[id*='txtPrecio']");
										var txtSubtotal = row.querySelector("input[id*='txtSubtotal']");

										var cantidad = parseFloat(txtCantidad.value) || 0;
										var precio = parseFloat(txtPrecio.value) || 0;
										var subtotal = cantidad * precio;

										txtSubtotal.value = subtotal.toFixed(2);

										calcularTotalGeneral();
									}

									function calcularTotalGeneral() {
										var total = 0;
										document.querySelectorAll("input[id*='txtSubtotal']").forEach(function (txt) {
											total += parseFloat(txt.value) || 0;
										});
										document.getElementById("lblTotalGeneral").innerText = total.toFixed(2);
									}

									function recalcularSubtotalesEnGrilla() {
										document.querySelectorAll("input[id*='txtCantidad']").forEach(function (input) {
											calcularSubtotal(input);
										});
									}

								</script>

<%--Guardamos valores solo si hay inputs en la fila--%>

<script type="text/javascript">
    (function () {
        var STORAGE_KEY = 'grvItemsCotizacionSnapshot';

        function snapshotGrilla() {
            try {
                var rows = document.querySelectorAll("table[id*='grvItemsCotizacion'] tr");
                var data = [];
                rows.forEach(function (row, idx) {
                    var c = row.querySelector("input[id*='txtCantidad']");
                    var p = row.querySelector("input[id*='txtPrecio']");
                    var s = row.querySelector("input[id*='txtSubtotal']");
                    // Guardamos valores solo si hay inputs en la fila
                    if (c || p || s) {
                        data.push({
                            i: idx,
                            cantidad: c ? c.value : null,
                            precio: p ? p.value : null,
                            subtotal: s ? s.value : null
                        });
                    }
                });
                localStorage.setItem(STORAGE_KEY, JSON.stringify(data));
            } catch (e) {
                console.warn('No se pudo guardar snapshot de la grilla:', e);
            }
        }

        function restoreGrilla() {
            try {
                var data = JSON.parse(localStorage.getItem(STORAGE_KEY) || '[]');
                var rows = document.querySelectorAll("table[id*='grvItemsCotizacion'] tr");
                data.forEach(function (item) {
                    var row = rows[item.i];
                    if (!row) return;
                    var c = row.querySelector("input[id*='txtCantidad']");
                    var p = row.querySelector("input[id*='txtPrecio']");
                    var s = row.querySelector("input[id*='txtSubtotal']");
                    if (c && item.cantidad != null) c.value = item.cantidad;
                    if (p && item.precio != null) p.value = item.precio;
                    if (s && item.subtotal != null) s.value = item.subtotal;
                });
                // Limpia snapshot para no contaminar siguientes posts
                localStorage.removeItem(STORAGE_KEY);

                // Recalcula subtotales y total general con los valores restaurados
                try { recalcularSubtotalesEnGrilla(); } catch (e) { }
            } catch (e) {
                console.warn('No se pudo restaurar la grilla:', e);
            }
        }

        function wireSubmitSnapshot() {
            // Captura el click de cualquier botón/submit que dispare postback
            var submits = document.querySelectorAll("input[type='submit'], button[type='submit']");
            submits.forEach(function (btn) {
                // Evita duplicar handlers
                if (btn._snapshotWired) return;
                btn._snapshotWired = true;

                btn.addEventListener('click', function () {
                    // Antes del postback, guarda los valores actuales
                    snapshotGrilla();
                }, true);
            });
        }

        // Al cargar la página, conectamos los botones y restauramos si hace falta
        document.addEventListener('DOMContentLoaded', function () {
            wireSubmitSnapshot();
            // En caso de volver desde un postback, intenta restaurar
            restoreGrilla();
        });
        window.addEventListener('load', wireSubmitSnapshot);

        // Después de cada postback ASÍNCRONO, restauramos y volvemos a cablear
        if (window.Sys && Sys.WebForms && Sys.WebForms.PageRequestManager) {
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            prm.add_endRequest(function () {
                restoreGrilla();
                wireSubmitSnapshot();
            });
        }

        // Si aparece el modal, también intentamos restaurar
        if (window.jQuery) {
            jQuery(document).on('shown.bs.modal', '#kt_modal_2', restoreGrilla);
        }
    })();
</script>


<%--<script type="text/javascript">
    document.addEventListener('keydown', function (e) {
        // Si la tecla es Enter y el elemento activo es un input tipo texto
        if (e.key === 'Enter' && e.target.tagName === 'INPUT' && e.target.type === 'text') {
            e.preventDefault(); // Bloquea el submit
            return false;
        }
    });
</script>--%>



<script type="text/javascript">
    (function () {
        function bloquearEnterEnInputs() {
            document.querySelectorAll("input[type='text'], input[type='number']").forEach(function (input) {
                if (input._enterBlocked) return; // Evita duplicar
                input._enterBlocked = true;

                input.addEventListener('keydown', function (e) {
                    if (e.key === 'Enter') {
                        e.preventDefault(); // Bloquea el submit
                        return false;
                    }
                });
            });
        }

        // Ejecuta al cargar la página
        document.addEventListener('DOMContentLoaded', bloquearEnterEnInputs);
        window.addEventListener('load', bloquearEnterEnInputs);

        // Si usas UpdatePanel, vuelve a aplicar después de cada postback parcial
        if (window.Sys && Sys.WebForms && Sys.WebForms.PageRequestManager) {
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            prm.add_endRequest(bloquearEnterEnInputs);
        }
    })();
</script>


<script type="text/javascript">
    (function () {
        function seleccionarTextoEnGrilla() {
            // Busca inputs dentro del GridView
            document.querySelectorAll("#<%= grvItemsCotizacion.ClientID %> input[type='text'], #<%= grvItemsCotizacion.ClientID %> input[type='number']").forEach(function (input) {
                if (input._selectOnClick) return; // Evita duplicar
                input._selectOnClick = true;

                input.addEventListener('click', function () {
                    if (!input._wasFocused) {
                        input.select(); // Selecciona todo el texto
                        input._wasFocused = true;
                    }
                });

                input.addEventListener('blur', function () {
                    input._wasFocused = false; // Resetea al perder foco
                });
            });
        }

        // Ejecuta al cargar la página
        document.addEventListener('DOMContentLoaded', seleccionarTextoEnGrilla);
        window.addEventListener('load', seleccionarTextoEnGrilla);

        // Si usas UpdatePanel, vuelve a aplicar después de cada postback parcial
        if (window.Sys && Sys.WebForms && Sys.WebForms.PageRequestManager) {
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            prm.add_endRequest(seleccionarTextoEnGrilla);
        }
    })();
</script>


							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</body>
</html>
