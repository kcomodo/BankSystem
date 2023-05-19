namespace BankSystemGui
{
    partial class CreateAccount1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount1));
            this.btnProceed = new System.Windows.Forms.Button();
            this.txtFirstNameCreate = new System.Windows.Forms.TextBox();
            this.txtLastNameCreate = new System.Windows.Forms.TextBox();
            this.txtUserCreate = new System.Windows.Forms.TextBox();
            this.txtPassCreate = new System.Windows.Forms.TextBox();
            this.txtEmailCreate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumberCreate = new System.Windows.Forms.TextBox();
            this.dateEdit = new System.Windows.Forms.DateTimePicker();
            this.checkEmail = new System.Windows.Forms.Label();
            this.checkPassword = new System.Windows.Forms.Label();
            this.checkUsername = new System.Windows.Forms.Label();
            this.checkPhoneNumber = new System.Windows.Forms.Label();
            this.exitBtn2 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.SlateGray;
            this.btnProceed.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProceed.Location = new System.Drawing.Point(123, 273);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(198, 42);
            this.btnProceed.TabIndex = 11;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // txtFirstNameCreate
            // 
            this.txtFirstNameCreate.Location = new System.Drawing.Point(125, 61);
            this.txtFirstNameCreate.Name = "txtFirstNameCreate";
            this.txtFirstNameCreate.Size = new System.Drawing.Size(196, 20);
            this.txtFirstNameCreate.TabIndex = 12;
            this.txtFirstNameCreate.TextChanged += new System.EventHandler(this.txtFirstNameCreate_TextChanged);
            // 
            // txtLastNameCreate
            // 
            this.txtLastNameCreate.Location = new System.Drawing.Point(125, 90);
            this.txtLastNameCreate.Name = "txtLastNameCreate";
            this.txtLastNameCreate.Size = new System.Drawing.Size(196, 20);
            this.txtLastNameCreate.TabIndex = 13;
            // 
            // txtUserCreate
            // 
            this.txtUserCreate.Location = new System.Drawing.Point(125, 116);
            this.txtUserCreate.Name = "txtUserCreate";
            this.txtUserCreate.Size = new System.Drawing.Size(196, 20);
            this.txtUserCreate.TabIndex = 14;
            // 
            // txtPassCreate
            // 
            this.txtPassCreate.Location = new System.Drawing.Point(125, 144);
            this.txtPassCreate.Name = "txtPassCreate";
            this.txtPassCreate.Size = new System.Drawing.Size(196, 20);
            this.txtPassCreate.TabIndex = 15;
            this.txtPassCreate.TextChanged += new System.EventHandler(this.txtPassCreate_TextChanged);
            // 
            // txtEmailCreate
            // 
            this.txtEmailCreate.Location = new System.Drawing.Point(125, 170);
            this.txtEmailCreate.Name = "txtEmailCreate";
            this.txtEmailCreate.Size = new System.Drawing.Size(196, 20);
            this.txtEmailCreate.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SlateGray;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date of birth:";
            // 
            // txtPhoneNumberCreate
            // 
            this.txtPhoneNumberCreate.Location = new System.Drawing.Point(125, 199);
            this.txtPhoneNumberCreate.Name = "txtPhoneNumberCreate";
            this.txtPhoneNumberCreate.Size = new System.Drawing.Size(196, 20);
            this.txtPhoneNumberCreate.TabIndex = 21;
            // 
            // dateEdit
            // 
            this.dateEdit.Checked = false;
            this.dateEdit.Location = new System.Drawing.Point(125, 225);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Size = new System.Drawing.Size(196, 20);
            this.dateEdit.TabIndex = 23;
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.checkEmail.Location = new System.Drawing.Point(223, 123);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(0, 13);
            this.checkEmail.TabIndex = 32;
            // 
            // checkPassword
            // 
            this.checkPassword.AutoSize = true;
            this.checkPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.checkPassword.Location = new System.Drawing.Point(223, 90);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.Size = new System.Drawing.Size(0, 13);
            this.checkPassword.TabIndex = 33;
            // 
            // checkUsername
            // 
            this.checkUsername.AutoSize = true;
            this.checkUsername.ForeColor = System.Drawing.Color.Firebrick;
            this.checkUsername.Location = new System.Drawing.Point(223, 64);
            this.checkUsername.Name = "checkUsername";
            this.checkUsername.Size = new System.Drawing.Size(0, 13);
            this.checkUsername.TabIndex = 34;
            // 
            // checkPhoneNumber
            // 
            this.checkPhoneNumber.AutoSize = true;
            this.checkPhoneNumber.ForeColor = System.Drawing.Color.Firebrick;
            this.checkPhoneNumber.Location = new System.Drawing.Point(226, 173);
            this.checkPhoneNumber.Name = "checkPhoneNumber";
            this.checkPhoneNumber.Size = new System.Drawing.Size(0, 13);
            this.checkPhoneNumber.TabIndex = 35;
            // 
            // exitBtn2
            // 
            this.exitBtn2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.exitBtn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn2.BackgroundImage")));
            this.exitBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn2.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.exitBtn2.IconColor = System.Drawing.Color.Black;
            this.exitBtn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn2.Location = new System.Drawing.Point(422, 0);
            this.exitBtn2.Name = "exitBtn2";
            this.exitBtn2.Size = new System.Drawing.Size(43, 36);
            this.exitBtn2.TabIndex = 36;
            this.exitBtn2.UseVisualStyleBackColor = false;
            this.exitBtn2.Click += new System.EventHandler(this.exitBtn2_Click);
            // 
            // CreateAccount1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 433);
            this.Controls.Add(this.exitBtn2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkPhoneNumber);
            this.Controls.Add(this.checkUsername);
            this.Controls.Add(this.checkPassword);
            this.Controls.Add(this.checkEmail);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.txtPhoneNumberCreate);
            this.Controls.Add(this.txtEmailCreate);
            this.Controls.Add(this.txtPassCreate);
            this.Controls.Add(this.txtUserCreate);
            this.Controls.Add(this.txtLastNameCreate);
            this.Controls.Add(this.txtFirstNameCreate);
            this.Controls.Add(this.btnProceed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CreateAccount1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox txtFirstNameCreate;
        private System.Windows.Forms.TextBox txtLastNameCreate;
        private System.Windows.Forms.TextBox txtUserCreate;
        private System.Windows.Forms.TextBox txtPassCreate;
        private System.Windows.Forms.TextBox txtEmailCreate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNumberCreate;
        private System.Windows.Forms.DateTimePicker dateEdit;
        private System.Windows.Forms.Label checkEmail;
        private System.Windows.Forms.Label checkPassword;
        private System.Windows.Forms.Label checkUsername;
        private System.Windows.Forms.Label checkPhoneNumber;
        private FontAwesome.Sharp.IconButton exitBtn2;
    }
}