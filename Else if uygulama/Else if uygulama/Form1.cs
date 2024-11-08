using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Else_if_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc;
            sonuc = Convert.ToDouble(textBox1.Text);
            if (sonuc >= 85) 
            {
                MessageBox.Show("Takdir Belgesi Almaya Hak Kazandınız");
            }
            else if (sonuc >= 70) 
            {
                MessageBox.Show("Teşekkür Belgesi Almaya Hak Kazandınız");
            }
            else if (sonuc >= 50)
            {
                MessageBox.Show("Boş Geçtiniz");
            }
            else if (sonuc < 50)
            {
                MessageBox.Show("Sınıfta Kaldınız");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double not1, not2, sozlu1, sozlu2, ortalama;
            not1 = Convert.ToDouble(textBox2.Text);
            not2 = Convert.ToDouble(textBox3.Text);
            sozlu1 = Convert.ToDouble(textBox4.Text);
            sozlu2 = Convert.ToDouble(textBox5.Text);
            ortalama = (not1 + not2 + sozlu1 + sozlu2) / 4;
            textBox1.Text = ortalama.ToString();


        }
    }
}
