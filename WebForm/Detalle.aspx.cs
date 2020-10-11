using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class Detalle : System.Web.UI.Page
    {
        public Articulos detalle { get; set; }
        public List<Articulos> listaarticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            List<Articulos>listaAux;
            try
            {
                listaAux = negocio.listar();
                int idart = Convert.ToInt32(Request.QueryString["idArticulo"]);
                detalle = listaAux.Find(i => i.Id == idart);

            }
            catch (Exception)
            {
                
                Response.Redirect("Error.aspx");
            }
        }
    }
}