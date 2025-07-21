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
/***** TT MMOLA 37629905, TB MOTSIRI 29998360, H MALULEKE 38549654, BJ KHALI 42579759 ****/
/***** T GEZANI 32489676, M CINDI 30773954 & Z MAKWARELA   ****/
namespace Project1
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            // Validate username (letters followed by exactly 2 digits)
            if (!Regex.IsMatch(username, @"^[A-Za-z]+[0-9]{2}$"))
            {
                MessageBox.Show("Invalid username! ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password (exactly 8 digits, numbers only)
            if (!Regex.IsMatch(password, @"^\d{8}$"))
            {
                MessageBox.Show("Invalid password! ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If validation passes, show the Stock form
            Stock newMDIChild = new Stock();
            newMDIChild.Show();

            // Clear the textboxes after login
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }
    }
}
