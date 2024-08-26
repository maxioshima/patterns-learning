
namespace Norbit.Crm.Anoshkeen.AbstractFactory
{
    /// <summary>
    /// Работник министерства сельского хозяйства.
    /// </summary>
    public class AgricultureMinistryEmployee : IGovermentEmployee
    {
        /// <summary>
        /// Должность.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Департамент.
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Отчетсво.
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Работник министерства сельского хозяйства.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="patronymic">Отчество.</param>
        /// <param name="position">Должность.</param>
        public AgricultureMinistryEmployee(string firstName, string lastName, string patronymic, string position)
        {

            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Position = position;
        }

        /// <summary>
        /// Представить работника.
        /// </summary>
        /// <returns>Строковое представление.</returns>
        public string IntroduceEmployee()
        {
            return $"{FirstName} {Patronymic} {LastName}, {Position}";
        }
    }
}
