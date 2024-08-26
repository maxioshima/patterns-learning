using System;

namespace Norbit.Crm.Anoshkeen.Mediator
{
    /// <summary>
    /// Кот.
    /// </summary>
    public class Cat: BaseComponent
    {
        /// <summary>
        /// Тип сущности.
        /// </summary>
        public override string Type {
            get { return "Cat"; }
        }

        /// <summary>
        /// Отправить сообщение.
        /// </summary>
        public override void Notify(string message)
        {
        }

        /// <summary>
        /// Реагировать на внешние изменения.
        /// </summary>
        public override void React(string message)
        {
            Console.WriteLine(message);
        }
    }
}
