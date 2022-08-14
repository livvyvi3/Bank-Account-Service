using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Service.Models
{
    public class CurrentAccountModel
    {
        public CurrentAccountModel(long accountId, double   balance, double overdraft)
        {
            this.AccountID = accountId;
            this.Balance = balance;
            this.Overdraft = overdraft;
        }

        public long AccountID { get; set; }
        public double Balance { get; set; }
        public double Overdraft { get; set; }
    }
}

