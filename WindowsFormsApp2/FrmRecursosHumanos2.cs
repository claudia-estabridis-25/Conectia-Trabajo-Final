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
    public partial class FrmRecursosHumanos2 : Form
    {
        public FrmRecursosHumanos2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenúPrincipal obj = new FormMenúPrincipal();
            obj.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmRecursosHumanos1 form = new FrmRecursosHumanos1();
            form.Show();
            this.Hide();
        }

        private void btnVerAsignarProyectos_Click(object sender, EventArgs e)
        {
            FrmRecursosHumanos3 form = new FrmRecursosHumanos3();
            form.Show();
            this.Hide();
        }

        private void btnVerEvaluaciones_Click(object sender, EventArgs e)
        {
            FrmRecursosHumanos6 form = new FrmRecursosHumanos6();
            form.Show();
            this.Hide();
        }
    }
}
