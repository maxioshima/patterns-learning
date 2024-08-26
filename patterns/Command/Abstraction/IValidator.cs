namespace Norbit.Crm.Anoshkeen
{
    /// <summary>
    /// Валидатор данных заёмщика.
    /// </summary>
    public interface IValidator
    {
        /// <summary>
        /// Валидировать данные заёмщика.
        /// </summary>
        /// <param name="borrower">Заёмщик.</param>
        void Validate(Borrower borrower);
    }
}
