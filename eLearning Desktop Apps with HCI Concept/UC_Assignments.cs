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
    public partial class UC_Assignments : UserControl
    {
        public UC_Assignments()
        {
            InitializeComponent();
            ResetButtonColors();
            button1.BackColor = Color.FromArgb(17, 24, 39);
            button1.ForeColor = Color.White;
        }

        private void FilterTasks(string tipe)
        {
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item is Panel)
                {
                    if (tipe == "all")
                    {
                        item.Visible = true; // Munculin semua
                    }
                    else
                    {
                        // Cek Tag-nya (quiz/assign)
                        if (item.Tag != null && item.Tag.ToString() == tipe)
                        {
                            item.Visible = true; // Munculin yang cocok
                        }
                        else
                        {
                            item.Visible = false; // Umpetin yang beda
                        }
                    }
                }
            }
        }

        private void ResetButtonColors()
        {
            // Button 1 (All)
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Gray;

            // Button 2 (Quiz)
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Gray;

            // Button 3 (Assignments)
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Gray;
        }

        // TOMBOL 1: ALL TASKS
        private void button1_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            button1.BackColor = Color.FromArgb(17, 24, 39);
            button1.ForeColor = Color.White;

            // Panggil Filter
            FilterTasks("all");
        }

        // TOMBOL 2: QUIZ
        private void button2_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            button2.BackColor = Color.FromArgb(17, 24, 39);
            button2.ForeColor = Color.White;

            FilterTasks("quiz");
        }

        // TOMBOL 3: ASSIGNMENTS
        private void button3_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            button3.BackColor = Color.FromArgb(17, 24, 39);
            button3.ForeColor = Color.White;

            FilterTasks("assign");
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void button6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}