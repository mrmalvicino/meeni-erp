<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EntityName.ascx.cs" Inherits="WebForms.UserControls.EntityName" %>

<div id="OrganizationNameDiv" runat="server">
    <label for="NameTxt">Nombre</label>
    <asp:TextBox
        ID="OrganizationNameTxt"
        runat="server"
        TextMode="SingleLine"
        class="width-100-pct input-box"
        placeholder="Nombre de la organización">
    </asp:TextBox>
</div>
<div id="PersonNameDiv" runat="server" class="row-flex space-between">
    <div class="width-120-px">
        <label for="FirstNameTxt">Nombre</label>
        <asp:TextBox
            ID="FirstNameTxt"
            runat="server"
            TextMode="SingleLine"
            class="width-100-pct input-box"
            placeholder="Nombre">
        </asp:TextBox>
    </div>
    <div class="width-120-px">
        <label for="LastNameTxt">Apellido</label>
        <asp:TextBox
            ID="LastNameTxt"
            runat="server"
            TextMode="SingleLine"
            class="width-100-pct input-box"
            placeholder="Apellido">
        </asp:TextBox>
    </div>
</div>