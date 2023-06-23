<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="PSD_LEC.Views.Transactions.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="trGridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="trGridView_SelectedIndexChanged1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="HeaderId" SortExpression="Id" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
