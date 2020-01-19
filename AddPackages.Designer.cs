namespace Session2
{
    partial class AddPackages
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.done_button = new System.Windows.Forms.Button();
            this.tier_combo = new System.Windows.Forms.ComboBox();
            this.package_box = new System.Windows.Forms.TextBox();
            this.value_updown = new System.Windows.Forms.NumericUpDown();
            this.quantity_updown = new System.Windows.Forms.NumericUpDown();
            this.Online = new System.Windows.Forms.CheckBox();
            this.Flyers = new System.Windows.Forms.CheckBox();
            this.Banner = new System.Windows.Forms.CheckBox();
            this.back_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.file_box = new System.Windows.Forms.TextBox();
            this.upload_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.value_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_updown)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sponsor Main Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tier :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Package Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Value :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Available Quantity :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filter By Benefit :";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(160, 208);
            this.clear_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(104, 38);
            this.clear_button.TabIndex = 15;
            this.clear_button.Text = "Clear Form";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(268, 208);
            this.done_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(104, 38);
            this.done_button.TabIndex = 16;
            this.done_button.Text = "Add Package";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // tier_combo
            // 
            this.tier_combo.FormattingEnabled = true;
            this.tier_combo.Location = new System.Drawing.Point(260, 62);
            this.tier_combo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tier_combo.Name = "tier_combo";
            this.tier_combo.Size = new System.Drawing.Size(92, 21);
            this.tier_combo.TabIndex = 17;
            // 
            // package_box
            // 
            this.package_box.Location = new System.Drawing.Point(260, 91);
            this.package_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.package_box.Name = "package_box";
            this.package_box.Size = new System.Drawing.Size(92, 20);
            this.package_box.TabIndex = 18;
            // 
            // value_updown
            // 
            this.value_updown.Location = new System.Drawing.Point(260, 119);
            this.value_updown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.value_updown.Name = "value_updown";
            this.value_updown.Size = new System.Drawing.Size(90, 20);
            this.value_updown.TabIndex = 22;
            // 
            // quantity_updown
            // 
            this.quantity_updown.Location = new System.Drawing.Point(260, 153);
            this.quantity_updown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantity_updown.Name = "quantity_updown";
            this.quantity_updown.Size = new System.Drawing.Size(90, 20);
            this.quantity_updown.TabIndex = 23;
            // 
            // Online
            // 
            this.Online.AutoSize = true;
            this.Online.Location = new System.Drawing.Point(260, 181);
            this.Online.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(56, 17);
            this.Online.TabIndex = 24;
            this.Online.Text = "Online";
            this.Online.UseVisualStyleBackColor = true;
            // 
            // Flyers
            // 
            this.Flyers.AutoSize = true;
            this.Flyers.Location = new System.Drawing.Point(320, 180);
            this.Flyers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Flyers.Name = "Flyers";
            this.Flyers.Size = new System.Drawing.Size(53, 17);
            this.Flyers.TabIndex = 25;
            this.Flyers.Text = "Flyers";
            this.Flyers.UseVisualStyleBackColor = true;
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.Location = new System.Drawing.Point(377, 180);
            this.Banner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(60, 17);
            this.Banner.TabIndex = 26;
            this.Banner.Text = "Banner";
            this.Banner.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(9, 6);
            this.back_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 38);
            this.back_button.TabIndex = 27;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "File Path:";
            // 
            // file_box
            // 
            this.file_box.Location = new System.Drawing.Point(213, 306);
            this.file_box.Margin = new System.Windows.Forms.Padding(2);
            this.file_box.Name = "file_box";
            this.file_box.Size = new System.Drawing.Size(92, 20);
            this.file_box.TabIndex = 29;
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(309, 301);
            this.upload_button.Margin = new System.Windows.Forms.Padding(2);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(73, 28);
            this.upload_button.TabIndex = 30;
            this.upload_button.Text = "Upload";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // AddPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.upload_button);
            this.Controls.Add(this.file_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.Flyers);
            this.Controls.Add(this.Online);
            this.Controls.Add(this.quantity_updown);
            this.Controls.Add(this.value_updown);
            this.Controls.Add(this.package_box);
            this.Controls.Add(this.tier_combo);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddPackages";
            this.Text = "AddPackages";
            ((System.ComponentModel.ISupportInitialize)(this.value_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_updown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.ComboBox tier_combo;
        private System.Windows.Forms.TextBox package_box;
        private System.Windows.Forms.NumericUpDown value_updown;
        private System.Windows.Forms.NumericUpDown quantity_updown;
        private System.Windows.Forms.CheckBox Online;
        private System.Windows.Forms.CheckBox Flyers;
        private System.Windows.Forms.CheckBox Banner;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox file_box;
        private System.Windows.Forms.Button upload_button;
    }
}