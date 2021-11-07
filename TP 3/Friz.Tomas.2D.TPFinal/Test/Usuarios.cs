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
    public partial class Usuarios : Form
    {
        CentroFormacional objneg = new CentroFormacional();
        Persona objent = new Persona();

        /// <summary>
        /// Constructor de Usuario.
        /// </summary>
        public Usuarios()
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
        /// Precarga los datos de los usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Usuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_usuarios();
            cbotipo.DataSource = objneg.N_listar_tipo();
            cbotipo.ValueMember = "id_tipo";
            cbotipo.DisplayMember = "tipo_nombre";
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
            dt = objneg.N_buscarusuario(objent);
            dataGridView1.DataSource = dt;
        }
        /// <summary>
        /// Sirve para agregar o modificar los datos de usuario y los actualiza en el datagridview y la base de datos.
        /// Valida si no se pusieron datos correctos.
        /// </summary>
        /// <param name="accion"></param>
        void mantusuario(String accion)
        {
            try
            {
                objent.codigo = txtcodigo.Text;
                objent.nombre = txtnombre.Text;
                objent.usuario = txtusuario.Text;
                objent.id_tipo = cbotipo.SelectedValue.ToString();
                objent.accion = accion;
                String men = objneg.N_mantenimientousuario(objent);
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
            txtusuario.Text = "";
            txtnombre.Text = "";
            cbotipo.SelectedIndex = 0;
        }
        /// <summary>
        /// Sirve para confirmar el registro del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a este usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantusuario("1");
                    dataGridView1.DataSource = objneg.N_listar_usuarios();
                    limpiar();
                }
            }
        }
        /// <summary>
        /// Sirve para confirmar la modificacion del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar a este usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantusuario("2");
                dataGridView1.DataSource = objneg.N_listar_usuarios();
                limpiar();
            }
        }
        /// <summary>
        /// Sirve para confirmar la eliminacion del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar a este usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantusuario("3");
                dataGridView1.DataSource = objneg.N_listar_usuarios();
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
            txtusuario.Text = dataGridView1[2, fila].Value.ToString();
            cbotipo.SelectedValue = dataGridView1[3, fila].Value.ToString();
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
