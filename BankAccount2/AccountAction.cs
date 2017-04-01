namespace BankAccount2
{
    public class AccountAction
        {   //Fields
            public decimal balance;
            //Constructor
            public AccountAction()
            {
                this.balance = balance;
            }
            //Methods
            public virtual void DepositMoney(decimal balance, decimal deposit)
            {
                balance += deposit;
            }

            public virtual void WithdrawMoney(decimal balance, decimal withdraw)
            {
                withdraw -= balance;
            }
        }
   }


