using System;

namespace Norbit.Crm.Anoshkeen
{
    /// <summary>
    /// Валидатор кредитных рисков заёмщика.
    /// </summary>
    public class CreditRisksInfoValidator : IValidator
    {
        /// <summary>
        /// Валидировать.
        /// </summary>
        /// <param name="borrower">Заёмщик.</param>
        public void Validate(Borrower borrower)
        {
            if (borrower == default)
            {
                throw new ArgumentException(nameof(borrower));
            }

            try
            {
                ValidateCreditRisksInfo(borrower);
            }
            catch 
            {
                borrower.ResetRiskData(new RiskCalculationDataResetHelper());
            }
        }

        /// <summary>
        /// Валидировать данные о кредитных рисках.
        /// </summary>
        /// <param name="borrower">Заёмщик.</param>
        /// <exception cref="ArgumentException">В случае, если хотя бы одно поле пустое, или объект равен null.</exception>
        private void ValidateCreditRisksInfo(Borrower borrower)
        {
            if (borrower == default
                || borrower.creditRisksInfo.RisksCm == default
                || borrower.creditRisksInfo.RisksKm == default)
            {
                throw new ArgumentException("Fill all required fields.");
            }

            if (borrower.creditRisksInfo.RisksCm < 0 
                || borrower.creditRisksInfo.RisksCm > 50 
                || borrower.creditRisksInfo.RisksKm < 0 
                || borrower.creditRisksInfo.RisksKm > 100)
            {
                throw new ArgumentException("Fields not didn't pass validation.");
            }
        }
    }
}
