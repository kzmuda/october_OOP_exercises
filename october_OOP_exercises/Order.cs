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
        private string _orderTitle;
        private List<OrderItem> OrderItems = new List<OrderItem>();

        public Order(string title = "")
        {
            _orderTitle = title;
        }

        public Order(List<OrderItem> OrderItems, string title = "")
        {
            this.OrderItems = OrderItems;
            _orderTitle = title;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void SetTitle(string title)
        {
            _orderTitle = title;
        }

        public override string ToString()
        {
            string text = _orderTitle + Environment.NewLine;
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
