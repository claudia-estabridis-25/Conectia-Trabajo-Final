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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenúPrincipal obj = new FormMenúPrincipal();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormInventario3 form = new FormInventario3();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormInventario4 form = new FormInventario4();
            form.Show();
            this.Hide();
        }

        private void btnConsultarStock_Click(object sender, EventArgs e)
        {
            FormInventario2 form = new FormInventario2();
            form.Show();
            this.Hide();
        }

        private void btnCategorizarRecursos_Click(object sender, EventArgs e)
        {
            FormInventario1 form = new FormInventario1();
            form.Show();
            this.Hide();
        }
    }
}
