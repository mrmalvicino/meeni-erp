<%@ Page Title="Meeni ERP" Language="C#" MasterPageFile="~/Landing.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebForms.Home" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="LandingHeadPlaceHolder" runat="server">
    <link href="style/home-containers.css" rel="stylesheet" />
    <link href="style/home-ids.css" rel="stylesheet" />
    <link href="style/home-responsive.css" rel="stylesheet" />
    <link href="style/banner.css" rel="stylesheet" />
    <link href="style/whatsapp.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="LandingMainPlaceHolder" runat="server">

    <!-- Hero Section -->

    <section id="heroSec" class="height-100-vh space-evenly">
        <div class="col-flex width-90-pct">
            <h1 class="margin-20-0-px">Software de gestión&nbsp;empresarial <span class="bold-text">Meeni&nbsp;ERP</span></h1>
            <p class="center-text margin-bottom-20-px">Una solución eficiente para gestionar tu negocio desde cualquier lugar.</p>
        </div>
        <a class="cta-button big-hover" href="#pricingSec">Comenzá ahora</a>
    </section>

    <!-- Sección de funcionalidades -->

    <section id="featuresSec" class="height-100-vh space-evenly">
        <div class="col-flex width-90-pct">
            <h2 class="margin-20-0-px">Simple, libre y eficaz</h2>
            <p class="center-text margin-bottom-20-px">Meeni ERP es un software de código abierto que te ayuda a gestionar tu empresa con facilidad desde cualquier dispositivo con conexión a internet.</p>
        </div>
        <div class="row-flex space-around width-90-pct">
            <div class="width-50-pct">
                <img data-image-id="mockupImg" />
            </div>
            <div class="col-flex space-around margin-bottom-10-px">
                <div class="feature-card">
                    <div class="row-flex justify-center width-100-pct">
                        <i class="bi bi-cart font-size-40-px margin-10-px"></i>
                        <h3>Gestión de cotizaciones</h3>
                    </div>
                    <p>Realizá cotizaciones eficientemente.</p>
                </div>
                <div class="feature-card">
                    <div class="row-flex justify-center width-100-pct">
                        <i class="bi bi-truck font-size-40-px margin-10-px"></i>
                        <h3>Gestión de inventarios</h3>
                    </div>
                    <p>Controlá los niveles de stock.</p>
                </div>
                <div class="feature-card">
                    <div class="row-flex justify-center width-100-pct">
                        <i class="bi bi-cash font-size-40-px margin-10-px"></i>
                        <h3>Registro de transacciones</h3>
                    </div>
                    <p>Monitoreá las compras y ventas.</p>
                </div>
            </div>
        </div>
    </section>

    <!-- Banner Section -->

    <section id="customersSec" class="background-1">
        <div class="col-flex width-90-pct padding-top-40-px">
            <h2 class="margin-20-0-px">Marcas que nos eligen</h2>
        </div>
        <div class="banner-container">
            <%
                for (int i = 0; i < 3; i++)
                {
            %>
            <div class="banner-slide">
                <div class="width-40-px"></div>
                <div class="width-100-px margin-20-px">
                    <img data-image-id="mokaImg" />
                </div>
                <div class="width-80-px"></div>
                <div class="width-100-px margin-20-px">
                    <img data-image-id="MMRSonidoImg" />
                </div>
                <div class="width-80-px"></div>
                <div class="width-100-px margin-20-px">
                    <img data-image-id="GSElectronicaImg" />
                </div>
                <div class="width-80-px"></div>
                <div class="width-100-px margin-20-px">
                    <img data-image-id="pisosClickImg" />
                </div>
                <div class="width-40-px"></div>
            </div>
            <%
                }


            %>
        </div>
    </section>

    <!-- Pricing Section -->

    <section id="pricingSec" class="height-100-vh space-evenly">
        <div class="width-90-pct col-flex justify-center">
            <h2 class="margin-20-0-px">Un plan para cada organización</h2>
            <div class="width-100-pct row-flex space-evenly">
                <div class="pricing-card">
                    <h3><%= PricingPlans[0].Name %></h3>
                    <ul>
                        <li>
                            <span>
                                <i class="bi bi-check"></i>
                            </span>
                            Plataforma sin publicidades
                        </li>
                        <li>
                            <span>
                                <i class="bi bi-check"></i>
                            </span>
                            Base de datos de 100 MB
                        </li>
                        <li>
                            <span>
                                <i class="bi bi-check"></i>
                            </span>
                            Soporte para reporte de errores
                        </li>
                    </ul>
                    <h4>¡Accedé a todas las funcionalidades sin costo!</h4>
                    <a
                        class="dark-button big-hover width-90-pct"
                        href="Signup.aspx?pricingPlanId=<%= PricingPlans[0].Id %>">
                        <span>USD $<%= PricingPlans[0].MonthlyFee.ToString("F2") %> / mes</span>
                    </a>
                </div>
                <div class="pricing-card">
                    <h3><%= PricingPlans[1].Name %></h3>
                    <ul>
                        <li>
                            <span>
                                <i class="bi bi-check"></i>
                            </span>
                            Todo lo del plan gratuito
                        </li>
                        <li>
                            <span>
                                <i class="bi bi-check"></i>
                            </span>
                            Base de datos de 500 MB
                        </li>
                        <li>
                            <span>
                                <i class="bi bi-check"></i>
                            </span>
                            Soporte para consultas técnicas
                        </li>
                    </ul>
                    <h4>¡Impulsá tu negocio en crecimiento!</h4>
                    <a
                        class="dark-button big-hover width-90-pct"
                        href="Signup.aspx?pricingPlanId=<%= PricingPlans[1].Id %>">
                        <span>USD $<%= PricingPlans[1].MonthlyFee.ToString("F2") %> / mes</span>
                    </a>
                </div>
                <div class="pricing-card">
                    <h3><%= PricingPlans[2].Name %></h3>
                    <ul>
                        <li>
                            <span>
                                <i class="bi bi-check"></i>
                            </span>
                            Todo lo del plan profesional
                        </li>
                        <li>
                            <span>
                                <i class="bi bi-check"></i>
                            </span>
                            Base de datos de 3 GB
                        </li>
                        <li>
                            <span>
                                <i class="bi bi-check"></i>
                            </span>
                            Soporte para modificaciones
                        </li>
                    </ul>
                    <h4>¡Destacá en el mercado con funcionalidades extra!</h4>
                    <a
                        class="dark-button big-hover width-90-pct"
                        href="Signup.aspx?pricingPlanId=<%= PricingPlans[2].Id %>">
                        <span>USD $<%= PricingPlans[2].MonthlyFee.ToString("F2") %> / mes</span>
                    </a>
                </div>
            </div>
        </div>
    </section>

    <!-- WhatsApp Button -->

    <div class="whatsapp-button">
        <a href="https://wa.me/5491159058729?text=Hola,%20quiero%20hacer%20una%20consulta sobre Meeni ERP." target="_blank">
            <img data-image-id="whatsappImg">
        </a>
    </div>
</asp:Content>
