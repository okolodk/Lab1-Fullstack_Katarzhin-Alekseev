// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Менят зовут Алексеев Г.С.");
Console.WriteLine(DateTime.Now);

string name = Console.ReadLine()
Console.WriteLine($"Привет, {name}!")

Console.WriteLine(DateTime.Now.DayOfWeek);

Console.Write("Хотите продолжить? (y/n): ");
string s = Console.ReadLine().Trim().ToLower();

while (true){
    Console.Write("Хотите продолжить? (y/n): ");
    string s = Console.ReadLine().Trim().ToLower();
    if (s == "y"){
        Console.WriteLine("Продолжаем.");
        break;
    }
    else if (s == "n"){
        Console.WriteLine("До свидания!");
        break;
    }
    else{
        Console.WriteLine("Пожалуйста, введите 'y' или 'n'.");
    }
}