namespace eMedic
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
            this.ButtonOnePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NavBar = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TitleLBL = new System.Windows.Forms.Label();
            this.IconPBox = new System.Windows.Forms.PictureBox();
            this.ButtonOnePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.NavBar.SuspendLayout();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonOnePanel
            // 
            this.ButtonOnePanel.Controls.Add(this.pictureBox1);
            this.ButtonOnePanel.Controls.Add(this.button1);
            this.ButtonOnePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonOnePanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonOnePanel.Name = "ButtonOnePanel";
            this.ButtonOnePanel.Size = new System.Drawing.Size(161, 36);
            this.ButtonOnePanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(38, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sample";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.Transparent;
            this.NavBar.BackgroundImage = global::eMedic.Properties.Resources.navbar;
            this.NavBar.Controls.Add(this.ButtonOnePanel);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavBar.Location = new System.Drawing.Point(0, 39);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(161, 499);
            this.NavBar.TabIndex = 1;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.SpringGreen;
            this.TopBar.BackgroundImage = global::eMedic.Properties.Resources.topbar;
            this.TopBar.Controls.Add(this.CloseButton);
            this.TopBar.Controls.Add(this.TitleLBL);
            this.TopBar.Controls.Add(this.IconPBox);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(784, 39);
            this.TopBar.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.LightGray;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(749, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 39);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.BackColor = System.Drawing.Color.Transparent;
            this.TitleLBL.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLBL.ForeColor = System.Drawing.Color.Honeydew;
            this.TitleLBL.Location = new System.Drawing.Point(85, 5);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(120, 28);
            this.TitleLBL.TabIndex = 1;
            this.TitleLBL.Text = "eMedic BETA";
            // 
            // IconPBox
            // 
            this.IconPBox.BackColor = System.Drawing.Color.Transparent;
            this.IconPBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconPBox.Location = new System.Drawing.Point(0, 0);
            this.IconPBox.Name = "IconPBox";
            this.IconPBox.Size = new System.Drawing.Size(79, 39);
            this.IconPBox.TabIndex = 0;
            this.IconPBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 538);
            this.ControlBox = false;
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonOnePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.NavBar.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label TitleLBL;
        private System.Windows.Forms.PictureBox IconPBox;
        private System.Windows.Forms.Panel ButtonOnePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

