using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1;

namespace WindowsFormsTP1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Funcion que inicia el WindowsForm y carga los datos iniciales en los textBox, ComboBox, y titulos.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            this.Name = "Calculadora";
            this.Text = "Calculadora";

            lblResultado.Text = "";

            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");

            btnLimpiar.Text = "CC";
            btnOperar.Text = "=";
        }

        /// <summary>
        /// Cuando el usuario clickea el button btnOperar llama a esta funcion, que a su vez esta llama a operar para realizar la operacion.
        /// </summary>
        /// <param name="sender">(todavia no aprendido)</param>
        /// <param name="e">(todavia no aprendido)</param>
        private void btnOperar_Click(object sender, EventArgs e) { operar(); }

        /// <summary>
        /// Cuando el usuario clickea el button btnLimpiar llama a esta funcion, que a su vez esta llama a limpiar para realizar la operacion.
        /// </summary>
        /// <param name="sender">(todavia no aprendido)</param>
        /// <param name="e">(todavia no aprendido)</param>
        private void btnLimpiar_Click(object sender, EventArgs e) { limpiar(); }

        /// <summary>
        /// funcion que realiza la operacion de 2 numeros dependiendo del operador extraido del comboBox, luego carga el resultado en el label.
        /// </summary>
        private void operar()
        {
            Numero numero1 = new Numero(txtNumero1.Text);
            Numero numero2 = new Numero(txtNumero2.Text);

            lblResultado.Text = Calculadora.operar(numero1, numero2, Calculadora.validarOperador(cmbOperacion.SelectedItem.ToString())).ToString();
        }

        /// <summary>
        /// funcion que realiza una limpieza de los casilleros del label y los textBoxs.
        /// </summary>
        private void limpiar()
        {
            lblResultado.Text = "";

            txtNumero1.Text = "";
            txtNumero2.Text = "";
        }   
        
    }
}
