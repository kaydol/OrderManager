using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OrderManager.Domain.Core;

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
            String name = textBox_CreateNewCustomer.Text.Trim();

            Regex r = new Regex(@"\s+");
            name = r.Replace(name, @" ");

            if (name == "") {
                MessageBox.Show("Invalid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String coststr = textBox_ItemCost.Text.Replace('.', ',');

            double cost;
            if (!Double.TryParse(coststr, out cost)) {
                MessageBox.Show("Invalid cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cost < 0) {
                MessageBox.Show("Invalid cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            // Unique check
            foreach (Item i in MainWindowForm.assortmentData.Get())
            {
                if (i.GetName().ToLower() == name.ToLower())
                {
                    MessageBox.Show("The item with this name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            MainWindowForm.assortmentData.Add(new Item(name, cost));
            MainWindowForm.MainWindow.UpdateData(Constants.UPDATE_ASSORTMENT);
        }

        private void button_CancelNewItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
