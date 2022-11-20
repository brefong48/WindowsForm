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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();                  // function for initializing the values of the form
        }

        // creates the connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bfpan\OneDrive\Documents\Inventory.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                // opens the connection
                Con.Open();
                // creates a new command with a query and connection
                SqlDataAdapter da = new SqlDataAdapter("select * from CategoryTable", Con);
                // command builder uses the SelectCommand object to retrieve a required set of metadata 
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                // fill method used to populate a DataSet with the results of the SelectCommand of the DataAdapter
                var ds = new DataSet();
                da.Fill(ds);
                CategoryGrid.DataSource = ds.Tables[0];
                // closes the connection
                Con.Close();
            }
            catch
            {

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            try
            {
                // opens the connection
                Con.Open();
                // creates a new command with a query and connection
                SqlCommand cmd = new SqlCommand("insert into CategoryTable values('" + textBox_categoryID.Text + "','" + textBox_categoryName.Text + "')", Con);
                // calls ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
                // message box once the text is transferred to the command
                MessageBox.Show("Category Successfully Added!");
                // closes the connection
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_categoryName.Text == "")
            {
                MessageBox.Show("Enter the Category's Name");
            }
            else
            {
                // opens the connection
                Con.Open();
                // creates a new command with a query and connection
                SqlCommand cmd = new SqlCommand("delete from CategoryTable where Name = '" + textBox_categoryName.Text + "'", Con);
                // calls ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
                // message box once the text is transferred to the command
                MessageBox.Show("Category Successfully Deleted!");
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
                SqlCommand cmd = new SqlCommand("update CategoryTable set ID ='" + textBox_categoryID.Text + "', Name = '" + textBox_categoryName.Text + "'", Con);
                // calls ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
                // message box once the text is transferred to the command
                MessageBox.Show("Category Successfully Updated!");
                // closes the connection
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void CategoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_categoryID.Text = CategoryGrid.SelectedRows[0].Cells[0].ToString();
            textBox_categoryName.Text = CategoryGrid.SelectedRows[0].Cells[1].ToString();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();                 // exits the program when pressed
        }

        private void homePage_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();     // once button is clicked, the homepage will open and this page will close
            home.Show();
            this.Hide();
        }

        private void textBox_categoryID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
