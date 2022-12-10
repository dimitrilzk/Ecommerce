<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Ecommerce.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-12 alert alert-info">
                <strong>Articoli nel carrello:</strong>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
                <strong>Totale da pagare:</strong>
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br />
                <a href="Default.aspx" class="btn btn-dark container-fluid">Torna alla home</a>
                <asp:Button ID="Button1" runat="server" Text="Svuota carrello" CssClass="btn btn-dark container-fluid" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</asp:Content>
