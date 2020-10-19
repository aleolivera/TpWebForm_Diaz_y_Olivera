using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
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
            ArticulosNegocio auxNegocio = new ArticulosNegocio();

            listaarticulo = (List<Articulos>)Session["ListaFiltrada"];
            if (Session["ListaFiltrada"] == null||listaarticulo.Count()==0)
            {
                
                listaarticulo = auxNegocio.listar();
                //Session.Add("ListaFiltrada", listaarticulo);
            }

            
            Session.Add("ListaFiltrada", new List<Articulos>());

            
            //ArticulosNegocio negocio = new ArticulosNegocio();
            //listaarticulo = negocio.listar();
        }


        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //ArticulosNegocio negocio = new ArticulosNegocio();
            //List<Articulos> listaAux;
            //try
            //{
            //    listaAux = negocio.listar();
            //    //int idArticulo = Convert.ToInt32(txtArticulo.Text);
            //    int ID = listaAux.Find(i => i.Nombre.ToLower().Contains(txtArticulo.Text.ToLower())).Id;

            //    Response.Redirect("Detalle.aspx?idArticulo=" + ID.ToString());
            //}
            //catch (Exception ex)
            //{
            //    //Response.Redirect("Error.aspx");
            //    throw ex;

            //}

            List<Articulos> listaAux = new List<Articulos>();
            ArticulosNegocio Negocio = new ArticulosNegocio();
            string auxString = txtArticulo.Text.ToLower();
            try
            {
                listaAux=Negocio.listar();
                listaarticulo = listaAux.FindAll(i=> i.Nombre.ToLower().Contains(auxString) || i.Codigo.ToLower().Contains(auxString) || i.marca.descripcion.ToLower().Contains(auxString)|| i.categoria.descripcion.ToLower().Contains(auxString));
                Session.Add("ListaFiltrada",listaarticulo);
                Response.Redirect("Default.aspx"); 
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}