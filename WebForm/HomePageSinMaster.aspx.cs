using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Web.UI.HtmlControls;

namespace WebForm
{
    public partial class HomePageSinMaster : System.Web.UI.Page
    {
        public List<Articulos> listaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio aux = new ArticulosNegocio();
            listaArticulos = aux.listar();
        }

        

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }
    }
}