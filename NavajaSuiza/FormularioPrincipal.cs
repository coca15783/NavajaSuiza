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
    /// <summary>
    /// Formulario Principal que establece la conexion con el resto de formularios.
    /// </summary>
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Boton que llama a la aplicación 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Aplicación_2.Formulario2 oFormulario = new Aplicación_2.Formulario2();
            oFormulario.ShowDialog();
        }

        /// <summary>
        /// Boton que llama a la aplicación 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Aplicación_1.Formulario1 oFormulario = new Aplicación_1.Formulario1();
            oFormulario.ShowDialog();    
        }

        /// <summary>
        /// Boton que llama a la aplicación 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Aplicación_3.Formulario3 oFormulario = new Aplicación_3.Formulario3();
            oFormulario.ShowDialog();
        }
        /// <summary>
        /// Boton que llama a la aplicación 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Aplicación_4.Formulario4 oFormulario = new Aplicación_4.Formulario4();
            oFormulario.ShowDialog();
        }
    }
}
