namespace KnowledgeSharing.CleanCode.SOLID.Accounts
{
    public class MostValuableCustomerAccount : RegisteredAccount
    {
        public override decimal MembershipDiscountPercentage
        {
            get { return 0.5m; }
        }
    }
}
