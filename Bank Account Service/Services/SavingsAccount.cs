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
        private readonly ISystemDB _systemDB;

        public SavingsAccount(ISystemDB systemDB)
        {
            _systemDB = systemDB;
        }
        public void Deposit(long accountId, double amountToDeposit)
        {
            _systemDB.getSavingsAccounts().Single(x => x.AccountId == accountId).Balance += amountToDeposit;
        }


        public void Withdraw(long accountId, double amountToWithdraw)
        {
            if (_systemDB.getSavingsAccounts().Single(x => x.AccountId == accountId).Balance > amountToWithdraw)
            {
                _systemDB.getSavingsAccounts().Single(x => x.AccountId == accountId).Balance -= amountToWithdraw;
            }
            else
                Console.WriteLine("Insufficient balance");
            
        }
    }
}
