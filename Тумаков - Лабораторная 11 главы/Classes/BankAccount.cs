namespace Тумаков___Лабораторная_11_главы.Classes
{
    public class BankAccount
    {

        private static ulong lastAccountNumber = 1001100110011001;


        private ulong accountNumber;
        private decimal balance;
        private AccountType accountType;


        public ulong AccountNumber { get; }


        public decimal Balance { get; }


        public AccountType AccountType { get; }

        private static ulong GenerateAccountNumber()
        {
            return lastAccountNumber++;
        }

        public BankAccount()
        {
            this.accountNumber = GenerateAccountNumber();
            this.balance = 0;
            this.accountType = AccountType.Текущий;
        }

        public BankAccount(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Начальный баланс не может быть отрицательным\n");
            }

            this.accountNumber = GenerateAccountNumber();
            this.balance = initialBalance;
            this.accountType = AccountType.Текущий;
        }
        public BankAccount(AccountType accountType)
        {
            this.accountNumber = GenerateAccountNumber();
            this.balance = 0;
            this.accountType = accountType;
        }
        public BankAccount(AccountType accountType, decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Начальный баланс не может быть отрицательным\n");
            }

            this.accountNumber = GenerateAccountNumber();
            this.accountType = accountType;
            this.balance = initialBalance;
        }


        public bool Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Сумма для снятия не может быть отрицательной\n");
                return false;
            }

            if (amount > balance)
            {
                Console.WriteLine("Недостаточно средств на счете\n");
                return false;
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Снято {amount}. Новый баланс: {balance}\n");
                return true;
            }
        }


        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Сумма для пополнения не может быть отрицательной\n");
                return;
            }

            balance += amount;
            Console.WriteLine($"Положено {amount}. Новый баланс: {balance}\n");
        }


        public bool Transfer(BankAccount paymentAccount, BankAccount destinationAccount, decimal amount)
        {
            if (destinationAccount == null && destinationAccount is not BankAccount)
            {
                Console.WriteLine("Указан недействительный счет назначения\n");
                return false;
            }

            if (amount < 0)
            {
                Console.WriteLine("Сумма для перевода не может быть отрицательной\n");
                return false;
            }

            Console.WriteLine($"Перевод c счёта {paymentAccount.AccountNumber} на счёт {destinationAccount.AccountNumber}:");
            if (paymentAccount.Withdraw(amount))
            {
                destinationAccount.Deposit(amount);
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is BankAccount exampleAccount)
            {
                return this.accountNumber == exampleAccount.accountNumber;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return accountNumber.GetHashCode();
        }

        public static bool operator ==(BankAccount a, BankAccount b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            return a.Equals(b);
        }

        public static bool operator !=(BankAccount a, BankAccount b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return $"Счет: {accountNumber}, Баланс: {balance}, Тип счёта: {accountType}";
        }

    }
}
