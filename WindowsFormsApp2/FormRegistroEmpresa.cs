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
    public partial class FormRegistroEmpresa : Form
    {
        public FormRegistroEmpresa()
        {
            InitializeComponent();
        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            FormRegistroEmpleado form = new FormRegistroEmpleado();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
