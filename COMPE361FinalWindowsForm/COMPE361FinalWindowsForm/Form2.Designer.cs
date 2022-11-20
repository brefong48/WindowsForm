
namespace COMPE361FinalWindowsForm
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneNumberTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IDTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_newUser = new System.Windows.Forms.Button();
            this.button_deleteUser = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.homePage = new System.Windows.Forms.Button();
            this.fullNameTb = new System.Windows.Forms.TextBox();
            this.label_fullName = new System.Windows.Forms.Label();
            this.UserGrid = new System.Windows.Forms.DataGridView();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox_department = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.searchDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(835, 153);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(416, 38);
            this.usernameTb.TabIndex = 3;
            this.usernameTb.TextChanged += new System.EventHandler(this.textBox_Username_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(829, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(1372, 61);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(416, 38);
            this.passwordTb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1366, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // phoneNumberTb
            // 
            this.phoneNumberTb.Location = new System.Drawing.Point(1372, 152);
            this.phoneNumberTb.Name = "phoneNumberTb";
            this.phoneNumberTb.Size = new System.Drawing.Size(416, 38);
            this.phoneNumberTb.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1366, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone Number";
            // 
            // IDTb
            // 
            this.IDTb.Location = new System.Drawing.Point(312, 61);
            this.IDTb.Name = "IDTb";
            this.IDTb.Size = new System.Drawing.Size(416, 38);
            this.IDTb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Number";
            // 
            // button_newUser
            // 
            this.button_newUser.Location = new System.Drawing.Point(311, 229);
            this.button_newUser.Name = "button_newUser";
            this.button_newUser.Size = new System.Drawing.Size(214, 58);
            this.button_newUser.TabIndex = 15;
            this.button_newUser.Text = "Add";
            this.button_newUser.UseVisualStyleBackColor = true;
            this.button_newUser.Click += new System.EventHandler(this.button_newUser_Click);
            // 
            // button_deleteUser
            // 
            this.button_deleteUser.Location = new System.Drawing.Point(732, 229);
            this.button_deleteUser.Name = "button_deleteUser";
            this.button_deleteUser.Size = new System.Drawing.Size(214, 58);
            this.button_deleteUser.TabIndex = 16;
            this.button_deleteUser.Text = "Delete";
            this.button_deleteUser.UseVisualStyleBackColor = true;
            this.button_deleteUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(1893, 947);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(209, 86);
            this.button_Exit.TabIndex = 18;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // homePage
            // 
            this.homePage.Location = new System.Drawing.Point(26, 947);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(231, 86);
            this.homePage.TabIndex = 19;
            this.homePage.Text = "Homepage";
            this.homePage.UseVisualStyleBackColor = true;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // fullNameTb
            // 
            this.fullNameTb.Location = new System.Drawing.Point(312, 153);
            this.fullNameTb.Name = "fullNameTb";
            this.fullNameTb.Size = new System.Drawing.Size(416, 38);
            this.fullNameTb.TabIndex = 21;
            this.fullNameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_fullName
            // 
            this.label_fullName.AutoSize = true;
            this.label_fullName.Location = new System.Drawing.Point(306, 118);
            this.label_fullName.Name = "label_fullName";
            this.label_fullName.Size = new System.Drawing.Size(144, 32);
            this.label_fullName.TabIndex = 20;
            this.label_fullName.Text = "Full Name";
            this.label_fullName.Click += new System.EventHandler(this.label7_Click);
            // 
            // UserGrid
            // 
            this.UserGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGrid.Location = new System.Drawing.Point(23, 427);
            this.UserGrid.Name = "UserGrid";
            this.UserGrid.RowHeadersWidth = 102;
            this.UserGrid.RowTemplate.Height = 40;
            this.UserGrid.Size = new System.Drawing.Size(2079, 493);
            this.UserGrid.TabIndex = 22;
            this.UserGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGrid_CellContentClick);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(1162, 229);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(214, 58);
            this.button_edit.TabIndex = 23;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(1574, 229);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(214, 58);
            this.button_print.TabIndex = 24;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(893, 596);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(854, 290);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // comboBox_department
            // 
            this.comboBox_department.FormattingEnabled = true;
            this.comboBox_department.Location = new System.Drawing.Point(835, 40);
            this.comboBox_department.Name = "comboBox_department";
            this.comboBox_department.Size = new System.Drawing.Size(416, 39);
            this.comboBox_department.TabIndex = 28;
            this.comboBox_department.Text = "Department";
            this.comboBox_department.SelectedIndexChanged += new System.EventHandler(this.comboBox_department_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 58);
            this.button1.TabIndex = 33;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(433, 348);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(140, 58);
            this.button_search.TabIndex = 32;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // searchDepartment
            // 
            this.searchDepartment.FormattingEnabled = true;
            this.searchDepartment.Location = new System.Drawing.Point(26, 359);
            this.searchDepartment.Name = "searchDepartment";
            this.searchDepartment.Size = new System.Drawing.Size(356, 39);
            this.searchDepartment.TabIndex = 31;
            this.searchDepartment.Text = "Select Department";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2128, 1062);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.searchDepartment);
            this.Controls.Add(this.comboBox_department);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.UserGrid);
            this.Controls.Add(this.fullNameTb);
            this.Controls.Add(this.label_fullName);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_deleteUser);
            this.Controls.Add(this.button_newUser);
            this.Controls.Add(this.phoneNumberTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Admin";
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneNumberTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_newUser;
        private System.Windows.Forms.Button button_deleteUser;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button homePage;
        private System.Windows.Forms.TextBox fullNameTb;
        private System.Windows.Forms.Label label_fullName;
        private System.Windows.Forms.DataGridView UserGrid;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox_department;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox searchDepartment;
    }
}