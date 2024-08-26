
namespace Norbit.Crm.Anoshkeen.Mediator
{
    /// <summary>
    /// Медиатор.
    /// </summary>
    public class ActionMediator : IMediator
    {
        /// <summary>
        /// Инициирующий компонент.
        /// </summary>
        private BaseComponent Initiator { get; set; }

        /// <summary>
        /// Получатель сообщения о изменении состояния инициирующего компонента.
        /// </summary>
        private BaseComponent Recipient { get; set; }

        /// <summary>
        /// Медиатор.
        /// </summary>
        /// <param name="initiator">Инициирующий компонент.</param>
        /// <param name="recipient">Реагирующий компонент.</param>
        public ActionMediator(BaseComponent initiator, BaseComponent recipient)
        {
            Initiator = initiator;
            Initiator.SetMediator(this);
            Recipient = recipient;
            Recipient.SetMediator(this);
        }

        /// <summary>
        /// Реагирует на сообщение от инициирующего компонента.
        /// </summary>
        /// <param name="sender">Отправитель.</param>
        /// <param name="state">Состояние.</param>
        public void ReactOnInitiatorChange(BaseComponent sender, string state)
        {

            if (state == "The light is turn on." && Recipient.Type == "Cat")
            {
                Recipient.React("Hiss on danger.");
            }
            else if (state == "Looks suspiciously into the corner" && Recipient.Type == "Citizen")
            {
                Recipient.React("The light is turn on.");
            }
        }
    }
}
