using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skaitmenu_skaiciuokle_ir_eglute
{
    public partial class Form1 : Form
    {
        public int h = 0;
        public int z = 0;
        int[] masyvas = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string IvedKint;
                int b = 0;
                IvedKint = textBox1.Text;
                while (h < 10)
                {
                    masyvas[h] = Convert.ToInt32(IvedKint.Substring(b, 1));
                    b++;
                    h++;
                }
                int skaicius=0;
                for (int i = 0; i < 10; i++) { skaicius = skaicius + masyvas[i]; }
                textBox2.Text = Convert.ToString(skaicius);
                button2.BringToFront();
               
            }
            catch (System.FormatException) { MessageBox.Show("Įvestas ne skaitmuo."); }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Įveskite dar "+(10-h)+" skaitmenis.");}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            h = 0; z = 0; textBox1.Text = ""; textBox2.Text = ""; button2.SendToBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int egDyd = 0;
            try
            {
                egDyd = Convert.ToInt32(textBox3.Text);
            }
            catch (System.FormatException) { MessageBox.Show("Įvestas ne skaitmuo arba nieko langelyje nieko neįvesa."); }
            for (int a=0; a < egDyd+1; a++) { for(int b=0; b<a; b++) { richTextBox1.Text += "* "; } richTextBox1.Text += "\n"; }
            richTextBox1.SelectAll(); richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
