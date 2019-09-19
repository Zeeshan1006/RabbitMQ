using MicroRabbit.Domain.Core.Events;

namespace Microrabbit.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Amount { get; private set; }

        public TransferCreatedEvent(int from, int to, int amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
