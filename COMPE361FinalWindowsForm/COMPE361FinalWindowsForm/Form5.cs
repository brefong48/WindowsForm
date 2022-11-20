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
    public partial class Department : Form
    {
        // creates the connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bfpan\OneDrive\Documents\AdminPage.mdf;Integrated Security=True;Connect Timeout=30");

        public Department()
        {
            InitializeComponent();                  // function for initializing the values of the form
        }

        void populate()
        {
            try
            {
                // opens the connection
                Con.Open();
                // creates a new command with a query and connection
                SqlDataAdapter da = new SqlDataAdapter("select * from DepartmentTable", Con);
                // command builder uses the SelectCommand object to retrieve a required set of metadata 
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                // fill method used to populate a DataSet with the results of the SelectCommand of the DataAdapter
                var ds = new DataSet();
                da.Fill(ds);
                DepartmentGrid.DataSource = ds.Tables[0];
                // closes the connection
                Con.Close();
            }
            catch
            {

            }
        }

        private void DepartmentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // select the grid view can be selected with the row by pressing the specific column and row
            textBox_departmentID.Text = DepartmentGrid.SelectedRows[0].Cells[0].ToString();
            textBox_departmentName.Text = DepartmentGrid.SelectedRows[0].Cells[1].ToString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                // opens the connection
                Con.Open();
                // creates a new command with a query and connection
                SqlCommand cmd = new SqlCommand("insert into DepartmentTable values('" + textBox_departmentID.Text + "','" + textBox_departmentName.Text + "')", Con);
                // calls ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
                // message box once the text is transferred to the command
                MessageBox.Show("Department Successfully Added!");
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
            if (textBox_departmentName.Text == "")                          // if department name textbox is empty, it will ask the user to enter the name
            {
                MessageBox.Show("Enter the Department's Name");
            }
            else
            {
                // opens the connection
                Con.Open();
                // creates a new command with a query and connection
                SqlCommand cmd = new SqlCommand("delete from DepartmentTable where Name = '" + textBox_departmentName.Text + "'", Con);
                // calls ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
                // message box once the text is transferred to the command
                MessageBox.Show("Department Successfully Deleted!");
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
                SqlCommand cmd = new SqlCommand("update DepartmentTable set ID ='" + textBox_departmentID.Text + "', Name = '" + textBox_departmentName.Text + "'", Con);
                // calls ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
                // message box once the text is transferred to the command
                MessageBox.Show("Department Successfully Updated!");
                // closes the connection
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void homePage_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();     // once button is clicked, the homepage will open and this page will close
            home.Show();
            this.Hide();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();                 // exits the program when pressed
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox_departmentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
