using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPE361FinalWindowsForm
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_adminPage_Click(object sender, EventArgs e)
        {
            Admin add = new Admin();
            add.Show();
            this.Hide();
        }

        private void button_inventory_Click(object sender, EventArgs e)
        {
            Inventory invent = new Inventory();
            invent.Show();
            this.Hide();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Department dep = new Department();
            dep.Show();
            this.Hide();
        }
    }
}
