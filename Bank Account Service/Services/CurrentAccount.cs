using Bank_Account_Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Service.Services
{
    internal class CurrentAccount : IAccountService
    {
        private double newBalance;
        private double balance;
        const double maxOverdraft = 100000.00;
        void IAccountService.Deposit(long accountId, double amountToDeposit)
        {
            balance += amountToDeposit;
        }

        void IAccountService.Withdraw(long accountId, double amountToWithdraw)
        {
            if (balance > 0 && amountToWithdraw <= balance + maxOverdraft)
            {
                balance -= amountToWithdraw;
            }
            throw new NotImplementedException();
        }
        public static void openCurrentAccount(long accountId)
        {

        }
    }
}
