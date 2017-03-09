using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza
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

        private void button2_Click(object sender, EventArgs e)
        {
            Aplicación_2.Form1 oFormulario = new Aplicación_2.Form1();
            oFormulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aplicación_1.Form1 oFormulario = new Aplicación_1.Form1();
            oFormulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aplicación_3.Form1 oFormulario = new Aplicación_3.Form1();
            oFormulario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Aplicación_4.Form1 oFormulario = new Aplicación_4.Form1();
            oFormulario.ShowDialog();
        }
    }
}
