using System;

namespace MiniMaxer.Library
{
    public class ProfitCalculator
    {
        private int buyPrice { get; set; }
        private int sellPrice { get; set; }
        private int maxProfit { get; set; }
        public int GetBuyPrice()
        {
            return buyPrice;
        }
        public int GetSellPrice()
        {
            return sellPrice;
        }
        public int GetMaxProfit()
        {
            return maxProfit;
        }
        
        public bool Process(int[] data)
        {
            maxProfit = 0;
            buyPrice = 0;
            sellPrice = 0;
            int numbersCount = data.Length;
            int profit = 0;

            for (int i = 0; i < numbersCount; i++) {
                for (int j = i + 1; j < numbersCount; j++)
                {
                    profit = data[j] - data[i];
                    
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                        buyPrice = data[i];
                        sellPrice = data[j];
                    }
                }
            }

            if (maxProfit == 0 && buyPrice == 0 && sellPrice == 0)
            {
                return false;
            }

            if (maxProfit <= 0) 
            {
                return false;
            }

            return true;
        }    
    }
}
