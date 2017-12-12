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

            this.Name = "LaCalculadora";
            this.Text = "Calculadora de Axel Brito de 2D";

            lblResultado.Text = "";

            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");

            btnLimpiar.Text = "CC";
            btnOperar.Text = "=";
            btnCerrar.Text = "Cerrar";
            btnConvertirABinario.Text = "Convertir a Binario";
            btnConvertirADecimal.Text = "Convertir a Decimal";
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

        /// <summary>
        /// Funcion que se encargar de cerrar el formulario
        /// </summary>
        private void cerrar()
        {
            this.Close();
        }

        /// <summary>
        /// Funcion que convierte un valor a binario
        /// </summary>
        private void ConvertirABinario()
        {
            Numero numero1 = new Numero();

            lblResultado.Text = numero1.DecimalBinario(lblResultado.Text);
        }
        /// <summary>
        /// Funcion que convierte un valor a decimal
        /// </summary>
        private void ConvertirADecimal()
        {
            Numero numero1 = new Numero();

            lblResultado.Text = numero1.BinarioDecimal(lblResultado.Text);
        }
        /// <summary>
        /// Cuando el usuario utiliza el boton cerrar, se cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        /// <summary>
        /// Cuando el usuario utiliza el boton convertir a binario, el valor se convirte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            ConvertirABinario();
        }
        /// <summary>
        /// Cuando el usuario utiliza el boton convertir a decimal, el valor se convirte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            ConvertirADecimal();
        }

        
    }
}
