<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LegacyXSolution._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <h1>LegacyX Virtual Adding Machine</h1>       
    </div>

    <div class="row">
        <asp:TextBox ID="FirstValue" runat="server"></asp:TextBox>
        <asp:DropDownList ID="Symbol" runat="server">
            <asp:ListItem Value="0">+</asp:ListItem>
            <asp:ListItem Value="0">-</asp:ListItem>
            <asp:ListItem Value="0">*</asp:ListItem>
            <asp:ListItem Value="0">/</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="SecondValue" runat="server"></asp:TextBox>
        <asp:Button ID="Calculate" runat="server" Text="Calculate" OnClick="Calculate_Click"/>
    </div>

    <div class="row">
        <asp:Button ID="ShowHistory" runat="server" Text="Show History" OnClick="ShowHistory_Click"/>
        <asp:Button ID="SaveHistory" runat="server" Text="Save History" OnClick="SaveHistory_Click"/>
        <asp:Button ID="ClearHistory" runat="server" Text="Clear History" OnClick="ClearHistory_Click"/>
    </div>

    <div class="row">
        <asp:ListView ID="CalculationHistory" runat="server"></asp:ListView>
        <asp:ObjectDataSource ID="HistoryODS" runat="server"></asp:ObjectDataSource>
    </div>

</asp:Content>
