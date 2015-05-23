using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using FastBankingManagementApp.Model;

namespace FastBankingManagementApp.DAL
{
    class GetWay
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;

        public List<Account> searchAccount(string accountNumber)
        {
            string query = "select * from AccountInfo where accountNumber='" + accountNumber + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Account> accountList = new List<Account>();
            while (reader.Read())
            {
                Account anAccount = new Account();
                anAccount.Customer_Name = reader["customerName"].ToString();
                anAccount.Account_Number = reader["accountNumber"].ToString();
                anAccount.email = reader["email"].ToString();
                anAccount.Opening_Date = reader["openingDate"].ToString();
                anAccount.balance = Convert.ToDecimal(reader["balance"]);
                accountList.Add(anAccount);
            }
            reader.Close();
            connection.Close();
            return accountList;            
        }

        public decimal Getbalance(string accounNo)
        {
            decimal balance = 0;
            string query = "select * from AccountInfo where accountNumber='"+accounNo+"'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                balance = Convert.ToDecimal(reader["balance"]);
            }
            reader.Close();
            connection.Close();
            return balance;
        }

        public int Withdraw(Account anAccount)
        {
            string query = "update AccountInfo set balance=" + anAccount.balance + " where accountNumber='" + anAccount.Account_Number + "' ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
        public int Deposit(Account anAccount)
        {
            string query = "update AccountInfo set balance="+anAccount.balance+" where accountNumber='"+anAccount.Account_Number+"' ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
        public bool isAccountNumerExists(string AccountNo)
        {
            string query = "select * from AccountInfo where accountNumber='" + AccountNo + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            bool isAccountNumerExists=false;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                isAccountNumerExists = true;
            }
               
            reader.Close();
            connection.Close();
            return isAccountNumerExists;
        }
        public int Save(Account anAccount)
        {
            
            string query = "insert into AccountInfo values('"+anAccount.Customer_Name+"','"+anAccount.Account_Number+"','"+anAccount.email+"','"+anAccount.Opening_Date+"',"+anAccount.balance+") ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;

        }
    }
}
