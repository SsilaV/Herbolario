using HerbolarioViolero.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerbolarioViolero
{
    public partial class FormEditar : Form
    {
        private List<CasaComercial> casas;
        private List<Producto> productos;

        public FormEditar()
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
            listBoxEditar.Items.Clear();
            foreach (Producto producto in productos)
            {
                listBoxEditar.Items.Add(producto.ToString());
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            comboBoxCasas.SelectedIndex = -1;
            txtAtributo1.Clear();
            txtAtributo2.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe indicar un Id",
                    "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto producto = Gestion.Buscar(Convert.ToInt32(txtIdEditar.Text));

            if (producto == null)
            {
                MessageBox.Show("No se encuentran productos con ese Id",
                    "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtNombre.Text = producto.GetNombre();
            txtDescripcion.Text = producto.GetDescripcion();
            //int indice = comboBoxCasas.Items.IndexOf(producto.GetCasa());
            //comboBoxCasas.SelectedIndex = indice;

            lblNombre.Visible = true;
            txtNombre.Visible = true;
            lblDescripcion.Visible = true;
            txtDescripcion.Visible = true;
            comboBoxCasas.Visible = true;
            groupBoxProducto.Visible = true;
            lblAtributo1.Visible = true;
            txtAtributo1.Visible = true;
            lblAtributo2.Visible = true;
            txtAtributo2.Visible = true;

            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e, FormInsertar formInsertar)
        {
            Producto producto = null;
            int id = Convert.ToInt32(txtIdEditar.Text.Trim());
            for(int i = 0; i < productos.Count; i++)
            {
                if (productos[i].GetId() == id)
                {
                    producto = productos[i];
                    productos.Remove(productos[i]);
                }
            }
            //---cortado y copiado
            Type tipoProducto = producto.GetType();
            if (tipoProducto.Equals(typeof(PAlimentacion)))
            {
                PAlimentacion pa = (PAlimentacion)producto;
                txtAtributo1.Text = pa.GetAlergeno();

                rbtnAlimentacion.Checked = true;
            }
            else if (tipoProducto.Equals(typeof(PAEcologico)))
            {
                PAEcologico pae = (PAEcologico)producto;
                txtAtributo1.Text = pae.GetAlergeno();
                txtAtributo2.Text = pae.GetCertificacion();
                lblAtributo1.Text = "Alergeno";
                lblAtributo2.Text = "Certificación";

                rbtnEcologico.Checked = true;
                lblAtributo2.Visible = true;
                txtAtributo2.Visible = true;
            }
            else if (tipoProducto.Equals(typeof(PAAdelgazante)))
            {
                rbtnAdelgazante.Checked = true;
                PAAdelgazante paa = (PAAdelgazante)producto;
                txtAtributo1.Text = paa.GetAlergeno();
                lblAtributo1.Text = "Alergeno";

                rbtnEcologico.Checked = true;
            }
            else if (tipoProducto.Equals(typeof(PAIntolerancia)))
            {
                PAIntolerancia pai = (PAIntolerancia)producto;
                txtAtributo1.Text = pai.GetAlergeno();
                txtAtributo2.Text = pai.GetIntolerancia();
                lblAtributo1.Text = "Alergeno";
                lblAtributo2.Text = "Intolerancia";

                rbtnIntolerancia.Checked = true;
                lblAtributo2.Visible = true;
                txtAtributo2.Visible = true;
            }
            else if (tipoProducto.Equals(typeof(PCorporal)))
            {
                PCorporal pc = (PCorporal)producto;
                txtAtributo1.Text = pc.GetModoEmpleo();
                lblAtributo1.Text = "Modo Empleo";

                rbtnCorporal.Checked = true;
            }
            else if (tipoProducto.Equals(typeof(PDeporte)))
            {
                PDeporte pd = (PDeporte)producto;
                txtAtributo1.Text = pd.GetDeporte();
                lblAtributo1.Text = "Deporte";

                rbtnDeporte.Checked = true;
            }
            else if (tipoProducto.Equals(typeof(PSuplemento)))
            {
                PSuplemento ps = (PSuplemento)producto;
                txtAtributo1.Text = ps.GetComposicionQuimica();
                lblAtributo1.Text = "Composición";
                rbtnSuplemento.Checked = true;
            }

            formInsertar.Anadir(producto);
            //----
            /*Gestion.Insertar(producto);

            MessageBox.Show("Producto " + tipoProducto + " insertado correctamente",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarListaProductos();
            LimpiarCampos();
            listBoxEditar.Items.Clear();
            listBoxEditar.Items.AddRange(productos.ToArray());*/
        }
    }
}
