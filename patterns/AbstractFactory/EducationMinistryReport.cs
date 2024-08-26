using System;

namespace Norbit.Crm.Anoshkeen.AbstractFactory
{
    /// <summary>
    /// Отчёт министерства образования.
    /// </summary>
    public class EducationMinistryReport : IGovDocument
    {
        /// <summary>
        /// Статус.
        /// </summary>
        private string _status = EnumHelper.GetDescription(DocumentStatus.Active);

        /// <summary>
        /// Ответственный.
        /// </summary>
        public string Responsible { set; get; }

        /// <summary>
        /// Статус.
        /// </summary>
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                if (!Enum.IsDefined(typeof(DocumentStatus), value))
                {
                    throw new ArgumentException("Document status not available.");
                }

                _status = value;
            }
        }

        /// <summary>
        /// Создать документ.
        /// </summary>
        /// <param name="documentId">Уникальный идентификатор документа.</param>
        /// <returns>Строка с информацие о созданном документе.</returns>
        public string CreateDocument(Guid documentId)
        {
            return $"Created document with id: {documentId}";
        }
    }
}
