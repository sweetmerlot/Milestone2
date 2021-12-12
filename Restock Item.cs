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
    public partial class Restock_Item : Form
    {
        private Form1 parent;
        public Restock_Item(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            string skuToStock = skuRestockInput.Text;
            int stockUpdate = int.Parse(restockQuantity.Text.ToString());
            InventoryManager.StockItem(skuToStock, stockUpdate);
            parent.RefreshList();
            this.Close();
        }
    }
}
