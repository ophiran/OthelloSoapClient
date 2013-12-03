<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OthelloWebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="Panel1" runat="server" Height="458px" Width="1070px">
        <asp:Panel ID="Panel3" runat="server">
            <asp:Panel ID="Panel2" runat="server" BackColor="#666666" Width="1066px">
                <asp:Menu ID="Menu1" runat="server" BackColor="#666666" Font-Bold="True" ForeColor="#66CCFF">
                    <DynamicMenuItemStyle BackColor="#666666" />
                    <DynamicItemTemplate>
                        <%# Eval("Text") %>
                    </DynamicItemTemplate>
                    <Items>
                        <asp:MenuItem Text="Menu" Value="Menu">
                            <asp:MenuItem Text="Connect" Value="Connect"></asp:MenuItem>
                            <asp:MenuItem Text="Disconnect" Value="Disconnect"></asp:MenuItem>
                            <asp:MenuItem Text="GameList" Value="GameList"></asp:MenuItem>
                            <asp:MenuItem Text="PlayerInfo" Value="PlayerInfo"></asp:MenuItem>
                        </asp:MenuItem>
                    </Items>
                    <StaticMenuItemStyle BackColor="#666666" BorderColor="#66CCFF" BorderStyle="Solid" BorderWidth="2px" />
                </asp:Menu>
            </asp:Panel>
        </asp:Panel>
        <asp:ListBox ID="ListBoxGames" runat="server" Height="372px" Width="307px" Rows="20"></asp:ListBox>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </asp:Panel>

</asp:Content>
