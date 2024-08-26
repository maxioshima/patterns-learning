using System;

namespace Norbit.Crm.Anoshkeen.Adapter
{
    /// <summary>
    /// Адаптер калькулятора ИМТ для перевода из ft/lb в м/кг.
    /// </summary>
    public class BmiCalculatorAdapter : IBmiCalculator
    {
        /// <summary>
        /// Оборачиваемый калькулятор ИМТ.
        /// </summary>
        IBmiCalculator bmiCalculator;

        /// <summary>
        /// Адаптер калькулятора ИМТ для перевода из ft/lb в м/кг.
        /// </summary>
        public BmiCalculatorAdapter(IBmiCalculator calculator)
        {
            bmiCalculator = calculator;
        }

        /// <summary>
        /// Делитель для перевода роста из ft в м.
        /// </summary>
        private const double HEIGHT_DIVISOR = 3.2808;

        /// <summary>
        /// Множитель для перевода веса из lb в кг.
        /// </summary>
        private const double WEIGHT_DIVISOR = 0.454;

        /// <summary>
        /// Посчитать индекс массы тела.
        /// </summary>
        /// <param name="height">Рост, м</param>
        /// <param name="weight">Вес, кг</param>
        /// <returns>Индекс массы тела.</returns>
        public double CalculateBmiIndex(double height, double weight)
        {

            var convertedHeight = height / HEIGHT_DIVISOR;
            var convertedRoundedHeight = Math.Round(convertedHeight, 1);
            var convertedWeight = weight * WEIGHT_DIVISOR;
            var convertedRoundedWeight = Math.Round(convertedWeight, 1);

            return bmiCalculator.CalculateBmiIndex(convertedRoundedHeight, convertedRoundedWeight);
        }
    }
}
