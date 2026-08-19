namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            wlcm_lbl = new Label();
            user_txtbx = new TextBox();
            pw_txtbx = new TextBox();
            lgn_bttn = new Button();
            devops_rdbttn = new RadioButton();
            supprtdev_rdbttn = new RadioButton();
            slct_lbl = new Label();
            SuspendLayout();
            // 
            // wlcm_lbl
            // 
            wlcm_lbl.AutoSize = true;
            wlcm_lbl.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wlcm_lbl.Location = new Point(116, 44);
            wlcm_lbl.Margin = new Padding(15);
            wlcm_lbl.Name = "wlcm_lbl";
            wlcm_lbl.Padding = new Padding(15);
            wlcm_lbl.Size = new Size(188, 68);
            wlcm_lbl.TabIndex = 0;
            wlcm_lbl.Text = "WELCOME";
            wlcm_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // user_txtbx
            // 
            user_txtbx.BorderStyle = BorderStyle.None;
            user_txtbx.Cursor = Cursors.IBeam;
            user_txtbx.Location = new Point(23, 151);
            user_txtbx.Name = "user_txtbx";
            user_txtbx.PlaceholderText = "Username";
            user_txtbx.Size = new Size(367, 20);
            user_txtbx.TabIndex = 1;
            // 
            // pw_txtbx
            // 
            pw_txtbx.BorderStyle = BorderStyle.None;
            pw_txtbx.Cursor = Cursors.IBeam;
            pw_txtbx.Location = new Point(23, 222);
            pw_txtbx.Name = "pw_txtbx";
            pw_txtbx.PasswordChar = '*';
            pw_txtbx.PlaceholderText = "Password";
            pw_txtbx.Size = new Size(367, 20);
            pw_txtbx.TabIndex = 2;
            pw_txtbx.UseSystemPasswordChar = true;
            // 
            // lgn_bttn
            // 
            lgn_bttn.FlatAppearance.BorderSize = 0;
            lgn_bttn.Location = new Point(116, 396);
            lgn_bttn.Name = "lgn_bttn";
            lgn_bttn.Size = new Size(188, 30);
            lgn_bttn.TabIndex = 3;
            lgn_bttn.Text = "Login";
            lgn_bttn.UseVisualStyleBackColor = true;
            lgn_bttn.Click += lgn_bttn_Click;
            // 
            // devops_rdbttn
            // 
            devops_rdbttn.AutoSize = true;
            devops_rdbttn.Location = new Point(27, 327);
            devops_rdbttn.Name = "devops_rdbttn";
            devops_rdbttn.Size = new Size(82, 24);
            devops_rdbttn.TabIndex = 4;
            devops_rdbttn.TabStop = true;
            devops_rdbttn.Text = "DevOps";
            devops_rdbttn.UseVisualStyleBackColor = true;
            // 
            // supprtdev_rdbttn
            // 
            supprtdev_rdbttn.AutoSize = true;
            supprtdev_rdbttn.Location = new Point(275, 327);
            supprtdev_rdbttn.Name = "supprtdev_rdbttn";
            supprtdev_rdbttn.Size = new Size(115, 24);
            supprtdev_rdbttn.TabIndex = 5;
            supprtdev_rdbttn.TabStop = true;
            supprtdev_rdbttn.Text = "Support DEV";
            supprtdev_rdbttn.UseVisualStyleBackColor = true;
            // 
            // slct_lbl
            // 
            slct_lbl.AutoSize = true;
            slct_lbl.Location = new Point(23, 296);
            slct_lbl.Name = "slct_lbl";
            slct_lbl.Size = new Size(83, 20);
            slct_lbl.TabIndex = 6;
            slct_lbl.Text = "Select Role";
            slct_lbl.Click += Form1_Load;
            // 
            // Form1
            // 
            AcceptButton = lgn_bttn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 497);
            Controls.Add(slct_lbl);
            Controls.Add(supprtdev_rdbttn);
            Controls.Add(devops_rdbttn);
            Controls.Add(lgn_bttn);
            Controls.Add(pw_txtbx);
            Controls.Add(user_txtbx);
            Controls.Add(wlcm_lbl);
            Name = "Form1";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label wlcm_lbl;
        private TextBox user_txtbx;
        private TextBox pw_txtbx;
        private Button lgn_bttn;
        private RadioButton devops_rdbttn;
        private RadioButton supprtdev_rdbttn;
        private Label slct_lbl;
    }
}
