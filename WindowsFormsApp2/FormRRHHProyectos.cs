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
              
        private void btnVerEvaluaciones_Click(object sender, EventArgs e)
        {
            FormRRHHRubrica form = new FormRRHHRubrica();
            form.Show();
            this.Hide();
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            FormReporteRRHH form = new FormReporteRRHH();
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
