namespace EmployeeSystemLT
{
    partial class StartWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            Welcome_Label = new Label();
            STAFFBUTTON = new PictureBox();
            ORDERBUTTON = new PictureBox();
            LogOut = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)STAFFBUTTON).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ORDERBUTTON).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogOut).BeginInit();
            SuspendLayout();
            // 
            // Welcome_Label
            // 
            Welcome_Label.AutoSize = true;
            Welcome_Label.BackColor = Color.Transparent;
            Welcome_Label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Welcome_Label.ForeColor = SystemColors.Control;
            Welcome_Label.Location = new Point(400, 37);
            Welcome_Label.Name = "Welcome_Label";
            Welcome_Label.Size = new Size(145, 37);
            Welcome_Label.TabIndex = 0;
            Welcome_Label.Text = "Welcome!";
            // 
            // STAFFBUTTON
            // 
            STAFFBUTTON.BackColor = Color.Transparent;
            STAFFBUTTON.BackgroundImage = (Image)resources.GetObject("STAFFBUTTON.BackgroundImage");
            STAFFBUTTON.BackgroundImageLayout = ImageLayout.Stretch;
            STAFFBUTTON.Location = new Point(21, 12);
            STAFFBUTTON.Name = "STAFFBUTTON";
            STAFFBUTTON.Size = new Size(236, 62);
            STAFFBUTTON.TabIndex = 1;
            STAFFBUTTON.TabStop = false;
            STAFFBUTTON.Click += STAFFBUTTON_Click_1;
            // 
            // ORDERBUTTON
            // 
            ORDERBUTTON.BackColor = Color.Transparent;
            ORDERBUTTON.BackgroundImage = (Image)resources.GetObject("ORDERBUTTON.BackgroundImage");
            ORDERBUTTON.BackgroundImageLayout = ImageLayout.Stretch;
            ORDERBUTTON.Location = new Point(440, 518);
            ORDERBUTTON.Name = "ORDERBUTTON";
            ORDERBUTTON.Size = new Size(178, 67);
            ORDERBUTTON.TabIndex = 2;
            ORDERBUTTON.TabStop = false;
            ORDERBUTTON.Click += ORDERBUTTON_Click;
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.Transparent;
            LogOut.BackgroundImage = (Image)resources.GetObject("LogOut.BackgroundImage");
            LogOut.BackgroundImageLayout = ImageLayout.Stretch;
            LogOut.Location = new Point(870, 12);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(165, 62);
            LogOut.TabIndex = 3;
            LogOut.TabStop = false;
            LogOut.Click += LogOut_Click_1;
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1047, 597);
            Controls.Add(LogOut);
            Controls.Add(ORDERBUTTON);
            Controls.Add(STAFFBUTTON);
            Controls.Add(Welcome_Label);
            DoubleBuffered = true;
            Name = "StartWindow";
            Text = "StartWindow";
            FormClosing += StartWindow_FormClosing;
            Load += StartWindow_Load;
            ((System.ComponentModel.ISupportInitialize)STAFFBUTTON).EndInit();
            ((System.ComponentModel.ISupportInitialize)ORDERBUTTON).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label Welcome_Label;
        private PictureBox STAFFBUTTON;
        private PictureBox ORDERBUTTON;
        private PictureBox LogOut;
    }
}