using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EmployeeSystemLT.LoginSignUp;
using System.IO;
using System.Xml.Serialization;

namespace EmployeeSystemLT
{
    public partial class LoginSignUp : Form
    {
        [XmlInclude(typeof(VIPCustomer))]
        [XmlInclude(typeof(BasicEmployee))]
        [XmlInclude(typeof(DeliveryPerson))]
        [XmlInclude(typeof(Manager))]
        [XmlInclude(typeof(Admin))]

        public class Customer
        {

            public static int count = 0;

            public int AccessLevel = 1;
            public string? Username { get; set; }
            public string? Password { get; set; }
            public string? Address { get; set; }
            public string? PhoneNumber { get; set; }
            public string? Level { get; set; } = "Customer";


            public virtual int AccessBox()
            {
                count++;
                if (count == 1)
                    MessageBox.Show("We serve fresh food and smile :)", "Customer Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return AccessLevel;
            }

        }

        public class VIPCustomer : Customer
        {
            public VIPCustomer()
            {
                AccessLevel = 2;
                Level = "VIPCustomer";
            }
            public override int AccessBox()
            {
                count++;
                if (count == 1)
                    MessageBox.Show("Enjoy Desserts, discounts, and FAST DELIVERY! :D", "VIP Customer detected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return AccessLevel;

            }

        }


        public class BasicEmployee : Customer
        {
            public BasicEmployee()
            {
                AccessLevel = 3;
                Level = "BasicEmployee";
            }
            public override int AccessBox()
            {
                count++;
                if (count == 1)
                    MessageBox.Show("Make sure to submit shifts!!!", "Employee Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return AccessLevel;
            }
        }

        public class DeliveryPerson : BasicEmployee
        {
            public DeliveryPerson()
            {
                AccessLevel = 4;
                Level = "DeliveryPerson";

            }

            public override int AccessBox()
            {
                count++;
                if (count == 1)
                    MessageBox.Show("Be safe on the road", "Delivery Guy Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return AccessLevel;
            }
        }

        public class Manager : BasicEmployee
        {
            public Manager()
            {
                AccessLevel = 5;
                Level = "Manager";
            }

            public override int AccessBox()
            {
                count++;
                if (count == 1)
                    MessageBox.Show("Keep an eye on the workers", "Manager Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return AccessLevel;
            }
        }

        public class Admin : Manager
        {
            public Admin()
            {
                AccessLevel = 6;
                Level = "Admin";
            }

            public override int AccessBox()
            {
                count++;
                if (count == 1)
                    MessageBox.Show("Keep your Password safe", "Admin Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return AccessLevel;
            }
        }


        public static class DataManager
        {
            private static List<Customer> users = new List<Customer>();

            public static List<Customer> Users
            {
                get { return users; }
                set { users = value; }
            }
        }

        private Dictionary<string, Type> userTypeMapping = new Dictionary<string, Type>
        {
          { "Customer", typeof(Customer) },
          { "VIPCustomer", typeof(VIPCustomer) },
            {"BasicEmployee", typeof(BasicEmployee) },
            {"DeliveryPerson", typeof(DeliveryPerson) },
            {"Manager", typeof(Manager) },
            {"Admin", typeof(Admin) }
          };


        public LoginSignUp()
        {
            InitializeComponent();



        }

        public class PictureBoxInfo
        {
            public Size OriginalSize { get; set; }
            public Point OriginalLocation { get; set; }
        }

        public static readonly Dictionary<PictureBox, PictureBoxInfo> pictureBoxInfoDict = new Dictionary<PictureBox, PictureBoxInfo>();
        public static void AnimatePictureBox(PictureBox pictureBox)
        {
            PictureBoxInfo pictureBoxInfo = new PictureBoxInfo
            {
                OriginalSize = pictureBox.Size,
                OriginalLocation = pictureBox.Location
            };

            pictureBox.MouseEnter += PictureBox_MouseEnter;
            pictureBox.MouseLeave += PictureBox_MouseLeave;

            pictureBoxInfoDict[pictureBox] = pictureBoxInfo;
        }

        public static void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            int newWidth = (int)(pictureBox.Width * 1.1);
            int newHeight = (int)(pictureBox.Height * 1.1);

            int newX = pictureBox.Left - (newWidth - pictureBox.Width) / 2;
            int newY = pictureBox.Top - (newHeight - pictureBox.Height) / 2;

            pictureBox.Size = new Size(newWidth, newHeight);
            pictureBox.Location = new Point(newX, newY);
        }

        public static void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            PictureBoxInfo pictureBoxInfo = pictureBoxInfoDict[pictureBox];

            pictureBox.Size = pictureBoxInfo.OriginalSize;
            pictureBox.Location = pictureBoxInfo.OriginalLocation;
        }
        private void SignUp_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;
            string add = address.Text;
            string phone = PhoneNumberTbox.Text;

            bool containsNonDigits = false;

            foreach (char c in phone)
            {
                if (!char.IsDigit(c))
                {
                    containsNonDigits = true;
                    break;
                }
            }

            if (containsNonDigits)
            {
                MessageBox.Show("Please enter a valid phone number with digits only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PhoneNumberTbox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(add) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please provide all the required information.");
                return;
            }

            if (DataManager.Users.Any(existingUser => existingUser.Username == user))
            {
                MessageBox.Show("A user with the same username already exists.");
                username.Clear();
                return;
            }



            Customer newUser = new Customer { Username = user, Password = pass, Address = add, PhoneNumber = phone };

            DataManager.Users.Add(newUser);

            username.Clear();
            password.Clear();
            address.Clear();
            PhoneNumberTbox.Clear();

            MessageBox.Show("Signed Up Succesfully!");


        }



        private void Login_Click(object sender, EventArgs e)
        {
            string user = loginuser.Text;
            string pass = loginpassword.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please provide all the required information.");
                return;
            }


            Customer foundUser = DataManager.Users.FirstOrDefault(existingUser => existingUser.Username == user && existingUser.Password == pass);

            if (foundUser == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            MessageBox.Show("Logged in Succesfully!");
            loginuser.Clear();
            loginpassword.Clear();

            StartWindow startWindow = new StartWindow();


            startWindow.currentClient = foundUser;

            // Hide the main form
            this.Hide();
            // Show the StartWindow form

            startWindow.Show();
            startWindow.Activate();



        }



        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminPasswordTbox.Visible = !AdminPasswordTbox.Visible;
            AdminPasswordLabel.Visible = !AdminPasswordLabel.Visible;
        }

        private void LoginSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            // XML serializer for Customer Class
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

            // Specify the path of the file
            string filePath = "users.xml";

            // Create or open the file to write serialized data
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                // Serialize the list of users to the XML file
                serializer.Serialize(fs, DataManager.Users);
            }
        }


        private void LoginSignUp_Load(object sender, EventArgs e)
        {
            // Specify the path of the file
            string filePath = "users.xml";

            // Check if the XML file exists
            if (File.Exists(filePath))
            {
                // Create an instance of XmlSerializer for your list type
                XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

                // Read the XML file and deserialize it back to the list of users
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    DataManager.Users = (List<Customer>)serializer.Deserialize(fs);
                }
            }
            else
            {
                // If the XML file doesn't exist, create an empty list
                DataManager.Users = new List<Customer>();
            }

            // add admin as default user

            if (!DataManager.Users.Any(u => u.Username == "admin"))
            {
                DataManager.Users.Add(new Admin { Username = "admin", Password = "admin", Address = "admin", PhoneNumber = "admin" });
            }

            AdminPanel.Dock = DockStyle.Fill;

            AnimatePictureBox(SignUpButton);
            AnimatePictureBox(LoginButton);
            AnimatePictureBox(ChangePWButton);
            AnimatePictureBox(ChangePWApply);
            AnimatePictureBox(AdminButton);

        }

        private void ChangePWButton_Click(object sender, EventArgs e)
        {
            if (!ChangePWuserTbox.Visible) // buttons are hidden
            {
                ChangePWuserTbox.Visible = true;
                ChangePWUserLabel.Visible = true;
                ChangePWnewpasslabel.Visible = true;
                ChangePWnewpassTbox.Visible = true;
                ChangePWoldpasslabel.Visible = true;
                ChangePWoldpassTbox.Visible = true;
                ChangePWApply.Visible = true;
            }
            else
            {
                ChangePWuserTbox.Visible = false;
                ChangePWUserLabel.Visible = false;
                ChangePWnewpasslabel.Visible = false;
                ChangePWnewpassTbox.Visible = false;
                ChangePWoldpasslabel.Visible = false;
                ChangePWoldpassTbox.Visible = false;
                ChangePWApply.Visible = false;
            }


        }

        private void ChangePWApply_Click(object sender, EventArgs e)
        {
            string user = ChangePWuserTbox.Text;
            string oldpass = ChangePWoldpassTbox.Text;
            string newpass = ChangePWnewpassTbox.Text;

            // Find the user in the users list
            Customer foundUser = DataManager.Users.FirstOrDefault(u => u.Username == user && u.Password == oldpass);

            if (foundUser != null && newpass != "")
            {
                // Update the user's password
                foundUser.Password = newpass;
                MessageBox.Show("Password changed successfully.");
                ChangePWuserTbox.Clear();
                ChangePWoldpassTbox.Clear();
                ChangePWnewpassTbox.Clear();
                ChangePWuserTbox.Visible = false;
                ChangePWUserLabel.Visible = false;
                ChangePWnewpasslabel.Visible = false;
                ChangePWnewpassTbox.Visible = false;
                ChangePWoldpasslabel.Visible = false;
                ChangePWoldpassTbox.Visible = false;
                ChangePWApply.Visible = false;

            }
            else
            {
                MessageBox.Show("Invalid username/old password/empty new password.");
            }


        }


        private void AdminPasswordTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Perform the action you want when Enter is pressed
                LoginAsAdmin();
            }
        }
        private void LoginAsAdmin()
        {
            string enteredPassword = AdminPasswordTbox.Text;
            Customer adminUser = DataManager.Users.FirstOrDefault(u => u.Username == "admin");

            if (enteredPassword != adminUser.Password)
            {
                MessageBox.Show("Incorrect admin password.");

            }
            else
            {
                // Correct admin password, open AdminPanel





                ////////////// Data Grid View now of Admin Panel
                ///

                // Set data source
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Users; // get data source from a list called users of the class "MyUsers"

                AdminPanel.Visible = true;
            }

            // Clear the password TextBox
            AdminPasswordTbox.Clear();
            AdminPasswordTbox.Hide();
            AdminPasswordLabel.Hide();
        }

        private void ReturnAdmin_Click(object sender, EventArgs e)
        {
            AdminPanel.Visible = false;
            AdminPasswordTbox.Clear(); // This fixes buffer issues with the enter key :)

        }

        private string originalLevelValue = null; // Here we make it so the Admin can only change the levels that exist
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // find the column of the level
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Level"].Index)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //make it string
                originalLevelValue = cell.Value?.ToString();
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //we change the value of the level and we check if its correct
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Level"].Index)
            {
                //find level
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string newLevel = cell.Value?.ToString();

                //checks if user did put a correct string
                if (!string.IsNullOrEmpty(newLevel) && userTypeMapping.ContainsKey(newLevel))
                {
                    //if correct: this code transfers the old user level to the new user level by making a copy and copying the info
                    Customer oldUser = (Customer)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    Type targetType = userTypeMapping[newLevel];

                    //language activator to create instance copy
                    Customer newUser = (Customer)Activator.CreateInstance(targetType);
                    newUser.Username = oldUser.Username;
                    newUser.Password = oldUser.Password;
                    newUser.Address = oldUser.Address;

                    DataManager.Users[e.RowIndex] = newUser;

                    // Update the "Level" property value in the cell
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newLevel;
                }
                else
                {
                    // Revert the cell's value to the original level because user put wrong level
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = originalLevelValue;
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string userToDelete = DeleteTbox.Text;

            if (userToDelete == "admin")
            {
                MessageBox.Show("Nice Try Buddy", "No way!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeleteTbox.Clear();
                return;
            }
            // Find the index of the user in the list
            int userIndex = DataManager.Users.FindIndex(u => u.Username == userToDelete);

            if (userIndex != -1)
            {
                MessageBox.Show("User found, deleting");

                // User found, delete the user from the list
                DataManager.Users.RemoveAt(userIndex);

                //update datagrid
                dataGridView1.DataSource = null; // Clear the existing data source
                dataGridView1.DataSource = DataManager.Users; // Set the new data source

            }
            else
            {
                // User not found, show a message box
                MessageBox.Show("User not found.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DeleteTbox.Clear();
        }

    }


}


