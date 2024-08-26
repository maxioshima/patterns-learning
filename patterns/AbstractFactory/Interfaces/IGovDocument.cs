using System;

namespace Norbit.Crm.Anoshkeen.AbstractFactory
{
    /// <summary>
    /// Документ государственного учреждения.
    /// </summary>
    public interface IGovDocument
    {
        /// <summary>
        /// Ответственный.
        /// </summary>
        string Responsible { get; set; }

        /// <summary>
        /// Статус.
        /// </summary>
        string Status { get; set; }

        /// <summary>
        /// Создать документ.
        /// </summary>
        /// <param name="documentId">Уникальный идентификатор документа.</param>
        /// <returns>Строка с информацие о созданном документе.</returns>
        string CreateDocument(Guid documentId);
    }
}