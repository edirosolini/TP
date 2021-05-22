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
    public partial class FormAdministrators : Form
    {
        public FormAdministrators()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAdministrators_Load(object sender, EventArgs e)
        {
            using StreamReader r0 = new StreamReader("./datos/usuarios.json");
            string json0 = r0.ReadToEnd();
            grid_usuarios.DataSource = JsonConvert.DeserializeObject<List<Usuario>>(json0);

            using StreamReader r1 = new StreamReader("./datos/reservas.json");
            string json1 = r1.ReadToEnd();
            grid_reservas.DataSource = JsonConvert.DeserializeObject<List<Reserva>>(json1);

            using StreamReader r2 = new StreamReader("./datos/alojamientos.json");
            string json2 = r2.ReadToEnd();
            grid_alojamientos.DataSource = JsonConvert.DeserializeObject<List<Alojamiento>>(json2);
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
