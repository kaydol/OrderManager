using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OrderManager
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
            this.FormClosed += OnFormClosed;
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            this.Dispose();
            MainWindowForm.newCustomerForm = null;
        }

        private void button_CreateNewCustomer_Click(object sender, EventArgs e)
        {
            String name = textBox_CreateNewCustomer.Text.Trim();

            Regex r = new Regex(@"\s+");
            name = r.Replace(name, @" ");

            if (name == "") {
                MessageBox.Show("Invalid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Unique check
            foreach (Customer c in MainWindowForm.customerData.Get())
            {
                if (c.GetName().ToLower() == name.ToLower())
                {
                    MessageBox.Show("Customer with this name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            MainWindowForm.customerData.Add(new Customer(name));
            MainWindowForm.MainWindow.UpdateData(Constants.UPDATE_CUSTOMERS);
        }

        private void button_CancelNewCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
