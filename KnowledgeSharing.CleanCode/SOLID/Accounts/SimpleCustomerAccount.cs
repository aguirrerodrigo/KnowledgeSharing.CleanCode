namespace KnowledgeSharing.CleanCode.SOLID.Accounts
{
    public class SimpleCustomerAccount : RegisteredAccount
    {
        public override decimal MembershipDiscountPercentage
        {
            get { return 0.1m; }
        }
    }
}