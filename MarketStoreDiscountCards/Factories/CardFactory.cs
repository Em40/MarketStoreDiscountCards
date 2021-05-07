namespace MarketStoreDiscountCards.Factories
{
    using MarketStoreDiscountCards.Models;

    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CardFactory
    {
        public static Card CreateCard(List<string> arguments)
        {
            string type = arguments[1];

            switch (type)
            {
                case "Bronze":
                    return new BronzeCard(decimal.Parse(arguments[2]), decimal.Parse(arguments[3]));
                case "Silver":
                    return new SilverCard(decimal.Parse(arguments[2]), decimal.Parse(arguments[3]));
                case "Gold":
                    return new GoldCard(decimal.Parse(arguments[2]), decimal.Parse(arguments[3]));
                default: throw new ArgumentNullException();
            }
        }
    }
}
