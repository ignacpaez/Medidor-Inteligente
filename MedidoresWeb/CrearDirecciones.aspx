<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CrearDirecciones.aspx.cs" Inherits="MedidoresWeb.CrearDirecciones" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card"> 
        <div class="card-header bg-primary text-white">
        Crear Direcciones
        </div>
        <asp:label ID="lblMensaje" runat="server" CssClass="text-success h1"></asp:label>
        <div class="card-body">
            <div class="form-group">
                <label for= "txtDescripcion">Descripcion</label>
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for= "txtNumero">Numero</label>
                <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control"></asp:TextBox>
               
            </div>
            <div class="form-group">
                <label for= "ddlRegion">Region</label>
                <asp:dropdownlist ID="ddlRegion" runat="server" 
                                 AutoPostBack="true" OnSelectedIndexChanged="ddlRegion_SelectedIndexChanged" ></asp:dropdownlist>
                
            </div>
            <div class="form-group">
                <label for= "ddlCliente">Codigo de cliente</label>
                <asp:DropDownList ID="ddlCliente" runat="server"  AutoPostBack="true"></asp:DropDownList>
               
            </div>
            <div class="form-group">
                <label for= "ddlMedidor">Identificador del medidor</label>
                <asp:DropDownList ID="ddlMedidor" runat="server" AutoPostBack="true"></asp:DropDownList>
                
            </div>
            <asp:Button ID="btnCrearDir" runat="server" Text="Registrar Direccion" CssClass="btn btn-dark" OnClick="btnCrearDir_Click" />
            
        </div>
    </div>
</asp:Content>
