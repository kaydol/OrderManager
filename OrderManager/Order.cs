using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    [Serializable]
    public class Order
    {
        List<Item> items = new List<Item>();
        double price = 0.0;
        DateTime overdueTime;
        DateTime payedAt;

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
            foreach (Item i in items) {
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
