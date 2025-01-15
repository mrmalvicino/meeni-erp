<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebForms.Dashboard" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <div class="grid-1-cols width-100-pct">
            <div class="container-div margin-10-px">
                contenido 1
            </div>
            <div class="container-div margin-10-px height-300-px">
                contenido 2
            </div>
        </div>
        <div class="grid-2-cols width-100-pct">
            <div class="container-div margin-10-px">
                contenido 3
            </div>
            <div class="container-div margin-10-px">
                contenido 3
            </div>
        </div>
        <div class="grid-3-cols width-100-pct">
            <div class="container-div margin-10-px">
                contenido 4
            </div>
            <div class="container-div margin-10-px">
                contenido 4
            </div>
            <div class="container-div margin-10-px">
                contenido 4
            </div>
        </div>
        <div class="grid-3-cols width-100-pct">
            <div class="container-div margin-10-px">
                contenido 5
            </div>
            <div class="container-div margin-10-px">
                contenido 5
            </div>
            <div class="container-div margin-10-px">
                contenido 5
            </div>
        </div>
    </div>
</asp:Content>
