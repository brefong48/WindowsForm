
namespace COMPE361FinalWindowsForm
{
    partial class Category
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
            this.textBox_categoryName = new System.Windows.Forms.TextBox();
            this.categoryName = new System.Windows.Forms.Label();
            this.textBox_categoryID = new System.Windows.Forms.TextBox();
            this.categoryID = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.CategoryGrid = new System.Windows.Forms.DataGridView();
            this.button_Exit = new System.Windows.Forms.Button();
            this.homePage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_categoryName
            // 
            this.textBox_categoryName.Location = new System.Drawing.Point(91, 254);
            this.textBox_categoryName.Name = "textBox_categoryName";
            this.textBox_categoryName.Size = new System.Drawing.Size(416, 38);
            this.textBox_categoryName.TabIndex = 15;
            // 
            // categoryName
            // 
            this.categoryName.AutoSize = true;
            this.categoryName.Location = new System.Drawing.Point(85, 219);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(212, 32);
            this.categoryName.TabIndex = 14;
            this.categoryName.Text = "Category Name";
            // 
            // textBox_categoryID
            // 
            this.textBox_categoryID.Location = new System.Drawing.Point(91, 162);
            this.textBox_categoryID.Name = "textBox_categoryID";
            this.textBox_categoryID.Size = new System.Drawing.Size(416, 38);
            this.textBox_categoryID.TabIndex = 13;
            this.textBox_categoryID.TextChanged += new System.EventHandler(this.textBox_categoryID_TextChanged);
            // 
            // categoryID
            // 
            this.categoryID.AutoSize = true;
            this.categoryID.Location = new System.Drawing.Point(85, 127);
            this.categoryID.Name = "categoryID";
            this.categoryID.Size = new System.Drawing.Size(164, 32);
            this.categoryID.TabIndex = 12;
            this.categoryID.Text = "Category ID";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(408, 338);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(148, 58);
            this.button_edit.TabIndex = 29;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.AutoSize = true;
            this.button_delete.Location = new System.Drawing.Point(226, 338);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(148, 58);
            this.button_delete.TabIndex = 28;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(45, 338);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(148, 58);
            this.button_add.TabIndex = 27;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // CategoryGrid
            // 
            this.CategoryGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CategoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryGrid.Location = new System.Drawing.Point(587, 28);
            this.CategoryGrid.Name = "CategoryGrid";
            this.CategoryGrid.RowHeadersWidth = 102;
            this.CategoryGrid.RowTemplate.Height = 40;
            this.CategoryGrid.Size = new System.Drawing.Size(799, 519);
            this.CategoryGrid.TabIndex = 30;
            this.CategoryGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGrid_CellContentClick);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(1191, 563);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(195, 84);
            this.button_Exit.TabIndex = 31;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // homePage
            // 
            this.homePage.Location = new System.Drawing.Point(194, 551);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(231, 86);
            this.homePage.TabIndex = 32;
            this.homePage.Text = "Homepage";
            this.homePage.UseVisualStyleBackColor = true;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 670);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.CategoryGrid);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_categoryName);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.textBox_categoryID);
            this.Controls.Add(this.categoryID);
            this.Name = "Category";
            this.Text = "Category Page";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_categoryName;
        private System.Windows.Forms.Label categoryName;
        private System.Windows.Forms.TextBox textBox_categoryID;
        private System.Windows.Forms.Label categoryID;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView CategoryGrid;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button homePage;
    }
}