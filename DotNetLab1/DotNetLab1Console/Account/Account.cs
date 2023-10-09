namespace Account
{
    public class Account
    {
        public long CardNuber { get; set; }
        public int Balance { get; set; }
        public int Pin { get; set; }

        public void account(long cardNuber, int balance, int pin)
        {
            CardNuber = cardNuber;
            Balance = balance;
            Pin = pin;
        }
    }
}