using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Command;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IEventBus eventBus;

        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            this.accountRepository = accountRepository;
            this.eventBus = eventBus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.TranferAmount);

            eventBus.SendCommand(createTransferCommand);
        }
    }
}
