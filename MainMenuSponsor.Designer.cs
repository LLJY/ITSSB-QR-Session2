namespace Session2
{
    partial class MainMenuSponsor
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
            this.book_package = new System.Windows.Forms.Button();
            this.update_package = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sponsor Main Menu";
            // 
            // book_package
            // 
            this.book_package.Location = new System.Drawing.Point(156, 55);
            this.book_package.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.book_package.Name = "book_package";
            this.book_package.Size = new System.Drawing.Size(277, 76);
            this.book_package.TabIndex = 9;
            this.book_package.Text = "Book Sponsorship Package";
            this.book_package.UseVisualStyleBackColor = true;
            this.book_package.Click += new System.EventHandler(this.book_package_Click);
            // 
            // update_package
            // 
            this.update_package.Location = new System.Drawing.Point(156, 150);
            this.update_package.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update_package.Name = "update_package";
            this.update_package.Size = new System.Drawing.Size(277, 76);
            this.update_package.TabIndex = 10;
            this.update_package.Text = "Update Sponsorship";
            this.update_package.UseVisualStyleBackColor = true;
            this.update_package.Click += new System.EventHandler(this.Update_package_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(214, 257);
            this.back_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(158, 76);
            this.back_button.TabIndex = 14;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // MainMenuSponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.update_package);
            this.Controls.Add(this.book_package);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenuSponsor";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button book_package;
        private System.Windows.Forms.Button update_package;
        private System.Windows.Forms.Button back_button;
    }
}