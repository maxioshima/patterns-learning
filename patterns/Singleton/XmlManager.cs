using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Norbit.Crm.Anoshkeen.Singleton
{
    /// <summary>
    /// XML Десериализатор.
    /// </summary>
    public class XmlManager : IDeserializer
    {
        /// <summary>
        /// Десериализация данных из файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns>Массив записей.</returns>
        public async Task<Person[]> DeserializeDataFromFile(string filePath) 
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person[]));

            using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return xmlSerializer.Deserialize(fs) as Person[];
            }
        }
    }
}
