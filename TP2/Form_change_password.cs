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
    public partial class Form_change_password : Form
    {
        public Form_change_password()
        {
            InitializeComponent();
        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            this.Hide();

            new FormLogin().ShowDialog();
        }

        private void button_change_password_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtNewPassword1.Text)
            {
                MessageBox.Show("La nueva password no corresponde con su verificaciòn");
            }
            else
            {
                var usuriod = new AgenciaManager().autenticarUsuario(Convert.ToInt32(txtDNI.Text), txtOldPassword.Text);
                if (usuriod == null)
                {
                    MessageBox.Show("No coincide Usaurio con vija clavce");
                }
                else
                {
                    using StreamReader r = new StreamReader("./datos/usuarios.json");
                    string json = r.ReadToEnd();
                    r.Close();

                    var lst = JsonConvert.DeserializeObject<List<Usuario>>(json);

                    var lst1 = new List<Usuario>();

                    foreach (var item in lst)
                    {
                        if(item.DNI != usuriod.DNI)
                        {
                            lst1.Add(item);
                        }
                    }

                    usuriod.Password = PasswordHash.CreateHash(txtNewPassword.Text);

                    lst1.Add(usuriod);

                    string outputJSON = "";
                    foreach (var item in lst1)
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
            }
        }
    }
}
