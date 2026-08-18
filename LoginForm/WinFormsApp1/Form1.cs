using System.Data;

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
            string role = radioButton1.Checked ? "DevOps" : radioButton2.Checked ? "SupportDev" : null;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter all fields");
            }
            else if (role==null)
            {
                MessageBox.Show("Role not selected");
            }

            //if (username == "devOpsUser1" && password == "devOpsPassword" && radioButton1.Checked)
            //{
            //    // Show success message
            //    MessageBox.Show("User verified");

            //    // Create a new Form2
            //    Form2 nextForm = new Form2();

            //    // Display Form2
            //    nextForm.Show();

            //    // Hide the current Form1
            //    this.Hide();

            //}
            //else if (username == "supportDevUser1" && password == "supportDevPassword" && radioButton2.Checked)
            //{
            //    // Show success message
            //    MessageBox.Show("User verified");
            //    Form3 nextForm = new Form3();
            //    nextForm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong user");
            //}

            // Hardcoded login verification
            switch ((username, password, role))
            {
                case ("devOpsUser1", "devOpsPassword", "DevOps"):
                    MessageBox.Show("User verified");
                    OpenForm(new Form2());
                    break;

                case ("supportDevUser1", "supportDevPassword", "SupportDev"):
                    MessageBox.Show("User verified");
                    OpenForm(new Form3());
                    break;

                default:
                    MessageBox.Show("Invalid credentials");
                    break;
            }
        }

        //helper function
        private void OpenForm(Form nextForm)
        {
            nextForm.Show();
            this.Hide();
        }
    }
}