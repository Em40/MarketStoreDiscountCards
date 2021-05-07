namespace MarketStoreDiscountCards.Controller
{
    using MarketStoreDiscountCards.Factories;
    using MarketStoreDiscountCards.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PayDesk
    {
        private static Card discountcard;
        private static decimal valueOfDiscount;
        
        public static void CreateCard(List<string> arguments)
        {
            var card = CardFactory.CreateCard(arguments);
            discountcard = card;
        }
        public static void PrintPurchaseValue()
        {
            Console.WriteLine($"Purchase value: ${discountcard.PurchaseValue}");
        }
        public static void PrintDiscountRate()
        {
            Console.WriteLine($"Discount rate: {discountcard.DiscountRate}%");
        }
        public static void PrintDiscount()
        {
            decimal discount = discountcard.PurchaseValue * (decimal)discountcard.DiscountRate/100;
            valueOfDiscount = discount;
            Console.WriteLine($"Discount: ${discount}");
        }
        public static void PrintDiscountedPurchaseValue()
        {
            Console.WriteLine($"Total: ${discountcard.PurchaseValue-valueOfDiscount}");
        }
    }
}
