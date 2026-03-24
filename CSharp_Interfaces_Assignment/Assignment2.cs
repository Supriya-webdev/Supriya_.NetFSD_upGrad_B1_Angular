using System;

namespace C__Interfaces_Assingment
{
    public abstract class DailySales
    {
        protected double dailySales;

        public DailySales(double daily)
        {
            dailySales = daily;
        }

        public abstract double CalculateMonthlySales();

        public double GetDailySales() => dailySales;
    }

    public interface IAnnualSales
    {
        double CalculateAnnualSales();
    }

    class SalesReport : DailySales, IAnnualSales
    {
        public SalesReport(double daily) : base(daily) { }

        public override double CalculateMonthlySales()
        {
            return dailySales * 30; 
        }

        public double CalculateAnnualSales()
        {
            return dailySales * 30 * 12;
        }
    }

    internal class Assignment2
    {
        static void Main()
        {
            SalesReport report = new SalesReport(400);

            Console.WriteLine($"Daily Sales: Rs.{report.GetDailySales()}");
            Console.WriteLine($"Monthly Sales: Rs.{report.CalculateMonthlySales()}");
            Console.WriteLine($"Annual Sales: Rs.{report.CalculateAnnualSales()}");
        }
    }
}