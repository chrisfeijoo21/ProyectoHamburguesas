<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="softwareComandas.RegistroUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row {
            margin-top: 40px;
            padding: 0 10px;
        }

        .clickable {
            cursor: pointer;
        }

        .panel-heading span {
            margin-top: -20px;
            font-size: 15px;
        }

        body {
            background: url( Imagenes/Homemade_Thanksgiving.jpg) no-repeat fixed;
            -webkit-background-size: cover;
            -moz-background-size: cover;
            
        }
    </style>

    <div class="container">
        <br />

        <div class="col-md-12">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Datos Usuario</h3>
                    <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Label CssClass="col-md-2 control-label" ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblEdad" runat="server" Text="Edad:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtEdad" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Label CssClass="col-md-2 control-label" ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Label CssClass="col-md-2 control-label" ID="lblLocalidad" runat="server" Text="Localidad:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtLocalidad" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
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
                    </div>
                    <br />
                    <div class="form-group">

                        <div class="col-md-offset-2 col-md-8">
                            <asp:GridView ID="gdvGrilla" runat="server" Visible=" true" AutoGenerateColumns="false" EmptyDataText="No Hay Nada" CssClass="table">
                                <Columns>
                                    <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                                    <asp:BoundField HeaderText="Apellido" DataField="apellido" />
                                    <asp:BoundField HeaderText="Edad" DataField="edad" />
                                    <asp:BoundField HeaderText="Direccion" DataField="direccion" />
                                    <asp:BoundField HeaderText="Telefono" DataField="telefono" />
                                    <asp:BoundField HeaderText="Localidad" DataField="localidad" />
                                    <asp:BoundField HeaderText="Usuario" DataField="usuario" />
                                    <asp:BoundField HeaderText="Contraseña" DataField="contraseña" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        $(document).on('click', '.panel-heading span.clickable', function (e) {
            var $this = $(this);
            if (!$this.hasClass('panel-collapsed')) {
                $this.parents('.panel').find('.panel-body').slideUp();
                $this.addClass('panel-collapsed');
                $this.find('i').removeClass('glyphicon-chevron-up').addClass('glyphicon-chevron-down');
            } else {
                $this.parents('.panel').find('.panel-body').slideDown();
                $this.removeClass('panel-collapsed');
                $this.find('i').removeClass('glyphicon-chevron-down').addClass('glyphicon-chevron-up');
            }
        })
    </script>

</asp:Content>
