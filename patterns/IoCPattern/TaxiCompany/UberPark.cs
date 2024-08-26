using System;
using System.Collections.Generic;
using System.Linq;

namespace Norbit.Crm.Anoshkeen.IoCPattern
{
    /// <summary>
    /// Таксопарк "Uber".
    /// </summary>
    public class UberPark : ITaxiCompany
    {
        /// <summary>
        /// Линия машин "на смене".
        /// </summary>
        private List<ITaxiCar> _taxiLine = new List<ITaxiCar>();

        /// <summary>
        /// Таксопарк "Uber".
        /// </summary>
        public UberPark(ITaxiCar taxiLine)
        {
            Validation.ValidationHelper.CheckValueIsNull(nameof(taxiLine), taxiLine);

            AddCarOnLine(taxiLine);
        }

        /// <summary>
        /// Добавить машину на линию.
        /// </summary>
        /// <param name="car">Автомобиль такси.</param>
        public void AddCarOnLine(ITaxiCar car)
        {
            Validation.ValidationHelper.CheckValueIsNull(nameof(car), car);

            _taxiLine.Add(car ?? throw new ArgumentNullException(nameof(car)));
        }

        /// <summary>
        /// Найти легковую машину.
        /// </summary>
        /// <returns>true, если легковая машина найдена, иначе false.</returns>
        public void FindPassengerCar() 
        {
            if (_taxiLine.Count == 0)
            {
                Console.WriteLine("Линия пуста.");
            }
            else
            {
                var foundedCar = _taxiLine.Where((car) => car.CarType == CarType.PassengerCar && !car.IsBusy)
                    .Count();

                Console.WriteLine(foundedCar > 0 ? 
                    "Найдена свободная машина!" : 
                    "К сожалению, машина не найдена!");
            } 
        }

        /// <summary>
        /// Найти грузовую машину.
        /// </summary>
        /// <returns>true, если грузовая машина найдена, иначе false.</returns>
        public void FindTruck() 
        {
            if (_taxiLine.Count == 0)
            {
                Console.WriteLine("Линия пуста.");
            }
            else
            {
                var foundedCar = _taxiLine.Where((car) => car.CarType == CarType.Truck && !car.IsBusy)
                    .Count();

                Console.WriteLine(foundedCar > 0 ?
                    "Найдена свободная грузовая машина!" :
                    "К сожалению, машина не найдена!");
            }
        }

    }
}
