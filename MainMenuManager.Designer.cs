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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sponsor Manager Main Menu";
            // 
            // view_sponsor_packages
            // 
            this.view_sponsor_packages.Location = new System.Drawing.Point(113, 58);
            this.view_sponsor_packages.Name = "view_sponsor_packages";
            this.view_sponsor_packages.Size = new System.Drawing.Size(210, 94);
            this.view_sponsor_packages.TabIndex = 9;
            this.view_sponsor_packages.Text = "View Sponsorship Packages";
            this.view_sponsor_packages.UseVisualStyleBackColor = true;
            this.view_sponsor_packages.Click += new System.EventHandler(this.view_sponsor_Click);
            // 
            // add_sponsorship
            // 
            this.add_sponsorship.Location = new System.Drawing.Point(439, 58);
            this.add_sponsorship.Name = "add_sponsorship";
            this.add_sponsorship.Size = new System.Drawing.Size(210, 94);
            this.add_sponsorship.TabIndex = 10;
            this.add_sponsorship.Text = "Add Sponsorship Packages";
            this.add_sponsorship.UseVisualStyleBackColor = true;
            this.add_sponsorship.Click += new System.EventHandler(this.add_sponsorship_Click);
            // 
            // approve_sponsor
            // 
            this.approve_sponsor.Location = new System.Drawing.Point(113, 182);
            this.approve_sponsor.Name = "approve_sponsor";
            this.approve_sponsor.Size = new System.Drawing.Size(210, 94);
            this.approve_sponsor.TabIndex = 11;
            this.approve_sponsor.Text = "Approve Sponsorship Packages";
            this.approve_sponsor.UseVisualStyleBackColor = true;
            this.approve_sponsor.Click += new System.EventHandler(this.approve_sponsor_Click);
            // 
            // view_sponsor
            // 
            this.view_sponsor.Location = new System.Drawing.Point(439, 182);
            this.view_sponsor.Name = "view_sponsor";
            this.view_sponsor.Size = new System.Drawing.Size(210, 94);
            this.view_sponsor.TabIndex = 12;
            this.view_sponsor.Text = "View Sponsorship";
            this.view_sponsor.UseVisualStyleBackColor = true;
            this.view_sponsor.Click += new System.EventHandler(this.view_sponsor_Click_1);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(269, 332);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(210, 94);
            this.back_button.TabIndex = 13;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // MainMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.view_sponsor);
            this.Controls.Add(this.approve_sponsor);
            this.Controls.Add(this.add_sponsorship);
            this.Controls.Add(this.view_sponsor_packages);
            this.Controls.Add(this.label3);
            this.Name = "MainMenuManager";
            this.Text = "MainMenuManager";
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
    }
}