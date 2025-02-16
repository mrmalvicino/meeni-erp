﻿<%@ Page Title="Warehouses" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Warehouses.aspx.cs" Inherits="WebForms.Warehouses" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
    <link href="style/table.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <h1>Depósitos</h1>

        <!-- Búsqueda y alta -->

        <div class="grid-1-cols width-100-pct">
            <div class="container-div margin-10-px">
                <div class="wrapped-flex space-between">
                    <div class="wrapped-flex">
                        <div>
                            <asp:DropDownList
                                ID="ActivityStatusDDL"
                                runat="server"
                                class="input-box width-250-px margin-right-20-px"
                                AutoPostBack="true"
                                OnSelectedIndexChanged="ActivityStatusDDL_SelectedIndexChanged">
                                <asp:ListItem Text="Solo activos" Value="Active"></asp:ListItem>
                                <asp:ListItem Text="Solo eliminados" Value="Inactive"></asp:ListItem>
                                <asp:ListItem Text="Ver todos" Value="All"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="row-flex space-between">
                            <asp:TextBox
                                ID="SearchTxt"
                                runat="server"
                                class="input-box width-250-px"
                                placeholder="Buscar depósito..."
                                OnTextChanged="SearchTxt_TextChanged">
                            </asp:TextBox>
                            <asp:LinkButton
                                ID="SearchBtn"
                                runat="server"
                                Text='<i class="bi bi-search"></i>'
                                class="asp-link-button margin-20-px"
                                OnClick="SearchBtn_Click">
                            </asp:LinkButton>
                        </div>
                    </div>
                    <div>
                        <a href="#" class="dark-button margin-10-0-px">
                            <i class="bi bi-plus-circle"></i>
                            <span>Agregar</span>
                        </a>
                    </div>
                </div>
            </div>

            <!-- Listado -->

            <div class="container-div margin-10-px">
                <table>
                    <thead>
                        <tr>
                            <th scope="col">Nombre</th>
                            <th scope="col">Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater
                            ID="WarehousesRpt"
                            runat="server"
                            OnItemCommand="WarehousesRpt_ItemCommand">
                            <ItemTemplate>
                                <tr>

                                    <!-- Nombre -->

                                    <td scope="row">
                                        <asp:Label
                                            ID="NameLbl"
                                            runat="server"
                                            Text='<%#Eval("Name")%>'>
                                        </asp:Label>
                                    </td>

                                    <!-- Acciones -->

                                    <td class="row-flex justify-center">

                                        <!-- Compartimientos -->

                                        <asp:LinkButton
                                            ID="CompartmentsBtn"
                                            runat="server"
                                            CommandName="Compartments"
                                            CommandArgument='<%#Eval("Id")%>'
                                            Text='<i class="bi bi-box-seam"></i>'
                                            class="asp-link-button">
                                        </asp:LinkButton>

                                        <!-- Editar -->

                                        <asp:LinkButton
                                            ID="EditBtn"
                                            runat="server"
                                            CommandName="Edit"
                                            CommandArgument='<%#Eval("Id")%>'
                                            Text='<i class="bi bi-pencil-square"></i>'
                                            class="asp-link-button">
                                        </asp:LinkButton>

                                        <!-- Eliminar -->

                                        <asp:LinkButton
                                            ID="DeleteBtn"
                                            runat="server"
                                            CommandName="Delete"
                                            CommandArgument='<%#Eval("Id")%>'
                                            Text='<i class="bi bi-trash3"></i>'
                                            class="asp-link-button">
                                        </asp:LinkButton>

                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>

        </div>
    </div>
</asp:Content>
