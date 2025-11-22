//using System.Reflection.Metadata.Ecma335;
//
//class Person
//{
//    string name = "Tom";
//    int age = 1;
//    public void SetAge(int value)
//    { age = value; }
//    public string Name { get { return name; } }
//    public void Print() => Console.WriteLine($"Name:{name} \nAge: {age}");
//    public int Age
//    {
//        set
//        {
//            if (value < 1 || value > 120)
//                Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
//            else
//                age = value;
//
//        }
//        get { return age; }
//    }
//
//
//    static void Main(string[] args)
//    {
//        Person person = new Person();
//        Console.WriteLine(person.Name);
//        person.SetAge(37);
//        person.Print();
//    }
//}
//
//
//public class Product
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//
//    private int _quantity;
//
//    public int Quantity
//    {
//        get => _quantity;
//        set
//        {
//            if (value < 0)
//                _quantity = 0;
//            else
//                _quantity = value;
//        }
//    }
//    public decimal TotalPrice
//    {
//        get { return Price * Quantity; }
//    }
//
//    static void Main(string[] args)
//    {
//        var apple = new Product { Name = "Яблоко", Price = 10.5m, Quantity = 5 };
//        var banana = new Product { Name = "Банан", Price = 7.2m, Quantity = -2 };
//        Console.WriteLine($"{apple.Name} x {apple.Quantity} = {apple.TotalPrice} Руб.");
//        Console.WriteLine($"{banana.Name} x {banana.Quantity} = {banana.TotalPrice} Руб.");
//    }
//}
//public class Hero
//{
//    public string Name { get; set; }
//    public int Mana { get; set; }
//    public int Level { get; set; }
//
//    private int _health;
//    private int _maxHealth;
//    public Hero(string name, int maxHealth)
//    {
//        Name = name;
//        _maxHealth = maxHealth;
//        _health = maxHealth;
//        Mana = 100;
//        Level = 1;
//    }
//    public int Health
//    {
//        get => _health;
//        set
//        {
//            if (value < 0)
//                _health = 0;
//            else if (value > _maxHealth)
//                _health = _maxHealth;
//            else
//                _health = value;
//        }
//
//    }
//    public string Status => _health > 0 ? "Жив" : "Погиб";
//
//    public void TakeDamage(int damage)
//    {
//        if (_health > 0)
//        {
//            Console.WriteLine($"{Name} уже погиб и не может получать урон.");
//            return;
//        }
//        Health -= damage;
//        Console.WriteLine($"{Name} получает {damage} урона. HP: {Health}|Статус: {Status}");
//        if (_health > 0)
//        {
//            Console.WriteLine($"{Name}погиб!");
//
//        }
//
//    }
//    public void Heal(int amount)
//    {
//        if (_health <= 0)
//        {
//            Console.WriteLine($"{Name} не может быть исцелен, так как он погиб ");
//            return;
//        }
//        Health += amount;
//        Console.WriteLine($"{Name} исцелен на {amount}. HP{Health}| Статус:{Status}");
//
//
//    }
//    static void Main(string[] args)
//    {
//        Hero hero = new Hero("Ривен", 120);
//        Console.WriteLine($"Имя героя: {hero.Name}\n Уровень героя:{hero.Level}\nМана:{hero.Mana}\nСтатус: {hero.Status}");
//        hero.TakeDamage(50);
//        hero.Heal(30);
//        hero.TakeDamage(200);
//        hero.Heal(50);
//    }
//}

//using MyApp.Models;
//
//public class Car
//{
//    public string Brand { get; set; }
//    public string Model { get; set; }
//    public int Year { get; set; }
//    public int Mileage { get; set; }
//
//    public void PrintInfo()
//    {
//        Console.WriteLine($"Марка: {Brand}");
//        Console.WriteLine($"Модель: {Model}");
//        Console.WriteLine($"Год выпуска: {Year}");
//        Console.WriteLine($"Пробег: {Mileage} км");
//        Console.WriteLine();
//    }
//}
//
//
//public struct Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//
//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }
//
//    public double DistanceTo(Point other)
//    {
//        return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
//    }
//}
//
//
//namespace MyApp.Models
//{
//    public class User
//    {
//        public string Name { get; set; }
//        public string Email { get; set; }
//        public bool IsActive { get; set; }
//
//        public void PrintInfo()
//        {
//            Console.WriteLine($"Имя: {Name}");
//            Console.WriteLine($"Email: {Email}");
//            Console.WriteLine($"Активен: {(IsActive ? "Да" : "Нет")}");
//        }
//    }
//}
//
//
//public class ValueChecker
//{
//    public void CheckType(object input)
//    {
//        Console.WriteLine($"Переданное значение: {input}");
//        Console.WriteLine($"Тип: {input.GetType()}");
//
//        if (input is ValueType)
//        {
//            Console.WriteLine("Это значимый тип (value type)");
//        }
//        else
//        {
//            Console.WriteLine("Это ссылочный тип (reference type)");
//        }
//
//        if (input is int)
//        {
//            Console.WriteLine("Это целое число (int)");
//        }
//        else if (input is string)
//        {
//            Console.WriteLine("Это строка (string)");
//        }
//        else if (input is double)
//        {
//            Console.WriteLine("Это число с плавающей точкой (double)");
//        }
//
//        Console.WriteLine();
//    }
//}
//
//
//
//namespace MyApp
//{
//    public class System
//    {
//        public string Version { get; set; } = "1.0";
//    }
//}
//
//
//
//public class Rectangle
//{
//    private double width;
//    private double height;
//
//    public double Width
//    {
//        get { return width; }
//        set { width = value <= 0 ? 1 : value; }
//    }
//
//    public double Height
//    {
//        get { return height; }
//        set { height = value <= 0 ? 1 : value; }
//    }
//
//    public double Area
//    {
//        get { return Width * Height; }
//    }
//
//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }
//
//    public void PrintInfo()
//    {
//        Console.WriteLine($"Ширина: {Width}");
//        Console.WriteLine($"Высота: {Height}");
//        Console.WriteLine($"Площадь: {Area}");
//        Console.WriteLine();
//    }
//}


