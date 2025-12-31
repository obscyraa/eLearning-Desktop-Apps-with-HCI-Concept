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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Navigation(new UC_Dashboard());
        }

        private void Navigation(UserControl uc)
        {
            panelMain.Controls.Clear(); // Hapus tampilan lama
            uc.Dock = DockStyle.Fill;   // Setting biar full screen
            panelMain.Controls.Add(uc); // Masukin tampilan baru
        }

        // Button 1 = Dashboard
        private void button1_Click(object sender, EventArgs e)
        {
            Navigation(new UC_Dashboard());
        }

        // Button 2 = My Courses
        private void button2_Click(object sender, EventArgs e)
        {
            Navigation(new UC_MyCourses());
        }

        // Button 3 = Assignments & Quiz
        private void button3_Click(object sender, EventArgs e)
        {
            Navigation(new UC_Assignments());
        }

        // Button 4 = Progress Report
        private void button4_Click(object sender, EventArgs e)
        {
            Navigation(new UC_ProgressReport());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}