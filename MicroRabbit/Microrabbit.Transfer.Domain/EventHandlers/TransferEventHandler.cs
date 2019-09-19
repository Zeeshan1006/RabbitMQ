using Microrabbit.Transfer.Domain.Events;
using Microrabbit.Transfer.Domain.Interfaces;
using Microrabbit.Transfer.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System.Threading.Tasks;

namespace Microrabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository transferRepository;

        public TransferEventHandler(ITransferRepository transferRepository)
        {
            this.transferRepository = transferRepository;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            transferRepository.Add(new TransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount
            });
            return Task.CompletedTask;
        }
    }
}
