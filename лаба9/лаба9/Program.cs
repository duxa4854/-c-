//using HtmlAgilityPack;
//using MyClass;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Threading;
//using System.Threading.Tasks;
//using static OOP.Program;
//
//namespace OOP
//{
//    internal class Program
//    {
//        public delegate void MessageHandler(string text);
//        public delegate void NumberHandler(int number);
//        public delegate void TemperatureEventHandler(string message);
//        public delegate void MotionEventHandler(string message);
//
//        static void Main(string[] args)
//        {
//            Person2 anton = new Person2("Anton");
//
//            Fruit apple = new Fruit { Name = "Яблоко", Quantity = 5 };
//            string json = JsonConvert.SerializeObject(apple);
//            Console.WriteLine("B JSON: " + json);
//            var deserialized = JsonConvert.DeserializeObject<Fruit>(json);
//            Console.WriteLine($"Объект: {deserialized?.Name} – {deserialized?.Quantity} ur.");
//
//            MessageHandler handler = ShowMessage;
//            handler("Привет, мир!");
//
//            NumberHandler numberHandler = Double;
//            numberHandler += Square;
//            numberHandler(5);
//
//            Player player = new Player();
//            player.OnDeath += () => Console.WriteLine("Враги празднуют победу!");
//            player.OnDeath += ShowGameOver;
//            player.TakeDamage(100);
//
//            var tempSensor = new TemperatureSensor();
//            var motionSensor = new MotionSensor();
//            var smartLight = new SmartLight();
//
//            tempSensor.OnOverheat += Notifier.SendTemperatureAlert;
//            motionSensor.OnMotionDetected += Notifier.LogMotionEvent;
//            motionSensor.OnMotionDetected += smartLight.TurnOn;
//
//            Console.WriteLine("=== Симуляция умного дома ===");
//            tempSensor.CheckTemperature(15);
//            tempSensor.CheckTemperature(35);
//            motionSensor.DetectMotion(false);
//            motionSensor.DetectMotion(true);
//            smartLight.TurnOn("Обнаружение движение");
//            Thread.Sleep(3000);
//            smartLight.TurnOff();
//        }
//
//        static void ShowMessage(string message)
//        {
//            Console.WriteLine($"Сообщение: {message}");
//        }
//
//        static void Double(int num)
//        {
//            Console.WriteLine($"Удвоено: {num * 2}");
//        }
//
//        static void Square(int num)
//        {
//            Console.WriteLine($"Квадрат: {num * num}");
//        }
//
//        static void ShowGameOver()
//        {
//            Console.WriteLine("GAME OVER");
//        }
//    }
//
//    public class Fruit
//    {
//        public string? Name { get; set; }
//        public int Quantity { get; set; }
//    }
//
//    public class Player
//    {
//        public event Action OnDeath;
//        private int health = 100;
//
//        public void TakeDamage(int damage)
//        {
//            health -= damage;
//            if (health <= 0)
//            {
//                Die();
//            }
//        }
//
//        private void Die()
//        {
//            Console.WriteLine("Игрок погиб!");
//            OnDeath?.Invoke();
//        }
//    }
//
//    public class TemperatureSensor
//    {
//        public event TemperatureEventHandler OnOverheat;
//
//        public void CheckTemperature(int currentTemp)
//        {
//            if (currentTemp > 30)
//            {
//                OnOverheat?.Invoke($"!! Температура критическая: {currentTemp}°C!");
//            }
//        }
//    }
//
//    public class MotionSensor
//    {
//        public event MotionEventHandler OnMotionDetected;
//
//        public void DetectMotion(bool isMotion)
//        {
//            if (isMotion)
//            {
//                OnMotionDetected?.Invoke("!! Обнаружено движение в коридоре!");
//            }
//        }
//    }
//
//    public class Notifier
//    {
//        public static void SendTemperatureAlert(string message)
//        {
//            Console.WriteLine($"[Уведомление] {message}");
//        }
//
//        public static void LogMotionEvent(string message)
//        {
//            Console.WriteLine($"[Лог] {message} (время: {DateTime.Now})");
//        }
//    }
//
//    public class SmartLight
//    {
//        private bool isOn = false;
//
//        public void TurnOn(string message)
//        {
//            if (!isOn)
//            {
//                isOn = true;
//                Console.WriteLine("[Лампочка]! Включена (триггер: движение)");
//            }
//        }
//
//        public void TurnOff()
//        {
//            if (isOn)
//            {
//                isOn = false;
//                Console.WriteLine("[Лампочка]! Выключена (прошло время без движения)");
//            }
//        }
//    }
//}
//
//
//namespace MathLibrary
//{
//    public class MathTools
//    {
//        public int Add(int a, int b)
//        {
//            return a + b;
//        }
//
//        public int Multiply(int a, int b)
//        {
//            return a * b;
//        }
//    }
//}
//
//
//using HtmlAgilityPack;
//using System;
//using System.Threading.Tasks;
//
//class Program
//{
//    static async Task Main()
//    {
//        Console.Write("Введите URL сайта: ");
//        string? url = Console.ReadLine();
//
//        if (!string.IsNullOrWhiteSpace(url))
//        {
//            try
//            {
//                HttpClient client = new HttpClient();
//                string html = await client.GetStringAsync(url);
//                HtmlDocument doc = new HtmlDocument();
//                doc.LoadHtml(html);
//                var titleNode = doc.DocumentNode.SelectSingleNode("//title");
//                if (titleNode != null)
//                {
//                    Console.WriteLine($"Заголовок страницы: {titleNode.InnerText}");
//                }
//                else
//                {
//                    Console.WriteLine("Заголовок страницы не найден");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Ошибка: " + ex.Message);
//            }
//        }
//        else
//        {
//            Console.WriteLine("URL не может быть пустым.");
//        }
//    }
//}
//
//
//
//public delegate void Logger(string message);
//
//class Program
//{
//    static void LogToConsole(string message)
//    {
//        Console.WriteLine(message);
//    }
//
//    static void Main()
//    {
//        Logger logger = LogToConsole;
//        logger("Тестовое сообщение");
//    }
//}
//
//public class Thermometer
//{
//    public event Action TemperatureTooHigh;
//
//    public void Measure(int value)
//    {
//        if (value > 100)
//        {
//            TemperatureTooHigh?.Invoke();
//        }
//    }
//}
//
//class Program
//{
//    static void Main()
//    {
//        Thermometer thermometer = new Thermometer();
//        thermometer.TemperatureTooHigh += () => Console.WriteLine("Температура превышена!");
//        thermometer.Measure(105);
//    }
//}
//
//
//static void PrintLength(string? input)
//{
//    if (input != null)
//    {
//        Console.WriteLine($"Длина строки: {input.Length}");
//    }
//    else
//    {
//        Console.WriteLine("Строка отсутствует");
//    }
//}
//
//
//using Newtonsoft.Json;
//
//public class SmartLight
//{
//    public bool IsOn { get; private set; }
//    public int Brightness { get; set; } = 100;
//    public event Action<bool> OnStateChanged;
//
//    public void Toggle()
//    {
//        IsOn = !IsOn;
//        OnStateChanged?.Invoke(IsOn);
//    }
//}
//
//class Program
//{
//    static void Main()
//    {
//        SmartLight light = new SmartLight();
//        light.OnStateChanged += (state) => Console.WriteLine(state ? "Свет включён" : "Свет выключен");
//        light.Toggle();
//
//        string json = JsonConvert.SerializeObject(light);
//        Console.WriteLine(json);
//        var deserializedLight = JsonConvert.DeserializeObject<SmartLight>(json);
//    }
//}