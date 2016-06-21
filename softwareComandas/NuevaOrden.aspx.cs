using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace softwareComandas
{
    public partial class NuevaOrden : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IniciarSesion"] == null)
            {
                Response.Redirect("NuevaOrden.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Correct", "alert('No se Inicio Sesión de Usuario.')", true);

            }

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCarne_Click(object sender, EventArgs e)
        {
            llenarGrilla(1);

        }
        private void llenarGrilla(int tipo)
        {
            ComidaNego comidaNego = new ComidaNego();

            gdvComida.DataSource = comidaNego.MostrarComidaXTipo(tipo);
            gdvComida.DataBind();


        }

        protected void btnPollo_Click(object sender, EventArgs e)
        {
            llenarGrilla(2);
        }

        protected void btnVegario_Click(object sender, EventArgs e)
        {
            llenarGrilla(3);
        }

    }
}