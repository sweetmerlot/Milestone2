using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTracker
{
    public partial class NewItemForm : Form
    {
        private Form1 parentForm;
        public NewItemForm(Form1 parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }
        private void NewItemForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                newItemCategory.Items.Add(i);
            }
        }
        public void addItemButton_Click(object sender, EventArgs e)
        {

            string itemName = newItemName.Text;
            string itemSku = newItemSku.Text;
            string itemDescription = newItemDescription.Text;
            decimal itemPrice = decimal.Parse(newItemPrice.Text);
            int itemCategory = (int)newItemCategory.SelectedItem;

            InventoryItem item = new InventoryItem(itemName, itemSku, itemDescription, itemPrice, itemCategory);
            InventoryManager.AddItem(item);

            parentForm.RefreshList();

            this.Close();

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

            
    }
}
