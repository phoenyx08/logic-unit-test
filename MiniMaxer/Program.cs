using System;
using MiniMaxer.Library;
using System.Collections.Generic;

namespace MiniMaxer
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<int>();

            do {
                Console.WriteLine("Please, type values, separated by comma...");
                var input = Console.ReadLine();
                data = Helper.NormalizeInput(input);
            } while (data.Count == 0);

            int[] dataAsArray = data.ToArray();

            var profitCalculator = new ProfitCalculator();

            if (!profitCalculator.Process(dataAsArray))
            {
                Console.WriteLine("Unexpected error occured during the profit calculation");
                Environment.Exit(-1);
            }

            Console.WriteLine("Buy at {0} and sell at {1} for a maximum profit of {2}.", 
                profitCalculator.BuyPrice, 
                profitCalculator.SellPrice, 
                profitCalculator.MaxProfit
            );
            
        }
    }
}
