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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Москва" });
            comboBox1.Items.AddRange(new string[] { "Адлер" });
            comboBox1.Items.AddRange(new string[] { "Томск" });
            comboBox1.Items.AddRange(new string[] { "Астрахань" });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Москва":
                    Form2 newForm = new Form2();
                    newForm.Show();
                    bilets.gorod = comboBox1.Text;
                    this.Hide();
                    break;
                case "Адлер":
                    Form2 new1Form = new Form2();
                    new1Form.Show();
                    bilets.gorod = comboBox1.Text;
                    this.Hide();
                    break;
                case "Томск":
                    Form2 new2Form = new Form2();
                    new2Form.Show();
                    bilets.gorod = comboBox1.Text;
                    this.Hide();
                    break;
                case "Астрахань":
                    Form2 new3Form = new Form2();
                    new3Form.Show();
                    bilets.gorod = comboBox1.Text;
                    this.Hide();
                    break;
            }
        }
    }
}
