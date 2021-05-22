using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP2
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

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
