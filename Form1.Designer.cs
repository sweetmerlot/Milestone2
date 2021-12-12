
namespace InventoryTracker
{
    partial class Form1
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
            this.itemLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchFor = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.restockButton = new System.Windows.Forms.Button();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(35, 95);
            this.itemLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(59, 13);
            this.itemLabel.TabIndex = 1;
            this.itemLabel.Text = "Search By:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(65, 328);
            this.saveButton.Margin = new System.Windows.Forms.Padding(1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(61, 39);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // newButton
            // 
            this.newButton.ForeColor = System.Drawing.Color.Green;
            this.newButton.Location = new System.Drawing.Point(219, 328);
            this.newButton.Margin = new System.Windows.Forms.Padding(1);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(61, 39);
            this.newButton.TabIndex = 12;
            this.newButton.Text = "Add an Item";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // Exit
            // 
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(388, 328);
            this.Exit.Margin = new System.Windows.Forms.Padding(1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(61, 39);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search Inventory By:";
            // 
            // searchFor
            // 
            this.searchFor.Location = new System.Drawing.Point(185, 118);
            this.searchFor.Margin = new System.Windows.Forms.Padding(1);
            this.searchFor.Name = "searchFor";
            this.searchFor.Size = new System.Drawing.Size(84, 20);
            this.searchFor.TabIndex = 16;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(182, 95);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(68, 13);
            this.categoryLabel.TabIndex = 15;
            this.categoryLabel.Text = "Search Text:";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.Location = new System.Drawing.Point(183, 59);
            this.optionsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(246, 9);
            this.optionsLabel.TabIndex = 17;
            this.optionsLabel.Text = "1 = Audio  | 2 = TV |  3 = Computer |  4 = Video Games | 5 = Appliances";
            // 
            // searchButton
            // 
            this.searchButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.Location = new System.Drawing.Point(287, 119);
            this.searchButton.Margin = new System.Windows.Forms.Padding(1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(61, 19);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(38, 151);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(497, 173);
            this.itemsListBox.TabIndex = 19;
            // 
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(141, 328);
            this.restockButton.Margin = new System.Windows.Forms.Padding(1);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(61, 39);
            this.restockButton.TabIndex = 20;
            this.restockButton.Text = "Restock Item";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Items.AddRange(new object[] {
            "Item Name",
            "Item Sku"});
            this.searchByComboBox.Location = new System.Drawing.Point(38, 118);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchByComboBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(368, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 19);
            this.button1.TabIndex = 22;
            this.button1.Text = "Clear Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.ForeColor = System.Drawing.Color.Red;
            this.removeItemButton.Location = new System.Drawing.Point(300, 328);
            this.removeItemButton.Margin = new System.Windows.Forms.Padding(1);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(66, 39);
            this.removeItemButton.TabIndex = 23;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 383);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchByComboBox);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.searchFor);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.itemLabel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Inventory System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button searchButton;
        public System.Windows.Forms.TextBox searchFor;
        public System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button removeItemButton;
    }
}

