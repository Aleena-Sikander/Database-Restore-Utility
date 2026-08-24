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

        private void lgn_bttn_Click(object sender, EventArgs e)
        {
            string username = user_txtbx.Text;
            string password = pw_txtbx.Text;
            string role = devops_rdbttn.Checked ? "DevOps" : supprtdev_rdbttn.Checked ? "SupportDev" : null;

            while (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || role == null)
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Enter all fields");
                }
                else if (role == null)
                {
                    MessageBox.Show("Role not selected");
                }
                return; 
            }

            // Hardcoded login verification
            switch ((username, password, role))
            {
                //case ("devOpsUser1", "devOpsPassword", "DevOps"):
                //    MessageBox.Show("User verified");
                //    OpenForm(new Form2());
                //    break;

                case ("aleena", "123", "DevOps"):
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
        private void OpenForm(Form nextForm)
        {
            nextForm.Show();
            this.Hide();
        }
    }
}