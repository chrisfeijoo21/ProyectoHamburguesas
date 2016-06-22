<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="softwareComandas.IniciarSesion" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <%--<link href="//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet">--%>
    <div class="container">
        <div class="row">
            <div class="col-md-offset-5 col-md-3">
                <div class="form-login">
                    <h4>Bienvenido!</h4>
                    <input type="text" id="input_usuario" class="form-control input-sm chat-input" placeholder="username" runat="server" />
                    <br />
                    <input type="text" id="input_password" class="form-control input-sm chat-input" placeholder="password" runat="server" />
                    <br />
                    <asp:Button CssClass="btn btn-info" ID="btn_validar" runat="server" Text="Ingresar" OnClick="btn_validar_Click" />
                    <%--<div class="wrapper">
                        <span class="group-btn">
                            <a href="#" class="btn btn-primary btn-md" onclick="btn_validar_Click" runat="server">login <i class="fa fa-sign-in"></i></a>
                        </span>
                    </div>--%>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
