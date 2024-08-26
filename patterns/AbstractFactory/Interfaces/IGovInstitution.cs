namespace Norbit.Crm.Anoshkeen.AbstractFactory
{
    /// <summary>
    /// Государственное учреждение.
    /// </summary>
    public interface IGovInstitution
    {
        /// <summary>
        /// Инициировать документ.
        /// </summary>
        /// <returns>Документ.</returns>
        IGovDocument InitiateAppeal();

        /// <summary>
        /// Зарегистрировать работника ведомства.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="patronymic">Отчество.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="department">Департамент.</param>
        /// <returns>Работник министерства.</returns>
        IGovermentEmployee RegisterEmployee(string firstName, string patronymic, string lastName, string department);
    }
}