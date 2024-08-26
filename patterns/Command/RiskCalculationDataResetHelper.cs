namespace Norbit.Crm.Anoshkeen
{
    /// <summary>
    /// Хэлпер для сброса данных.
    /// </summary>
    public class RiskCalculationDataResetHelper : IResetDataHelper
    {
        /// <summary>
        /// Сбросить данные расчета кредитных рисков.
        /// </summary>
        /// <param name="riskcalculatedRecord">Запись содержащая поля для рассчета рисков.</param>
        public void ResetRiskData(RiskCalculated riskcalculatedRecord)
        {
            if (riskcalculatedRecord == default)
            {
                return;
            }

            riskcalculatedRecord.creditRisksInfo.RisksCm = 0;
            riskcalculatedRecord.creditRisksInfo.RisksKm = 0;
            riskcalculatedRecord.creditRisksInfo.NeedRisksInfoRecalculation = true;
        }
    }
}
