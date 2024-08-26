namespace Norbit.Crm.Anoshkin.Iterator
{
    /// <summary>
    /// Итератор.
    /// </summary>
    public interface IIterator
    {
        /// <summary>
        /// Получить первый элемент коллекции.
        /// </summary>
        /// <returns>Первый элемент перечисления.</returns>
        object First();

        /// <summary>
        /// Получить следующий элемент перечисления.
        /// </summary>
        /// <returns>Следующий элемент перечисления.</returns>
        object Next();

        /// <summary>
        /// Конец перечисления.
        /// </summary>
        /// <returns>Признак.</returns>
        bool IsDone();

        /// <summary>
        /// Текущий элемент перечисления.
        /// </summary>
        /// <returns>Элемент.</returns>
        object CurrentItem();
    }
}
