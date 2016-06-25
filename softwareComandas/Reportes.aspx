<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="softwareComandas.Reportes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-12">
            <br />

            <div class="form-group">
                <asp:Button ID="btnFecha" runat="server" Text="FECHA" CssClass="btn btn-info" OnClick="btnFecha_Click" />
                <asp:Button ID="btnOrden" runat="server" Text="ORDEN" CssClass="btn btn-info" OnClick="btnOrden_Click"/>
                <asp:Button ID="btnUsuario" runat="server" Text="USUARIO" CssClass="btn btn-info" OnClick="btnUsuario_Click" />
            </div>
            <div class="form-group">
                <asp:GridView ID="gdvItems" runat="server" CssClass="table table-hover table-bordered"></asp:GridView>

            </div>
        </div>
    </div>
</asp:Content>
