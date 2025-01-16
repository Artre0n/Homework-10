using Тумаков___Лабораторная_11_главы.Classes;
using Тумаков___Лабораторная_11_главы;

class Program
{
    static void Main()
    {
        Task();
    }
    static void Task()
    {
        BankAccount account1 = new BankAccount(1000);

        BankAccount account2 = new BankAccount(500);

        BankAccount account3 = new BankAccount(500);

        Console.WriteLine(account2 == account1);
        Console.WriteLine(account3 == account1);
        Console.WriteLine(account1 != account2);

        Console.WriteLine(account1.Equals(account3));

        Console.WriteLine(account1);





    }
}