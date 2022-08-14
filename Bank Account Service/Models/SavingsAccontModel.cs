using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Service.Models
{
    public class SavingsAccountModel
    {
        public SavingsAccountModel(long accountId, double balance)
        {
            this.AccountId = accountId;
            this.Balance = balance;
        }

        public long AccountId { get; }
        public double Balance { get; set; }
    }
}

