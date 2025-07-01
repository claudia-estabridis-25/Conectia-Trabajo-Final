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
    public partial class FrmRecursosHumanos1: Form
    {
        public FrmRecursosHumanos1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormMenúPrincipal form = new FormMenúPrincipal();
            form.Show();
            this.Hide();
        }

        private void btnVerProyectos_Click(object sender, EventArgs e)
        {
            FrmRecursosHumanos2 form = new FrmRecursosHumanos2();
            form.Show();
            this.Hide();
        }
    }
}
