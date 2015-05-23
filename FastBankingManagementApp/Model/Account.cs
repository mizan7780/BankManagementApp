using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBankingManagementApp.Model
{
    class Account
    {
        public string Customer_Name { get; set; }
        public string Account_Number { get; set; }
        public string email { get; set; }
        public string Opening_Date { get; set; }
        public decimal balance { get; set; }

        public void Deposit(decimal Amount)
        {
            balance += Amount;
        }

        public void Withdraw(decimal Amount)
        {
            balance -= Amount;
        }
    }
}
