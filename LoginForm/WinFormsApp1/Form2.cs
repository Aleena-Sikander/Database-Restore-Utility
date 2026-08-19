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

            //dummy databases for now, later, these can come from your backend/API.
            cmpnydb_cmbBx.Items.Add("dummyclient1");
            cmpnydb_cmbBx.Items.Add("dummyclient2");
            cmpnydb_cmbBx.Items.Add("dummyclient3");
            cmpnydb_cmbBx.DropDownStyle = ComboBoxStyle.DropDownList;

            //initially disabled until other radio buton selected
            bckp_dt_pckr.Enabled = false;

            frsh_bckp_rdBtn.CheckedChanged +=
                BackupSource_CheckedChanged;

            lst_bckp_rdBtn.CheckedChanged +=
                BackupSource_CheckedChanged;

            othr_rdBtn.CheckedChanged +=
                BackupSource_CheckedChanged;


            sbmt_btn.Click += sbmt_btn_Click;

            cncl_btn.Click += cncl_btn_Click;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void BackupSource_CheckedChanged(object sender,EventArgs e)
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


        private void sbmt_btn_Click(
            object sender,
            EventArgs e)
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



            string requestName =
                rstr_rq_nm_txtbx.Text.Trim();

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


            string databaseName =
                cmpnydb_cmbBx.SelectedItem.ToString();




            string backupDate = "";

            if (othr_rdBtn.Checked)
            {
                backupDate =
                    bckp_dt_pckr.Value.ToString("dd/MM/yyyy");
            }



            string message =
                "Restore request created successfully!\n\n" +
                "Company Database: " + databaseName + "\n" +
                "Request Name: " + requestName + "\n" +
                "Virtual Machine: " + virtualMachine + "\n" +
                "Restore Source: " + backupSource;


            // Only show the date when "Other" was selected.
            if (othr_rdBtn.Checked)
            {
                message +=
                    "\nBackup Date: " + backupDate;
            }


            MessageBox.Show(
                message,
                "Restore Request",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );


          

        private void cncl_btn_Click(
            object sender,
            EventArgs e)
        {
            // Clear database selection.
            cmpnydb_cmbBx.SelectedIndex = -1;

            // Clear request name.
            rstr_rq_nm_txtbx.Clear();

            // Clear restore source.
            frsh_bckp_rdBtn.Checked = false;
            lst_bckp_rdBtn.Checked = false;
            othr_rdBtn.Checked = false;

            // Disable date picker again.
            bckp_dt_pckr.Enabled = false;
        }



        public void bckp_rq_lgout_btn_Click(
            object sender,
            EventArgs e)
        {
            // Create the login form again.
            Form1 nextForm = new Form1();

            // Show login form.
            nextForm.Show();

            // Hide the current form.
            this.Hide();
        }
    }
}