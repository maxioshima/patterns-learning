namespace Norbit.Crm.Anoshkeen.Observer
{
    /// <summary>
    /// Продуктовый магазин.
    /// </summary>
    public interface IStore
    {
        /// <summary>
        /// Название.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Адрес.
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// Добавление нового клиента.
        /// </summary>
        /// <param name="newClient">Объект нового клиента.</param>
        void AddClient(IClient newClient);

        /// <summary>
        /// Удаление клиента.
        /// </summary>
        /// <param name="client">Клиент.</param>
        /// <returns>Результат удаления.</returns>
        bool RemoveClient(IClient client);

        /// <summary>
        /// Разослать уведомление клиентам.
        /// </summary>
        /// <param name="discount">Акция.</param>
        /// <returns>Количество оповещённых клиентов.</returns>
        int SendClientNotification(IDiscount discount);
    }
}
