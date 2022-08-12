using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Service.Models
{
    public class CurrentAccountModel
    {
        public CurrentAccountModel(long accountId,  int balance, int overdraft)
        {
            this.AccountID = accountId;
            this.Balance = balance;
            this.Overdraft = overdraft;
        }

        public long AccountID { get; }
        public int Balance { get; }
        public int Overdraft { get; }
    }
}

