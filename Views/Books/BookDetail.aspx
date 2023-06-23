<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="BookDetail.aspx.cs" Inherits="PSD_LEC.Views.Books.BookDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card" style="width: 18rem;">
      <div class="card-body">
        <asp:Label ID="name" runat="server" Text="Name: "></asp:Label>
        <asp:Label runat="server" id="bookName" class="card-title" Text="Label"></asp:Label>
          <br />
          <asp:Label ID="isbn" runat="server" Text="ISBN: "></asp:Label>
        <asp:Label runat="server" id="bookISBN" class="card-subtitle mb-2 text-body-secondary" Text="Label"></asp:Label>
          <br />
        <asp:Label ID="publisher" runat="server" Text="Publisher: "></asp:Label>
        <asp:Label runat="server" id="bookPublisher" class="card-subtitle mb-2 text-body-secondary" Text="Label"></asp:Label>
          <br />
          <asp:Label ID="price" runat="server" Text="Price: "></asp:Label>
        <asp:Label runat="server" id="bookPrice" class="card-subtitle mb-2 text-body-secondary" Text="Label"></asp:Label>
          <br />
          <asp:Label ID="year" runat="server" Text="Year: "></asp:Label>
        <asp:Label runat="server" id="bookYear" class="card-subtitle mb-2 text-body-secondary" Text="Label"></asp:Label>
          <br />
        <asp:Label runat="server" id="bookOrderQuantity" class="card-subtitle mb-2 text-body-secondary" Text="Quantity"></asp:Label>
        <asp:TextBox ID="quantityTxt" runat="server"></asp:TextBox>
         <asp:LinkButton ID="updateBtn" class="card-link" runat="server" Style="cursor: pointer" CommandArgument='<%#Eval("Id") %>' onclick="updateBtn_Click" Visible="true">
             Update
         </asp:LinkButton>
          <asp:LinkButton ID="orderBtn" class="card-link" runat="server" Style="cursor: pointer" CommandArgument='<%#Eval("Id") %>' onclick="orderBtn_Click" Visible="true">
             Order
         </asp:LinkButton>
         <asp:LinkButton ID="deleteBtn" class="card-link" runat="server" Style="cursor: pointer" CommandArgument='<%#Eval("Id") %>' onclick="deleteBtn_Click" Visible="true">
             Delete
         </asp:LinkButton>
      </div>
    </div>
</asp:Content>

