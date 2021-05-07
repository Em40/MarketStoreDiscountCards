using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStoreDiscountCards.Models
{
    public class BronzeCard : Card
    {
        const double INITIAL_DICOUNT_RATE = 0;

        double discountRate;

        public BronzeCard(decimal turnover, decimal purchaseValue)
            : base(turnover, purchaseValue)
        {
            this.TurnoverForPrevMonth = turnover;
            this.PurchaseValue = purchaseValue;
        }

        public override double DiscountRate
        {
            get
            {
                discountRate = 0;

                if (TurnoverForPrevMonth >= 100 && TurnoverForPrevMonth <= 300)
                {
                    discountRate = 1;
                }
                if (TurnoverForPrevMonth > 300)
                {
                    discountRate = 2.5;
                }
                return this.discountRate;
            }
            set
            {
                this.discountRate = value; 
            }
        }
        public override decimal TurnoverForPrevMonth { get; set; }

        public override decimal PurchaseValue { get; set; }
    }
}
