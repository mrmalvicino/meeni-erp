<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EditEntity.ascx.cs" Inherits="WebForms.UserControls.EditEntity" %>

<%@ Register Src="~/UserControls/EntityName.ascx" TagPrefix="uc" TagName="EntityName" %>
<%@ Register Src="~/UserControls/AddressFields.ascx" TagPrefix="uc" TagName="AddressFields" %>

<!-- Imagen -->

<div class="container-div small-box-width big-box-height margin-10-px">
    <p class="center-text">Imagen</p>
    <div class="width-100-pct">
        <asp:Image ID="EntityImg" runat="server" class="fit-image circle-border" />
    </div>
    <div>
        <label for="ImageURLTxt">URL de imagen</label>
        <asp:TextBox
            ID="ImageURLTxt"
            runat="server"
            TextMode="SingleLine"
            class="width-100-pct input-box"
            placeholder="URL de la imagen"
            AutoPostBack="true">
        </asp:TextBox>
    </div>
    <div class="col-flex">
        <a href="https://imgur.com/upload" target="_blank" rel="noopener noreferrer" class="light-button">
            <i class="bi bi-upload"></i>
            <span>Subir a Imgur</span>
        </a>
    </div>
</div>

<!-- Identificación -->

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

    <uc:EntityName ID="EntityNameUC" runat="server" />

    <div class="row-flex space-between">
        <div class="width-120-px">
            <label for="IdentificationCodeTxt">Código fiscal</label>
            <asp:TextBox
                ID="IdentificationCodeTxt"
                runat="server"
                TextMode="SingleLine"
                class="width-100-pct input-box"
                placeholder="Número">
            </asp:TextBox>
        </div>
        <div class="width-120-px">
            <label for="IdentificationTypesDDL">Tipo</label>
            <asp:DropDownList
                ID="IdentificationTypesDDL"
                runat="server"
                class="input-box width-100-pct">
            </asp:DropDownList>
        </div>
    </div>
    <div>
        <label for="BirthDateTxt">Fecha de nacimiento</label>
        <asp:TextBox
            ID="BirthDateTxt"
            runat="server"
            TextMode="Date"
            class="width-100-pct input-box">
        </asp:TextBox>
    </div>
    <div>
        <label for="EmailTxt">Email</label>
        <asp:TextBox
            ID="EmailTxt"
            runat="server"
            TextMode="Email"
            class="width-100-pct input-box"
            placeholder="Email de tu empresa">
        </asp:TextBox>
    </div>
    <div>
        <label for="PhoneTxt">Teléfono</label>
        <asp:TextBox
            ID="PhoneTxt"
            runat="server"
            TextMode="Number"
            class="width-100-pct input-box"
            placeholder="Teléfono de tu empresa">
        </asp:TextBox>
    </div>
</div>

<uc:AddressFields ID="AddressFieldsUC" runat="server" />