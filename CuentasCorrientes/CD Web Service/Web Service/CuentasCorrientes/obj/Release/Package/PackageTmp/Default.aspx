<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CuentasCorrientes._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Cuentas Corrientes</h1>
        <p class="lead">.Consulta de facturas y saldos de proveedores</p>
        <p><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consulta" />
        </p>
        <asp:GridView ID="GridView1" runat="server" Height="368px" Width="968px">
        </asp:GridView>
    </div>

    <div class="row">
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
