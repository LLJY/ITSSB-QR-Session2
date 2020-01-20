namespace Session2
{
    partial class MainMenuManager
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
            this.label3 = new System.Windows.Forms.Label();
            this.view_sponsor_packages = new System.Windows.Forms.Button();
            this.add_sponsorship = new System.Windows.Forms.Button();
            this.approve_sponsor = new System.Windows.Forms.Button();
            this.view_sponsor = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(438, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sponsor Manager Main Menu";
            // 
            // view_sponsor_packages
            // 
            this.view_sponsor_packages.Location = new System.Drawing.Point(182, 121);
            this.view_sponsor_packages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.view_sponsor_packages.Name = "view_sponsor_packages";
            this.view_sponsor_packages.Size = new System.Drawing.Size(158, 76);
            this.view_sponsor_packages.TabIndex = 9;
            this.view_sponsor_packages.Text = "View Sponsorship Packages";
            this.view_sponsor_packages.UseVisualStyleBackColor = true;
            this.view_sponsor_packages.Click += new System.EventHandler(this.view_sponsor_Click);
            // 
            // add_sponsorship
            // 
            this.add_sponsorship.Location = new System.Drawing.Point(426, 121);
            this.add_sponsorship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_sponsorship.Name = "add_sponsorship";
            this.add_sponsorship.Size = new System.Drawing.Size(158, 76);
            this.add_sponsorship.TabIndex = 10;
            this.add_sponsorship.Text = "Add Sponsorship Packages";
            this.add_sponsorship.UseVisualStyleBackColor = true;
            this.add_sponsorship.Click += new System.EventHandler(this.add_sponsorship_Click);
            // 
            // approve_sponsor
            // 
            this.approve_sponsor.Location = new System.Drawing.Point(182, 222);
            this.approve_sponsor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.approve_sponsor.Name = "approve_sponsor";
            this.approve_sponsor.Size = new System.Drawing.Size(158, 76);
            this.approve_sponsor.TabIndex = 11;
            this.approve_sponsor.Text = "Approve Sponsorship Packages";
            this.approve_sponsor.UseVisualStyleBackColor = true;
            this.approve_sponsor.Click += new System.EventHandler(this.approve_sponsor_Click);
            // 
            // view_sponsor
            // 
            this.view_sponsor.Location = new System.Drawing.Point(426, 222);
            this.view_sponsor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.view_sponsor.Name = "view_sponsor";
            this.view_sponsor.Size = new System.Drawing.Size(158, 76);
            this.view_sponsor.TabIndex = 12;
            this.view_sponsor.Text = "View Sponsorship";
            this.view_sponsor.UseVisualStyleBackColor = true;
            this.view_sponsor.Click += new System.EventHandler(this.view_sponsor_Click_1);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(8, 9);
            this.back_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(82, 37);
            this.back_button.TabIndex = 13;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 48);
            this.panel1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(570, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "ASEAN Skills 2020";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(3, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 48);
            this.panel2.TabIndex = 23;
            // 
            // MainMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.view_sponsor);
            this.Controls.Add(this.approve_sponsor);
            this.Controls.Add(this.add_sponsorship);
            this.Controls.Add(this.view_sponsor_packages);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenuManager";
            this.Text = "MainMenuManager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button view_sponsor_packages;
        private System.Windows.Forms.Button add_sponsorship;
        private System.Windows.Forms.Button approve_sponsor;
        private System.Windows.Forms.Button view_sponsor;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}