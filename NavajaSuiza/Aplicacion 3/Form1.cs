using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            int pot;
            int i;
            int exp;
            
            num = int.Parse(textBox1.Text);
            exp = int.Parse(textBox2.Text);
            pot = 1;
            for (i = 1;  i<=exp ; i++)
            {
                pot = pot * num ;
            }
            MessageBox.Show(pot.ToString());

        }
    }
}
