<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EntityContainers.ascx.cs" Inherits="WebForms.UserControls.EntityContainers" %>

<%@ Register Src="~/UserControls/ImageContainer.ascx" TagPrefix="uc" TagName="ImageContainer" %>
<%@ Register Src="~/UserControls/EntityNameFields.ascx" TagPrefix="uc" TagName="EntityNameFields" %>
<%@ Register Src="~/UserControls/IdentificationFields.ascx" TagPrefix="uc" TagName="IdentificationFields" %>
<%@ Register Src="~/UserControls/ContactFields.ascx" TagPrefix="uc" TagName="ContactFields" %>
<%@ Register Src="~/UserControls/AddressContainer.ascx" TagPrefix="uc" TagName="AddressContainer" %>

<uc:ImageContainer ID="ImageContainerUC" runat="server" />

<div class="container-div small-box-width big-box-height margin-10-px">
    <p class="center-text">Identificación</p>
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
    <uc:IdentificationFields ID="IdentificationFieldsUC" runat="server" />
    
    <div>
        <label for="BirthDateTxt">Fecha de nacimiento</label>
        <asp:TextBox
            ID="BirthDateTxt"
            runat="server"
            TextMode="Date"
            class="width-100-pct input-box">
        </asp:TextBox>
    </div>

    <uc:ContactFields ID="ContactFieldsUC" runat="server" />
</div>

<uc:AddressContainer ID="AddressContainerUC" runat="server" />