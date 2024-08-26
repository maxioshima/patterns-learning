
namespace Norbit.Crm.Anoshkeen.Observer
{
    /// <summary>
    /// Акция.
    /// </summary>
    public class Discount : IDiscount
    {
        /// <summary>
        /// Является активной.
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Размер.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Категория.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Акция.
        /// </summary>
        /// <param name="amount">Размер скидки, %.</param>
        /// <param name="category">Категория товара.</param>
        public Discount(int amount, string category)
        {

            Amount = amount;
            Category = category;
        }
    }
}
