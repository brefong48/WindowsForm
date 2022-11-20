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
using System.IO;

namespace COMPE361FinalWindowsForm
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();                  // function for initializing the values of the form
        }

        // Instantiate the connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bfpan\OneDrive\Documents\AdminPage.mdf;Integrated Security=True;Connect Timeout=30");

        private void button_newUser_Click(object sender, EventArgs e)
        {
            // EXCEPTION HANDLING EXAMPLE
            try
            {
                // opens the connection 
                Con.Open();
                // creates a new command with a query and connection
                SqlCommand cmd = new SqlCommand("insert into UserTable values('" + IDTb.Text + "','" + fullNameTb.Text + "','" + comboBox_department.SelectedValue.ToString() + "','" + usernameTb.Text + "','" + passwordTb.Text + "','" + phoneNumberTb.Text + "')", Con);
                // calls ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
                // message box once the text is transferred to the command
                MessageBox.Show("User Successfully Added!");
                // closes the connection
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (phoneNumberTb.Text == "")           // if phone number textbox is empty, it will ask the user to enter the number
            {
                MessageBox.Show("Enter the User's Phone Number");
            }
            else
            {
                // opens the connection 
                Con.Open();
                // instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand("delete from UserTable where PhoneNumber = '" + phoneNumberTb.Text + "'", Con);
                // calls ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
                // message box once the text is transferred to the command
                MessageBox.Show("User Successfully Deleted!");
                // closes the connection
                Con.Close();
                populate();
            }
        }

        private void UserGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // select the grid view can be selected with the row by pressing the specific column and row
            IDTb.Text = UserGrid.SelectedRows[0].Cells[0].ToString();
            fullNameTb.Text = UserGrid.SelectedRows[0].Cells[1].ToString();
            comboBox_department.SelectedValue = UserGrid.SelectedRows[0].Cells[2].ToString();
            usernameTb.Text = UserGrid.SelectedRows[0].Cells[3].ToString();
            passwordTb.Text = UserGrid.SelectedRows[0].Cells[4].ToString();
            phoneNumberTb.Text = UserGrid.SelectedRows[0].Cells[5].ToString();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                // opens the connection 
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTable set ID ='" + IDTb.Text + "', FullName = '" + fullNameTb.Text + "', Department = '" + comboBox_department.SelectedValue.ToString() + "', Username = '" + usernameTb.Text + "', Password = '" + passwordTb.Text + "', PhoneNumber = '" + phoneNumberTb.Text + "'", Con);
                // creates a new command with a query and connection
                cmd.ExecuteNonQuery();
                // message box once the text is transferred to the command
                MessageBox.Show("User Successfully Updated!");
                // closes the connection
                Con.Close();
                populate();
            }
            catch
            {

            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();                 // exits the program when pressed
        }
        void populate()
        {
            try
            {
                // opens the connection 
                Con.Open();
                string Myquery = "select * from UserTable";
                // creates a new command with a query and connection
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                // command builder uses the SelectCommand object to retrieve the data 
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                // uses fill method to populate a DataSet with the results of the SelectCommand of the DataAdapter
                var ds = new DataSet();
                da.Fill(ds);
                UserGrid.DataSource = ds.Tables[0];
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
                SqlDataAdapter da = new SqlDataAdapter("select * from UserTable where Department = '" + searchDepartment.SelectedValue.ToString() + "'", Con);
                // command builder uses the SelectCommandBuilder object to retrieve a required set of data 
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                // uses fill method to populate a DataSet with the results of the SelectCommand of the DataAdapter
                var ds = new DataSet();
                da.Fill(ds);
                // gathers the data to the UserGrid source 
                UserGrid.DataSource = ds.Tables[0];
                // closes the connection
                Con.Close();
            }
            catch
            {

            }
        }

        void filldepartment()
        {
            // creates a new command with a query and connection
            SqlCommand cmd = new SqlCommand("select * from DepartmentTable", Con);
            // creates a SqlDataReader object
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
                comboBox_department.ValueMember = "Name";
                comboBox_department.DataSource = dt;
                searchDepartment.ValueMember = "Name";
                searchDepartment.DataSource = dt;
                // closes the connection
                Con.Close();
            }
            catch
            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            filldepartment();
            populate();
        }

        private void homePage_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();     // once button is clicked, the homepage will open and this page will close
            home.Show();
            this.Hide();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            // StreamWriter reads the application written in the textboxes and writes in a text file created and stored in EmployeeList
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\EmployeeList\\" + IDTb.Text + " " + fullNameTb.Text + ".txt"); // writes a separate file for each employee
            // GUI APPLICATION EXAMPLE/ATTEMPT AND READ/WRITE FILE
            sw.WriteLine(label1.Text + " " + IDTb.Text);
            sw.WriteLine(label2.Text + " " + fullNameTb.Text);
            sw.WriteLine(label4.Text + " " + usernameTb.Text);
            sw.WriteLine(label5.Text + " " + passwordTb.Text);
            // closes the file
            sw.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox_department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
