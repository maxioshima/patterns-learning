using System;

namespace Norbit.Crm.Anoshkeen.Mediator
{
    /// <summary>
    /// Бабайка.
    /// </summary>
    public class Babayka: BaseComponent
    {
        /// <summary>
        /// Бежать за жертвой.
        /// </summary>
        public void RunForVictim()
        {
            var message = "Babayka run for his victim.";
            Console.WriteLine(message);

            _mediator.ReactOnInitiatorChange(this, message);
        }

        /// <summary>
        /// Спрятаться.
        /// </summary>
        public void Hide()
        {
            Console.WriteLine("Babayka hid...");
        }
    }
}
