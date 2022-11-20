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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                  // function for initializing the values of the form
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creates the connection
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bfpan\OneDrive\Documents\AdminPage.mdf;Integrated Security=True;Connect Timeout=30");
            // opens the connection
            Con.Open();
            // pass the connection to a command object
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserTable where Username = '" + textBox_Username.Text + "' and Password = '" + textBox_Password + "'", Con);
            // uses the connection to open the datatable
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)                  // if datatable object meets with the username and password from the row, it will close and open the homepage
            {
                Homepage home = new Homepage();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");  // else it will provide this message box
            }
            // closes the connection 
            Con.Close(); 
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox_Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Show_Hide.Checked == true)                  // if the checkbox is clicked, it will show the password
            {
                textBox_Password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Password.UseSystemPasswordChar = true;      // if it hits again, it will hide the password
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)        // once the button is clicked, the textbox will be cleared
        {
            textBox_Username.Text = "";
            textBox_Password.Text = "";
        }
    }
}
