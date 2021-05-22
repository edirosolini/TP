
namespace TP2
{
    partial class FormResultadoBusqueda
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
            this.home_form_user = new System.Windows.Forms.Label();
            this.grid_alojamientos_disponibles = new System.Windows.Forms.DataGridView();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precioxnoche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precioxdia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadiaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_alojamientos_disponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // home_form_user
            // 
            this.home_form_user.AutoSize = true;
            this.home_form_user.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_form_user.Location = new System.Drawing.Point(308, 52);
            this.home_form_user.Name = "home_form_user";
            this.home_form_user.Size = new System.Drawing.Size(316, 37);
            this.home_form_user.TabIndex = 1;
            this.home_form_user.Text = "Alojamientos disponibles";
            // 
            // grid_alojamientos_disponibles
            // 
            this.grid_alojamientos_disponibles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.grid_alojamientos_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_alojamientos_disponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Localidad,
            this.Tipo,
            this.Precioxnoche,
            this.Precioxdia,
            this.EstadiaTotal,
            this.Reservar});
            this.grid_alojamientos_disponibles.Location = new System.Drawing.Point(148, 119);
            this.grid_alojamientos_disponibles.Name = "grid_alojamientos_disponibles";
            this.grid_alojamientos_disponibles.RowTemplate.Height = 25;
            this.grid_alojamientos_disponibles.Size = new System.Drawing.Size(643, 187);
            this.grid_alojamientos_disponibles.TabIndex = 2;
            this.grid_alojamientos_disponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_alojamientos_disponibles_CellContentClick);
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Precioxnoche
            // 
            this.Precioxnoche.HeaderText = "Precio x noche";
            this.Precioxnoche.Name = "Precioxnoche";
            // 
            // Precioxdia
            // 
            this.Precioxdia.HeaderText = "Precio x dia";
            this.Precioxdia.Name = "Precioxdia";
            // 
            // EstadiaTotal
            // 
            this.EstadiaTotal.HeaderText = "Estadia total";
            this.EstadiaTotal.Name = "EstadiaTotal";
            // 
            // Reservar
            // 
            this.Reservar.DataPropertyName = "Click";
            this.Reservar.HeaderText = "Reservar";
            this.Reservar.Name = "Reservar";
            // 
            // button_atras
            // 
            this.button_atras.ForeColor = System.Drawing.Color.Black;
            this.button_atras.Location = new System.Drawing.Point(21, 12);
            this.button_atras.Name = "button_atras";
            this.button_atras.Size = new System.Drawing.Size(83, 34);
            this.button_atras.TabIndex = 3;
            this.button_atras.Text = "Atras";
            this.button_atras.UseVisualStyleBackColor = true;
            // 
            // FormResultadoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(34)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.button_atras);
            this.Controls.Add(this.grid_alojamientos_disponibles);
            this.Controls.Add(this.home_form_user);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormResultadoBusqueda";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid_alojamientos_disponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label home_form_user;
        private System.Windows.Forms.DataGridView grid_alojamientos_disponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precioxnoche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precioxdia;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadiaTotal;
        private System.Windows.Forms.DataGridViewButtonColumn Reservar;
        private System.Windows.Forms.Button button_atras;
    }
}