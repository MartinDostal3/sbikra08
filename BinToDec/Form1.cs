using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinToDec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int BinToDec(string bin)
        {
            int dec = 0;
            int mocnina = 1;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                int cifra = int.Parse(bin[i].ToString());
                dec += cifra * mocnina;
                mocnina *= 2;
            }
            return dec;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string bin = textBox1.Text;

            label1.Text = "Cislo decimalne je: " + BinToDec(bin);

        }
    }
}
