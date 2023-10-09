
namespace Account
{
    public class AutomatedTellerMachine
    {
        public int Cash { get; private set; }
        public int ATMId { get; private set; }
        public string Address { get; private set; }

        public AutomatedTellerMachine(int cash, int atmId, string address)
        {
            Cash = cash;
            ATMId = atmId;
            Address = address;
        }

        public void MoneyTransfer(int sum ,Account from,Account to)
        {
            Cash = +sum;
            from.Balance -= sum;
            to.Balance += sum;
        }

        public bool Withdraw(int sum,Account account)
        {
            if(Cash > sum)
            {
                account.Balance -= sum;
                return true;

            } else
            {
                return false;
            }
        }
        public int BalanceCheck(Account account)
        {
            return account.Balance;
        }
        public void Deposit(int sum, Account account)
        {
            account.Balance += sum;
            Cash += sum;
        }
    }
}