 namespace Norbit.Crm.Anoshkeen.Adapter
{
    /// <summary>
    /// Калькулятор индекса массы тела.
    /// </summary>
    public interface IBmiCalculator
    {
        /// <summary>
        /// Посчитать индекс массы тела.
        /// </summary>
        /// <param name="height">Рост, м</param>
        /// <param name="weight">Вес, кг</param>
        /// <returns>Индекс массы тела.</returns>
        double CalculateBmiIndex(double height, double weight);
    }
}
