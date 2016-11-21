using System;
using KnowledgeSharing.CleanCode.Shared;

namespace KnowledgeSharing.CleanCode.Iteration3
{
    public class DiscountCalculator
    {
        /// <summary>
        /// Calculates the discount.
        /// </summary>
        /// <param name="price">Given amount.</param>
        /// <param name="accountStatus">Account status.</param>
        /// <param name="years">Years registered.</param>
        /// <returns>Returns the discounted amount.</returns>
        public decimal Calculate(decimal price, AccountStatus accountStatus, int years)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;

            switch (accountStatus)
            {
                case AccountStatus.NotRegistered:
                    result = price;
                    break;
                case AccountStatus.SimpleCustomer:
                    result = (price - (0.1m * price)) - disc * (price - (0.1m * price));
                    break;
                case AccountStatus.ValuableCustomer:
                    result = (0.7m * price) - disc * (0.7m * price);
                    break;
                case AccountStatus.MostValuableCustomer:
                    result = (price - (0.5m * price)) - disc * (price - (0.5m * price));
                    break;
                default:
                    throw new NotImplementedException();
            }
            
            return result;
        }
    }
}