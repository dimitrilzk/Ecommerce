<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="Ecommerce.Dettagli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Image ID="Image1" runat="server" />
     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="messaggioAcquisto" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="Button1" runat="server" Text="Aggiungi al carrello" CssClass="btn btn-dark container-fluid" OnClick="Button1_Click"/>
    <a href="Default.aspx" class="btn btn-dark container-fluid">Torna alla home</a>
    <a href="Carrello.aspx" class="btn btn-dark container-fluid">Vai al carrello</a>
</asp:Content>
