namespace Norbit.Crm.Anoshkeen
{
    /// <summary>
    /// Хэлпер для сброса данных у объекта с полями расчёта рисков.
    /// </summary>
    public interface IResetDataHelper
    {
        /// <summary>
        /// Сбросить данные рассчета-рисков.
        /// </summary>
        void ResetRiskData(RiskCalculated riskcalculatedRecord);
    }
}
