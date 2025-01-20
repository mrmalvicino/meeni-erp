<%@ Page Title="Login" Language="C#" MasterPageFile="~/Landing.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="LandingHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="LandingMainPlaceHolder" runat="server">
    <section class="height-100-vh col-flex space-evenly">
        <div class="site-menu-height"></div>
        <h1>Iniciar sesión</h1>
        <div class="container-div width-300-px height-300-px margin-bottom-20-px">
            <div>
                <label for="UsernameTxt">Usuario</label>
                <asp:TextBox
                    ID="UsernameTxt"
                    runat="server"
                    TextMode="SingleLine"
                    class="width-100-pct input-box"
                    placeholder="Ingresá tu usuario">
                </asp:TextBox>
            </div>
            <div>
                <label for="PasswordTxt">Contraseña</label>
                <asp:TextBox
                    ID="PasswordTxt"
                    runat="server"
                    TextMode="Password"
                    class="width-100-pct input-box"
                    placeholder="Ingresá tu contraseña">
                </asp:TextBox>
            </div>
            <div class="margin-top-20-px">
                <asp:Button ID="LoginBtn" runat="server" Text="Ingresar" class="dark-button width-100-pct" OnClick="LoginBtn_Click" />
            </div>
        </div>
    </section>
</asp:Content>
