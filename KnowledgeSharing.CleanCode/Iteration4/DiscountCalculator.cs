using System;
using KnowledgeSharing.CleanCode.Shared;

namespace KnowledgeSharing.CleanCode.Iteration4
{
    public class DiscountCalculator
    {
        /// <summary>
        /// Calculates the discount.
        /// </summary>
        /// <param name="amount">Given amount.</param>
        /// <param name="accountStatus">Account status.</param>
        /// <param name="years">Years registered.</param>
        /// <returns>Returns the discounted amount.</returns>
        public decimal Calculate(decimal amount, AccountStatus accountStatus, int years)
        {
            decimal result = 0;
            decimal disc = GetDiscountPercentage(years);

            switch (accountStatus)
            {
                case AccountStatus.NotRegistered:
                    result = amount;
                    break;
                case AccountStatus.SimpleCustomer:
                    result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
                    break;
                case AccountStatus.ValuableCustomer:
                    result = (0.7m * amount) - disc * (0.7m * amount);
                    break;
                case AccountStatus.MostValuableCustomer:
                    result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
                    break;
                default:
                    throw new NotImplementedException();
            }
            
            return result;
        }

        /// <summary>
        /// Gets discount in percentage based on the years registered.
        /// </summary>
        /// <param name="years">Years registered.</param>
        /// <returns>The discount in perentage.</returns>
        private decimal GetDiscountPercentage(int years)
        {
            if (years > 5)
                return 5M / 100M;
            else
                return years / 100M;
        }
    }
}