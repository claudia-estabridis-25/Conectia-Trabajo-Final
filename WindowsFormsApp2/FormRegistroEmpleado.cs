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
    public partial class FormRegistroEmpleado: Form
    {
        public FormRegistroEmpleado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormRegistroEmpresa form = new FormRegistroEmpresa();
            form.Show();
            this.Hide();
        }

        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
            FormIniciarSesion form = new FormIniciarSesion();
            form.Show();
            this.Hide();
        }
    }
}
