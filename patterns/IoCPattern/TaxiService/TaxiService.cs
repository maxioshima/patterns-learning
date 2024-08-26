namespace Norbit.Crm.Anoshkeen.IoCPattern
{
    /// <summary>
    /// Сервис заказа такси.
    /// </summary>
    public class TaxiService
    {
        /// <summary>
        /// Таксопарк.
        /// </summary>
        private ITaxiCompany _taxiCompany;

        /// <summary>
        /// Сервис заказа такси.
        /// </summary>
        public TaxiService(ITaxiCompany taxiCompany) 
        {
            Validation.ValidationHelper.CheckValueIsNull(nameof(taxiCompany), taxiCompany);

            _taxiCompany = taxiCompany;
        }

        /// <summary>
        /// Заказать пассажирское такси.
        /// </summary>
        public void OrderPassengerTaxi() 
        {
            _taxiCompany.FindPassengerCar();
        }

        /// <summary>
        /// Заказать грузовое такси.
        /// </summary>
        public void OrderTruck() 
        {
            _taxiCompany.FindTruck();
        }
    }
}
