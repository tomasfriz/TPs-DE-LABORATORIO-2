using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    /// <summary>
    /// CREADO POR TOMÁS AGUSTIN FRIZ
    /// </summary>
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// CREADO POR TOMÁS AGUSTIN FRIZ
        /// </summary>

        #region Constructor
        /// <summary>
        /// Inicializa una instancia de FormCalculadora , establece los operadores para el comboBox , el operador de
        /// inicio y modo DropDownList a fin de evitar que se utilicen operadores erroneos.
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        /// <summary>
        /// CREADO POR TOMÁS AGUSTIN FRIZ
        /// </summary>

        #region Metodos
        /// <summary>
        /// Reestablece los textBox , el comboBox y el label de resultado a sus valores de inicio.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "0";
            this.txtNumero2.Text = "0";
            this.cmbOperador.SelectedItem = "+";
            this.lblResultado.Text = "0";
        }
        /// <summary>
        /// Realiza una operación artimética a partir de cadenas de caracteres que representan dos operandos y un operador.
        /// Devuelve el resultado en formato double.
        /// </summary>
        /// <param name="numero1">Operando 1.</param>
        /// <param name="numero2">Operando 2.</param>
        /// <param name="operador">Operador aritmético.</param>
        /// <returns>Devuelve un numero en formato double o NaN en caso de operadores erroneos.</returns>
        private double Operar(string numero1, string numero2, string operador)
        {
            double resultado = double.NaN;
            if (double.TryParse(numero1, out double num1) && double.TryParse(numero2, out double num2))
            {
                resultado = Calculadora.Operar(new Operando(numero1), new Operando(numero2), operador);
                this.lstOperaciones.Items.Add($"{numero1} {operador} {numero2} = {resultado}");
            }
            return resultado;
        }
        /// <summary>
        /// Cierra al formulario cuando se hace click en el botón cerrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Cuando se hace click en el botón limpiar, restablece los valores numéricos de la calculadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Realiza una operación cuando se hace click en el botón operar y muestra el resultado en el label resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
            this.lblResultado.Text = (double.IsNaN(resultado)) ? "Valores inválidos" : resultado.ToString();
        }
        /// <summary>
        /// Intenta convertir a binario el número decimal que se encuentre en el label "resultado".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Operando().DecimalBinario(this.lblResultado.Text);
        }
        /// <summary>
        /// Intenta convertir a decimal el numero binario que se encuentre en label "resultado".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Operando().BinarioDecimal(this.lblResultado.Text);
        }
        #endregion

        /// <summary>
        /// CREADO POR TOMÁS AGUSTIN FRIZ
        /// </summary>

        #region Eventos
        /// <summary>
        /// Carga de antemano que el comboBox se vea vacio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.SelectedItem = " ";
        }

        /// <summary>
        /// Pregunta al usuario si esta seguro de salir de la calculadora.
        /// Si presiona "NO" volvera a la calculadora.
        /// Si presiona "SI" cerrara la calculadora y el programa en si.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msj = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = msj == DialogResult.No;
        }
        #endregion

        /// <summary>
        /// CREADO POR TOMÁS AGUSTIN FRIZ
        /// </summary>
    }
}
