﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data.OleDb;
using System.Data;

namespace softwareComandas
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        UsuarioNego usuarioNego = new UsuarioNego();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            IngresarDatos();
        }

        private void IngresarDatos() //Botón de de ingreso a sesion de usuario, comparando los ID en base de datos
        {
            
            DataTable objdt = new DataTable();
            objdt = usuarioNego.CompararUsuario(txtidUser.Text, txtUsuario.Text, txtpassword.Text);
   
            if (objdt.Rows.Count !=  0)
            {
                Session["IniciarSesion"] = objdt;
                Response.Redirect("NuevaOrden.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('Error en Ingreso de Usuario Y contraseña.')", true);

            }
        }

       
    }
}