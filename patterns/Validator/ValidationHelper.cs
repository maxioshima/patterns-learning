using System;

namespace Norbit.Crm.Anoshkeen.Validation
{
    /// <summary>
    /// Валидатор.
    /// </summary>
    public class ValidationHelper
    {
        /// <summary>
        /// Проверка на null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="paramName">Название проверяемого параметра.</param>
        /// <param name="value">Значение параметра.</param>
        /// <exception cref="ArgumentNullException">Ограничивает передачу аргумента со значением null.</exception>
        public static void CheckValueIsNull<T>(string paramName, T value)
        {
            if (Object.Equals(value, null))
            {
                throw new ArgumentNullException(paramName,
                    $"{paramName} is null.");
            }
        }

        /// <summary>
        /// Проверяет, что значение параметра выше указанной границы.
        /// </summary>
        /// <param name="paramName">Наименование параметра.</param>
        /// <param name="value">Значение параметра.</param>
        /// <param name="targetValue">Граничное значение.</param>
        /// <exception cref="ArgumentOutOfRangeException">Ограничивает передачу аргумента ниже установленной границы.</exception>
        public static void CheckValueIsBigger(string paramName, int value, int targetValue)
        {
            if (value < targetValue)
            {
                throw new ArgumentOutOfRangeException(paramName,
                    $"{paramName} must be higher than {targetValue}");
            }
        }

        /// <summary>
        /// Значение параметра выше указанной границы.
        /// </summary>
        /// <param name="paramName">Наименование параметра.</param>
        /// <param name="value">Значение параметра.</param>
        /// <param name="targetValue">Граничное значение.</param>
        /// <exception cref="ArgumentOutOfRangeException">Ограничивает передачу аргумента ниже установленной границы.</exception>
        public static void CheckValueIsBigger(string paramName, double value, double targetValue)
        {
            if (value < targetValue)
            {
                throw new ArgumentOutOfRangeException(paramName,
                    $"{paramName} must be higher than {targetValue}");
            }
        }
    }
}
