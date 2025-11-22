using System.Data.Common;
using System.Runtime.ConstrainedExecution;
//
//internal class Car
//{
//    public string? model;
//    private int _currentSpeed;
//    protected string? engineType;
//    public void Accelerate(int speed)
//    {
//        if (speed > 0)
//        {
//            _currentSpeed += speed;
//            Console.WriteLine($"Разгон до {_currentSpeed}км/x");
//        }
//    }
//    private void CheckEngine()
//    {
//        Console.WriteLine("Проверка двигателя");
//
//    }
//    protected void SetEngine(string type)
//    {
//        engineType = type;
//    }
//
//    static void Main(string[] args)
//    {
//        Car myCar = new Car();
//
//        myCar.model = "hendau";
//        Console.WriteLine($"Модель:{myCar.model}");
//        myCar.Accelerate(20);
//    }
//}

//class Player
//{
//    private int health = 100;
//    public void TakeDamage(int damage)
//    {
//        if (damage > 0)
//        {
//            health -= damage;
//            Console.WriteLine($"Персонаж получил урон{damage}. Осталось здоровья: {health}");
//        }
//    }
//    public int GetHealth()
//    {
//        return health;
//    }
//    static void Main(string[] args)
//    {
//        Player player = new Player();
//        player.TakeDamage(56);
//        Console.WriteLine(player.GetHealth());
//    }
//}

//internal class Television
//{
//    private int volume = 100;
//    public void SetVolume(int newVolume)
//    {
//        if (newVolume >= 0 && newVolume <= 100)
//        {
//            volume = newVolume;
//            Console.WriteLine($"Громкость изменена:{volume}");
//        }
//        else
//        {
//            Console.WriteLine("Ошибка! Громкость должна быть от 0 до 100.");
//        }
//    }
//    static void Main(string[] args)
//    {
//        Television tv = new Television();
//        tv.SetVolume(78);
//        tv.SetVolume(150);
//    }
//}

//internal class BankAccount
//{
//    private decimal balance = 0m;
//    public void Deposit(decimal amount)
//    {
//        if (amount > 0)
//        {
//            balance += amount;
//            Console.WriteLine($"Пополнение:{amount}. Текущий баласнс.{balance}");
//
//        }
//    }
//    public void Withdraw(decimal amount)
//    {
//        if (amount > 0 && amount <= balance)
//        {
//            balance -= amount;
//            Console.WriteLine($"Снятие:{amount}.Остаток:{balance}");
//        }
//        else
//        {
//            Console.WriteLine("Недостаточно средств!");
//        }
//    }
//
//    static void Main(string[] args)
//    {
//        BankAccount bankAccount = new BankAccount();
//        bankAccount.Deposit(50);
//        bankAccount.Withdraw(23);
//    }
//
//}

//namespace OOPBasics
//{
//    internal class Person
//    {
//        int age;
//        public static int retirementAge = 65;
//        public Person(int age)
//        {
//            this.age = age;
//
//        }
//        public void CheckAge()
//        {
//            if (age >= retirementAge)
//                Console.WriteLine("Уже на пенсии");
//            else
//                Console.WriteLine($"Сколько лет осталось до пенсии:{retirementAge - age}");
//
//        }
//
//        static void Main(string[] args)
//        {
//            Person bob = new(68);
//            bob.CheckAge();
//            Person tom = new(37);
//            tom.CheckAge();
//            Console.WriteLine(Person.retirementAge);
//            Person.retirementAge = 67;
//        }
//    }
//}
//internal class CardPicker
//{
//    static Random Random = new Random();
//    public static string[] PickSomeCards(int numberOfCards)
//    {
//        string[] pickedCards = new string[numberOfCards];
//        for (int i = 0; i < numberOfCards; i++)
//        {
//            pickedCards[i] = RandomValue() + "" + RandomSuit();
//        }
//        return pickedCards;
//    }
//
//
//
//    private static string RandomSuit()
//    {
//        int value = Random.Next(1, 5);
//        if (value == 1) return "пик";
//        if (value == 2) return "червей";
//        if (value == 3) return "треф";
//        return "бубен";
//        throw new NotImplementedException();
//    }
//
//    private static string RandomValue()
//    {
//        int value = Random.Next(1, 14);
//        if (value == 1) return "Туз";
//        if (value == 11) return "Валет";
//        if (value == 12) return "Дама";
//        if (value == 13) return "Король";
//        return value.ToString();
//        throw new NotSupportedException();
//    }
//    static void Main(string[] args)
//    {
//        System.Console.WriteLine("Введите количество карт для выбора: ");
//        string? line = Console.ReadLine();
//    }
//    if (int.TryParse(line, out int numberOfCards))
//    {
//        foreach(string card in CardPicker.PickSomeCards(numberOfCards))
//        {
//            System.Console.WriteLine(card);
//        }
//    }
//    else
//    {
//        Console.WriteLine("Введите корректное число.");
//    }
//}
//   #1
//Book book1 = new Book();
//Book book2 = new Book("Война и мир", "Лев Толстой", 1869, true);
//Console.WriteLine("Первая книга:");
//book1.PrintInfo();
//Console.WriteLine("\nВторая книга:");
//book2.PrintInfo();

//   #2
//BankAccount bank = new BankAccount();
//bank.Deposit(1000);
//bank.Withdraw(500);
//bank.PrintBalance();

//   #3
//Car car = new Car();
//car.Accelerate(120);
//car.PrintSpeed();
//car.Brake();
//car.PrintSpeed();

//   #4
//Dice kub1 = new Dice(6);
//Dice kub2 = new Dice(12);
//Console.WriteLine($"6 гранный куб: {kub1.Roll()},{kub1.Roll()},{kub1.Roll()}");
//Console.WriteLine($"12 гранный куб: {kub2.Roll()},{kub2.Roll()},{kub2.Roll()}");

//   #5
//Character voin = new Character(200, 150);
//Character mag = new Character(54, 20);
//Character luhnik = new Character(36, 85);
//voin.Attack();
//mag.Attack();
//luhnik.Attack();