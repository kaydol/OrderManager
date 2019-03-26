using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Domain.Core;

namespace OrderManager.Domain.Interfaces
{
    public interface ICustomer
    {
        String GetName();
        bool AddItemToCart(CItem item);
        void FinalizeOrder();
        COrder GetActiveOrder();
        String ToString();
    }

    public interface IItem
    {
        void SetDate();
        DateTime GetDate();
        bool IsEarlierThan(CItem i);
        double GetPrice();
        String GetName();
        bool HasSameName(String name);
        bool HasSameDate(DateTime time);
        bool HasSameDate(CItem i);
        String ToString();
    }

    public interface IOrder
    {
        void AddItem(CItem item);
        void RemoveItem(int index);
        CItem GetEarliestItem();
        void MarkAsPaid();
        bool IsOverdue();
        bool IsActive();
        List<CItem> GetItems();
        double GetCost();
        DateTime GetDueDate();
        DateTime GetArchivedDate();
        int GetOverdueDays();
    }

    public interface IData<T>
    {
        List<T> Get();
        void Add(T c);
        void RemoveAt(int index);
    }
}
