using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebForm
{ 
    public partial class About : Page
    {
        public List<Articulos> carrito = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio auxNegocio = new ArticulosNegocio();
            Articulos auxArticulo = new Articulos();
            
            if (carrito == null)
            {
                lblCarrito.Text = "No se ha agregado ningun articulo al carrito";
            }
        }
    }
}