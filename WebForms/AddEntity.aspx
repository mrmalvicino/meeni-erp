<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddEntity.aspx.cs" Inherits="WebForms.AddEntity" %>

<%@ Register Src="~/UserControls/EntityName.ascx" TagPrefix="uc" TagName="EntityName" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <h1>Agregar nuevo registro</h1>
        <div class="container-div small-box-width big-box-height margin-10-px">
            <uc:EntityName ID="EntityNameUC" runat="server" />
            <div>
                <label for="UsernameTxt">Usuario</label>
                <asp:TextBox
                    ID="UsernameTxt"
                    runat="server"
                    TextMode="SingleLine"
                    class="width-100-pct input-box"
                    placeholder="Creá un usuario">
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
            <div class="margin-top-20-px">
                <asp:Button
                    ID="SaveBtn"
                    runat="server"
                    Text="Guardar"
                    class="dark-button width-100-pct"
                    OnClick="SaveBtn_Click" />
            </div>
        </div>
    </div>
</asp:Content>
