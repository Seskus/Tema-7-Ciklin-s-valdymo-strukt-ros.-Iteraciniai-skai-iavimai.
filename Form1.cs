using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Atsiprašau, kad taip vėluoju su darbais tikiuosi atleisit :D.
/// Mantas Šeškus PS0/1
/// Tema 7: Ciklinės valdymo struktūros. Iteraciniai skaičiavimai.
/// </summary>
namespace Ciklai
{
    public partial class Form1 : Form
    {
        public int[] Arrayy = new int[10];
        public int n=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Elemtų sumos išspauzdinimas.
        {
            if (n < 10)
            {
                Form2 frm = new Form2(this);
                frm.Show();
            }
            else
            {
                int i = 0;
                int sum = 0;
                while (true)
                {
                    sum += Arrayy[i];
                    i++;
                    if (i == n) break;
                }
                richTextBox1.Text = "Suma : " + sum; 
            }
        }

        private void button2_Click(object sender, EventArgs e) // Elemntų įvedimas 
        {
            try
            {
                if (Int32.TryParse(textBox1.Text,out Arrayy[n]))
                {
                    n++;
                    richTextBox2.Text = 1 + ". " + Arrayy[0] + "\n";
                    for (int i = 1; i < n; i++)
                    {
                        richTextBox2.AppendText( i+1 + ". " + Arrayy[i] + "\n");
                    }
                    if (n == 10)
                    {
                        button2.Text = "Masyvo skaičiavimas";
                    }
                    textBox1.Clear();
                }
            }
            catch (IndexOutOfRangeException) { n = 0; richTextBox2.Clear(); richTextBox1.Clear(); button2.Text = "Prideti elementa"; }
        }

        private void button3_Click(object sender, EventArgs e) // Eglutės sukūrimas.
        {
            int Dydis;
            int k = 0;
            int star = 1;
            int gap;
            if (Int32.TryParse(textBox2.Text, out Dydis) && Dydis>0)
            {
                richTextBox1.Text= "Kalėdinė eglutė: " + '\n';
                gap = Dydis;
                do
                {
                    for (int i=1;i<gap;i++)
                    {
                        richTextBox1.AppendText(" ");
                    }
                    for (int i = 0; i < star; i++)
                    {
                        richTextBox1.AppendText("* ");
                    }
                    richTextBox1.AppendText("\n");
                    gap--;
                    star++;
                    k++;
                } while (k < Dydis);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
