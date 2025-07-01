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
    public partial class FormRRHHRubrica: Form
    {
        public FormRRHHRubrica()
        {
            InitializeComponent();
        }        

        private void btnVerEvaluacion_Click(object sender, EventArgs e)
        {
            FormRRHHEvaluacion form = new FormRRHHEvaluacion();
            form.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormRRHHProyectos form = new FormRRHHProyectos();
            form.Show();
            this.Hide();
        }
    }
}
