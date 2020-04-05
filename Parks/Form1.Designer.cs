namespace Parks
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftNavigationPanel = new System.Windows.Forms.Panel();
            this.navShowCurrent = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.planButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.viewLabel = new System.Windows.Forms.Label();
            this.mainDataLabel = new System.Windows.Forms.Label();
            this.mainDataGrid = new System.Windows.Forms.DataGridView();
            this.mainViewPanel = new System.Windows.Forms.Panel();
            this.leftNavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // leftNavigationPanel
            // 
            this.leftNavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(113)))));
            this.leftNavigationPanel.Controls.Add(this.navShowCurrent);
            this.leftNavigationPanel.Controls.Add(this.homeButton);
            this.leftNavigationPanel.Controls.Add(this.logoPicBox);
            this.leftNavigationPanel.Controls.Add(this.exitButton);
            this.leftNavigationPanel.Controls.Add(this.recordButton);
            this.leftNavigationPanel.Controls.Add(this.planButton);
            this.leftNavigationPanel.Controls.Add(this.editButton);
            this.leftNavigationPanel.Controls.Add(this.searchButton);
            this.leftNavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.leftNavigationPanel.Name = "leftNavigationPanel";
            this.leftNavigationPanel.Size = new System.Drawing.Size(267, 928);
            this.leftNavigationPanel.TabIndex = 0;
            // 
            // navShowCurrent
            // 
            this.navShowCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.navShowCurrent.Location = new System.Drawing.Point(0, 199);
            this.navShowCurrent.Name = "navShowCurrent";
            this.navShowCurrent.Size = new System.Drawing.Size(18, 90);
            this.navShowCurrent.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(24, 199);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(224, 90);
            this.homeButton.TabIndex = 9;
            this.homeButton.Text = "  Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // logoPicBox
            // 
            this.logoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPicBox.Image")));
            this.logoPicBox.Location = new System.Drawing.Point(3, 3);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(264, 179);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicBox.TabIndex = 8;
            this.logoPicBox.TabStop = false;
            this.logoPicBox.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(24, 826);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(224, 90);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "  Exit";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // recordButton
            // 
            this.recordButton.FlatAppearance.BorderSize = 0;
            this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recordButton.Image = ((System.Drawing.Image)(resources.GetObject("recordButton.Image")));
            this.recordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordButton.Location = new System.Drawing.Point(24, 583);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(224, 90);
            this.recordButton.TabIndex = 5;
            this.recordButton.Text = "  Record A Visit";
            this.recordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // planButton
            // 
            this.planButton.FlatAppearance.BorderSize = 0;
            this.planButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.planButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.planButton.Image = ((System.Drawing.Image)(resources.GetObject("planButton.Image")));
            this.planButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.planButton.Location = new System.Drawing.Point(24, 487);
            this.planButton.Name = "planButton";
            this.planButton.Size = new System.Drawing.Size(224, 90);
            this.planButton.TabIndex = 4;
            this.planButton.Text = "  Plan A Visit";
            this.planButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.planButton.UseVisualStyleBackColor = true;
            this.planButton.Click += new System.EventHandler(this.planButton_Click);
            // 
            // editButton
            // 
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.Location = new System.Drawing.Point(24, 391);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(224, 90);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "  Edit Parks";
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(24, 295);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(224, 90);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "  Find A Park";
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(113)))));
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewButton.Location = new System.Drawing.Point(1305, 862);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(101, 47);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLabel.Location = new System.Drawing.Point(309, 862);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(653, 30);
            this.viewLabel.TabIndex = 2;
            this.viewLabel.Text = "Select a park and press view to see more information.";
            // 
            // mainDataLabel
            // 
            this.mainDataLabel.AutoSize = true;
            this.mainDataLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDataLabel.Location = new System.Drawing.Point(309, 583);
            this.mainDataLabel.Name = "mainDataLabel";
            this.mainDataLabel.Size = new System.Drawing.Size(175, 28);
            this.mainDataLabel.TabIndex = 1;
            this.mainDataLabel.Text = "All State Parks";
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.mainDataGrid.Location = new System.Drawing.Point(314, 624);
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.RowTemplate.Height = 28;
            this.mainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDataGrid.Size = new System.Drawing.Size(1092, 222);
            this.mainDataGrid.TabIndex = 0;
            // 
            // mainViewPanel
            // 
            this.mainViewPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainViewPanel.BackgroundImage")));
            this.mainViewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainViewPanel.Location = new System.Drawing.Point(267, 0);
            this.mainViewPanel.Name = "mainViewPanel";
            this.mainViewPanel.Size = new System.Drawing.Size(1211, 580);
            this.mainViewPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1478, 928);
            this.Controls.Add(this.mainViewPanel);
            this.Controls.Add(this.leftNavigationPanel);
            this.Controls.Add(this.mainDataLabel);
            this.Controls.Add(this.mainDataGrid);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.viewButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Parks";
            this.leftNavigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftNavigationPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button planButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel navShowCurrent;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label mainDataLabel;
        private System.Windows.Forms.DataGridView mainDataGrid;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.Panel mainViewPanel;
    }
}

