<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddressFields.ascx.cs" Inherits="WebForms.UserControls.AddressFields" %>

<div class="container-div small-box-width big-box-height margin-10-px">
    <p class="center-text">Domicilio</p>
    <div>
        <label for="StreetNameTxt">Calle</label>
        <asp:TextBox
            ID="StreetNameTxt"
            runat="server"
            TextMode="SingleLine"
            class="width-100-pct input-box"
            placeholder="Calle">
        </asp:TextBox>
    </div>
    <div class="row-flex space-between">
        <div class="width-120-px">
            <label for="StreetNumberTxt">Número</label>
            <asp:TextBox
                ID="StreetNumberTxt"
                runat="server"
                TextMode="Number"
                class="width-100-pct input-box"
                placeholder="Número">
            </asp:TextBox>
        </div>
        <div class="width-120-px">
            <label for="FlatTxt">Depto.</label>
            <asp:TextBox
                ID="FlatTxt"
                runat="server"
                TextMode="SingleLine"
                class="width-100-pct input-box"
                placeholder="Depto.">
            </asp:TextBox>
        </div>
    </div>
    <div>
        <label for="DetailsTxt">Detalles</label>
        <asp:TextBox
            ID="DetailsTxt"
            runat="server"
            TextMode="SingleLine"
            class="width-100-pct input-box"
            placeholder="Información adicional">
        </asp:TextBox>
    </div>
    <div class="row-flex space-between">
        <div class="width-120-px">
            <label for="CityTxt">Localidad</label>
            <asp:TextBox
                ID="CityTxt"
                runat="server"
                TextMode="SingleLine"
                class="width-100-pct input-box"
                placeholder="Localidad">
            </asp:TextBox>
        </div>
        <div class="width-120-px">
            <label for="ZipCodeTxt">C.P.</label>
            <asp:TextBox
                ID="ZipCodeTxt"
                runat="server"
                TextMode="SingleLine"
                class="width-100-pct input-box"
                placeholder="Cód. Postal">
            </asp:TextBox>
        </div>
    </div>
    <div>
        <label for="ProvinceTxt">Provincia</label>
        <asp:TextBox
            ID="ProvinceTxt"
            runat="server"
            TextMode="SingleLine"
            class="width-100-pct input-box"
            placeholder="Provincia">
        </asp:TextBox>
    </div>
    <div>
        <label for="CountryTxt">País</label>
        <asp:TextBox
            ID="CountryTxt"
            runat="server"
            TextMode="SingleLine"
            class="width-100-pct input-box"
            placeholder="País">
        </asp:TextBox>
    </div>
</div>