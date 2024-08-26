namespace Norbit.Crm.Anoshkin.Iterator
{
    /// <summary>
    /// Объект перечисления.
    /// </summary>
    public abstract class Aggregate
    {
        /// <summary>
        /// Создать итератор.
        /// </summary>
        /// <returns></returns>
        public abstract IIterator CreateIterator();

        /// <summary>
        /// Количество элементов в перечислении.
        /// </summary>
        public abstract int Count { get; }

        /// <summary>
        /// Текущий элемент.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Элемент.</returns>
        public abstract object this[int index] { get; }
    }
}
