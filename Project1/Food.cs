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
    public partial class Food : Form
    {
        public static string Pastry { get; set; }
        public static string Sandwich { get; set; }
        public Food()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeelteCafDB.mdf;Integrated Security=True;";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_pastry.Checked)
            {
                grb_pastry.Visible = true;
                rdb_sandwich.Checked = false;
                grb_sandwich.Visible = false;
                LoadFoodItems("Pastry", lst_pastry);
            }
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_sandwich.Checked)
            {
                grb_sandwich.Visible = true;
                rdb_pastry.Checked = false;
                grb_pastry.Visible = false;
                LoadFoodItems("Sandwich", lst_Sandwich);
            }
        }

        private void LoadFoodItems(string type, ListBox listBox)
        {
            string query = $"SELECT Name FROM Food WHERE Type LIKE '%{type}%'";
            listBox.Items.Clear();
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listBox.Items.Add(reader.GetValue(0));
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void Food_Load(object sender, EventArgs e)
        {
            rdb_pastry.Checked = false;
            rdb_sandwich.Checked = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (lst_Sandwich.SelectedItem != null)
            {
                string selectedSandwich = lst_Sandwich.SelectedItem.ToString();
                Cart.CartItems.Add(selectedSandwich); // Add the sandwich to the shared cart list
                MessageBox.Show("Sandwich added to cart");

                // Update Cart form if it is open
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Cart cartForm)
                    {
                        cartForm.UpdateCartItems();
                    }
                }
            }
            else if (lst_pastry.SelectedItem != null)
            {
                string selectedPastry = lst_pastry.SelectedItem.ToString();
                Cart.CartItems.Add(selectedPastry); // Add the pastry to the shared cart list
                MessageBox.Show("Pastry added to cart");

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
                MessageBox.Show("Please select a food item.");
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
