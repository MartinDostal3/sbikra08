using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecToBin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string DecToBin(int dec)
        {
            if (dec == 0)
            {
                return "0";
            }


            string bin = "";
            while (dec > 0)
            {
                int zbytek = dec % 2;
                bin = zbytek.ToString() + bin;
                dec /= 2;
            }


            return bin;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dec = int.Parse(textBox1.Text);


            label1.Text = "Číslo binárně je: " + DecToBin(dec);

        }
    }
}
