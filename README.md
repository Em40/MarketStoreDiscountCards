# MarketStoreDiscountCards
The program starts and expects to receive:

Create(a command that tells the program to create a new Card)
Bronze, Silver, Gold(type of a discount card that the user wants to create)
A number(The turnover from the previous month)
A number(The purchase value)

An example of a inputs:

Create Bronze 0 150

Create Silver 600 850

Create Gold 1500 1300

The program calculates the discount rate of each different type of cards then calculates the discount and finally calculates the final price with the discount.

Then the program prints the output as follows:

Input:
Create Bronze 0 150

Output:
Purchase value: $150.00
Discount rate: 0.0%
Discount: $0.00
Total: $150.00

Input:
Create Silver 600 850

Output:
Purchase value: $850.00
Discount rate: 3.5%
Discount: $29.75
Total: $820.25

Input:
Create Gold 1500 1300

Output:
Purchase value: $1300.00
Discount rate: 10.0%
Discount: $130.00
Total: $1170.00

After the program prints its ouput it ends.
