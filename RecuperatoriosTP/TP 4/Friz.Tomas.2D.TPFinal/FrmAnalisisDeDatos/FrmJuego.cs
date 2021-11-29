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

/// <summary>
/// FRIZ TOMÁS AGUSTÍN
/// </summary>

namespace FrmAnalisisDeDatos
{
    public partial class FrmJuego : Form
    {
        private Juego juego;
        /// <summary>
        /// Encapsulamiento de Juego.
        /// </summary>
        public Juego Juego
        {
            get { return this.juego; }
        }
        /// <summary>
        /// Constructor de FrmJuego.
        /// </summary>
        public FrmJuego()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Añade items a la cmb y hardcodea valores segun la logica del juego.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmJuego_Load(object sender, EventArgs e)
        {
            cmb_equipos.Items.Add(Equipo.Rojo);
            cmb_equipos.Items.Add(Equipo.Verde);
            if (FrmTablas.selectedCmb == "Ajedrez")
            {
                txt_Rojos.Enabled = false;
                txt_Rojos.Text = "1";
                txt_Verdes.Enabled = false;
                txt_Verdes.Text = "1";
                txt_Duracion.Enabled = false;
                txt_Duracion.Text = "60";
            }
        }
        /// <summary>
        /// Verifica que los parametros ingresados sean correctos y si es asi devuelve el juego a crear/modificar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Rojos.Text.SoloNumeros() && txt_Verdes.Text.SoloNumeros() && txt_Puntos.Text.SoloNumeros() && txt_Duracion.Text.SoloNumeros() && cmb_equipos.Text != "")
                {
                    this.juego = new Juego(0, (Equipo)cmb_equipos.SelectedItem, Convert.ToInt32(txt_Rojos.Text), Convert.ToInt32(txt_Verdes.Text), Convert.ToInt32(txt_Puntos.Text), Convert.ToDouble(txt_Duracion.Text));
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    throw new ParametrosInvalidosException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Se encarga de cancelar la operación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
