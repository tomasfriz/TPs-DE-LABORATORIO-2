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
using System.Runtime.CompilerServices;

namespace Test
{
    /// <summary>
    /// Hecho por Tomás Agustín Friz
    /// </summary>
    public partial class Cursos : Form
    {
        Principal frmprincipal = new Principal();
        CentroFormacional objneg = new CentroFormacional();
        Persona objent = new Persona();

        /// <summary>
        /// Constructor de Cursos.
        /// </summary>
        public Cursos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Precarga los datos de los cursos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cursos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_curso();
        }
        /// <summary>
        /// Sirve para agregar o modificar los datos de cursos y los actualiza en el datagridview y la base de datos.
        /// Valida si no se pusieron datos correctos.
        /// </summary>
        /// <param name="accion"></param>
        void mantcurso(String accion)
        {
            try
            {
                objent.codigo = textBox1.Text;
                objent.nombre = textBox4.Text;
                objent.accion = accion;
                String men = objneg.N_mantenimientocurso(objent);
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
            textBox1.Text = "";
            textBox4.Text = "";
        }
        /// <summary>
        /// Sirve para confirmar el registro del curso.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a este curso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantcurso("1");
                    dataGridView1.DataSource = objneg.N_listar_curso();
                    limpiar();

                }
            }
        }
        /// <summary>
        /// Sirve para confirmar la modificacion del curso.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar este curso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantcurso("2");
                dataGridView1.DataSource = objneg.N_listar_curso();
                limpiar();
            }
        }
        /// <summary>
        /// Sirve para confirmar la eliminacion del curso.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar este curso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantcurso("3");
                dataGridView1.DataSource = objneg.N_listar_curso();
                limpiar();
            }
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
        /// Sirve para limpiar los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        /// <summary>
        /// Carga los datos en las celdas de datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1[0, fila].Value.ToString();
            textBox4.Text = dataGridView1[1, fila].Value.ToString();
        }
    }
}
