using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            bckp_hstry_tbPg.Text = "Backup History";
            cmpnydb_lbl.Text = "Company database:";
            LoadCompanyDatabases();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (DatabaseConnection.TestConnection())
            {
            }
            else
            {
                MessageBox.Show(
                    "Could not connect to the MySQL database.\n\n" +
                    "Please check:\n" +
                    "- MySQL server is running\n" +
                    "- Username/password are correct\n" +
                    "- Database name is correct",
                    "Database Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LoadCompanyDatabases()
        {
            cmpnydb_cmbBx.Items.Clear();

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // dummy db 'employee'
                    cmpnydb_cmbBx.Items.Add("employee");
                    if (cmpnydb_cmbBx.Items.Count > 0)
                    {
                        cmpnydb_cmbBx.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading company databases:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void BackupSource_CheckedChanged(object sender, EventArgs e)
        {

            if (othr_rdBtn.Checked)
            {
                bckp_dt_pckr.Enabled = true;
            }
            else
            {
                bckp_dt_pckr.Enabled = false;
            }
        }
        private void sbmt_btn_Click(object sender, EventArgs e)
        {
            if (cmpnydb_cmbBx.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a company database.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            string requestName =rstr_rq_nm_txtbx.Text.Trim();

            if (string.IsNullOrWhiteSpace(requestName))
            {
                MessageBox.Show(
                    "Please enter a restore request name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                rstr_rq_nm_txtbx.Focus();
                return;
            }

            string backupSource = "";

            if (frsh_bckp_rdBtn.Checked)
            {
                backupSource = "Fresh Backup";
            }
            else if (lst_bckp_rdBtn.Checked)
            {
                backupSource = "Last Backup";
            }
            else if (othr_rdBtn.Checked)
            {
                backupSource = "Other";
            }
            else
            {
                MessageBox.Show(
                    "Please select a backup source.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string databaseName = cmpnydb_cmbBx.SelectedItem?.ToString() ?? "";
            string backupDate = "";

            if (othr_rdBtn.Checked)
            {
                backupDate = bckp_dt_pckr.Value.ToString("dd/MM/yyyy");
            }

            string message =
                "Restore request created successfully!\n\n" +
                "Company Database: " + databaseName + "\n" +
                "Request Name: " + requestName + "\n" +
                "Restore Source: " + backupSource;

            if (othr_rdBtn.Checked)
            {
                message +="\nBackup Date: " + backupDate;
            }

            MessageBox.Show(
                message,
                "Restore Request",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void cncl_btn_Click(object sender, EventArgs e)
        {
            cmpnydb_cmbBx.SelectedIndex = -1;
            rstr_rq_nm_txtbx.Clear();
            frsh_bckp_rdBtn.Checked = false;
            lst_bckp_rdBtn.Checked = false;
            othr_rdBtn.Checked = false;
            bckp_dt_pckr.Enabled = false;
        }

        public void bckp_rq_lgout_btn_Click(
            object sender,
            EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Hide();
        }
    }
}