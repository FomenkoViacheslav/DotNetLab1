using Account;
using System.Data.SqlTypes;
using System.Drawing.Text;

namespace FormsATM
{
    public partial class Form1 : Form
    {
        public List<Account.Account> accounts;
        public List<AutomatedTellerMachine> ATMs;
        public Bank Privat_Bank;
        public Account.Account Current_User;
        public Account.AutomatedTellerMachine Current_ATM;


        public Account.Account Current_Card;
        public Form1()
        {
            InitializeComponent();
            DisableTextBoxInput(this);
            accounts = new List<Account.Account>();
            Account.Account user1 = new Account.Account();
            user1.account(1111222233334444, 1000, 1234);
            accounts.Add(user1);
            Account.Account user2 = new Account.Account();
            user2.account(1000200030004000, 100000, 1000);
            accounts.Add(user2);
            AutomatedTellerMachine ATM1 = new AutomatedTellerMachine(10_000, 0001, "center");
            AutomatedTellerMachine ATM2 = new AutomatedTellerMachine(6_000, 0002, "dastor");
            AutomatedTellerMachine ATM3 = new AutomatedTellerMachine(3_000, 0003, "global");
            ATMs = new List<AutomatedTellerMachine>();
            Current_ATM = ATM1;
            ATMs.Add(ATM1);
            ATMs.Add(ATM2);
            ATMs.Add(ATM3);

            Privat_Bank = new Bank();
            Privat_Bank.Accounts = accounts;
            Privat_Bank.BankName = "Privat Bank";
            Privat_Bank.ATMs = ATMs;
            foreach (var ATM in ATMs)
            {
                ATMsInput.Items.Add(ATM.ATMId.ToString());
            }
            foreach (Control control in Controls)
            {
                if (control != ATMsInput)
                {
                    control.Enabled = false;
                }
            }

            Initialize();
        }

        private void DisableTextBoxInput(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).KeyPress += (sender, e) => e.Handled = true;
                }
                else if (control.HasChildren)
                {
                    DisableTextBoxInput(control);
                }
            }
        }
        private void Initialize()
        {
            Ok_label.Visible = false;
            CanselLabel.Visible = false;
            CheckBalanceLabel.Visible = false;
            WithdrawLabel.Visible = false;
            CashTransactionLabel.Visible = false;
            ExitLabel.Visible = false;
        }
        private void EnterPin()
        {
            foreach (Control control in Controls)
            {
                if (control == CardInput || control == ATMsInput)
                {
                    control.Enabled = false;
                }
                else
                {
                    control.Enabled = true;
                }
                if (control == Ok_Btn)
                {
                    control.Enabled = false;
                }
            }
            Ok_label.Visible = true;
            ExitLabel.Visible = true;
            CanselLabel.Visible = true;
            EnterPassLabel.Visible = true;
            PasswordInput.Visible = true;
            EnterCardLabel.Visible = false;
            PassWordTryLabel.Visible = true;
            BlockCardLabel.Visible = false;
            Check_Balance_Btn.Enabled = false;
            Deposit_Btn.Enabled = false;
            Withdraw_btn.Enabled = false;
            CashTrnsfer_btn.Enabled = false;
            PassWordTryLabel.Text = "Залишилось спроб 3";
        }
        private void RemoveProperties()
        {
            foreach (Control control in Controls)
            {
                if (control != CardInput)
                {
                    control.Enabled = false;
                }
            }
            ATMCashErr.Visible = false;
            ReadyLabel.Visible = false;
            CashTranferSumErr.Visible = true;
            CardTransferInput.Text = "";
            CashTrasferInput.Text = "";
            CashTrasferInput.Enabled = false;
            PassWordTryLabel.Text = "Залишилось спроб 3";
            Take_Cash_label.Visible = false;
            State.Text = "Авторизація";
            CheckBalanceLabel.Visible = false;
            Balance_Label.Visible = false;
            PassWordTryLabel.Visible = false;
            PasswordInput.Text = "";
            PasswordInput.Visible = false;
            EnterPassLabel.Visible = false;
            Balance_Label.Visible = false;
            CheckBalanceLabel.Visible = false;
            WithdrawLabel.Visible = false;
            CashTransactionLabel.Visible = false;
            Deposit_Label.Visible = false;
            Num_Btns_State(false);
            DepositLabel.Visible = false;
            Deposit_Input.Visible = false;
            WithdrawInput.Visible = false;
            Withdraw_label.Visible = false;
            ATM_Err.Visible = false;
            CashTransferLabel.Visible = false;
            CardTransitLabel.Visible = false;
            CardTransferInput.Visible = false;
            CashTrasferInput.Visible = false;
            CashTransitSumLabel.Visible = false;
            CardTransferErr.Visible = false;
            CashTranferSumErr.Visible = false;
        }

        private void Balance_Check_Click(object sender, EventArgs e)
        {
            BalanseCheck_monitor();
            Balance_Label.Text = "На вашому рахунку " + Current_ATM.BalanceCheck(Current_User).ToString() + " грн!";
        }
        private void BalanseCheck_monitor()
        {
            CheckBalanceLabel.Visible = false;
            Check_Balance_Btn.Enabled = false;
            Deposit_Btn.Enabled = false;
            Deposit_Label.Visible = false;
            Withdraw_btn.Enabled = false;
            WithdrawLabel.Visible = false;
            CashTransactionLabel.Visible = false;
            CashTrnsfer_btn.Enabled = false;
            CanselLabel.Visible = true;
            CanselLabel.Text = "Назад";
            Balance_Label.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, EventArgs e)
        {
        }
        private void Menu_monitor()
        {
            ATMCashErr.Visible = false;
            CashTranferSumErr.Visible = false;
            ATM_Err.Visible = false;
            State.Text = "Меню";
            CardTransferErr.Visible = false;
            CashTranferSumErr.Visible = false;
            Ok_Btn.Enabled = false;
            Ok_label.Visible = false;
            CanselLabel.Visible = false;
            CheckBalanceLabel.Visible = true;
            Check_Balance_Btn.Enabled = true;
            CashTransactionLabel.Visible = true;
            CashTrnsfer_btn.Enabled = true;
            WithdrawLabel.Visible = true;
            Withdraw_btn.Enabled = true;
            Deposit_Label.Visible = true;
            Deposit_Btn.Enabled = true;
            Balance_Label.Visible = false;
            Deposit_Input.Visible = false;
            DepositLabel.Visible = false;
            WithdrawInput.Visible = false;
            Withdraw_label.Visible = false;
            BalanceError.Visible = false;
            Take_Cash_label.Visible = false;
            CashTransferLabel.Visible = false;
            CardTransitLabel.Visible = false;
            CardTransferInput.Visible = false;
            CashTrasferInput.Visible = false;
            CashTransitSumLabel.Visible = false;
        }

        private void Ok_Btn_Click(object sender, EventArgs e)
        {
            if (PasswordInput.Visible)
            {

                char lastChar = PassWordTryLabel.Text[PassWordTryLabel.Text.Length - 1];
                int current_try = Int32.Parse(lastChar.ToString());
                if (Int32.Parse(PasswordInput.Text) == Current_User.Pin)
                {
                    Menu_monitor();
                    PasswordInput.Visible = false;
                    PassWordTryLabel.Visible = false;
                    EnterPassLabel.Visible = false;
                }
                else
                {
                    Ok_Btn.Enabled = false;
                    if (current_try == 1)
                    {
                        accounts.Remove(Current_User);
                        CardInput.Items.Remove(Current_User.CardNuber.ToString());
                        BlockCardLabel.Visible = true;
                        PassWordTryLabel.Visible = false;
                        PasswordInput.Visible = false;
                        EnterPassLabel.Visible = false;
                        CardInput.Enabled = true;
                        RemoveProperties();
                    }
                    current_try--;
                    string updatedLabelText = PassWordTryLabel.Text.Substring(0, PassWordTryLabel.Text.Length - 1) + current_try.ToString();
                    PassWordTryLabel.Text = updatedLabelText;
                    PasswordInput.Text = "";
                    if (current_try > 0)
                    {
                        Num_Btns_State(true);
                    }
                }
            }
            if (Deposit_Input.Visible)
            {
                Current_ATM.Deposit(Int32.Parse(Deposit_Input.Text), Current_User);
                Deposit_Input.Text = "";
                CanselLabel.Text = "Назад";
            }
            if (WithdrawInput.Visible)
            {
                if (Int32.Parse(WithdrawInput.Text) <= Current_User.Balance)
                {

                    if (Current_ATM.Withdraw(Int32.Parse(WithdrawInput.Text), Current_User))
                    {
                        WithdrawInput.Visible = false;
                        Withdraw_label.Visible = false;
                        Take_Cash_label.Visible = true;
                    }
                    else
                    {
                        ATMCashErr.Visible = true;
                        WithdrawInput.Text = "";
                    }
                }
                else
                {
                    BalanceError.Visible = true;
                    WithdrawInput.Text = "";
                }
                WithdrawInput.Text = "";
                CanselLabel.Text = "Назад";
            }
            if (CardTransitLabel.Visible)
            {
                Account.Account To_User = accounts.Find(account => account.CardNuber == long.Parse(CardTransferInput.Text));
                Current_ATM.MoneyTransfer(Int32.Parse(CashTrasferInput.Text), Current_User, To_User);
                CashTrasferInput.Enabled = false;
                ReadyLabel.Visible = true;
                CanselLabel.Text = "Назад";
                Ok_Btn.Enabled = false;
                Ok_label.Text = "Готово";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCardNumber = CardInput.SelectedItem?.ToString();

            Account.Account user = accounts.Find(account => account.CardNuber == long.Parse(selectedCardNumber));

            Current_User = user;

            if (!string.IsNullOrEmpty(selectedCardNumber))
            {
                EnterPin();
            }

        }

        private void NumBtnClick(object sender, EventArgs e)
        {
            if ((sender as Button).Enabled == true)
            {
                if (EnterPassLabel.Visible == true)
                {
                    PasswordInput.Text += (sender as Button).Text;
                    if (PasswordInput.Text.Length > 3)
                    {
                        Num_Btns_State(false);
                        Ok_Btn.Enabled = true;
                    }
                }

                if (DepositLabel.Visible)
                {
                    Deposit_Input.Text += (sender as Button).Text;
                    CanselLabel.Text = "Стерти";
                }

                if (Withdraw_label.Visible)
                {
                    WithdrawInput.Text += (sender as Button).Text;
                    CanselLabel.Text = "Стерти";
                    if (BalanceError.Visible)
                    {
                        BalanceError.Visible = false;
                    }
                    if (ATM_Err.Visible)
                    {
                        ATM_Err.Visible = false;
                    }
                    if (ATMCashErr.Visible)
                    {
                        ATMCashErr.Visible = false;
                    }
                }

                if (CardTransitLabel.Visible)
                {
                    if (CashTrasferInput.Enabled)
                    {
                        CashTrasferInput.Text += (sender as Button).Text;
                        CanselLabel.Text = "Стерти";
                        if (Int32.Parse(CashTrasferInput.Text) != 0 && CashTrasferInput.Text != "")
                        {
                            if (Int32.Parse(CashTrasferInput.Text) <= Current_User.Balance)
                            {
                                Ok_label.Text = "Перерахувати";
                                Ok_label.Visible = true;
                                Ok_Btn.Enabled = true;
                                CashTranferSumErr.Visible = false;
                            }
                            else
                            {
                                Ok_label.Visible = false;
                                Ok_Btn.Enabled = false;
                                CashTranferSumErr.Visible = true;
                            }
                        }
                    }
                    if (CardTransferInput.Enabled)
                    {
                        CardTransferInput.Text += (sender as Button).Text;
                        CanselLabel.Text = "Стерти";
                        CardTransferErr.Visible = false;
                        if (CardTransferInput.Text.Length == 16)
                        {
                            long CardToTransfer = long.Parse(CardTransferInput.Text);
                            bool isHave = false;
                            accounts.Find(account => account.CardNuber == CardToTransfer && account != Current_User ? isHave = true : isHave = false);

                            if (isHave)
                            {
                                CardTransferInput.Enabled = false;
                                CashTrasferInput.Enabled = true;
                                CashTrasferInput.Focus();
                                CanselLabel.Text = "Назад";

                            }
                            else
                            {
                                CardTransferInput.Text = "";
                                CardTransferErr.Visible = true;
                            }
                        }
                    }
                }
            }

        }
        private void Num_Btns_State(Boolean isActive)
        {
            Num1.Enabled = isActive;
            num0.Enabled = isActive;
            num2.Enabled = isActive;
            num3.Enabled = isActive;
            num4.Enabled = isActive;
            num5.Enabled = isActive;
            num6.Enabled = isActive;
            num7.Enabled = isActive;
            num8.Enabled = isActive;
            num9.Enabled = isActive;
        }
        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            if (PasswordInput.Visible == true && PasswordInput.Text.Length > 0)
            {
                PasswordInput.Text = PasswordInput.Text.Substring(0, PasswordInput.Text.Length - 1);
                if (num0.Enabled == false)
                {
                    Num_Btns_State(true);
                    Ok_Btn.Enabled = false;
                }
            }
            if (Balance_Label.Visible)
            {
                Menu_monitor();

            }
            if (DepositLabel.Visible)
            {
                if (Deposit_Input.Text.Length > 0)
                {
                    Deposit_Input.Text = Deposit_Input.Text.Substring(0, Deposit_Input.Text.Length - 1);
                    if (Deposit_Input.Text.Length == 0)
                    {
                        CanselLabel.Text = "Назад";
                    }
                }
                else
                {
                    CanselLabel.Text = "Назад";
                    Menu_monitor();
                }
            }
            if (Take_Cash_label.Visible)
            {
                Menu_monitor();
            }
            if (WithdrawInput.Visible)
            {
                if (WithdrawInput.Text.Length > 0)
                {
                    WithdrawInput.Text = WithdrawInput.Text.Substring(0, WithdrawInput.Text.Length - 1);
                    if (WithdrawInput.Text.Length == 0)
                    {
                        CanselLabel.Text = "Назад";
                    }
                }
                else
                {
                    CanselLabel.Text = "Назад";
                    Menu_monitor();
                }
            }
            if (ReadyLabel.Visible)
            {
                Menu_monitor();
                ReadyLabel.Visible = false;
            }
            if (CardTransferInput.Visible)
            {
                if (CardTransferInput.Enabled)
                {
                    if (CardTransferInput.Text.Length == 0)
                    {
                        Menu_monitor();
                        CardTransferInput.Enabled = false;
                    }
                    else
                    {
                        CardTransferInput.Text = CardTransferInput.Text.Substring(0, CardTransferInput.Text.Length - 1);
                        CanselLabel.Text = "Стерти";
                        if (CardTransferInput.Text.Length == 0)
                        {
                            CanselLabel.Text = "Назад";
                        }
                    }
                }
                if (CashTrasferInput.Enabled)
                {

                    if (CashTrasferInput.Text.Length == 0)
                    {
                        CardTransferInput.Enabled = true;
                        CashTrasferInput.Enabled = false;
                    }
                    else
                    {
                        CashTrasferInput.Text = CashTrasferInput.Text.Substring(0, CashTrasferInput.Text.Length - 1);
                        CanselLabel.Text = "Стерти";
                        if (CashTrasferInput.Text.Length == 0)
                        {
                            CanselLabel.Text = "Назад";
                        }
                        else
                        {
                            if (Int32.Parse(CashTrasferInput.Text) <= Current_User.Balance && CashTrasferInput.Text != null && Int32.Parse(CashTrasferInput.Text) != 0)
                            {
                                Ok_label.Text = "Перерахувати";
                                Ok_label.Visible = true;
                                Ok_Btn.Enabled = true;
                                CashTranferSumErr.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            RemoveProperties();
            PassWordTryLabel.Text = "Залишилось спроб 3";
            CardInput.Enabled = true;
            CardInput.Text = "";
            Ok_label.Visible = false;
            CanselLabel.Visible = false;
            EnterCardLabel.Visible = true;
            ExitLabel.Visible = false;
        }

        private void Withdraw_Button_Click(object sender, EventArgs e)
        {

        }

        private void Cash_Tranzaktion_Button_Click(object sender, EventArgs e)
        {

        }
        private void Deposit_Btn_Click(object sender, EventArgs e)
        {
            Deposit_monitor();
        }

        private void Deposit_monitor()
        {
            WithdrawLabel.Visible = false;
            Withdraw_btn.Enabled = false;
            CashTransactionLabel.Visible = false;
            CashTrnsfer_btn.Enabled = false;
            CheckBalanceLabel.Visible = false;
            Check_Balance_Btn.Enabled = false;
            Ok_Btn.Enabled = true;
            Ok_label.Visible = true;
            CanselLabel.Visible = true;
            Cancel_btn.Enabled = true;
            DepositLabel.Visible = true;
            Deposit_Input.Visible = true;
            Deposit_Label.Visible = false;
            CanselLabel.Text = "Назад";
            Num_Btns_State(true);
        }

        private void Withdraw_btn_Click(object sender, EventArgs e)
        {
            Num_Btns_State(true);
            Deposit_Label.Visible = false;
            Deposit_Btn.Enabled = false;
            CheckBalanceLabel.Visible = false;
            Check_Balance_Btn.Enabled = false;
            CashTrnsfer_btn.Enabled = false;
            CashTransactionLabel.Visible = false;
            WithdrawLabel.Visible = false;
            Ok_Btn.Enabled = true;
            Ok_label.Visible = true;
            CanselLabel.Visible = true;
            CanselLabel.Text = "Назад";
            Withdraw_label.Visible = true;
            WithdrawInput.Visible = true;
        }
        private void CashTrnsfer_btn_Click(object sender, EventArgs e)
        {
            CashTrasferInput.Visible = true;
            CashTrasferInput.Enabled = false;
            CardTransferInput.Enabled = true;
            CardTransferInput.Text = "";
            CashTrasferInput.Text = "";
            Deposit_Btn.Enabled = false;
            Deposit_Label.Visible = false;
            WithdrawLabel.Visible = false;
            Withdraw_btn.Enabled = false;
            CheckBalanceLabel.Visible = false;
            Check_Balance_Btn.Enabled = false;
            CashTransactionLabel.Visible = false;
            CashTransferLabel.Visible = true;
            CardTransitLabel.Visible = true;
            CardTransferInput.Visible = true;
            CashTrasferInput.Visible = true;
            CashTransitSumLabel.Visible = true;
            CashTrasferInput.Enabled = false;
            CardTransferErr.Visible = false;
            CashTranferSumErr.Visible = false;
            Num_Btns_State(true);
            CanselLabel.Text = "Назад";
            CanselLabel.Visible = true;
        }

        private void CardTransferErr_Click(object sender, EventArgs e)
        {

        }

        private void ATMsInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            ATMsInput.Enabled = false;
            string selectedATM = ATMsInput.SelectedItem?.ToString();

            Account.AutomatedTellerMachine ATM = ATMs.Find(atm => atm.ATMId == Int32.Parse(selectedATM));
            Current_ATM = ATM;
            CardInput.Enabled = true;
            foreach (var account in accounts)
            {
                CardInput.Items.Add(account.CardNuber.ToString());
            }
            foreach (Control control in Controls)
            {
                if (control != CardInput)
                {
                    control.Enabled = false;
                }
            }
        }
    }
}