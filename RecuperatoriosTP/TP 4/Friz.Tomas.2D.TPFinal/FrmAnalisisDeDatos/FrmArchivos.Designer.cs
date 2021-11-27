
namespace FrmAnalisisDeDatos
{
    partial class FrmArchivos
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
            this.lbl_Seleccione = new System.Windows.Forms.Label();
            this.btn_ExportarTipo = new System.Windows.Forms.Button();
            this.dgv_juegos = new System.Windows.Forms.DataGridView();
            this.btn_ExportarSeleccion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Importar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_juegos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Seleccione
            // 
            this.lbl_Seleccione.AutoSize = true;
            this.lbl_Seleccione.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Seleccione.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Seleccione.Location = new System.Drawing.Point(12, 18);
            this.lbl_Seleccione.Name = "lbl_Seleccione";
            this.lbl_Seleccione.Size = new System.Drawing.Size(112, 28);
            this.lbl_Seleccione.TabIndex = 38;
            this.lbl_Seleccione.Text = "Archivos";
            this.lbl_Seleccione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ExportarTipo
            // 
            this.btn_ExportarTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ExportarTipo.BackColor = System.Drawing.Color.Lavender;
            this.btn_ExportarTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ExportarTipo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ExportarTipo.FlatAppearance.BorderSize = 2;
            this.btn_ExportarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarTipo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ExportarTipo.Location = new System.Drawing.Point(545, 141);
            this.btn_ExportarTipo.Name = "btn_ExportarTipo";
            this.btn_ExportarTipo.Size = new System.Drawing.Size(227, 74);
            this.btn_ExportarTipo.TabIndex = 37;
            this.btn_ExportarTipo.Text = "Exportar por tipo";
            this.btn_ExportarTipo.UseVisualStyleBackColor = false;
            this.btn_ExportarTipo.Click += new System.EventHandler(this.btn_ExportarTipo_Click);
            // 
            // dgv_juegos
            // 
            this.dgv_juegos.AllowUserToAddRows = false;
            this.dgv_juegos.AllowUserToDeleteRows = false;
            this.dgv_juegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_juegos.Location = new System.Drawing.Point(12, 61);
            this.dgv_juegos.Name = "dgv_juegos";
            this.dgv_juegos.ReadOnly = true;
            this.dgv_juegos.RowTemplate.Height = 25;
            this.dgv_juegos.Size = new System.Drawing.Size(527, 382);
            this.dgv_juegos.TabIndex = 35;
            // 
            // btn_ExportarSeleccion
            // 
            this.btn_ExportarSeleccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ExportarSeleccion.BackColor = System.Drawing.Color.Lavender;
            this.btn_ExportarSeleccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ExportarSeleccion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ExportarSeleccion.FlatAppearance.BorderSize = 2;
            this.btn_ExportarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarSeleccion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ExportarSeleccion.Location = new System.Drawing.Point(545, 61);
            this.btn_ExportarSeleccion.Name = "btn_ExportarSeleccion";
            this.btn_ExportarSeleccion.Size = new System.Drawing.Size(227, 74);
            this.btn_ExportarSeleccion.TabIndex = 34;
            this.btn_ExportarSeleccion.Text = "Exportar seleccion";
            this.btn_ExportarSeleccion.UseVisualStyleBackColor = false;
            this.btn_ExportarSeleccion.Click += new System.EventHandler(this.btn_ExportarSeleccion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(576, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 28);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tipo de juego";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(545, 340);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(227, 23);
            this.cmb_tipo.TabIndex = 39;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Volver.BackColor = System.Drawing.Color.Lavender;
            this.btn_Volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Volver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Volver.FlatAppearance.BorderSize = 2;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Volver.Location = new System.Drawing.Point(545, 385);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(227, 58);
            this.btn_Volver.TabIndex = 41;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Importar
            // 
            this.btn_Importar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Importar.BackColor = System.Drawing.Color.Lavender;
            this.btn_Importar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Importar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Importar.FlatAppearance.BorderSize = 2;
            this.btn_Importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Importar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Importar.Location = new System.Drawing.Point(545, 221);
            this.btn_Importar.Name = "btn_Importar";
            this.btn_Importar.Size = new System.Drawing.Size(227, 74);
            this.btn_Importar.TabIndex = 42;
            this.btn_Importar.Text = "Importar datos";
            this.btn_Importar.UseVisualStyleBackColor = false;
            this.btn_Importar.Click += new System.EventHandler(this.btn_Importar_Click);
            // 
            // FrmArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_Importar);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.lbl_Seleccione);
            this.Controls.Add(this.btn_ExportarTipo);
            this.Controls.Add(this.dgv_juegos);
            this.Controls.Add(this.btn_ExportarSeleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmArchivos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArchivos";
            this.Load += new System.EventHandler(this.FrmArchivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_juegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Seleccione;
        private System.Windows.Forms.Button btn_ExportarTipo;
        private System.Windows.Forms.DataGridView dgv_juegos;
        private System.Windows.Forms.Button btn_ExportarSeleccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Importar;
    }
}