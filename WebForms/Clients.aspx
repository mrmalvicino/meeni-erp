<%@ Page Title="Clients" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Clients.aspx.cs" Inherits="WebForms.Clients" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="AdminHeadPlaceHolder" runat="server">
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
                            <th scope="col">Nombre</th>
                            <th scope="col">Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="ClientsRpt" runat="server" OnItemCommand="ClientsRpt_ItemCommand">
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

                                    <td>
                                        <div>

                                            <!-- Ver -->

                                            <asp:LinkButton
                                                ID="ViewBtn"
                                                runat="server"
                                                CommandName="View"
                                                CommandArgument='<%#Eval("Id")%>'
                                                Text='<i class="bi bi-eye"></i>'>
                                            </asp:LinkButton>

                                            <!-- Editar -->

                                            <asp:LinkButton
                                                ID="EditBtn"
                                                runat="server"
                                                CommandName="Edit"
                                                CommandArgument='<%#Eval("Id")%>'
                                                Text='<i class="bi bi-pencil-square"></i>'>
                                            </asp:LinkButton>

                                            <!-- Eliminar -->

                                            <asp:LinkButton
                                                ID="DeleteBtn"
                                                runat="server"
                                                CommandName="Delete"
                                                CommandArgument='<%#Eval("Id")%>'
                                                Text='<i class="bi bi-trash3"></i>'>
                                            </asp:LinkButton>
                                        </div>
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
