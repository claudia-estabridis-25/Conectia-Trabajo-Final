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
    public partial class FormIniciarSesion: Form
    {
        public FormIniciarSesion()
        {
            InitializeComponent();
            tbContraseña.PasswordChar = '•';
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormRegistro form = new FormRegistro();
            form.Show();
            this.Hide();
        }

        private void btnIniciaSesino_Click(object sender, EventArgs e)
        {
            FormMenúPrincipal form = new FormMenúPrincipal();
            form.Show();
            this.Hide();
        }
    }
}
