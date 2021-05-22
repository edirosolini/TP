using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_register frm = new Form_register();

            this.Hide();
            frm.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var usuriod = new AgenciaManager().autenticarUsuario(Convert.ToInt32(textuser.Text), textpassword.Text);

                if (usuriod != null)
                {
                    if (usuriod.EsAdmin)
                    {
                        FormAdministrators frm = new FormAdministrators();

                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        FormUsers frm = new FormUsers();

                        this.Hide();
                        frm.ShowDialog();
                    }

                }
                else
                    MessageBox.Show("Login erroneo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            Form_change_password frm = new Form_change_password();

            this.Hide();
            frm.ShowDialog();
        }
    }
}
