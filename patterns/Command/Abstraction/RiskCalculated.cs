namespace Norbit.Crm.Anoshkeen
{
    /// <summary>
    /// Сущность с рассчетами риска.
    /// </summary>
    public abstract class RiskCalculated
    {
        /// <summary>
        /// Информация о кредитных рисках.
        /// </summary>
        public abstract CreditRisksInfo creditRisksInfo { get; set; }

        /// <summary>
        /// Сбросить данные рассчета-рисков.
        /// </summary>
        /// <param name="helper"></param>
        public virtual void ResetRiskData(IResetDataHelper helper) { }
    }
}
