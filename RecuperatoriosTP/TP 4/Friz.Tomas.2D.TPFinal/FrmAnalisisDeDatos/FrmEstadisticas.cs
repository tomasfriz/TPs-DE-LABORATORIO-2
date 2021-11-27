using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmAnalisisDeDatos
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llama a los metodos que calculan los porcentajes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            CalcularPorcentajeJuegos();
            CalcularPorcentajeCompletado();
            CalcularPorcentajeVictorias();
        }

        /// <summary>
        /// Calcula el porcentaje de los juegos
        /// </summary>
        private void CalcularPorcentajeJuegos()
        {
            FrmCompetencia.Actualizar_Listas();
            decimal cantidadAjedrez = FrmCompetencia.ajedrez.Lista.Count();
            decimal cantidadCarrera = FrmCompetencia.carrera.Lista.Count();
            decimal cantidadQuemados = FrmCompetencia.quemados.Lista.Count();

            decimal juegosTotal = cantidadAjedrez + cantidadQuemados + cantidadCarrera;
            decimal porcentajeAjedrez = (FrmCompetencia.ajedrez.Lista.Count()/juegosTotal*100);
            decimal porcentajeCarrera = FrmCompetencia.carrera.Lista.Count() / juegosTotal * 100;
            decimal porcentajeQuemados = FrmCompetencia.quemados.Lista.Count() / juegosTotal * 100;
            porcentajeAjedrez = Math.Round(porcentajeAjedrez, 2);
            porcentajeCarrera = Math.Round(porcentajeCarrera, 2);
            porcentajeQuemados = Math.Round(porcentajeQuemados, 2);

            lbl_Ajedrez.Text = $"Ajedrez: {porcentajeAjedrez}%";
            lbl_Carrera.Text = $"Carrera: {porcentajeCarrera}%";
            lbl_Quemados.Text = $"Quemados: {porcentajeQuemados}%";
        }
        /// <summary>
        /// Calcula el porcentaje de victorias
        /// </summary>
        private void CalcularPorcentajeVictorias()
        {
            decimal victoriasVerde = 0;
            decimal victoriasRojo = 0;

            victoriasRojo += Entidades.Competencia<Ajedrez>.VictoriasEquipo(FrmCompetencia.ajedrez.Lista, Equipo.Rojo);
            victoriasVerde += Entidades.Competencia<Ajedrez>.VictoriasEquipo(FrmCompetencia.ajedrez.Lista, Equipo.Verde);
            victoriasRojo += Entidades.Competencia<Carrera>.VictoriasEquipo(FrmCompetencia.carrera.Lista, Equipo.Rojo);
            victoriasVerde += Entidades.Competencia<Carrera>.VictoriasEquipo(FrmCompetencia.carrera.Lista, Equipo.Verde);
            victoriasRojo += Entidades.Competencia<Quemados>.VictoriasEquipo(FrmCompetencia.quemados.Lista, Equipo.Rojo);
            victoriasVerde += Entidades.Competencia<Quemados>.VictoriasEquipo(FrmCompetencia.quemados.Lista, Equipo.Verde);
            decimal victoriasTotales = victoriasRojo + victoriasVerde;

            decimal porcentajeRojo = victoriasRojo / victoriasTotales * 100;
            decimal nuevoTamaño = porcentajeRojo * 760 / 100;

            lbl_VictoriasVerde.Text = victoriasVerde.ToString();
            lbl_VictoriasRojo.Text = victoriasRojo.ToString();
            BarraRoja.Size = new Size((int)nuevoTamaño,25);
        }
        /// <summary>
        /// Calcula el porcentaje completado
        /// </summary>
        private void CalcularPorcentajeCompletado()
        {
            FrmCompetencia.Actualizar_Listas();

            decimal puntosAjedrez = FrmCompetencia.ajedrez.PuntosTotales;   
            decimal puntosCarrera = FrmCompetencia.carrera.PuntosTotales;
            decimal puntosQuemados = FrmCompetencia.quemados.PuntosTotales;
            decimal porcentajeAjedrez = puntosAjedrez / FrmCompetencia.ajedrez.PuntosMax * 100;
            decimal porcentajeCarrera = puntosCarrera / FrmCompetencia.carrera.PuntosMax * 100;
            decimal porcentajeQuemados = puntosQuemados / FrmCompetencia.quemados.PuntosMax * 100;
            porcentajeAjedrez = Math.Round(porcentajeAjedrez, 2);
            porcentajeCarrera = Math.Round(porcentajeCarrera, 2);
            porcentajeQuemados = Math.Round(porcentajeQuemados, 2);

            if(porcentajeAjedrez > 100)
            {
                porcentajeAjedrez = 100;
            }
            if (porcentajeCarrera > 100)
            {
                porcentajeCarrera = 100;
            }
            if (porcentajeQuemados > 100)
            {
                porcentajeQuemados = 100;
            }


            lbl_AjedrezCompletado.Text = $"Ajedrez: {porcentajeAjedrez}/100%";
            lbl_CarreraCompletado.Text = $"Carrera: {porcentajeCarrera}/100%";
            lbl_QuemadosCompletado.Text = $"Quemados: {porcentajeQuemados}/100%";
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Busca un log generado por el programa en la carpeta correspondiente y lo muestra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MostrarResultados_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Para mostrar los resultados/informes busque el archivo .log con su respectivo nombre.", "Resultados/Informes.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Mostrar resultados";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\FrmAnalisisDeDatos\";
            openFileDialog.Filter = "Log|*.log";
            openFileDialog.DefaultExt = ".log";
            openFileDialog.FileName = "resultados";

            DialogResult rta = openFileDialog.ShowDialog();

            if (rta == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        MessageBox.Show(sr.ReadToEnd(), "Informacion.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
