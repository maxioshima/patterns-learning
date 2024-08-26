using System;

namespace Norbit.Crm.Anoshkeen.Singleton
{
    /// <summary>
    /// Персона.
    /// </summary>
    [Serializable]
    public class Person
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; } = "Undefined";

        /// <summary>
        /// Возраст.
        /// </summary>
        public int Age = 1;

        /// <summary>
        /// Персона.
        /// </summary>
        public Person()
        {}

        /// <summary>
        /// Персона.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="age">Возраст.</param>
        public Person(string name, int age)
        {

            Name = name;
            Age = age;
        }
    }
}
