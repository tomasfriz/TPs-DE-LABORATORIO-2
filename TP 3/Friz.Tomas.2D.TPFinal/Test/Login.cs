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
    public partial class Login : Form
    {
        Persona objeuser = new Persona();
        CentroFormacional objnuser = new CentroFormacional();
        public static string usuario_nombre;
        public static string id_tipo;
        public static string usuario_nick;
        public static string usuario_codigo;
        Principal frm1 = new Principal();
        int mov, movX, movY;

        /// <summary>
        /// Constructor de Login.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Precarga el tiempo de la funcion timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        /// <summary>
        /// Sirve para salir y finalizar el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Para mover el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxmovform_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        /// <summary>
        /// Sirve para iniciar sesion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnentrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            objeuser.usuario = textBox1.Text;
            objeuser.clave = textBox2.Text;
            dt = objnuser.N_login(objeuser);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][0].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][0].ToString();
                id_tipo = dt.Rows[0][3].ToString();
                usuario_nick = dt.Rows[0][1].ToString();
                usuario_codigo = dt.Rows[0][4].ToString();
                frm1.ShowDialog();
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Usuario o contraeña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Establece el horario actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        /// <summary>
        /// Sirve para cerrar y finalizar el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Para mover el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxmovform_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        /// <summary>
        /// Para mover el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxmovform_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
