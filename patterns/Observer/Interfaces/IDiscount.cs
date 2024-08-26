namespace Norbit.Crm.Anoshkeen.Observer
{
    /// <summary>
    /// Акция.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Является активной.
        /// </summary>
        bool IsActive { get; set; }

        /// <summary>
        /// Размер.
        /// </summary>
        int Amount { get; set; }

        /// <summary>
        /// Категория.
        /// </summary>
        string Category { get; set; }
    }
}
