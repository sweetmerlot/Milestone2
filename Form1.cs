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
               
        private void newButton_Click(object sender, EventArgs e)
        {
            //open the new form dialog
            NewItemForm newItemForm = new NewItemForm(this);
            newItemForm.ShowDialog();     
            
            //itemsListBox.Items.Add(new ListViewItem(new string[] { itemName, itemSku, itemDescription, itemPrice.ToString(), itemCategory.ToString() }));
                        
        }
        public void RefreshList()
        {
            itemsListBox.Items.Clear();
            List<InventoryItemEntry> addTheseItems = InventoryManager.GetItems();
            foreach(InventoryItemEntry toList in addTheseItems)
            {
                itemsListBox.Items.Add(toList);
            }
            this.Refresh();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            Restock_Item restockForm = new Restock_Item(this);
            restockForm.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchByComboBox.SelectedItem == "Item Name")
            {
                itemsListBox.Items.Clear();
                List<InventoryItemEntry> foundItems = InventoryManager.SearchItemByName(searchFor.Text);
                for(int i = 0; i < foundItems.Count; i++)
                {
                    itemsListBox.Items.Add(foundItems[i]);
                }

            }
            if (searchByComboBox.SelectedItem == "Item Sku")
            {
                itemsListBox.Items.Clear();
                List<InventoryItemEntry> foundItems = InventoryManager.SearchItemBySku(searchFor.Text);
                for (int i = 0; i < foundItems.Count; i++)
                {
                    itemsListBox.Items.Add(foundItems[i]);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemsListBox.Items.Clear();
            RefreshList();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            InventoryItemEntry itemToRemove = (InventoryItemEntry)itemsListBox.SelectedItem;
            InventoryManager.RemoveItem(itemToRemove.Item.Sku);
            RefreshList();
        }
    }
    
}

