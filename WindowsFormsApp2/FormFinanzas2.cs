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
    public partial class FormFinanzas2: Form
    {
        public FormFinanzas2()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormFinanzas1 form = new FormFinanzas1();
            form.Show();
            this.Hide();
        }

        private void btnVerGastos_Click(object sender, EventArgs e)
        {
            FormFinanzas3 form = new FormFinanzas3();
            form.Show();
            this.Hide();
        }
    }
}
