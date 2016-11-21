namespace KnowledgeSharing.CleanCode.SOLID.Accounts
{
    public abstract class Account
    {
        public abstract decimal MembershipDiscountPercentage { get; }

        public abstract decimal LoyaltyDiscountPercentage { get; }
    }
}