using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace october_OOP_exercises
{
    internal class Order
    {
        private List<OrderItem> OrderItems = new List<OrderItem>();

        public void AddItem(OrderItem orderItem)
        { 
            OrderItems.Add(orderItem);
        }

        public Order()
        {

        }

        public Order(List<OrderItem> OrderItems)
        {
            this.OrderItems = OrderItems;
        }

        public override string ToString()
        {
            string text = "";
            //decimal sum = 0;
            foreach(var item in OrderItems) 
            {
                //Console.WriteLine(item.ToString()); //ToString -> default display
                text += item.ToString() + Environment.NewLine;
                //sum += item.GetValue();
            }
            return text + GetValue().ToString();
            
        }

        public decimal GetValue()
        {
            decimal sum = 0;
            foreach (var item in OrderItems)
            {
                sum += item.GetValue();
            }
            return sum;
        }

    }
}
