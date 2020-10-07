using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WindowsFormsApp
{
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio auxNegocio = new ArticulosNegocio();
            Articulos auxArticulo = new Articulos();
            List<Articulos> lista = new List<Articulos>();

            if (auxNegocio.buscar(txtCodigo.Text))
            {
                auxArticulo = auxNegocio.cargar(txtCodigo.Text);
                lista.Add(auxArticulo);
                dgvEliminar.DataSource = lista;
                pbEliminar.Load(auxArticulo.ImagenUrl);
            }
            else
            {
                MessageBox.Show("El articulo codigo: "+txtCodigo.Text+" no se encuentra en el catalogo");
            }
            

            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio auxNegocio = new ArticulosNegocio();
            Articulos auxArticulo = new Articulos();

            if (auxNegocio.buscar(txtCodigo.Text))
            {
                if (auxNegocio.eliminar(txtCodigo.Text))
                {
                    MessageBox.Show("El articulo codigo: " + txtCodigo.Text + " se ha eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha podido establecer la conexion con el servidor");
                }
                
            }
            else
            {
                MessageBox.Show("EL Articulo codigo: "+txtCodigo.Text+" no se encuentra en el catalogo");
            }

        }
    }
}
