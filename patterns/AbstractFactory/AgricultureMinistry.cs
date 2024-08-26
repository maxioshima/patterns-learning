

namespace Norbit.Crm.Anoshkeen.AbstractFactory
{
    /// <summary>
    /// Министерство аграрной промышленности.
    /// </summary>
    public class AgricultureMinistry : IGovInstitution
    {
        /// <summary>
        /// Создать документ ведомства.
        /// </summary>
        /// <returns>Разрешение на возделывание почвы.</returns>
        public IGovDocument InitiateAppeal()
        {
            return new GrantRightsTillageDocument();
        }

        /// <summary>
        /// Зарегистрировать работника ведомства.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="patronymic">Отчество.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="department">Департамент.</param>
        /// <returns>Работник министерства.</returns>
        public IGovermentEmployee RegisterEmployee(string firstName, string patronymic, string lastName, string department)
        {


            return new AgricultureMinistryEmployee(firstName, lastName, patronymic, department);
        }
    }
}
