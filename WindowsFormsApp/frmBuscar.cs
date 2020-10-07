using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApp
{
    public partial class frmBuscar : Form
    {
        //private Articulos articulo = null; COMENTE LAS LINEAS PORQUE VAN EN EL FORM AGREGAR

        public frmBuscar()
        {
            InitializeComponent();
        }
        //public frmBuscar(Articulos art)
        // {
        //   InitializeComponent();
        //    articulo = art;
        // }

        //public Articulos articuloguardado = new Articulos();
        private void cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            dgvBuscar.DataSource = negocio.listar();
            dgvBuscar.Columns[2].Visible = false;

        }
        private void btnBuscar_Click(object sender, EventArgs e) // SI PONES UN DATO QUE NO EXISTE PINCHA. 
        {
            //Elimine el codigo de prueba

            ArticulosNegocio auxNegocio = new ArticulosNegocio();
            Articulos auxArticulo = new Articulos();


            auxArticulo.marca = new Marca();
            auxArticulo.categoria = new Categoria();

            if (auxNegocio.buscar(txtBuscar.Text))
            {
                auxArticulo = auxNegocio.cargar(txtBuscar.Text);
                List<Articulos> lista = new List<Articulos>();
                lista.Add(auxArticulo);
           
                dgvBuscar.DataSource = lista;
            }
            else
            {
                MessageBox.Show("El articulo codigo: "+txtBuscar.Text+" no se encuentra en el catalogo.");
            }


        }


        private void txtdetalle_click(object sender, EventArgs e)
        {
            
            ArticulosNegocio auxNegocio = new ArticulosNegocio();
            Articulos auxArticulo = new Articulos();

            auxArticulo.marca = new Marca();
            auxArticulo.categoria = new Categoria();

            if (dgvBuscar.SelectedRows.Count ==1)
            {
                //string codigo = Convert.ToString(dgvBuscar.CurrentRow.Cells[1].Value);
                
                //articuloguardado= auxNegocio.cargar(txtBuscar.Text);
                //FMAgregar agregar = new FMAgregar(auxArticulo);
                //agregar.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("No selecciono ningun articulo!");

            }

        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            Articulos art;
            art = (Articulos)dgvBuscar.CurrentRow.DataBoundItem;

            FMAgregar modificar = new FMAgregar(art); //REUTILIZO EL FM AGREGAR PARA MODIFICAR
            modificar.ShowDialog();
            cargar();// VERIFICAR
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio auxNegocio = new ArticulosNegocio();
            Articulos auxArticulo = (Articulos)dgvBuscar.CurrentRow.DataBoundItem;

           
                if (auxNegocio.eliminar(auxArticulo.Codigo))
                {
                    MessageBox.Show("El articulo codigo: " + auxArticulo.Codigo + " se ha eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha podido establecer la conexion con el servidor");
                }
        }

    }
}
