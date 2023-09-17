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

namespace TPWinForm_equipo_O
{
    public partial class FormAltaBajaModificacion : Form
    {
        private Articulo articulo = null;
        
        public FormAltaBajaModificacion()
        {
            InitializeComponent();
            if (articulo == null)
            {
                textBoxUrlImagen.Visible = false;
                labelUrlImagen.Visible = false;
            }
        }

        public FormAltaBajaModificacion(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                articulo.CodArticulo = textBoxCodArticulo.Text;
                articulo.Nombre = textBoxNombre.Text;
                articulo.Descripcion = textBoxDescripcion.Text;
                articulo.Imagen.ImagenUrl = textBoxUrlImagen.Text;
                articulo.Marca = (Marca)comboBoxMarca.SelectedItem;
                articulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(textBoxPrecio.Text);

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado en el inventario");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado en el inventario");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormAltaBajaModificacion_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                comboBoxMarca.DataSource = marcaNegocio.listar();
                comboBoxMarca.ValueMember = "Id";
                comboBoxMarca.DisplayMember = "Descripcion";
                comboBoxCategoria.DataSource = categoriaNegocio.listar();
                comboBoxCategoria.ValueMember = "Id";
                comboBoxCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    textBoxCodArticulo.Text = articulo.CodArticulo;
                    textBoxNombre.Text = articulo.Nombre;
                    textBoxDescripcion.Text = articulo.Descripcion;
                    textBoxUrlImagen.Text = articulo.Imagen.ImagenUrl;
                    cargarImagen(articulo.Imagen.ImagenUrl);
                    comboBoxMarca.SelectedValue = articulo.Marca.Id;
                    comboBoxCategoria.SelectedValue = articulo.Categoria.Id;
                    textBoxPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void textBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            try
            {
                cargarImagen(textBoxUrlImagen.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cargarImagen(string imagenUrl)
        {
            try
            {
                pictureBoxArticulo.Load(imagenUrl);
            }
            catch (Exception)
            {
                pictureBoxArticulo.Load("https://www.came-educativa.com.ar/wp-content/uploads/2022/03/placeholder-3.png");
            }
        }
    }
}
