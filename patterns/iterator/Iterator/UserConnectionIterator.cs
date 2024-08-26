using System;

namespace Norbit.Crm.Anoshkin.Iterator
{
    /// <summary>
    /// Коллекция с возможностью перечисления.
    /// </summary>
    public class UserConnectionIterator : IIterator
    {
        /// <summary>
        /// Коллекция.
        /// </summary>
        readonly Aggregate userConnectionAggregate;

        /// <summary>
        /// Индекс текущего элемента перечисления.
        /// </summary>
        private int _current;

        /// <summary>
        /// Коллекция с возможностью перечисления.
        /// </summary>
        public UserConnectionIterator(Aggregate aggregate) 
        {
            userConnectionAggregate = aggregate;
        }
        /// <summary>
        /// Получить первый элемент коллекции.
        /// </summary>
        /// <returns>Первый элемент перечисления.</returns>
        public object First() 
        {
            Console.WriteLine(userConnectionAggregate.Count);
            return userConnectionAggregate[0];
        }

        /// <summary>
        /// Получить следующий элемент перечисления.
        /// </summary>
        /// <returns>Следующий элемент перечисления.</returns>
        public object Next()
        {
            object element = null;

            if (_current < userConnectionAggregate.Count)
            {
                element = userConnectionAggregate[_current];
            }

            _current++;
            
            return element;
        }

        /// <summary>
        /// Конец перечисления.
        /// </summary>
        /// <returns>Признак.</returns>
        public bool IsDone()
        {
            return _current >= userConnectionAggregate.Count;
        }

        /// <summary>
        /// Текущий элемент перечисления.
        /// </summary>
        /// <returns>Элемент.</returns>
        public object CurrentItem()
        {
            return userConnectionAggregate[_current];
        }
    }
}
