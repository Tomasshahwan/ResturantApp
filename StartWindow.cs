using System.Windows.Forms;
using System;
using static EmployeeSystemLT.LoginSignUp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Drawing.Text;
using static EmployeeSystemLT.StartWindow;
using System.Text;
using System.Security.Principal;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace EmployeeSystemLT
{
    public partial class StartWindow : Form
    {

        public Customer currentClient { get; set; }
        public StartWindow()
        {
            InitializeComponent();



        }


        private void ORDERBUTTON_Click(object sender, EventArgs e)
        {
            // Create a new instance of the form you want to open
            OrderMenu newForm = new OrderMenu();

            newForm.currentClient = currentClient;
            // Close the current form
            this.Hide();

            // Show the new form
            newForm.Show();

        }

        private void StartWindow_Load(object sender, EventArgs e)
        {

            Welcome_Label.Text = "Welcome " + currentClient.Level + "!";
            int checklevel = currentClient.AccessBox();
            if (checklevel <= 2)
                STAFFBUTTON.Visible = false;

            LoginSignUp.AnimatePictureBox(ORDERBUTTON);
            LoginSignUp.AnimatePictureBox(STAFFBUTTON);
            LoginSignUp.AnimatePictureBox(LogOut);

        }



        private void StartWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Close the main form (LoginSignUp)
            LoginSignUp mainForm = Application.OpenForms["LoginSignUp"] as LoginSignUp;
            mainForm?.Close();

        }

        private void STAFFBUTTON_Click_1(object sender, EventArgs e)
        {
            // Create a new instance of the form you want to open
            STAFFAREA newForm = new STAFFAREA();

            newForm.currentClient = currentClient;
            // Close the current form
            this.Hide();

            // Show the new form
            newForm.Show();

        }

        private void LogOut_Click_1(object sender, EventArgs e)
        {
            LoginSignUp mainForm = Application.OpenForms["LoginSignUp"] as LoginSignUp;
            if (mainForm != null)
            {
                mainForm.Show();
            }

            // Hide the current form
            this.Hide(); // maybe to be changed to Close but then ask how to avoid logout bug
        }
    }
}