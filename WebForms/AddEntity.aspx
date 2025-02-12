<%@ Page Title="Add Entity" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddEntity.aspx.cs" Inherits="WebForms.AddEntity" %>

<%@ Register Src="~/UserControls/EntityNameFields.ascx" TagPrefix="uc" TagName="EntityNameFields" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <h1 id="title" runat="server">Agregar nuevo registro</h1>
        <div class="container-div small-box-width mid-box-height margin-10-px">
            <div id="IsOrganizationDiv" runat="server" class="row-flex">
                <asp:CheckBox
                    ID="IsOrganizationChk"
                    runat="server"
                    class="input-checkbox"
                    AutoPostBack="true"
                    OnCheckedChanged="IsOrganizationChk_CheckedChanged" />
                <label for="IsOrganizationChk">Es organización</label>
            </div>
            <uc:EntityNameFields ID="EntityNameFieldsUC" runat="server" />
            <div class="margin-top-20-px">
                <asp:LinkButton
                    ID="SaveBtn"
                    runat="server"
                    class="dark-button width-100-pct"
                    OnClick="SaveBtn_Click">
                    <i class="bi bi-floppy"></i>
                    <span>Guardar</span>
                </asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
