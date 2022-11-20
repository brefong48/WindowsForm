
namespace COMPE361FinalWindowsForm
{
    partial class Department
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
            this.homePage = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.DepartmentGrid = new System.Windows.Forms.DataGridView();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_departmentName = new System.Windows.Forms.TextBox();
            this.categoryName = new System.Windows.Forms.Label();
            this.textBox_departmentID = new System.Windows.Forms.TextBox();
            this.categoryID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // homePage
            // 
            this.homePage.Location = new System.Drawing.Point(179, 546);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(231, 86);
            this.homePage.TabIndex = 42;
            this.homePage.Text = "Homepage";
            this.homePage.UseVisualStyleBackColor = true;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(1176, 558);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(195, 84);
            this.button_Exit.TabIndex = 41;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // DepartmentGrid
            // 
            this.DepartmentGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DepartmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentGrid.Location = new System.Drawing.Point(572, 23);
            this.DepartmentGrid.Name = "DepartmentGrid";
            this.DepartmentGrid.RowHeadersWidth = 102;
            this.DepartmentGrid.RowTemplate.Height = 40;
            this.DepartmentGrid.Size = new System.Drawing.Size(799, 519);
            this.DepartmentGrid.TabIndex = 40;
            this.DepartmentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepartmentGrid_CellContentClick);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(393, 333);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(148, 58);
            this.button_edit.TabIndex = 39;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(211, 333);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(148, 58);
            this.button_delete.TabIndex = 38;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.AutoSize = true;
            this.button_add.Location = new System.Drawing.Point(30, 333);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(148, 58);
            this.button_add.TabIndex = 37;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_departmentName
            // 
            this.textBox_departmentName.Location = new System.Drawing.Point(76, 249);
            this.textBox_departmentName.Name = "textBox_departmentName";
            this.textBox_departmentName.Size = new System.Drawing.Size(416, 38);
            this.textBox_departmentName.TabIndex = 36;
            // 
            // categoryName
            // 
            this.categoryName.AutoSize = true;
            this.categoryName.Location = new System.Drawing.Point(70, 214);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(245, 32);
            this.categoryName.TabIndex = 35;
            this.categoryName.Text = "Department Name";
            // 
            // textBox_departmentID
            // 
            this.textBox_departmentID.Location = new System.Drawing.Point(76, 157);
            this.textBox_departmentID.Name = "textBox_departmentID";
            this.textBox_departmentID.Size = new System.Drawing.Size(416, 38);
            this.textBox_departmentID.TabIndex = 34;
            this.textBox_departmentID.TextChanged += new System.EventHandler(this.textBox_departmentID_TextChanged);
            // 
            // categoryID
            // 
            this.categoryID.AutoSize = true;
            this.categoryID.Location = new System.Drawing.Point(70, 122);
            this.categoryID.Name = "categoryID";
            this.categoryID.Size = new System.Drawing.Size(197, 32);
            this.categoryID.TabIndex = 33;
            this.categoryID.Text = "Department ID";
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1419, 660);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.DepartmentGrid);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_departmentName);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.textBox_departmentID);
            this.Controls.Add(this.categoryID);
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homePage;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.DataGridView DepartmentGrid;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_departmentName;
        private System.Windows.Forms.Label categoryName;
        private System.Windows.Forms.TextBox textBox_departmentID;
        private System.Windows.Forms.Label categoryID;
    }
}