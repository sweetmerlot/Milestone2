
namespace InventoryTracker
{
    partial class NewItemForm
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
            this.newItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newItemSku = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newItemDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.newItemPrice = new System.Windows.Forms.TextBox();
            this.newItemCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // newItemName
            // 
            this.newItemName.Location = new System.Drawing.Point(31, 114);
            this.newItemName.Name = "newItemName";
            this.newItemName.Size = new System.Drawing.Size(195, 20);
            this.newItemName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Item Sku";
            // 
            // newItemSku
            // 
            this.newItemSku.Location = new System.Drawing.Point(28, 156);
            this.newItemSku.Name = "newItemSku";
            this.newItemSku.Size = new System.Drawing.Size(195, 20);
            this.newItemSku.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Item Description";
            // 
            // newItemDescription
            // 
            this.newItemDescription.Location = new System.Drawing.Point(31, 207);
            this.newItemDescription.Name = "newItemDescription";
            this.newItemDescription.Size = new System.Drawing.Size(195, 20);
            this.newItemDescription.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Item Category";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.Location = new System.Drawing.Point(29, 38);
            this.optionsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(246, 9);
            this.optionsLabel.TabIndex = 18;
            this.optionsLabel.Text = "1 = Audio  | 2 = TV |  3 = Computer |  4 = Video Games | 5 = Appliances";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(37, 296);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 19;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(139, 296);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "New Item Price";
            // 
            // newItemPrice
            // 
            this.newItemPrice.Location = new System.Drawing.Point(34, 258);
            this.newItemPrice.Name = "newItemPrice";
            this.newItemPrice.Size = new System.Drawing.Size(108, 20);
            this.newItemPrice.TabIndex = 21;
            // 
            // newItemCategory
            // 
            this.newItemCategory.FormattingEnabled = true;
            this.newItemCategory.Location = new System.Drawing.Point(31, 62);
            this.newItemCategory.Name = "newItemCategory";
            this.newItemCategory.Size = new System.Drawing.Size(121, 21);
            this.newItemCategory.TabIndex = 23;
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 366);
            this.Controls.Add(this.newItemCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newItemPrice);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newItemDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newItemSku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newItemName);
            this.Name = "NewItemForm";
            this.Text = "NewItemForm";
            this.Load += new System.EventHandler(this.NewItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox newItemName;
        public System.Windows.Forms.TextBox newItemSku;
        public System.Windows.Forms.TextBox newItemDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox newItemPrice;
        public System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ComboBox newItemCategory;
    }
}