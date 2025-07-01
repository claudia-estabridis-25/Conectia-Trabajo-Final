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
    public partial class FormFinanzas6: Form
    {
        public FormFinanzas6()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormFinanzas5 form = new FormFinanzas5();
            form.Show();
            this.Hide();
        }
    }
}
