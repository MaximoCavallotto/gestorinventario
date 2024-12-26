using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmDetalle : Form
    {
        private Articulo seleccionado;

        public frmDetalle(Articulo seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
              
        }
       
        private void frmDetalle_Load(object sender, EventArgs e)
        {

            txtboxMarca.Text = seleccionado.Marca.Descripcion;
            txtboxModelo.Text = seleccionado.Modelo;
            txtboxDescripcion.Text = seleccionado.Descripcion;
            txtboxCategoria.Text = seleccionado.Categoria.Descripcion;
            txtboxCodigo.Text = seleccionado.Codigo;
            txtboxPrecio.Text = seleccionado.PrecioFormateado;
            cargarImagen(seleccionado.UrlImagen);
            
        }

        private void btnCerrarDetalle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarImagen(String imagen)
        {
            try
            {
                picboxUrlImagenDetalle.Load(seleccionado.UrlImagen);

            }
            catch (Exception)
            {

                picboxUrlImagenDetalle.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTa9oh_xT4XzP_RhI_kwLBe6fOprEig0e76jQ&s");
            }
        }
    }
}
