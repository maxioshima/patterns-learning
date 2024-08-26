
namespace Norbit.Crm.Anoshkeen.Decorator
{
    /// <summary>
    /// Декоратор нового метода верификации.
    /// </summary>
    public abstract class VerificationDecorator : Verification
    {
        /// <summary>
        /// Оборачиваемый объект метода верификации.
        /// </summary>
        private Verification _verification;

        /// <summary>
        /// Декоратор нового метода верификации.
        /// </summary>
        /// <param name="verification">Метод верификации.</param>
        public VerificationDecorator(Verification verification)
        {

            _verification = verification;
        }

        /// <summary>
        /// Переопределение реализации метода верификации.
        /// </summary>
        /// <returns>Результат верификации.</returns>
        public override string PassVerificaton()
        {

            if (_verification != null)
            {
                return _verification.PassVerificaton();
            }
            else
            {
                return "No verification method defined.";
            }
        }
    }
}
