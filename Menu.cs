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
    public partial class Menu : Form
    {
        Gestion gestion;

        public Menu()
        {
            gestion = new Gestion();
            InitializeComponent();
        }
                                                                               
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FormInsertar formInsertar = new FormInsertar();
            formInsertar.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditar formEditar = new FormEditar();
            formEditar.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FormListar formListar = new FormListar();
            formListar.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormEliminar formEliminar = new FormEliminar();
            formEliminar.Show();
        }
    }
}
