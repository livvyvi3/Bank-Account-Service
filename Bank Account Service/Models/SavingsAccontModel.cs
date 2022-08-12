using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Service.Models
{
    public class SavingsAccontModel
    {
        public SavingsAccontModel(long accountId,  int balance)
        {
            this.AccountId = accountId;
            this.Balance = balance;
        }

        public long AccountId { get; }
        public int Balance { get; }
    }
}

