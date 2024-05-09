using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pogice3
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> items = new Dictionary<string, decimal>()
        {
            {"Item 1", 10.00m},
            {"Item 2", 15.00m},
            {"Item 3", 20.00m}
        };
        private List<OrderItem> orderItems = new List<OrderItem>();

        public Form1()
        {
            InitializeComponent();

            // Populate dropdown list with items
            foreach (var item in items.Keys)
            {
                comboBoxItems.Items.Add(item);
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            if (numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            string selectedItem = comboBoxItems.SelectedItem.ToString();
            int quantity = (int)numericUpDownQuantity.Value;
            decimal price = items[selectedItem];
            decimal totalPrice = price * quantity;

            orderItems.Add(new OrderItem(selectedItem, quantity, price, totalPrice));

            MessageBox.Show("Item added to order.");
        }

        private void btnDisplayReceipt_Click(object sender, EventArgs e)
        {
            if (orderItems.Count == 0)
            {
                MessageBox.Show("No items in the order.");
                return;
            }

            string receipt = "Receipt:\n";

            foreach (var item in orderItems)
            {
                receipt += $"{item.ItemName} - Quantity: {item.Quantity}, Price: {item.Price:C}, Total: {item.TotalPrice:C}\n";
            }

            decimal totalOrderPrice = CalculateTotalOrderPrice();
            receipt += $"\nTotal Order Price: {totalOrderPrice:C}";

            MessageBox.Show(receipt);
        }

        private decimal CalculateTotalOrderPrice()
        {
            decimal total = 0;
            foreach (var item in orderItems)
            {
                total += item.TotalPrice;
            }
            return total;
        }
    }

    public class OrderItem
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

        public OrderItem(string itemName, int quantity, decimal price, decimal totalPrice)
        {
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
            TotalPrice = totalPrice;
        }
    }
}
