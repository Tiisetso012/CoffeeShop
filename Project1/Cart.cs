using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/***** TT MMOLA 37629905, TB MOTSIRI 29998360, H MALULEKE 38549654, BJ KHALI 42579759 ****/
/***** T GEZANI 32489676, M CINDI 30773954 & Z MAKWARELA   ****/
namespace Project1
{
    public partial class Cart : Form
    {
        // Static list to store cart items across different forms
        public static List<string> CartItems = new List<string>();
        
        // Price dictionary for Food and Drinks
        private Dictionary<string, decimal> PriceList = new Dictionary<string, decimal>
        {
            // Food prices
            { "Apricot Danish", 45m },
            { "Chicken Sandwich", 30m },
            { "Chocolate tart", 33m },
            { "Custard tart", 33m },
            { "Egg Sandwich", 35m },
            { "Florentine tart", 40m },
            { "Grilled Cheese", 35m },
            { "Ham Sandwich", 30m },
            { "Lemon Meringue", 45m },
            { "Nutella Sandwich", 30m },
            
            // Drink prices
            { "Americano", 23m },
            { "Black tea", 20m },
            { "Caffe mocha", 25m },
            { "Cappuccino", 30m },
            { "Chamomile tea", 30m },
            { "Earl Grey", 28m },
            { "Espresso", 23m },
            { "Flat White", 25m },
            { "Green tea", 30m },
            { "Herbal tea", 28m },
            { "Latte", 30m },
            { "Rooibos", 25m }
        };

        // Calculate total amount based on items and their prices
        private decimal TotalAmount => CartItems.Sum(item => PriceList.ContainsKey(item) ? PriceList[item] : 0m);

        public Cart()
        {
            InitializeComponent();

        }

        // Method to add items to the Cart from other forms
        public void AddToCart(string item)
        {
            CartItems.Add(item);
            UpdateCartItems();
        }

        public static void ClearCart()
        {
            CartItems.Clear(); // Clear the cart items list

            // Access the Cart form if it's open and clear the listbox
            foreach (Form form in Application.OpenForms)
            {
                if (form is Cart cartForm)
                {
                    cartForm.lst_Cart.Items.Clear(); // Clear the listbox completely, including order number and total
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate payment
            if (string.IsNullOrWhiteSpace(paymentTB.Text) || !decimal.TryParse(paymentTB.Text, out decimal paymentAmount))
            {
                MessageBox.Show("Please enter a valid payment amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (paymentAmount < TotalAmount)
            {
                MessageBox.Show($"Insufficient payment. Total amount is {TotalAmount:C}.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Pass the cart items and total amount to the Receipt form
            Receipt newMDIChild = new Receipt(CartItems, TotalAmount);
            newMDIChild.Show();

            this.Close();
        }

        // Method to update the ListBox with the items from the CartItems list
        public void UpdateCartItems()
        {
            lst_Cart.Items.Clear(); // Clear the listbox before populating it
            lst_Cart.Items.Add("Order Number: " + Customer.OrderNumber); // Add order number
            foreach (var item in CartItems)
            {
                lst_Cart.Items.Add(item);
            }
            lst_Cart.Items.Add("Total Amount: " + TotalAmount.ToString("C")); // Display total amount
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            // Call the method to update the cart when the form loads
            UpdateCartItems();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowForm<Food>();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowForm<Drinks>();
        }

        private void ShowForm<T>() where T : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    return;
                }
            }
            new T().Show();
        }
    }
}
