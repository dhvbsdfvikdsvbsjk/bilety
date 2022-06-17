using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pasajir.vzr = Convert.ToDouble(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pasajir.deti = Convert.ToDouble(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d = pasajir.vzr;
            if (d == 0)
            {
                MessageBox.Show("На самолете есть дети, но 0 взрослых");
            }
            else
            {
                Form3 newForm = new Form3();
                newForm.Show();
                this.Hide();
            }
        }
    }
}
