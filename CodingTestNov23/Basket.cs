using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestNov23
{
    internal class Basket
    {
        public static List<string[]> basket = new List<string[]>();
        public static void AddItem(string[] Item, int Qty)
        {
            string[] ItemQty = new string[Item.Length+1];
            int counter = 0;
            foreach(string item in Item)
            {
                ItemQty[counter] = item;
                counter++;
            }
            basket.Add(ItemQty);
        }

        public static void RemoveItem()
        {

        }

        public static List<string[]> returnBasket ()
        {
            return basket;
        }
        public static double GetBasketVal()
        {
            int total = 0;
            foreach (string[] item in basket)
            {
                int itemtotal = Int32.Parse(item[2]) + Int32.Parse(item[3]);
                total = total + itemtotal;
            }
            Console.WriteLine(total);
            return total;
        }
    }
}
