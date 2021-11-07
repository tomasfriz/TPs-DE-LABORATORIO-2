namespace Test
{
    partial class Reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salon_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cursos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_salon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsalir = new System.Windows.Forms.Button();
            this.boxmovform = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxmovform)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbo1);
            this.groupBox1.Controls.Add(this.cbo2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(29, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(869, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbo1
            // 
            this.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Location = new System.Drawing.Point(107, 25);
            this.cbo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(297, 28);
            this.cbo1.TabIndex = 0;
            this.cbo1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbo2
            // 
            this.cbo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Location = new System.Drawing.Point(422, 25);
            this.cbo2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(297, 28);
            this.cbo2.TabIndex = 1;
            this.cbo2.SelectedValueChanged += new System.EventHandler(this.cbo2_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opción:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(29, 151);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(869, 530);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Matricula,
            this.Column4,
            this.salon_nombre,
            this.id_cursos,
            this.id_salon});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(861, 505);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_alumno";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nombre";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "telefono";
            this.Column3.HeaderText = "Teléfono";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "curso_nombre";
            this.Column4.HeaderText = "Curso";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // salon_nombre
            // 
            this.salon_nombre.DataPropertyName = "salon_nombre";
            this.salon_nombre.HeaderText = "Salon";
            this.salon_nombre.Name = "salon_nombre";
            this.salon_nombre.ReadOnly = true;
            // 
            // id_cursos
            // 
            this.id_cursos.DataPropertyName = "id_cursos";
            this.id_cursos.HeaderText = "id_cursos";
            this.id_cursos.Name = "id_cursos";
            this.id_cursos.ReadOnly = true;
            this.id_cursos.Visible = false;
            // 
            // id_salon
            // 
            this.id_salon.DataPropertyName = "id_salon";
            this.id_salon.HeaderText = "id_salon";
            this.id_salon.Name = "id_salon";
            this.id_salon.ReadOnly = true;
            this.id_salon.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Maroon;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(900, 12);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(23, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "X";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // boxmovform
            // 
            this.boxmovform.BackColor = System.Drawing.Color.Navy;
            this.boxmovform.Location = new System.Drawing.Point(110, 5);
            this.boxmovform.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxmovform.Name = "boxmovform";
            this.boxmovform.Size = new System.Drawing.Size(788, 30);
            this.boxmovform.TabIndex = 30;
            this.boxmovform.TabStop = false;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test.Properties.Resources.reportes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 708);
            this.Controls.Add(this.boxmovform);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxmovform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.ComboBox cbo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn salon_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_salon;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.PictureBox boxmovform;
    }
}