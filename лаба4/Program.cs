
// № 1
//string[] n = ["sword", "shield", "potion", "sword", "potion", "potion"];
//Console.WriteLine($"{n[0]}, {n[1]}, {n[2]}, {n[3]}, {n[4]}, {n[5]} ");
//№ 2
//int[] n = [10, 20, 15, 30, 25];
//int b = 0;
//foreach (int i in n)
//{
//    b += i;
//}
//Console.WriteLine(b);
//№ 3
//int[] n = [1, 3, 7, 2, 5];
//int max = n[0];
//for (int i = 1; i < n.Length; i++)
//{
//    if (n[i] > max)
//    {
//        max = n[i];
//    }
//}
//Console.WriteLine(max);
//№ 4
//int[] n = [1, 2, 3, 4, 5];
//int c = 0;
//int nc = 0;
//for (int i = 0; i < n.Length; i++)
//{
//    if (n[i] % 2 == 0)
//    {
//        c++;
//    }
//    else
//    {
//        nc++;
//    }
//}
//Console.WriteLine($"Чётные - {c}, Не чётные - {nc}");
//№ 5
//int[] n = [120, 95, 110, 105, 100];
//int min = n[0];
//for (int i = 1; i < n.Length; i++)
//{
//    if (n[i] < min)
//    {
//        min = n[i];
//    }
//}
//Console.WriteLine($"{min} секунд");
//№ 6
//string[] n = ["win", "loss", "win", "win", "loss"];
//int c = 0;
//int nc = 0;
//for (int i = 0; i < n.Length; i++)
//{
//    if (n[i] == "win".ToLower())
//    {
//        c++;
//    }
//    else
//    {
//        nc++;
//    }
//}
//Console.WriteLine($"Победы - {c}, Поражения - {nc}");
//№ 7
//int[] n = [10, 20, 15, 30, 25];
//int b = 0;
//foreach (int i in n)
//{
//    b += i;
//}
//Console.WriteLine(b/n.Length);
//№ 8
//List<string> n = ["Меч", "Ласточка", "Бомба", "Зелье Гром", "Ласточка"];
//for (int i = 0; i < n.Count; i++)
//{
//    if (n[i] == "Ласточка")
//    {
//        n[i] = "Кошка";
//    }
//    Console.WriteLine("Изменённый инвентарь:");
//    Console.Write($"{n[i]},");
//}
//№ 9
//List<string> k = ["Garrus", "Tali", "Mordin", "Grunt", "Jack"];
//List<string> r = ["Лидер команды", "Техник", "Биотик", "Солдат", "Поддержка"];
//for (int i = 0; i < k.Count; i++)
//{
//    Console.WriteLine($"{r[i]}: {k[i]}");
//}