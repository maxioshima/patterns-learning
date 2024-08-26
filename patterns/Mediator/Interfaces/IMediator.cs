namespace Norbit.Crm.Anoshkeen.Mediator
{
    /// <summary>
    /// Медиатор для взаимодействующих компонентов.
    /// </summary>
    public interface IMediator
    {
        /// <summary>
        /// Обработать сообщение.
        /// <param name="sender">Отправитель.</param>
        /// <param name="state">Состояние.</param>
        void ReactOnInitiatorChange(BaseComponent sender, string state);
    }
}
