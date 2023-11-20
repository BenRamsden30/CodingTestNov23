namespace CodingTestNov23
{
    internal class Checkout
    {
        public static void Checkoutitems(List<string[]> Items)
        {
            Console.WriteLine("Your basket contains the following Items:");

            foreach (string[] item in Items)
            {
                Console.WriteLine("ID:" + item[0] + ", Name:" + item[1] + ", Cost:" + item[2] + ", Quantity:" + item[3]);
            }
            Console.WriteLine("for a total basket value of:");
            Basket.GetBasketVal();
            Console.WriteLine("Do you have a discount code to apply?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    WithDiscount();
                    break;
                case "2":
                    WithoutDiscount();
                    break;
                default:
                    Console.WriteLine("Invalid choice, returning to home.");
                    break;
            }
        }
        public static void WithDiscount()
        {
            Console.WriteLine("Please Insert your discount Code: ");
            string code = Console.ReadLine();


            while (checkCode(code) == false)
            {
                Console.WriteLine("Invalid Code, Please Try Again.");
            }
            Console.WriteLine("Old Basket value: ");
            double val = Basket.GetBasketVal();
            Console.WriteLine("New Value of Basket:");
            Console.WriteLine(val * 0.75);
            Pay(val *0.75);
        }

        public static void WithoutDiscount()
        {
            Console.WriteLine("No discount code applied, your basket cost is:");
            double val = Basket.GetBasketVal();
            Pay(val);
        }

        public static void Pay (double val)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Type Yes to Pay, Type No to clear basket and start again.");
                string choice = Console.ReadLine();
                if (choice == "Yes")
                {
                    flag = false;
                    Console.WriteLine("Payment Successfull. Your Order is on it's way!");
                }
                else if (choice == "No")
                {
                    Console.WriteLine("Basket Cleared, Have a good day!");
                    flag = false;
                }
            }
        }

        public static Boolean checkCode(string code)
        {
            if (code != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
