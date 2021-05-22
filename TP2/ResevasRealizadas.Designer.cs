
namespace TP2
{
    partial class ResevasRealizadas
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
            this.button_atras = new System.Windows.Forms.Button();
            this.grid_alojamientos_disponibles = new System.Windows.Forms.DataGridView();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarReserva = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_alojamientos_disponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // home_form_user
            // 
            this.home_form_user.AutoSize = true;
            this.home_form_user.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_form_user.ForeColor = System.Drawing.Color.White;
            this.home_form_user.Location = new System.Drawing.Point(311, 69);
            this.home_form_user.Name = "home_form_user";
            this.home_form_user.Size = new System.Drawing.Size(307, 37);
            this.home_form_user.TabIndex = 8;
            this.home_form_user.Text = "Alojamientos reservados";
            // 
            // button_atras
            // 
            this.button_atras.ForeColor = System.Drawing.Color.Black;
            this.button_atras.Location = new System.Drawing.Point(12, 12);
            this.button_atras.Name = "button_atras";
            this.button_atras.Size = new System.Drawing.Size(91, 40);
            this.button_atras.TabIndex = 9;
            this.button_atras.Text = "Atras";
            this.button_atras.UseVisualStyleBackColor = true;
            // 
            // grid_alojamientos_disponibles
            // 
            this.grid_alojamientos_disponibles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.grid_alojamientos_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_alojamientos_disponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Localidad,
            this.Tipo,
            this.FechaDesde,
            this.FechaHasta,
            this.EliminarReserva});
            this.grid_alojamientos_disponibles.Location = new System.Drawing.Point(198, 124);
            this.grid_alojamientos_disponibles.Name = "grid_alojamientos_disponibles";
            this.grid_alojamientos_disponibles.RowTemplate.Height = 25;
            this.grid_alojamientos_disponibles.Size = new System.Drawing.Size(543, 187);
            this.grid_alojamientos_disponibles.TabIndex = 10;
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
            // FechaDesde
            // 
            this.FechaDesde.HeaderText = "Fecha desde";
            this.FechaDesde.Name = "FechaDesde";
            // 
            // FechaHasta
            // 
            this.FechaHasta.HeaderText = "Fecha hasta";
            this.FechaHasta.Name = "FechaHasta";
            // 
            // EliminarReserva
            // 
            this.EliminarReserva.DataPropertyName = "Click";
            this.EliminarReserva.HeaderText = "Eliminar reserva";
            this.EliminarReserva.Name = "EliminarReserva";
            // 
            // ResevasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(34)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.grid_alojamientos_disponibles);
            this.Controls.Add(this.button_atras);
            this.Controls.Add(this.home_form_user);
            this.Name = "ResevasRealizadas";
            this.Text = "Reservas_realizadas";
            ((System.ComponentModel.ISupportInitialize)(this.grid_alojamientos_disponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label home_form_user;
        private System.Windows.Forms.Button button_atras;
        private System.Windows.Forms.DataGridView grid_alojamientos_disponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHasta;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarReserva;
    }
}