using System.Collections;

namespace Norbit.Crm.Anoshkin.Iterator
{
    /// <summary>
    /// Набор объектов типа "Пользовательское подключение"
    /// </summary>
    public class UserConnectionCollection : Aggregate
    {
        /// <summary>
        /// Коллекция.
        /// </summary>
        private readonly UserConnection[] _items;

        /// <summary>
        /// Набор объектов типа "Пользовательское подключение"
        /// </summary>
        public UserConnectionCollection(UserConnection[] items)
        {
            _items = items;
        }

        /// <summary>
        /// Создать итератор.
        /// </summary>
        public override IIterator CreateIterator()
        {
            return new UserConnectionIterator(this);
        }

        /// <summary>
        /// Количество элементов в коллекции.
        /// </summary>
        public override int Count { 
            get { return _items.Length; }
        }

        /// <summary>
        /// Текущий элемент.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Элемент.</returns>
        public override object this[int index] {
            get { return _items[index]; }
        }

    }
}
