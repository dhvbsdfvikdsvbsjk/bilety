using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        private readonly string tem = @"C:\Users\vovv0\Desktop\sd.docx";
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = pasajir.fio;
            double amui = Convert.ToDouble(pasajir.vzr);
            double kids = Convert.ToDouble(pasajir.deti);
            double bilet = 0;

            double er = Convert.ToInt32(pasajir.old);
            if (er > 12)
            {
                bilet = (amui * 500) + (kids * 500);
                label5.Text = bilet.ToString();

            }
            else if (er < 12 || er > 2)
            {
                bilet = (amui * 500) + (kids * 250);
                label5.Text = bilet.ToString();
            }
            else if (er < 2)
            {
                bilet = (amui * 500) + (kids * 0);
                label5.Text = bilet.ToString();
            }
            pasajir.price1 = label5.Text;
            double er1 = Convert.ToDouble(pasajir.old);
            if (er1 > 12)
            {
                label6.Text = er1.ToString("Взрослый");
            }
            else if (er1 < 12 || er1 > 2)
            {
                label6.Text = er1.ToString("Ребенок, скидка половина %");
            }
            else if (er1 < 2)
            {
                label6.Text = er1.ToString("Ребенок, скидка 100%");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = bilets.gorod;
            var b = pasajir.vzr;
            var c = pasajir.deti;
            var f = pasajir.fio;
            var f1 = pasajir.price1;
            var f2 = pasajir.old;
            var ff = pasajir.date;
            var f3 = bilets.today;
            var f10 = pasajir.numpass;
            var f11 = pasajir.seriapass;
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDoc = wordApp.Documents.Open(tem);
            Ada("{gorod}", a, wordDoc);
            Ddd("{vzr}", b, wordDoc);
            Ddd("{deti}", c, wordDoc);
            Ada("{fio}", f, wordDoc);
            Ada("{price}", f1, wordDoc);
            Ada("{date}", ff, wordDoc);
            Ada("{today}", f3, wordDoc);
            Ddd("{old}", f2, wordDoc);
            Ddd("{numpas}", f10, wordDoc);
            Ddd("{serpas}", f11, wordDoc);
            wordDoc.SaveAs(@"C:\Users\vovv0\Desktop\sd.docx");
            wordApp.Visible = true;
        }
        private void Ddd(string stub, double text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stub, ReplaceWith: text);
        }
        private void Ada(string stub, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stub, ReplaceWith: text);
        }
    }
}
