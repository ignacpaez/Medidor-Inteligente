<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CrearCliente.aspx.cs" Inherits="MedidoresWeb.CrearCliente" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card"> 
        <div class="card-header bg-primary text-white">
        Crear Cliente
        </div>
        <asp:Label ID="lblMensaje" runat="server"  CssClass="text-success h1"></asp:Label>
        <div class="card-body">
            <div class="form-group">
                <label for= "txtCodigoCliente">Codigo Cliente</label>
                <asp:TextBox ID="txtCodigoCliente" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for= "txtRut">Rut del cliente</label>
                <asp:TextBox ID="txtRut" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for= "txtNombre">Nombre del cliente</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for= "txtApellidoP">Apellido paterno</label>
                <asp:TextBox ID="txtApellidoP" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for= "txtApellidoM">Apellido materno</label>
                <asp:TextBox ID="txtApellidoM" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for= "txtCorreo">Correo Electronico del cliente</label>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" type="email" ></asp:TextBox>
            </div>
            <asp:Button ID="btnCrearCliente" runat="server" Text="Crear cliente" CssClass="btn btn-dark" OnClick="btnCrearCliente_Click"/>
        </div>
    </div>
</asp:Content>
