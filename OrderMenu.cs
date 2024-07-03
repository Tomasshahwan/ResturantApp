using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static EmployeeSystemLT.LoginSignUp;
using static EmployeeSystemLT.OrderMenu;
using static EmployeeSystemLT.StartWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EmployeeSystemLT
{
    public partial class OrderMenu : Form
    {
        public Customer currentClient { get; set; }
        private bool deliveryMethodSelected = false;
        public OrderMenu()
        {
            InitializeComponent();
        }

        public class Order
        {
            public string ClientsName { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public bool Delivery { get; set; } = false;
            public int TotalItems { get; set; } = 0;
            public int CheeseHamburgers { get; set; } = 0;
            public int Hamburgers { get; set; } = 0;
            public int ChickenSandwich { get; set; } = 0;
            public int Nuggets { get; set; } = 0;
            public int Fries { get; set; } = 0;
            public int Salad { get; set; } = 0;
            public int Coke { get; set; } = 0;
            public int DietCoke { get; set; } = 0;
            public int WaterBottle { get; set; } = 0;
            public int ApplePie { get; set; } = 0;
            public int PistachioIceCream { get; set; } = 0;
            public int MatchaIceCream { get; set; } = 0;

            public Order()
            {
            }

            public Order(Order other)
            {
                ClientsName = other.ClientsName;
                Address = other.Address;
                PhoneNumber = other.PhoneNumber;
                CheeseHamburgers = other.CheeseHamburgers;
                Hamburgers = other.Hamburgers;
                ChickenSandwich = other.ChickenSandwich;
                Nuggets = other.Nuggets;
                Fries = other.Fries;
                Salad = other.Salad;
                Coke = other.Coke;
                DietCoke = other.DietCoke;
                WaterBottle = other.WaterBottle;
                ApplePie = other.ApplePie;
                PistachioIceCream = other.PistachioIceCream;
                MatchaIceCream = other.MatchaIceCream;
                Delivery = other.Delivery;
                TotalItems = other.TotalItems;
            }
            public void Reset()
            {
                ClientsName = string.Empty;
                Address = string.Empty;
                PhoneNumber = string.Empty;
                CheeseHamburgers = 0;
                Hamburgers = 0;
                ChickenSandwich = 0;
                Nuggets = 0;
                Fries = 0;
                Salad = 0;
                Coke = 0;
                DietCoke = 0;
                WaterBottle = 0;
                ApplePie = 0;
                PistachioIceCream = 0;
                MatchaIceCream = 0;
                Delivery = false;
                TotalItems = 0;
            }
        }

        Order currentOrder = new Order(); //need it on repeat

        private bool PromptForBoolean(string message)
        {
            DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private double Sum = 0.0; // Declare the Sum variable

        // ...
        private double HamburgerPrice = 8.0;
        private double ChickenSandwichPrice = 6.0;
        private double NuggetsPrice = 9.0;
        private double FriesPrice = 4.0;
        private double SaladPrice = 3.0;
        private double CokePrice = 2.0;
        private double DietCokePrice = 2.0;
        private double WaterBottlePrice = 2.0;
        private double GreenIceCreamPrice = 4.0;
        private double ApplePiePrice = 3.0;

        public enum FoodItem
        {
            CheeseHamburger,
            Hamburger,
            ChickenSandwich,
            Nuggets,
            Fries,
            Salad,
            Coke,
            DietCoke,
            WaterBottle,
            ApplePie,
            PistachioIceCream,
            MatchaIceCream
        }

        private Stack<FoodItem> foodStack = new Stack<FoodItem>();
        private void UpdateSumLabel()
        {
            if (currentClient.AccessBox() >= 2)
            {
                HamburgerPrice = 8.0 * 0.8;
                ChickenSandwichPrice = 6.0 * 0.8;
                NuggetsPrice = 9.0 * 0.8;
                FriesPrice = 4.0 * 0.8;
                SaladPrice = 3.0 * 0.8;
                CokePrice = 2.0 * 0.8;
                DietCokePrice = 2.0 * 0.8;
                WaterBottlePrice = 2.0 * 0.8;
                GreenIceCreamPrice = 4.0 * 0.8;
                ApplePiePrice = 3.0 * 0.8;
            }

            Sum = 0;

            Sum += HamburgerPrice * (currentOrder.Hamburgers + currentOrder.CheeseHamburgers);
            Sum += ChickenSandwichPrice * currentOrder.ChickenSandwich;
            Sum += NuggetsPrice * currentOrder.Nuggets;
            Sum += FriesPrice * currentOrder.Fries;
            Sum += SaladPrice * currentOrder.Salad;
            Sum += CokePrice * currentOrder.Coke;
            Sum += DietCokePrice * currentOrder.DietCoke;
            Sum += WaterBottlePrice * currentOrder.WaterBottle;
            Sum += GreenIceCreamPrice * (currentOrder.PistachioIceCream + currentOrder.MatchaIceCream);
            Sum += ApplePiePrice * currentOrder.ApplePie;

            SumLabel.Text = $"Total: ${Sum:F2}";
        }
        private void HamburgerButton_Click(object sender, EventArgs e)
        {
            bool WantCheese = PromptForBoolean("Do you want cheese on your Hamburger?");

            // Update the corresponding counters based on user's choices
            if (WantCheese)
            {
                currentOrder.CheeseHamburgers++;
                foodStack.Push(FoodItem.CheeseHamburger);
            }
            else
            {
                currentOrder.Hamburgers++;
                foodStack.Push(FoodItem.Hamburger);
            }

            // Update the sum label
            UpdateSumLabel();
        }

        private void GreenIceCreamButton_Click(object sender, EventArgs e)
        {
            int checklevel = currentClient.AccessBox();
            if (checklevel == 1)
            {
                MessageBox.Show("You need to be a VIP Customer for desserts!");
                return;
            }

            bool wantsPistachio = PromptForBoolean("Do you want Pistachio Ice Cream? No for Matcha");

            int flavorType = wantsPistachio ? 0 : 1;

            // Update the corresponding counters based on user's choices
            if (flavorType == 0)
            {
                currentOrder.PistachioIceCream++;
                foodStack.Push(FoodItem.PistachioIceCream);
            }
            else
            {
                currentOrder.MatchaIceCream++;
                foodStack.Push(FoodItem.MatchaIceCream);
            }

            // Update the sum label
            UpdateSumLabel();
        }

        private void ChickenButton_Click(object sender, EventArgs e)
        {
            currentOrder.ChickenSandwich++;
            foodStack.Push(FoodItem.ChickenSandwich);

            UpdateSumLabel();
        }

        private void NuggetsButton_Click(object sender, EventArgs e)
        {
            currentOrder.Nuggets++;
            foodStack.Push(FoodItem.Nuggets);

            UpdateSumLabel();
        }

        private void FriesButton_Click(object sender, EventArgs e)
        {
            currentOrder.Fries++;
            foodStack.Push(FoodItem.Fries);

            UpdateSumLabel();
        }

        private void SaladButton_Click(object sender, EventArgs e)
        {
            currentOrder.Salad++;
            foodStack.Push(FoodItem.Salad);


            UpdateSumLabel();
        }

        private void CokeButton_Click(object sender, EventArgs e)
        {
            currentOrder.Coke++;
            foodStack.Push(FoodItem.Coke);


            UpdateSumLabel();
        }

        private void DietCokeButton_Click(object sender, EventArgs e)
        {
            currentOrder.DietCoke++;
            foodStack.Push(FoodItem.DietCoke);

            UpdateSumLabel();
        }

        private void WaterButton_Click(object sender, EventArgs e)
        {
            currentOrder.WaterBottle++;
            foodStack.Push(FoodItem.WaterBottle);
            UpdateSumLabel();
        }

        private void ApplePieButton_Click(object sender, EventArgs e)
        {
            int checklevel = currentClient.AccessBox();
            if (checklevel == 1)
            {
                MessageBox.Show("You need to be VIP Customer for desserts!");
                return;
            }
            currentOrder.ApplePie++;
            foodStack.Push(FoodItem.ApplePie);
            UpdateSumLabel();
        }

        public static List<Order> orders = new List<Order>();

        public int GetTotalItemsCount()
        {
            int totalCount = 0;

            // Calculate total hamburgers count
            int hamburgerCount = currentOrder.Hamburgers + currentOrder.CheeseHamburgers;
            totalCount += hamburgerCount;

            // Add counts of other food items
            totalCount += currentOrder.ChickenSandwich;
            totalCount += currentOrder.Nuggets;
            totalCount += currentOrder.Fries;
            totalCount += currentOrder.Salad;
            totalCount += currentOrder.Coke;
            totalCount += currentOrder.DietCoke;
            totalCount += currentOrder.WaterBottle;
            totalCount += currentOrder.ApplePie;

            // Add counts of ice cream flavors
            totalCount += currentOrder.PistachioIceCream + currentOrder.MatchaIceCream;

            return totalCount;
        }
        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            if (!deliveryMethodSelected)
            {
                MessageBox.Show("Please choose a delivery method first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            currentOrder.TotalItems = GetTotalItemsCount();
            if (currentOrder.TotalItems == 0)
            {
                MessageBox.Show("You didn't order anything! :O");
                return;
            }

            // Print the order details to the user
            PrintOrderDetails();

            DialogResult result = MessageBox.Show("Confirm your order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            // Prompt the user to confirm the order
            //  DialogResult result = MessageBox.Show("Confirm your order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                currentOrder.ClientsName = currentClient.Username;
                currentOrder.Address = currentClient.Address;
                currentOrder.PhoneNumber = currentClient.PhoneNumber;


                Order newOrder = new Order(currentOrder); // Using the copy constructor to copy all menu items
                orders.Add(newOrder);

                SaveOrdersToXml();

                // Reset all the necessary components for the next order
                currentOrder.Reset();
                UpdateSumLabel();
                foodStack.Clear();
                deliveryMethodSelected = false;

                string soundFilePath = @"C:\Users\User\source\repos\EmployeeSystemLT\Resources\McDonaldsLogoSoundEffects(HD).wav";

                using (SoundPlayer player = new SoundPlayer(soundFilePath))
                {
                    // Play the sound
                    player.Play();
                }
            }
        }
        private void PrintOrderDetails()
        {
            // Create a StringBuilder to store the order details
            StringBuilder orderDetails = new StringBuilder();
            orderDetails.AppendLine($"Total Items: {currentOrder.TotalItems}");

            // Print hamburger details
            int totalHamburgers = currentOrder.Hamburgers + currentOrder.CheeseHamburgers;
            if (totalHamburgers > 0)
            {
                orderDetails.AppendLine($"Hamburgers (Total: {totalHamburgers}):");
                orderDetails.AppendLine($"- Cheese: {currentOrder.CheeseHamburgers}");
                orderDetails.AppendLine($"- No Cheese: {currentOrder.Hamburgers}");
            }

            // Print other food item details
            if (currentOrder.ChickenSandwich > 0) orderDetails.AppendLine($"Chicken Sandwich: {currentOrder.ChickenSandwich}");
            if (currentOrder.Nuggets > 0) orderDetails.AppendLine($"Nuggets: {currentOrder.Nuggets}");
            if (currentOrder.Fries > 0) orderDetails.AppendLine($"Fries: {currentOrder.Fries}");
            if (currentOrder.Coke > 0) orderDetails.AppendLine($"Coke: {currentOrder.Coke}");
            if (currentOrder.DietCoke > 0) orderDetails.AppendLine($"Diet Coke: {currentOrder.DietCoke}");
            if (currentOrder.WaterBottle > 0) orderDetails.AppendLine($"Water Bottle: {currentOrder.WaterBottle}");
            if (currentOrder.ApplePie > 0) orderDetails.AppendLine($"Apple Pie: {currentOrder.ApplePie}");
            if (currentOrder.Salad > 0) orderDetails.AppendLine($"Salad: {currentOrder.Salad}");

            // Print ice cream details
            int totalPistachioIceCreams = currentOrder.PistachioIceCream;
            int totalMatchaIceCreams = currentOrder.MatchaIceCream;
            if (totalPistachioIceCreams > 0 || totalMatchaIceCreams > 0)
            {
                orderDetails.AppendLine($"Ice Creams (Total: {totalPistachioIceCreams + totalMatchaIceCreams}):");
                orderDetails.AppendLine($"- Pistachio Ice Cream: {totalPistachioIceCreams}");
                orderDetails.AppendLine($"- Matcha Ice Cream: {totalMatchaIceCreams}");
            }

            // Display the order details to the user
            MessageBox.Show(orderDetails.ToString(), "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RemoveLastItemButton_Click(object sender, EventArgs e)
        {
            if (foodStack.Count > 0)
            {
                // Pop the last FoodItem from the stack
                FoodItem lastFoodItem = foodStack.Pop();

                // Update the corresponding counters in currentOrder based on the popped FoodItem
                switch (lastFoodItem)
                {
                    case FoodItem.CheeseHamburger:
                        currentOrder.CheeseHamburgers--;
                        break;
                    case FoodItem.Hamburger:
                        currentOrder.Hamburgers--;
                        break;
                    case FoodItem.ChickenSandwich:
                        currentOrder.ChickenSandwich--;
                        break;
                    case FoodItem.Nuggets:
                        currentOrder.Nuggets--;
                        break;
                    case FoodItem.Fries:
                        currentOrder.Fries--;
                        break;
                    case FoodItem.Salad:
                        currentOrder.Salad--;
                        break;
                    case FoodItem.Coke:
                        currentOrder.Coke--;
                        break;
                    case FoodItem.DietCoke:
                        currentOrder.DietCoke--;
                        break;
                    case FoodItem.WaterBottle:
                        currentOrder.WaterBottle--;
                        break;
                    case FoodItem.ApplePie:
                        currentOrder.ApplePie--;
                        break;
                    case FoodItem.PistachioIceCream:
                        currentOrder.PistachioIceCream--;
                        break;
                    case FoodItem.MatchaIceCream:
                        currentOrder.MatchaIceCream--;
                        break;
                    default:
                        break;
                }


                // Update the sum label
                UpdateSumLabel();
            }
        }

        private void OrderMenu_Load(object sender, EventArgs e)
        {
            LoadOrdersFromXml();

            ApplyPictureBoxAnimation(this);
        }

        private void ApplyPictureBoxAnimation(OrderMenu control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is PictureBox pictureBox)
                {
                    LoginSignUp.AnimatePictureBox(pictureBox);
                }
            }
        }


        public void LoadOrdersFromXml()
        {
            string filePath = "orders.xml";

            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
                    orders = (List<Order>)serializer.Deserialize(fs);
                }
            }
        }

        public void SaveOrdersToXml()
        {
            string filePath = "orders.xml";

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
                serializer.Serialize(fs, orders);
            }
        }

        private void OrderMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Clean before closing
            currentOrder.Reset();
            Sum = 0;
            UpdateSumLabel();
            foodStack.Clear();
            deliveryMethodSelected = false;

            StartWindow? OGForm = Application.OpenForms["StartWindow"] as StartWindow;

            OGForm.currentClient = currentClient;


            if (OGForm != null)
            {
                OGForm.Show();
            }

        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {

            // Close the current form
            this.Close();
        }

        private void Delivery_Method_Button_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("$5 Extra For Delivery? (No for Pickup)", "Delivery or Pickup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                currentOrder.Delivery = true;
            else
                currentOrder.Delivery = false;

            deliveryMethodSelected = true;
        }
    }
}
