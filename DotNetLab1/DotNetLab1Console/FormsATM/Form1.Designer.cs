namespace FormsATM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cancel_btn = new Button();
            Ok_Btn = new Button();
            Check_Balance_Btn = new Button();
            Withdraw_btn = new Button();
            CashTrnsfer_btn = new Button();
            PanelContainer = new Panel();
            ATMCashErr = new Label();
            ReadyLabel = new Label();
            CashTranferSumErr = new Label();
            CardTransferErr = new Label();
            CashTrasferInput = new TextBox();
            CardTransferInput = new TextBox();
            CashTransitSumLabel = new Label();
            CardTransitLabel = new Label();
            CashTransferLabel = new Label();
            ATM_Err = new Label();
            Take_Cash_label = new Label();
            BalanceError = new Label();
            Withdraw_label = new Label();
            WithdrawInput = new TextBox();
            DepositLabel = new Label();
            Deposit_Input = new TextBox();
            Balance_Label = new Label();
            Deposit_Label = new Label();
            CashTransactionLabel = new Label();
            WithdrawLabel = new Label();
            CheckBalanceLabel = new Label();
            ExitLabel = new Label();
            BlockCardLabel = new Label();
            PassWordTryLabel = new Label();
            CanselLabel = new Label();
            Ok_label = new Label();
            EnterPassLabel = new Label();
            PasswordInput = new TextBox();
            State = new Label();
            EnterCardLabel = new Label();
            CardInput = new ComboBox();
            Num1 = new Button();
            num2 = new Button();
            num3 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            num9 = new Button();
            num8 = new Button();
            num7 = new Button();
            num0 = new Button();
            button1 = new Button();
            Deposit_Btn = new Button();
            ATMsInput = new ComboBox();
            ATMsLabel = new Label();
            PanelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(202, 339);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(107, 103);
            Cancel_btn.TabIndex = 1;
            Cancel_btn.Text = ">";
            Cancel_btn.UseVisualStyleBackColor = true;
            Cancel_btn.Click += Cancel_Btn_Click;
            // 
            // Ok_Btn
            // 
            Ok_Btn.Location = new Point(202, 205);
            Ok_Btn.Name = "Ok_Btn";
            Ok_Btn.Size = new Size(107, 103);
            Ok_Btn.TabIndex = 2;
            Ok_Btn.Text = ">";
            Ok_Btn.UseVisualStyleBackColor = true;
            Ok_Btn.Click += Ok_Btn_Click;
            // 
            // Check_Balance_Btn
            // 
            Check_Balance_Btn.Location = new Point(202, 475);
            Check_Balance_Btn.Name = "Check_Balance_Btn";
            Check_Balance_Btn.Size = new Size(107, 103);
            Check_Balance_Btn.TabIndex = 3;
            Check_Balance_Btn.Text = ">";
            Check_Balance_Btn.UseVisualStyleBackColor = true;
            Check_Balance_Btn.Click += Balance_Check_Click;
            // 
            // Withdraw_btn
            // 
            Withdraw_btn.Location = new Point(1116, 339);
            Withdraw_btn.Name = "Withdraw_btn";
            Withdraw_btn.Size = new Size(107, 103);
            Withdraw_btn.TabIndex = 4;
            Withdraw_btn.Text = "<";
            Withdraw_btn.UseVisualStyleBackColor = true;
            Withdraw_btn.Click += Withdraw_btn_Click;
            // 
            // CashTrnsfer_btn
            // 
            CashTrnsfer_btn.Location = new Point(1116, 475);
            CashTrnsfer_btn.Name = "CashTrnsfer_btn";
            CashTrnsfer_btn.Size = new Size(107, 103);
            CashTrnsfer_btn.TabIndex = 5;
            CashTrnsfer_btn.Text = "<";
            CashTrnsfer_btn.UseVisualStyleBackColor = true;
            CashTrnsfer_btn.Click += CashTrnsfer_btn_Click;
            // 
            // PanelContainer
            // 
            PanelContainer.BackColor = SystemColors.ActiveCaption;
            PanelContainer.Controls.Add(ATMCashErr);
            PanelContainer.Controls.Add(ReadyLabel);
            PanelContainer.Controls.Add(CashTranferSumErr);
            PanelContainer.Controls.Add(CardTransferErr);
            PanelContainer.Controls.Add(CashTrasferInput);
            PanelContainer.Controls.Add(CardTransferInput);
            PanelContainer.Controls.Add(CashTransitSumLabel);
            PanelContainer.Controls.Add(CardTransitLabel);
            PanelContainer.Controls.Add(CashTransferLabel);
            PanelContainer.Controls.Add(ATM_Err);
            PanelContainer.Controls.Add(Take_Cash_label);
            PanelContainer.Controls.Add(BalanceError);
            PanelContainer.Controls.Add(Withdraw_label);
            PanelContainer.Controls.Add(WithdrawInput);
            PanelContainer.Controls.Add(DepositLabel);
            PanelContainer.Controls.Add(Deposit_Input);
            PanelContainer.Controls.Add(Balance_Label);
            PanelContainer.Controls.Add(Deposit_Label);
            PanelContainer.Controls.Add(CashTransactionLabel);
            PanelContainer.Controls.Add(WithdrawLabel);
            PanelContainer.Controls.Add(CheckBalanceLabel);
            PanelContainer.Controls.Add(ExitLabel);
            PanelContainer.Controls.Add(BlockCardLabel);
            PanelContainer.Controls.Add(PassWordTryLabel);
            PanelContainer.Controls.Add(CanselLabel);
            PanelContainer.Controls.Add(Ok_label);
            PanelContainer.Controls.Add(EnterPassLabel);
            PanelContainer.Controls.Add(PasswordInput);
            PanelContainer.Controls.Add(State);
            PanelContainer.Controls.Add(EnterCardLabel);
            PanelContainer.Location = new Point(337, 42);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(745, 559);
            PanelContainer.TabIndex = 6;
            PanelContainer.Paint += panel1_Paint;
            // 
            // ATMCashErr
            // 
            ATMCashErr.AutoSize = true;
            ATMCashErr.Location = new Point(166, 488);
            ATMCashErr.Name = "ATMCashErr";
            ATMCashErr.Size = new Size(371, 32);
            ATMCashErr.TabIndex = 35;
            ATMCashErr.Text = "В банкоматі недостатньо коштів";
            ATMCashErr.Visible = false;
            // 
            // ReadyLabel
            // 
            ReadyLabel.AutoSize = true;
            ReadyLabel.Location = new Point(259, 198);
            ReadyLabel.Name = "ReadyLabel";
            ReadyLabel.Size = new Size(182, 32);
            ReadyLabel.TabIndex = 32;
            ReadyLabel.Text = "Перераховано!";
            ReadyLabel.Visible = false;
            // 
            // CashTranferSumErr
            // 
            CashTranferSumErr.AutoSize = true;
            CashTranferSumErr.Location = new Point(429, 504);
            CashTranferSumErr.Name = "CashTranferSumErr";
            CashTranferSumErr.Size = new Size(242, 32);
            CashTranferSumErr.TabIndex = 19;
            CashTranferSumErr.Text = "Не достатьно коштів";
            CashTranferSumErr.Visible = false;
            // 
            // CardTransferErr
            // 
            CardTransferErr.AutoSize = true;
            CardTransferErr.Location = new Point(29, 500);
            CardTransferErr.Name = "CardTransferErr";
            CardTransferErr.Size = new Size(349, 32);
            CardTransferErr.TabIndex = 31;
            CardTransferErr.Text = "Не коректно вказаний номер ";
            CardTransferErr.Visible = false;
            CardTransferErr.Click += CardTransferErr_Click;
            // 
            // CashTrasferInput
            // 
            CashTrasferInput.Location = new Point(429, 433);
            CashTrasferInput.Name = "CashTrasferInput";
            CashTrasferInput.Size = new Size(200, 39);
            CashTrasferInput.TabIndex = 19;
            CashTrasferInput.Visible = false;
            CashTrasferInput.WordWrap = false;
            // 
            // CardTransferInput
            // 
            CardTransferInput.Location = new Point(86, 433);
            CardTransferInput.Name = "CardTransferInput";
            CardTransferInput.Size = new Size(274, 39);
            CardTransferInput.TabIndex = 19;
            CardTransferInput.Visible = false;
            CardTransferInput.WordWrap = false;
            // 
            // CashTransitSumLabel
            // 
            CashTransitSumLabel.AutoSize = true;
            CashTransitSumLabel.Location = new Point(406, 380);
            CashTransitSumLabel.Name = "CashTransitSumLabel";
            CashTransitSumLabel.Size = new Size(279, 32);
            CashTransitSumLabel.TabIndex = 19;
            CashTransitSumLabel.Text = "Введіть сумму переказу";
            CashTransitSumLabel.Visible = false;
            // 
            // CardTransitLabel
            // 
            CardTransitLabel.AutoSize = true;
            CardTransitLabel.Location = new Point(108, 380);
            CardTransitLabel.Name = "CardTransitLabel";
            CardTransitLabel.Size = new Size(243, 32);
            CardTransitLabel.TabIndex = 19;
            CardTransitLabel.Text = "Введіть номер карти";
            CardTransitLabel.Visible = false;
            // 
            // CashTransferLabel
            // 
            CashTransferLabel.AutoSize = true;
            CashTransferLabel.Location = new Point(253, 297);
            CashTransferLabel.Name = "CashTransferLabel";
            CashTransferLabel.Size = new Size(187, 32);
            CashTransferLabel.TabIndex = 19;
            CashTransferLabel.Text = "Переказ коштів";
            CashTransferLabel.Visible = false;
            // 
            // ATM_Err
            // 
            ATM_Err.AutoSize = true;
            ATM_Err.Location = new Point(134, 433);
            ATM_Err.Name = "ATM_Err";
            ATM_Err.Size = new Size(464, 32);
            ATM_Err.TabIndex = 30;
            ATM_Err.Text = "Нажаль в банкомті немає стільки коштів";
            ATM_Err.Visible = false;
            // 
            // Take_Cash_label
            // 
            Take_Cash_label.AutoSize = true;
            Take_Cash_label.Location = new Point(244, 271);
            Take_Cash_label.Name = "Take_Cash_label";
            Take_Cash_label.Size = new Size(228, 32);
            Take_Cash_label.TabIndex = 19;
            Take_Cash_label.Text = "Візьміть ваші гроші";
            Take_Cash_label.Visible = false;
            // 
            // BalanceError
            // 
            BalanceError.AutoSize = true;
            BalanceError.Location = new Point(175, 433);
            BalanceError.Name = "BalanceError";
            BalanceError.Size = new Size(379, 32);
            BalanceError.TabIndex = 19;
            BalanceError.Text = "Нажаль у вас не вистачає коштів";
            BalanceError.Visible = false;
            // 
            // Withdraw_label
            // 
            Withdraw_label.AutoSize = true;
            Withdraw_label.Location = new Point(175, 271);
            Withdraw_label.Name = "Withdraw_label";
            Withdraw_label.Size = new Size(362, 32);
            Withdraw_label.TabIndex = 29;
            Withdraw_label.Text = "Введіть суму яку бажаєте зняти";
            Withdraw_label.Visible = false;
            // 
            // WithdrawInput
            // 
            WithdrawInput.Location = new Point(253, 361);
            WithdrawInput.Name = "WithdrawInput";
            WithdrawInput.Size = new Size(200, 39);
            WithdrawInput.TabIndex = 28;
            WithdrawInput.Visible = false;
            // 
            // DepositLabel
            // 
            DepositLabel.AutoSize = true;
            DepositLabel.Location = new Point(108, 271);
            DepositLabel.Name = "DepositLabel";
            DepositLabel.Size = new Size(508, 32);
            DepositLabel.TabIndex = 27;
            DepositLabel.Text = "Введіть сумму яку бажаєте покласи на карту";
            DepositLabel.Visible = false;
            // 
            // Deposit_Input
            // 
            Deposit_Input.Location = new Point(253, 361);
            Deposit_Input.Name = "Deposit_Input";
            Deposit_Input.Size = new Size(200, 39);
            Deposit_Input.TabIndex = 19;
            Deposit_Input.Visible = false;
            // 
            // Balance_Label
            // 
            Balance_Label.AutoSize = true;
            Balance_Label.Location = new Point(253, 279);
            Balance_Label.Name = "Balance_Label";
            Balance_Label.Size = new Size(0, 32);
            Balance_Label.TabIndex = 26;
            Balance_Label.Visible = false;
            // 
            // Deposit_Label
            // 
            Deposit_Label.AutoSize = true;
            Deposit_Label.Location = new Point(531, 198);
            Deposit_Label.Name = "Deposit_Label";
            Deposit_Label.Size = new Size(193, 32);
            Deposit_Label.TabIndex = 25;
            Deposit_Label.Text = "Покласти кошти";
            Deposit_Label.Visible = false;
            // 
            // CashTransactionLabel
            // 
            CashTransactionLabel.AutoSize = true;
            CashTransactionLabel.Location = new Point(479, 468);
            CashTransactionLabel.Name = "CashTransactionLabel";
            CashTransactionLabel.Size = new Size(245, 32);
            CashTransactionLabel.TabIndex = 24;
            CashTransactionLabel.Text = "Перерахувати кошти";
            // 
            // WithdrawLabel
            // 
            WithdrawLabel.AutoSize = true;
            WithdrawLabel.Location = new Point(571, 332);
            WithdrawLabel.Name = "WithdrawLabel";
            WithdrawLabel.Size = new Size(153, 32);
            WithdrawLabel.TabIndex = 23;
            WithdrawLabel.Text = "Зняти кошти";
            // 
            // CheckBalanceLabel
            // 
            CheckBalanceLabel.AutoSize = true;
            CheckBalanceLabel.Location = new Point(12, 468);
            CheckBalanceLabel.Name = "CheckBalanceLabel";
            CheckBalanceLabel.Size = new Size(238, 32);
            CheckBalanceLabel.TabIndex = 18;
            CheckBalanceLabel.Text = "Переглянути баланс";
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Location = new Point(12, 53);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(250, 32);
            ExitLabel.TabIndex = 22;
            ExitLabel.Text = "Завершити операцію";
            // 
            // BlockCardLabel
            // 
            BlockCardLabel.AutoSize = true;
            BlockCardLabel.ForeColor = Color.Red;
            BlockCardLabel.Location = new Point(184, 271);
            BlockCardLabel.Name = "BlockCardLabel";
            BlockCardLabel.Size = new Size(334, 32);
            BlockCardLabel.TabIndex = 21;
            BlockCardLabel.Text = "ВАША КАРТА ЗАБЛОКОВАНА";
            BlockCardLabel.Visible = false;
            // 
            // PassWordTryLabel
            // 
            PassWordTryLabel.AutoSize = true;
            PassWordTryLabel.Location = new Point(244, 433);
            PassWordTryLabel.Name = "PassWordTryLabel";
            PassWordTryLabel.Size = new Size(243, 32);
            PassWordTryLabel.TabIndex = 19;
            PassWordTryLabel.Text = "Залишилось спроб 3";
            PassWordTryLabel.Visible = false;
            // 
            // CanselLabel
            // 
            CanselLabel.AutoSize = true;
            CanselLabel.Location = new Point(12, 332);
            CanselLabel.Name = "CanselLabel";
            CanselLabel.Size = new Size(90, 32);
            CanselLabel.TabIndex = 18;
            CanselLabel.Text = "Стерти";
            // 
            // Ok_label
            // 
            Ok_label.AutoSize = true;
            Ok_label.Location = new Point(12, 198);
            Ok_label.Name = "Ok_label";
            Ok_label.Size = new Size(90, 32);
            Ok_label.TabIndex = 17;
            Ok_label.Text = "Готово";
            // 
            // EnterPassLabel
            // 
            EnterPassLabel.AutoSize = true;
            EnterPassLabel.Location = new Point(259, 311);
            EnterPassLabel.Name = "EnterPassLabel";
            EnterPassLabel.Size = new Size(181, 32);
            EnterPassLabel.TabIndex = 3;
            EnterPassLabel.Text = "Введіть пароль";
            EnterPassLabel.Visible = false;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(253, 361);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(200, 39);
            PasswordInput.TabIndex = 2;
            PasswordInput.Visible = false;
            // 
            // State
            // 
            State.AutoSize = true;
            State.Location = new Point(285, 157);
            State.Name = "State";
            State.Size = new Size(137, 32);
            State.TabIndex = 1;
            State.Text = "Авторизіця";
            // 
            // EnterCardLabel
            // 
            EnterCardLabel.AutoSize = true;
            EnterCardLabel.Location = new Point(269, 239);
            EnterCardLabel.Name = "EnterCardLabel";
            EnterCardLabel.Size = new Size(171, 32);
            EnterCardLabel.TabIndex = 0;
            EnterCardLabel.Text = "Введите карту";
            // 
            // CardInput
            // 
            CardInput.FormattingEnabled = true;
            CardInput.Location = new Point(1146, 764);
            CardInput.Name = "CardInput";
            CardInput.Size = new Size(269, 40);
            CardInput.TabIndex = 7;
            CardInput.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Num1
            // 
            Num1.Location = new Point(568, 619);
            Num1.Name = "Num1";
            Num1.Size = new Size(70, 70);
            Num1.TabIndex = 3;
            Num1.Text = "1";
            Num1.UseVisualStyleBackColor = true;
            Num1.Click += NumBtnClick;
            // 
            // num2
            // 
            num2.Location = new Point(655, 619);
            num2.Name = "num2";
            num2.Size = new Size(70, 70);
            num2.TabIndex = 8;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += NumBtnClick;
            // 
            // num3
            // 
            num3.Location = new Point(743, 619);
            num3.Name = "num3";
            num3.Size = new Size(70, 70);
            num3.TabIndex = 9;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += NumBtnClick;
            // 
            // num6
            // 
            num6.Location = new Point(743, 707);
            num6.Name = "num6";
            num6.Size = new Size(70, 70);
            num6.TabIndex = 12;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += NumBtnClick;
            // 
            // num5
            // 
            num5.Location = new Point(655, 707);
            num5.Name = "num5";
            num5.Size = new Size(70, 70);
            num5.TabIndex = 11;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += NumBtnClick;
            // 
            // num4
            // 
            num4.Location = new Point(568, 707);
            num4.Name = "num4";
            num4.Size = new Size(70, 70);
            num4.TabIndex = 10;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += NumBtnClick;
            // 
            // num9
            // 
            num9.Location = new Point(743, 794);
            num9.Name = "num9";
            num9.Size = new Size(70, 70);
            num9.TabIndex = 15;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += NumBtnClick;
            // 
            // num8
            // 
            num8.Location = new Point(655, 794);
            num8.Name = "num8";
            num8.Size = new Size(70, 70);
            num8.TabIndex = 14;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += NumBtnClick;
            // 
            // num7
            // 
            num7.Location = new Point(568, 794);
            num7.Name = "num7";
            num7.Size = new Size(70, 70);
            num7.TabIndex = 13;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += NumBtnClick;
            // 
            // num0
            // 
            num0.Location = new Point(655, 882);
            num0.Name = "num0";
            num0.Size = new Size(70, 70);
            num0.TabIndex = 16;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += NumBtnClick;
            // 
            // button1
            // 
            button1.Location = new Point(202, 60);
            button1.Name = "button1";
            button1.Size = new Size(107, 103);
            button1.TabIndex = 17;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Exit_button_Click;
            // 
            // Deposit_Btn
            // 
            Deposit_Btn.Location = new Point(1116, 205);
            Deposit_Btn.Name = "Deposit_Btn";
            Deposit_Btn.Size = new Size(107, 103);
            Deposit_Btn.TabIndex = 18;
            Deposit_Btn.Text = "<";
            Deposit_Btn.UseVisualStyleBackColor = true;
            Deposit_Btn.Click += Deposit_Btn_Click;
            // 
            // ATMsInput
            // 
            ATMsInput.FormattingEnabled = true;
            ATMsInput.Location = new Point(1269, 87);
            ATMsInput.Name = "ATMsInput";
            ATMsInput.Size = new Size(103, 40);
            ATMsInput.TabIndex = 33;
            ATMsInput.SelectedIndexChanged += ATMsInput_SelectedIndexChanged;
            // 
            // ATMsLabel
            // 
            ATMsLabel.AutoSize = true;
            ATMsLabel.Location = new Point(1208, 33);
            ATMsLabel.Name = "ATMsLabel";
            ATMsLabel.Size = new Size(207, 32);
            ATMsLabel.TabIndex = 34;
            ATMsLabel.Text = " Вибір банкомату";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 973);
            Controls.Add(ATMsLabel);
            Controls.Add(ATMsInput);
            Controls.Add(Deposit_Btn);
            Controls.Add(button1);
            Controls.Add(num0);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(Num1);
            Controls.Add(CardInput);
            Controls.Add(PanelContainer);
            Controls.Add(CashTrnsfer_btn);
            Controls.Add(Withdraw_btn);
            Controls.Add(Check_Balance_Btn);
            Controls.Add(Ok_Btn);
            Controls.Add(Cancel_btn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            PanelContainer.ResumeLayout(false);
            PanelContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Cancel_btn;
        private Button Ok_Btn;
        private Button Check_Balance_Btn;
        private Button Withdraw_btn;
        private Button CashTrnsfer_btn;
        private Panel PanelContainer;
        private Label EnterCardLabel;
        private ComboBox CardInput;
        private Label State;
        private TextBox PasswordInput;
        private Button Num1;
        private Button num2;
        private Button num3;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button num9;
        private Button num8;
        private Button num7;
        private Button num0;
        private Label EnterPassLabel;
        private Label CanselLabel;
        private Label Ok_label;
        private Label PassWordTryLabel;
        private Label BlockCardLabel;
        private Label ExitLabel;
        private Button button1;
        private Label CheckBalanceLabel;
        private Label CashTransactionLabel;
        private Label WithdrawLabel;
        private Label Deposit_Label;
        private Button Deposit_Btn;
        private Label Balance_Label;
        private TextBox Deposit_Input;
        private Label DepositLabel;
        private Label Withdraw_label;
        private TextBox WithdrawInput;
        private Label BalanceError;
        private Label Take_Cash_label;
        private Label ATM_Err;
        private Label CardTransitLabel;
        private Label CashTransferLabel;
        private TextBox CardTransferInput;
        private Label CashTransitSumLabel;
        private TextBox CashTrasferInput;
        private Label CardTransferErr;
        private Label CashTranferSumErr;
        private Label ReadyLabel;
        private ComboBox ATMsInput;
        private Label ATMsLabel;
        private Label ATMCashErr;
    }
}