using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Norbit.Crm.Anoshkeen.Singleton
{
    /// <summary>
    /// Json Десериализатор.
    /// </summary>
    public class JsonManager : IDeserializer
    {
        /// <summary>
        /// Десериализация данных из файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns>Массив записей.</returns>
        public async Task<Person[]> DeserializeDataFromFile(string filePath)
        {
            using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                var person =  await JsonSerializer.DeserializeAsync<Person[]>(fs);

                return person;
            }
        }
    }
}
