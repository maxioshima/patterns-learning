namespace Norbit.Crm.Anoshkeen.Observer
{
    /// <summary>
    /// Клиент.
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// Имя.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Обработчик оповещения о акции.
        /// </summary>
        /// <param name="newDiscount">Акция.</param>
        /// <returns>Строка оповещения пользователя.</returns>
        string NotificationReply(IDiscount newDiscount);
    }
}
