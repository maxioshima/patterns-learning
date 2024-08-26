using System;

namespace Norbit.Crm.Anoshkeen.Adapter
{
    /// <summary>
    /// Человек.
    /// </summary>
    public abstract class Human
    {
        /// <summary>
        /// Максимальное значение роста, ft.
        /// </summary>
        private const double MAX_HEIGHT = 8;

        /// <summary>
        /// Минимальное значение роста, ft.
        /// </summary>
        private const double MIN_HEIGHT = 1;

        /// <summary>
        /// Максимальное значение веса, lb.
        /// </summary>
        private const double MAX_WEIGHT = 450;

        /// <summary>
        /// Минимальное значение веса, lb.
        /// </summary>
        private const double MIN_WEIGHT = 15;

        /// <summary>
        /// Рост, ft.
        /// </summary>
        private double _height;

        /// <summary>
        /// Вес, lb.
        /// </summary>
        private double _weight;

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Рост, ft.
        /// </summary>
        public double Height 
        {
            get
            {
                return _height;
            }
            set {

                if (value > MAX_HEIGHT || value < MIN_HEIGHT)
                {
                    throw new ArgumentOutOfRangeException(nameof(Height), $"{nameof(Height)} is invalid.");
                }

                _height = value;
            }}

        /// <summary>
        /// Вес, lb.
        /// </summary>
        public double Weight 
        {
            get
            {
                return _weight;
            }
            set
            {

                if (value > MAX_WEIGHT || value < MIN_WEIGHT)
                {
                    throw new ArgumentOutOfRangeException(nameof(Weight), $"{nameof(Weight)} is invalid.");
                }

                _weight = value;
            }
        }
    }
}
