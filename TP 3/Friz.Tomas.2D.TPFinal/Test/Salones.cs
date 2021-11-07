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
    public partial class Salones : Form
    {
        CentroFormacional objneg = new CentroFormacional();
        Persona objent = new Persona();

        /// <summary>
        /// Constructor de Salones.
        /// </summary>
        public Salones()
        {
            InitializeComponent();
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
        /// Sirve para agregar o modificar los datos de salones y los actualiza en el datagridview y la base de datos.
        /// Valida si no se pusieron datos correctos.
        /// </summary>
        /// <param name="accion"></param>
        void mantsalon(String accion)
        {
            try
            {
                objent.codigo = txtcodigo.Text;
                objent.nombre = txtnombre.Text;
                objent.accion = accion;
                String men = objneg.N_mantenimientosalon(objent);
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
        }
        /// <summary>
        /// Precarga los datos de los salones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Salones_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_salon();
        }
        /// <summary>
        /// Sirve para confirmar el registro del salon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a este salon?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantsalon("1");
                    dataGridView1.DataSource = objneg.N_listar_salon();
                    limpiar();
                }
            }
        }
        /// <summary>
        /// Sirve para confirmar la modificacion del salon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar este salon?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantsalon("2");
                dataGridView1.DataSource = objneg.N_listar_salon();
                limpiar();
            }
        }
        /// <summary>
        /// Sirve para confirmar la eliminacion del salon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar este salon?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantsalon("3");
                dataGridView1.DataSource = objneg.N_listar_salon();
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
