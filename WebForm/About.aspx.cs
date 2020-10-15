﻿using System;
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
        public Articulos articuloNuevo { get; set; }
        public List<Articulos> carrito = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCarrito.Text = "Su Compra: ";
            int IDArticulo = Convert.ToInt32(Request.QueryString["IDArticulo"]);
            int quitar = Convert.ToInt32(Request.QueryString["quitar"]);
            if (IDArticulo!=0 && quitar==0)
            {
                try
                {

                    carrito = new List<Articulos>();
                    articuloNuevo = new Articulos();
                    ArticulosNegocio auxNegocio = new ArticulosNegocio();
                    articuloNuevo = auxNegocio.listar().Find(i => i.Id == IDArticulo);

                    if (Session["carrito"] != null)
                    {
                        carrito = (List<Articulos>)Session["carrito"];
                    }
                   
                    carrito.Add(articuloNuevo);
                    Session.Add("carrito", carrito);
                    lblCarrito.Text = "Su Compra: ";
                }
                catch (Exception)
                {
                    Response.Redirect("/error.aspx");
                    //throw ex;
                }

            }
            else if(quitar==1)
            {
                try
                {

                    carrito = new List<Articulos>();
                    articuloNuevo = new Articulos();
                    ArticulosNegocio auxNegocio = new ArticulosNegocio();
                    articuloNuevo = auxNegocio.listar().Find(i => i.Id == IDArticulo);
                    
                    if (Session["carrito"] != null)
                    {
                        carrito = (List<Articulos>)Session["carrito"];
                    }

                    foreach (Articulos item in carrito)
                    {

                        if (articuloNuevo.Id == IDArticulo)
                        {
                            carrito.Remove(item);
                            Session.Add("carrito", carrito);
                            Response.Redirect("About.aspx");
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    //Response.Redirect("/error.aspx");
                    throw ex;
                }
            }
            else
            {
                try
                {
                    
                    carrito = (List<Articulos>)Session["carrito"];
                    lblCarrito.Text = "Su Compra: ";
                }
                catch (Exception)
                {
                    Response.Redirect("/error.aspx");
                    //throw ex;
                }
                
            }

            //ArticulosNegocio negocio = new ArticulosNegocio();
            //carrito = negocio.listar();


        }
    }
}