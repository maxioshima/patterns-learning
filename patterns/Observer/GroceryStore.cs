using System.Collections.Generic;

namespace Norbit.Crm.Anoshkeen.Observer
{
    /// <summary>
    /// Продуктовый магазин.
    /// </summary>
    public partial class GroceryStore : IStore
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; } = "Anonymous";

        /// <summary>
        /// Адрес.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Список клиентов.
        /// </summary>
        private List<IClient> _clientList = new List<IClient>();

        /// <summary>
        /// Список акций.
        /// </summary>
        private List<IDiscount> _discountList = new List<IDiscount>();

        /// <summary>
        /// Добавление нового клиента.
        /// </summary>
        /// <param name="newClient">Клиент.</param>
        public void AddClient(IClient newClient)
        {

            _clientList.Add(newClient);
        }

        /// <summary>
        /// Удаление клиента.
        /// </summary>
        /// <param name="client">Клиент.</param>
        /// <returns>Результат удаления.</returns>
        public bool RemoveClient(IClient client)
        {

            return _clientList.Remove(client);
        }

        /// <summary>
        /// Разослать клиентам уведомление о акции.
        /// </summary>
        /// <param name="discount">Акция.</param>
        /// <returns>Количество оповещённых клиентов.</returns>
        public int SendClientNotification(IDiscount discount)
        {

            foreach (var client in _clientList)
            {
                client.NotificationReply(discount);
            }

            return _clientList.Count;
        }

        /// <summary>
        /// Добавление акции.
        /// </summary>
        /// <param name="newDiscount">Акция.</param>
        public void AddDiscount(IDiscount newDiscount)
        {

            _discountList.Add(newDiscount);
            SendClientNotification(newDiscount);
        }
    }
}
