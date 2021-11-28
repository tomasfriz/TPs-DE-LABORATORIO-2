
namespace FrmAnalisisDeDatos
{
    partial class FrmTablas
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_juegos = new System.Windows.Forms.DataGridView();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_Puntos = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Juego = new System.Windows.Forms.Label();
            this.lbl_Seleccione = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_juegos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(203)))), ((int)(((byte)(133)))));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Add.FlatAppearance.BorderSize = 2;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Location = new System.Drawing.Point(545, 52);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(227, 46);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Añadir";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_juegos
            // 
            this.dgv_juegos.AllowUserToAddRows = false;
            this.dgv_juegos.AllowUserToDeleteRows = false;
            this.dgv_juegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_juegos.Location = new System.Drawing.Point(12, 52);
            this.dgv_juegos.Name = "dgv_juegos";
            this.dgv_juegos.ReadOnly = true;
            this.dgv_juegos.RowTemplate.Height = 25;
            this.dgv_juegos.Size = new System.Drawing.Size(527, 382);
            this.dgv_juegos.TabIndex = 7;
            // 
            // btn_Volver
            // 
            this.btn_Volver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(124)))), ((int)(((byte)(115)))));
            this.btn_Volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Volver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Volver.FlatAppearance.BorderSize = 2;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Volver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Volver.Location = new System.Drawing.Point(545, 376);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(227, 58);
            this.btn_Volver.TabIndex = 23;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_Puntos
            // 
            this.lbl_Puntos.AutoSize = true;
            this.lbl_Puntos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Puntos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Puntos.Location = new System.Drawing.Point(555, 324);
            this.lbl_Puntos.Name = "lbl_Puntos";
            this.lbl_Puntos.Size = new System.Drawing.Size(0, 28);
            this.lbl_Puntos.TabIndex = 24;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(203)))), ((int)(((byte)(133)))));
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Update.FlatAppearance.BorderSize = 2;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Update.Location = new System.Drawing.Point(545, 104);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(227, 46);
            this.btn_Update.TabIndex = 25;
            this.btn_Update.Text = "Modificar";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(203)))), ((int)(((byte)(133)))));
            this.btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Remove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Remove.FlatAppearance.BorderSize = 2;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Remove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Remove.Location = new System.Drawing.Point(545, 156);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(227, 46);
            this.btn_Remove.TabIndex = 26;
            this.btn_Remove.Text = "Eliminar";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(545, 278);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(227, 23);
            this.cmb_tipo.TabIndex = 30;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(576, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tipo de juego";
            // 
            // lbl_Juego
            // 
            this.lbl_Juego.AutoSize = true;
            this.lbl_Juego.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Juego.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Juego.Location = new System.Drawing.Point(337, 9);
            this.lbl_Juego.Name = "lbl_Juego";
            this.lbl_Juego.Size = new System.Drawing.Size(0, 28);
            this.lbl_Juego.TabIndex = 32;
            this.lbl_Juego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Seleccione
            // 
            this.lbl_Seleccione.AutoSize = true;
            this.lbl_Seleccione.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Seleccione.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Seleccione.Location = new System.Drawing.Point(12, 9);
            this.lbl_Seleccione.Name = "lbl_Seleccione";
            this.lbl_Seleccione.Size = new System.Drawing.Size(552, 28);
            this.lbl_Seleccione.TabIndex = 33;
            this.lbl_Seleccione.Text = "Mostrando todos, seleccione un tipo de juego.";
            this.lbl_Seleccione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(212)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lbl_Seleccione);
            this.Controls.Add(this.lbl_Juego);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lbl_Puntos);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.dgv_juegos);
            this.Controls.Add(this.btn_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmTablas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTablas";
            this.Load += new System.EventHandler(this.Tablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_juegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_juegos;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label lbl_Puntos;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Juego;
        private System.Windows.Forms.Label lbl_Seleccione;
    }
}