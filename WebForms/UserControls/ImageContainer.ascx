<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ImageContainer.ascx.cs" Inherits="WebForms.UserControls.ImageContainer" %>

<div class="container-div small-box-width big-box-height margin-10-px">
    <p class="center-text">Imagen</p>
    <div class="width-100-pct">
        <asp:Image ID="PictureImg" runat="server" class="fit-image circle-border" />
    </div>
    <div>
        <label for="URLTxt">URL de imagen</label>
        <asp:TextBox
            ID="URLTxt"
            runat="server"
            TextMode="SingleLine"
            class="width-100-pct input-box"
            placeholder="URL de la imagen"
            AutoPostBack="true">
        </asp:TextBox>
    </div>
    <div class="col-flex">
        <a href="https://imgur.com/upload" target="_blank" rel="noopener noreferrer" class="light-button">
            <i class="bi bi-upload"></i>
            <span>Subir a Imgur</span>
        </a>
    </div>
</div>