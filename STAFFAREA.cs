using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static EmployeeSystemLT.LoginSignUp;
using static EmployeeSystemLT.OrderMenu;
using static EmployeeSystemLT.StartWindow;
using static System.Windows.Forms.DataFormats;

namespace EmployeeSystemLT
{
    public partial class STAFFAREA : Form
    {
        public Customer currentClient;

        public STAFFAREA()
        {
            InitializeComponent();
        }

        private void RETURNBUTTON_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void STAFFAREA_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ShiftData>));

            using (FileStream fs = new FileStream("shiftsData.xml", FileMode.Create))
            {
                serializer.Serialize(fs, shiftsList);
            }

            // Find and show the original form (Form1)
            StartWindow? OGForm = Application.OpenForms["StartWindow"] as StartWindow;
            OGForm.currentClient = currentClient;
            OGForm.Welcome_Label.Text = $"Welcome, {currentClient.Level}!";
            if (OGForm != null)
            {
                OGForm.Show();
            }
        }

        //SHIFTPANEL LOGIC HERE:

        public class ShiftData
        {
            public string UserName { get; set; }
            public DateTime Day { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }

            public int ShiftCount = 0;

        }

        private List<ShiftData> shiftsList = new List<ShiftData>();

        private void PopulateShiftsListView()
        {
            // Clear the ListView before populating
            listViewShifts.Items.Clear();

            // Get the current user's UserType
            int checklevel = currentClient.AccessBox();

            if (checklevel == 6) ClearShiftButton.Visible = true; // Admin button only!

            if (checklevel >= 5) DeleteShiftButton.Visible = true; //Managers and Admin only buttons!

            foreach (ShiftData shift in shiftsList)
            {
                // Display shifts only for the current user's UserType
                if (checklevel == 3 || checklevel == 4)
                {

                    if (shift.UserName == currentClient.Username)
                    {
                        ListViewItem item = new ListViewItem(new[]
                        {
                    shift.UserName,
                    shift.Day.ToShortDateString(),
                    shift.StartTime.ToShortTimeString(),
                    shift.EndTime.ToShortTimeString()
                });
                        listViewShifts.Items.Add(item);
                    }
                }
                // Display all shifts for other user types
                else
                {
                    ListViewItem item = new ListViewItem(new[]
                    {
                shift.UserName,
                shift.Day.ToShortDateString(),
                shift.StartTime.ToShortTimeString(),
                shift.EndTime.ToShortTimeString()
            });
                    listViewShifts.Items.Add(item);
                }
            }
        }

        private void AddShift_Click(object sender, EventArgs e)
        {

            // Get selected day from day DateTimePicker
            DateTime selectedDay = dateTimePickerDay.Value.Date;

            // Check if selected day is the current day or before it
            if (selectedDay <= DateTime.Today)
            {
                MessageBox.Show("Please select a day from tomorrow onwards.");
                return;
            }

            // Check if selected day is more than 7 days from the current date
            if ((selectedDay - DateTime.Today).TotalDays > 7)
            {
                MessageBox.Show("You can only select a day within the next 7 days.");
                return;
            }

            TimeSpan openingTime = new TimeSpan(6, 0, 0);
            TimeSpan closingTime = new TimeSpan(23, 0, 0);

            // Check if selected day is a Saturday
            if (selectedDay.DayOfWeek == DayOfWeek.Saturday)
            {
                MessageBox.Show("Saturdays are not allowed as shift days.");
                return;
            }

            // Check if the user already has a shift on the selected day
            foreach (ListViewItem Item in listViewShifts.Items)
            {
                if (Item.SubItems[0].Text == currentClient.Username && DateTime.Parse(Item.SubItems[1].Text).Date == selectedDay)
                {
                    MessageBox.Show($"You already have a shift on {selectedDay.ToShortDateString()}.");
                    return;
                }
            }

            // Get selected date and time from time DateTimePicker
            DateTime selectedStartTime = dateTimePickerTime.Value;

            // Create end time by adding a duration (e.g., 8 hours) to the start time    
            DateTime selectedEndTime = dateTimePickerEndTime.Value;

            if (selectedEndTime.TimeOfDay > TimeSpan.FromHours(23) && selectedEndTime.TimeOfDay <= TimeSpan.FromHours(6)) //to avoid messagebox bug
            {
                MessageBox.Show("Shift end time cannot be after 23:00 and before 06:00.");
                return;
            }

            if (selectedStartTime.TimeOfDay < openingTime || selectedEndTime.TimeOfDay > closingTime)
            {
                MessageBox.Show("Shift times must be within restaurant opening hours (6:00 AM - 11:00 AM).");
                return;
            }

            TimeSpan shiftDuration = selectedEndTime - selectedStartTime;

            if (shiftDuration.TotalHours < 6 || shiftDuration.TotalHours > 11)
            {
                MessageBox.Show("Shift duration must be between 6 and 11 hours.");
                return;
            }

            // Check if the user has reached the maximum limit of 5 shifts
            int userShiftCount = shiftsList.Count(shift => shift.UserName == currentClient.Username);
            if (userShiftCount >= 5)
            {
                MessageBox.Show("User has reached the maximum limit of 5 shifts.");
                return;
            }




            ShiftData newShift = new ShiftData
            {
                UserName = currentClient.Username,
                Day = selectedDay,
                StartTime = selectedStartTime,
                EndTime = selectedEndTime
            };

            shiftsList.Add(newShift);

            // Increment the user's ShiftCount property
            newShift.ShiftCount++;

            ListViewItem item = new ListViewItem(new[]
            {
    newShift.UserName,
    newShift.Day.ToShortDateString(),
    newShift.StartTime.ToShortTimeString(),
    newShift.EndTime.ToShortTimeString()
});

            listViewShifts.Items.Add(item);
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Get selected items in the ListView
            foreach (ListViewItem selectedItem in listViewShifts.SelectedItems)
            {
                string ListViewUserName = selectedItem.SubItems[0].Text;

                // Find the selected shift and delete it
#pragma warning disable CS8600 // Avoid green text
                ShiftData shiftToRemove = shiftsList.Find(shift => shift.UserName == ListViewUserName &&
                shift.Day.ToShortDateString() == selectedItem.SubItems[1].Text &&
                shift.StartTime.ToShortTimeString() == selectedItem.SubItems[2].Text &&
                shift.EndTime.ToShortTimeString() == selectedItem.SubItems[3].Text);
#pragma warning restore CS8600 // Avoid green text

                if (shiftToRemove != null)
                {
                    shiftsList.Remove(shiftToRemove);
                    shiftToRemove.ShiftCount--;
                }

                // Remove the selected item from the ListView
                listViewShifts.Items.Remove(selectedItem);
            }
        }

        private void ClearShiftButton_Click(object sender, EventArgs e)
        {
            // Clear all items from the ListView and reset ShiftCount for each shift
            foreach (ShiftData shift in shiftsList)
            {
                shift.ShiftCount = 0; // remove shift counter
            }
            shiftsList.Clear();
            listViewShifts.Items.Clear();
        }


        private void STAFFAREA_Load(object sender, EventArgs e)
        {
            // Dock panels automatically
            ManagePanel.Dock = DockStyle.Fill;
            ShiftsPanel.Dock = DockStyle.Fill;
            CurrentOrdersPanel.Dock = DockStyle.Fill;

            int checklevel = currentClient.AccessBox();
            if (checklevel >= 5) ManageButton.Visible = true;

            if (File.Exists("shiftsData.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<ShiftData>));

                using (FileStream fs = new FileStream("shiftsData.xml", FileMode.Open))
                {
                    shiftsList = (List<ShiftData>)serializer.Deserialize(fs);
                }
            }

            ApplyPictureBoxAnimation(this);

        }

        private void ApplyPictureBoxAnimation(STAFFAREA control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is PictureBox pictureBox)
                {
                    LoginSignUp.AnimatePictureBox(pictureBox);
                }
            }
        }
        private void ShiftSubmit_Click(object sender, EventArgs e)
        {
            ShiftsPanel.Visible = true;
            PopulateShiftsListView();
        }


        private void ShiftPanelReturn_Click(object sender, EventArgs e)
        {
            ShiftsPanel.Visible = false;
        }

        //Manage Employee Logic:
        private void ManageButton_Click(object sender, EventArgs e)
        {
            // Set data source
            dataGridView1.DataSource = null;

            int checklevel = currentClient.AccessBox();

            if (checklevel == 5)
            {
                // Filter data for Managers (AccessLevel >= 3 and AccessLevel <= 4)
                var filteredUsers = DataManager.Users.Where(user => user.AccessLevel >= 3 && user.AccessLevel <= 4).ToList();
                dataGridView1.DataSource = filteredUsers;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Disable DataGridView editing for Managers
                dataGridView1.ReadOnly = true;
            }
            else
            {
                // Display all data for Admin users
                dataGridView1.DataSource = DataManager.Users.Where(user => user.AccessLevel != 6).ToList();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Enable DataGridView editing for Admins
                dataGridView1.ReadOnly = false;
            }

            ManagePanel.Visible = true;
        }

        private void FireButtonManage_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected user or employee
                Customer selectedUser = (Customer)dataGridView1.SelectedRows[0].DataBoundItem;

                // Remove the selected user or employee from the DataManager.Users list
                DataManager.Users.Remove(selectedUser);

                // Apply the same filtering logic to display the updated list
                dataGridView1.DataSource = null;

                int checklevel = currentClient.AccessBox();
                if (checklevel == 5) // Manager level
                {
                    // Display filtered data for Manager
                    dataGridView1.DataSource = DataManager.Users.Where(user => user.AccessLevel >= 3 && user.AccessLevel <= 4).ToList();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else if (checklevel == 6) // Admin level
                {
                    // Display all data for Admin
                    dataGridView1.DataSource = DataManager.Users.Where(user => user.AccessLevel != 6).ToList();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                MessageBox.Show($"User/Employee '{selectedUser.Username}' has been fired.", "Fired", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a user/employee to fire.", "Select User/Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ReturnFromFirePanel_Click(object sender, EventArgs e)
        {
            ManagePanel.Visible = false;
        }

        private void CurrentOrdersButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the OrderMenu form
            using (OrderMenu orderMenuForm = new OrderMenu())
            {
                // Perform any actions or logic you need in the OrderMenu form
                orderMenuForm.LoadOrdersFromXml(); // load orders from XML

                // Close the form immediately after performing the actions
                orderMenuForm.Close();
            }

            // Refresh the DataGridView and show the panel
            dataGridViewForOrders.DataSource = null;
            dataGridViewForOrders.DataSource = OrderMenu.orders; // use orders from OrderMenu
            CurrentOrdersPanel.Visible = true; // Show the panel
            dataGridViewForOrders.ReadOnly = true;

            int userAccessLevel = currentClient.AccessBox();

            if (userAccessLevel == 4)
            {
                // Display all columns for DeliveryPerson (level 4)
                dataGridViewForOrders.AutoGenerateColumns = true;
            }
            else // not level 4
            {
                foreach (DataGridViewColumn column in dataGridViewForOrders.Columns)
                {
                    if (column.DataPropertyName == "Address")
                    {
                        column.Visible = false;
                        break;
                    }
                }
            }


        }

        private void CloseOrderButton_Click(object sender, EventArgs e)
        {
            int userAccessLevel = currentClient.AccessBox();

            // Get the selected order from the DataGridView
            if (dataGridViewForOrders.SelectedRows.Count == 1)
            {
                Order selectedOrder = dataGridViewForOrders.SelectedRows[0].DataBoundItem as Order;

                // Check if the logged-in user is a DeliveryPerson (level 4)
                if (userAccessLevel == 4)
                {
                    // Only DeliveryPerson can close Delivery orders
                    if (selectedOrder.Delivery)
                    {
                        // Remove the order from the list and DataGridView
                        OrderMenu.orders.Remove(selectedOrder);
                        dataGridViewForOrders.DataSource = null;
                        dataGridViewForOrders.DataSource = OrderMenu.orders;

                        using (OrderMenu orderMenuForm = new OrderMenu())
                        {
                            // Perform any actions or logic you need in the OrderMenu form
                            orderMenuForm.SaveOrdersToXml(); // load orders from XML

                            // Close the form immediately after performing the actions
                            orderMenuForm.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Only Delivery orders can be closed by a DeliveryPerson.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Non-DeliveryPerson staff can close non-Delivery orders
                    if (!selectedOrder.Delivery)
                    {
                        // Remove the order from the list and DataGridView
                        OrderMenu.orders.Remove(selectedOrder);
                        dataGridViewForOrders.DataSource = null;
                        dataGridViewForOrders.DataSource = OrderMenu.orders;

                        using (OrderMenu orderMenuForm = new OrderMenu())
                        {
                            // Perform any actions or logic you need in the OrderMenu form
                            orderMenuForm.SaveOrdersToXml(); // load orders from XML

                            // Close the form immediately after performing the actions
                            orderMenuForm.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Delivery orders can only be closed by a DeliveryPerson.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an order to close.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReturnFromCurrOrdersButton_Click(object sender, EventArgs e)
        {
            CurrentOrdersPanel.Visible = false;
        }
    }
}
