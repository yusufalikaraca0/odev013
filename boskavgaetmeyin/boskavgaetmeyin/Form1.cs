using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boskavgaetmeyin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }
        bool first = true;

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (first) { textBox1.Text = ""; first = false;  }
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            comboBox1.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text); 
            
        }

        private void richTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        bool first2 = true;
        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (first2) { richTextBox1.Text = ""; first2 = false; }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                comboBox1.Items.Add(richTextBox1.Lines[i]);
            }
            
            
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if(comboBox1.FindString(textBox2.Text) == -1)
            {
                label1.Text = "Bulunamadı"; 
            }
            else
            {
                label1.Text = (comboBox1.FindString(textBox2.Text)+1).ToString()+" . Sırada";

            }


        }
        bool first3 = true; 
        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (first3) { textBox2.Text = ""; first3 = false; }
        }
        bool first4 = true;
        private void textBox3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (first4) { textBox3.Text = ""; first4 = false; }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                label2.Text = comboBox1.Items[int.Parse(textBox3.Text)-1].ToString();
            }
            catch (Exception)
            {
                label2.Text = "Bulunamadı";
                
            }
            
        }
    }
}
