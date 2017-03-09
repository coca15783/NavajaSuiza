using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_4
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
            int tabla;
            string texto;

            tabla = 0;
            num = int.Parse(textBox1.Text);

            texto = "Tabla del" + " " + num + ":" + "\n";

            if (num > 0 && num <= 100)
            {
                for (i = 1; i <= 10; i++)
                {
                    tabla = num * i;
                    texto = texto + num + " " + "*" + " " + i + " " + "=" + " " + tabla + "\n";



                }
                MessageBox.Show(texto.ToString());
            }
            else
            {
                MessageBox.Show("El número no es valido");
            
        
            }
        }
    }
}
