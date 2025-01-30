<%@ Page Title="View Organization" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EditPartner.aspx.cs" Inherits="WebForms.EditPartner" %>

<%@ Register Src="~/UserControls/EditEntity.ascx" TagPrefix="uc" TagName="EditEntity" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <h1>Datos de entidad</h1>
        <div class="wrapped-flex justify-center">
            <uc:EditEntity runat="server" ID="EditEntityUC" />
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
