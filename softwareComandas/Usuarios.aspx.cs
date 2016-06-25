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
            if (IsPostBack == false)
            {
                llenarDdlModificacion();
                llenarDdlCarga();
            }
        }
        private void llenarDdlModificacion()
        {
            ddl_usuarios.DataSource = usuarioNego.mostrar_usuarios();
            ddl_usuarios.DataValueField = "id_usuario";
            ddl_usuarios.DataTextField = "username";
            ddl_usuarios.DataBind();
            ddl_usuarios.Items.Insert(0, new ListItem("seleccione", "0"));
        }
        private void llenarDdlCarga()
        {
            ddl_tipo.Items.Insert(0, new ListItem("seleccione", "0"));
            ddl_tipo.Items.Insert(1, new ListItem("admin", "1"));
            ddl_tipo.Items.Insert(2, new ListItem("user", "2"));
        }
        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            cargarUsuario();
        }
        private void cargarUsuario()
        {
            Usuario u = new Usuario();
            u.Nombre = input_nombre.Value;
            u.Apellido = input_apellido.Value;
            u.Username = input_usuario.Value;
            u.Password = input_password.Value;
            u.Tipo = ddl_tipo.SelectedItem.ToString();
            usuarioNego.cargar_usuario(u);
        }
        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            actualizarCliente();
        }
        private void actualizarCliente()
        {
            Usuario u = new Usuario();
            u.Id_usuario = Convert.ToInt32(ddl_usuarios.SelectedValue);
            u.Nombre = inputm_nombre.Value;
            u.Apellido = inputm_apellido.Value;
            u.Username = inputm_username.Value;
            u.Password = inputm_password.Value;
            usuarioNego.actualizar_usuario(u);
            vaciarCampos();
            ddl_usuarios.SelectedValue = "0".ToString();
        }
        protected void btn_seleccionar_Click(object sender, EventArgs e)
        {
            llenarFormulario();
        }
        private void llenarFormulario()
        {
            int id = Convert.ToInt32(ddl_usuarios.SelectedValue);
            if (id > 0)
            {
                Usuario usuario = usuarioNego.ListaUsuariosPorID(id);
                inputm_apellido.Value = usuario.Apellido;
                inputm_nombre.Value = usuario.Nombre;
                inputm_username.Value = usuario.Username;
                inputm_password.Value = usuario.Password;
            }
            else vaciarCampos();
        }
        private void vaciarCampos()
        {
            inputm_apellido.Value = "";
            inputm_nombre.Value = "";
            inputm_username.Value = "";
            inputm_password.Value = "";
        }

        



        //protected void btnSeleccionar_Click(object sender, EventArgs e)
        //{
        //    llenarFormulario();
        //}
        //private void llenarFormulario()
        //{
        //    int id = Convert.ToInt32(ddlPersona.SelectedValue);
        //    if (id > 0)
        //    {
        //        DataTable dt = PersonaNego.listaPersonasPorID(id);
        //        DataRow row = dt.Rows[0];
        //        txtNombre.Text = Convert.ToString(row[1]);
        //        txtApellido.Text = Convert.ToString(row[2]);
        //        txtEdad.Text = Convert.ToString(row[3]);
        //        txtCiudad.Text = Convert.ToString(row[4]);
        //        dtp_fechanac.Value = Convert.ToString(row[5]);
        //    }
        //    else vaciarCampos();
        //}
        //protected void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32(ddlPersona.SelectedValue);
        //    if (id > 0)
        //    {
        //        Persona persona = new Persona();
        //        persona.Nombre = txtNombre.Text;
        //        persona.Apellido = txtApellido.Text;
        //        persona.Edad = Convert.ToInt32(txtEdad.Text);
        //        persona.Ciudad = txtCiudad.Text;
        //        persona.Nacimiento = Convert.ToDateTime(dtp_fechanac.Value);
        //        PersonaNego personaNego = new PersonaNego();
        //        personaNego.ModificarPersona(persona, id);
        //        vaciarCampos();
        //        ddlPersona.SelectedValue = "0";
        //    }
        //}
        //private void vaciarCampos()
        //{
        //    txtNombre.Text = "";
        //    txtApellido.Text = "";
        //    txtEdad.Text = "";
        //    txtCiudad.Text = "";
        //    dtp_fechanac.Value = "";
        //}
        
    }
}