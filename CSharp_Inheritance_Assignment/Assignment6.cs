using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment
{
    class Furniture
    {
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public string FurnitureType { get; set; }
        public int Qty { get; set; }
        public double TotalAmt { get; set; }
        public string PaymentMode { get; set; }

        public virtual void GetData()
        {
            Console.Write("Enter OrderId: "); OrderId = int.Parse(Console.ReadLine());
            Console.Write("Enter OrderDate: "); OrderDate = Console.ReadLine();
            Console.Write("Enter FurnitureType (Chair/Cot): "); FurnitureType = Console.ReadLine();
            Console.Write("Enter Qty: "); Qty = int.Parse(Console.ReadLine());
            Console.Write("Enter TotalAmt: "); TotalAmt = double.Parse(Console.ReadLine());
            Console.Write("Enter PaymentMode: "); PaymentMode = Console.ReadLine();
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"OrderId: {OrderId}, Date: {OrderDate}, Type: {FurnitureType}, Qty: {Qty}, Total: {TotalAmt}, Payment: {PaymentMode}");
        }
    }

    class Chair : Furniture
    {
        public string ChairType { get; set; }
        public string Purpose { get; set; }
        public string WoodType { get; set; }
        public override void GetData()
        {
            base.GetData();
            Console.Write("Enter ChairType (Wood/Steel/Plastic): "); ChairType = Console.ReadLine();
            Console.Write("Enter Purpose (Home/Office): "); Purpose = Console.ReadLine();
            if (ChairType == "Wood")
            {
                Console.Write("Enter Wood Type (Teak/Rose): "); WoodType = Console.ReadLine();
            }
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"ChairType: {ChairType}, Purpose: {Purpose}, WoodType: {WoodType}");
        }
    }

    class Cot : Furniture
    {
        public string CotType { get; set; }
        public string Capacity { get; set; }

        public override void GetData()
        {
            base.GetData();
            Console.Write("Enter CotType (Wood/Steel): "); CotType = Console.ReadLine();
            Console.Write("Enter Capacity (Single/Double): "); Capacity = Console.ReadLine();
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"CotType: {CotType}, Capacity: {Capacity}");
        }
    }

    internal class Assignment6
    {
        static void Main()
        {
            Chair chair = new Chair();
            chair.GetData();
            chair.ShowData();

            Cot cot = new Cot();
            cot.GetData();
            cot.ShowData();
        }
    }
}
  
