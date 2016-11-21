namespace KnowledgeSharing.CleanCode.SOLID.Accounts
{
    public class ValuableCustomerAccount : RegisteredAccount
    {
        public override decimal MembershipDiscountPercentage
        {
            get { return 0.3m; }
        }
    }
}
