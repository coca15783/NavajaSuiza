using NavajaSuiza.Aplicacion_1;
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
    /// Clase principal de la aplicación 1.
    /// </summary>
    /// <remarks>
    /// Lee archivos de configuración y crea los hilos que ejecutan el resto del programa.
    /// </remarks>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    public partial class Formulario1 : Form
    {
        /// <summary>
        /// Constructor de la clase Formulario1.
        /// </summary>

        public Formulario1()
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
        
        private void mostrarBilletes()
        {
            tDinero Dinero = new tDinero();

            int dinero;

            dinero = Dinero.Dinero;

            // Prueba Caja Blanca

            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduce un número de pesetas en metalico");
            }
            else
            {
                try
                {
                    Dinero.Dinero = int.Parse(textBox1.Text);
                    MessageBox.Show(Dinero.mostrarDatos());
                }
                catch
                {
                    MessageBox.Show("Has instroducido un carácter");
                }
            }
        }

        /// <summary>
        /// Boton que ejecuta la función cantbilletes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void button1_Click(object sender, EventArgs e)
        {

            mostrarBilletes();
              
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {
            // Lo hago aqui ya que no he podido acceder a las propiedades de los label porque no me aparecen los label en el formulario.

            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

       

        private void Formulario1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
