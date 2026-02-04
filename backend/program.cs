
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Нас зовут Настя и Полина");
// Console.WriteLine(DateTime.Now);


Console.WriteLine("Введите ваше имя:");
string name = Console.ReadLine();
Console.WriteLine($"Привет, {name}!");

Console.WriteLine($"Текущая дата и время: {DateTime.Now}");
Console.WriteLine($"День недели: {DateTime.Now.DayOfWeek}");

Console.WriteLine("Хотите продолжить? (yes/no)");
string answer = Console.ReadLine();

if (answer.ToLower() == "yes")
{
    Console.WriteLine("Продолжаем работу...");
}
else
{
    Console.WriteLine("Завершение работы.");
}