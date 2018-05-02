using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    // TODO: 1) Making use of our internal calculator, display on the screen the full order and totals
    // TODO: 2) Add VAT to the basket
    // TODO: 3) Update the code to add a discount to the basket

    class Program
    {
        static void Main(string[] args)
        {

            var basket = new Basket();
            basket.AddLineItem(new LineItem { ProductName = "A", Price = 10, units = 1 });
            basket.AddLineItem(new LineItem { ProductName = "B", Price = 20, units = 2 });

        }
    }

    public class Calc
    {
        public static int multiply(int a, string b)
        {
            return a * b;   
        }
    }

    public struct LineItem
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int units { get; set; }
    }

    public class Basket
    {
        private IEnumerable<LineItem> Lines;

        public Basket()
        {

        }
    }
}
