using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the current MDI child and return to the main form
            this.Close();
        }

        private void coffeeTeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Drinks))
                {
                    form.Activate();
                    return;
                }
            }

            Drinks newMDIChild = new Drinks();
            newMDIChild.MdiParent = this.MdiParent; // Set Form1 as the MdiParent
            newMDIChild.ClientSize = new System.Drawing.Size(800, 600); // Adjust size as needed
            newMDIChild.WindowState = System.Windows.Forms.FormWindowState.Normal; // Normal state
            newMDIChild.Show(); // Show the form without hiding the title bar
        }

        private void pastriesSandwichesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Food))
                {
                    form.Activate();
                    return;
                }
            }

            Food newMDIChild = new Food();
            newMDIChild.MdiParent = this.MdiParent; // Set Form1 as the MdiParent
            newMDIChild.ClientSize = new System.Drawing.Size(800, 600); // Adjust size as needed
            newMDIChild.WindowState = System.Windows.Forms.FormWindowState.Normal; // Normal state
            newMDIChild.Show(); // Show the form without hiding the title bar
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Cart))
                {
                    form.Activate();
                    return;
                }
            }

            Cart newMDIChild = new Cart();
            newMDIChild.MdiParent = this.MdiParent; // Set Form1 as the MdiParent
            newMDIChild.ClientSize = new System.Drawing.Size(800, 600); // Adjust size as needed
            newMDIChild.WindowState = System.Windows.Forms.FormWindowState.Normal; // Normal state
            newMDIChild.Show(); // Show the form without hiding the title bar

            // Ensure static properties are initialized before showing the Cart form
            if (string.IsNullOrEmpty(Drinks.Coffee) && string.IsNullOrEmpty(Drinks.Tea) &&
                string.IsNullOrEmpty(Food.Pastry) && string.IsNullOrEmpty(Food.Sandwich))
            {
                MessageBox.Show("Please select items before opening the cart.");
                return; // Prevent opening the Cart if no items are selected
            }
        }
    }
}
