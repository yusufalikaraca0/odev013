using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void temizle()
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
            sayi1 = 0;
            sayi2 = 0;

        }
        public  int sayi1;
        public  int sayi2;
        public  string islemturu;
        class islemler
        {

            public int sayi1;
            public int sayi2;
            public string islemturu;
            void debug()
            {
             
            }
            
            public  int carpma()
            {
                
                int toplam = sayi1 * sayi2;
                return toplam;
            }
            public int toplama()
            {
                int toplam = sayi1 + sayi2;
                return toplam;
            }
            public  int bolme()
            {
                try
                {
                    int toplam = sayi1 / sayi2;
                    return toplam;
                }
                catch (System.DivideByZeroException)
                {

                    MessageBox.Show("Hatalı Sözdizimi Lütfen Tekrar Deneyiniz");

                }

                
                
            }
           public int cikarma()
            {
                int toplam = sayi1 - sayi2;
                return toplam;
            }

       
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            islemturu = "carpma";
            sayi1 = int.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            label2.Text = islemturu;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islemturu = "bolme";
            sayi1 = int.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            label2.Text = islemturu;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            islemturu = "toplama";
            sayi1 = int.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            label2.Text = islemturu;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islemturu = "cikarma";
            sayi1 = int.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            textBox1.Text = "";
        }
        
        private void button15_Click(object sender, EventArgs e)
        {

            sayi1 = int.Parse(label1.Text);
            sayi2 = int.Parse(textBox1.Text);
            if(label1.Text !="" && islemturu !=""&& textBox1.Text !="") { }
            
            islemler islemim = new islemler();
            islemim.sayi1 = sayi1;
            islemim.sayi2 = sayi2;
            islemim.islemturu = islemturu;
           
            
                if(islemim.islemturu == "toplama")
                MessageBox.Show(islemim.toplama().ToString());
                if (islemim.islemturu == "cikarma")
                MessageBox.Show(islemim.cikarma().ToString());
                if (islemim.islemturu == "carpma")
                MessageBox.Show(islemim.carpma().ToString());
                if (islemim.islemturu == "bolme")
                MessageBox.Show(islemim.bolme().ToString());


            temizle();




        }
       
        private void button16_Click(object sender, EventArgs e)
        {
          
        }
    }
}
