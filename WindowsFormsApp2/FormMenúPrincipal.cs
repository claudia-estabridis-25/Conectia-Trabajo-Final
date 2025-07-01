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

        private void btnMonitoreoRRHH_Click(object sender, EventArgs e)
        {
            FormRRHHPrincipal obj = new FormRRHHPrincipal();
            obj.Show();
            this.Hide();
        }

        private void btnGestionRecursosMateriales_Click(object sender, EventArgs e)
        {
            FormInventario1 form = new FormInventario1();
            form.Show();
            this.Hide();
        }

        private void btnControlFinanciero_Click(object sender, EventArgs e)
        {
            FormFinanzas1 obj = new FormFinanzas1();
            obj.Show();
            this.Hide();
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            FormIniciarSesion form = new FormIniciarSesion();
            form.Show();
            this.Hide();
        }        
    }
}
