using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace WindowsFormsApp
{
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticulosNegocio Negocio = new ArticulosNegocio();
            DGVLista.DataSource = Negocio.listar();
            DGVLista.Columns[3].Visible = false;
            
        }

        private void DGVLista_SelectionChanged(object sender, EventArgs e)
        {
            //Este try no haria falta porque todo tiene imagen
            try
            {
                Articulos articulo = (Articulos)DGVLista.CurrentRow.DataBoundItem;
                pbarticulo.Load(articulo.ImagenUrl);
            }
            catch (Exception)
            {

           
            }
            
        }

        private void DGVLista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmBuscar buscar = new frmBuscar();
            buscar.ShowDialog();
        }
    }
}
