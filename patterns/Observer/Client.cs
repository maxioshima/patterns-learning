using System;

namespace Norbit.Crm.Anoshkeen.Observer
{
    /// <summary>
    /// Клиент.
    /// </summary>
    public class Client : IClient
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Клиент.
        /// </summary>
        /// <param name="name">Имя.</param>
        public Client(string name)
        {

            Name = name;
        }

        /// <summary>
        /// Обработчик уведомления.
        /// </summary>
        /// <param name="newDiscount">Тело оповещения.</param>
        /// <returns>Строка оповещения пользователя.</returns>
        public string NotificationReply(IDiscount newDiscount)
        {

            return $"Dear {Name}! Good news: in our store {newDiscount.Category} with {newDiscount.Amount}% discount!";
        }
    }
}
