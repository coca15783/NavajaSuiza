using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int din;
            int billete;

            din = int.Parse(textBox1.Text);

            billete = din / 10000;
            din = din % 10000;
            label2.Text = billete.ToString()+" " + "de 10000";
            if (billete == 0)
            {
                label2.Text = "";
            }

            billete = din / 5000;
            din = din % 5000;
            label3.Text = billete.ToString()+" "+ "de 5000";
            if(billete==0)
            {
                label3.Text = "";
            }

            billete = din / 2000;
            din = din % 2000;
            label4.Text = billete.ToString()+" " + "de 2000";
            if (billete == 0)
            {
                label4.Text = "";
            }

            billete = din / 100;
            din = din % 100;
            label5.Text = billete.ToString()+" " + "de 100";
            if (billete == 0)
            {
                label5.Text = "";
            }

            billete = din / 25;
            din = din % 25;
            label6.Text = billete.ToString()+" " + "de 25";
            if (billete == 0)
            {
                label6.Text = "";
            }






        }
    }
}
