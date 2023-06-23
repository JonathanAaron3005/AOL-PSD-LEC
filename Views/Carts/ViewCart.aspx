<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="PSD_LEC.Views.Carts.ViewCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div style="padding:2% 10%">
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">Book ISBN</th>
                    <th scope="col">Book Title</th>
                    <th scope="col">Book Publisher</th>
                    <th scope="col">Book Price</th>
                    <th scope="col">Published Year</th>
                    <th scope="col">Book Quantity</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="TableRepeater" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td scope="row"><%# Eval("BookISBN") %></td>
                            <td scope="row"><%# Eval("BookName") %></td>
                            <td scope="row"><%# Eval("PublisherName") %></td>
                            <td scope="row"><%# Eval("BookPrice") %></td>
                            <td scope="row"><%# Eval("BookYear") %></td>
                            <td scope="row"><%# Eval("Quantity") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
    <asp:Button ID="buyCartBtn" runat="server" Text="Buy Cart" OnClick="buyCartBtn_Click"/>
    <asp:Button ID="clearCartBtn" runat="server" Text="Clear Cart" OnClick="clearCartBtn_Click"/>
</asp:Content>
