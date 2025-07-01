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
    public partial class FormRRHHPrincipal: Form
    {
        public FormRRHHPrincipal()
        {
            InitializeComponent();
        }        

        private void btnVerProyectos_Click(object sender, EventArgs e)
        {
            FormRRHHProyectos form = new FormRRHHProyectos();
            form.Show();
            this.Hide();
        }
                
        private void btnVerRubricas_Click(object sender, EventArgs e)
        {
            FormRRHHRubrica form = new FormRRHHRubrica();
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
