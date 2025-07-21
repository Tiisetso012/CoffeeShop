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
    public partial class Receipt : Form
    {
        private List<string> _cartItems;
        private decimal _totalAmount;

        public Receipt(List<string> cartItems, decimal totalAmount)
        {
            InitializeComponent();
            _cartItems = cartItems; // Store the cart items
            _totalAmount = totalAmount; // Store the total amount
        }
        public Receipt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the cart items using the static method in the Cart class
            Cart.ClearCart();  // Clear both cart items and the ListBox in Cart form

            // Clear the items in the Receipt listbox, including Order Number and Total
            listBox1.Items.Clear();  // Clear the receipt list box completely

            // Navigate back to the Home form
            ShowForm<Form1>();

            this.Close(); // Close the Receipt form
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

        private void Receipt_Load(object sender, EventArgs e)
        {
            // Display the order number
            listBox1.Items.Add("Order Number: " + Customer.OrderNumber);

            // Display items on the receipt
            foreach (var item in _cartItems)
            {
                listBox1.Items.Add(item);
            }

            // Display total amount
            listBox1.Items.Add("Total Amount: " + _totalAmount.ToString("C")); // Show the total amount paid
        }

        // Method to add items to the Receipt
        public void AddToReceipt(string item)
        {
            _cartItems.Add(item);
            listBox1.Items.Add(item);
        }
    }
}
