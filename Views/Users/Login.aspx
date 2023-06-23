<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PSD_LEC.Views.Users.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="min-h-screen bg-gray-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8" style="margin-top: 5%;">
        <div class="sm:mx-auto sm:w-full sm:max-w-md">
            <h2 class="mt-6 text-center text-3xl font-extrabold text-gray-900">
                Login
            </h2>
        </div>
        <div class="d-flex justify-content-center" style="margin-top: 2.5%;">
            <div class="card row d-flex" style="width: 30rem;">
                <div class="card-body">
                    <div>
                        <p class="card-text">Username</p>
                        <div class="mb-3">
                            <asp:TextBox ID="UsernameTxt" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <p class="card-text">Password</p>
                        <div class="mb-3">
                            <asp:TextBox ID="PasswordTxt" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                        <p class="pt-3">
                            <asp:CheckBox ID="RememberCheckBox" runat="server"/>
                            <asp:Label ID="RememberLabel" runat="server" Text="Remember Me" AssociatedControlID="RememberCheckBox"></asp:Label>
                        </p>
                        <p>
                            <asp:Label ID="ErrorLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                        </p>
                        <p>
                            <asp:Button ID="LoginBtn" runat="server" Text="Login" class="btn btn-success" 
                                style="width: 100%;" onclick="LoginBtn_Click"/>
                        </p>
                    </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
