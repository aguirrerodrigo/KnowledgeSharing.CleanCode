using System;
using KnowledgeSharing.CleanCode.Shared;

namespace KnowledgeSharing.CleanCode.Iteration6
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
            var result = 0m;

            switch (accountStatus)
            {
                case AccountStatus.NotRegistered:
                    result = amount;
                    break;
                case AccountStatus.SimpleCustomer:
                case AccountStatus.ValuableCustomer:
                case AccountStatus.MostValuableCustomer:
                    var discountPercentageByYears = GetDiscountPercentageByYearsRegistered(years);
                    var discountedAmount = GetDiscountedAmount(accountStatus, amount);
                    return discountedAmount - (discountPercentageByYears * discountedAmount);
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
        private decimal GetDiscountPercentageByYearsRegistered(int years)
        {
            return Math.Min(years, 5) / 100m;
        }

        /// <summary>
        /// Get discounted amount based on the account status and the non-discounted amount.
        /// </summary>
        /// <param name="accountStatus">Account status.</param>
        /// <param name="amount">Given amount.</param>
        /// <returns>The discounted amount.</returns>
        private decimal GetDiscountedAmount(AccountStatus accountStatus, decimal amount)
        {
            var discountPercentage = GetDiscountPercentage(accountStatus);
            return amount - (discountPercentage * amount);
        }

        /// <summary>
        /// Gets the discount percentage based on the account status.
        /// e.g. SimpleCustomer = 0.1 (10%), ValuableCustomer = 0.3 (30%), MostValuableCustomer = 0.5 (50%).
        /// </summary>
        /// <param name="accountStatus">Account status.</param>
        /// <returns>The discount in percentage.</returns>
        private decimal GetDiscountPercentage(AccountStatus accountStatus)
        {
            switch (accountStatus)
            {
                case AccountStatus.NotRegistered:
                    throw new Exception("No discount percentage.");
                case AccountStatus.SimpleCustomer:
                    return 0.1m;
                case AccountStatus.ValuableCustomer:
                    return 0.3m;
                case AccountStatus.MostValuableCustomer:
                    return 0.5m;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}