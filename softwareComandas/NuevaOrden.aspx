<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevaOrden.aspx.cs" Inherits="softwareComandas.NuevaOrden" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div class="row">
            <div class="form-group">
                <div class="col-md-4">
                    <span class="glyphicon glyphicon-chevron-right"></span> <asp:DropDownList ID="ddl_rubro_comida" runat="server" CssClass="dropdown" OnSelectedIndexChanged="ddl_rubro_comida_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-4">
                    <span class="glyphicon glyphicon-chevron-right"></span> <asp:DropDownList ID="ddl_rubro_bebida" runat="server" CssClass="dropdown" OnSelectedIndexChanged="ddl_rubro_bebida_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-4">
                    <span class="glyphicon glyphicon-chevron-right"></span> <asp:DropDownList ID="ddl_rubro_otro" runat="server" CssClass="dropdown" OnSelectedIndexChanged="ddl_rubro_otro_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </div>

            </div>
            <div class="form-group">
                <div class="col-md-4">
                    <asp:GridView ID="dgrid_comida" runat="server" CssClass="table table-hover table-bordered" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="No entries found" OnRowCommand="dgrid_comida_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="id_articulo" HeaderText="Id" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="precio" HeaderText="Precio" />
                            <asp:BoundField DataField="observacion" HeaderText="Obs" />
                            <asp:ButtonField Text="elegir" CommandName="cmdClick" ControlStyle-CssClass="btn btn-circle" />
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="col-md-4">
                    <asp:GridView ID="dgrid_bebida" runat="server" CssClass="table table-hover table-bordered" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="No entries found" OnRowCommand="dgrid_bebida_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="id_articulo" HeaderText="Id" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="precio" HeaderText="Precio" />
                            <asp:BoundField DataField="observacion" HeaderText="Obs" />
                            <asp:ButtonField Text="elegir" CommandName="cmdClick" ControlStyle-CssClass="btn btn-circle" />
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="col-md-4">
                    <asp:GridView ID="dgrid_otro" runat="server" CssClass="table table-hover table-bordered" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="No entries found" OnRowCommand="dgrid_otro_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="id_articulo" HeaderText="Id" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="precio" HeaderText="Precio" />
                            <asp:BoundField DataField="observacion" HeaderText="Obs" />
                            <asp:ButtonField Text="elegir" CommandName="cmdClick" ControlStyle-CssClass="btn btn-circle" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="dgrid_detalle" runat="server" CssClass="table table-hover table-bordered"></asp:GridView>
                <br />
                <asp:Button ID="btn_confirmar_orden" runat="server" Text="Button" CssClass="btn btn-info" OnClick="btn_confirmar_orden_Click" />
            </div>
        </div>
    </div>
</asp:Content>
