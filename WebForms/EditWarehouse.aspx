<%@ Page Title="Edit Warehouse" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EditWarehouse.aspx.cs" Inherits="WebForms.EditWarehouse" %>

<%@ Register Src="~/UserControls/AddressFields.ascx" TagPrefix="uc" TagName="AddressFields" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
    <link href="style/table.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <h1>Datos del depósito</h1>

        <div class="wrapped-flex justify-center">
            <div class="col-flex">
                <!-- Identificación -->

                <div class="container-div small-box-width mid-box-height margin-10-px">
                    <p class="center-text">Identificación</p>
                    <div>
                        <label for="NameTxt">Nombre</label>
                        <asp:TextBox
                            ID="NameTxt"
                            runat="server"
                            TextMode="SingleLine"
                            class="width-100-pct input-box"
                            placeholder="Nombre del depósito">
                        </asp:TextBox>
                    </div>
                </div>

                <!-- Compartimientos -->

                <div class="container-div small-box-width mid-box-height margin-10-px">
                    <p class="center-text">Productos en depósito</p>
                    <div class="col-flex">
                        <asp:LinkButton
                            ID="CompartmentsBtn"
                            runat="server"
                            class="dark-button"
                            OnClick="CompartmentsBtn_Click">
                        <i class="bi bi-box-seam"></i>
                        <span>Ver inventario</span>
                        </asp:LinkButton>
                    </div>
                </div>
            </div>

            <uc:AddressFields ID="AddressFieldsUC" runat="server" />
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
