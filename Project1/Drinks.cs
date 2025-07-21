using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/***** TT MMOLA 37629905, TB MOTSIRI 29998360, H MALULEKE 38549654, BJ KHALI 42579759 ****/
/***** T GEZANI 32489676, M CINDI 30773954 & Z MAKWARELA   ****/
namespace Project1
{
    public partial class Drinks : Form
    {
        public static string Tea { get; internal set; }
        public static string Coffee { get; internal set; }

        public Drinks()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeelteCafDB.mdf;Integrated Security=True;";
        private void Drinks_Load(object sender, EventArgs e)
        {
            rdb_coffee.Checked = false;
            rdb_tea.Checked = false;
        }

        private void rdb_coffee_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_coffee.Checked)
            {
                grb_Coffee.Visible = true;
                rdb_tea.Checked = false;
                grb_Tea.Visible = false;

                string type = "Coffee";
                string query = "SELECT Name FROM Drinks WHERE Type LIKE '%" + type + "%'";
                lst_Coffee.Items.Clear();
                try
                {
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand(query, cnn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            lst_Coffee.Items.Add(reader.GetValue(0));
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void rdb_tea_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_tea.Checked)
            {
                grb_Tea.Visible = true;
                rdb_coffee.Checked = false;
                grb_Coffee.Visible = false;

                string type = "Tea";
                string query = "SELECT Name FROM Drinks WHERE Type LIKE '%" + type + "%'";
                lst_Tea.Items.Clear();
                try
                {
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand(query, cnn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            lst_Tea.Items.Add(reader.GetValue(0));
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (lst_Tea.SelectedItem != null)
            {
                string selectedTea = lst_Tea.SelectedItem.ToString();
                Cart.CartItems.Add(selectedTea); // Add the tea to the shared cart list
                MessageBox.Show("Tea added to cart");

                // Update Cart form if it is open
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Cart cartForm)
                    {
                        cartForm.UpdateCartItems();
                    }
                }
            }
            else if (lst_Coffee.SelectedItem != null)
            {
                string selectedCoffee = lst_Coffee.SelectedItem.ToString();
                Cart.CartItems.Add(selectedCoffee); // Add the coffee to the shared cart list
                MessageBox.Show("Coffee added to cart");

                // Update Cart form if it is open
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Cart cartForm)
                    {
                        cartForm.UpdateCartItems();
                    }
                } 
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void homeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
