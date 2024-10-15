using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerbolarioViolero.Clases;

namespace HerbolarioViolero
{
    public partial class FormInsertar : Form
    {
        private List<CasaComercial> casas;
        private List<Producto> productos;

        public FormInsertar()
        {
            InitializeComponent();
            CargarCasas();
            CargarListaProductos();
            LimpiarCampos();
        }

        private void CargarCasas()
        {
            casas = CasaComercial.CargarCasas();
            foreach (CasaComercial casa in casas)
            {
                comboBoxCasas.Items.Add(casa);
            }
        }

        private void CargarListaProductos()
        {
            productos = Gestion.Listar();
            listBoxInsertar.Items.Clear();
            foreach (Producto producto in productos)
            {
                listBoxInsertar.Items.Add(producto.ToString());
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = Gestion.CalcularId().ToString();
            txtNombre.Clear();
            txtDescripcion.Clear();
            comboBoxCasas.SelectedIndex = -1;
            txtAtributo1.Clear();
            txtAtributo2.Clear();
        }

        private void rbtnAlimentacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAlimentacion.Checked == true)
            {
                lblAtributo1.Text = "Alérgeno";
                lblAtributo1.Visible = true;
            }
        }

        private void rbtnEcologico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEcologico.Checked == true) {
                lblAtributo1.Text = "Alérgeno";
                lblAtributo2.Text = "Certificación";
                lblAtributo2.Visible = true;
                txtAtributo2.Visible = true;
            }
        }

        private void rbtnAdelgazante_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAdelgazante.Checked == true)
            {
                lblAtributo1.Text = "Alérgeno";
                lblAtributo2.Visible = false;
                txtAtributo2.Visible = false;
            }
        }

        private void rbtnIntolerancia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnIntolerancia.Checked == true)
            {
                lblAtributo1.Text = "Alérgeno";
                lblAtributo2.Text = "Intolerancia";
                lblAtributo2.Visible = true;
                txtAtributo2.Visible = true;
            }
        }

        private void rbtnCorporal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCorporal.Checked == true)
            {
                lblAtributo1.Text = "Modo Empleo";
                lblAtributo2.Visible = false;
                txtAtributo2.Visible = false;
            }
        }

        private void rbtnDeporte_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDeporte.Checked == true)
            {
                lblAtributo1.Text = "Deporte";
                lblAtributo2.Visible = false;
                txtAtributo2.Visible = false;
            }
        }

        private void rbtnSuplemento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSuplemento.Checked == true)
            {
                lblAtributo1.Text = "Composición";
                lblAtributo2.Visible = false;
                txtAtributo2.Visible = false;
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Producto producto = null;
            Anadir(producto);
        }

        public void Anadir(Producto producto)
        {
            if (txtNombre.Text.Trim() == ""
                || txtDescripcion.Text == ""
                || comboBoxCasas.SelectedIndex == -1)

            {
                MessageBox.Show("Debe rellenar todos los campos del formulario",
                    "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String tipoProducto = "";

            if (rbtnAlimentacion.Checked)
            {
                producto = new PAlimentacion(Convert.ToInt32(txtId.Text),
                    txtNombre.Text, txtDescripcion.Text,
                    (CasaComercial)comboBoxCasas.SelectedItem,
                    txtAtributo1.Text);
                tipoProducto = "Alimentación";
            }
            else if (rbtnEcologico.Checked)
            {
                producto = new PAEcologico(Convert.ToInt32(txtId.Text),
                    txtNombre.Text, txtDescripcion.Text,
                    (CasaComercial)comboBoxCasas.SelectedItem,
                    txtAtributo1.Text, txtAtributo1.Text);
                tipoProducto = "Ecológico";
            }
            else if (rbtnAdelgazante.Checked)
            {
                producto = new PAAdelgazante(Convert.ToInt32(txtId.Text),
                    txtNombre.Text, txtDescripcion.Text,
                    (CasaComercial)comboBoxCasas.SelectedItem,
                    txtAtributo1.Text);
                tipoProducto = "Adelgazante";
            }
            else if (rbtnIntolerancia.Checked)
            {
                producto = new PAIntolerancia(Convert.ToInt32(txtId.Text),
                    txtNombre.Text, txtDescripcion.Text,
                    (CasaComercial)comboBoxCasas.SelectedItem,
                    txtAtributo1.Text, txtAtributo1.Text);
                tipoProducto = "Intolerancia";
            }
            else if (rbtnCorporal.Checked)
            {
                producto = new PCorporal(Convert.ToInt32(txtId.Text),
                    txtNombre.Text, txtDescripcion.Text,
                    (CasaComercial)comboBoxCasas.SelectedItem,
                    txtAtributo1.Text);
            }
            else if (rbtnDeporte.Checked)
            {
                producto = new PDeporte(Convert.ToInt32(txtId.Text),
                    txtNombre.Text, txtDescripcion.Text,
                    (CasaComercial)comboBoxCasas.SelectedItem,
                    txtAtributo1.Text);
                tipoProducto = "Deporte";
            }
            else if (rbtnSuplemento.Checked)
            {
                producto = new PSuplemento(Convert.ToInt32(txtId.Text),
                    txtNombre.Text, txtDescripcion.Text,
                    (CasaComercial)comboBoxCasas.SelectedItem,
                    txtAtributo1.Text);
                tipoProducto = "Suplemento";
            }

            Gestion.Insertar(producto);

            MessageBox.Show("Producto " + tipoProducto + " insertado correctamente",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarListaProductos();
            LimpiarCampos();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
