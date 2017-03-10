using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Namespace aplicación 1

namespace NavajaSuiza.Aplicación_1
{
    /// <summary>
    /// Clase principal de la aplicación.
    /// </summary>
    /// <remarks>
    /// Lee archivos de configuración y crea los hilos que ejecutan el resto del programa.
    /// </remarks>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor de la clase Form1.
        /// </summary>

        public Form1()
        {
            InitializeComponent();
        }

        ///<summary>
        ///Introduciremos una cantidad de dinero en metálico y nos mostrará la cantidad de billetes que le corresponda.
        ///</summary>
        ///<remarks>
        ///Cuando la cantidad de billetes sea igual a 0 no deberá aparecer nada.
        ///</remarks>
        /// <para> Tipos de Billetes
        ///     <list type="bullet">
        ///         <item>
        ///             <description>10000</description>
        ///         </item>
        ///         <item>
        ///             <description>5000</description>
        ///         </item>
        ///         <item>
        ///             <description>2000</description>
        ///         </item>
        ///         <item>
        ///             <description>100</description>
        ///         </item>
        ///         <item>
        ///             <description>25</description>
        ///         </item>
        ///        </list>
        /// </para>
        ///<param name="din">
        ///Ruta del dinero a leer.
        ///</param>

        void cantbilletes(int din)
        {
            int billete;

            billete = din / 10000;
            din = din % 10000;
            label2.Text = billete.ToString() + " " + "de 10000";

            if (billete == 0)
            {
                label2.Text = "";
            }

            billete = din / 5000;
            din = din % 5000;
            label3.Text = billete.ToString() + " " + "de 5000";

            if (billete == 0)
            {
                label3.Text = "";
            }

            billete = din / 2000;
            din = din % 2000;
            label4.Text = billete.ToString() + " " + "de 2000";

            if (billete == 0)
            {
                label4.Text = "";
            }

            billete = din / 100;
            din = din % 100;
            label5.Text = billete.ToString() + " " + "de 100";

            if (billete == 0)
            {
                label5.Text = "";
            }

            billete = din / 25;
            din = din % 25;
            label6.Text = billete.ToString() + " " + "de 25";

            if (billete == 0)
            {
                label6.Text = "";
            }
        }
        /// <summary>
        /// Boton que ejecuta la función cantbilletes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int din;

            // Prueba Caja Blanca

            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduce un número de pesetas en metalico");
            }
            else
            {
                try
                {
                    din = int.Parse(textBox1.Text);
                    cantbilletes(din);
                }
                catch
                {
                    MessageBox.Show("Has instroducido un carácter");
                }
            }
            

            
        }
    }
}
