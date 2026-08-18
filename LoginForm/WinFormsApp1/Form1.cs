namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get whatever the user typed into the TextBox
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "devOpsUser1" && password == "devOpsPassword" && radioButton1.Checked)
            {
                // Show success message
                MessageBox.Show("User verified");

                // Create a new Form2
                Form2 nextForm = new Form2();

                // Display Form2
                nextForm.Show();

                // Hide the current Form1
                this.Hide();

            }
            else if (username == "supportDevUser1" && password == "supportDevPassword" && radioButton2.Checked)
            {
                // Show success message
                MessageBox.Show("User verified");
                Form3 nextForm = new Form3();
                nextForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong user");
            }
        }
    }
}