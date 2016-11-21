using KnowledgeSharing.CleanCode.SOLID.Accounts;

namespace KnowledgeSharing.CleanCode.SOLID
{
    public class DiscountCalculator
    {
        public decimal Calculate(Order order, Account account)
        {
            var amount = order.GetDiscountedAmount(account);
            return amount;
        }
    }
}