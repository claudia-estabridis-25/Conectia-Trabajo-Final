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
    public partial class FrmRecursosHumanos5: Form
    {
        public FrmRecursosHumanos5()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmRecursosHumanos3 form = new FrmRecursosHumanos3();
            form.Show();
            this.Hide();
        }
    }
}
