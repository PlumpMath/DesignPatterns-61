using System;

namespace DesignPatterns.Flyweight
{
    public class MetallicMoney : IMoney
    {
        public MoneyType MoneyType
        {
            get { return MoneyType.Metallic; }
        }

        public void DisplayMoneyFalling(int moneyValue)
        {
            Console.WriteLine("Displaying a gold coin of value {0} falling from the sky", moneyValue);
        }
    }
}
