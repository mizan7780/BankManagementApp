using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastBankingManagementApp.DAL;
using FastBankingManagementApp.Model;

namespace FastBankingManagementApp.BLL
{
    class Manager
    {
        GetWay getway = new GetWay();

        public string Save(Account anAccount)
        {
            int value;
            string accountNum = anAccount.Account_Number;

            if(!getway.isAccountNumerExists(accountNum))
            {
                if (anAccount.Account_Number.Length > 7)
                {
                    value = getway.Save(anAccount);
                    if (value > 0)
                    {
                        return "Save Successfull";
                    }
                    else
                    {
                        return "Save Failed!!!";
                    }
                }
                else
                {
                    return "Account Number must be at least 8 character";
                }
              
            }
            else
            {
                return "Account Number Already Exist!!!";
            }
           
           
        }

        public decimal Getbalance(string accountNo)
        {
            return getway.Getbalance(accountNo);
        }
        public string Deposit(Account anAccount, decimal Amount)
        {
            anAccount.Deposit(Amount);
            getway.Deposit(anAccount);

            return "Amount Deposited!!!";
        }
        public string Withdraw(Account anAccount,decimal Amount)
        {
            anAccount.Withdraw(Amount);
            getway.Withdraw(anAccount);

            return "Amount Withdrawn!!!";
        }
        public List<Account> searchAccount(string accountNo)
        {
           return getway.searchAccount(accountNo);
        }
    }
}
