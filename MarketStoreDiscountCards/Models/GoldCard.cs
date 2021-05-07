using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStoreDiscountCards.Models
{
    public class GoldCard : Card
    {
        const double INITIAL_DICOUNT_RATE = 2;

        double discountRate;

        public GoldCard(decimal turnover, decimal purchaseValue)
            : base(turnover, purchaseValue)
        {
            this.TurnoverForPrevMonth = turnover;
            this.PurchaseValue = purchaseValue;
        }

        public override double DiscountRate
        {
            get
            {
                discountRate = INITIAL_DICOUNT_RATE;

                int multiplier = (int)TurnoverForPrevMonth / 100;

                for (int i = 0; i < multiplier; i++)
                {
                    discountRate++;
                }

                if (discountRate > 10)
                {
                    discountRate = 10;
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
