using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz_grafica
{
    public partial class sistemaintegral : Form
    {
        public sistemaintegral()
        {
            InitializeComponent();
            btnclientes.Enabled = false;
            btnconfig.Enabled = false;
            btnreportes.Enabled = false;
            btnventas.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            complementaria compl = new complementaria();
            compl.ShowDialog();
        }
    }
}
