using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    public class MoneyFactory
    {
        private Dictionary<MoneyType, IMoney> moneyObjects = new Dictionary<MoneyType, IMoney>()
        {
            { MoneyType.Metallic, new MetallicMoney()},
            { MoneyType.Paper, new PaperMoney()}
        };

        public IMoney GetMoneyToDisplay(MoneyType moneyType)
        {
            if (!moneyObjects.ContainsKey(moneyType))
            {
                return null;
            }

            return moneyObjects[moneyType];
        }
    }
}
