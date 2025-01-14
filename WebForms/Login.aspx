<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="SiteHeadPlaceHolder" runat="server">
    <link href="style/Login.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="SiteBodyPlaceHolder" runat="server">
    <section class="height-100-vh col-flex space-evenly">
        <h1>Iniciar sesión</h1>
        <div class="login-div">
            <div>
                <label for="UsernameTxt">Usuario</label>
                <asp:TextBox
                    ID="UsernameTxt"
                    runat="server"
                    TextMode="SingleLine"
                    class="width-100-pct transparent-input"
                    placeholder="Ingresá tu usuario">
                </asp:TextBox>
            </div>
            <div>
                <label for="PasswordTxt">Contraseña</label>
                <asp:TextBox
                    ID="PasswordTxt"
                    runat="server"
                    TextMode="Password"
                    class="width-100-pct transparent-input"
                    placeholder="Ingresá tu contraseña">
                </asp:TextBox>
            </div>
            <div class="margin-top-20-px">
                <asp:Button ID="LoginBtn" runat="server" Text="Ingresar" class="small-dark-button width-100-pct" OnClick="LoginBtn_Click" />
            </div>
        </div>
    </section>
</asp:Content>
