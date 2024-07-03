namespace EmployeeSystemLT
{
    partial class STAFFAREA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STAFFAREA));
            RETURNBUTTON = new PictureBox();
            ShiftSubmit = new PictureBox();
            ShiftsPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            ReturnFromShiftsPanel = new PictureBox();
            dateTimePickerEndTime = new DateTimePicker();
            dateTimePickerTime = new DateTimePicker();
            dateTimePickerDay = new DateTimePicker();
            DeleteShiftButton = new PictureBox();
            ClearShiftButton = new PictureBox();
            AddShiftButton = new PictureBox();
            listViewShifts = new ListView();
            EmployeeName = new ColumnHeader();
            WorkDay = new ColumnHeader();
            StartWorkTime = new ColumnHeader();
            EndWorkHour = new ColumnHeader();
            ManageButton = new PictureBox();
            CurrentOrdersButton = new PictureBox();
            ManagePanel = new Panel();
            ReturnFromFirePanel = new PictureBox();
            FireButtonManage = new PictureBox();
            dataGridView1 = new DataGridView();
            CurrentOrdersPanel = new Panel();
            ReturnFromCurrOrdersButton = new PictureBox();
            CloseOrderButton = new PictureBox();
            dataGridViewForOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)RETURNBUTTON).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShiftSubmit).BeginInit();
            ShiftsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnFromShiftsPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteShiftButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClearShiftButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddShiftButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ManageButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CurrentOrdersButton).BeginInit();
            ManagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnFromFirePanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FireButtonManage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            CurrentOrdersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnFromCurrOrdersButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseOrderButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForOrders).BeginInit();
            SuspendLayout();
            // 
            // RETURNBUTTON
            // 
            RETURNBUTTON.BackColor = Color.Transparent;
            RETURNBUTTON.BackgroundImage = (Image)resources.GetObject("RETURNBUTTON.BackgroundImage");
            RETURNBUTTON.BackgroundImageLayout = ImageLayout.Stretch;
            RETURNBUTTON.Location = new Point(907, 12);
            RETURNBUTTON.Name = "RETURNBUTTON";
            RETURNBUTTON.Size = new Size(146, 53);
            RETURNBUTTON.TabIndex = 0;
            RETURNBUTTON.TabStop = false;
            RETURNBUTTON.Click += RETURNBUTTON_Click;
            // 
            // ShiftSubmit
            // 
            ShiftSubmit.BackColor = Color.Transparent;
            ShiftSubmit.BackgroundImage = (Image)resources.GetObject("ShiftSubmit.BackgroundImage");
            ShiftSubmit.BackgroundImageLayout = ImageLayout.Stretch;
            ShiftSubmit.Location = new Point(375, 234);
            ShiftSubmit.Name = "ShiftSubmit";
            ShiftSubmit.Size = new Size(373, 107);
            ShiftSubmit.SizeMode = PictureBoxSizeMode.StretchImage;
            ShiftSubmit.TabIndex = 1;
            ShiftSubmit.TabStop = false;
            ShiftSubmit.Click += ShiftSubmit_Click;
            // 
            // ShiftsPanel
            // 
            ShiftsPanel.BackgroundImage = (Image)resources.GetObject("ShiftsPanel.BackgroundImage");
            ShiftsPanel.BackgroundImageLayout = ImageLayout.Stretch;
            ShiftsPanel.Controls.Add(label2);
            ShiftsPanel.Controls.Add(label1);
            ShiftsPanel.Controls.Add(ReturnFromShiftsPanel);
            ShiftsPanel.Controls.Add(dateTimePickerEndTime);
            ShiftsPanel.Controls.Add(dateTimePickerTime);
            ShiftsPanel.Controls.Add(dateTimePickerDay);
            ShiftsPanel.Controls.Add(DeleteShiftButton);
            ShiftsPanel.Controls.Add(ClearShiftButton);
            ShiftsPanel.Controls.Add(AddShiftButton);
            ShiftsPanel.Controls.Add(listViewShifts);
            ShiftsPanel.Location = new Point(64, 480);
            ShiftsPanel.Name = "ShiftsPanel";
            ShiftsPanel.Size = new Size(249, 129);
            ShiftsPanel.TabIndex = 2;
            ShiftsPanel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(845, 147);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "End Hour";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(845, 101);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 8;
            label1.Text = "Start Hour";
            // 
            // ReturnFromShiftsPanel
            // 
            ReturnFromShiftsPanel.BackColor = Color.Transparent;
            ReturnFromShiftsPanel.BackgroundImage = (Image)resources.GetObject("ReturnFromShiftsPanel.BackgroundImage");
            ReturnFromShiftsPanel.BackgroundImageLayout = ImageLayout.Stretch;
            ReturnFromShiftsPanel.Location = new Point(924, 10);
            ReturnFromShiftsPanel.Name = "ReturnFromShiftsPanel";
            ReturnFromShiftsPanel.Size = new Size(129, 53);
            ReturnFromShiftsPanel.TabIndex = 7;
            ReturnFromShiftsPanel.TabStop = false;
            ReturnFromShiftsPanel.Click += ShiftPanelReturn_Click;
            // 
            // dateTimePickerEndTime
            // 
            dateTimePickerEndTime.Format = DateTimePickerFormat.Time;
            dateTimePickerEndTime.Location = new Point(816, 165);
            dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            dateTimePickerEndTime.Size = new Size(235, 23);
            dateTimePickerEndTime.TabIndex = 6;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Format = DateTimePickerFormat.Time;
            dateTimePickerTime.Location = new Point(816, 119);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.Size = new Size(235, 23);
            dateTimePickerTime.TabIndex = 5;
            // 
            // dateTimePickerDay
            // 
            dateTimePickerDay.Format = DateTimePickerFormat.Short;
            dateTimePickerDay.Location = new Point(818, 69);
            dateTimePickerDay.Name = "dateTimePickerDay";
            dateTimePickerDay.Size = new Size(235, 23);
            dateTimePickerDay.TabIndex = 4;
            // 
            // DeleteShiftButton
            // 
            DeleteShiftButton.BackColor = SystemColors.ButtonHighlight;
            DeleteShiftButton.BackgroundImage = (Image)resources.GetObject("DeleteShiftButton.BackgroundImage");
            DeleteShiftButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteShiftButton.Location = new Point(656, 346);
            DeleteShiftButton.Name = "DeleteShiftButton";
            DeleteShiftButton.Size = new Size(111, 53);
            DeleteShiftButton.TabIndex = 3;
            DeleteShiftButton.TabStop = false;
            DeleteShiftButton.Visible = false;
            DeleteShiftButton.Click += DeleteButton_Click;
            // 
            // ClearShiftButton
            // 
            ClearShiftButton.BackColor = SystemColors.ButtonHighlight;
            ClearShiftButton.BackgroundImage = (Image)resources.GetObject("ClearShiftButton.BackgroundImage");
            ClearShiftButton.BackgroundImageLayout = ImageLayout.Stretch;
            ClearShiftButton.Location = new Point(656, 69);
            ClearShiftButton.Name = "ClearShiftButton";
            ClearShiftButton.Size = new Size(111, 53);
            ClearShiftButton.TabIndex = 2;
            ClearShiftButton.TabStop = false;
            ClearShiftButton.Visible = false;
            ClearShiftButton.Click += ClearShiftButton_Click;
            // 
            // AddShiftButton
            // 
            AddShiftButton.BackColor = SystemColors.ButtonHighlight;
            AddShiftButton.BackgroundImage = (Image)resources.GetObject("AddShiftButton.BackgroundImage");
            AddShiftButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddShiftButton.Location = new Point(656, 405);
            AddShiftButton.Name = "AddShiftButton";
            AddShiftButton.Size = new Size(111, 53);
            AddShiftButton.TabIndex = 1;
            AddShiftButton.TabStop = false;
            AddShiftButton.Click += AddShift_Click;
            // 
            // listViewShifts
            // 
            listViewShifts.Columns.AddRange(new ColumnHeader[] { EmployeeName, WorkDay, StartWorkTime, EndWorkHour });
            listViewShifts.Location = new Point(233, 60);
            listViewShifts.Name = "listViewShifts";
            listViewShifts.Size = new Size(551, 412);
            listViewShifts.TabIndex = 0;
            listViewShifts.UseCompatibleStateImageBehavior = false;
            listViewShifts.View = View.Details;
            // 
            // EmployeeName
            // 
            EmployeeName.Text = "Name";
            EmployeeName.Width = 100;
            // 
            // WorkDay
            // 
            WorkDay.Text = "Day";
            WorkDay.Width = 80;
            // 
            // StartWorkTime
            // 
            StartWorkTime.Text = "Start Time";
            StartWorkTime.Width = 80;
            // 
            // EndWorkHour
            // 
            EndWorkHour.Text = "End Hour";
            EndWorkHour.Width = 80;
            // 
            // ManageButton
            // 
            ManageButton.BackColor = Color.Transparent;
            ManageButton.BackgroundImage = (Image)resources.GetObject("ManageButton.BackgroundImage");
            ManageButton.BackgroundImageLayout = ImageLayout.Stretch;
            ManageButton.Location = new Point(375, 384);
            ManageButton.Name = "ManageButton";
            ManageButton.Size = new Size(373, 110);
            ManageButton.SizeMode = PictureBoxSizeMode.StretchImage;
            ManageButton.TabIndex = 3;
            ManageButton.TabStop = false;
            ManageButton.Visible = false;
            ManageButton.Click += ManageButton_Click;
            // 
            // CurrentOrdersButton
            // 
            CurrentOrdersButton.BackColor = Color.Transparent;
            CurrentOrdersButton.BackgroundImage = (Image)resources.GetObject("CurrentOrdersButton.BackgroundImage");
            CurrentOrdersButton.BackgroundImageLayout = ImageLayout.Stretch;
            CurrentOrdersButton.Location = new Point(375, 81);
            CurrentOrdersButton.Name = "CurrentOrdersButton";
            CurrentOrdersButton.Size = new Size(358, 107);
            CurrentOrdersButton.SizeMode = PictureBoxSizeMode.StretchImage;
            CurrentOrdersButton.TabIndex = 4;
            CurrentOrdersButton.TabStop = false;
            CurrentOrdersButton.Click += CurrentOrdersButton_Click;
            // 
            // ManagePanel
            // 
            ManagePanel.BackgroundImage = (Image)resources.GetObject("ManagePanel.BackgroundImage");
            ManagePanel.BackgroundImageLayout = ImageLayout.Stretch;
            ManagePanel.Controls.Add(ReturnFromFirePanel);
            ManagePanel.Controls.Add(FireButtonManage);
            ManagePanel.Controls.Add(dataGridView1);
            ManagePanel.Location = new Point(658, 500);
            ManagePanel.Name = "ManagePanel";
            ManagePanel.Size = new Size(368, 137);
            ManagePanel.TabIndex = 6;
            ManagePanel.Visible = false;
            // 
            // ReturnFromFirePanel
            // 
            ReturnFromFirePanel.BackColor = Color.Transparent;
            ReturnFromFirePanel.BackgroundImage = (Image)resources.GetObject("ReturnFromFirePanel.BackgroundImage");
            ReturnFromFirePanel.BackgroundImageLayout = ImageLayout.Stretch;
            ReturnFromFirePanel.Location = new Point(907, 12);
            ReturnFromFirePanel.Name = "ReturnFromFirePanel";
            ReturnFromFirePanel.Size = new Size(103, 53);
            ReturnFromFirePanel.TabIndex = 8;
            ReturnFromFirePanel.TabStop = false;
            ReturnFromFirePanel.Click += ReturnFromFirePanel_Click;
            // 
            // FireButtonManage
            // 
            FireButtonManage.BackColor = Color.Transparent;
            FireButtonManage.BackgroundImage = (Image)resources.GetObject("FireButtonManage.BackgroundImage");
            FireButtonManage.BackgroundImageLayout = ImageLayout.Stretch;
            FireButtonManage.Location = new Point(907, 529);
            FireButtonManage.Name = "FireButtonManage";
            FireButtonManage.Size = new Size(103, 53);
            FireButtonManage.TabIndex = 7;
            FireButtonManage.TabStop = false;
            FireButtonManage.Click += FireButtonManage_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(248, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(566, 425);
            dataGridView1.TabIndex = 0;
            // 
            // CurrentOrdersPanel
            // 
            CurrentOrdersPanel.BackgroundImage = (Image)resources.GetObject("CurrentOrdersPanel.BackgroundImage");
            CurrentOrdersPanel.BackgroundImageLayout = ImageLayout.Stretch;
            CurrentOrdersPanel.Controls.Add(ReturnFromCurrOrdersButton);
            CurrentOrdersPanel.Controls.Add(CloseOrderButton);
            CurrentOrdersPanel.Controls.Add(dataGridViewForOrders);
            CurrentOrdersPanel.Location = new Point(50, 194);
            CurrentOrdersPanel.Name = "CurrentOrdersPanel";
            CurrentOrdersPanel.Size = new Size(173, 112);
            CurrentOrdersPanel.TabIndex = 9;
            CurrentOrdersPanel.Visible = false;
            // 
            // ReturnFromCurrOrdersButton
            // 
            ReturnFromCurrOrdersButton.BackColor = Color.Transparent;
            ReturnFromCurrOrdersButton.BackgroundImage = (Image)resources.GetObject("ReturnFromCurrOrdersButton.BackgroundImage");
            ReturnFromCurrOrdersButton.BackgroundImageLayout = ImageLayout.Stretch;
            ReturnFromCurrOrdersButton.Location = new Point(965, 3);
            ReturnFromCurrOrdersButton.Name = "ReturnFromCurrOrdersButton";
            ReturnFromCurrOrdersButton.Size = new Size(82, 31);
            ReturnFromCurrOrdersButton.TabIndex = 11;
            ReturnFromCurrOrdersButton.TabStop = false;
            ReturnFromCurrOrdersButton.Click += ReturnFromCurrOrdersButton_Click;
            // 
            // CloseOrderButton
            // 
            CloseOrderButton.BackColor = Color.Transparent;
            CloseOrderButton.BackgroundImage = (Image)resources.GetObject("CloseOrderButton.BackgroundImage");
            CloseOrderButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseOrderButton.Location = new Point(14, 568);
            CloseOrderButton.Name = "CloseOrderButton";
            CloseOrderButton.Size = new Size(157, 46);
            CloseOrderButton.TabIndex = 10;
            CloseOrderButton.TabStop = false;
            CloseOrderButton.Click += CloseOrderButton_Click;
            // 
            // dataGridViewForOrders
            // 
            dataGridViewForOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForOrders.Location = new Point(14, 40);
            dataGridViewForOrders.Name = "dataGridViewForOrders";
            dataGridViewForOrders.RowTemplate.Height = 25;
            dataGridViewForOrders.Size = new Size(1027, 525);
            dataGridViewForOrders.TabIndex = 1;
            // 
            // STAFFAREA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1065, 635);
            Controls.Add(CurrentOrdersPanel);
            Controls.Add(ManagePanel);
            Controls.Add(ShiftsPanel);
            Controls.Add(RETURNBUTTON);
            Controls.Add(ShiftSubmit);
            Controls.Add(CurrentOrdersButton);
            Controls.Add(ManageButton);
            DoubleBuffered = true;
            Name = "STAFFAREA";
            Text = "STAFFAREA";
            FormClosing += STAFFAREA_FormClosing;
            Load += STAFFAREA_Load;
            ((System.ComponentModel.ISupportInitialize)RETURNBUTTON).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShiftSubmit).EndInit();
            ShiftsPanel.ResumeLayout(false);
            ShiftsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnFromShiftsPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteShiftButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClearShiftButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddShiftButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)ManageButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CurrentOrdersButton).EndInit();
            ManagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReturnFromFirePanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)FireButtonManage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            CurrentOrdersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReturnFromCurrOrdersButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseOrderButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private PictureBox RETURNBUTTON;
        private PictureBox ShiftSubmit;
        private Panel ShiftsPanel;
        private ListView listViewShifts;
        private ColumnHeader EmployeeName;
        private ColumnHeader WorkDay;
        private ColumnHeader StartWorkTime;
        private ColumnHeader EndWorkHour;
        private PictureBox AddShiftButton;
        private PictureBox DeleteShiftButton;
        private PictureBox ClearShiftButton;
        private DateTimePicker dateTimePickerDay;
        private DateTimePicker dateTimePickerTime;
        private DateTimePicker dateTimePickerEndTime;
        private PictureBox ReturnFromShiftsPanel;
        private PictureBox ManageButton;
        private PictureBox CurrentOrdersButton;
        private Label label2;
        private Label label1;
        private Panel ManagePanel;
        private DataGridView dataGridView1;
        private PictureBox FireButtonManage;
        private PictureBox ReturnFromFirePanel;
        private Panel CurrentOrdersPanel;
        private DataGridView dataGridViewForOrders;
        private PictureBox CloseOrderButton;
        private PictureBox ReturnFromCurrOrdersButton;
    }
}