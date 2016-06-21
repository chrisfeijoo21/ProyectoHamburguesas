using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data;
using System.Data.Sql;

namespace softwareComandas
{
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        UsuarioNego usuarioNego = new UsuarioNego();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarUsuario();
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarUsuario();
        }

        private void GuardarUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.IdUsuario = Convert.ToInt32(txtidUsuario.Text);
            usuario.Usuario1 = txtUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;

            usuarioNego.CargaUsuario(usuario);

        }
        private void MostrarUsuario()
        {
            gdvGrilla.DataSource = usuarioNego.MostrarUsuario().ToList();
            gdvGrilla.DataBind();
        }
    }
}