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

        private void btnVerify_Click(object sender, EventArgs e)
        {
            // Get whatever the user typed into the TextBox
            string username = txtUsername.Text;

            // Check if it is EXACTLY "aleena"
            if (username == "aleena")
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
            else
            {
                // Anything other than exactly "aleena"
                MessageBox.Show("Wrong user");
            }
        }
    }
}


namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Set the welcome message
            lblWelcome.Text = "Welcome to the next page!";
        }
    }
}