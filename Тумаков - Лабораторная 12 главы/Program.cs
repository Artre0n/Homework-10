using Тумаков___Лабораторная_12_главы.Classes;

class Programm
{
    static void Main()
    {
        Task12_1();
        Task12_2();
        Task12_11();
        Task12_22();

    }
    static void Task12_1()
    {
        Console.WriteLine("\nУпражнение 12.1\n");
        #region Условия задачи
        //Для класса банковский счет переопределить операторы == и != для
        //сравнения информации в двух счетах.Переопределить метод Equals аналогично оператору
        //==, не забыть переопределить метод GetHashCode().Переопределить метод ToString() для
        //печати информации о счете.Протестировать функционирование переопределенных методов
        //и операторов на простом примере.
        #endregion
        BankAccount account1 = new BankAccount(1000);

        BankAccount account2 = new BankAccount(500);

        BankAccount account3 = new BankAccount(500);

        Console.WriteLine(account2 == account1);
        Console.WriteLine(account3 == account1);
        Console.WriteLine(account1 != account2);

        Console.WriteLine(account1.Equals(account3));

        Console.WriteLine(account1);
    }
    static void Task12_2()
    {
        Console.WriteLine("\nУпражнение 12.2\n");
        #region Условия задачи
        //Создать класс рациональных чисел. В классе два поля – числитель и
        //знаменатель.Предусмотреть конструктор. Определить операторы ==, != (метод Equals()), <, 
        //>, <=, >=, +, – , ++, --.Переопределить метод ToString() для вывода дроби.Определить
        //операторы преобразования типов между типом дробь, float, int.Определить операторы *, /, %.
        #endregion

        RationalNumber rn1 = new RationalNumber(1, 2);
        RationalNumber rn2 = new RationalNumber(3, 4);

        Console.WriteLine($"Первое число: {rn1}");
        Console.WriteLine($"Второе число: {rn2}");
        Console.WriteLine($"Сумма: {rn1 + rn2}");
        Console.WriteLine($"Разность: {rn1 - rn2}");
        Console.WriteLine($"Произведение: {rn1 * rn2}");
        Console.WriteLine($"Деление: {rn1 / rn2}");
        Console.WriteLine($"Равенство: {((rn1 == rn2) ? "равны" : "не равны")}");
        Console.WriteLine($"Сравнение (>): {((rn1 > rn2) ? "Первое больше второго" : "Второе больше первого")}");
        Console.WriteLine($"Инкремент для первого числа: {++rn1}");
        Console.WriteLine($"Декремент декремент для второго: {--rn2}");
    }
    static void Task12_11()
    {
        Console.WriteLine("\nДомашнее задание 12.1\n");
        #region Условия задачи
        //На перегрузку операторов.Описать класс комплексных чисел. 
        //Реализовать операцию сложения, умножения, вычитания, проверку на равенство двух
        //комплексных чисел. Переопределить метод ToString() для комплексного числа.
        //Протестировать на простом примере.
        #endregion
        ComplexNumber num1 = new ComplexNumber(2, 2);
        ComplexNumber num2 = new ComplexNumber(2, 2);

        ComplexNumber sum = num1 + num2;
        ComplexNumber difference = num1 - num2;
        ComplexNumber product = num1 * num2;

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Разность: {difference}");
        Console.WriteLine($"Произведение: {product}");
        Console.WriteLine($"Равенство: {((num1 == num2) ? "равны" : "не равны")}");
    }
    
    public static void Task12_22()
    {
        Console.WriteLine("\nДомашнее задание 12.2\n");
        #region Условия задачи
        //Написать делегат, с помощью которого реализуется сортировка
        //книг.Книга представляет собой класс с полями Название, Автор, Издательство и
        //конструктором.Создать класс, являющийся контейнером для множества книг(массив книг). 
        //В этом классе предусмотреть метод сортировки книг.Критерий сортировки определяется
        //экземпляром делегата, который передается методу в качестве параметра. Каждый экземпляр
        //делегата должен сравнивать книги по какому-то одному полю: названию, автору, 
        //издательству.
        #endregion
        Library library = new Library();
        library.SortingLibrary(new DelegateSorted(library.Sort), 1);
        library.SortingLibrary(new DelegateSorted(library.Sort), 2);
        library.SortingLibrary(new DelegateSorted(library.Sort), 3);
    }
}





