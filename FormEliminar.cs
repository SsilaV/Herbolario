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
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim()); 
            listBoxEliminar.Items.Remove(Gestion.Buscar(id));
            Gestion.Eliminar(id);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            if(Gestion.Buscar(id) != null && !listBoxEliminar.Items.Contains(Gestion.Buscar(id))) 
                listBoxEliminar.Items.Add(Gestion.Buscar(id));
        }
    }
}

