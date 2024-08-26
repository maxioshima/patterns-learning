using System;

namespace Norbit.Crm.Anoshkeen
{
    /// <summary>
    /// Заёмщик.
    /// </summary>
    public class Borrower : RiskCalculated
    {
        /// <summary>
        /// Общая информация.
        /// </summary>
        public GeneralInfo generalInfo {  get; set; }

        /// <summary>
        /// Информация о кредитных рисках.
        /// </summary>
        public override CreditRisksInfo creditRisksInfo { get; set;}

        /// <summary>
        /// Сбросить данные рассчета-рисков.
        /// </summary>
        /// <param name="helper">Хэлпер для сброса данных.</param>
        public override void ResetRiskData(IResetDataHelper helper) {
            if (helper == default)
            {
                throw new ArgumentException(nameof(helper));
            }

            helper.ResetRiskData(this);
        }

        /// <summary>
        /// Заёмщик.
        /// </summary>
        public Borrower() 
        {
            generalInfo = new GeneralInfo();
            creditRisksInfo = new CreditRisksInfo();
        }

        /// <summary>
        /// Возвращает строковое представление для объекта "Заёмщик".
        /// </summary>
        /// <returns>Строковое представление для объекта "Заёмщик".</returns>
        public override string ToString()
        {
            return $"Name: {generalInfo.Name}, " +
                $"Middle name: {generalInfo.MiddleName}, " +
                $"Family name: {generalInfo.FamilyName}, " +
                $"First credit property: {creditRisksInfo.RisksCm}, " +
                $"Second credit property: {creditRisksInfo.RisksKm}, " +
                $"Need recalculation: {creditRisksInfo.NeedRisksInfoRecalculation}";
        }

    }
}
