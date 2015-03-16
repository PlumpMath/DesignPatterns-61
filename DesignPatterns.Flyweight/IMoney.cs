
namespace DesignPatterns.Flyweight
{
    public interface IMoney
    {
        MoneyType MoneyType { get; }

        void DisplayMoneyFalling(int moneyValue);
    }
}
