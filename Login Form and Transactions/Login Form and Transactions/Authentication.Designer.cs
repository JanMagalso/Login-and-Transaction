namespace Login_Form_and_Transactions
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Green;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Yellow;
            this.searchBtn.Location = new System.Drawing.Point(553, 332);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(97, 38);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchID
            // 
            this.searchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchID.Location = new System.Drawing.Point(263, 336);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(272, 30);
            this.searchID.TabIndex = 1;
            this.searchID.TextChanged += new System.EventHandler(this.searchID_TextChanged);
            this.searchID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchID_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(191, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please tap your ID";
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 705);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.searchBtn);
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchID;
        private System.Windows.Forms.Label label1;
    }
}