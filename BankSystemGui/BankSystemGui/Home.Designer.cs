namespace BankSystemGui
{
    partial class Home
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
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnOthers = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(787, 428);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(10, 20);
            this.dtPicker.TabIndex = 5;
            this.dtPicker.Visible = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnOthers);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Black;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(139, 450);
            this.panelMenu.TabIndex = 6;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(139, 360);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(661, 90);
            this.bottomPanel.TabIndex = 7;
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(139, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(661, 84);
            this.topPanel.TabIndex = 8;
            // 
            // middlePanel
            // 
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(139, 84);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(661, 276);
            this.middlePanel.TabIndex = 9;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.Location = new System.Drawing.Point(0, 84);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(139, 86);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnOthers
            // 
            this.btnOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.IconChar = FontAwesome.Sharp.IconChar.GaugeHigh;
            this.btnOthers.IconColor = System.Drawing.Color.White;
            this.btnOthers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOthers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOthers.Location = new System.Drawing.Point(0, 169);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(139, 76);
            this.btnOthers.TabIndex = 9;
            this.btnOthers.Text = "Credit";
            this.btnOthers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOthers.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(0, 244);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(139, 70);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbout.Location = new System.Drawing.Point(0, 313);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(139, 74);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(139, 84);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Profile";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 42;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(0, 386);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(139, 62);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dtPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Panel topPanel;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnOthers;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnLogout;
    }
}