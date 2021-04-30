<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CrearMedidor.aspx.cs" Inherits="MedidoresWeb.CrearMedidor" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
        <div class="card-header bg-primary text-white">
        Crear Medidor
        </div>
        <asp:Label ID="lblMensaje" runat="server" CssClass="text-success h1"></asp:Label>
        <div class="card-body">
            <div class="form-group">
                <label for= "txtIdentificador">Identificador</label>
                <asp:TextBox ID="txtIdentificador" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:CustomValidator ID="ID_CV"
                    runat="server"
                    ErrorMessage="CustomValidator"
                    ValidateEmptyText="true"
                    CssClass="text-danger"
                    ControlToValidate ="txtIdentificador" OnServerValidate="ID_CV_ServerValidate"                 
                    >
                </asp:CustomValidator>
            </div>
            <div class="form-group">
            <label for ="rblTipo">Tipo</label>
            <asp:RadioButtonList ID="rblTipo" runat="server">
                <asp:ListItem Selected="True" Value="Monofasico" Text="Monofasico"></asp:ListItem>
                <asp:ListItem Value="Trifasico" Text="Trifasico"></asp:ListItem>

            </asp:RadioButtonList>
            </div>
            <asp:Button ID="btnCrearMedidor" runat="server" Text="Crear Medidor" CssClass="btn btn-dark" OnClick="btnCrearMedidor_Click" />
            <br/>
            
        </div>
    </div>
</asp:Content>
