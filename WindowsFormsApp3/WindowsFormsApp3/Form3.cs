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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pasajir.fio = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pasajir.old = Convert.ToDouble(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pasajir.date = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();
        }
    }
}
