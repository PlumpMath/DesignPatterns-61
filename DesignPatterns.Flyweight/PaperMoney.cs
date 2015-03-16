using System;

namespace DesignPatterns.Flyweight
{
    public class PaperMoney : IMoney
    {
        public MoneyType MoneyType
        {
            get { return MoneyType.Paper; }
        }

        public void DisplayMoneyFalling(int moneyValue)
        {
            Console.WriteLine("Displaying a paper bill of value {0} falling from the sky", moneyValue);
        }
    }
}
