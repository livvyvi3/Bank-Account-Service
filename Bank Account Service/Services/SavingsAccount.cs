using Bank_Account_Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Service.Services
{
    public class SavingsAccount : IAccountService
    {
        const double minBalance = 1000;
        private double newBalance;
        private double balance;
        void IAccountService.Deposit(long accountId, double amountToDeposit)
        {
            newBalance = balance + amountToDeposit;
            throw new NotImplementedException();
        }


        void IAccountService.Withdraw(long accountId, double amountToWithdraw)
        {
            if (balance - amountToWithdraw < minBalance)
                throw new NotImplementedException();
            else
                newBalance = balance - amountToWithdraw;
        }
    }
}
