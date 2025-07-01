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
    public partial class FormFinanzas1 : Form
    {
        public FormFinanzas1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FrmFinanzas_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenúPrincipal obj = new FormMenúPrincipal();
            obj.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormMenúPrincipal form = new FormMenúPrincipal();
            form.Show();
            this.Hide();
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            FormFinanzas2 form = new FormFinanzas2();
            form.Show();
            this.Hide();
        }

        private void btnVerFondos_Click(object sender, EventArgs e)
        {
            FormFinanzas4 form = new FormFinanzas4();
            form.Show();
            this.Hide();
        }

        private void btnVerKPIs_Click(object sender, EventArgs e)
        {
            FormFinanzas5 form = new FormFinanzas5();
            form.Show();
            this.Hide();
        }

        private void btnVerPresupeuestoMensual_Click(object sender, EventArgs e)
        {
            EjecucionPresupuestalMensual form = new EjecucionPresupuestalMensual();
            form.Show();
            this.Hide();
        }

        private void btnVerComparacion_Click(object sender, EventArgs e)
        {
            ReporteComparativo form = new ReporteComparativo();
            form.Show();
            this.Hide();
        }

        private void btnGastosPorCompra_Click(object sender, EventArgs e)
        {
            ReporteGastosCategorizados form = new ReporteGastosCategorizados();
            form.Show();
            this.Hide();
        }
    }
}
