<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="softwareComandas.IniciarSesion" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <br />

    <div class="container">
        <br />
        <div class="col-md-12">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Panel 1</h3>
                    <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblidUser" runat="server" Text="idUser:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtidUser" runat="server"></asp:TextBox>
                        </div>
                        <asp:Label CssClass="col-md-2 control-label" ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-offset-2 col-md-4">
                            <asp:Button CssClass="btn btn-info" ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
