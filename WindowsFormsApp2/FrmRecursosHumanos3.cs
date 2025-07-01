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
    public partial class FrmRecursosHumanos3: Form
    {
        public FrmRecursosHumanos3()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmRecursosHumanos2 form = new FrmRecursosHumanos2();
            form.Show();
            this.Hide();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            FrmRecursosHumanos4 form = new FrmRecursosHumanos4();
            form.Show();
            this.Hide();
        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            FrmRecursosHumanos5 form = new FrmRecursosHumanos5();
            form.Show();
            this.Hide();
        }
    }
}
