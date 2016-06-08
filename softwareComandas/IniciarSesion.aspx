<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="softwareComandas.IniciarSesion" %>


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
    </style>
    <div class=" container">
        <br />

        <div class="col-md-12">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Usuarios </h3>
                    <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblNombreUsuario" runat="server" Text="Nombre de Usuario:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Label CssClass="col-md-2 control-label" ID="lblContraseña" runat="server" Text="Contraseña:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />

                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-4">
                            <asp:Button CssClass="btn btn-info" ID="btnRegistrar" runat="server" Text="Registrar" onclick="btnRegistrar_Click"/>
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
