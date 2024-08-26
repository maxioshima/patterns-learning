using System;
using System.ComponentModel;

namespace Norbit.Crm.Anoshkeen.AbstractFactory
{
    /// <summary>
    /// Методы для перечислений.
    /// </summary>
    public class EnumHelper
    {
        /// <summary>
        /// Получить описание значения в перечислении.
        /// </summary>
        /// <param name="value">Значение в типе перечисления.</param>
        /// <returns>Описание значение в типе перечисления.</returns>
        public static string GetDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
