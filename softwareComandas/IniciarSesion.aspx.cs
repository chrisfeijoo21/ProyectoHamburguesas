using System;
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
            if (global.usuario != null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('Estas logeado como "+global.usuario+"')", true);
            }
        }
        protected void btn_validar_Click(object sender, EventArgs e)
        {
            validar();
        }
        private void validar()
        {
            Usuario u = usuarioNego.validar_usuario(input_usuario.Value, input_password.Value);
            if (u != null)
            {
                global.usuario = input_usuario.Value;
                Response.Redirect("NuevaOrden.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('Wrong user id aand password.')", true);
            }
        }
    }
}