namespace Norbit.Crm.Anoshkeen.Decorator
{
    /// <summary>
    /// Верификация пользователя.
    /// </summary>
    public class PasswordVerification : Verification
    {
        /// <summary>
        /// Переопределение реализации метода верификации.
        /// </summary>
        /// <returns>Результат верификации.</returns>
        public override string PassVerificaton()
        {
            return "Password verification passed";
        }
    }
}
