namespace MarketStoreDiscountCards.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Engine
    {
        public static void Run()
        {
            PayDesk payDesk = new PayDesk();

            string input = Console.ReadLine();

            List<string> arguments = input.Split(' ').ToList();

            string command = arguments[0];
            arguments.Skip(1).ToList();

            if (command == "Create")
            {
                PayDesk.CreateCard(arguments);
            }

            PayDesk.PrintPurchaseValue();

            PayDesk.PrintDiscountRate();

            PayDesk.PrintDiscount();

            PayDesk.PrintDiscountedPurchaseValue();
        }
    }
}
