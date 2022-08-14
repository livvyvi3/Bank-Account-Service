using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Service.Interface
{
    public interface IAccountService
    {
        public void Deposit(long accountId, double amountToDeposit);
        public void Withdraw(long accountId, double amountToWithdraw);

    }
}
