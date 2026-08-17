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
            button1 = new Button();
            textBox1 = new TextBox();
            txtUsername = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 93);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 27);
            textBox1.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Location = new Point(12, 36);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(90, 20);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "Enter Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 149);
            Controls.Add(txtUsername);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label txtUsername;
    }
}
