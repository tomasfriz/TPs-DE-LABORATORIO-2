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
    public partial class Alumnos : Form
    {
        CentroFormacional objneg = new CentroFormacional();
        Persona objent = new Persona();

        /// <summary>
        /// Constructor de Alumnos.
        /// </summary>
        public Alumnos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Precarga los datos de los alumnos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Alumnos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listaralumnos();
            cbocurso.DataSource = objneg.N_listar_curso();
            cbocurso.ValueMember = "id_cursos";
            cbocurso.DisplayMember = "curso_nombre";
            cbosalon.DataSource = objneg.N_listar_salon();
            cbosalon.ValueMember = "id_salon";
            cbosalon.DisplayMember = "salon_nombre";
        }
        /// <summary>
        /// Sirve para agregar o modificar los datos de alumno y los actualiza en el datagridview y la base de datos.
        /// Valida si no se pusieron datos correctos.
        /// </summary>
        /// <param name="accion"></param>
        void mantalumno(String accion)
        {
            try
            {
                objent.id_alumno = txtcodigo.Text;
                objent.nombre = txtnombre.Text;
                objent.telefono = Convert.ToInt32(txttel.Text);
                objent.matricula = Convert.ToInt32(txtmatricula.Text);
                objent.id_curso = cbocurso.SelectedValue.ToString();
                objent.id_salon = cbosalon.SelectedValue.ToString();
                objent.accion = accion;
                String men = objneg.N_mantenimientoalumno(objent);
                MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR, a puesto valores incorrectos.");
            }
        }
        /// <summary>
        /// Sirve para limpiar el formulario.
        /// </summary>
        void limpiar()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txttel.Text = "";
            txtmatricula.Text = "";
            cbocurso.SelectedIndex = 0;
            cbosalon.SelectedIndex = 0;
            dataGridView1.DataSource = objneg.N_listaralumnos();
        }
        /// <summary>
        /// Sirve para salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Sirve para confirmar el registro del alumno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a este salon?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantalumno("1");
                    limpiar();
                }
            }
        }
        /// <summary>
        /// Sirve para confirmar la modificacion del alumno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar este alumno?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantalumno("2");
                limpiar();
            }
        }
        /// <summary>
        /// Sirve para confirmar la eliminacion del alumno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar este alumno?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantalumno("3");
                limpiar();
            }
        }
        /// <summary>
        /// Carga los datos en las celdas de datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtcodigo.Text = dataGridView1[0, fila].Value.ToString();
            txtnombre.Text = dataGridView1[1, fila].Value.ToString();
            txttel.Text = dataGridView1[2, fila].Value.ToString();
            txtmatricula.Text = dataGridView1[3, fila].Value.ToString();
            cbocurso.SelectedValue = dataGridView1[4, fila].Value.ToString();
            cbosalon.SelectedValue = dataGridView1[6, fila].Value.ToString();
        }
        /// <summary>
        /// Sirve para buscar un usuario o los usuarios en particular a partir del nombre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            objent.nombre = textBox8.Text + "%";
            DataTable dt = new DataTable();
            dt = objneg.N_buscaralumnos(objent);
            dataGridView1.DataSource = dt;
        }
        /// <summary>
        /// Sirve para limpiar los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
