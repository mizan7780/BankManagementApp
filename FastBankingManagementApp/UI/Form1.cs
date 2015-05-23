using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastBankingManagementApp.BLL;
using FastBankingManagementApp.Model;

namespace FastBankingManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Manager manager = new Manager();
        Account anAccount = new Account();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ClearText()
        {
            customerNameEntryTextBox.Text = "";
            accountNumberEntryTextBox.Text = "";
            customerEmailEntryTextBox.Text = "";
            customerAccountOpeningDateTextBox.Text = "";
        }
        private void accountSave_Button(object sender, EventArgs e)
        {
            anAccount.Customer_Name = customerNameEntryTextBox.Text;
            anAccount.Account_Number = accountNumberEntryTextBox.Text;
            anAccount.email = customerEmailEntryTextBox.Text;
            anAccount.Opening_Date = customerAccountOpeningDateTextBox.Text;
            anAccount.balance = 0;

            MessageBox.Show(manager.Save(anAccount));
            ClearText();
        }

        private void amountDeposit_Button_Click(object sender, EventArgs e)
        {
            anAccount.Account_Number = accountNumberForTransactionTextBox.Text;
            anAccount.balance = manager.Getbalance(anAccount.Account_Number);
            decimal Amount = Convert.ToDecimal(amountForTransactionTextBox.Text);

            MessageBox.Show(manager.Deposit(anAccount,Amount));

            accountNumberForTransactionTextBox.Text = "";
            amountForTransactionTextBox.Text = "";
        }

        private void amountWithdraw_Button(object sender, EventArgs e)
        {
            anAccount.Account_Number = accountNumberForTransactionTextBox.Text;
            anAccount.balance = manager.Getbalance(anAccount.Account_Number);
            decimal Amount = Convert.ToDecimal(amountForTransactionTextBox.Text);

            MessageBox.Show(manager.Withdraw(anAccount, Amount));

            accountNumberForTransactionTextBox.Text = "";
            amountForTransactionTextBox.Text = "";
        }

        private void Search_Button(object sender, EventArgs e)
        {
            AccountlistView.Items.Clear();

            foreach(Account anAccount in manager.searchAccount(SearchTextBox.Text))
            {
                ListViewItem item = new ListViewItem();
                item.Text = anAccount.Customer_Name;
                item.SubItems.Add(anAccount.Account_Number);
                item.SubItems.Add(anAccount.email);
                item.SubItems.Add(anAccount.Opening_Date);
                item.SubItems.Add(anAccount.balance.ToString());

                AccountlistView.Items.Add(item);
            }
        }
    }
}
