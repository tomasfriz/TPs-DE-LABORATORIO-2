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

namespace Test
{
    /// <summary>
    /// Hecho por Tomás Agustín Friz
    /// </summary>
    public partial class Reportes : Form
    {
        CentroFormacional objneg = new CentroFormacional();
        Persona objent = new Persona();

        /// <summary>
        /// Constructor de Login.
        /// </summary>
        public Reportes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Precarga los distintos filtros o listados de los datos de cursos y salones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reportes_Load(object sender, EventArgs e)
        {
            cbo1.Items.Add("Todos");
            cbo1.Items.Add("Curso");
            cbo1.Items.Add("Salones");
            cbo1.SelectedIndex = 0;
        }
        /// <summary>
        /// Establece las condiciones del filtrado o listado de los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo1.SelectedIndex == 0)
            {
                cbo2.Text = "Todos";
                cbo2.Enabled = false;
                dataGridView1.DataSource = objneg.N_listaralumnos();
            }
            else if (cbo1.SelectedIndex == 1)
            {
                cbo2.DataSource = objneg.N_listar_curso();
                cbo2.ValueMember = "id_cursos";
                cbo2.DisplayMember = "curso_nombre";
                cbo2.Enabled = true;
            }
            else if (cbo1.SelectedIndex == 2)
            {
                cbo2.DataSource = objneg.N_listar_salon();
                cbo2.ValueMember = "id_salon";
                cbo2.DisplayMember = "salon_nombre";
                cbo2.Enabled = true;
            }
        }
        /// <summary>
        /// Carga los valores en el datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo1.SelectedIndex == 0)
            {
                cbo2.Text = "Todos";
            }
            else
        if (cbo1.SelectedIndex == 1)
            {
                objent.id_cod = cbo2.SelectedValue.ToString();
                DataTable dt = objneg.N_buscaralumnosXcurso(objent);
                dataGridView1.DataSource = dt;
            }
            else if (cbo1.SelectedIndex == 2)
            {
                objent.id_cod = cbo2.SelectedValue.ToString();
                DataTable dt = objneg.N_buscaralumnosXsalon(objent);
                dataGridView1.DataSource = dt;
            }
        }
        /// <summary>
        /// Sirve para salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
