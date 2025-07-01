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
    public partial class FormFinanzas5: Form
    {
        public FormFinanzas5()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormFinanzas1 form = new FormFinanzas1();
            form.Show();
            this.Hide();
        }

        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            FormFinanzas6 form = new FormFinanzas6();
            form.Show();
            this.Hide();
        }
    }
}
