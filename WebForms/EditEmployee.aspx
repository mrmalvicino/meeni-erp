<%@ Page Title="Edit Employee" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EditEmployee.aspx.cs" Inherits="WebForms.EditEmployee" %>

<%@ Register Src="~/UserControls/EditEntity.ascx" TagPrefix="uc" TagName="EditEntity" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <h1>Datos del empleado</h1>
        <div class="wrapped-flex justify-center">
            <uc:EditEntity ID="EditEntityUC" runat="server" />

            <!-- Antiguedad -->

            <div class="container-div small-box-width mid-box-height margin-10-px">
                <p class="center-text">Antiguedad</p>
                <div>
                    <label for="AdmissionDateTxt">Fecha de admisión</label>
                    <asp:TextBox
                        ID="AdmissionDateTxt"
                        runat="server"
                        TextMode="Date"
                        class="width-100-pct input-box">
                    </asp:TextBox>
                </div>
            </div>

        </div>

        <!-- Botones -->

        <div class="wrapped-flex justify-center">
            <div class="margin-10-px">
                <asp:Button
                    ID="SaveBtn"
                    runat="server"
                    Text="Guardar cambios"
                    class="dark-button big-hover"
                    OnClick="SaveBtn_Click" />
            </div>
        </div>
    </div>
</asp:Content>
