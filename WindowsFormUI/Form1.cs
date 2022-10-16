using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormUI
{
    //Form: WindowsForms altyapısının tüm ekranlarının geldiği temel (base) sınıftır.
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Form tasarımının ve üzerindeki tüm elementlerin/komponentlerin tanımlanması için işletilir.
            InitializeComponent();
        }

        //Button (button1) elementi için click olayı oluşturuldu.
        private void button1_Click(object sender, EventArgs e)
        {
            //Label (label1) elementinin içindeki Text alanı değiştiril.
            //label1.Text = "Merhaba dünya!!!";
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Para para = new Para();
            int sonuc = para.At();

            if (sonuc == 1)
            {
                label2.Text = "Yazı";
            }
            else if(sonuc==2)
            {
                label2.Text = "Tura";
            }
            else
            {
                label2.Text = "Dik";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tavla tavla = new Tavla();
            string sonuc = tavla.At() + " + " + tavla.At();
            label2.Text = sonuc;
        }
    }
}
