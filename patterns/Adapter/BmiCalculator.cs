using System;

namespace Norbit.Crm.Anoshkeen.Adapter
{
    /// <summary>
    /// Калькулятор индекса массы тела.
    /// </summary>
    public class BmiCalculator : IBmiCalculator
    {
        /// <summary>
        /// Посчитать индекс массы тела.
        /// </summary>
        /// <param name="height">Рост, м</param>
        /// <param name="weight">Вес, кг</param>
        /// <returns>Индекс массы тела.</returns>
        public double CalculateBmiIndex(double height, double weight) 
        {

            double bmi = weight / (Math.Pow(height, 2));
            return Math.Round(bmi, 1);
        }
    }
}
