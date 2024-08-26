namespace Norbit.Crm.Anoshkeen.Decorator
{
    /// <summary>
    /// Верификация по фото.
    /// </summary>
    public class PhotoVerification : VerificationDecorator
    {
        /// <summary>
        /// Верификация по фото.
        /// </summary>
        /// <param name="verification">Метод верификации.</param>
        public PhotoVerification(Verification verification): base(verification)
        {
        }

        /// <summary>
        /// Переопределение реализации метода верификации.
        /// </summary>
        /// <returns>Результат верификации.</returns>
        public override string PassVerificaton()
        {
            return $"Photo verification passed. {base.PassVerificaton()}";
        }
    }
}
