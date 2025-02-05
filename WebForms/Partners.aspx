<%@ Page Title="Partners" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Partners.aspx.cs" Inherits="WebForms.Partners" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
    <link href="style/table.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <h1>Socios comerciales</h1>

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
                                placeholder="Buscar socio comercial..."
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
                        <a href="AddEntity.aspx?class=Partner" class="dark-button margin-10-0-px">
                            <i class="bi bi-plus-circle"></i>
                            <span>Crear nuevo</span>
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
                            <th scope="col">Tipo</th>
                            <th scope="col">Email</th>
                            <th scope="col">Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater
                            ID="PartnersRpt"
                            runat="server"
                            OnItemCommand="PartnersRpt_ItemCommand"
                            OnItemDataBound="PartnersRpt_ItemDataBound">
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

                                    <!-- Tipo -->

                                    <td scope="row">
                                        <asp:Label
                                            ID="TypeLbl"
                                            runat="server">
                                        </asp:Label>
                                    </td>

                                    <!-- Email -->

                                    <td scope="row">
                                        <asp:Label
                                            ID="EmailLbl"
                                            runat="server"
                                            Text='<%#Eval("Email")%>'>
                                        </asp:Label>
                                    </td>

                                    <!-- Acciones -->

                                    <td class="row-flex justify-center">

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
