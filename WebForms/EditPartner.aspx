<%@ Page Title="Edit Partner" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EditPartner.aspx.cs" Inherits="WebForms.EditPartner" %>

<%@ Register Src="~/UserControls/EntityContainers.ascx" TagPrefix="uc" TagName="EntityContainers" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <h1>Datos del socio comercial</h1>
        <div class="wrapped-flex justify-center">
            <uc:EntityContainers ID="EntityContainersUC" runat="server" />

            <!-- Tipo -->

            <div class="container-div small-box-width small-box-height margin-10-px">
                <p class="center-text">Tipo de socio comercial</p>
                <div>
                    <div class="row-flex">
                        <asp:CheckBox ID="IsClientChk" runat="server" class="input-checkbox" />
                        <label for="IsClientChk">Cliente</label>
                    </div>
                    <div class="row-flex">
                        <asp:CheckBox ID="IsSupplierChk" runat="server" class="input-checkbox" />
                        <label for="IsSupplierChk">Proveedor</label>
                    </div>
                </div>
            </div>

        </div>

        <!-- Botones -->

        <div class="wrapped-flex justify-center">
            <div class="margin-10-px">
                <asp:Button
                    ID="SaveBtn"
                    runat="server"
                    Text="Guardar cambios"
                    class="dark-button big-hover"
                    OnClick="SaveBtn_Click" />
            </div>
        </div>
    </div>
</asp:Content>
