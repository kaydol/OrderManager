using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OrderManager.Domain.Core
{
    [Serializable]
    public class Customer
    {
        String fullname;
        Order activeOrder;
        List<Order> history;

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
                activeOrder = new Order();

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

    [Serializable]
    public class Item
    {
        public double price;
        public String name;
        public DateTime date;

        public Item(String name, double price)
        {
            this.price = price;
            this.name = name;
        }

        public Item(Item anotherItem)
        {
            price = anotherItem.price;
            name = anotherItem.name;
        }

        public void SetDate()
        {
            date = DateTime.Now;
            date = new DateTime(date.Year, date.Month, date.Day);
            //date = date.AddDays(-100000);
        }
        public DateTime GetDate()
        {
            return date;
        }
        public bool IsEarlierThan(Item i)
        {
            return date.CompareTo(i.GetDate()) < 0;
        }
        public double GetPrice()
        {
            return price;
        }
        public String GetName()
        {
            return name;
        }

        public bool HasSameName(String name)
        {
            return this.name.CompareTo(name) == 0;
        }
        public bool HasSameDate(DateTime time)
        {
            return date.CompareTo(time) == 0;
        }
        public bool HasSameDate(Item i)
        {
            return date.CompareTo(i.GetDate()) == 0;
        }

        override
        public String ToString()
        {
            return name + " (" + price + ")";
        }
    }

    [Serializable]
    public class Order
    {
        public List<Item> items = new List<Item>();
        public double price = 0.0;
        public DateTime overdueTime;
        public DateTime payedAt;

        public void AddItem(Item item)
        {
            Item copy = new Item(item);
            copy.SetDate();
            items.Add(copy);
            price += item.GetPrice();

            overdueTime = GetEarliestItem().GetDate().AddDays(7);
        }

        public void RemoveItem(int index)
        {
            if (!Enumerable.Range(0, items.Count - 1).Contains(index))
                return;

            Item item = items.ElementAt(index);
            price -= item.GetPrice();

            items.RemoveAt(index);

            overdueTime = GetEarliestItem().GetDate();

        }

        // Returns the item with the earliest date of adding or null
        public Item GetEarliestItem()
        {
            if (items.Count == 0)
                return null;
            if (items.Count == 1)
                return items.ElementAt(0);

            Item min = items.ElementAt(0);
            foreach (Item i in items)
            {
                if (i.IsEarlierThan(min))
                    min = i;
            }

            return min;
        }

        public void MarkAsPaid()
        {
            payedAt = DateTime.Now;
        }

        public bool IsOverdue()
        {
            if (items.Count == 0)
                return false;

            if (payedAt == default(DateTime)) // The order was never paid for
            {
                if (GetEarliestItem().GetDate() < overdueTime)
                    return false;
            }
            else
            {
                if (overdueTime > payedAt)  // The order was paid for
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsActive()
        {
            return payedAt == default(DateTime);
        }

        public List<Item> GetItems()
        {
            return items;
        }

        public double GetCost()
        {
            return price;
        }

        public DateTime GetDueDate()
        {
            return overdueTime;
        }

        public DateTime GetArchivedDate()
        {
            return payedAt;
        }

        public int GetOverdueDays()
        {
            if (!IsOverdue())
                return 0;
            return (payedAt - overdueTime).Days;
        }
    }

    

}
