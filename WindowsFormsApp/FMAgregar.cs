using Dominio;
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
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class FMAgregar : Form
    {
        private Articulos articulo = null;

        public FMAgregar()
        {
            InitializeComponent();
        }

        public FMAgregar (Articulos art)
       {
          InitializeComponent();
          articulo = art;
       }

        

        private void btaceptar_Click(object sender, EventArgs e)
        {
            //Articulos nuevo = new Articulos();
            //ArticulosNegocio Negocio = new ArticulosNegocio();

            // nuevo.Nombre = txtnombre.Text;
            //nuevo.Descripcion = txtdescripcion.Text;

            //Negocio.Agregar(nuevo);

            // MessageBox.Show("Articulo agregado exitosamente!");
            // Close();

            //CODIGO PREVIO ARRIBA

            ArticulosNegocio negocio = new ArticulosNegocio();
            if (articulo == null)
                articulo = new Articulos();
            
            articulo.Codigo = txtcodigo.Text;
            articulo.Nombre = txtnombre.Text;
            articulo.Descripcion = txtdescripcion.Text;
            articulo.ImagenUrl = txtimagen.Text;
            articulo.marca= (Marca)cbmarca.SelectedItem;
            articulo.categoria = (Categoria)cbcategoria.SelectedItem;
            articulo.Precio = Convert.ToDecimal(txtprecio.Text);

            if (articulo.Id == 0)
                negocio.Agregar(articulo);
            else
                negocio.modificar(articulo);

            MessageBox.Show("Operacion realizada exitosamente!");
            Close();

        }

        private void FMAgregar_Load(object sender, EventArgs e)
        {
           // MarcaNegocio marcaNegocio = new MarcaNegocio();

           // cbmarca.DataSource = marcaNegocio.listar();

           // CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            //cbcategoria.DataSource = categoriaNegocio.listar();

            //CODIGO PREVIO ARRIBA

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cbmarca.DataSource = marcaNegocio.listar();
            cbmarca.ValueMember = "ID";
            cbmarca.DisplayMember = "Descripcion";

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbcategoria.DataSource = categoriaNegocio.listar();
            cbcategoria.ValueMember = "ID"; 
            cbcategoria.DisplayMember= "Descripcion";

            cbmarca.SelectedIndex = -1;
            cbcategoria.SelectedIndex = -1;

            if (articulo !=null)
            {
                SqlCommand comando = new SqlCommand();
                
                txtcodigo.Text = articulo.Codigo;
                txtnombre.Text = articulo.Nombre;
                txtdescripcion.Text = articulo.Descripcion;
                txtimagen.Text = articulo.ImagenUrl;
               
                txtprecio.Text = Convert.ToString(articulo.Precio);
                cbmarca.SelectedValue = articulo.marca.ID;
                cbcategoria.SelectedValue = articulo.categoria.ID;
                Text = "Formulario de modificacion";
            }

        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if((e.KeyChar <48 || e.KeyChar>57||e.KeyChar==46)&& e.KeyChar != 8)
            //{
            //    e.Handled = true;
            //}
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
