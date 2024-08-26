using System;
using System.Linq;
using System.Threading.Tasks;

namespace Norbit.Crm.Anoshkeen.Singleton
{
    /// <summary>
    /// Менеджер десериализации.
    /// </summary>
    public class SerializationManager
    {
        /// <summary>
        /// Объект класса.
        /// </summary>
        private static SerializationManager Instance;

        /// <summary>
        /// Объект для блокировки потока.
        /// </summary>
        private static readonly object Locker = new object();

        /// <summary>
        /// Приватный конструктор.
        /// </summary>
        private SerializationManager()
        { }

        /// <summary>
        /// Предоставляет доступ к экземпляру класса.
        /// </summary>
        /// <returns>Экземпляр класса.</returns>
        public static SerializationManager GetInstance() 
        {
            lock (Locker)
            {
                if (Instance == null)
                {
                    Instance = new SerializationManager();
                    return Instance;
                }
                else
                {
                    return Instance;
                }
            }
        }

        /// <summary>
        /// Десериализовать данные.
        /// </summary>
        /// <param name="path">Путь к файлу для десериализации.</param>
        /// <returns>Десериализованный набор объектов.</returns>
        /// <exception cref="ArgumentException">Ограничивает передачу файла с недопустимым расширением.</exception>
        public async Task<Person[]> DeserializeData(string path)
        {

            string fileExtension = path.Split('.').Last();

            if (fileExtension == "json")
            {
                var jsonSerializer = new JsonManager();
                return await jsonSerializer.DeserializeDataFromFile(path);
            }
            else if (fileExtension == "xml")
            {
                var xmlSerializer = new XmlManager();
                return await xmlSerializer.DeserializeDataFromFile(path);
            }
            else
            {
                throw new ArgumentException("Unknown file extension!");
            }
        }
    }
}
