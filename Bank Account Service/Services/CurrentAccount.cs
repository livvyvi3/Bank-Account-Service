using Bank_Account_Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Service.Services
{
    public class CurrentAccount : IAccountService
    {

        private readonly ISystemDB _systemDB;
        private const double maxOverdraft = 100000;
        private double balanceAfterWithdrawal;

        public CurrentAccount(ISystemDB systemDB)
        {
            _systemDB = systemDB;
        }
        
        public void Deposit(long accountId, double amountToDeposit)
        {
            _systemDB.getCurrentAccounts().Single(x => x.AccountID == accountId).Balance += amountToDeposit;
        }


        public void Withdraw(long accountId, double amountToWithdraw)
        {
            balanceAfterWithdrawal = _systemDB.getCurrentAccounts().Single(x => x.AccountID == accountId).Balance  - amountToWithdraw;
            if (balanceAfterWithdrawal <= maxOverdraft) 
            {
                
                    _systemDB.getCurrentAccounts().Single(x => x.AccountID == accountId).Balance -= amountToWithdraw;
                }
               
            else
                Console.WriteLine("You have exceeded your overdraft limit");
        }

        
    }
}
