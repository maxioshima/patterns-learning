using System;

namespace Norbit.Crm.Anoshkeen.Mediator
{
    /// <summary>
    /// Горожанин.
    /// </summary>
    public class Citizen : BaseComponent
    {
        /// <summary>
        /// Тип сущности.
        /// </summary>
        public override string Type
        {
            get { return "Citizen"; }
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
