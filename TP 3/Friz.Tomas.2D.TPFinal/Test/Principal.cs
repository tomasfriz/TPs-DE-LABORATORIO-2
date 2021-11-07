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
    public partial class Principal : Form
    {
        Persona obje = new Persona();
        CentroFormacional objn = new CentroFormacional();
        public static string totalalum, totalcur, totalsal;
        int mov, movX, movY;

        /// <summary>
        /// Constructor de Principal.
        /// </summary>
        public Principal()
        {
            InitializeComponent();
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
        /// Sirve para salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Precarga las funcionalidades del formulario.
        /// Carga los totales de los cursos, alumnos y salones.
        /// Carga los permisos de cada inicio de sesion(si es admi, secretaria o asistente).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_Load(object sender, EventArgs e)
        {
            DataTable dtalum = objn.N_totalalumnos();
            DataTable dtacur = objn.N_totalcurso();
            DataTable dtasal = objn.N_totalsalones();
            lbltotalalum.Text = dtalum.Rows[0][0].ToString();
            lbltotalcurs.Text = dtacur.Rows[0][0].ToString();
            lbltotalsalon.Text = dtasal.Rows[0][0].ToString();
            lblusuario.Text = Login.usuario_nombre;
            if (Login.id_tipo == "T0001")  //Admin
            {
                usuariosToolStripMenuItem.Enabled = true;
                alumnosToolStripMenuItem.Enabled = true;
                salonesToolStripMenuItem.Enabled = true;
                reportesToolStripMenuItem.Enabled = true;
                cursosToolStripMenuItem.Enabled = true;
            }
            else
            if (Login.id_tipo == "T0002") //Asistente
            {
                usuariosToolStripMenuItem.Enabled = false;
                alumnosToolStripMenuItem.Enabled = false;
                salonesToolStripMenuItem.Enabled = false;
                reportesToolStripMenuItem.Enabled = true;
                cursosToolStripMenuItem.Enabled = false;
            }
            else
            if (Login.id_tipo == "T0003") //Secretaria
            {
                usuariosToolStripMenuItem.Enabled = false;
                alumnosToolStripMenuItem.Enabled = true;
                salonesToolStripMenuItem.Enabled = true;
                reportesToolStripMenuItem.Enabled = true;
                cursosToolStripMenuItem.Enabled = true;
            }
            timer1.Start();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }
        /// <summary>
        /// Cambia el color del menu con respecto a los permisos que tienen cada usuario.
        /// </summary>
        public class MyColorTable : ProfessionalColorTable
        {
            public override Color MenuBorder
            {
                get
                {
                    return Color.Black;
                }
            }
            public override Color MenuItemBorder
            {
                get
                {
                    return Color.Black;
                }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.Navy;
                }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.Navy;
                }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.Blue;
                }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.Blue;
                }
            }
        }
        /// <summary>
        /// Establece el horario y el dia actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        /// <summary>
        /// Evento de salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Evento de usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios frmusu = new Usuarios();
            frmusu.ShowDialog();
        }
        /// <summary>
        /// Evento de alumno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Alumnos frmalu = new Alumnos();
            frmalu.ShowDialog();
        }
        /// <summary>
        /// Evento de curso.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos frmcur = new Cursos();
            frmcur.ShowDialog();
        }
        /// <summary>
        /// Sirve para actualizar los datos de los totales de cursos, alumnos y salones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
            DataTable dtalum = objn.N_totalalumnos();
            DataTable dtacur = objn.N_totalcurso();
            DataTable dtasal = objn.N_totalsalones();
            lbltotalalum.Text = dtalum.Rows[0][0].ToString();
            lbltotalcurs.Text = dtacur.Rows[0][0].ToString();
            lbltotalsalon.Text = dtasal.Rows[0][0].ToString();
        }
        /// <summary>
        /// Evento de reportes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes frmreport = new Reportes();
            frmreport.ShowDialog();
        }
        /// <summary>
        /// Evento de salon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salones frmsalones = new Salones();
            frmsalones.ShowDialog();
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
