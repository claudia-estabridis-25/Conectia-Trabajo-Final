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
    public partial class FormMenúPrincipal : Form
    {
        public FormMenúPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRecursosHumanos1 obj = new FrmRecursosHumanos1();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmInventario obj = new FrmInventario();
            obj.Show();
        }

        private void btnControlFinanciero_Click(object sender, EventArgs e)
        {
            FormFinanzas1 obj = new FormFinanzas1();
            obj.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            FormIniciarSesion form = new FormIniciarSesion();
            form.Show();
            this.Hide();
        }

        private void btnGestionRecursosMateriales_Click(object sender, EventArgs e)
        {
            FormInventario1 form = new FormInventario1();
            form.Show();
            this.Hide();
        }
    }
}
