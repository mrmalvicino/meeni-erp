<%@ Page Title="Settings" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="WebForms.Settings" %>

<%@ Register Src="~/UserControls/EntityContainers.ascx" TagPrefix="uc" TagName="EntityContainers" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <h1>Datos de la empresa</h1>
        <div class="wrapped-flex justify-center">
            <uc:EntityContainers ID="EntityContainersUC" runat="server" />
        </div>

        <!-- Botones -->

        <div class="wrapped-flex justify-center">
            <div class="margin-10-px">
                <asp:LinkButton
                    ID="SaveBtn"
                    runat="server"
                    class="dark-button big-hover"
                    OnClick="SaveBtn_Click">
                    <i class="bi bi-floppy"></i>
                    <span>Guardar</span>
                </asp:LinkButton>
            </div>
            <div class="margin-10-px">
                <asp:LinkButton
                    ID="DeleteBtn"
                    runat="server"
                    class="danger-button big-hover"
                    OnClick="DeleteBtn_Click">
                    <i class="bi bi-trash3"></i>
                    <span>Eliminar</span>
                </asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
