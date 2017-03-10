using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Namespace aplicación 4

namespace NavajaSuiza.Aplicación_4
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
        ///Funcion que calcula la tabla de multiplicar de un número.
        ///</summary>
        ///<return>
        ///Devuelve un texto que corresponde con el resultado.
        ///</return>
        ///<param name="num">
        ///Ruta del número a leer.
        ///</param>
        
        string tabla(int num)
        {
            string texto;
            int i,tabla;

            texto = "Tabla del" + " " + num + ":" + "\n";
            tabla = 0;

            for (i = 1; i <= 10; i++)
            {
                tabla = num * i;
                texto = texto + num + " " + "*" + " " + i + " " + "=" + " " + tabla + "\n";
            }
                return texto;
        }

        /// <summary>
        /// Boton que ejecuta la función tabla y muestra su resultado.
        /// </summary>
        /// <remarks>
        /// El número introducido tiene que estar entre o y 100.
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            string resultado;

            num = int.Parse(textBox1.Text);
            resultado = tabla(num);

            if (num > 0 && num <= 100)
            {
                
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("El número no es valido");
            
            }
        }
    }
}
