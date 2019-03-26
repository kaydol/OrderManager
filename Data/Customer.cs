using System;
using System.Collections.Generic;
using OrderManager.Domain.Core;
using OrderManager.Domain.Interfaces;

namespace OrderManager.Infrastructure.Data
{
    [Serializable]
    public class Customer : CCustomer, ICustomer
    {
        public Customer(String fullname, Order activeOrder = null, List<Order> history = null)
        {
            this.fullname = fullname;
            this.activeOrder = activeOrder;
            this.history = history;
        }

        public String GetName()
        {
            return this.fullname;
        }

        public bool AddItemToCart(Item item)
        {
            if (activeOrder == null)
                activeOrder = new COrder();

            if (activeOrder.IsOverdue()) // can't add items to the overdued orders
                return false;

            activeOrder.AddItem(item);
            return true;
        }

        public void FinalizeOrder()
        {
            if (activeOrder == null)
                return;

            activeOrder.MarkAsPaid();

            if (history == null)
                history = new List<Order>();

            history.Add(activeOrder);
            activeOrder = null;
        }

        public Order GetActiveOrder()
        {
            return activeOrder;
        }
        public List<Order> GetHistory()
        {
            return history;
        }

        override
        public String ToString()
        {
            return fullname;
        }

    }
}
