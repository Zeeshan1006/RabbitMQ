﻿using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext context;

        public AccountRepository(BankingDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return context.Accounts;
        }
    }
}
