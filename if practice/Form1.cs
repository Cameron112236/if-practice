using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int tendered = Convert.ToInt32(value: textBox1.Text);
            double o = tendered % 7;
            if (o != 0)
            {

                label1.Text = $"{tendered} is not divisible by 7 ";

            }
               else
            {
                label1.Text = $"{tendered} is divisible by 7";
            }
            if (tendered > 0)
            {
                label2.Text = $"{tendered} is a positive number";
            }
            else label2.Text = $"{tendered} is a negative number";
        }
    }
}
