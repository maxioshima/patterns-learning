namespace Norbit.Crm.Anoshkeen
{
    /// <summary>
    /// Информация о кредитных рисках.
    /// </summary>
    public class CreditRisksInfo
    {
        /// <summary>
        /// Коэффициент кредитных метрик.
        /// </summary>
        public int RisksCm;

        /// <summary>
        /// Коэффициент кредитной маржинальности.
        /// </summary>
        public int RisksKm;

        /// <summary>
        /// Необходим перерасчёт кредитных рисков.
        /// </summary>
        public bool NeedRisksInfoRecalculation;
    }
}
