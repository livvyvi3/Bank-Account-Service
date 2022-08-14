using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Account_Service.Models;

namespace Bank_Account_Service.Interface
{
    
        public interface ISystemDB
        {
            List<SavingsAccountModel> getSavingsAccounts();
            List<CurrentAccountModel> getCurrentAccounts();
    }
    
}
