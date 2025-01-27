<%@ Page Title="Clients" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Clients.aspx.cs" Inherits="WebForms.Clients" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
    <link href="style/table.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminMainPlaceHolder" runat="server">
    <div class="height-100-pct width-100-pct col-flex justify-center padding-10-px">
        <h1>Clientes</h1>
        <div class="grid-1-cols width-100-pct">
            <div class="container-div margin-10-px height-200-px">
                Buscador y agregar cliente
            </div>
            <div class="container-div margin-10-px">
                <table>
                    <thead>
                        <tr>
                            <th scope="col">ID</th>
                            <th scope="col">Nombre</th>
                            <th scope="col">Apellido</th>
                            <th scope="col">Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="HumanClientsRpt" runat="server" OnItemCommand="HumanClientsRpt_ItemCommand">
                            <ItemTemplate>
                                <tr>

                                    <!-- ID -->

                                    <td scope="row">
                                        <asp:Label
                                            ID="IdLbl"
                                            runat="server"
                                            Text='<%#Eval("Id")%>'>
                                        </asp:Label>
                                    </td>

                                    <!-- Nombre -->

                                    <td scope="row">
                                        <asp:Label
                                            ID="FirstNameLbl"
                                            runat="server"
                                            Text='<%#Eval("Person.FirstName")%>'>
                                        </asp:Label>
                                    </td>

                                    <!-- Apellido -->

                                    <td scope="row">
                                        <asp:Label
                                            ID="LastNameLbl"
                                            runat="server"
                                            Text='<%#Eval("Person.LastName")%>'>
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
                                            class="dark-font margin-0-5-px">
                                        </asp:LinkButton>

                                        <!-- Eliminar -->

                                        <asp:LinkButton
                                            ID="DeleteBtn"
                                            runat="server"
                                            CommandName="Delete"
                                            CommandArgument='<%#Eval("Id")%>'
                                            Text='<i class="bi bi-trash3"></i>'
                                            class="dark-font margin-0-5-px">
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
