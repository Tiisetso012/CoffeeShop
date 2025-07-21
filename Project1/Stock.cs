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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        public string connectionStringFood = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeelteCafDB.mdf;Integrated Security=True;";
        public string connectionStringDrinks = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeelteCafDB.mdf;Integrated Security=True;";
        public SqlCommand cmd;
        public SqlDataAdapter adapter;
        public DataSet ds;
        private void Stock_Load(object sender, EventArgs e)
        {
            string query = "SELECT * from Food";

            try
            {
                SqlConnection cnn = new SqlConnection(connectionStringFood);
                cnn.Open();

                cmd = new SqlCommand(query, cnn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Food");
                dgv_Food.DataSource = ds;
                dgv_Food.DataMember = "Food";
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            
            try
            {
                SqlConnection cnn = new SqlConnection(connectionStringFood);
                cnn.Open();

                cmd = new SqlCommand(query, cnn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Food");
                cmb_Food.DisplayMember = "Type";
                cmb_Food.ValueMember = "Type";
                cmb_Food.DataSource = ds.Tables["Food"];

                cmb_Food.SelectedItem = null;
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            string query2 = "SELECT * from Drinks";
            

            try
            {
                SqlConnection cnn = new SqlConnection(connectionStringDrinks);
                cnn.Open();

                cmd = new SqlCommand(query2, cnn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Drinks");
                dgv_Drinks.DataSource = ds;
                dgv_Drinks.DataMember = "Drinks";
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            try
            {
                SqlConnection cnn = new SqlConnection(connectionStringDrinks);
                cnn.Open();

                cmd = new SqlCommand(query2, cnn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Drinks");
                cmb_Drink.DisplayMember = "Type";
                cmb_Drink.ValueMember = "Type";
                cmb_Drink.DataSource = ds.Tables["Drinks"];

                cmb_Drink.SelectedItem = null;
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_UpdateFood_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionStringFood);
            try
            {
                cnn.Open();
                string query = "INSERT INTO Food(Name, Type, Price) VALUES(@Name, @Type, @Price)";
                
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Name", txtFood.Text);
                cmd.Parameters.AddWithValue("@Type", cmb_Food.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Price", int.Parse(txtFoodPrice.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Menu Item Added Successfully!");
                cnn.Close();

                cnn.Open();
                cmd = new SqlCommand("Select * from Food", cnn);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                ds = new DataSet();
                adapter.Fill(ds, "Food");

                dgv_Food.DataSource = ds;
                dgv_Food.DataMember = "Food";
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_DelFood_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection cnn = new SqlConnection(connectionStringFood);
                cnn.Open();
                cmd = new SqlCommand("Delete from Food Where Name = '" + txtFood.Text + "'", cnn);
                adapter = new SqlDataAdapter();
                adapter.DeleteCommand = cmd;
                adapter.DeleteCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Menu Item Deleted");

                cnn.Open();
                cmd = new SqlCommand("Select * from Food", cnn);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                ds = new DataSet();
                adapter.Fill(ds, "Food");

                dgv_Food.DataSource = ds;
                dgv_Food.DataMember = "Food";
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_DelDrink_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(connectionStringDrinks);
                cnn.Open();
                cmd = new SqlCommand("Delete from Drinks Where Name = '" + txtDrink.Text + "'", cnn);
                adapter = new SqlDataAdapter();
                adapter.DeleteCommand = cmd;
                adapter.DeleteCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Menu Item Deleted");

                cnn.Open();
                cmd = new SqlCommand("Select * from Drinks", cnn);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                ds = new DataSet();
                adapter.Fill(ds, "Drinks");

                dgv_Drinks.DataSource = ds;
                dgv_Drinks.DataMember = "Drinks";
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_UpdateDrink_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionStringDrinks);
            try
            {
                cnn.Open();
                string query = "INSERT INTO Drinks(Name, Type, Price) VALUES(@Name, @Type, @Price)";

                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Name", txtDrink.Text);
                cmd.Parameters.AddWithValue("@Type", cmb_Drink.SelectedValue.ToString()); ;
                cmd.Parameters.AddWithValue("@Price", int.Parse(txtDrinkPrice.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Menu Item Added Successfully!");
                cnn.Close();

                cnn.Open();
                cmd = new SqlCommand("Select * from Drinks", cnn);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                ds = new DataSet();
                adapter.Fill(ds, "Drinks");

                dgv_Drinks.DataSource = ds;
                dgv_Drinks.DataMember = "Drinks";
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
