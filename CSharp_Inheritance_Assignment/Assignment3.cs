using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment
{
    class Order
    {
        public int OrderId { get; set; }
        public double OrderAmount { get; set; }

        public virtual void CalculateShippingCost()
        {
            Console.WriteLine($"Order {OrderId}: Shipping = 50");
        }
    }

    class StandardOrder : Order
    {
        public override void CalculateShippingCost() => Console.WriteLine($"Order {OrderId}: Shipping = 50");
    }

    class ExpressOrder : Order
    {
        public override void CalculateShippingCost() => Console.WriteLine($"Order {OrderId}: Shipping = 100");
    }

    class InternationalOrder : Order
    {
        public override void CalculateShippingCost() => Console.WriteLine($"Order {OrderId}: Shipping = 500");
    }

    internal class Assignment3
    {
        static void Main()
        {
            List<Order> orders = new List<Order>
            {
                new StandardOrder{OrderId=101},
                new ExpressOrder{OrderId=102},
                new InternationalOrder{OrderId=103}
            };

            foreach (var o in orders)
                o.CalculateShippingCost(); 
        }
    }
}
  
