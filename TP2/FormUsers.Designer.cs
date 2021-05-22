
namespace TP2
{
    partial class FormUsers
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
            this.box_localidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.box_tipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_cantidad_de_personas = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button_buscar_alojamiento = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // home_form_user
            // 
            this.home_form_user.AutoSize = true;
            this.home_form_user.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_form_user.Location = new System.Drawing.Point(360, 35);
            this.home_form_user.Name = "home_form_user";
            this.home_form_user.Size = new System.Drawing.Size(242, 37);
            this.home_form_user.TabIndex = 0;
            this.home_form_user.Text = "Buscar alojamiento";
            // 
            // box_localidad
            // 
            this.box_localidad.FormattingEnabled = true;
            this.box_localidad.Items.AddRange(new object[] {
            "Palermo",
            "Caballito"});
            this.box_localidad.Location = new System.Drawing.Point(327, 142);
            this.box_localidad.Name = "box_localidad";
            this.box_localidad.Size = new System.Drawing.Size(275, 23);
            this.box_localidad.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(414, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Localidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(199, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(592, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(571, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo de alojamiento";
            // 
            // box_tipo
            // 
            this.box_tipo.FormattingEnabled = true;
            this.box_tipo.Items.AddRange(new object[] {
            "Hotel",
            "Cabaña",
            "Ambos"});
            this.box_tipo.Location = new System.Drawing.Point(524, 361);
            this.box_tipo.Name = "box_tipo";
            this.box_tipo.Size = new System.Drawing.Size(275, 23);
            this.box_tipo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(169, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cantidad de personas";
            // 
            // box_cantidad_de_personas
            // 
            this.box_cantidad_de_personas.FormattingEnabled = true;
            this.box_cantidad_de_personas.Items.AddRange(new object[] {
            "1",
            "2",
            "3 o mas"});
            this.box_cantidad_de_personas.Location = new System.Drawing.Point(131, 360);
            this.box_cantidad_de_personas.Name = "box_cantidad_de_personas";
            this.box_cantidad_de_personas.Size = new System.Drawing.Size(275, 23);
            this.box_cantidad_de_personas.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 23);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(524, 238);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(266, 23);
            this.dateTimePicker2.TabIndex = 19;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button_buscar_alojamiento
            // 
            this.button_buscar_alojamiento.ForeColor = System.Drawing.Color.Black;
            this.button_buscar_alojamiento.Location = new System.Drawing.Point(395, 450);
            this.button_buscar_alojamiento.Name = "button_buscar_alojamiento";
            this.button_buscar_alojamiento.Size = new System.Drawing.Size(142, 47);
            this.button_buscar_alojamiento.TabIndex = 20;
            this.button_buscar_alojamiento.Text = "Buscar";
            this.button_buscar_alojamiento.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.ForeColor = System.Drawing.Color.Black;
            this.button_logout.Location = new System.Drawing.Point(841, 24);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(104, 38);
            this.button_logout.TabIndex = 21;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(34)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_buscar_alojamiento);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_tipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_cantidad_de_personas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_localidad);
            this.Controls.Add(this.home_form_user);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label home_form_user;
        private System.Windows.Forms.ComboBox box_localidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox box_tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox box_cantidad_de_personas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button_buscar_alojamiento;
        private System.Windows.Forms.Button button_logout;
    }
}