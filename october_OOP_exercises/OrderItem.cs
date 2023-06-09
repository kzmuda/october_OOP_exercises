﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace october_OOP_exercises
{
    public class OrderItem  //linijka na paragonie: cena jednostkowa i wartośc i ilośc i nazwa produktu
    {
         private string productName;
         private decimal price;
         protected int quantity;

        public OrderItem(string productName , decimal price, int quantity)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return $"{productName} - {quantity}*{price} - {GetValue()}";
        }

        public virtual decimal GetValue()
        {
            return quantity * price;
        }
    }
}
