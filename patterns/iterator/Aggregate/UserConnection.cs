using System;

namespace Norbit.Crm.Anoshkin.Iterator
{
    /// <summary>
    /// Пользовательское подключение.
    /// </summary>
    public class UserConnection
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Дата создания соединения.
        /// </summary>
        private DateTime _connectionCreationDate = DateTime.Now;

        /// <summary>
        /// Дата создания соединения.
        /// </summary>
        public DateTime ConnectionCreationDate { get { return _connectionCreationDate; } }

        /// <summary>
        /// Дата истекания соединения.
        /// </summary>
        public DateTime ConnectionExpirationDate { get { return _connectionCreationDate.AddDays(1); } }

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public UserConnection(string userName) 
        {
            UserName = userName;
        }
    }
}
