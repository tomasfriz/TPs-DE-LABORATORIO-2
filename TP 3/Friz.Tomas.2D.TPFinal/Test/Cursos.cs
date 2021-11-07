﻿using System;
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
    public partial class Cursos : Form
    {
        Principal frmprincipal = new Principal();
        CentroFormacional objneg = new CentroFormacional();
        Persona objent = new Persona();
        public Cursos()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_curso();
        }

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

        void limpiar()
        {
            textBox1.Text = "";
            textBox4.Text = "";
        }
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

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar este curso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantcurso("2");
                dataGridView1.DataSource = objneg.N_listar_curso();
                limpiar();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar este curso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantcurso("3");
                dataGridView1.DataSource = objneg.N_listar_curso();
                limpiar();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1[0, fila].Value.ToString();
            textBox4.Text = dataGridView1[1, fila].Value.ToString();
        }
    }
}
