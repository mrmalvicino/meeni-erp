<%@ Page Title="View Organization" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EditEntity.aspx.cs" Inherits="WebForms.EditEntity" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <h1>Datos de entidad</h1>
        <div class="wrapped-flex justify-center">

            <!-- Imagen -->

            <div class="container-div width-300-px height-520-px margin-10-px">
                <p class="center-text">Imagen</p>
                <div class="width-100-pct">
                    <asp:Image ID="EntityImg" runat="server" class="fit-image circle-border" />
                </div>
                <label for="ImageURLTxt">URL de imagen</label>
                <asp:TextBox
                    ID="ImageURLTxt"
                    runat="server"
                    TextMode="SingleLine"
                    class="width-100-pct input-box"
                    placeholder="URL de imagen"
                    AutoPostBack="true">
                </asp:TextBox>
            </div>

            <div class="col-flex space-between height-520-px margin-10-px">

                <!-- Identificación fiscal -->

                <div class="container-div width-300-px height-250-px">
                    <p class="center-text">Identificación fiscal</p>
                    <div>
                        <label for="NameTxt">Nombre</label>
                        <asp:TextBox
                            ID="NameTxt"
                            runat="server"
                            TextMode="SingleLine"
                            class="width-100-pct input-box"
                            placeholder="Nombre">
                        </asp:TextBox>
                    </div>
                    <div>
                        <label for="TaxCodeTxt">CUIT</label>
                        <asp:TextBox
                            ID="TaxCodeTxt"
                            runat="server"
                            TextMode="Number"
                            class="width-100-pct input-box"
                            placeholder="CUIT de la empresa">
                        </asp:TextBox>
                    </div>
                </div>

                <!-- Contacto -->

                <div class="container-div width-300-px height-250-px">
                    <p class="center-text">Contacto</p>
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
            </div>

            <!-- Domicilio -->

            <div class="container-div width-300-px height-520-px margin-10-px">
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
