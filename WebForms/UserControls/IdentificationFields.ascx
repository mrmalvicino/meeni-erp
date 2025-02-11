<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="IdentificationFields.ascx.cs" Inherits="WebForms.UserControls.IdentificationFields" %>

<div class="row-flex space-between">
    <div class="width-120-px">
        <label for="IdentificationCodeTxt">Código fiscal</label>
        <asp:TextBox
            ID="IdentificationCodeTxt"
            runat="server"
            TextMode="SingleLine"
            class="width-100-pct input-box"
            placeholder="Número">
        </asp:TextBox>
    </div>
    <div class="width-120-px">
        <label for="IdentificationTypesDDL">Tipo</label>
        <asp:DropDownList
            ID="IdentificationTypesDDL"
            runat="server"
            class="input-box width-100-pct">
        </asp:DropDownList>
    </div>
</div>