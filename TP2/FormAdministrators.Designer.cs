
namespace TP2
{
    partial class FormAdministrators
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
            this.grid_usuarios = new System.Windows.Forms.DataGridView();
            this.button_modificar_usuario = new System.Windows.Forms.Button();
            this.button_elimina_usuario = new System.Windows.Forms.Button();
            this.button_desbloquear_usuario = new System.Windows.Forms.Button();
            this.grid_reservas = new System.Windows.Forms.DataGridView();
            this.button_elimina_reserva = new System.Windows.Forms.Button();
            this.button_modificar_reserva = new System.Windows.Forms.Button();
            this.grid_alojamientos = new System.Windows.Forms.DataGridView();
            this.button_agregar_alojamiento = new System.Windows.Forms.Button();
            this.button_quitar_alojamiento = new System.Windows.Forms.Button();
            this.button_modificar_alojamiento = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_alojamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_usuarios
            // 
            this.grid_usuarios.AllowUserToAddRows = false;
            this.grid_usuarios.AllowUserToDeleteRows = false;
            this.grid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_usuarios.Location = new System.Drawing.Point(31, 112);
            this.grid_usuarios.Name = "grid_usuarios";
            this.grid_usuarios.ReadOnly = true;
            this.grid_usuarios.RowTemplate.Height = 25;
            this.grid_usuarios.Size = new System.Drawing.Size(647, 92);
            this.grid_usuarios.TabIndex = 0;
            this.grid_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_modificar_usuario
            // 
            this.button_modificar_usuario.Location = new System.Drawing.Point(697, 100);
            this.button_modificar_usuario.Name = "button_modificar_usuario";
            this.button_modificar_usuario.Size = new System.Drawing.Size(92, 38);
            this.button_modificar_usuario.TabIndex = 1;
            this.button_modificar_usuario.Text = "Modificar";
            this.button_modificar_usuario.UseVisualStyleBackColor = true;
            this.button_modificar_usuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_elimina_usuario
            // 
            this.button_elimina_usuario.Location = new System.Drawing.Point(696, 140);
            this.button_elimina_usuario.Name = "button_elimina_usuario";
            this.button_elimina_usuario.Size = new System.Drawing.Size(93, 38);
            this.button_elimina_usuario.TabIndex = 2;
            this.button_elimina_usuario.Text = "Eliminar";
            this.button_elimina_usuario.UseVisualStyleBackColor = true;
            // 
            // button_desbloquear_usuario
            // 
            this.button_desbloquear_usuario.Location = new System.Drawing.Point(696, 184);
            this.button_desbloquear_usuario.Name = "button_desbloquear_usuario";
            this.button_desbloquear_usuario.Size = new System.Drawing.Size(93, 38);
            this.button_desbloquear_usuario.TabIndex = 3;
            this.button_desbloquear_usuario.Text = "Desbloquear";
            this.button_desbloquear_usuario.UseVisualStyleBackColor = true;
            // 
            // grid_reservas
            // 
            this.grid_reservas.AllowUserToAddRows = false;
            this.grid_reservas.AllowUserToDeleteRows = false;
            this.grid_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_reservas.Location = new System.Drawing.Point(31, 254);
            this.grid_reservas.Name = "grid_reservas";
            this.grid_reservas.ReadOnly = true;
            this.grid_reservas.RowTemplate.Height = 25;
            this.grid_reservas.Size = new System.Drawing.Size(646, 92);
            this.grid_reservas.TabIndex = 4;
            // 
            // button_elimina_reserva
            // 
            this.button_elimina_reserva.Location = new System.Drawing.Point(795, 279);
            this.button_elimina_reserva.Name = "button_elimina_reserva";
            this.button_elimina_reserva.Size = new System.Drawing.Size(94, 38);
            this.button_elimina_reserva.TabIndex = 6;
            this.button_elimina_reserva.Text = "Eliminar";
            this.button_elimina_reserva.UseVisualStyleBackColor = true;
            // 
            // button_modificar_reserva
            // 
            this.button_modificar_reserva.Location = new System.Drawing.Point(691, 279);
            this.button_modificar_reserva.Name = "button_modificar_reserva";
            this.button_modificar_reserva.Size = new System.Drawing.Size(98, 38);
            this.button_modificar_reserva.TabIndex = 5;
            this.button_modificar_reserva.Text = "Modificar";
            this.button_modificar_reserva.UseVisualStyleBackColor = true;
            // 
            // grid_alojamientos
            // 
            this.grid_alojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_alojamientos.Location = new System.Drawing.Point(31, 411);
            this.grid_alojamientos.Name = "grid_alojamientos";
            this.grid_alojamientos.RowTemplate.Height = 25;
            this.grid_alojamientos.Size = new System.Drawing.Size(646, 92);
            this.grid_alojamientos.TabIndex = 7;
            // 
            // button_agregar_alojamiento
            // 
            this.button_agregar_alojamiento.Location = new System.Drawing.Point(691, 433);
            this.button_agregar_alojamiento.Name = "button_agregar_alojamiento";
            this.button_agregar_alojamiento.Size = new System.Drawing.Size(88, 38);
            this.button_agregar_alojamiento.TabIndex = 10;
            this.button_agregar_alojamiento.Text = "Agregar";
            this.button_agregar_alojamiento.UseVisualStyleBackColor = true;
            this.button_agregar_alojamiento.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_quitar_alojamiento
            // 
            this.button_quitar_alojamiento.Location = new System.Drawing.Point(878, 433);
            this.button_quitar_alojamiento.Name = "button_quitar_alojamiento";
            this.button_quitar_alojamiento.Size = new System.Drawing.Size(80, 38);
            this.button_quitar_alojamiento.TabIndex = 9;
            this.button_quitar_alojamiento.Text = "Quitar";
            this.button_quitar_alojamiento.UseVisualStyleBackColor = true;
            this.button_quitar_alojamiento.Click += new System.EventHandler(this.button7_Click);
            // 
            // button_modificar_alojamiento
            // 
            this.button_modificar_alojamiento.Location = new System.Drawing.Point(786, 433);
            this.button_modificar_alojamiento.Name = "button_modificar_alojamiento";
            this.button_modificar_alojamiento.Size = new System.Drawing.Size(84, 38);
            this.button_modificar_alojamiento.TabIndex = 8;
            this.button_modificar_alojamiento.Text = "Modificar";
            this.button_modificar_alojamiento.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 23);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Reservas:";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 382);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 23);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Alojamientos:";
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(831, 12);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(105, 39);
            this.button_logout.TabIndex = 14;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuarios:";
            // 
            // FormAdministrators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(34)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_agregar_alojamiento);
            this.Controls.Add(this.button_quitar_alojamiento);
            this.Controls.Add(this.button_modificar_alojamiento);
            this.Controls.Add(this.grid_alojamientos);
            this.Controls.Add(this.button_elimina_reserva);
            this.Controls.Add(this.button_modificar_reserva);
            this.Controls.Add(this.grid_reservas);
            this.Controls.Add(this.button_desbloquear_usuario);
            this.Controls.Add(this.button_elimina_usuario);
            this.Controls.Add(this.button_modificar_usuario);
            this.Controls.Add(this.grid_usuarios);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormAdministrators";
            this.Text = "Alojamientos:";
            this.Load += new System.EventHandler(this.FormAdministrators_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_alojamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_usuarios;
        private System.Windows.Forms.Button button_modificar_usuario;
        private System.Windows.Forms.Button button_elimina_usuario;
        private System.Windows.Forms.Button button_desbloquear_usuario;
        private System.Windows.Forms.DataGridView grid_reservas;
        private System.Windows.Forms.Button button_elimina_reserva;
        private System.Windows.Forms.Button button_modificar_reserva;
        private System.Windows.Forms.DataGridView grid_alojamientos;
        private System.Windows.Forms.Button button_agregar_alojamiento;
        private System.Windows.Forms.Button button_quitar_alojamiento;
        private System.Windows.Forms.Button button_modificar_alojamiento;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label1;
    }
}