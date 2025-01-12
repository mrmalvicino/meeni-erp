<%@ Page Title="Signup" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WebForms.Signup" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
    <link href="style/Signup.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <section class="height-100-vh col-flex space-evenly">
        <h1 class="margin-top-60-px">Registrar empresa</h1>
        <div class="signup-div">
            <div>
                <label for="PricingPlansDDL">Plan</label>
                <asp:DropDownList
                    ID="PricingPlansDDL"
                    runat="server"
                    class="width-100-pct transparent-input">
                </asp:DropDownList>
            </div>
            <div>
                <label for="OrganizationTxt">Organización</label>
                <asp:TextBox
                    ID="OrganizationNameTxt"
                    runat="server"
                    TextMode="SingleLine"
                    class="width-100-pct transparent-input"
                    placeholder="Nombre de tu empresa">
                </asp:TextBox>
            </div>
            <div>
                <label for="UsernameTxt">Usuario</label>
                <asp:TextBox
                    ID="UsernameTxt"
                    runat="server"
                    TextMode="SingleLine"
                    class="width-100-pct transparent-input"
                    placeholder="Ingresá un usuario">
                </asp:TextBox>
            </div>
            <div>
                <label for="PasswordTxt">Contraseña</label>
                <asp:TextBox
                    ID="PasswordTxt"
                    runat="server"
                    TextMode="Password"
                    class="width-100-pct transparent-input"
                    placeholder="Ingresá una contraseña">
                </asp:TextBox>
            </div>
            <div class="margin-top-20-px">
                <asp:Button ID="SignupBtn" runat="server" Text="Registrarse" class="small-dark-button width-100-pct" OnClick="SignupBtn_Click" />
            </div>
        </div>
    </section>
</asp:Content>
