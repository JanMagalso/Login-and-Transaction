namespace Login_Form_and_Transactions
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupbox1.BackColor = System.Drawing.Color.Transparent;
            this.groupbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupbox1.BackgroundImage")));
            this.groupbox1.Controls.Add(this.panel1);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.usernameTxt);
            this.groupbox1.Controls.Add(this.button1);
            this.groupbox1.Controls.Add(this.button2);
            this.groupbox1.Controls.Add(this.passwordLogin);
            this.groupbox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupbox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupbox1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupbox1.Location = new System.Drawing.Point(198, 205);
            this.groupbox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox1.Size = new System.Drawing.Size(535, 346);
            this.groupbox1.TabIndex = 10;
            this.groupbox1.TabStop = false;
            this.groupbox1.Enter += new System.EventHandler(this.groupbox1_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(63, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 1);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login to your account";
            // 
            // usernameTxt
            // 
            this.usernameTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameTxt.FormattingEnabled = true;
            this.usernameTxt.Items.AddRange(new object[] {
            "pabugnawan",
            "chicos"});
            this.usernameTxt.Location = new System.Drawing.Point(184, 116);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(164, 30);
            this.usernameTxt.TabIndex = 7;
            this.usernameTxt.Text = "Username";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(260, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(356, 251);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // passwordLogin
            // 
            this.passwordLogin.BackColor = System.Drawing.Color.White;
            this.passwordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordLogin.Location = new System.Drawing.Point(184, 180);
            this.passwordLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.Size = new System.Drawing.Size(164, 21);
            this.passwordLogin.TabIndex = 3;
            this.passwordLogin.Text = "Password";
            this.passwordLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordLogin_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(942, 704);
            this.Controls.Add(this.groupbox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox passwordLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox usernameTxt;
    }
}

