<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="softwareComandas.IniciarSesion" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <br />

    <div class="col-md-4 col-md-offset-4">
        <div class="panel panel-default">
            <div class="panel-heading">
                <h3 class="panel-title">Ingreso de Usuarios</h3>
            </div>
            <div class="panel-body">

                
                    <div class="form-group">
                        <input class="form-control" placeholder="Nombre de Usuario" name="Usuario" type="text">
                    </div>
                    <div class="form-group">
                        <input class="form-control" placeholder="Contraseña" name="contraseña" type="password" value="">
                    </div>
                    <div class="checkbox">
                        <label>
                            <input name="remember" type="checkbox" value="Recordar Contraseña">
                            Recordar Contraseña
                        </label>
                    </div>
                    <input class="btn btn-lg btn-success btn-block" type="submit" value="Ingresar">
                

                <hr />
                <center><h4> </h4></center>
                <input class="btn btn-lg btn-facebook btn-block" type="submit" value="Ingresar via facebook">
            </div>
        </div>
    </div>



</asp:Content>
