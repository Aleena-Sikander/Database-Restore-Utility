using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Set the welcome message
            lblWelcome.Text = "Welcome to the devOps page!";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();

            // Display Form2
            nextForm.Show();

            // Hide the current Form1
            this.Hide();
        }
    }
}
