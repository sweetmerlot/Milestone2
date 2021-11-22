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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //create an inventory item
            string itemName = itemNameInput.Text;
            string itemID = idInput.Text;
            string itemDescription = descriptionInput.Text;
            decimal itemPrice = decimal.Parse(priceInput.Text);
            int itemCategory = int.Parse(categoryInput.Text);


            InventoryItem item = new InventoryItem(itemName, itemID, itemDescription, itemPrice, itemCategory);
            MessageBox.Show(item.ShowAllItemDetails());

            
        }
    }
    
}

