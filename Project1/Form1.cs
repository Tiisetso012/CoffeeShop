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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pastriesAndSandwichesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
       

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                // If frmSearch is Opened, set focus to it and exit subroutine.
                if (form.GetType() == typeof(Cart))
                {

                    form.Activate();
                    return;
                }
            }

            Cart newMDIChild = new Cart();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();

            // Ensure static properties are initialized before showing the Cart form
            if (string.IsNullOrEmpty(Drinks.Coffee) && string.IsNullOrEmpty(Drinks.Tea) &&
                string.IsNullOrEmpty(Food.Pastry) && string.IsNullOrEmpty(Food.Sandwich))
            {
                MessageBox.Show("Please select items before opening the cart.");
                return; // Prevent opening the Cart if no items are selected
            }

            newMDIChild.Show();
        }

    

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                // If frmSearch is Opened, set focus to it and exit subroutine.
                if (form.GetType() == typeof(Staff))
                {

                    form.Activate();
                    return;
                }
            }

            Staff newMDIChild = new Staff();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            newMDIChild.ClientSize = new System.Drawing.Size(2000, 800);
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            newMDIChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                // If the Customer form is already opened, set focus to it
                if (form.GetType() == typeof(Customer))
                {
                    form.Activate();
                    return;
                }
            }

            // Open a new Customer form if it isn't already opened
            Customer newMDIChild = new Customer
            {
                MdiParent = this,
                ClientSize = new System.Drawing.Size(2000, 800),
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            this.WindowState = FormWindowState.Normal;
            newMDIChild.Show();

        }
    }
}
