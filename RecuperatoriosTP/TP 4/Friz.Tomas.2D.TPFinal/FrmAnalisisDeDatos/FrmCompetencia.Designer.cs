
namespace FrmAnalisisDeDatos
{
    partial class FrmCompetencia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.btn_Tablas = new System.Windows.Forms.Button();
            this.btn_Archivos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Estadisticas
            // 
            this.btn_Estadisticas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Estadisticas.BackColor = System.Drawing.Color.Lavender;
            this.btn_Estadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Estadisticas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Estadisticas.FlatAppearance.BorderSize = 2;
            this.btn_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Estadisticas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Estadisticas.Location = new System.Drawing.Point(38, 226);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.btn_Estadisticas.Size = new System.Drawing.Size(289, 76);
            this.btn_Estadisticas.TabIndex = 3;
            this.btn_Estadisticas.Text = "Estadisticas";
            this.btn_Estadisticas.UseVisualStyleBackColor = false;
            this.btn_Estadisticas.Click += new System.EventHandler(this.btn_Estadisticas_Click);
            // 
            // btn_Tablas
            // 
            this.btn_Tablas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Tablas.BackColor = System.Drawing.Color.Lavender;
            this.btn_Tablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Tablas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Tablas.FlatAppearance.BorderSize = 2;
            this.btn_Tablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tablas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Tablas.Location = new System.Drawing.Point(38, 23);
            this.btn_Tablas.Name = "btn_Tablas";
            this.btn_Tablas.Size = new System.Drawing.Size(289, 76);
            this.btn_Tablas.TabIndex = 5;
            this.btn_Tablas.Text = "Tablas";
            this.btn_Tablas.UseVisualStyleBackColor = false;
            this.btn_Tablas.Click += new System.EventHandler(this.btn_Tablas_Click);
            // 
            // btn_Archivos
            // 
            this.btn_Archivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Archivos.BackColor = System.Drawing.Color.Lavender;
            this.btn_Archivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Archivos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Archivos.FlatAppearance.BorderSize = 2;
            this.btn_Archivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Archivos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Archivos.Location = new System.Drawing.Point(38, 128);
            this.btn_Archivos.Name = "btn_Archivos";
            this.btn_Archivos.Size = new System.Drawing.Size(289, 76);
            this.btn_Archivos.TabIndex = 6;
            this.btn_Archivos.Text = "Archivos";
            this.btn_Archivos.UseVisualStyleBackColor = false;
            this.btn_Archivos.Click += new System.EventHandler(this.btn_Archivos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.Lavender;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(38, 325);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(289, 76);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 413);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btn_Archivos);
            this.Controls.Add(this.btn_Tablas);
            this.Controls.Add(this.btn_Estadisticas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompetencia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evento deportivo";
            this.Load += new System.EventHandler(this.EventoDeportivo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.Button btn_Tablas;
        private System.Windows.Forms.Button btn_Archivos;
        private System.Windows.Forms.Button btnSalir;
    }
}