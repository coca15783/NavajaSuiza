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
        ///<param name="Num">
        ///Ruta del número a leer.
        ///</param>
        
        string tabla (int Num)
        {
            string Texto;
            int I;
            int Tabla;

            Texto = "Tabla del" + " " + Num + ":" + "\n";
            Tabla = 0;

            for (I = 1; I <= 10; I++)
            {
                Tabla = Num * I;
                Texto = Texto + Num + " " + "*" + " " + I + " " + "=" + " " + Tabla + "\n";
            }
                return Texto;
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
            int Num;
            string Resultado;

            Num = int.Parse(textBox1.Text);
            Resultado = tabla(Num);

            if (Num > 0 && Num <= 100)
            {
                
                MessageBox.Show(Resultado);
            }
            else
            {
                MessageBox.Show("El número no es valido");
            
            }
        }
    }
}
