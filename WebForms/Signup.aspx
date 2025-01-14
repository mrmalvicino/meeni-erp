﻿<%@ Page Title="Signup" Language="C#" MasterPageFile="~/Landing.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WebForms.Signup" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="LandingHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="LandingMainPlaceHolder" runat="server">
    <section class="height-100-vh col-flex space-evenly">
        <div class="site-menu-height"></div>
        <h1>Registrar empresa</h1>
        <div class="container-div width-300-px height-500-px">
            <div>
                <label for="PricingPlansDDL">Plan</label>
                <asp:DropDownList
                    ID="PricingPlansDDL"
                    runat="server"
                    class="width-100-pct input-box">
                </asp:DropDownList>
            </div>
            <div>
                <label for="OrganizationTxt">Organización</label>
                <asp:TextBox
                    ID="OrganizationNameTxt"
                    runat="server"
                    TextMode="SingleLine"
                    class="width-100-pct input-box"
                    placeholder="Nombre de tu empresa">
                </asp:TextBox>
            </div>
            <div>
                <label for="UsernameTxt">Usuario</label>
                <asp:TextBox
                    ID="UsernameTxt"
                    runat="server"
                    TextMode="SingleLine"
                    class="width-100-pct input-box"
                    placeholder="Ingresá un usuario">
                </asp:TextBox>
            </div>
            <div>
                <label for="PasswordTxt">Contraseña</label>
                <asp:TextBox
                    ID="PasswordTxt"
                    runat="server"
                    TextMode="Password"
                    class="width-100-pct input-box"
                    placeholder="Ingresá una contraseña">
                </asp:TextBox>
            </div>
            <div class="margin-top-20-px">
                <asp:Button ID="SignupBtn" runat="server" Text="Registrarse" class="dark-button width-100-pct" OnClick="SignupBtn_Click" />
            </div>
        </div>
    </section>
</asp:Content>
