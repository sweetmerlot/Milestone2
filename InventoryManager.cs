using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTracker
{
    class InventoryManager
    {        
        private static List<InventoryItemEntry> items = new List<InventoryItemEntry>();
        

        //Add a new item to the inventory manager.
        //checks to see if item already exists in the inventory

        public static void AddItem(InventoryItem item)
        {
            
            if (items.Count == 0)
            {
                items.Add(new InventoryItemEntry(item));
                return;
            }

            for (int i = 0; i < items.Count; i++)
            {
                InventoryItemEntry entry = items[i];
                if (entry.Item.Sku == item.Sku)
                {
                    Console.WriteLine("Item already exists");
                    return;
                }

            }
            items.Add(new InventoryItemEntry(item));

        }

        //Remove an item from the inventory manager.
        public static void RemoveItem(String sku)
        {
            for (int i = 0; i < items.Count; i++)
            {
                InventoryItemEntry entry = items[i];
                if (entry.Item.Sku == sku)
                {
                    items.RemoveAt(i);
                    
                }
            }
        }
        //Re-stock an item in the inventory manager.
        public static void StockItem(String sku, int change) //enter the sku and the amount to change by
        {
            for (int i = 0; i < items.Count; i++)
            {
                InventoryItemEntry entry = items[i]; //temp item storage looks for a sku match
                if (entry.Item.Sku == sku)
                {
                    if (entry.Count + change >= 0)
                    {
                        entry.Count += change;
                    }
                }
            }
        }
        //Display the items in the inventory manager.
        public static void DisplayItems()
        {
            //for (int i = 0; i < productCount; i++)
            for (int i = 0; i < items.Count; i++)
            {
                InventoryItemEntry entry = items[i];
                Console.WriteLine(entry);
            }
        }
        public static List<InventoryItemEntry> GetItems()
        {
            return items;
        }


        //Search for an item in the inventory manager by at least two criteria(name, price, quantity, etc.)
        public static List<InventoryItemEntry> SearchItemBySku(String sku)
        {
            List<InventoryItemEntry> foundItems = new List<InventoryItemEntry>();
            for (int i = 0; i < items.Count; i++)
            {
                InventoryItemEntry entry = items[i];
                if (entry.Item.Sku == sku)
                {
                    foundItems.Add(entry);
                    
                }
            }
            return foundItems;
        }
        public static List<InventoryItemEntry> SearchItemByName(String name)
        {
            List<InventoryItemEntry> foundItems = new List<InventoryItemEntry>();
            for (int i = 0; i < items.Count; i++)
            {                
                InventoryItemEntry entry = items[i];
                if (entry.Item.ItemName == name)
                {
                    foundItems.Add(entry);                    
                }
            }return foundItems;
            
        }
    }
}
