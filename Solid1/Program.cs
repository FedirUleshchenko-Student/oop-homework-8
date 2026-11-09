using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    //ANSWER:
    //S. - Single Responsibility
    public class Item
    {

    }

    // !!
    // ALL RETURNS ARE BLANK
    // !!
    public class Order
    {
        public int id { get; private set; }
        internal List<Item> ItemList { get; private set; }

        public void AddItem(Item item) { /*...*/ }
        public void DeleteItem(Item item) { /*...*/ }
        public double CalculateTotalSum() { /*...*/ return 0; }
    }

    public class OrderRepository
    {
        public void Save(Order order) { /*...*/ }
        public Order Load(int id) { /*...*/ return new Order(); }
        public void Update(Order order) { /*...*/ }
        public void Delete(int id) { /*...*/ }
    }

    public class OrderPrinter
    {
        public void PrintOrder(Order order) { /*...*/ }
        public void ShowOrder(Order order) { /*...*/ }
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
