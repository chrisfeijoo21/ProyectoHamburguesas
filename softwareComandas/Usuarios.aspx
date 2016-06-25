<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="softwareComandas.RegistroUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%--<style>
        body {
            background: url( Imagenes/light.jpg) no-repeat fixed;
            -webkit-background-size: cover;
            -moz-background-size: cover;
        }
    </style>--%>

    <%--<style>
        .panel.with-nav-tabs .panel-heading {
            padding: 5px 5px 0 5px;
        }

        .panel.with-nav-tabs .nav-tabs {
            border-bottom: none;
        }

        .panel.with-nav-tabs .nav-justified {
            margin-bottom: -1px;
        }
        /********************************************************************/
        /*** PANEL DEFAULT ***/
        .with-nav-tabs.panel-default .nav-tabs > li > a,
        .with-nav-tabs.panel-default .nav-tabs > li > a:hover,
        .with-nav-tabs.panel-default .nav-tabs > li > a:focus {
            color: #777;
        }

            .with-nav-tabs.panel-default .nav-tabs > .open > a,
            .with-nav-tabs.panel-default .nav-tabs > .open > a:hover,
            .with-nav-tabs.panel-default .nav-tabs > .open > a:focus,
            .with-nav-tabs.panel-default .nav-tabs > li > a:hover,
            .with-nav-tabs.panel-default .nav-tabs > li > a:focus {
                color: #777;
                background-color: #ddd;
                border-color: transparent;
            }

        .with-nav-tabs.panel-default .nav-tabs > li.active > a,
        .with-nav-tabs.panel-default .nav-tabs > li.active > a:hover,
        .with-nav-tabs.panel-default .nav-tabs > li.active > a:focus {
            color: #555;
            background-color: #fff;
            border-color: #ddd;
            border-bottom-color: transparent;
        }
    </style>--%>


    <div class="container">
        <div class="page-header">
            <h2>Usuarios</h2>
        </div>
        <div class="row">
            <div class="col-md-8">
                <div class="panel with-nav-tabs panel-default">
                    <div class="panel-heading">
                        <ul class="nav nav-tabs">
                            <li class="active"><a href="#tab1default" data-toggle="tab">Carga</a></li>
                            <li><a href="#tab2default" data-toggle="tab">Modificacion</a></li>
                        </ul>
                    </div>
                    <div class="panel-body">
                        <div class="tab-content">
                            <div class="tab-pane fade in active" id="tab1default">
                                <div class="col-md-offset-3 col-md-12">
                                    <div class="form-login">
                                        <h4>Carga de usuarios</h4>
                                        <input type="text" id="input_nombre" class="form-control input-sm chat-input" placeholder="nombre" runat="server" />
                                        <br />
                                        <input type="text" id="input_apellido" class="form-control input-sm chat-input" placeholder="apellido" runat="server" />
                                        <br />
                                        <input type="text" id="input_usuario" class="form-control input-sm chat-input" placeholder="username" runat="server" />
                                        <br />
                                        <input type="text" id="input_password" class="form-control input-sm chat-input" placeholder="password" runat="server" />
                                        <br />
                                        <asp:DropDownList ID="ddl_tipo" runat="server" CssClass="dropdown"></asp:DropDownList>
                                        <br />
                                        <br />
                                        <asp:Button CssClass="btn btn-info" ID="btn_guardar" runat="server" Text="Guardar" OnClick="btn_guardar_Click" />
                                        <br />
                                    </div>
                                </div>
                            </div>
                            <div class="tab-pane fade" id="tab2default">
                                <div class="col-md-offset-3 col-md-12">
                                    <div class="form-login">
                                        <h4>Modificacion de Usuarios</h4>
                                        <asp:DropDownList ID="ddl_usuarios" runat="server" CssClass="dropdown"></asp:DropDownList>
                                        <asp:Button CssClass="btn btn-info" ID="btn_seleccionar" runat="server" Text="Seleccionar" OnClick="btn_seleccionar_Click" />
                                        <br />
                                        <br />
                                        <input type="text" id="inputm_nombre" class="form-control input-sm chat-input" placeholder="nombre" runat="server" />
                                        <br />
                                        <input type="text" id="inputm_apellido" class="form-control input-sm chat-input" placeholder="apellido" runat="server" />
                                        <br />
                                        <input type="text" id="inputm_username" class="form-control input-sm chat-input" placeholder="username" runat="server" />
                                        <br />
                                        <input type="text" id="inputm_password" class="form-control input-sm chat-input" placeholder="password" runat="server" />
                                        <br />
                                        <asp:Button CssClass="btn btn-info" ID="btn_modificar" runat="server" Text="Confirmar" OnClick="btn_modificar_Click" />
                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>




<%--<div class="col-md-12">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Datos Usuario</h3>
                    <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Label CssClass="col-md-2 control-label" ID="lblContraseña" runat="server" Text="Contraseña:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-4">
                            <asp:Button CssClass="btn btn-info" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                        </div>
                        <div class="col-md-offset-2 col-md-4">
                            <asp:Button CssClass="btn btn-info" ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" />
                        </div>
                        <div class="form-group">
                            <asp:Label CssClass="col-md-2 control-label" ID="LblidUsuario" runat="server" Text="idUsuario:"></asp:Label>
                            <div class="col-md-4">
                                <asp:TextBox ID="txtidUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>--%>


<%-- <div class="col-md-offset-2 col-md-8">
                            <asp:GridView ID="gdvGrilla" runat="server" Visible=" true" AutoGenerateColumns="false" EmptyDataText="No Hay Nada" CssClass="table">
                                <Columns>
                                    <asp:BoundField HeaderText="idUsuario" DataField="idUsuario" />
                                    <asp:BoundField HeaderText="Usuario1" DataField="Usuario1" />
                                    <asp:BoundField HeaderText="Contraseña" DataField="Contraseña" />
                                </Columns>
                            </asp:GridView>
                        </div>--%>
