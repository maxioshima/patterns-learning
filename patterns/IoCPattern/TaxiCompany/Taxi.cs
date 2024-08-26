namespace Norbit.Crm.Anoshkeen.IoCPattern
{
    /// <summary>
    /// Такси.
    /// </summary>
    public class Taxi : ITaxiCar
    {
        /// <summary>
        /// Тип автомобиля.
        /// </summary>
        public CarType CarType { get; set; }

        /// <summary>
        /// На вызове.
        /// </summary>
        public bool IsBusy { get; set; }

        /// <summary>
        /// Такси.
        /// </summary>
        public Taxi(CarType carType, bool isBusyCar)
        {
            CarType = carType;
            IsBusy = isBusyCar;
        }
    }
}
