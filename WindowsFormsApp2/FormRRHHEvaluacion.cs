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
    public partial class FormRRHHEvaluacion: Form
    {
        public FormRRHHEvaluacion()
        {
            InitializeComponent();
        }
                
        private void btnRegistrarEvaluacion_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormRRHHRubrica form = new FormRRHHRubrica();
            form.Show();
            this.Hide();
        }
    }
}
