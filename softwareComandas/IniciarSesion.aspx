<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="softwareComandas.IniciarSesion" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-offset-5 col-md-3">
                <div class="form-login">
                    <h4>Bienvenido!</h4>
                    <input type="text" id="input_usuario" class="form-control input-sm chat-input" placeholder="username" runat="server" />
                    <br />
                    <input id="input_password" class="form-control input-sm chat-input" placeholder="password" runat="server" type="password" />
                    <br />
                    <asp:LinkButton CssClass="btn btn-primary btn-md" OnClick="btn_validar_Click" runat="server">login <i class="glyphicon glyphicon-log-in" style="font-size:.8em"></i> </asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
