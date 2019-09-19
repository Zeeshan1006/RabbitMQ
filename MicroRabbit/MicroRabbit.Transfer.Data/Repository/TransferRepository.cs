using Microrabbit.Transfer.Domain.Interfaces;
using Microrabbit.Transfer.Domain.Models;
using MicroRabbit.Transfer.Data.Context;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext context;

        public TransferRepository(TransferDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return context.TransferLogs;
        }

        public void Add(TransferLog transferLog)
        {
            context.TransferLogs.Add(transferLog);
            context.SaveChanges();
        }
    }
}
