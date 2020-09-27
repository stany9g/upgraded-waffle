# Task 3 - Tesla Stocks
1. Download *Stock.cs*
2. Implement *GetMaxProfit* method
3. Zip the *Stock.cs*
4. Ship it!

Teaching hasn't made me rich yet... so I need you to implement a super-duper algorithm for trading stocks.

To become all start stock trader, I need to know how much money I could have made yesterday If I trade Tesla stocks all day.

So I took Tesla's stock prices from yesterday and put them in an array called *stockPrices*, where:
- The indices are the time (in minutes) after trade opening time, which is 8:30 am local time.
- The values are the prices (in US dollars) of one share of Tesla stock at that time.
So if the stock cost $1000 at 9:30am, that means *stockPrices[60] = 1000*

Implement a function that takes stockPrices and returns **the best profit I could make from one purchase and one sale of one share of Tesla stock yesterday**.

For example:
```csharp
    int[] stockPrices = { 10, 7, 5, 8, 11, 9 };

    // Returns 6 (buying for $5 and selling for $11)
    GetMaxProfit(stockPrices);
```

#### Tip:
You need to buy it before you can sell it.
You can't buy and sell at the same time step. At least 1 minute has to pass.
You need at least 2 prices in input otherwise ArgumentException
