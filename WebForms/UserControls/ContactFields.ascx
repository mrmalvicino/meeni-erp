<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactFields.ascx.cs" Inherits="WebForms.UserControls.ContactFields" %>

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