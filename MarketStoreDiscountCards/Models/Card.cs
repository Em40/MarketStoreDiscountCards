namespace MarketStoreDiscountCards.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Card
    {
        public Card(decimal turnover, decimal purchaseValue)
        {
            this.TurnoverForPrevMonth = turnover;
            this.PurchaseValue = purchaseValue;
        }

        public abstract double DiscountRate { get; set; }

        public abstract decimal TurnoverForPrevMonth { get; set; }

        public abstract decimal PurchaseValue { get; set; }
    }
}
