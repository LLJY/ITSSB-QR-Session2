namespace Session2
{
    partial class BookPackages
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tier_combo = new System.Windows.Forms.ComboBox();
            this.budget_updown = new System.Windows.Forms.NumericUpDown();
            this.Online = new System.Windows.Forms.CheckBox();
            this.Flyers = new System.Windows.Forms.CheckBox();
            this.Banner = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.desired_updown = new System.Windows.Forms.NumericUpDown();
            this.book_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desired_updown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By Benefit :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 297);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By Budget :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter By Tier :";
            // 
            // tier_combo
            // 
            this.tier_combo.FormattingEnabled = true;
            this.tier_combo.Location = new System.Drawing.Point(134, 6);
            this.tier_combo.Name = "tier_combo";
            this.tier_combo.Size = new System.Drawing.Size(121, 24);
            this.tier_combo.TabIndex = 4;
            this.tier_combo.SelectedIndexChanged += new System.EventHandler(this.tier_combo_SelectedIndexChanged);
            // 
            // budget_updown
            // 
            this.budget_updown.Location = new System.Drawing.Point(135, 44);
            this.budget_updown.Name = "budget_updown";
            this.budget_updown.Size = new System.Drawing.Size(120, 22);
            this.budget_updown.TabIndex = 5;
            this.budget_updown.ValueChanged += new System.EventHandler(this.budget_updown_ValueChanged);
            // 
            // Online
            // 
            this.Online.AutoSize = true;
            this.Online.Location = new System.Drawing.Point(134, 72);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(71, 21);
            this.Online.TabIndex = 6;
            this.Online.Text = "Online";
            this.Online.UseVisualStyleBackColor = true;
            this.Online.CheckedChanged += new System.EventHandler(this.Online_CheckedChanged);
            // 
            // Flyers
            // 
            this.Flyers.AutoSize = true;
            this.Flyers.Location = new System.Drawing.Point(238, 72);
            this.Flyers.Name = "Flyers";
            this.Flyers.Size = new System.Drawing.Size(68, 21);
            this.Flyers.TabIndex = 7;
            this.Flyers.Text = "Flyers";
            this.Flyers.UseVisualStyleBackColor = true;
            this.Flyers.CheckedChanged += new System.EventHandler(this.Flyers_CheckedChanged);
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.Location = new System.Drawing.Point(342, 71);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(83, 21);
            this.Banner.TabIndex = 8;
            this.Banner.Text = "Banners";
            this.Banner.UseVisualStyleBackColor = true;
            this.Banner.CheckedChanged += new System.EventHandler(this.Banner_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desired Quantity :";
            // 
            // desired_updown
            // 
            this.desired_updown.Location = new System.Drawing.Point(159, 416);
            this.desired_updown.Name = "desired_updown";
            this.desired_updown.Size = new System.Drawing.Size(120, 22);
            this.desired_updown.TabIndex = 10;
            // 
            // book_button
            // 
            this.book_button.Location = new System.Drawing.Point(680, 402);
            this.book_button.Name = "book_button";
            this.book_button.Size = new System.Drawing.Size(108, 43);
            this.book_button.TabIndex = 11;
            this.book_button.Text = "Book";
            this.book_button.UseVisualStyleBackColor = true;
            this.book_button.Click += new System.EventHandler(this.book_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.book_button);
            this.Controls.Add(this.desired_updown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.Flyers);
            this.Controls.Add(this.Online);
            this.Controls.Add(this.budget_updown);
            this.Controls.Add(this.tier_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "BookPackages";
            this.Text = "BookPackages";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desired_updown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tier_combo;
        private System.Windows.Forms.NumericUpDown budget_updown;
        private System.Windows.Forms.CheckBox Online;
        private System.Windows.Forms.CheckBox Flyers;
        private System.Windows.Forms.CheckBox Banner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown desired_updown;
        private System.Windows.Forms.Button book_button;
        private System.Windows.Forms.Button button1;
    }
}