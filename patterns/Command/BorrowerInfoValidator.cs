using System;

namespace Norbit.Crm.Anoshkeen
{
    /// <summary>
    /// Валидатор данных.
    /// </summary>
    public class BorrowerInfoValidator
    {
        /// <summary>
        /// Валидировать.
        /// </summary>
        public void Validate(IValidator validator, Borrower borrower)
        {
            if (validator == null)
            {
                throw new ArgumentNullException(nameof(validator));
            }
            if (borrower == null)
            {
                throw new ArgumentNullException(nameof(borrower));
            }

            validator.Validate(borrower);
        }
    }
}
