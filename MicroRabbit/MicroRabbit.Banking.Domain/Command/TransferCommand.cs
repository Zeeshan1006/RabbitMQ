namespace MicroRabbit.Banking.Domain.Command
{
    public abstract class TransferCommand : MicroRabbit.Domain.Core.Commands.Command
    {
        public int From { get; set; }
        public int To { get; set; }
        public decimal Amount { get; set; }
    }
}
