<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListarDirecciones.aspx.cs" Inherits="MedidoresWeb.ListarDirecciones" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="mt-5">
                <asp:GridView ID="GridDirecciones" runat="server" AutoGenerateColumns="false" EmptyDataText ="No hay Direcciones" 
                    CssClass="table table-hover" BorderStyle="Solid">
                    <Columns>
                        <asp:BoundField HeaderText="Id Dirección" DataField="Id"  />
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                        <asp:BoundField HeaderText="Numero" DataField="Numero" />
                        <asp:BoundField HeaderText="Region " DataField="Region.Nombre" />
                        <asp:BoundField HeaderText="Codigo Cliente" DataField="CodigoCliente" />
                        <asp:BoundField HeaderText="Identificador del medidor" DataField="IdMedidor" />
                    </Columns>
                </asp:GridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
