namespace Norbit.Crm.Anoshkeen.Decorator
{
    /// <summary>
    /// Верификация пользователя.
    /// </summary>
    abstract public class Verification
    {
        /// <summary>
        /// Пройти верификацию.
        /// </summary>
        /// <returns>Результат верификации.</returns>
        public abstract string PassVerificaton();
    }
}
