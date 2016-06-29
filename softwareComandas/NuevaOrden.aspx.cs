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
        ArticuloNego articuloNego = new ArticuloNego();
        RubroNego rubroNego = new RubroNego();
        SubRubroNego subRubroNego = new SubRubroNego();
        LineaOrdenNego lineaOrdenNego = new LineaOrdenNego();
        DetalleOrdenNego detalleOrdenNego = new DetalleOrdenNego();
        OrdenNego ordenNego = new OrdenNego();
        DetalleOrden detalleOrden = new DetalleOrden();
        Orden orden = new Orden();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("IniciarSesion.aspx");
            }
            if (IsPostBack == false)
            {
                llenarDdlSubRubro_comida();
                llenarDdlSubRubro_bebida();
                llenarDdlSubRubro_otro();
                
                orden.Estado = "pendiente";
                //ordenNego.cargar_orden(orden);
                detalleOrden.Orden.Add(orden);
                //detalleOrdenNego.cargar_detalle_orden(detalleOrden);
            }
        }
        private void llenarDdlSubRubro_comida()
        {
            ddl_rubro_comida.DataSource = subRubroNego.mostrar_subrubros(1);
            ddl_rubro_comida.DataValueField = "id_subrubro";
            ddl_rubro_comida.DataTextField = "nombre";
            ddl_rubro_comida.DataBind();
            ddl_rubro_comida.Items.Insert(0, new ListItem("comida", "0"));
        }
        private void llenarDdlSubRubro_bebida()
        {
            ddl_rubro_bebida.DataSource = subRubroNego.mostrar_subrubros(2);
            ddl_rubro_bebida.DataValueField = "id_subrubro";
            ddl_rubro_bebida.DataTextField = "nombre";
            ddl_rubro_bebida.DataBind();
            ddl_rubro_bebida.Items.Insert(0, new ListItem("bebida", "0"));
        }
        private void llenarDdlSubRubro_otro()
        {
            ddl_rubro_otro.DataSource = subRubroNego.mostrar_subrubros(3);
            ddl_rubro_otro.DataValueField = "id_subrubro";
            ddl_rubro_otro.DataTextField = "nombre";
            ddl_rubro_otro.DataBind();
            ddl_rubro_otro.Items.Insert(0, new ListItem("otro", "0"));
        }

        protected void ddl_rubro_comida_SelectedIndexChanged(object sender, EventArgs e)
        {
            int subrubro = Convert.ToInt32(ddl_rubro_comida.SelectedValue);
            dgrid_comida.DataSource = articuloNego.ListaArticulosPorRubroSubrubro(1, subrubro);
            dgrid_comida.DataBind();
        }

        protected void ddl_rubro_bebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            int subrubro = Convert.ToInt32(ddl_rubro_bebida.SelectedValue);
            dgrid_bebida.DataSource = articuloNego.ListaArticulosPorRubroSubrubro(2, subrubro);
            dgrid_bebida.DataBind();
        }

        protected void ddl_rubro_otro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int subrubro = Convert.ToInt32(ddl_rubro_otro.SelectedValue);
            dgrid_otro.DataSource = articuloNego.ListaArticulosPorRubroSubrubro(3, subrubro);
            dgrid_otro.DataBind();
        }

        protected void dgrid_comida_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int selected_index = int.Parse(e.CommandArgument.ToString());
            string commandName = e.CommandName;

            if (commandName == "cmdClick")
            {

                LineaOrden lineaOrden = new LineaOrden();
                string id_articulo = dgrid_comida.Rows[selected_index].Cells[0].Text;
                lineaOrden.Id_articulo = Convert.ToInt32(id_articulo);
                lineaOrdenNego.cargar_linea_orden(lineaOrden);
                lineaOrden.DetalleOrden.Add(detalleOrden);
            }
        }

        protected void dgrid_bebida_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void dgrid_otro_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void btn_confirmar_orden_Click(object sender, EventArgs e)
        {
            ordenNego.cargar_orden(orden);
            detalleOrdenNego.cargar_detalle_orden(detalleOrden);
        }

    }
}