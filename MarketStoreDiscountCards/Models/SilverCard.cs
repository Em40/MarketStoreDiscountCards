using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStoreDiscountCards.Models
{
    public class SilverCard : Card
    {
        const double INITIAL_DICOUNT_RATE = 2;

        double discountRate;

        public SilverCard(decimal turnover, decimal purchaseValue)
            :base(turnover, purchaseValue)
        {
            this.TurnoverForPrevMonth = turnover;
            this.PurchaseValue = purchaseValue;
        }

        public override double DiscountRate 
        {
            get
            {
                discountRate = INITIAL_DICOUNT_RATE;

                if (TurnoverForPrevMonth > 300)
                {
                    discountRate = 3.5;
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
