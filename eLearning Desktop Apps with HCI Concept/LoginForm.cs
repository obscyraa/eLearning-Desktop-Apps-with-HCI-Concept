using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLearning_Desktop_Apps_with_HCI_Concept
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Sembunyikan Form Login biar gak ganggu
            this.Hide();

            // 2. Panggil Form Dashboard (Form1)
            Form1 dashboard = new Form1();

            // 3. Tampilkan Dashboard
            dashboard.Show();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}