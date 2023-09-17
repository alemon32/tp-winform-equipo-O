using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_equipo_O
{
    public partial class FormaInicio : Form
    {
        private List<Articulo> listaArticulo;
        public FormaInicio()
        {
            InitializeComponent();
        }

        private void FormaInicio_Load(object sender, EventArgs e)
        {
            cargar();
            comboBoxCampo.Items.Add("Codigo Articulo");
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Marca");
            comboBoxCampo.Items.Add("Categoria");
            comboBoxCampo.Items.Add("Precio");
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dataGridViewArticuloBD.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].Imagen.ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dataGridViewArticuloBD.Columns["Id"].Visible = false;
            dataGridViewArticuloBD.Columns["Imagen"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxArticulo.Load("https://www.came-educativa.com.ar/wp-content/uploads/2022/03/placeholder-3.png");
            }
        }

        private void dataGridViewArticuloBD_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewArticuloBD.CurrentRow != null)
            {
                Articulo selecionado = (Articulo)dataGridViewArticuloBD.CurrentRow.DataBoundItem;
                cargarImagen(selecionado.Imagen.ImagenUrl);
            }
        }

        private void buttonAgregarArticulo_Click(object sender, EventArgs e)
        {
            FormAltaBajaModificacion form2 = new FormAltaBajaModificacion();
            form2.ShowDialog();
            cargar();
        }

        private void buttonModificiarArticulo_Click(object sender, EventArgs e)
        {
            Articulo selecionado;
            selecionado = (Articulo)dataGridViewArticuloBD.CurrentRow.DataBoundItem;

            FormAltaBajaModificacion modificar = new FormAltaBajaModificacion(selecionado);
            modificar.ShowDialog();
            cargar();
        }

        private void buttonEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Estas seguro de elimnar el articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dataGridViewArticuloBD.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    MessageBox.Show("Articulo eliminado del inventario");
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Comienza con");
                comboBoxCriterio.Items.Add("Termina con");
                comboBoxCriterio.Items.Add("Contiene");
            }
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }

        private bool validarFiltro()
        {
            if (comboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione los campos para filtrar");
                return true;
            }
            if (comboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione los campos para filtrar");
                return true;
            }
            if (comboBoxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(textBoxFiltro.Text))
                {
                    MessageBox.Show("Indicar el numero en el campo filtro");
                    return true;
                }
                if (!(soloNumeros(textBoxFiltro.Text)))
                {
                    MessageBox.Show("Por favor ingresar solo numeros al filtrar por un campo numerico");
                    return true;
                }
            }

            return false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltro.Text;
                dataGridViewArticuloBD.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
