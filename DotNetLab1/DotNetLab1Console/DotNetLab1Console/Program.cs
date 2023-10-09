
using Account;
using System;

namespace Account
{
    public class Program
    {
        private static void Main(string[] args)
        {

            List<Account> accounts = new List<Account>();
            
            Account user1 = new Account();
            user1.account(1111222233334444, 1000, 1234);
            accounts.Add(user1);

            Account user2 = new Account();
            user2.account(1000200030004000, 12000, 1000);
            accounts.Add(user2);

            List<AutomatedTellerMachine> ATMs = new List<AutomatedTellerMachine>();

            AutomatedTellerMachine ATM1 = new AutomatedTellerMachine(10_000,0001,"center");
            AutomatedTellerMachine ATM2 = new AutomatedTellerMachine(6_000, 0002, "dastor");
            AutomatedTellerMachine ATM3 = new AutomatedTellerMachine(3_000, 0003, "global");
            ATMs.Add( ATM1 );
            ATMs.Add(ATM2);
            ATMs.Add(ATM3);

            Bank Privat_Bank = new Bank();
            Privat_Bank.Accounts = accounts;
            Privat_Bank.BankName = "Privat Bank";
            Privat_Bank.ATMs = ATMs;

            while (true)
            {
                Console.WriteLine("Введiть номер карти:");

                long cardNumber;
                cardNumber = long.Parse(Console.ReadLine());

                Account selectedAccount = accounts.Find(acc => acc.CardNuber == cardNumber);

                if (selectedAccount != null)
                {
                    for (int i = 3; i >0; i--)
                    {

                        Console.WriteLine("Введите PIN:");

                        int pin = Int32.Parse(Console.ReadLine());

                        if (pin == selectedAccount.Pin)
                        {
                            while (true)
                            {
                                Console.WriteLine("1. Перегляд балансу");
                                Console.WriteLine("2. Зняття коштiв");
                                Console.WriteLine("3. Зарахування коштiв");
                                Console.WriteLine("4. Перерахування коштiв на iншу картку");
                                Console.WriteLine("0. Вихiд");

                                string choice = Console.ReadLine();

                                switch (choice)
                                {
                                    case "1":
                                        Console.WriteLine("На вашому рахунку " + ATM1.BalanceCheck(selectedAccount) + " грн!");
                                       
                                        break;
                                    case "2":
                                        while (true)
                                        {
                                            Console.WriteLine("Введiть сумму яку бажаєте зняти");
                                            int sumWithdraw = Int32.Parse(Console.ReadLine());
                                            if (selectedAccount.Balance> sumWithdraw)
                                            {
                                                if (ATM1.Withdraw(sumWithdraw, selectedAccount))
                                                {
                                                    Console.WriteLine("Тримайте " + sumWithdraw);
                                                    break;
                                                } else
                                                {
                                                   Console.WriteLine("В банкоматi немає такої кiлькостi грошей");
                                                }
                                            } else
                                            {
                                                Console.WriteLine("У вас недостатьньо коштiв!");
                                                Console.WriteLine("На вашому рахунку " + selectedAccount.Balance);
                                            }
                                                
                                        }
                                        break;
                                    case "3":
                                        Console.WriteLine("Введiть сумму яку бажаєте покласти");
                                        int sumDeposit = Int32.Parse(Console.ReadLine());
                                        ATM1.Deposit(sumDeposit, selectedAccount);
                                        break;
                                    case "4":
                                        Console.WriteLine("Введiть номер карти на яку бажаєте перевести кошти:");

                                        long secondCurdNuber = long.Parse(Console.ReadLine());

                                        Account secondAccount = accounts.Find(acc => acc.CardNuber == secondCurdNuber);

                                        if (secondAccount != null && secondAccount!=selectedAccount)
                                        {
                                            Console.WriteLine("Введiть сумму яку бажаєте перевести");
                                            int sumTransfer = Int32.Parse(Console.ReadLine());
                                            if (selectedAccount.Balance > sumTransfer)
                                            {
                                                ATM1.MoneyTransfer(sumTransfer, selectedAccount,secondAccount);
                                                Console.WriteLine("На рахунку " + selectedAccount.CardNuber +" "+ selectedAccount.Balance + "грн.");
                                                Console.WriteLine("На рахунку " + secondAccount.CardNuber + " " + secondAccount.Balance + "грн.");
                                            } else
                                            {
                                                Console.WriteLine("У вас недостатньо коштiв для переводу!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Не вiрно набраний номер карти");
                                            break;
                                        }
                                            break;
                                    case "0":
                                        Environment.Exit(0);
                                        break;
                                    default:
                                        Console.WriteLine("Невiрний вибiр. Спробуйте ще раз.");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Ви ввели не вiрнйи pin код залишилось {i} спроб!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Аккаунт с указанним номером карти не найдений.");
                }
            }
        }
    }
}
