﻿using System;
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
    public partial class mesa2 : Form
    {
        public mesa2()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orden1 Orden1 = new Orden1();
            Orden1.mesaIndex = 1;
            Orden1.ordenescantidad = Convert.ToInt32(txtCantidad.Text);
            Orden1.Show();
            this.Hide();
        }
    }
}
