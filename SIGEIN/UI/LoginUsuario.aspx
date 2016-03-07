<%@ Page Title="" Language="C#" MasterPageFile="~/Encargado.Master" AutoEventWireup="true" CodeBehind="LoginUsuario.aspx.cs" Inherits="UI.LoginUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
    </asp:Login>
</asp:Content>
