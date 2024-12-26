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
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }



        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarAlta_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(articulo == null) 
                    articulo = new Articulo();

                articulo.Marca = (Marca)comboxMarca.SelectedItem;
                articulo.Modelo = txtboxModelo.Text;
                articulo.Codigo = txtboxCodArt.Text;
                articulo.Descripcion = txtboxDescripcion.Text;
                articulo.Categoria = (Categoria)comboxCategoria.SelectedItem;
                articulo.UrlImagen = txtboxUrlImagen.Text;
                articulo.Precio = decimal.Parse(txtboxPrecio.Text);

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                   MessageBox.Show("Modificado exitosamente.");
                }

                else
                {
                    negocio.agregarArticulo(articulo);
                    MessageBox.Show("Agregado exitosamente.");
                    
                }

                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
                     
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                comboxCategoria.DataSource = categoriaNegocio.listar();
                comboxCategoria.DisplayMember = "Descripcion";
                comboxCategoria.ValueMember = "Id";

                comboxMarca.DataSource = marcaNegocio.listar();
                comboxMarca.DisplayMember = "Descripcion";
                comboxMarca.ValueMember = "Id";

                if (articulo != null)
                {
                    txtboxCodArt.Text = articulo.Codigo.ToString();
                    txtboxDescripcion.Text = articulo.Descripcion.ToString();
                    txtboxModelo.Text = articulo.Modelo.ToString();
                    txtboxPrecio.Text = articulo.PrecioFormateado.ToString();
                    txtboxUrlImagen.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);

                    comboxCategoria.SelectedValue = articulo.Categoria.Id;
                    comboxMarca.SelectedValue = articulo.Marca.Id;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtboxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtboxUrlImagen.Text);
        }

        public void cargarImagen(String imagen)
        {
            try
            {
                picboxImagenAlta.Load(txtboxUrlImagen.Text);

            }
            catch (Exception)
            {

                picboxImagenAlta.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTa9oh_xT4XzP_RhI_kwLBe6fOprEig0e76jQ&s");
            }
        }
    }
}
