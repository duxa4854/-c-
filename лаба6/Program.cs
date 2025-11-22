//int x = int.Parse(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
//int res = x / y;
//Console.WriteLine($"результат: {res}");
//Console.WriteLine("Конец программы:");
//try
//{
//    int x = int.Parse(Console.ReadLine());
//    int y = Convert.ToInt32(Console.ReadLine());
//    int res = x / y;
//    Console.WriteLine($"результат: {res}");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"оШИБКА:{ex}");
//}
//catch (FormatException ex) {
//    Console.WriteLine();
//}
//finally
//{
//    Console.WriteLine("пРОДОЛЖЕНИЕ");
//}
//Console.WriteLine("Конец программы:");

//try{
//    Console.WriteLine("Введите первое число");
//    double number1 = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите второе число");
//    double number2 = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите операцию (+ * - /): ");
//    string? operation = Console.ReadLine();
//    double res = 0;
//    switch (operation)
//    {
//        case "+":
//            res = number1 + number2;
//            break;
//        case "-":
//            res = number1 - number2;
//            break;
//        case "*":
//            res = number1 * number2;
//            break;
//        case "/":
//            res = number1 / number2;
//            if (number2 == 0)
//                throw new DivideByZeroException
//            break;
//        default:
//            Console.WriteLine("неизвестная операция");
//            break;
//
//    }
//}
//catch (FormatException ex)
//{
//    Console.WriteLine($"{ex.Message}");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"{ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"{ex.Message}");
//}
//finally{
//    Console.WriteLine("Работа кальтулятор завершена");
//}
using System.Data;
using System.Linq.Expressions;
//
//int number = 12;
//Console.WriteLine(number.ToString());
//bool boolean = true;
//Console.WriteLine(boolean.ToString());
//DateTime now = DateTime.Now;
//Console.WriteLine(now.ToString());
//object me = new();
//Console.WriteLine(me.ToString());

//int age = int.Parse("27");
//DateTime birthday = DateTime.Parse("21 June 2007");
//Console.WriteLine($"i was born{age} years ago");
//Console.WriteLine($"My birthday is {birthday}");
//Console.WriteLine($"My birthday is {birthday:D}");

//Console.Write("Какой максимальный балл по дисциплинам? ");
//string? input = Console.ReadLine();
//if (int.TryParse(input, out int count))
//{
//    Console.WriteLine($"Это {count} баллов ");
//}
//else
//{
//    Console.WriteLine("Некорректный ввод ");
//}
//
//Console.WriteLine("Введите сумму: ");
//string? amout = Console.ReadLine();
//try
//{
//    decimal amoutValue = decimal.Parse(amout);
//}
//catch (FormatException) when (amout.Contains("$"))
//{
//    Console.WriteLine("В суммах нельзя использовать знак доллара!");
//}
//catch(FormatException)
//{
//    Console.WriteLine("Суммы должны содержать только цифры!");    
//}

//int x = int.MaxValue - 1;
//Console.WriteLine($"Intial value: {x}");
//x++;
//Console.WriteLine($"After incrementing: {x}");
//x++;
//Console.WriteLine($"After incrementing: {x}");
//x++;
//Console.WriteLine($"After incrementing: {x}");
//try
//{
//    checked
//    {
//        int x = int.MaxValue - 1;
//        Console.WriteLine($"Intial value: {x}");
//        x++;
//        Console.WriteLine($"After incrementing: {x}");
//        x++;
//        Console.WriteLine($"After incrementing: {x}");
//        x++;
//        Console.WriteLine($"After incrementing: {x}");
//    }
//}
//catch (OverflowException)
//{
//    Console.WriteLine("The code overfrowed but i caught the exception.");
//}
//
//static double Add(double a, double b )
//{
//    return a + b;
//}
//double a = 4.5;
//double b = 2.5;
//double answer = Add(a, b);
//Console.WriteLine($"{a}+{b}={answer}");
//Console.WriteLine("Нажмите ENTER чтобы продолжить. ");
//Console.ReadLine();
using System;
using System.Data.Common;

class Calculator
{
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) 
    {
        if (b == 0) 
        {
            Console.WriteLine("Ошибка: деление на ноль!");
            return 0;
        }
        return a / b;
    }
    static double Power(double a, double b) => Math.Pow(a, b);
    static void Main()
    {
        string command;
        do
        {
            Console.WriteLine("Простой калькулятор");
            Console.WriteLine("Введите 'exit' для выхода");
            Console.WriteLine("Доступные операции: +, -, *, /, ^");
            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите операцию: ");
            string? oper = Console.ReadLine();
            if (oper.ToLower() == "exit")
                break;
            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine()); 
            double res;
            switch (oper)
            {
                case "+": res = Add(number1, number2); break;
                case "-": res = Subtract(number1, number2); break;
                case "*": res = Multiply(number1, number2); break;
                case "/": res = Divide(number1, number2); break;
                case "^": res = Power(number1, number2); break;
                default: 
                    Console.WriteLine("Ошибка: неверная операция!");
                    continue;
            }
            Console.WriteLine($"Результат: {number1} {oper} {number2} = {res}");
            Console.Write("Нажмите Enter для продолжения...");
            Console.ReadLine(); 
        } while (true);
    }
}
