using Account;
using FormsATM;

namespace Account
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            List<Account> accounts = new List<Account>();

            Account user1 = new Account();
            user1.account(1111222233334444, 1000, 1234);
            accounts.Add(user1);

            Account user2 = new Account();
            user2.account(1000200030004000, 12000, 1000);
            accounts.Add(user2);

            List<AutomatedTellerMachine> ATMs = new List<AutomatedTellerMachine>();

            AutomatedTellerMachine ATM1 = new AutomatedTellerMachine(10_000, 0001, "center");
            AutomatedTellerMachine ATM2 = new AutomatedTellerMachine(6_000, 0002, "dastor");
            AutomatedTellerMachine ATM3 = new AutomatedTellerMachine(3_000, 0003, "global");
            ATMs.Add(ATM1);
            ATMs.Add(ATM2);
            ATMs.Add(ATM3);

            Bank Privat_Bank = new Bank();
            Privat_Bank.Accounts = accounts;
            Privat_Bank.BankName = "Privat Bank";
            Privat_Bank.ATMs = ATMs;
        }
    }
}