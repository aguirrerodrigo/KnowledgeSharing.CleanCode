namespace KnowledgeSharing.CleanCode.SOLID.Accounts
{
    public class NotRegisteredAccount : Account
    {
        public override decimal MembershipDiscountPercentage
        {
            get { return 0; }
        }

        public override decimal LoyaltyDiscountPercentage
        {
            get { return 0; }
        }
    }
}