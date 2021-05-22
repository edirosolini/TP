
namespace TP2
{
    partial class Form_register
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
            this.home_register = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_atras = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // home_register
            // 
            this.home_register.AutoSize = true;
            this.home_register.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_register.ForeColor = System.Drawing.Color.White;
            this.home_register.Location = new System.Drawing.Point(413, 141);
            this.home_register.Name = "home_register";
            this.home_register.Size = new System.Drawing.Size(107, 37);
            this.home_register.TabIndex = 9;
            this.home_register.Text = "Sign up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.DimGray;
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(78, 280);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(275, 23);
            this.txtMail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.DimGray;
            this.txtDNI.ForeColor = System.Drawing.Color.White;
            this.txtDNI.Location = new System.Drawing.Point(78, 204);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(275, 23);
            this.txtDNI.TabIndex = 1;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(416, 344);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(116, 37);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "Sign in";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_atras
            // 
            this.button_atras.ForeColor = System.Drawing.Color.Black;
            this.button_atras.Location = new System.Drawing.Point(21, 22);
            this.button_atras.Name = "button_atras";
            this.button_atras.Size = new System.Drawing.Size(94, 43);
            this.button_atras.TabIndex = 15;
            this.button_atras.Text = "Atras";
            this.button_atras.UseVisualStyleBackColor = true;
            this.button_atras.Click += new System.EventHandler(this.button_atras_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.White;
            this.Nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nombre.Location = new System.Drawing.Point(370, 180);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(68, 21);
            this.Nombre.TabIndex = 17;
            this.Nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.DimGray;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(370, 204);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(370, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DimGray;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(370, 280);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(275, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // Form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(34)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button_atras);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.home_register);
            this.Name = "Form_register";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label home_register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_atras;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
    }
}