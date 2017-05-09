using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Namespace aplicación 2

namespace NavajaSuiza.Aplicación_2
{
    /// <summary>
    /// Clase principal de la aplicación 2.
    /// </summary>
    /// <remarks>
    /// Lee archivos de configuración y crea los hilos que ejecutan el resto del programa.
    /// </remarks>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    public partial class Formulario2 : Form
    {
        /// <summary>
        /// Constructor de la clase Formulario2.
        /// </summary>
        
        public Formulario2()
        {
            InitializeComponent();
        }

        ///<summary>
        ///Funcion que calcula el factorial de un número.
        ///</summary>
        ///<return>
        ///Devuelve un número que corresponde con el resultado.
        ///</return>
        ///<param name="num">
        ///Ruta del número a leer.
        ///</param>

        int factorial (int num)
        {
            int fac;
            int i;

            fac = 1;
           
            for (i = num; i > 0; i--)
            {
               fac = fac * i;
            }

            return fac;
        }
        /// <summary>
        /// Boton que ejecuta la función factorial y muestra su resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void button1_Click(object sender, EventArgs e)
        {

            int num; 
            int fact;

            //Prueba Caja Blanca

            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduce un número");
            }
            else
            {
                try
                {
                    
                    num = int.Parse(textBox1.Text);
                    fact = factorial(num);

                    if (num >= 0)
                    {
                        MessageBox.Show(fact.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Introduce un número positivo");
                    }
                }
                catch
                {
                    MessageBox.Show("Has instroducido un carácter");
                }
            }
            

        }

        

        /*
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Formulario2
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Formulario2";
            this.Load += new System.EventHandler(this.Formulario2_Load);
            this.ResumeLayout(false);

        }
        */

        private void Formulario2_Load(object sender, EventArgs e)
        {

        }

        
        private void Formulario2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
