namespace BankSystemGui
{
    partial class Profile
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
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnOthers = new FontAwesome.Sharp.IconButton();
            this.profileButton = new FontAwesome.Sharp.IconButton();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
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
            this.panelMenu.Controls.Add(this.profileButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Black;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(139, 472);
            this.panelMenu.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(0, 390);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(139, 81);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbout.Location = new System.Drawing.Point(0, 313);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(139, 80);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.Location = new System.Drawing.Point(0, 84);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(139, 79);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(0, 235);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(139, 81);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnOthers
            // 
            this.btnOthers.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOthers.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.ForeColor = System.Drawing.Color.White;
            this.btnOthers.IconChar = FontAwesome.Sharp.IconChar.GaugeHigh;
            this.btnOthers.IconColor = System.Drawing.Color.White;
            this.btnOthers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOthers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOthers.Location = new System.Drawing.Point(0, 162);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(139, 76);
            this.btnOthers.TabIndex = 9;
            this.btnOthers.Text = "Credit";
            this.btnOthers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOthers.UseVisualStyleBackColor = false;
            this.btnOthers.Click += new System.EventHandler(this.btnOthers_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.profileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.profileButton.IconColor = System.Drawing.Color.White;
            this.profileButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.profileButton.Location = new System.Drawing.Point(0, 0);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(139, 84);
            this.profileButton.TabIndex = 0;
            this.profileButton.Text = "Profile";
            this.profileButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.topPanel.Controls.Add(this.btnExit);
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.Color.White;
            this.topPanel.Location = new System.Drawing.Point(139, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(551, 84);
            this.topPanel.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(488, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 51);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(131, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "QA BANKING";
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.middlePanel.Controls.Add(this.lblCity);
            this.middlePanel.Controls.Add(this.lblState);
            this.middlePanel.Controls.Add(this.lblEmail);
            this.middlePanel.Controls.Add(this.lblPassword);
            this.middlePanel.Controls.Add(this.lblUserName);
            this.middlePanel.Controls.Add(this.btnEdit);
            this.middlePanel.Controls.Add(this.lblName);
            this.middlePanel.Controls.Add(this.label3);
            this.middlePanel.ForeColor = System.Drawing.Color.SlateGray;
            this.middlePanel.Location = new System.Drawing.Point(139, 84);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(551, 388);
            this.middlePanel.TabIndex = 9;
            this.middlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.middlePanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(194, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "My Profile";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(46, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 18);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(182, 284);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 38);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(45, 78);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 18);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(45, 102);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 18);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(45, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(45, 161);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(50, 18);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(45, 188);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 18);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City:";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 472);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dtPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelMenu.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Panel topPanel;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnOthers;
        private FontAwesome.Sharp.IconButton profileButton;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
    }
}