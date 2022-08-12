using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Service.Interface
{
    public interface IAccountService
    {
        void Deposit(long accountId, double amountToDeposit);
        void Withdraw(long accountId, double amountToWithdraw);

    }
}
