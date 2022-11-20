
namespace COMPE361FinalWindowsForm
{
    partial class Homepage
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
            this.button_adminPage = new System.Windows.Forms.Button();
            this.button_inventory = new System.Windows.Forms.Button();
            this.button_category = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_adminPage
            // 
            this.button_adminPage.Location = new System.Drawing.Point(197, 388);
            this.button_adminPage.Name = "button_adminPage";
            this.button_adminPage.Size = new System.Drawing.Size(252, 189);
            this.button_adminPage.TabIndex = 0;
            this.button_adminPage.Text = "Admin Page";
            this.button_adminPage.UseVisualStyleBackColor = true;
            this.button_adminPage.Click += new System.EventHandler(this.button_adminPage_Click);
            // 
            // button_inventory
            // 
            this.button_inventory.Location = new System.Drawing.Point(1145, 388);
            this.button_inventory.Name = "button_inventory";
            this.button_inventory.Size = new System.Drawing.Size(252, 189);
            this.button_inventory.TabIndex = 1;
            this.button_inventory.Text = "Inventory Page";
            this.button_inventory.UseVisualStyleBackColor = true;
            this.button_inventory.Click += new System.EventHandler(this.button_inventory_Click);
            // 
            // button_category
            // 
            this.button_category.Location = new System.Drawing.Point(425, 653);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(252, 189);
            this.button_category.TabIndex = 2;
            this.button_category.Text = "Category Page";
            this.button_category.UseVisualStyleBackColor = true;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(184, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1240, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to the Merchandise Homepage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(1381, 918);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(195, 84);
            this.button_Exit.TabIndex = 32;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(936, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 189);
            this.button1.TabIndex = 33;
            this.button1.Text = "Department Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1601, 1024);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_inventory);
            this.Controls.Add(this.button_adminPage);
            this.MaximumSize = new System.Drawing.Size(1633, 1112);
            this.MinimumSize = new System.Drawing.Size(1633, 1112);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_adminPage;
        private System.Windows.Forms.Button button_inventory;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button1;
    }
}