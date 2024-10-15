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
    public partial class FormListar : Form
    {
        private List<Producto> productos;

        public FormListar()
        {
            InitializeComponent();
        }

        private void CargarListaProductos(string tipo)
        {
            productos = Gestion.Filtrar(tipo);
            listBoxListar.Items.Clear();
            listBoxListar.Items.AddRange(productos.ToArray());
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            CargarListaProductos("Alimentación");
        }
    }
}
