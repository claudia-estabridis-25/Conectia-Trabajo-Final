using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormInventario1: Form
    {
        public FormInventario1()
        {
            InitializeComponent();
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            FormInventario4 form = new FormInventario4();
            form.Show();
            this.Hide();
        }

        private void btnVerMantenimiento_Click(object sender, EventArgs e)
        {
            FormInventario3 form = new FormInventario3();
            form.Show();
            this.Hide();
        }

        private void btnVerStock_Click(object sender, EventArgs e)
        {
            FormInventario2 form = new FormInventario2();
            form.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormMenúPrincipal form = new FormMenúPrincipal();
            form.Show();
            this.Hide();
        }
    }
}
