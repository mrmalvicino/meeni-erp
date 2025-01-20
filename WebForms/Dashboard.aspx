<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebForms.Dashboard" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <h1>Estadísticas de la empresa</h1>
        <div class="grid-2-cols width-100-pct">
            <div class="container-div margin-10-px">
                <h3>Cotizaciones hechas</h3>
            </div>
            <div class="container-div margin-10-px">
                <h3>Ventas concretadas</h3>
            </div>
        </div>
        <div class="grid-1-cols width-100-pct">
            <div class="container-div margin-10-px height-300-px">
                <h3>Gráficos</h3>
            </div>
        </div>
        <div class="grid-2-cols width-100-pct">
            <div class="container-div margin-10-px">
                <h3>Facturación bruta</h3>
            </div>
            <div class="container-div margin-10-px">
                <h3>Ganancia neta</h3>
            </div>
        </div>
        <div class="grid-3-cols width-100-pct">
            <div class="container-div margin-10-px">
                <h3>Clientes Activos</h3>
            </div>
            <div class="container-div margin-10-px">
                <h3>Patrimonio</h3>
            </div>
            <div class="container-div margin-10-px">
                <h3>Stock</h3>
            </div>
        </div>
    </div>
</asp:Content>
