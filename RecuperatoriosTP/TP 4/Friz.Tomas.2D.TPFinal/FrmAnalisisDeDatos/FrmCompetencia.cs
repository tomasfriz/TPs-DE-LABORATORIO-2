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

/// <summary>
/// FRIZ TOMÁS AGUSTÍN
/// </summary>

namespace FrmAnalisisDeDatos
{
    public partial class FrmCompetencia : Form
    {
        static public Competencia<Carrera> carrera;
        static public Competencia<Quemados> quemados;
        static public Competencia<Ajedrez> ajedrez;

        public FrmCompetencia()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa las listas y suscribe los eventos de las mismas. Verifica que exista el directorio que va a utilizar la aplicacion
        /// y verifica que la conexion con la base de datos sea válida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventoDeportivo_Load(object sender, EventArgs e)
        {
            string pathArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\FrmAnalisisDeDatos\";
            if (!Directory.Exists(pathArchivo))
            {
                Directory.CreateDirectory(pathArchivo);
            }

            carrera = new Competencia<Carrera>(1000);
            quemados = new Competencia<Quemados>(2000);
            ajedrez = new Competencia<Ajedrez>(800);
           
            Resultados<Juego> resultados = new Resultados<Juego>();
            carrera.EventoFinalizado += Competencia_EventoFinalizado;
            quemados.EventoFinalizado += Competencia_EventoFinalizado;
            ajedrez.EventoFinalizado += Competencia_EventoFinalizado;
            carrera.EventoReporte += Competencia_EventoReporte;
            quemados.EventoReporte += Competencia_EventoReporte;
            ajedrez.EventoReporte += Competencia_EventoReporte;

            try
            {
                if(BaseDeDatos.IsConnected())
                {
                    Actualizar_Listas();
                }
                else
                {
                    MessageBox.Show("Debe conectarse a la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo iniciar la aplicacion debido a que no se puede establecer conexión con la base de datos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                this.Close();
            }
        }

       
        /// <summary>
        /// Manejador del evento, llama a la impresora de resultados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Competencia_EventoFinalizado(object sender, EventArgs e)
        {
            string tipo = sender.GetType().ToString();
            switch (tipo)
            {
                case "Entidades.Competencia`1[Entidades.Carrera]":
                Resultados<Carrera>.ImprimirResultados(sender, "Carrera");
                    break;
                case "Entidades.Competencia`1[Entidades.Quemados]":
                Resultados<Quemados>.ImprimirResultados(sender, "Quemados");
                    break;
                case "Entidades.Competencia`1[Entidades.Ajedrez]":
                Resultados<Ajedrez>.ImprimirResultados(sender, "Ajedrez");
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Manejador del evento, llama a la impresora de resultados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Competencia_EventoReporte(object sender, EventArgs e)
        {
            string tipo = sender.GetType().ToString();
            switch (tipo)
            {
                case "Entidades.Competencia`1[Entidades.Carrera]":
                    Resultados<Carrera>.ImprimirReporte(sender, "Carrera");
                    break;
                case "Entidades.Competencia`1[Entidades.Quemados]":
                    Resultados<Quemados>.ImprimirReporte(sender, "Quemados");
                    break;
                case "Entidades.Competencia`1[Entidades.Ajedrez]":
                    Resultados<Ajedrez>.ImprimirReporte(sender, "Ajedrez");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Actualiza las listas con lo que hay en la base de datos y hace saltar los eventos si es necesario.
        /// </summary>
        public static void Actualizar_Listas()
        {
            try
            {
                ajedrez.Lista = BaseDeDatos.ObtenerAjedrez();
                quemados.Lista = BaseDeDatos.ObtenerQuemados();
                carrera.Lista = BaseDeDatos.ObtenerCarrera();
                Competencia<Ajedrez>.VerificarEstado(ajedrez);
                Competencia<Quemados>.VerificarEstado(quemados);
                Competencia<Carrera>.VerificarEstado(carrera);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: ", ex);
            }
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.Show();
        }

        private void btn_Tablas_Click(object sender, EventArgs e)
        {
            FrmTablas tablas = new FrmTablas();
            tablas.Show();
        }

        private void btn_Archivos_Click(object sender, EventArgs e)
        {
            FrmArchivos archivos = new FrmArchivos();
            archivos.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
