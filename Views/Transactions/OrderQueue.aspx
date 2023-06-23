<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="OrderQueue.aspx.cs" Inherits="PSD_LEC.Views.Transactions.OrderQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="mb-2">Unhandled Transactions</h1>
    <asp:GridView ID="trGridView" runat="server" AutoGenerateColumns="False" OnRowCommand="trGridView_RowCommand">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Transaction ID" SortExpression="Id" />
            <asp:BoundField DataField="CustomerId" HeaderText="Customer ID" SortExpression="CustomerId" />
            <asp:BoundField DataField="Date" HeaderText="Transaction Date" SortExpression="Date" />
            <asp:TemplateField HeaderText="Detail">
                <ItemTemplate>
                    <asp:Button runat="server" ID="DetailBtn" Text="Detail" CommandName="Detail" CommandArgument='<%# Eval("Id") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:Button ID="HandleBtn" runat="server" Text="Process" CommandName="Process" CommandArgument='<%# Eval("Id") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <h1 class="mb-2">Handled Transactions</h1>
    <asp:GridView ID="handledGridView" runat="server" AutoGenerateColumns="False" OnRowCommand="handledGridView_RowCommand">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Transaction Id" SortExpression="Id" />
            <asp:BoundField DataField="CustomerId" HeaderText="Customer ID" SortExpression="CustomerId" />
            <asp:BoundField DataField="Date" HeaderText="Transaction Date" SortExpression="Date" />
            <asp:TemplateField HeaderText="Detail">
                <ItemTemplate>
                    <asp:Button runat="server" ID="DetailBtn" Text="Detail" CommandName="Detail" CommandArgument='<%# Eval("Id") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
