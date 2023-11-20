using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodingTestNov23
{
    public class CodingTestNov24
    {
        static void Main()
        {
            bool decision = true;
            string[][] Items = new string[][] { new string[] { "1", "Apple", "6.50" },
                                                new string[] { "2", "Pear", "4.56" },
                                                new string[] { "3", "Banana", "3.89"},
                                                new string[] { "4", "Strawberry", "10.47"}};
            while (decision == true)
            {
                Console.WriteLine("Please enter the number of if you would like to:");
                Console.WriteLine("1) Continue shopping,");
                Console.WriteLine("2) Checkout,");
                Console.WriteLine("0) Exit");
                
                string Choice = Console.ReadLine();

                switch (Choice)
                {
                    case "1":
                        StoreFront.DiusplayItems(Items);
                        break;
                    case "2":
                        Checkout.Checkoutitems(Basket.returnBasket());
                        break;
                    case "0":
                        decision = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }
    }
}
