namespace EmployeeSystemLT
{
    partial class LoginSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSignUp));
            LoginButton = new PictureBox();
            SignUpButton = new PictureBox();
            pictureBox3 = new PictureBox();
            address = new TextBox();
            password = new TextBox();
            username = new TextBox();
            loginpassword = new TextBox();
            loginuser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ChangePWButton = new PictureBox();
            AdminButton = new PictureBox();
            ChangePWuserTbox = new TextBox();
            ChangePWUserLabel = new Label();
            ChangePWoldpasslabel = new Label();
            ChangePWoldpassTbox = new TextBox();
            ChangePWnewpassTbox = new TextBox();
            ChangePWnewpasslabel = new Label();
            ChangePWApply = new PictureBox();
            AdminPasswordTbox = new TextBox();
            AdminPasswordLabel = new Label();
            AdminPanel = new Panel();
            LabelDelete = new Label();
            DeleteTbox = new RichTextBox();
            DeleteButton = new PictureBox();
            dataGridView1 = new DataGridView();
            ReturnAdmin = new PictureBox();
            PhoneNumberTbox = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)LoginButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SignUpButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangePWButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangePWApply).BeginInit();
            AdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReturnAdmin).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackgroundImage = (Image)resources.GetObject("LoginButton.BackgroundImage");
            LoginButton.BackgroundImageLayout = ImageLayout.Stretch;
            LoginButton.Location = new Point(535, 368);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(201, 79);
            LoginButton.TabIndex = 0;
            LoginButton.TabStop = false;
            LoginButton.Click += Login_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.BackgroundImage = (Image)resources.GetObject("SignUpButton.BackgroundImage");
            SignUpButton.BackgroundImageLayout = ImageLayout.Stretch;
            SignUpButton.Location = new Point(124, 368);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(214, 79);
            SignUpButton.TabIndex = 1;
            SignUpButton.TabStop = false;
            SignUpButton.Click += SignUp_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(377, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(138, 119);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // address
            // 
            address.Location = new Point(149, 237);
            address.Multiline = true;
            address.Name = "address";
            address.Size = new Size(161, 26);
            address.TabIndex = 3;
            // 
            // password
            // 
            password.Location = new Point(149, 334);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(161, 26);
            password.TabIndex = 5;
            // 
            // username
            // 
            username.Location = new Point(149, 284);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(161, 28);
            username.TabIndex = 4;
            // 
            // loginpassword
            // 
            loginpassword.Location = new Point(553, 334);
            loginpassword.Multiline = true;
            loginpassword.Name = "loginpassword";
            loginpassword.PasswordChar = '*';
            loginpassword.Size = new Size(161, 28);
            loginpassword.TabIndex = 7;
            // 
            // loginuser
            // 
            loginuser.Location = new Point(553, 284);
            loginuser.Multiline = true;
            loginuser.Name = "loginuser";
            loginuser.Size = new Size(161, 28);
            loginuser.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 266);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 8;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 219);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 9;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 316);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(603, 266);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 11;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(606, 316);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "Password";
            // 
            // ChangePWButton
            // 
            ChangePWButton.BackgroundImage = (Image)resources.GetObject("ChangePWButton.BackgroundImage");
            ChangePWButton.BackgroundImageLayout = ImageLayout.Stretch;
            ChangePWButton.Location = new Point(12, 12);
            ChangePWButton.Name = "ChangePWButton";
            ChangePWButton.Size = new Size(158, 31);
            ChangePWButton.TabIndex = 13;
            ChangePWButton.TabStop = false;
            ChangePWButton.Click += ChangePWButton_Click;
            // 
            // AdminButton
            // 
            AdminButton.BackgroundImage = (Image)resources.GetObject("AdminButton.BackgroundImage");
            AdminButton.BackgroundImageLayout = ImageLayout.Stretch;
            AdminButton.Location = new Point(757, 12);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(79, 31);
            AdminButton.TabIndex = 14;
            AdminButton.TabStop = false;
            AdminButton.Click += AdminButton_Click;
            // 
            // ChangePWuserTbox
            // 
            ChangePWuserTbox.Location = new Point(9, 61);
            ChangePWuserTbox.Multiline = true;
            ChangePWuserTbox.Name = "ChangePWuserTbox";
            ChangePWuserTbox.Size = new Size(161, 26);
            ChangePWuserTbox.TabIndex = 15;
            ChangePWuserTbox.Visible = false;
            // 
            // ChangePWUserLabel
            // 
            ChangePWUserLabel.AutoSize = true;
            ChangePWUserLabel.Location = new Point(64, 46);
            ChangePWUserLabel.Name = "ChangePWUserLabel";
            ChangePWUserLabel.Size = new Size(60, 15);
            ChangePWUserLabel.TabIndex = 16;
            ChangePWUserLabel.Text = "Username";
            ChangePWUserLabel.Visible = false;
            // 
            // ChangePWoldpasslabel
            // 
            ChangePWoldpasslabel.AutoSize = true;
            ChangePWoldpasslabel.Location = new Point(45, 87);
            ChangePWoldpasslabel.Name = "ChangePWoldpasslabel";
            ChangePWoldpasslabel.Size = new Size(79, 15);
            ChangePWoldpasslabel.TabIndex = 17;
            ChangePWoldpasslabel.Text = "Old Password";
            ChangePWoldpasslabel.Visible = false;
            // 
            // ChangePWoldpassTbox
            // 
            ChangePWoldpassTbox.Location = new Point(9, 105);
            ChangePWoldpassTbox.Multiline = true;
            ChangePWoldpassTbox.Name = "ChangePWoldpassTbox";
            ChangePWoldpassTbox.PasswordChar = '*';
            ChangePWoldpassTbox.Size = new Size(161, 26);
            ChangePWoldpassTbox.TabIndex = 18;
            ChangePWoldpassTbox.Visible = false;
            // 
            // ChangePWnewpassTbox
            // 
            ChangePWnewpassTbox.Location = new Point(177, 105);
            ChangePWnewpassTbox.Multiline = true;
            ChangePWnewpassTbox.Name = "ChangePWnewpassTbox";
            ChangePWnewpassTbox.PasswordChar = '*';
            ChangePWnewpassTbox.Size = new Size(161, 26);
            ChangePWnewpassTbox.TabIndex = 19;
            ChangePWnewpassTbox.Visible = false;
            // 
            // ChangePWnewpasslabel
            // 
            ChangePWnewpasslabel.AutoSize = true;
            ChangePWnewpasslabel.Location = new Point(213, 87);
            ChangePWnewpasslabel.Name = "ChangePWnewpasslabel";
            ChangePWnewpasslabel.Size = new Size(84, 15);
            ChangePWnewpasslabel.TabIndex = 20;
            ChangePWnewpasslabel.Text = "New Password";
            ChangePWnewpasslabel.Visible = false;
            // 
            // ChangePWApply
            // 
            ChangePWApply.BackgroundImage = (Image)resources.GetObject("ChangePWApply.BackgroundImage");
            ChangePWApply.BackgroundImageLayout = ImageLayout.Stretch;
            ChangePWApply.Location = new Point(177, 12);
            ChangePWApply.Name = "ChangePWApply";
            ChangePWApply.Size = new Size(87, 31);
            ChangePWApply.SizeMode = PictureBoxSizeMode.StretchImage;
            ChangePWApply.TabIndex = 21;
            ChangePWApply.TabStop = false;
            ChangePWApply.Visible = false;
            ChangePWApply.Click += ChangePWApply_Click;
            // 
            // AdminPasswordTbox
            // 
            AdminPasswordTbox.Location = new Point(715, 64);
            AdminPasswordTbox.Multiline = true;
            AdminPasswordTbox.Name = "AdminPasswordTbox";
            AdminPasswordTbox.PasswordChar = '*';
            AdminPasswordTbox.Size = new Size(161, 26);
            AdminPasswordTbox.TabIndex = 23;
            AdminPasswordTbox.Visible = false;
            AdminPasswordTbox.KeyDown += AdminPasswordTbox_KeyDown;
            // 
            // AdminPasswordLabel
            // 
            AdminPasswordLabel.AutoSize = true;
            AdminPasswordLabel.Location = new Point(740, 46);
            AdminPasswordLabel.Name = "AdminPasswordLabel";
            AdminPasswordLabel.Size = new Size(96, 15);
            AdminPasswordLabel.TabIndex = 24;
            AdminPasswordLabel.Text = "Admin Password";
            AdminPasswordLabel.Visible = false;
            // 
            // AdminPanel
            // 
            AdminPanel.BackgroundImage = (Image)resources.GetObject("AdminPanel.BackgroundImage");
            AdminPanel.BackgroundImageLayout = ImageLayout.Stretch;
            AdminPanel.Controls.Add(LabelDelete);
            AdminPanel.Controls.Add(DeleteTbox);
            AdminPanel.Controls.Add(DeleteButton);
            AdminPanel.Controls.Add(dataGridView1);
            AdminPanel.Controls.Add(ReturnAdmin);
            AdminPanel.Location = new Point(0, 337);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.Size = new Size(106, 122);
            AdminPanel.TabIndex = 25;
            AdminPanel.Visible = false;
            // 
            // LabelDelete
            // 
            LabelDelete.BackColor = Color.Transparent;
            LabelDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LabelDelete.ForeColor = SystemColors.Control;
            LabelDelete.Location = new Point(731, 241);
            LabelDelete.Name = "LabelDelete";
            LabelDelete.Size = new Size(96, 22);
            LabelDelete.TabIndex = 5;
            LabelDelete.Text = "Username";
            // 
            // DeleteTbox
            // 
            DeleteTbox.Location = new Point(715, 266);
            DeleteTbox.Name = "DeleteTbox";
            DeleteTbox.Size = new Size(121, 29);
            DeleteTbox.TabIndex = 4;
            DeleteTbox.Text = "";
            // 
            // DeleteButton
            // 
            DeleteButton.BackgroundImage = (Image)resources.GetObject("DeleteButton.BackgroundImage");
            DeleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteButton.Location = new Point(715, 190);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(121, 46);
            DeleteButton.TabIndex = 3;
            DeleteButton.TabStop = false;
            DeleteButton.Click += Delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(176, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(436, 362);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // ReturnAdmin
            // 
            ReturnAdmin.BackgroundImage = (Image)resources.GetObject("ReturnAdmin.BackgroundImage");
            ReturnAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            ReturnAdmin.Location = new Point(715, 12);
            ReturnAdmin.Name = "ReturnAdmin";
            ReturnAdmin.Size = new Size(121, 46);
            ReturnAdmin.TabIndex = 1;
            ReturnAdmin.TabStop = false;
            ReturnAdmin.Click += ReturnAdmin_Click;
            // 
            // PhoneNumberTbox
            // 
            PhoneNumberTbox.Location = new Point(149, 190);
            PhoneNumberTbox.Multiline = true;
            PhoneNumberTbox.Name = "PhoneNumberTbox";
            PhoneNumberTbox.Size = new Size(161, 26);
            PhoneNumberTbox.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(193, 172);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 27;
            label6.Text = "Phone Number";
            // 
            // LoginSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(918, 459);
            Controls.Add(AdminPanel);
            Controls.Add(AdminPasswordLabel);
            Controls.Add(AdminPasswordTbox);
            Controls.Add(ChangePWApply);
            Controls.Add(ChangePWnewpasslabel);
            Controls.Add(ChangePWnewpassTbox);
            Controls.Add(ChangePWoldpassTbox);
            Controls.Add(ChangePWoldpasslabel);
            Controls.Add(ChangePWUserLabel);
            Controls.Add(ChangePWuserTbox);
            Controls.Add(AdminButton);
            Controls.Add(ChangePWButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginuser);
            Controls.Add(loginpassword);
            Controls.Add(username);
            Controls.Add(password);
            Controls.Add(address);
            Controls.Add(pictureBox3);
            Controls.Add(SignUpButton);
            Controls.Add(LoginButton);
            Controls.Add(PhoneNumberTbox);
            Controls.Add(label6);
            DoubleBuffered = true;
            Name = "LoginSignUp";
            Text = "LoginSignUp";
            FormClosing += LoginSignUp_FormClosing;
            Load += LoginSignUp_Load;
            ((System.ComponentModel.ISupportInitialize)LoginButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)SignUpButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangePWButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangePWApply).EndInit();
            AdminPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DeleteButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReturnAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LoginButton;
        private PictureBox SignUpButton;
        private PictureBox pictureBox3;
        private TextBox address;
        private TextBox password;
        private TextBox username;
        private TextBox loginpassword;
        private TextBox loginuser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox ChangePWButton;
        private PictureBox AdminButton;
        private TextBox ChangePWuserTbox;
        private Label ChangePWUserLabel;
        private Label ChangePWoldpasslabel;
        private TextBox ChangePWoldpassTbox;
        private TextBox ChangePWnewpassTbox;
        private Label ChangePWnewpasslabel;
        private PictureBox ChangePWApply;
        private TextBox AdminPasswordTbox;
        private Label AdminPasswordLabel;
        private Panel AdminPanel;
        private PictureBox ReturnAdmin;
        private DataGridView dataGridView1;
        private PictureBox DeleteButton;
        private Label LabelDelete;
        private RichTextBox DeleteTbox;
        private TextBox PhoneNumberTbox;
        private Label label6;
    }
}