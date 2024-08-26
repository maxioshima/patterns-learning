
namespace Norbit.Crm.Anoshkeen.IoCPattern
{
    /// <summary>
    /// Таксопарк.
    /// </summary>
    public interface ITaxiCompany
    {
        /// <summary>
        /// Найти легковую машину.
        /// </summary>
        /// <returns>true, если легковая машина найдена, иначе false.</returns>
        void FindPassengerCar();

        /// <summary>
        /// Найти грузовую машину.
        /// </summary>
        /// <returns>true, если грузовая машина найдена, иначе false.</returns>
        void FindTruck();

        /// <summary>
        /// Добавить машину на линию.
        /// </summary>
        /// <param name="car">Автомобиль такси.</param>
        void AddCarOnLine(ITaxiCar car);
    }
}
