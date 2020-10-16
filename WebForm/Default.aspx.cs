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
    public partial class _Default : Page
    {
        public Articulos busqueda { get; set; }
        public List<Articulos>listaarticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            listaarticulo = negocio.listar();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        //EVENTO CLICK PARA REVISAR

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            List<Articulos> listaAux;
            try
            {
                listaAux = negocio.listar();
                //int idArticulo = Convert.ToInt32(txtArticulo.Text);
                int idArticulo = listaAux.Find(i => i.Nombre.ToLower().Contains(txtArticulo.Text.ToLower())).Id;
                
               
                Response.Redirect("Detalle.aspx?idArticulo=" + idArticulo.ToString());
            }
            catch (Exception ex)
            {
                //Response.Redirect("Error.aspx");
                throw ex;

            }


        }
    }
}