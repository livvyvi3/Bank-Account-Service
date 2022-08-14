using Bank_Account_Service.Interface;
using Bank_Account_Service.Models;
using System.Collections.Generic;

namespace Bank_Account_Service.Services
{
    public class SystemDB : ISystemDB
    {
        public SystemDB()
        {
            savingsAccounts.Add(new SavingsAccountModel(1, 2000));
            savingsAccounts.Add(new SavingsAccountModel(2, 5000));
            currentAccounts.Add(new CurrentAccountModel(3, 1000, 10000));
            currentAccounts.Add(new CurrentAccountModel(4, -5000, 20000));
        }
        private static List<CurrentAccountModel> currentAccounts = new List<CurrentAccountModel>();

        private static List<SavingsAccountModel> savingsAccounts = new List<SavingsAccountModel>();

        private static SystemDB instance = null;
        public static SystemDB GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SystemDB();
                return instance;
            }
        }

        public List<SavingsAccountModel> getSavingsAccounts()
        {
            return savingsAccounts;
        }

        public List<CurrentAccountModel> getCurrentAccounts()
        {
            return currentAccounts;
        }

    }
}
