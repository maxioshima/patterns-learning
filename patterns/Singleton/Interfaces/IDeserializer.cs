using System.Threading.Tasks;

namespace Norbit.Crm.Anoshkeen.Singleton
{
    /// <summary>
    /// Десериализатор.
    /// </summary>
    public interface IDeserializer
    {
        /// <summary>
        /// Метод десериализации данных из файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу с данными.</param>
        /// <returns>Массив записей.</returns>
        Task<Person[]> DeserializeDataFromFile(string filePath);
    }
}
