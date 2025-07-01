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
    public partial class ReporteGastosCategorizados : Form
    {
        public ReporteGastosCategorizados()
        {
            InitializeComponent();
        }

        private void btnSALIRgastos_Click(object sender, EventArgs e)
        {
            FormFinanzas1 form = new FormFinanzas1();
            form.Show();
            this.Hide();
        }
    }
}
