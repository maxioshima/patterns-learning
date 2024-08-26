using System;

namespace Norbit.Crm.Anoshkeen
{
    /// <summary>
    /// Валидатор основной информации.
    /// </summary>
    public class GeneralInfoValidator : IValidator
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

            ValidateGeneralInfo(borrower);
        }

        /// <summary>
        /// Валидировать данные.
        /// </summary>
        /// <param name="borrower">Заёмщик.</param>
        /// <exception cref="ArgumentException">В случае, если хотя бы одно поле пустое, или объект равен null.</exception>
        private void ValidateGeneralInfo(Borrower borrower)
        {
            if (borrower == default
                || borrower.generalInfo.Name == default
                || borrower.generalInfo.FamilyName == default
                || borrower.generalInfo.Age == default)
            {
                throw new ArgumentException("Fill all required fields.");
            }
        }
    }
}
