<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OthelloWebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="345px" Width="1070px">
        <br />
        <asp:Label ID="UserName" runat="server" Font-Bold="True"></asp:Label>
        <br />
        <asp:Label ID="wins" runat="server" Font-Bold="True"></asp:Label>
        <br /> 
        <asp:Label ID="losses" runat="server" Font-Bold="True"></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="ListBoxGames" runat="server" Height="241px" Rows="20" Width="307px"></asp:ListBox>
    </asp:Panel>

</asp:Content>
