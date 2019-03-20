using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            List<Customer> link = MainWindowForm.customerData.data;
            if (link == null)
            { 
                link = new List<Customer>();
                MainWindowForm.customerData.data = link;
            }


            String name = textBox_CreateNewCustomer.Text;

            // Unique check
            foreach (Customer c in link)
            {
                if (c.HasSameName(name))
                {
                    MessageBox.Show("Customer with this name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            
            link.Add(new Customer(textBox_CreateNewCustomer.Text));
            MainWindowForm.MainWindow.UpdateData(Constants.UPDATE_CUSTOMERS);
        }

        private void button_CancelNewCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
