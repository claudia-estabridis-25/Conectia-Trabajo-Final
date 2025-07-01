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
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenúPrincipal obj= new FormMenúPrincipal();
            this.Hide();
            obj.Show();
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
            FormIniciarSesion form = new FormIniciarSesion();
            form.Show();
            this.Hide();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
