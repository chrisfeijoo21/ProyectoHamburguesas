<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevaOrden.aspx.cs" Inherits="softwareComandas.NuevaOrden" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="col-md-12">
            <br />
            <div class="form-group">
                <asp:Button ID="btnCarne" runat="server" Text="CARNE" CssClass="btn btn-info" onclick="btnCarne_Click"/>
                <asp:Button ID="btnPollo" runat="server" Text="POLLO" CssClass="btn btn-info" onclick="btnPollo_Click"/>
                <asp:Button ID="btnVegario" runat="server" Text="VEGARIO" CssClass="btn btn-info" onclick="btnVegario_Click"/>
            </div>
            <div class="form-group">
                <asp:GridView ID="gdvComida" runat="server" ShowHeaderWhenEmpty="true" EmptyDataText="no hay nada" CssClass="table table-hover table-bordered" AutoGenerateColumns="true">
                   <%-- <Columns>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Precio" DataField="Precio" />
                        <asp:BoundField HeaderText="Ingredientes" DataField="Ingredientes" />
                    </Columns>--%>
                </asp:GridView>
            </div>
            <div class="form-group">
                <asp:Button ID="btnConGas" runat="server" Text="CON GAS" CssClass="btn btn-info" />
                <asp:Button ID="btnSinGas" runat="server" Text="SIN GAS" CssClass="btn btn-info" />
                <asp:Button ID="btnCerveza" runat="server" Text="CERVEZA" CssClass="btn btn-info" />
            </div>
            <div class="form-group">
                <asp:GridView ID="gdvBebida" runat="server" CssClass="table table-hover table-bordered"></asp:GridView>
            </div>
            <div class="form-group">
                <asp:Label ID="lblDetalle" runat="server" Text="Detalle:" CssClass="col-md-2 control-label"></asp:Label>
            </div>
            <div class="form-group">
                <asp:GridView ID="gdvDetalle" runat="server" CssClass="table table-hover table-bordered"  Visible="true"></asp:GridView>
            </div>
            <div class="form-group">
                <asp:Label ID="lblTotal" runat="server" Text="TOTAL: $" CssClass="col-md-2 control-label"></asp:Label>
                <asp:TextBox ID="txtTotal" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" onclick="btnConfirmar_Click"/>
                <asp:Button ID="btnBlanquear" runat="server" Text="Blanquear" />
            </div>




        </div>
    </div>
</asp:Content>
