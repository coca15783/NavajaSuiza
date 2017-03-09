using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_2
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
            int i;
            int fac;
            
            num = int.Parse(textBox1.Text);
            fac = 1;
            for (i = num; i > 0 ; i--)
            {
                fac = fac * i;

            }
            
            MessageBox.Show(fac.ToString());


        }
    }
}
