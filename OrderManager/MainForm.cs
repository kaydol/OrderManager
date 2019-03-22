using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace OrderManager
{
    public partial class MainWindowForm : Form
    {
        
        static public NewCustomerForm newCustomerForm = null;
        static public NewItemForm newItemForm = null;
        static public MainWindowForm MainWindow;

        static public CustomerData customerData = new CustomerData();
        static public AssortmentData assortmentData = new AssortmentData();

        Customer selectedCustomer = null;

        public MainWindowForm()
        {
            MainWindow = this;
            InitializeComponent();
        }

        public void UpdateData(int flags)
        {
            if ((flags & Constants.UPDATE_CUSTOMERS) != 0)
            {
                listBox_AllClients.Items.Clear();

                foreach (Customer c in customerData.Get()) {
                    listBox_AllClients.Items.Add(c);
                }
            }

            if ((flags & Constants.UPDATE_ASSORTMENT) != 0)
            {
                listBox_Menu.Items.Clear();

                foreach (Item c in assortmentData.Get())
                {
                    listBox_Menu.Items.Add(c);
                }
            }

            if ((flags & Constants.UPDATE_SELECTED) != 0)
            {
                textBox_ClientName.Text = "";

                treeView_ActiveOrder.Nodes.Clear();
                textBox_DueDate.Text = "";
                textBox_Cost.Text = "";

                textBox_OverdueTotal.Text = "";
                treeView_history.Nodes.Clear();

                if (selectedCustomer == null)
                    return;

                textBox_ClientName.Text = selectedCustomer.GetName();

                Order current = selectedCustomer.GetActiveOrder();
                if (current != null)
                { 
                    textBox_Cost.Text = current.GetCost().ToString();
                    textBox_DueDate.Text = current.GetDueDate().ToShortDateString();

                    // Drawing current order
                    List<Item> usedElements = new List<Item>();
                    List<Item> pool = new List<Item>();

                    foreach (Item i in current.GetItems())
                    {
                        if (usedElements.Contains(i))
                            continue;

                        usedElements.Add(i);
                        pool.Add(i);

                        foreach (Item j in current.GetItems())
                        {
                            if (i == j || usedElements.Contains(j))
                                continue;

                            if (j.HasSameDate(i))
                            {
                                pool.Add(j);
                                usedElements.Add(j);
                            }
                        }

                        TreeNode root = new TreeNode(i.GetDate().ToShortDateString());
                        treeView_ActiveOrder.Nodes.Add(root);
                        foreach (Item j in pool)
                            root.Nodes.Add(j.ToString());

                        pool.Clear();
                    }

                    treeView_ActiveOrder.ExpandAll();
                }

                // Counting overdue orders in history
                List<Order> history = selectedCustomer.GetHistory();
                int overdueTotal = 0;
                if (history != null)
                { 
                    overdueTotal = history.Count(i => i.IsOverdue());
                    
                    // Drawing history
                    foreach (Order i in history)
                    {
                        int overdueDays = i.GetOverdueDays();
                        String nodeName = i.GetArchivedDate().ToShortDateString();
                        if (overdueDays > 0)
                            nodeName += " [Overdue " + overdueDays + " days]";

                        TreeNode root = new TreeNode(nodeName);
                        treeView_history.Nodes.Add(root);
                        foreach (Item j in i.GetItems())
                            root.Nodes.Add(j.ToString());
                    }
                    //treeView_history.ExpandAll();
                }
                textBox_OverdueTotal.Text = overdueTotal.ToString();

            }
        }

        private void button_AddClient_Click(object sender, EventArgs e)
        {
            if (newCustomerForm == null)
                newCustomerForm = new NewCustomerForm();
            newCustomerForm.Show();
            newCustomerForm.Focus();
        }

        private void button_AddAssortmentItem_Click(object sender, EventArgs e)
        {
            if (newItemForm == null)
                newItemForm = new NewItemForm();
            newItemForm.Show();
            newItemForm.Focus();
        }

        private void button_RemoveClient_Click(object sender, EventArgs e)
        {
            String name = listBox_AllClients.GetItemText(listBox_AllClients.SelectedItem);

            var confirmResult = MessageBox.Show("Delete customer " + name + "?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var index = customerData.Get().FindIndex(i => i.GetName() == name);
                if (index >= 0)
                {
                    customerData.RemoveAt(index);
                    selectedCustomer = null;
                }
                
                UpdateData(Constants.UPDATE_CUSTOMERS | Constants.UPDATE_SELECTED);
            }
        }

        private void button_RemoveAssortmentItem_Click(object sender, EventArgs e)
        {
            String name = listBox_Menu.GetItemText(listBox_Menu.SelectedItem);

            var confirmResult = MessageBox.Show("Delete item " + name + "?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var index = assortmentData.Get().FindIndex(i => i.ToString() == name);
                if (index >= 0)
                {
                    assortmentData.RemoveAt(index);
                    selectedCustomer = null;
                }
                
                UpdateData(Constants.UPDATE_ASSORTMENT);
            }
        }

        private void toolStripMenuItem_LoadCustomerDB_Click(object sender, EventArgs e)
        {
            Database.LoadDialogue(ref customerData, "Customer DB (*.bincdb) | *.bincdb");
            UpdateData(Constants.UPDATE_CUSTOMERS);
        }

        private void toolStripMenuItem_SaveCustomerDB_Click(object sender, EventArgs e)
        {
            Database.SaveDialogue(customerData, "Customer DB (*.bincdb) | *.bincdb", ".bincdb");
        }

        private void toolStripMenuItem_LoadMenuDB_Click(object sender, EventArgs e)
        {
            Database.LoadDialogue(ref assortmentData, "Assortment DB (*.binadb) | *.binadb");
            UpdateData(Constants.UPDATE_ASSORTMENT);
        }

        private void toolStripMenuItem_SaveMenuDB_Click(object sender, EventArgs e)
        {
            Database.SaveDialogue(assortmentData, "Assortment DB (*.binadb) | *.binadb", ".binadb");
        }

        private void listbox_AllClients_SelectedItemChanged(object sender, EventArgs e)
        {
            String name = listBox_AllClients.GetItemText(listBox_AllClients.SelectedItem);
            foreach (Customer c in customerData.Get())
            {
                if (c.GetName() == name) {
                    selectedCustomer = c;
                    break;
                }
            }

            UpdateData(Constants.UPDATE_SELECTED);
        }

        private void button_AddToActiveOrder_Click(object sender, EventArgs e)
        {
            String name = listBox_Menu.GetItemText(listBox_Menu.SelectedItem);
            Item selectedItem = null;
            foreach (Item c in assortmentData.Get())
            {
                if (c.ToString() == name)
                {
                    selectedItem = c;
                    break;
                }
            }

            bool success = true;
            if (selectedCustomer != null && selectedItem != null)
                success = selectedCustomer.AddItemToCart(selectedItem);

            if (!success)
                MessageBox.Show("This order is overdue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            UpdateData(Constants.UPDATE_SELECTED);
        }

        private void button_MoveOrderToHistory_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
                return;
            selectedCustomer.FinalizeOrder();
            UpdateData(Constants.UPDATE_SELECTED);
        }
    }

    public static class Constants
    {
        public static int UPDATE_CUSTOMERS = 2;
        public static int UPDATE_ASSORTMENT = 4;
        public static int UPDATE_SELECTED = 8;
    }
}
