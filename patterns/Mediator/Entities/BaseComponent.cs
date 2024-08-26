
namespace Norbit.Crm.Anoshkeen.Mediator
{
    /// <summary>
    /// Базовый компонент.
    /// </summary>
    public abstract class BaseComponent
    {
        /// <summary>
        /// Посредник.
        /// </summary>
        protected IMediator Mediator;

        /// <summary>
        /// Тип сущности.
        /// </summary>
        public abstract string Type { get; }

        /// <summary>
        /// Базовый компонент.
        /// </summary>
        public BaseComponent(IMediator bindMediator = null) 
        {
            Mediator = bindMediator;
        }

        /// <summary>
        /// Установить посредника.
        /// </summary>
        /// <param name="bindMediator">Посредник.</param>
        public void SetMediator(IMediator bindMediator)
        {

            Mediator = bindMediator;
        }

        /// <summary>
        /// Отправить сообщение о изменении состояния.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        public abstract void Notify(string message);

        /// <summary>
        /// Реагировать на сообщение.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        public abstract void React(string message);
    }
}
