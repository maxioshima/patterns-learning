using System.ComponentModel;

namespace Norbit.Crm.Anoshkeen.AbstractFactory
{
    /// <summary>
    /// Статус документа.
    /// </summary>
    public enum DocumentStatus
    {
        [Description("Active")]
        Active,

        [Description("Close")]
        Close
    }
}
