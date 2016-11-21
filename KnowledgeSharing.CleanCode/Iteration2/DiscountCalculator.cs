using System;

namespace KnowledgeSharing.CleanCode.Iteration2
{
    public class DiscountCalculator
    {
        /// <summary>
        /// Calculates the discount.
        /// </summary>
        /// <param name="amount">Given amount.</param>
        /// <param name="type">Account type.</param>
        /// <param name="years">Years registered.</param>
        /// <returns>Returns the discounted amount.</returns>
        public decimal Calculate(decimal amount, int type, int years)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;

            switch (type)
            {
                case 1: // Not Registered
                    result = amount;
                    break;
                case 2: // Simple Customer
                    result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
                    break;
                case 3: // Valuable Customer
                    result = (0.7m * amount) - disc * (0.7m * amount);
                    break;
                case 4: // Most Valuable Customer
                    result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
                    break;
                default:
                    throw new NotImplementedException();
            }
            
            return result;
        }
    }
}