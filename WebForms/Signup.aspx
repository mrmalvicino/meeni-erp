<%@ Page Title="Signup" Language="C#" MasterPageFile="~/Landing.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WebForms.Signup" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="LandingHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="LandingMainPlaceHolder" runat="server">
    <section class="height-100-vh col-flex space-evenly">
        <div class="site-menu-height"></div>
        <h1>Registrar empresa</h1>
        <div class="wrapped-flex justify-center">
            <div class="container-div width-300-px height-400-px margin-10-px">
                <p class="center-text">Datos de la empresa</p>
                <div>
                    <label for="PricingPlansDDL">Plan</label>
                    <asp:DropDownList
                        ID="PricingPlansDDL"
                        runat="server"
                        class="width-100-pct input-box">
                    </asp:DropDownList>
                </div>
                <div>
                    <label for="OrganizationNameTxt">Organización</label>
                    <asp:TextBox
                        ID="OrganizationNameTxt"
                        runat="server"
                        TextMode="SingleLine"
                        class="width-100-pct input-box"
                        placeholder="Nombre de tu empresa">
                    </asp:TextBox>
                </div>
                <div>
                    <label for="OrganizationEmailTxt">Email</label>
                    <asp:TextBox
                        ID="OrganizationEmailTxt"
                        runat="server"
                        TextMode="Email"
                        class="width-100-pct input-box"
                        placeholder="Email de tu empresa">
                    </asp:TextBox>
                </div>
            </div>
            <div class="container-div width-300-px height-400-px margin-10-px">
                <p class="center-text">Datos del administrador</p>
                <div>
                    <label for="FirstNameTxt">Nombre</label>
                    <asp:TextBox
                        ID="FirstNameTxt"
                        runat="server"
                        TextMode="SingleLine"
                        class="width-100-pct input-box"
                        placeholder="Tu nombre">
                    </asp:TextBox>
                </div>
                <div>
                    <label for="LastNameTxt">Apellido</label>
                    <asp:TextBox
                        ID="LastNameTxt"
                        runat="server"
                        TextMode="SingleLine"
                        class="width-100-pct input-box"
                        placeholder="Tu apellido">
                    </asp:TextBox>
                </div>
                <div>
                    <label for="UsernameTxt">Usuario</label>
                    <asp:TextBox
                        ID="UsernameTxt"
                        runat="server"
                        TextMode="SingleLine"
                        class="width-100-pct input-box"
                        placeholder="Creá un nombre de usuario">
                    </asp:TextBox>
                </div>
                <div>
                    <label for="PasswordTxt">Contraseña</label>
                    <asp:TextBox
                        ID="PasswordTxt"
                        runat="server"
                        TextMode="Password"
                        class="width-100-pct input-box"
                        placeholder="Creá una contraseña">
                    </asp:TextBox>
                </div>
            </div>
        </div>
        <div class="margin-20-px">
            <asp:Button
                ID="SignupBtn"
                runat="server"
                Text="Crear empresa"
                class="dark-button big-hover"
                OnClick="SignupBtn_Click" />
        </div>
    </section>
</asp:Content>
