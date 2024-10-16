namespace OOP_Ovning_ConstructorsFieldsProperties
{
    internal class BankAccount
    {
        private string _AccountNumber { get; }
        private decimal _balance { get; set; }

        public BankAccount(string accountNumber)
        {
            _AccountNumber = accountNumber;
            _balance = 0; //innitiated with 0
        }

        public void Deposit(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Du kan inte sätta in mindre än 0 kr.");
            }
            _balance += value;
            Console.WriteLine($"{value} kr har satts in på ditt konto.");
        }

        public void Withdrawal(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Du kan inte ta ut mindre än 0 kr.");
            }
            _balance -= value;
            Console.WriteLine($"{value} kr har tagits ut från ditt konto.");
        }

        public bool IsOverdrawn
        {
            get { return _balance < 0; }
        }

        //public bool IsOverdrawn => _balance < 0;
    }
}
