namespace Norbit.Crm.Anoshkeen.Decorator
{
    /// <summary>
    /// Верификация по номеру телефона.
    /// </summary>
    public class PhoneVerification : VerificationDecorator
    {
        /// <summary>
        /// Верификация по номеру телефона.
        /// </summary>
        /// <param name="verification">Метод верификации.</param>
        public PhoneVerification(Verification verification): base(verification)
        {
        }

        /// <summary>
        /// Переопределение реализации метода верификации.
        /// </summary>
        /// <returns>Результат верификации.</returns>
        public override string PassVerificaton()
        {
            return $"Phone verification passed. {base.PassVerificaton()}";
        }

    }
}
