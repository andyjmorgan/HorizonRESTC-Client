namespace ExampleDashboard
{
    partial class frmLogon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogon));
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teConnectionServer = new System.Windows.Forms.TextBox();
            this.teUserName = new System.Windows.Forms.TextBox();
            this.tePassword = new System.Windows.Forms.TextBox();
            this.teDomain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(224, 116);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Submit";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // teConnectionServer
            // 
            this.teConnectionServer.Location = new System.Drawing.Point(92, 12);
            this.teConnectionServer.Name = "teConnectionServer";
            this.teConnectionServer.Size = new System.Drawing.Size(207, 20);
            this.teConnectionServer.TabIndex = 4;
            this.teConnectionServer.Text = "https://example.domain.local/rest";
            // 
            // teUserName
            // 
            this.teUserName.Location = new System.Drawing.Point(92, 38);
            this.teUserName.Name = "teUserName";
            this.teUserName.Size = new System.Drawing.Size(207, 20);
            this.teUserName.TabIndex = 5;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(92, 64);
            this.tePassword.Name = "tePassword";
            this.tePassword.Size = new System.Drawing.Size(207, 20);
            this.tePassword.TabIndex = 6;
            this.tePassword.UseSystemPasswordChar = true;
            // 
            // teDomain
            // 
            this.teDomain.Location = new System.Drawing.Point(92, 90);
            this.teDomain.Name = "teDomain";
            this.teDomain.Size = new System.Drawing.Size(207, 20);
            this.teDomain.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Domain:";
            // 
            // frmLogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 148);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teDomain);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.teUserName);
            this.Controls.Add(this.teConnectionServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horizon Dashboard Example";
            this.Load += new System.EventHandler(this.frmLogon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teConnectionServer;
        private System.Windows.Forms.TextBox teUserName;
        private System.Windows.Forms.TextBox tePassword;
        private System.Windows.Forms.TextBox teDomain;
        private System.Windows.Forms.Label label4;
    }
}