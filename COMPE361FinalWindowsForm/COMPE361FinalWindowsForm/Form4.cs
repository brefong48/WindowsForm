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

namespace COMPE361FinalWindowsForm
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();                      // function for initializing the values of the form
        }

        // creates the connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bfpan\OneDrive\Documents\Inventory.mdf;Integrated Security=True;Connect Timeout=30");
        
        void fillinventory()
        {
            //query command connection
            SqlCommand cmd = new SqlCommand("select * from CategoryTable", Con);
            // data reading command object
            SqlDataReader rdr;
            try
            {
                // opens the connection
                Con.Open();
                // creates a new datatable
                DataTable dt = new DataTable();
                // adding columns with Name 
                dt.Columns.Add("Name", typeof(string));
                // calls the SqlDataReader object to the SqlCommand object to call ExecuteReader method
                rdr = cmd.ExecuteReader();
                // loads the data table from the SqlDataReader object
                dt.Load(rdr);
                // value member gets the value of Name and uses the value for the ListControl item
                //then sets the datasource for the combobox
                comboBox_category.ValueMember = "Name";
                comboBox_category.DataSource = dt;
                searchCategory.ValueMember = "Name";
                searchCategory.DataSource = dt;
                // closes the connection
                Con.Close();
            }
            catch
            {

            }
        }

       

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();                 // exits the program when pressed
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_shipmentDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_providerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            fillinventory();
            populate();
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            try
            {
                // opens the connection
                Con.Open();
                // creates a new command with a query and connection
                SqlCommand cmd = new SqlCommand("insert into InventoryTable values('" + textBox_productNumber.Text + "','" + textBox_productName.Text + "','" + textBox_quanity.Text + "','" + textBox_price.Text + "','" + textBox_Material.Text + "','" + textBox_description.Text + "', '" + comboBox_category.SelectedValue.ToString() + "')", Con);
                // calls ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
                // message box once the text is transferred to the command
                MessageBox.Show("Product Successfully Added!");
                // closes the connection
                Con.Close();
                populate();
            }
            catch
            {

            }
        }
        void populate()
        {
            try
            {
                // opens the connection 
                Con.Open();
                // creates a new command with a query and connection
                SqlDataAdapter da = new SqlDataAdapter("select * from InventoryTable", Con);
                // command builder uses the SelectCommand object to retrieve a required set of metadata 
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                // fill method used to populate a DataSet with the results of the SelectCommand of the DataAdapter
                var ds = new DataSet();
                da.Fill(ds);
                InventoryGrid.DataSource = ds.Tables[0];
                // closes the connection
                Con.Close();
            }
            catch
            {

            }
        }

        void filter()
        {
            try
            {
                // opens the connection 
                Con.Open();
                // creates a new command with a query and connection
                SqlDataAdapter da = new SqlDataAdapter("select * from InventoryTable where Category = '" + searchCategory.SelectedValue.ToString() + "'", Con);
                // command builder uses the SelectCommandBuilder object to retrieve a required set of data 
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                // fills method used to populate a DataSet with the results of the SelectCommand of the DataAdapter
                var ds = new DataSet();
                da.Fill(ds);
                // gathers the data to the UserGrid source 
                InventoryGrid.DataSource = ds.Tables[0];
                // closes the connection
                Con.Close();
            }
            catch
            {

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_productNumber.Text == "")
            {
                MessageBox.Show("Enter the Product's Number");
            }
            else
            {
                // opens the connection 
                Con.Open();
                // creates a new command with a query and connection
                SqlCommand cmd = new SqlCommand("delete from InventoryTable where Number = '" + textBox_productNumber.Text + "'", Con);
                // calls ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
                // message box once the text is transferred to the command
                MessageBox.Show("Product Successfully Deleted!");
                // closes the connection
                Con.Close();
                populate();
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                // opens the connection 
                Con.Open();
                // creates a new command with a query and connection
                SqlCommand cmd = new SqlCommand("update InventoryTable set Name = '" + textBox_productName.Text + "', Quanity = '"+ textBox_quanity.Text +"', Price = '" + textBox_price.Text + "', Material = '" + textBox_Material.Text + "', Description = '" + textBox_description.Text + "' , Category = '" + comboBox_category.SelectedValue.ToString() + "' where Number ='" + textBox_productNumber.Text + "'", Con);
                // calls ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
                // message box once the text is transferred to the command
                MessageBox.Show("Product Successfully Updated!");
                // closes the connection
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void InventoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // select the grid view can be selected with the row by pressing the specific column and row
            textBox_productNumber.Text = InventoryGrid.SelectedRows[0].Cells[0].ToString();
            textBox_productName.Text = InventoryGrid.SelectedRows[0].Cells[1].ToString();
            textBox_quanity.Text = InventoryGrid.SelectedRows[0].Cells[2].ToString();
            textBox_price.Text = InventoryGrid.SelectedRows[0].Cells[3].ToString();
            textBox_Material.Text = InventoryGrid.SelectedRows[0].Cells[4].ToString();
            textBox_description.Text = InventoryGrid.SelectedRows[0].Cells[5].ToString();
            comboBox_category.SelectedValue = InventoryGrid.SelectedRows[0].Cells[6].ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void homePage_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();     // once button is clicked, the homepage will open and this page will close
            home.Show();
            this.Hide();
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
