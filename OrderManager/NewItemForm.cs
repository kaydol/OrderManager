using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderManager
{
    public partial class NewItemForm : Form
    {
        public NewItemForm()
        {
            InitializeComponent();
            this.FormClosed += OnFormClosed;
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            this.Dispose();
            MainWindowForm.newItemForm = null;
        }

        private void button_CreateNewItem_Click(object sender, EventArgs e)
        {
            List<Item> link = MainWindowForm.assortmentData.data;
            if (link == null)
            {
                link = new List<Item>();
                MainWindowForm.assortmentData.data = link;
            }

            String name = textBox_CreateNewCustomer.Text;
            double cost;

            if (!Double.TryParse(textBox_ItemCost.Text, out cost)) {
                MessageBox.Show("Invalid cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cost < 0) {
                MessageBox.Show("Invalid cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            // Unique check
            foreach (Item i in link)
            {
                if (i.HasSameName(name))
                {
                    MessageBox.Show("The item with this name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            link.Add(new Item(name, cost));
            MainWindowForm.MainWindow.UpdateData(Constants.UPDATE_ASSORTMENT);
        }

        private void button_CancelNewItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
