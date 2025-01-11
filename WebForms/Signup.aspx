<%@ Page Title="Signup" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WebForms.Signup" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
    <link href="style/Signup.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <section class="height-100-vh col-flex space-evenly">
        <h1 class="margin-top-60-px">Registrar empresa</h1>
        <div class="signup-div">
            <div>
                <label for="organizationTxt">Organización</label>
                <asp:TextBox
                    ID="organizationTxt"
                    runat="server"
                    TextMode="SingleLine"
                    class="width-100-pct transparent-input"
                    placeholder="Nombre de tu empresa">
                </asp:TextBox>
            </div>
            <div>
                <label for="usernameTxt">Usuario</label>
                <asp:TextBox
                    ID="usernameTxt"
                    runat="server"
                    TextMode="SingleLine"
                    class="width-100-pct transparent-input"
                    placeholder="Ingresá un usuario">
                </asp:TextBox>
            </div>
            <div>
                <label for="passwordTxt">Contraseña</label>
                <asp:TextBox
                    ID="passwordTxt"
                    runat="server"
                    TextMode="Password"
                    class="width-100-pct transparent-input"
                    placeholder="Ingresá una contraseña">
                </asp:TextBox>
            </div>
            <div>
                <label for="pricingPlansDDL">Plan</label>
                <asp:DropDownList
                    ID="pricingPlansDDL"
                    runat="server"
                    class="width-100-pct transparent-input">
                </asp:DropDownList>
            </div>
            <div class="margin-top-20-px">
                <asp:Button ID="loginBtn" runat="server" Text="Registrarse" class="small-dark-button width-100-pct" />
            </div>
        </div>
    </section>
</asp:Content>
