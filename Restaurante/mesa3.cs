using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class mesa3 : Form
    {
        public mesa3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orden1 Orden1 = new Orden1();
            Orden1.mesaIndex = 2;
            Orden1.ordenescantidad = Convert.ToInt32(txtCantidad.Text);
            Orden1.Show();
            this.Hide();
        }
    }
}
