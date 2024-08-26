namespace Norbit.Crm.Anoshkeen.AbstractFactory
{
    /// <summary>
    /// Работник правительства.
    /// </summary>
    public interface IGovermentEmployee
    {
        /// <summary>
        /// Должность.
        /// </summary>
        string Position { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Отчетсво.
        /// </summary>
        string Patronymic { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Представить работника.
        /// </summary>
        /// <returns>Строковое представление.</returns>
        string IntroduceEmployee();
    }
}