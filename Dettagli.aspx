<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="Ecommerce.Dettagli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="card mb-3" style="max-width: 1000px;">
            <div class="row g-0">
                <div class="col-md-4">
                    <asp:Image ID="Image1" CssClass="img-fluid" runat="server" />
                </div>
                <div class="col-md-8">
                    <div class="card-body ">
                        <asp:Label ID="Label1" CssClass="fw-bold" runat="server" Text=""></asp:Label><br />
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
                        <asp:Label ID="Label3" CssClass="fw-bold" runat="server" Text=""></asp:Label><br />
                        <asp:Label ID="messaggioAcquisto" runat="server" CssClass="text-danger" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
            <asp:Button ID="Button1" runat="server" Text="Aggiungi al carrello" CssClass="btn btn-dark container-fluid" OnClick="Button1_Click" />
            <a href="Default.aspx" class="btn btn-dark container-fluid">Torna alla home</a>
            <a href="Carrello.aspx" class="btn btn-dark container-fluid">Vai al carrello</a>
        </div>
</asp:Content>
