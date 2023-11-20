using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestNov23
{
    internal class StoreFront
    {
        public static void DiusplayItems (string[][] Items)
        {
            Console.WriteLine("Welcome to our new store!");
            Console.WriteLine("Which Item would you like?");

            foreach (string[] Item in Items)
            {
                Console.WriteLine("ID:" + Item[0] + ", Name:" + Item[1] + ", Cost:" + Item[2]);
            }
            
            Console.WriteLine("To select an item please type the ID");
            string ID = Console.ReadLine();
            Console.WriteLine("How many of this item would you like?");
            Console.WriteLine("This should be a number between 1 and 99.");
            string Qty = Console.ReadLine();
            
            if ((Int32.Parse(Qty) > 0) && (Int32.Parse(Qty) < 100))
            {
                foreach (string[] Item in Items)
                {
                    if (Item[0] == ID)
                    {
                        Basket.AddItem(Item, int.Parse(Qty));
                    }
                }
            }
            else
            {
                Console.WriteLine("There appears to have been an error, please try again.");
            }
            Basket.GetBasketVal();
        }
    }
}
