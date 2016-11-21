using KnowledgeSharing.CleanCode.SOLID.Accounts;

namespace KnowledgeSharing.CleanCode.SOLID
{
    public class Order
    {
        public decimal TotalAmount { get; set; }

        public decimal GetDiscountedAmount(Account account)
        {
            var membershipDiscountMultiplier = 1 - account.MembershipDiscountPercentage;
            var loyaltyDiscountMultiplier = 1 - account.LoyaltyDiscountPercentage;

            return this.TotalAmount * membershipDiscountMultiplier * loyaltyDiscountMultiplier;
        }
    }
}