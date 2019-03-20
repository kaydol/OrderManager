﻿using System;

namespace OrderManager
{
    [Serializable]
    public class Item
    {
        double price;
        String name;
        DateTime date;

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

}
