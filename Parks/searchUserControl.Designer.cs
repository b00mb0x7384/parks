namespace Parks
{
    partial class searchUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchUserControl));
            this.recCheckYes = new System.Windows.Forms.CheckBox();
            this.planCheckYes = new System.Windows.Forms.CheckBox();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.recordLabel = new System.Windows.Forms.Label();
            this.planLabel = new System.Windows.Forms.Label();
            this.mainDisplayLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recCheckYes
            // 
            this.recCheckYes.AutoSize = true;
            this.recCheckYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recCheckYes.Location = new System.Drawing.Point(490, 196);
            this.recCheckYes.Margin = new System.Windows.Forms.Padding(2);
            this.recCheckYes.Name = "recCheckYes";
            this.recCheckYes.Size = new System.Drawing.Size(15, 14);
            this.recCheckYes.TabIndex = 30;
            this.recCheckYes.ThreeState = true;
            this.recCheckYes.UseVisualStyleBackColor = true;
            this.recCheckYes.CheckedChanged += new System.EventHandler(this.recCheckYes_CheckedChanged);
            // 
            // planCheckYes
            // 
            this.planCheckYes.AutoSize = true;
            this.planCheckYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planCheckYes.Location = new System.Drawing.Point(490, 123);
            this.planCheckYes.Margin = new System.Windows.Forms.Padding(2);
            this.planCheckYes.Name = "planCheckYes";
            this.planCheckYes.Size = new System.Drawing.Size(15, 14);
            this.planCheckYes.TabIndex = 28;
            this.planCheckYes.ThreeState = true;
            this.planCheckYes.UseVisualStyleBackColor = true;
            this.planCheckYes.CheckedChanged += new System.EventHandler(this.planCheckYes_CheckedChanged);
            // 
            // addTextBox
            // 
            this.addTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTextBox.Location = new System.Drawing.Point(32, 187);
            this.addTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(138, 26);
            this.addTextBox.TabIndex = 25;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(31, 114);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(138, 26);
            this.nameTextBox.TabIndex = 24;
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordLabel.Location = new System.Drawing.Point(343, 166);
            this.recordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(191, 20);
            this.recordLabel.TabIndex = 23;
            this.recordLabel.Text = "Have recorded a Visit?";
            // 
            // planLabel
            // 
            this.planLabel.AutoSize = true;
            this.planLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planLabel.Location = new System.Drawing.Point(343, 94);
            this.planLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.planLabel.Name = "planLabel";
            this.planLabel.Size = new System.Drawing.Size(190, 20);
            this.planLabel.TabIndex = 22;
            this.planLabel.Text = "Have planned to Visit?";
            // 
            // mainDisplayLabel
            // 
            this.mainDisplayLabel.AutoSize = true;
            this.mainDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDisplayLabel.Location = new System.Drawing.Point(28, 19);
            this.mainDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainDisplayLabel.Name = "mainDisplayLabel";
            this.mainDisplayLabel.Size = new System.Drawing.Size(170, 24);
            this.mainDisplayLabel.TabIndex = 21;
            this.mainDisplayLabel.Text = "Search for a Park";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(29, 94);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(29, 166);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(75, 20);
            this.addressLabel.TabIndex = 19;
            this.addressLabel.Text = "Address";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(113)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchButton.Location = new System.Drawing.Point(346, 265);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(119, 36);
            this.searchButton.TabIndex = 32;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // searchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.recCheckYes);
            this.Controls.Add(this.planCheckYes);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.planLabel);
            this.Controls.Add(this.mainDisplayLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addressLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "searchUserControl";
            this.Size = new System.Drawing.Size(807, 377);
            this.Load += new System.EventHandler(this.searchUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Label planLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button searchButton;
        public System.Windows.Forms.CheckBox recCheckYes;
        public System.Windows.Forms.CheckBox planCheckYes;
        public System.Windows.Forms.TextBox addTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.Label mainDisplayLabel;
    }
}
