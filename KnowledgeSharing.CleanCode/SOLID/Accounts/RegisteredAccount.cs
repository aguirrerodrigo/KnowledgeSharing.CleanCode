using System;

namespace KnowledgeSharing.CleanCode.SOLID.Accounts
{
    public abstract class RegisteredAccount : Account
    {
        public int YearsMember { get; set; }

        public override decimal LoyaltyDiscountPercentage
        {
            get { return Math.Max(YearsMember, 5) * 0.01m; }
        }
    }
}