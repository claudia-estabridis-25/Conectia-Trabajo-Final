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
    public partial class FormRRHHProyectos : Form
    {
        public FormRRHHProyectos()
        {
            InitializeComponent();
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            FormRRHHReporte form = new FormRRHHReporte();
            form.Show();
            this.Hide();
        }        

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            FormRRHHTareas form = new FormRRHHTareas();
            form.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormRRHHPrincipal form = new FormRRHHPrincipal();
            form.Show();
            this.Hide();
        }
    }
}
