//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//
//namespace OOP
//{
//    internal class Program
//    {
//        public delegate void MessageHandler(string message);
//
//        static async Task Main(string[] args)
//        {
//            var player = new { Name = "Артур", Health = 100, Level = 5 };
//            Console.WriteLine($"Игрок: {player.Name}, Уровень: {player.Level}");
//
//            var products = new[]
//            {
//                new { Name = "Молоко", Price = 59.99, Category = "Продукты" },
//                new { Name = "Ноутбук", Price = 49990.00, Category = "Электроника" },
//                new { Name = "Щётка для зубов", Price = 120.50, Category = "Гигиена" }
//            };
//
//            Console.WriteLine("Список товаров:");
//            foreach (var product in products)
//            {
//                Console.WriteLine($"{product.Name} ({product.Category}) - {product.Price} P");
//            }
//
//            MessageHandler handler = delegate (string mes)
//            {
//                Console.WriteLine(mes);
//            };
//            handler("hello world!");
//
//            ShowMessage("hello!", delegate (string mes)
//            {
//                Console.WriteLine(mes);
//            });
//
//            Func<int, int> square = x => x * x;
//            Console.WriteLine(square(5));
//
//            Button button = new Button();
//            button.OnClick += () => Console.WriteLine("Кнопка нажата!");
//            button.Click();
//
//            Func<int, int, int> sum = (a, b) => a + b;
//            Console.WriteLine(sum(3, 7));
//
//            Func<int, string> numberToWord = num =>
//            {
//                switch (num)
//                {
//                    case 1: return "один";
//                    case 2: return "два";
//                    default: return "много";
//                }
//            };
//            Console.WriteLine(numberToWord(2));
//
//            MathOperation add = (a, b) => a + b;
//            Console.WriteLine(add(2, 3));
//
//            List<ISoundMaker> soundMakers = new List<ISoundMaker> { new Cat(), new Phone() };
//            foreach (var item in soundMakers)
//            {
//                item.MakeSound();
//            }
//
//            Book book = new Book { Name = "Война и мир" };
//            Console.WriteLine(book.Name);
//
//            Duck duck = new Duck();
//            ((IFlier)duck).Fly();
//            ((ISwimmer)duck).Swim();
//
//            Arena arena = new();
//            arena.AddUnit(new Warrior("Рагнар"));
//            arena.AddUnit(new Mage("Гендальф"));
//            arena.AddUnit(new Archer("Легопас"));
//            arena.StartBattle();
//
//            Console.WriteLine("1. Включили чайник...");
//            await BoilWaterAsync();
//            Console.WriteLine("3. Завариваем чай!");
//
//            Console.WriteLine("1. Включили чайник...");
//            Task boilTask = BoilWaterAsync();
//            Task sliceTask = SliceLemonAsync();
//            await Task.WhenAll(boilTask, sliceTask);
//            Console.WriteLine("4. Завариваем чай с лимоном!");
//
//            Console.WriteLine("Начинаем готовить ужин...");
//            await CookDinnerAsync();
//            Console.WriteLine("Ужин готов!");
//
//            foreach (int number in GenerateNumbers())
//            {
//                Console.WriteLine($"Получено число: {number}");
//            }
//
//            foreach (var step in WaitCoroutine())
//            {
//                Console.WriteLine(step);
//                Thread.Sleep(1000);
//            }
//            Console.WriteLine("Готово (коругина)!");
//
//            List<int> numbers = new List<int> { 5, 2, 9, 4, 7, 3, 8, 23, 45, 12, 34, 13, 98, 67, 56, 99 };
//
//            var result = numbers
//                .Where(n => n % 2 == 0)
//                .Select(n => n * 10)
//                .OrderByDescending(n => n);
//
//            Console.WriteLine("Результат (с LINQ):");
//            foreach (var num in result)
//            {
//                Console.WriteLine(num);
//            }
//
//            List<string> names = new List<string> { "Anna", "Иван", "Мария", "Пётр" };
//            var linqLongNames = names.Where(name => name.Length > 4);
//            foreach (var name in linqLongNames)
//            {
//                Console.WriteLine(name);
//            }
//
//            List<int> nums = new List<int> { 10, 5, 20, 3 };
//            int linqMin = nums.Min();
//            Console.WriteLine($"Минимальное число (c LINQ): {linqMin}");
//
//            List<int> numbers2 = new List<int> { 1, 2, 3, 4 };
//            var LinqSquares = numbers2.Select(n => n * n);
//            Console.WriteLine("Квадраты чисел (c LINQ):");
//            Console.WriteLine(string.Join(", ", LinqSquares));
//
//            List<Student> students = new()
//            {
//                new Student { Name = "Андрей", Score = 90 },
//                new Student { Name = "Вика", Score = 78 },
//                new Student { Name = "Денис", Score = 84 },
//                new Student { Name = "Лена", Score = 95 },
//                new Student { Name = "Олег", Score = 65 }
//            };
//
//            var goodStudents = students
//                .Where(s => s.Score > 80)
//                .OrderBy(s => s.Name);
//
//            var averageScore = students.Average(s => s.Score);
//
//            Console.WriteLine("Студенты с баллом > 80:");
//            foreach (var s in goodStudents)
//                Console.WriteLine($"{s.Name} - {s.Score}");
//
//            Console.WriteLine($"Средний балл: {averageScore:F1}");
//        }
//
//        static void ShowMessage(string message, MessageHandler handler)
//        {
//            handler(message);
//        }
//
//        static async Task BoilWaterAsync()
//        {
//            Console.WriteLine("2. Кипятим воду (ждём 3 секунды)...");
//            await Task.Delay(3000);
//            Console.WriteLine("...вода закипела!");
//        }
//
//        static async Task SliceLemonAsync()
//        {
//            Console.WriteLine("3. Режем лимон (ждём 2 секунды)...");
//            await Task.Delay(2000);
//            Console.WriteLine("...лимон порезан!");
//        }
//
//        public static async Task<string> MakeSoupAsync()
//        {
//            Console.WriteLine("Начали варить суп...");
//            await Task.Delay(3000);
//            return "Суп";
//        }
//
//        public static async Task<string> MakeSaladAsync()
//        {
//            Console.WriteLine("Начали резать салат...");
//            await Task.Delay(1000);
//            return "Салат";
//        }
//
//        public static async Task CookDinnerAsync()
//        {
//            Task<string> soupTask = MakeSoupAsync();
//            Task<string> saladTask = MakeSaladAsync();
//            string soup = await soupTask;
//            string salad = await saladTask;
//            Console.WriteLine($"Готово: {soup} и {salad}");
//        }
//
//        static IEnumerable<int> GenerateNumbers()
//        {
//            Console.WriteLine("Начинаем генерацию...");
//            yield return 1;
//            Console.WriteLine("Пауза...");
//            yield return 2;
//            Console.WriteLine("И ещё раз...");
//            yield return 3;
//            Console.WriteLine("Готово!");
//        }
//
//        static IEnumerable<string> WaitCoroutine()
//        {
//            yield return "Ждём... 1 секунда";
//            yield return "Ждём... 2 секунда";
//        }
//    }
//
//    public class Button
//    {
//        public event Action OnClick;
//
//        public void Click()
//        {
//            OnClick?.Invoke();
//        }
//    }
//
//    public interface ISoundMaker
//    {
//        void MakeSound();
//    }
//
//    public class Cat : ISoundMaker
//    {
//        public void MakeSound()
//        {
//            Console.WriteLine("May!");
//        }
//    }
//
//    public class Phone : ISoundMaker
//    {
//        public void MakeSound()
//        {
//            Console.WriteLine("Дэвинь-дэвинь!");
//        }
//    }
//
//    public interface INamed
//    {
//        string Name { get; set; }
//    }
//
//    public class Book : INamed
//    {
//        public string Name { get; set; }
//    }
//
//    public interface IFlier
//    {
//        void Fly();
//    }
//
//    public interface ISwimmer
//    {
//        void Swim();
//    }
//
//    public class Duck : IFlier, ISwimmer
//    {
//        public void Fly() => Console.WriteLine("Утка летит!");
//        public void Swim() => Console.WriteLine("Утка плывёт!");
//    }
//
//    public interface IUnit
//    {
//        string Name { get; }
//        int Health { get; }
//        void Attack(IUnit target);
//    }
//
//    public class Warrior : IUnit
//    {
//        public string Name { get; private set; }
//        public int Health { get; private set; }
//
//        public Warrior(string name)
//        {
//            Name = name;
//            Health = 150;
//        }
//
//        public void Attack(IUnit target)
//        {
//            Console.WriteLine($"{Name} рубит мечом {target.Name}!");
//        }
//    }
//
//    public class Mage : IUnit
//    {
//        public string Name { get; private set; }
//        public int Health { get; private set; }
//
//        public Mage(string name)
//        {
//            Name = name;
//            Health = 100;
//        }
//
//        public void Attack(IUnit target)
//        {
//            Console.WriteLine($"{Name} использует магию против {target.Name}!");
//        }
//    }
//
//    public class Archer : IUnit
//    {
//        public string Name { get; private set; }
//        public int Health { get; private set; }
//
//        public Archer(string name)
//        {
//            Name = name;
//            Health = 120;
//        }
//
//        public void Attack(IUnit target)
//        {
//            Console.WriteLine($"{Name} стреляет из лука в {target.Name}!");
//        }
//    }
//
//    public class Arena
//    {
//        private List<IUnit> _units = new();
//
//        public void AddUnit(IUnit unit)
//        {
//            _units.Add(unit);
//        }
//
//        public void StartBattle()
//        {
//            Console.WriteLine("Битва началась!");
//            foreach (var attacker in _units)
//            {
//                foreach (var defender in _units)
//                {
//                    if (attacker != defender)
//                        attacker.Attack(defender);
//                }
//            }
//        }
//    }
//
//    public class Student
//    {
//        public string Name;
//        public int Score;
//    }
//
//    public delegate int MathOperation(int a, int b);
//}



//      Задание       1
//var students = new[]
//{
//    new { Name = "Иван", Age = 20, Group = "ИСП-101" },
//    new { Name = "Мария", Age = 19, Group = "ИСП-102" },
//    new { Name = "Петр", Age = 21, Group = "ИСП-101" }
//};
//
//Console.WriteLine("Список студентов:");
//foreach (var student in students)
//{
//    Console.WriteLine($"{student.Name}\t{student.Age}\t{student.Group}");
//}
//      Задание       2
//List<int> numbers = Enumerable.Range(1, 20).ToList();
//
//List<int> evenNumbers = numbers.FindAll(n => n % 2 == 0);
//List<int> multiplesOfThree = numbers.FindAll(n => n % 3 == 0);
//
//Console.WriteLine("Чётные числа: " + string.Join(", ", evenNumbers));
//Console.WriteLine("Числа, кратные 3: " + string.Join(", ", multiplesOfThree));
//      Задание       3
//public interface IPrintable
//{
//    void PrintInfo();
//}
//
//public class Book : IPrintable
//{
//    public string Title { get; set; }
//    public void PrintInfo() => Console.WriteLine($"Книга: {Title}");
//}
//
//public class Magazine : IPrintable
//{
//    public string Name { get; set; }
//    public void PrintInfo() => Console.WriteLine($"Журнал: {Name}");
//}
//
//class Program
//{
//    static void Main()
//    {
//        List<IPrintable> items = new List<IPrintable>
//        {
//            new Book { Title = "Война и мир" },
//            new Magazine { Name = "Наука и техника" }
//        };
//
//        foreach (var item in items)
//        {
//            item.PrintInfo();
//        }
//    }
//}
//      Задание       4
//string[] cities = { "Москва", "Киев", "Минск", "Казань", "Краснодар" };
//
//var citiesStartingWithK = cities.Where(c => c.StartsWith("К"));
//var sortedByLength = citiesStartingWithK.OrderBy(c => c.Length);
//var longCities = cities.Where(c => c.Length > 6);
//
//Console.WriteLine("Города на 'К': " + string.Join(", ", citiesStartingWithK));
//Console.WriteLine("Отсортированы по длине: " + string.Join(", ", sortedByLength));
//Console.WriteLine("Города длиной > 6: " + string.Join(", ", longCities));
////      Задание       5
//static async Task<int> GetDataAsync()
//{
//    await Task.Delay(2000);
//    return 42;
//}
//
//static async Task Main()
//{
//    Console.WriteLine("Ждём данные…");
//    int result = await GetDataAsync();
//    Console.WriteLine("Данные получены: " + result);
//}
//      Задание       6
//public interface IPerson
//{
//    string Name { get; }
//    int Age { get; }
//    string GetDescription();
//}
//
//public class Student : IPerson
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public string Major { get; set; }
//
//    public string GetDescription() => $"Студент {Name}, {Age} лет, специальность: {Major}";
//}
//
//public class Teacher : IPerson
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public string Department { get; set; }
//
//    public string GetDescription() => $"Преподаватель {Name}, {Age} лет, кафедра: {Department}";
//}
//
//class Program
//{
//    static async Task Main()
//    {
//        var people = new List<IPerson>
//        {
//            new Student { Name = "Андрей", Age = 21, Major = "Информатика" },
//            new Student { Name = "Мария", Age = 19, Major = "Математика" },
//            new Teacher { Name = "Иван Петрович", Age = 45, Department = "Информатика" },
//            new Teacher { Name = "Ольга Сергеевна", Age = 38, Department = "Математика" }
//        };
//
//        var studentsOver20 = people.OfType<Student>().Where(s => s.Age > 20);
//        var csTeachers = people.OfType<Teacher>().Where(t => t.Department == "Информатика");
//
//        Console.WriteLine("Студенты старше 20 лет:");
//        foreach (var student in studentsOver20)
//        {
//            Console.WriteLine(student.GetDescription());
//        }
//
//        Console.WriteLine("\nПреподаватели кафедры Информатика:");
//        foreach (var teacher in csTeachers)
//        {
//            Console.WriteLine(teacher.GetDescription());
//        }
//
//        await LoadStudentsAsync();
//
//        var sortedPeople = people.OrderBy(p => p.Name).ToList();
//        Console.WriteLine("\nОтсортировано по имени:");
//        foreach (var person in sortedPeople)
//        {
//            Console.WriteLine(person.GetDescription());
//        }
//    }
//
//    static async Task LoadStudentsAsync()
//    {
//        Console.WriteLine("\nЗагрузка данных...");
//        await Task.Delay(2000);
//        Console.WriteLine("Данные загружены!");
//    }
//}