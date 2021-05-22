using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TP2
{
    public partial class Form_register : Form
    {
        public Form_register()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            using StreamReader r = new StreamReader("./datos/usuarios.json");
            string json = r.ReadToEnd();
            r.Close();

            var lst = JsonConvert.DeserializeObject<List<Usuario>>(json);
            try
            {
                lst.Add(new Usuario
                {
                    DNI = Convert.ToInt32(txtDNI.Text),
                    Nombre = txtNombre.Text,
                    Mail = txtMail.Text,
                    Password = PasswordHash.CreateHash(txtPassword.Text),
                    EsAdmin = false,
                    Bloqueado = false
                });


                string outputJSON = "";
                foreach (var item in lst)
                {
                    outputJSON += JsonConvert.SerializeObject(item, Formatting.Indented) + ",";
                }

                if (File.Exists("./datos/usuarios.json"))
                {
                    File.Delete("./datos/usuarios.json");
                }

                StreamWriter sw = new StreamWriter("./datos/usuarios.json");
                //Write a line of text
                sw.WriteLine("[" + outputJSON + "]");

                //Close the file
                sw.Close();

                this.Hide();

                new FormLogin().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            this.Hide();

            new FormLogin().ShowDialog();
        }
    }
}
