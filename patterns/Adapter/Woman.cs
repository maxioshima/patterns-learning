namespace Norbit.Crm.Anoshkeen.Adapter
{
    /// <summary>
    /// Женщина.
    /// </summary>
    public class Woman : Human
    {
        /// <summary>
        /// Женщина.
        /// </summary>
        /// <param name="height">Рост, ft.</param>
        /// <param name="weight">Вес, lb.</param>
        public Woman(double height, double weight)
        {
            Height = height;
            Weight = weight;
        }
    }
}
