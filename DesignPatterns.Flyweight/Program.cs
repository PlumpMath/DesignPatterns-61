using System;
using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    /// <summary>
    /// The flyweight pattern represents a shared object that can be used in multiple contexts simultaneously.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var currencyDenominations = new int[] { 1, 2, 5, 10, 20, 50, 100 };
            var currencyToMoneyType = new Dictionary<int, MoneyType>(){
            };
            var moneyFactory = new MoneyFactory();
            var random = new Random();
            for (int i = 0; i < 20; i++)
            {
                IMoney moneyObject;
                var currencyDisplayValue = currencyDenominations[random.Next(0, currencyDenominations.Length)];
                if (currencyDisplayValue <= 5)
                {
                    moneyObject = moneyFactory.GetMoneyToDisplay(MoneyType.Metallic);
                }
                else
                {
                    moneyObject = moneyFactory.GetMoneyToDisplay(MoneyType.Paper);
                }

                moneyObject.DisplayMoneyFalling(currencyDisplayValue);
            }

            Console.ReadLine();
        }
    }
}
