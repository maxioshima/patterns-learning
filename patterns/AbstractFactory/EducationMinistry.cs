
namespace Norbit.Crm.Anoshkeen.AbstractFactory
{
    /// <summary>
    /// Министерство образования.
    /// </summary>
    public class EducationMinistry : IGovInstitution
    {
        /// <summary>
        /// Создать отчет министерства образования.
        /// </summary>
        /// <returns>Отчет министерства образования.</returns>
        public IGovDocument InitiateAppeal()
        {
            return new EducationMinistryReport();
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


            return new EducationMinistryEmployee(firstName, lastName, patronymic, department);
        }
    }
}
