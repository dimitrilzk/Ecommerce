<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecommerce.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Repeater ID="Repeater1" runat="server" ItemType="Ecommerce.Prodotto">
                <ItemTemplate>
                    <div class="col-md-4">
                <div class="card" style="width: 15rem;">
                    <asp:Image ID="Image1" runat="server" CssClass="card" style="width: 15rem;" ImageUrl="<%# Item.img %>"   />
                    <div class="card-body">
                        <asp:Label ID="Label1" runat="server" Text="" CssClass="card-title; text-center;"><%# Item.nomeProdotto %></asp:Label><br />
                        <asp:Label ID="Label2" runat="server" Text="" CssClass="card-text"><%# Item.descrizione %></asp:Label><br />
                        <asp:Label ID="Label3" runat="server" Text="" CssClass="text-center;"><%#  Item.prezzo.ToString("c2") %></asp:Label><br />
                        <a href="#" class="btn btn-primary container-fluid">Go somewhere</a>
                    </div>
                </div>
            </div>
                </ItemTemplate>
            </asp:Repeater>




            




            <%--<div class="col-md-4">
                <div class="card" style="width: 15rem;">
                    <img src="/img/orologio2.jpg" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title text-center">Card title</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <h5 class="card-title text-center">Prezzo</h5>
                        <a href="#" class="btn btn-primary container-fluid">Go somewhere</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="card" style="width: 15rem;">
                    <img src="/img/orologio3.jpg" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title text-center">Card title</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <h5 class="card-title text-center">Prezzo</h5>
                        <a href="#" class="btn btn-primary container-fluid">Go somewhere</a>
                    </div>
                </div>
            </div>--%>
        </div>
    </div>
</asp:Content>
