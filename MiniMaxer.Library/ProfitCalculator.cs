using System;

namespace MiniMaxer.Library
{
    public class ProfitCalculator
    {
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int MaxProfit { get; set; }
        public bool Process(int[] data)
        {
            MaxProfit = 0;
            BuyPrice = 0;
            SellPrice = 0;
            int numbersCount = data.Length;
            int profit = 0;

            for (int i = 0; i < numbersCount; i++) {
                for (int j = i + 1; j < numbersCount; j++)
                {
                    profit = data[j] - data[i];
                    
                    if (profit > MaxProfit)
                    {
                        MaxProfit = profit;
                        BuyPrice = data[i];
                        SellPrice = data[j];
                    }
                }
            }

            if (MaxProfit == 0 && BuyPrice == 0 && SellPrice == 0)
            {
                return false;
            }

            return true;
        }    
    }
}
