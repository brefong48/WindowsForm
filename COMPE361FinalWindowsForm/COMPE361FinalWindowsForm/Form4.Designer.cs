
namespace COMPE361FinalWindowsForm
{
    partial class Inventory
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
            this.textBox_Material = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.Label();
            this.textBox_productNumber = new System.Windows.Forms.TextBox();
            this.productNumber = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_quanity = new System.Windows.Forms.TextBox();
            this.label_quanity = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.InventoryGrid = new System.Windows.Forms.DataGridView();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.searchCategory = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.homePage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Material
            // 
            this.textBox_Material.Location = new System.Drawing.Point(1507, 172);
            this.textBox_Material.Name = "textBox_Material";
            this.textBox_Material.Size = new System.Drawing.Size(416, 38);
            this.textBox_Material.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1501, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Material";
            // 
            // textBox_productName
            // 
            this.textBox_productName.Location = new System.Drawing.Point(283, 264);
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.Size = new System.Drawing.Size(416, 38);
            this.textBox_productName.TabIndex = 11;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(277, 229);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(195, 32);
            this.productName.TabIndex = 10;
            this.productName.Text = "Product Name";
            // 
            // textBox_productNumber
            // 
            this.textBox_productNumber.Location = new System.Drawing.Point(283, 172);
            this.textBox_productNumber.Name = "textBox_productNumber";
            this.textBox_productNumber.Size = new System.Drawing.Size(416, 38);
            this.textBox_productNumber.TabIndex = 9;
            // 
            // productNumber
            // 
            this.productNumber.AutoSize = true;
            this.productNumber.Location = new System.Drawing.Point(277, 137);
            this.productNumber.Name = "productNumber";
            this.productNumber.Size = new System.Drawing.Size(220, 32);
            this.productNumber.TabIndex = 8;
            this.productNumber.Text = "Product Number";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(1507, 263);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(416, 38);
            this.textBox_description.TabIndex = 19;
            this.textBox_description.TextChanged += new System.EventHandler(this.textBox_providerName_TextChanged);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(1501, 228);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(158, 32);
            this.label_description.TabIndex = 18;
            this.label_description.Text = "Description";
            this.label_description.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_quanity
            // 
            this.textBox_quanity.Location = new System.Drawing.Point(882, 172);
            this.textBox_quanity.Name = "textBox_quanity";
            this.textBox_quanity.Size = new System.Drawing.Size(416, 38);
            this.textBox_quanity.TabIndex = 17;
            this.textBox_quanity.TextChanged += new System.EventHandler(this.textBox_shipmentDate_TextChanged);
            // 
            // label_quanity
            // 
            this.label_quanity.AutoSize = true;
            this.label_quanity.Location = new System.Drawing.Point(876, 137);
            this.label_quanity.Name = "label_quanity";
            this.label_quanity.Size = new System.Drawing.Size(114, 32);
            this.label_quanity.TabIndex = 16;
            this.label_quanity.Text = "Quanity";
            this.label_quanity.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(882, 264);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(416, 38);
            this.textBox_price.TabIndex = 15;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(876, 229);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(80, 32);
            this.label_price.TabIndex = 14;
            this.label_price.Text = "Price";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(2004, 1301);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(171, 63);
            this.button_Exit.TabIndex = 20;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // InventoryGrid
            // 
            this.InventoryGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGrid.Location = new System.Drawing.Point(49, 528);
            this.InventoryGrid.Name = "InventoryGrid";
            this.InventoryGrid.RowHeadersWidth = 102;
            this.InventoryGrid.RowTemplate.Height = 40;
            this.InventoryGrid.Size = new System.Drawing.Size(2111, 713);
            this.InventoryGrid.TabIndex = 22;
            this.InventoryGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryGrid_CellContentClick);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(1346, 349);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(332, 58);
            this.button_edit.TabIndex = 26;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(916, 349);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(332, 58);
            this.button_delete.TabIndex = 25;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(495, 349);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(332, 58);
            this.button_add.TabIndex = 24;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(283, 69);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(356, 39);
            this.comboBox_category.TabIndex = 27;
            this.comboBox_category.Text = "Product Category";
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // searchCategory
            // 
            this.searchCategory.FormattingEnabled = true;
            this.searchCategory.Location = new System.Drawing.Point(49, 457);
            this.searchCategory.Name = "searchCategory";
            this.searchCategory.Size = new System.Drawing.Size(356, 39);
            this.searchCategory.TabIndex = 28;
            this.searchCategory.Text = "Select Category";
            this.searchCategory.SelectedIndexChanged += new System.EventHandler(this.searchCategory_SelectedIndexChanged);
            // 
            // button_search
            // 
            this.button_search.AutoSize = true;
            this.button_search.Location = new System.Drawing.Point(456, 446);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(140, 58);
            this.button_search.TabIndex = 29;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 58);
            this.button1.TabIndex = 30;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // homePage
            // 
            this.homePage.Location = new System.Drawing.Point(49, 1289);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(231, 86);
            this.homePage.TabIndex = 31;
            this.homePage.Text = "Homepage";
            this.homePage.UseVisualStyleBackColor = true;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2199, 1391);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.searchCategory);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.InventoryGrid);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.textBox_quanity);
            this.Controls.Add(this.label_quanity);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.textBox_Material);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_productName);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.textBox_productNumber);
            this.Controls.Add(this.productNumber);
            this.MaximumSize = new System.Drawing.Size(2231, 1479);
            this.MinimumSize = new System.Drawing.Size(2231, 1479);
            this.Name = "Inventory";
            this.Text = "Invertory List";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Material;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.TextBox textBox_productNumber;
        private System.Windows.Forms.Label productNumber;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox textBox_quanity;
        private System.Windows.Forms.Label label_quanity;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.DataGridView InventoryGrid;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.ComboBox searchCategory;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button homePage;
    }
}