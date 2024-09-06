int MaxProfit(int[] prices)
{
    var profit = 0;
    var i = 0;

    while (i < prices.Length - 1)
    {
        // buy
        var buy = prices[i];
        while (i < prices.Length - 1 && prices[i] > prices[i + 1])
        {
            i++;
            buy = prices[i];
        }

        // sell
        var sell = prices[i];
        while (i < prices.Length - 1 && prices[i] <= prices[i + 1])
        {
            i++;
            sell = prices[i];
        }

        profit += sell - buy;
    }
    return profit;
}

var a = MaxProfit(new int[] { 2, 1, 2, 0, 1 });