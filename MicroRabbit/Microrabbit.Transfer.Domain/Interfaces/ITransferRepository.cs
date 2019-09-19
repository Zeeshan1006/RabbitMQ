using Microrabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace Microrabbit.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void Add(TransferLog transferLog);
    }
}
