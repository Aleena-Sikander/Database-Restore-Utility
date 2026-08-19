namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bckp_rq_lgout_btn = new Button();
            tabControl = new TabControl();
            bckp_rq_tbPg = new TabPage();
            cmpnydb_lbl = new Label();
            bckp_hstry_tbPg = new TabPage();
            cmpnydb_cmbBx = new ComboBox();
            bckp_hstry_lgout_btn = new Button();
            rstr_rq_nm_lbl = new Label();
            rstr_rq_nm_txtbx = new TextBox();
            bckp_src_lbl = new Label();
            frsh_bckp_rdBtn = new RadioButton();
            lst_bckp_rdBtn = new RadioButton();
            othr_rdBtn = new RadioButton();
            bckp_dt_pckr = new DateTimePicker();
            sbmt_btn = new Button();
            cncl_btn = new Button();
            tabControl.SuspendLayout();
            bckp_rq_tbPg.SuspendLayout();
            bckp_hstry_tbPg.SuspendLayout();
            SuspendLayout();
            // 
            // bckp_rq_lgout_btn
            // 
            bckp_rq_lgout_btn.BackColor = Color.Red;
            bckp_rq_lgout_btn.FlatAppearance.BorderSize = 0;
            bckp_rq_lgout_btn.FlatStyle = FlatStyle.Flat;
            bckp_rq_lgout_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bckp_rq_lgout_btn.ForeColor = SystemColors.ControlLightLight;
            bckp_rq_lgout_btn.Location = new Point(296, 336);
            bckp_rq_lgout_btn.Name = "bckp_rq_lgout_btn";
            bckp_rq_lgout_btn.Size = new Size(94, 29);
            bckp_rq_lgout_btn.TabIndex = 4;
            bckp_rq_lgout_btn.Text = "Log Out";
            bckp_rq_lgout_btn.UseVisualStyleBackColor = false;
            bckp_rq_lgout_btn.Click += bckp_rq_lgout_btn_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(bckp_rq_tbPg);
            tabControl.Controls.Add(bckp_hstry_tbPg);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(425, 428);
            tabControl.TabIndex = 5;
            // 
            // bckp_rq_tbPg
            // 
            bckp_rq_tbPg.BackColor = SystemColors.Control;
            bckp_rq_tbPg.Controls.Add(cncl_btn);
            bckp_rq_tbPg.Controls.Add(sbmt_btn);
            bckp_rq_tbPg.Controls.Add(bckp_dt_pckr);
            bckp_rq_tbPg.Controls.Add(othr_rdBtn);
            bckp_rq_tbPg.Controls.Add(lst_bckp_rdBtn);
            bckp_rq_tbPg.Controls.Add(frsh_bckp_rdBtn);
            bckp_rq_tbPg.Controls.Add(bckp_src_lbl);
            bckp_rq_tbPg.Controls.Add(rstr_rq_nm_txtbx);
            bckp_rq_tbPg.Controls.Add(rstr_rq_nm_lbl);
            bckp_rq_tbPg.Controls.Add(cmpnydb_cmbBx);
            bckp_rq_tbPg.Controls.Add(cmpnydb_lbl);
            bckp_rq_tbPg.Controls.Add(bckp_rq_lgout_btn);
            bckp_rq_tbPg.Location = new Point(4, 29);
            bckp_rq_tbPg.Name = "bckp_rq_tbPg";
            bckp_rq_tbPg.Padding = new Padding(3);
            bckp_rq_tbPg.Size = new Size(417, 395);
            bckp_rq_tbPg.TabIndex = 0;
            bckp_rq_tbPg.Text = "New Backup Request";
            // 
            // cmpnydb_lbl
            // 
            cmpnydb_lbl.AutoSize = true;
            cmpnydb_lbl.Location = new Point(22, 22);
            cmpnydb_lbl.Name = "cmpnydb_lbl";
            cmpnydb_lbl.Size = new Size(140, 20);
            cmpnydb_lbl.TabIndex = 5;
            cmpnydb_lbl.Text = "Company database:";
            // 
            // bckp_hstry_tbPg
            // 
            bckp_hstry_tbPg.Controls.Add(bckp_hstry_lgout_btn);
            bckp_hstry_tbPg.Location = new Point(4, 29);
            bckp_hstry_tbPg.Name = "bckp_hstry_tbPg";
            bckp_hstry_tbPg.Padding = new Padding(3);
            bckp_hstry_tbPg.Size = new Size(1040, 484);
            bckp_hstry_tbPg.TabIndex = 1;
            bckp_hstry_tbPg.Text = "tabPage2";
            bckp_hstry_tbPg.UseVisualStyleBackColor = true;
            // 
            // cmpnydb_cmbBx
            // 
            cmpnydb_cmbBx.FlatStyle = FlatStyle.Flat;
            cmpnydb_cmbBx.FormattingEnabled = true;
            cmpnydb_cmbBx.Location = new Point(22, 54);
            cmpnydb_cmbBx.Name = "cmpnydb_cmbBx";
            cmpnydb_cmbBx.Size = new Size(368, 28);
            cmpnydb_cmbBx.TabIndex = 6;
            cmpnydb_cmbBx.Text = "Select Database...";
            // 
            // bckp_hstry_lgout_btn
            // 
            bckp_hstry_lgout_btn.BackColor = Color.Red;
            bckp_hstry_lgout_btn.FlatAppearance.BorderSize = 0;
            bckp_hstry_lgout_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bckp_hstry_lgout_btn.ForeColor = SystemColors.ControlLightLight;
            bckp_hstry_lgout_btn.Location = new Point(829, 22);
            bckp_hstry_lgout_btn.Name = "bckp_hstry_lgout_btn";
            bckp_hstry_lgout_btn.Size = new Size(188, 30);
            bckp_hstry_lgout_btn.TabIndex = 6;
            bckp_hstry_lgout_btn.Text = "Log Out";
            bckp_hstry_lgout_btn.UseVisualStyleBackColor = false;
            // 
            // rstr_rq_nm_lbl
            // 
            rstr_rq_nm_lbl.AutoSize = true;
            rstr_rq_nm_lbl.Location = new Point(22, 111);
            rstr_rq_nm_lbl.Name = "rstr_rq_nm_lbl";
            rstr_rq_nm_lbl.Size = new Size(156, 20);
            rstr_rq_nm_lbl.TabIndex = 7;
            rstr_rq_nm_lbl.Text = "Restore request name:";
            //rstr_rq_nm_lbl.Click += this.label2_Click;
            // 
            // rstr_rq_nm_txtbx
            // 
            rstr_rq_nm_txtbx.BorderStyle = BorderStyle.None;
            rstr_rq_nm_txtbx.Location = new Point(22, 143);
            rstr_rq_nm_txtbx.Name = "rstr_rq_nm_txtbx";
            rstr_rq_nm_txtbx.Size = new Size(368, 20);
            rstr_rq_nm_txtbx.TabIndex = 9;
            // 
            // bckp_src_lbl
            // 
            bckp_src_lbl.AutoSize = true;
            bckp_src_lbl.Location = new Point(22, 194);
            bckp_src_lbl.Name = "bckp_src_lbl";
            bckp_src_lbl.Size = new Size(107, 20);
            bckp_src_lbl.TabIndex = 10;
            bckp_src_lbl.Text = "Backup source:";
            // 
            // frsh_bckp_rdBtn
            // 
            frsh_bckp_rdBtn.AutoSize = true;
            frsh_bckp_rdBtn.Location = new Point(22, 226);
            frsh_bckp_rdBtn.Name = "frsh_bckp_rdBtn";
            frsh_bckp_rdBtn.Size = new Size(116, 24);
            frsh_bckp_rdBtn.TabIndex = 12;
            frsh_bckp_rdBtn.TabStop = true;
            frsh_bckp_rdBtn.Text = "Fresh backup";
            frsh_bckp_rdBtn.UseVisualStyleBackColor = true;
            // 
            // lst_bckp_rdBtn
            // 
            lst_bckp_rdBtn.AutoSize = true;
            lst_bckp_rdBtn.Location = new Point(144, 226);
            lst_bckp_rdBtn.Name = "lst_bckp_rdBtn";
            lst_bckp_rdBtn.Size = new Size(108, 24);
            lst_bckp_rdBtn.TabIndex = 13;
            lst_bckp_rdBtn.TabStop = true;
            lst_bckp_rdBtn.Text = "Last backup";
            lst_bckp_rdBtn.UseVisualStyleBackColor = true;
            // 
            // othr_rdBtn
            // 
            othr_rdBtn.AutoSize = true;
            othr_rdBtn.Location = new Point(258, 226);
            othr_rdBtn.Name = "othr_rdBtn";
            othr_rdBtn.Size = new Size(67, 24);
            othr_rdBtn.TabIndex = 14;
            othr_rdBtn.TabStop = true;
            othr_rdBtn.Text = "Other";
            othr_rdBtn.UseVisualStyleBackColor = true;
            // 
            // bckp_dt_pckr
            // 
            bckp_dt_pckr.Enabled = false;
            bckp_dt_pckr.Location = new Point(22, 276);
            bckp_dt_pckr.Name = "bckp_dt_pckr";
            bckp_dt_pckr.Size = new Size(303, 27);
            bckp_dt_pckr.TabIndex = 15;
            // 
            // sbmt_btn
            // 
            sbmt_btn.BackColor = SystemColors.Desktop;
            sbmt_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sbmt_btn.ForeColor = SystemColors.Control;
            sbmt_btn.Location = new Point(22, 336);
            sbmt_btn.Name = "sbmt_btn";
            sbmt_btn.Size = new Size(94, 29);
            sbmt_btn.TabIndex = 16;
            sbmt_btn.Text = "Submit";
            sbmt_btn.UseVisualStyleBackColor = false;
            // 
            // cncl_btn
            // 
            cncl_btn.BackColor = SystemColors.ActiveCaption;
            cncl_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cncl_btn.ForeColor = SystemColors.Control;
            cncl_btn.Location = new Point(158, 336);
            cncl_btn.Name = "cncl_btn";
            cncl_btn.Size = new Size(94, 29);
            cncl_btn.TabIndex = 17;
            cncl_btn.Text = "Cancel";
            cncl_btn.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 451);
            Controls.Add(tabControl);
            Name = "Form2";
            Padding = new Padding(20);
            Text = "Form2";
            tabControl.ResumeLayout(false);
            bckp_rq_tbPg.ResumeLayout(false);
            bckp_rq_tbPg.PerformLayout();
            bckp_hstry_tbPg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button bckp_rq_lgout_btn;
        private TabControl tabControl;
        private TabPage bckp_rq_tbPg;
        private TabPage bckp_hstry_tbPg;
        private Label cmpnydb_lbl;
        private ComboBox cmpnydb_cmbBx;
        private Button bckp_hstry_lgout_btn;
        private Label rstr_rq_nm_lbl;
        private TextBox rstr_rq_nm_txtbx;
        private RadioButton lst_bckp_rdBtn;
        private RadioButton frsh_bckp_rdBtn;
        private Label bckp_src_lbl;
        private RadioButton othr_rdBtn;
        private DateTimePicker bckp_dt_pckr;
        private Button cncl_btn;
        private Button sbmt_btn;
    }
}