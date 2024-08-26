namespace Norbit.Crm.Anoshkeen.IoCPattern
{
    /// <summary>
    /// Автомобиль такси.
    /// </summary>
    public interface ITaxiCar
    {
        /// <summary>
        /// Тип авто.
        /// </summary>
        CarType CarType { get; set; }

        /// <summary>
        /// На вызове.
        /// </summary>
        bool IsBusy { get; set; }
    }
}
