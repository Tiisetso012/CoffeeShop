using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Customer : Form
    {
        // Declare OrderNumber as a static class-level property
        public static string OrderNumber { get; private set; }
        public Customer()
        {
            InitializeComponent();
        }

        // Method to generate an order number
        private string GenerateOrderNumber()
        {
            Random random = new Random();
            return "Order#" + random.Next(1000, 9999).ToString();
        }

        // Method to validate email format (allowing letters, numbers, dots, underscores, etc.)
        private bool IsValidEmail(string email)
        {
            // Updated regex pattern for emails like "name<number>@gmail.com"
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Method to validate phone number (only digits and exactly 10 digits)
        private bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{10}$"); // Phone number should be exactly 10 digits
        }

        private void proceedbtn_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;  
            string email = emailTB.Text.Trim(); 
            string phone = phoneTB.Text; 

            // Validate the inputs
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show($"Entered email: {email}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Please enter a valid email address (e.g., name2@gmail.com).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate phone number format
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate the order number
            OrderNumber = GenerateOrderNumber();

            // Add order number to Cart and Receipt
            if (Application.OpenForms["Cart"] is Cart cartForm)
            {
                cartForm.AddToCart(OrderNumber);
            }

            if (Application.OpenForms["Receipt"] is Receipt receiptForm)
            {
                receiptForm.AddToReceipt(OrderNumber);
            }

            // Create an instance of the Home form
            Home homeForm = new Home();

            // Set the MDI parent to Form1
            homeForm.MdiParent = this.Owner as Form1; // Assuming Form1 is the owner of the Customer form

            // Show the Home form
            homeForm.Show();

            this.Close(); // Close the Customer form after proceeding

        }
    }
}
