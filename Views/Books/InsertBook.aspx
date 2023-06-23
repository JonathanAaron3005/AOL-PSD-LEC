<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="InsertBook.aspx.cs" Inherits="PSD_LEC.Views.Books.InsertBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="min-h-screen bg-gray-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8" style="margin-top: 5%; min-height:75vh">
        <div class="sm:mx-auto sm:w-full sm:max-w-md">
            <h2 class="mt-6 text-center text-3xl font-extrabold text-gray-900">
                Insert Book
            </h2>
        </div>
        <div class="d-flex justify-content-center" style="margin-top: 2.5%;">
            <div class="card row d-flex" style="width: 30rem;">
                <div class="card-body">
                <p class="card-text">Book Name</p>
                <div class="mb-3">
                    <asp:TextBox ID="bookName_TextBox" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="name_Label" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                <p class="card-text">Publisher</p>
                <asp:DropDownList id="publisher_selector" runat="server">
                    
                </asp:DropDownList>
                <p class="card-text">ISBN</p>
                <div class="mb-3">
                    <asp:TextBox ID="bookISBN_TextBox" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="isbn_Label" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                <p class="card-text">Price</p>
                <div class="mb-3">
                    <asp:TextBox ID="bookPrice_TextBox" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="price_Label" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                    <p class="card-text">Year</p>
                <div class="mb-3">
                    <asp:TextBox ID="year_TextBox" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="year_label" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="errorText_Label" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>
                <div>
                    <asp:Button ID="insertBook_Btn" runat="server" Text="Insert Book" class="btn btn-success" style="width: 100%;"
                        onClick="InsertBook_Btn_Click"/>
                </div>
                
            </div>
        </div>
        </div>
</asp:Content>