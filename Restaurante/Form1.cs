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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mesa1 = new mesa1();
            mesa1.Show();
            this.Hide();
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            

        }

        private void mesa2_Click(object sender, EventArgs e)
        {
            Form mesa2 = new mesa2();
            mesa2.Show();
            this.Hide();
        }

        private void mesa3_Click(object sender, EventArgs e)
        {
            Form mesa3 = new mesa3();
            mesa3.Show();
            this.Hide();
        }

        private void mesa4_Click(object sender, EventArgs e)
        {
            Form mesa4 = new mesa4();
            mesa4.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
