<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="main2.aspx.vb" Inherits="ARMantenimiento.main2" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>Sistema ARmanto</title>
<meta charset="utf-8" />
<meta name="description" content="Sistema ARManto - Acurio Restaurantes" />
<meta name="keywords" content="Sistema de Mantenimiento en Acurio Restaurantes" />
<meta name="viewport" content="width=device-width, initial-scale=1" />
<meta property="og:locale" content="en_US" />
<meta property="og:type" content="article" />
<meta property="og:title" content="Sistema ARManto" />
<meta property="og:url" content="https://themes.getbootstrap.com/product/start-multipurpose-admin-dashboard-theme/" />
<meta property="og:site_name" content="Keenthemes | Start" />
<link rel="canonical" href="https://preview.keenthemes.com/start" />
<link rel="shortcut icon" href="images/images_sistema/icono.ico" />
<!--begin::Fonts-->
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700" />
<!--end::Fonts-->
<!--begin::Page Vendor Stylesheets(used by this page)-->
<link href="theme/dist/assets/plugins/custom/leaflet/leaflet.bundle.css" rel="stylesheet" type="text/css" />
<!--end::Page Vendor Stylesheets-->
<!--begin::Global Stylesheets Bundle(used by all pages)-->
<link href="theme/dist/assets/plugins/global/plugins.bundle.css" rel="stylesheet" type="text/css" />

<link href="theme/dist/assets/css/style.bundle.css" rel="stylesheet" type="text/css" />
<!--end::Global Stylesheets Bundle-->

</head>
	<body id="kt_body" data-sidebar="on" class="header-fixed header-tablet-and-mobile-fixed sidebar-enabled" style="background: linear-gradient(to right, #540f4a, #975a89);">
		<div class="container w-lg-1200px">
				<div class="modal-body">
				
					<div class="py-10">
				<%--		<h2 class="fw-bolder mb-8">Sistema ARManto</h2>--%>
						<asp:Label ID="lbltituloSistema" runat="server" Text="Sistema ARManto" class="fw-bolder mb-8" Font-Size="Large" ForeColor="White"></asp:Label>
						<br />
						<br />
						<asp:Label ID="Label1" runat="server" Text="Menú Principal" class="mb-8" ForeColor="White"></asp:Label>
						<br />
						<br />
					<%--	<h6 class="fw-bolder mb-8">Menú Principal</h6>--%>
						<!--begin::Row-->
						<div class="row g-5">
							<!-- Columna izquierda -->
							<div class="col-sm-6">
											<div class="card card-stretch overlay mb-5 shadow-none min-h-250px">
															<div class="card-body d-flex flex-column p-0">
																<div class="overlay-wrapper flex-grow-1 card-rounded 
																			d-flex flex-column align-items-center justify-content-center text-center px-3" 
																		style="background-color:#975a89; min-height:250px;">

																	<!-- Imagen PNG como ícono -->
																	<img src="images/images_sistema/nuevo_aviso.png" 
																			alt="Nuevo Aviso" 
																			style="width:60px; height:60px; margin-bottom:10px" />

																	<!-- Título -->
																	<span class="text-black fs-5 mb-2">
																		¿Desea crear un nuevo Aviso?
																	</span>

																	<!-- Descripción -->
																	<span class="text-white fs-6">
																		<%--Tiene alguna incidencia dentro del local.  
																		Entonces debe crear un aviso para administrar su caso.--%>
																	</span>

																	<!-- Link invisible -->
																	<a href="NuevoAviso.aspx" class="stretched-link"></a>
																</div>
																<div class="overlay-layer bg-white bg-opacity-25 card-rounded"></div>
															</div>
											</div>
							</div>

							<!-- Columna derecha -->
							<div class="col-sm-6">
								<div class="row g-5">
									<!-- Card grande mantenimiento -->
									<div class="col-sm-6">
													<div class="card card-stretch overlay mb-5 shadow-none min-h-250px">
																	<div class="card-body d-flex flex-column p-0">
																		<div class="overlay-wrapper flex-grow-1 card-rounded 
																					d-flex flex-column align-items-center justify-content-center text-center px-3" 
																			 style="background-color:#ebe6e5; min-height:250px;">

																			<!-- Ícono/imagen -->
																			<img src="images/images_sistema/mantenimiento_avisos.png" 
																				 alt="Mantenimiento" 
																				 style="width:50px; height:50px; margin-bottom:10px" />

																			<!-- Texto -->
																			<span class="text-black  fs-5 mb-2">Mantenimiento de Avisos</span>

																			<!-- Link -->
																			<a href="MantenimientoAvisos.aspx" class="stretched-link"></a>
																		</div>
																		<div class="overlay-layer bg-white bg-opacity-25 card-rounded"></div>
																	</div>
													</div>
									</div>
									<!-- Card pequeño 1 -->
									<div class="col-sm-6">
										<div class="card overlay min-h-125px mb-5 shadow-none">
											<div class="card-body d-flex flex-column p-0">
												<div class="overlay-wrapper flex-grow-1 card-rounded 
															d-flex flex-column align-items-center justify-content-center text-center px-2" 
													 style="background-color:#534a4b; min-height:125px;">

													<!-- Ícono/imagen -->
													<img src="images/images_sistema/report_excel.png" 
														 alt="Explorar" 
														 style="width:35px; height:35px; margin-bottom:5px; filter: brightness(0) invert(1);" />

													<!-- Texto -->
													<span class="text-white fs-6">Reportes</span>

													<!-- Link -->
													<a href="Explorar.aspx" class="stretched-link"></a>
												</div>
												<div class="overlay-layer bg-white bg-opacity-25 card-rounded"></div>
											</div>
										</div>

										<!-- Card pequeño 2 -->
										<div class="card overlay min-h-125px mb-5 shadow-none">
											<div class="card-body d-flex flex-column p-0">
												<div class="overlay-wrapper flex-grow-1 card-rounded 
															d-flex flex-column align-items-center justify-content-center text-center px-2" 
													 style="background-color:#540f4a; min-height:125px;">

													<!-- Ícono/imagen -->
													<img src="images/images_sistema/report_bi.png" 
														 alt="Explore" 
														 style="width:35px; height:35px; margin-bottom:5px; filter: brightness(0) invert(1);" />

													<!-- Texto -->
													<span class="text-white  fs-6">Analítica</span>

													<!-- Link -->
													<a href="Explorar2.aspx" class="stretched-link"></a>
												</div>
												<div class="overlay-layer bg-white bg-opacity-25 card-rounded"></div>
											</div>
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
						<asp:Label ID="Label2" runat="server" Text="Listado de Movimientos" class="mb-8" ForeColor="White"></asp:Label>
						<!--begin::List Widget 4-->
						<div class="card bg-transparent mb-5 shadow-none">
							<!--begin::Body-->
							<div class="card-body pt-2 px-0">
								<div class="table-responsive">
									
								</div>
							</div>
							<!--end::Body-->
						</div>
						<!--end::List Widget 4-->
					</div>
					<!--end::Framework Users-->

				</div>
</div>
	</body>
</html>