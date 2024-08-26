using Norbit.Crm.Anoshkeen.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.Crm.Anoshkeen.Mediator
{
    /// <summary>
    /// Медиатор.
    /// </summary>
    public class CitizenMediator: IMediator
    {
        /// <summary>
        /// Инициирующий компонент.
        /// </summary>
        private Citizen Initiator { get; set; }

        /// <summary>
        /// Получатель сообщения о изменении состояния инициирующего компонента.
        /// </summary>
        private Babayka Recipient { get; set; }

        /// <summary>
        /// Медиатор.
        /// </summary>
        /// <param name="initiator">Инициирующий компонент.</param>
        public CitizenMediator(Citizen initiator, Babayka recipient)
        {
            Initiator = initiator;
            Initiator.SetMediator(this);
            Recipient = recipient;
            Recipient.SetMediator(this);
        }

        /// <summary>
        /// Реагировать на действие жертвы.
        /// </summary>
        /// <param name="sender">Отправитель.</param>
        /// <param name="state">Состояние.</param>
        public void ReactOnInitiatorChange(object sender, string state)
        {
            if (state == "Light is on.")
            {
                Recipient.Hide();
            }
            else if (state == "The lights are turned off.")
            {
                Recipient.RunForVictim();
            }
        }
    }
}
