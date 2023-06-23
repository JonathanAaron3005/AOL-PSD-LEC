<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PSD_LEC.Views.Users.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="min-h-screen bg-gray-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8" style="margin-top: 5%; min-height:75vh">
        <div class="sm:mx-auto sm:w-full sm:max-w-md">
            <h2 class="mt-6 text-center text-3xl font-extrabold text-gray-900">
                Register
            </h2>
        </div>
        <div class="d-flex justify-content-center" style="margin-top: 2.5%;">
            <div class="card row d-flex" style="width: 30rem;">
                <div class="card-body">
                <p class="card-text">Username</p>
                <div class="mb-3">
                    <asp:TextBox ID="UsernameTxt" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="UsernameLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>
                <p class="card-text">Email</p>
                <div class="mb-3">
                    <asp:TextBox ID="EmailTxt" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="EmailLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>
                <div class="mb-3">
                    <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
                    <asp:DropDownList ID="genderList" runat="server"></asp:DropDownList>
                </div>
                <p class="card-text">Password</p>
                <div class="mb-3">
                    <asp:TextBox ID="PasswordTxt" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="PasswordLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>
                
                <p class="card-text">Confirm Password</p>
                <div class="mb-3">
                    <asp:TextBox ID="ConfirmPasswordTxt" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="ConfirmPasswordLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>
                <div class="mb-3">
                    <asp:Label ID="roleLbl" runat="server" Text="Role"></asp:Label>
                    <asp:DropDownList ID="roleList" runat="server"></asp:DropDownList>
                </div>
                <p>
                    <asp:Label ID="ErrorLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    <asp:Button ID="registerBtn" runat="server" Text="Register" class="btn btn-success" style="width: 100%;"
                        onclick="registerBtn_Click"/>
                </p>
                <p>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Views/Users/Login.aspx"><input type="button" value="Login" style="width:100%" class="btn btn-outline-success"/></asp:HyperLink>
                </p>
            </div>
                </div>
        </div>
        </div>
</asp:Content>
