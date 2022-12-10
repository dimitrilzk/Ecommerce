<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecommerce.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Repeater ID="Repeater1" runat="server" ItemType="Ecommerce.Prodotto">
                <ItemTemplate>
                    <div class="col-md-4 text-center my-3">
                        <div class="card" style="width: 20rem;">
                            <asp:Image ID="Image1" runat="server" CssClass="card img-fluid" ImageUrl="<%# Item.img %>" />
                            <div class="card-body bg-success">
                                <asp:Label ID="Label1" runat="server" Text="" CssClass="card-title fw-bold text-center"><%# Item.nomeProdotto %></asp:Label><br />
                                <asp:Label ID="Label3" runat="server" Text="" CssClass="text-center text-warning"><%#  Item.prezzo.ToString("c2") %></asp:Label><br />
                                <a href="Dettagli.aspx?idProdotto=<%# Item.id %>" class="btn btn-dark container-fluid mt-3">Dettagli</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
